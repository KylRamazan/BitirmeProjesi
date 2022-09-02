using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        Context _ctx = new Context();
        private IKullaniciService _kullaniciService;
        private IUniversiteService _universiteService;
        private IBolumService _bolumService;

        public LoginController(IKullaniciService kullaniciService, IUniversiteService universiteService, IBolumService bolumService)
        {
            _kullaniciService = kullaniciService;
            _universiteService = universiteService;
            _bolumService = bolumService;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(Kullanici kullanici)
        {
            Kullanici value = _ctx.Kullanicis.FirstOrDefault(x => x.EMail == kullanici.EMail && x.Sifre == SHA256.SHA256Sifreleme(kullanici.Sifre));
            Debug.WriteLine(SHA256.SHA256Sifreleme(kullanici.Sifre));

            HttpContext.Session.SetString("kullaniciBilgileri", JsonConvert.SerializeObject(value));

            if (value != null)
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, kullanici.EMail) };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                if (value.EtiketDurumu == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("EtiketSayfasi", "Etiket");
                }

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("SignIn", "Login");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            List<Universite> universiteler = _universiteService.GetList();
            List<Bolum> bolumler = _bolumService.GetList();

            ViewBag.universiteler = universiteler;
            ViewBag.bolumler = bolumler;

            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Kullanici kullanici)
        {
            var value = _ctx.Kullanicis.FirstOrDefault(x => x.EMail == kullanici.EMail && x.Telefon == kullanici.Telefon && x.Silindi == true);

            if (value == null)
            {
                kullanici.Sifre = SHA256.SHA256Sifreleme(kullanici.Sifre);
                _kullaniciService.Ekle(kullanici);

                return RedirectToAction("SignIn", "Login");
            }
            else
            {
                return RedirectToAction("SignUp", "Login");
            }
        }

        [HttpGet]
        public IActionResult Forgot()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Forgot(Kullanici kullanici)
        {
            var value = _ctx.Kullanicis.FirstOrDefault(x => x.EMail == kullanici.EMail && x.Silindi == false);

            if (value != null)
            {
                Random random = new Random();
                int geciciSifre = random.Next(10000, 100000);

                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(kullanici.EMail);
                mailMessage.From = new MailAddress("kayaliramazan.rk@gmail.com", "tercihbilgiplatformu.com");
                mailMessage.Subject = "Yeni Şifreniz";
                mailMessage.Body = "Sayın Kullanıcımız,<br> sistem tarafından oluşturulan şifrenizi: <b>" + geciciSifre + "</b> kullanarak sisteme giriş yapabilir ve daha sonrasında profil ayarları sayfasından şifrenizi değiştirebilirsiniz.<br> İyi günler dileriz...";
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("kayaliramazan.rk@gmail.com", "encqxorkmsklxiic");
                smtpClient.EnableSsl = true;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
                mailMessage.Dispose();

                value.Sifre = SHA256.SHA256Sifreleme(geciciSifre.ToString());
                _kullaniciService.Guncelle(value);

                return RedirectToAction("SignIn", "Login");
            }
            else
            {
                return RedirectToAction("Forgot", "Login");
            }
        }


        [HttpGet]
        public IActionResult PasswordRefresh()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PasswordRefresh(Kullanici kullanici)
        {
            Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));

            var item = _ctx.Kullanicis.FirstOrDefault(x => x.KullaniciID == value.KullaniciID);

            if (item.Sifre == SHA256.SHA256Sifreleme(kullanici.Sifre))
            {
                value.Sifre = SHA256.SHA256Sifreleme(kullanici.YeniSifre);
                _kullaniciService.Guncelle(value);
                ViewBag.durum = true;
            }
            else
            {
                ViewBag.durum = false;
            }
            return View();

        }
    }
}
