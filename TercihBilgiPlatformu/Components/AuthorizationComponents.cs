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
  public class AuthorizationComponents : ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      Kullanici value = JsonConvert.DeserializeObject<Kullanici>(HttpContext.Session.GetString("kullaniciBilgileri"));
      return View(value);
    }
  }
}
