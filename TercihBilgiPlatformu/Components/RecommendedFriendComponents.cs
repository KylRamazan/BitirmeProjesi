using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Components
{
  public class RecommendedFriendComponents : ViewComponent
  {
    private KullaniciManager km = new KullaniciManager(new EFKullaniciRepository());
    public IViewComponentResult Invoke()
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      var veriTabaniKullanici = km.GetByID(value.KullaniciID);
      ArkadasListesi arkadasListesi = new ArkadasListesi();
      return View(arkadasListesi.OnerilenArkadasListesi(veriTabaniKullanici));
    }
  }
}
