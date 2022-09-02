using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Controllers
{
  public class YorumController : Controller
  {
    private SoruManager sm = new SoruManager(new EFSoruRepository());
    private CevapManager cm = new CevapManager(new EFCevapRepository());
    Context context = new Context();
    public IActionResult Index(int id)
    {
      Soru soru = sm.GetByID(id);
      List<KullaniciYorumDTO> yorumYapanKullanicilar =
        (from kullanici in context.Kullanicis
         join cevap in context.Cevaps.Where(x => x.SoruId == soru.SoruID)
         on kullanici.KullaniciID equals cevap.KullaniciID
         select new KullaniciYorumDTO
         {
           AdSoyad = kullanici.AdSoyad,
           BolumAdi = kullanici.BolumAdi,
           Mezun = kullanici.Mezun,
           Cinsiyet = kullanici.Cinsiyet,
           Cevap = cevap.Icerik
         }).ToList();

      ViewData["Soru"] = soru;
      ViewData["Kullanici"] = yorumYapanKullanicilar;

      return View();
    }

    [HttpPost]
    public IActionResult YorumYap(Cevap cevap)
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      cevap.KullaniciID = value.KullaniciID;
      cm.Ekle(cevap);
      return RedirectToAction("Index", new { id = cevap.SoruId });
    }
  }
}
