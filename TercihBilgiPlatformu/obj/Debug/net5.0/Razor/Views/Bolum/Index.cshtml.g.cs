#pragma checksum "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d365410ab5621bc566c56e137d226cac5f388366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bolum_Index), @"mvc.1.0.view", @"/Views/Bolum/Index.cshtml")]
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
#line 1 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d365410ab5621bc566c56e137d226cac5f388366", @"/Views/Bolum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ed2d02e85b3bf5308a89a7f32067c0147ede3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Bolum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Bolum>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
  
  ViewData["Title"] = "Index";
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""overflow:auto; margin:20px auto 20px auto;"">
  <table class=""table table-hover"">
    <thead>
      <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">B??L??M ADI</th>
        <th scope=""col"">DURUM</th>
        <th scope=""col"">KAYIT TAR??H??</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n          <td>");
#nullable restore
#line 27 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
         Write(item.BolumID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 28 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
         Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n");
#nullable restore
#line 30 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
             if (item.Silindi == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <span class=\"kt-badge  kt-badge--success kt-badge--inline kt-badge--pill\">AKT??F</span>\r\n");
#nullable restore
#line 33 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <span class=\"kt-badge  kt-badge--danger kt-badge--inline kt-badge--pill\">PAS??F</span>\r\n");
#nullable restore
#line 37 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </td>\r\n          <td>");
#nullable restore
#line 39 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
         Write(item.KayitTarihi.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td><a");
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1130, 2);
            WriteAttributeValue("", 1101, "/Bolum/BolumSil/", 1101, 16, true);
#nullable restore
#line 40 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
WriteAttributeValue("", 1117, item.BolumID, 1117, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n          <td><a");
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1226, 2);
            WriteAttributeValue("", 1192, "/Bolum/BolumGuncelle/", 1192, 21, true);
#nullable restore
#line 41 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
WriteAttributeValue("", 1213, item.BolumID, 1213, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">G??NCELLE</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n  <div style=\"margin:15px;\">\r\n    ");
#nullable restore
#line 48 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Bolum\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page }),
      new PagedListRenderOptions
      {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
      }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n  <div style=\"margin:10px; float:right;\"><a href=\"\\Bolum\\YeniBolumEkle\" class=\"btn btn-primary\">B??l??m Ekle</a></div>\r\n  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Bolum>> Html { get; private set; }
    }
}
#pragma warning restore 1591
