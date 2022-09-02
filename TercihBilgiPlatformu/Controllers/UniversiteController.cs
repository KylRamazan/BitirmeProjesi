using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TercihBilgiPlatformu.Controllers
{
  public class UniversiteController : Controller
  {
    private UniversiteManager um = new UniversiteManager(new EFUniversiteRepository());
    public IActionResult Index(int page = 1)
    {
      List<Universite> universiteListe = um.GetList();
      return View(universiteListe.ToPagedList(page, 20));
    }

    [HttpGet]
    public IActionResult YeniUniversiteEkle()
    {
      return View();
    }

    [HttpPost]
    public IActionResult YeniUniversiteEkle(Universite item)
    {
      um.Ekle(item);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UniversiteGuncelle(int id)
    {
      Universite universite = um.GetByID(id);

      return View(universite);
    }

    [HttpPost]
    public IActionResult UniversiteGuncellemeIslemi(Universite universite)
    {
      if (universite != null)
      {
        um.Guncelle(universite);
        return RedirectToAction("Index");
      }
      return View();

    }

    public IActionResult UniversiteSil(int id)
    {
      um.Sil(id);
      return RedirectToAction("Index");
    }
  }
}
