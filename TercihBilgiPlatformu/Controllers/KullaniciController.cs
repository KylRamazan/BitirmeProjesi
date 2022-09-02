using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TercihBilgiPlatformu.Controllers
{
  public class KullaniciController : Controller
  {
    private KullaniciManager km = new KullaniciManager(new EFKullaniciRepository());
    public IActionResult Index(int page = 1)
    {
      List<Kullanici> kullaniciListe = km.GetList();
      return View(kullaniciListe.ToPagedList(page, 20));
    }

    [HttpGet]
    public IActionResult YeniKullaniciEkle()
    {
      return View();
    }

    [HttpPost]
    public IActionResult YeniKullaniciEkle(Kullanici item)
    {
      km.Ekle(item);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult KullaniciGuncelle(int id)
    {
      Kullanici kullanici = km.GetByID(id);

      return View(kullanici);
    }

    [HttpPost]
    public IActionResult KullaniciGuncellemeIslemi(Kullanici kullanici)
    {
      if (kullanici != null)
      {
        km.Guncelle(kullanici);
        return RedirectToAction("Index");
      }
      return View();

    }

    public IActionResult KullaniciSil(int id)
    {
      km.Sil(id);
      return RedirectToAction("Index");
    }
  }
}
