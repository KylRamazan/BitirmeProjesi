#pragma checksum "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5202517e6eef4dde53c11981482d3e6accedf9c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanici_Index), @"mvc.1.0.view", @"/Views/Kullanici/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\_ViewImports.cshtml"
using TercihBilgiPlatformu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\_ViewImports.cshtml"
using TercihBilgiPlatformu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5202517e6eef4dde53c11981482d3e6accedf9c6", @"/Views/Kullanici/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ed2d02e85b3bf5308a89a7f32067c0147ede3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Kullanici_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Kullanici>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
  
  ViewData["Title"] = "Index";
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""overflow:auto; margin-left:10px; margin-right:10px;"">
  <table class=""table table-hover"">
    <thead>
      <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">ADI SOYADI</th>
        <th scope=""col"">CİNSİYET</th>
        <th scope=""col"">DOĞUM TARİHİ</th>
        <th scope=""col"">OKUL ADI</th>
        <th scope=""col"">BÖLÜM ADI</th>
        <th scope=""col"">MEZUN DURUMU</th>
        <th scope=""col"">E-MAİL</th>
        <th scope=""col"">TELEFON</th>
        <th scope=""col"">KULLANICI ADI</th>
        <th scope=""col"">DURUM</th>
        <th scope=""col"">KAYIT TARİHİ</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 33 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.KullaniciID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 34 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.KullaniciAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 35 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.Cinsiyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 36 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.DogumTarihi.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 37 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.OkulAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 38 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.BolumAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n");
#nullable restore
#line 40 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
             if (item.Mezun == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <span class=\"kt-badge  kt-badge--success kt-badge--inline kt-badge--pill\">AKTİF</span>\r\n");
#nullable restore
#line 43 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <span class=\"kt-badge  kt-badge--danger kt-badge--inline kt-badge--pill\">PASİF</span>\r\n");
#nullable restore
#line 47 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n          <td>");
#nullable restore
#line 49 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.EMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 50 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 51 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.KullaniciAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n");
#nullable restore
#line 53 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
             if (item.Silindi == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <span class=\"kt-badge  kt-badge--success kt-badge--inline kt-badge--pill\">AKTİF</span>\r\n");
#nullable restore
#line 56 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <span class=\"kt-badge  kt-badge--danger kt-badge--inline kt-badge--pill\">PASİF</span>\r\n");
#nullable restore
#line 60 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n          <td>");
#nullable restore
#line 62 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
         Write(item.KayitTarihi.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td><a");
            BeginWriteAttribute("href", " href=\"", 2066, "\"", 2114, 2);
            WriteAttributeValue("", 2073, "/Kullanici/KullaniciSil/", 2073, 24, true);
#nullable restore
#line 63 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
WriteAttributeValue("", 2097, item.KullaniciID, 2097, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n          <td><a");
            BeginWriteAttribute("href", " href=\"", 2169, "\"", 2222, 2);
            WriteAttributeValue("", 2176, "/Kullanici/KullaniciGuncelle/", 2176, 29, true);
#nullable restore
#line 64 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
WriteAttributeValue("", 2205, item.KullaniciID, 2205, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">GÜNCELLE</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n  <div>\r\n    ");
#nullable restore
#line 70 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Kullanici\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page }),
      new PagedListRenderOptions
      {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
      }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n  <div><a href=\"\\Kullanici\\YeniKullaniciEkle\" class=\"btn btn-primary\">Kullanıcı Ekle</a></div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Kullanici>> Html { get; private set; }
    }
}
#pragma warning restore 1591
