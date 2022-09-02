using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TercihBilgiPlatformu.Controllers
{
  public class ArkadasController : Controller
  {
    private KullaniciManager km = new KullaniciManager(new EFKullaniciRepository());
    public IActionResult Index(int page = 1)
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      var veriTabaniKullanici = km.GetByID(value.KullaniciID);

      ArkadasListesi arkadasListesi = new ArkadasListesi();
      List<Kullanici> kullaniciListe = arkadasListesi.ArkadasListesiParcala(veriTabaniKullanici);
      arkadasListesi.OnerilenArkadasListesi(veriTabaniKullanici);
      return View(kullaniciListe.ToPagedList(page, 6));
    }

    public IActionResult ArkadasCikar(int id)
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      var veriTabaniKullanici = km.GetByID(value.KullaniciID);
      var parcalar = veriTabaniKullanici.Arkadaslar.Split(',');
      string arkadaslar = "";
      foreach (var item in parcalar)
      {
        if (item != "" && Convert.ToInt32(item) != id)
        {
          arkadaslar += item.ToString() + ",";
        }
      }
      veriTabaniKullanici.Arkadaslar = arkadaslar;
      km.Guncelle(veriTabaniKullanici);
      return RedirectToAction("Index");
    }

    public IActionResult ArkadasEkle(int id)
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      var veriTabaniKullanici = km.GetByID(value.KullaniciID);

      veriTabaniKullanici.Arkadaslar += id.ToString() + ",";
      km.Guncelle(veriTabaniKullanici);
      return RedirectToAction("Index");
    }
  }
}
