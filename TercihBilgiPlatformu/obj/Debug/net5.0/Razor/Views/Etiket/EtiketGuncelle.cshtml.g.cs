#pragma checksum "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34f6a5773e46bb934d53f0abb53c4940a2c01e33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Etiket_EtiketGuncelle), @"mvc.1.0.view", @"/Views/Etiket/EtiketGuncelle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f6a5773e46bb934d53f0abb53c4940a2c01e33", @"/Views/Etiket/EtiketGuncelle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ed2d02e85b3bf5308a89a7f32067c0147ede3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Etiket_EtiketGuncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Etiket>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml"
  
  ViewData["Title"] = "EtiketGuncelle";
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-top:75px;"" class=""login-container order-2 order-lg-1 flex-center flex-row-fluid px-7 pt-lg-0 pb-lg-0 pt-4 pb-6 bg-white"">
  <div class=""login-content d-flex flex-column pt-lg-0 pt-12"">
    <!--begin::Signin-->
    <div class=""login-form"">
      <br />
");
#nullable restore
#line 13 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml"
       using (Html.BeginForm("EtiketGuncellemeIslemi", "Etiket", FormMethod.Post))
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label class=\"font-size-h6 font-weight-bolder text-dark\">Etiket ID</label>\r\n");
#nullable restore
#line 16 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml"
   Write(Html.TextBoxFor(x => x.EtiketID, new { @class = "form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label class=\"font-size-h6 font-weight-bolder text-dark\">Etiket Adı</label>\r\n");
#nullable restore
#line 19 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml"
   Write(Html.TextBoxFor(x => x.Adi, new { @class = "form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label class=\"font-size-h6 font-weight-bolder text-dark\">Silinme Durumu</label>\r\n");
#nullable restore
#line 22 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml"
   Write(Html.TextAreaFor(x => x.Silindi, new { @class = "form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <button class=\"btn btn-primary\">Güncelle</button>\r\n");
#nullable restore
#line 25 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Etiket\EtiketGuncelle.cshtml"

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Etiket> Html { get; private set; }
    }
}
#pragma warning restore 1591