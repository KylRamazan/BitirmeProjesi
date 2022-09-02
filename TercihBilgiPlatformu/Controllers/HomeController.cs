using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TercihBilgiPlatformu.Models;

namespace TercihBilgiPlatformu.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    Context context = new Context();
    private IMemoryCache _cache;
    private SoruManager cm = new SoruManager(new EFSoruRepository());


    public HomeController(ILogger<HomeController> logger, IMemoryCache cache)
    {
      _logger = logger;
      _cache = cache;
    }

    public IActionResult Index()
    {
      
      TempData["sorular"] = _cache.Get<List<Soru>>("sorular");
      return View();
    }

    public IActionResult OnerilenSorular()
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      var item = context.Kullanicis.FirstOrDefault(x => x.KullaniciID == value.KullaniciID);

      StreamWriter yaz = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/dosya.txt");
      yaz.Write(item.UniversiteEtiketi + "," + item.IlgiAlaniEtiketi);
      yaz.Close();

      //Process.Start("cmd.exe", "/k" + "python C:\\Users\\zeuss\\PycharmProjects\\pythonProject\\main.py");

      System.Threading.Thread.Sleep(1000);

      StreamReader oku = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/veriler.txt");
      var gelenVeri = oku.ReadToEnd().Split(',');

      List<Soru> sorular = new List<Soru>();

      foreach (var id in gelenVeri)
      {
        if (id != "")
        {
          sorular.Add(context.Sorus.FirstOrDefault(x => x.SoruID == Convert.ToInt32(id)));
        }
      }

      var cacheSorular = _cache.Get<List<Soru>>("sorular");

      if (cacheSorular!=null)
      {
        _cache.Remove("sorular");
      }

      _cache.Set("sorular", sorular);
      return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult SoruEkle(Soru soru)
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      soru.KullaniciID = value.KullaniciID;
      soru.UniversiteEtiketi = 1;
      soru.IlgiAlaniEtiketi = 2;
      cm.Ekle(soru);
      return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
