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
  public class EtiketController : Controller
  {
    private EtiketManager em = new EtiketManager(new EFEtiketRepository());
    public IActionResult Index(int page = 1)
    {
      List<Etiket> etiketListe = em.GetList();
      return View(etiketListe.ToPagedList(page, 20));
    }

    public IActionResult EtiketSayfasi()
    {
      return View();
    }

    [HttpGet]
    public IActionResult YeniEtiketEkle()
    {
      return View();
    }

    [HttpPost]
    public IActionResult YeniEtiketEkle(Etiket item)
    {
      em.Ekle(item);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult EtiketGuncelle(int id)
    {
      Etiket etiket = em.GetByID(id);

      return View(etiket);
    }

    [HttpPost]
    public IActionResult EtiketGuncellemeIslemi(Etiket etiket)
    {
      if (etiket != null)
      {
        em.Guncelle(etiket);
        return RedirectToAction("Index");
      }
      return View();

    }

    public IActionResult EtiketSil(int id)
    {
      em.Sil(id);
      return RedirectToAction("Index");
    }
  }
}
