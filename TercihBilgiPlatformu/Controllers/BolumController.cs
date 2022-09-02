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
  public class BolumController : Controller
  {

    private BolumManager bm = new BolumManager(new EFBolumRepository());
    public IActionResult Index(int page = 1)
    {
      List<Bolum> bolumListe = bm.GetList();
      return View(bolumListe.ToPagedList(page, 20));
    }

    [HttpGet]
    public IActionResult YeniBolumEkle()
    {
      return View();
    }

    [HttpPost]
    public IActionResult YeniBolumEkle(Bolum item)
    {
      bm.Ekle(item);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult BolumGuncelle(int id)
    {
      Bolum bolum = bm.GetByID(id);
      
      return View(bolum);
    }

    [HttpPost]
    public IActionResult BolumGuncellemeIslemi(Bolum bolum)
    {
      if (bolum != null)
      {
        bm.Guncelle(bolum);
        return RedirectToAction("Index");
      }
      return View();
      
    }

    public IActionResult BolumSil(int id)
    {
      bm.Sil(id);
      return RedirectToAction("Index");
    }
  }
}
