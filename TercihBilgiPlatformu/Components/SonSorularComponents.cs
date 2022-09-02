using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Components
{
  public class SonSorularComponents : ViewComponent
  {
    Context context = new Context();
    public IViewComponentResult Invoke()
    {
      var sonSorular = context.Sorus.Where(x => x.Silindi == false).ToList().OrderByDescending(x => x.SoruID).Take(5);

      List<Soru> sorular = new List<Soru>();
      foreach (var item in sonSorular)
      {
        sorular.Add(item);
      }
      return View(sorular);
    }
  }
}
