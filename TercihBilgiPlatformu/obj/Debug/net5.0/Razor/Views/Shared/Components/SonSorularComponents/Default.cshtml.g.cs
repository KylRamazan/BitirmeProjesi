#pragma checksum "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c30175f14a51c2b4937d8ee8d5e0213663aea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SonSorularComponents_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SonSorularComponents/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c30175f14a51c2b4937d8ee8d5e0213663aea8", @"/Views/Shared/Components/SonSorularComponents/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ed2d02e85b3bf5308a89a7f32067c0147ede3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SonSorularComponents_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Soru>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
   
  int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--begin::List Widget 9-->
<div class=""card card-custom card-shadowless bg-white gutter-b"">
  <!--begin::Header-->
  <div class=""card-header align-items-center border-0 mt-4"">
    <h3 class=""card-title align-items-start flex-column"">
      <span class=""font-weight-bolder text-dark"">Sorulan Sorular</span>
      <span class=""text-muted mt-3 font-weight-bold font-size-sm"">Sorulan Son 5 Soru</span>
    </h3>
  </div>
  <!--end::Header-->
  <!--begin::Body-->
  <div class=""card-body pt-4"">
    <!--begin::Timeline-->
    <div class=""timeline timeline-2 mt-3"">

");
#nullable restore
#line 21 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
       foreach (var item in Model)
      {
        sayac++;
        if (sayac == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <!--begin::Item-->
          <div class=""timeline-item align-items-start"">
            <!--begin::Badge-->
            <div class=""timeline-badge"">
              <i class=""fa fa-genderless text-warning icon-xl""></i>
            </div>
            <!--end::Badge-->
            <!--begin::Text-->
            <div class=""timeline-content font-weight-bolder font-size-lg text-dark-75 pl-3""><a");
            BeginWriteAttribute("href", " href=\"", 1152, "\"", 1184, 2);
            WriteAttributeValue("", 1159, "/Yorum/Index/", 1159, 13, true);
#nullable restore
#line 34 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
WriteAttributeValue("", 1172, item.SoruID, 1172, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
                                                                                                                           Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            <!--end::Text-->\r\n          </div>\r\n          <!--end::Item-->\r\n");
#nullable restore
#line 38 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
        }
        else if (sayac == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <!--begin::Item-->
          <div class=""timeline-item align-items-start"">
            <!--begin::Badge-->
            <div class=""timeline-badge"">
              <i class=""fa fa-genderless text-success icon-xl""></i>
            </div>
            <!--end::Badge-->
            <!--begin::Content-->
            <div class=""timeline-content font-weight-bolder font-size-lg text-dark-75 pl-3""><a");
            BeginWriteAttribute("href", " href=\"", 1749, "\"", 1781, 2);
            WriteAttributeValue("", 1756, "/Yorum/Index/", 1756, 13, true);
#nullable restore
#line 49 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
WriteAttributeValue("", 1769, item.SoruID, 1769, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
                                                                                                                           Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            <!--end::Content-->\r\n          </div>\r\n          <!--end::Item-->\r\n");
#nullable restore
#line 53 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
        }
        else if (sayac == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <!--begin::Item-->
          <div class=""timeline-item align-items-start"">
            <!--begin::Badge-->
            <div class=""timeline-badge"">
              <i class=""fa fa-genderless text-info icon-xl""></i>
            </div>
            <!--end::Badge-->
            <!--begin::Desc-->
            <div class=""timeline-content font-weight-bolder font-size-lg text-dark-75 pl-3""><a");
            BeginWriteAttribute("href", " href=\"", 2343, "\"", 2375, 2);
            WriteAttributeValue("", 2350, "/Yorum/Index/", 2350, 13, true);
#nullable restore
#line 64 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
WriteAttributeValue("", 2363, item.SoruID, 2363, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
                                                                                                                           Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            <!--end::Desc-->\r\n          </div>\r\n          <!--end::Item-->\r\n");
#nullable restore
#line 68 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
        }
        else if (sayac == 4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <!--begin::Item-->
          <div class=""timeline-item align-items-start"">
            <!--begin::Badge-->
            <div class=""timeline-badge"">
              <i class=""fa fa-genderless text-primary icon-xl""></i>
            </div>
            <!--end::Badge-->
            <!--begin::Text-->
            <div class=""timeline-content font-weight-bolder font-size-lg text-dark-75 pl-3""><a");
            BeginWriteAttribute("href", " href=\"", 2937, "\"", 2969, 2);
            WriteAttributeValue("", 2944, "/Yorum/Index/", 2944, 13, true);
#nullable restore
#line 79 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
WriteAttributeValue("", 2957, item.SoruID, 2957, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
                                                                                                                           Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            <!--end::Text-->\r\n          </div>\r\n          <!--end::Item-->\r\n");
#nullable restore
#line 83 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
        }
        else if (sayac == 5)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <!--begin::Item-->
          <div class=""timeline-item align-items-start"">
            <!--begin::Badge-->
            <div class=""timeline-badge"">
              <i class=""fa fa-genderless text-danger icon-xl""></i>
            </div>
            <!--end::Badge-->
            <!--begin::Desc-->
            <div class=""timeline-content font-weight-bolder text-dark-75 pl-3 font-size-lg""><a");
            BeginWriteAttribute("href", " href=\"", 3530, "\"", 3562, 2);
            WriteAttributeValue("", 3537, "/Yorum/Index/", 3537, 13, true);
#nullable restore
#line 94 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
WriteAttributeValue("", 3550, item.SoruID, 3550, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
                                                                                                                           Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            <!--end::Desc-->\r\n          </div>\r\n          <!--end::Item-->\r\n");
#nullable restore
#line 98 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Shared\Components\SonSorularComponents\Default.cshtml"
        }

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <!--end::Timeline-->\r\n  </div>\r\n  <!--end: Card Body-->\r\n</div>\r\n<!--end: List Widget 9-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Soru>> Html { get; private set; }
    }
}
#pragma warning restore 1591
