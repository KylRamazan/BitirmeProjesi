#pragma checksum "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Universite\YeniUniversiteEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d5a82057084d7c6b4038ec5dc31c373c9231f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Universite_YeniUniversiteEkle), @"mvc.1.0.view", @"/Views/Universite/YeniUniversiteEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d5a82057084d7c6b4038ec5dc31c373c9231f5", @"/Views/Universite/YeniUniversiteEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ed2d02e85b3bf5308a89a7f32067c0147ede3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Universite_YeniUniversiteEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Universite>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Universite\YeniUniversiteEkle.cshtml"
  
  ViewData["Title"] = "YeniUniversite";
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-top:75px;"" class=""login-container order-2 order-lg-1 flex-center flex-row-fluid px-7 pt-lg-0 pb-lg-0 pt-4 pb-6 bg-white"">
  <div class=""login-content d-flex flex-column pt-lg-0 pt-12"">
    <!--begin::Signin-->
    <div class=""login-form"">
      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d5a82057084d7c6b4038ec5dc31c373c9231f54603", async() => {
                WriteLiteral("\r\n        <br />\r\n        <div class=\"form-group\">\r\n          <label class=\"font-size-h6 font-weight-bolder text-dark\">Üniversite Adı</label>\r\n          ");
#nullable restore
#line 15 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Universite\YeniUniversiteEkle.cshtml"
     Write(Html.TextBoxFor(x => x.Ad, new { @class = "form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n          <br />\r\n        </div>\r\n        <label class=\"font-size-h6 font-weight-bolder text-dark\">Bölüm</label>\r\n        ");
#nullable restore
#line 19 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Universite\YeniUniversiteEkle.cshtml"
   Write(Html.TextBoxFor(x => x.Bolumler, new { @class = "form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label class=\"font-size-h6 font-weight-bolder text-dark\">Silinme Durumu</label>\r\n        ");
#nullable restore
#line 22 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Universite\YeniUniversiteEkle.cshtml"
   Write(Html.TextBoxFor(x => x.Silindi, new { @class = "form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <button class=\"btn btn-primary\">Kaydet</button>\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Universite> Html { get; private set; }
    }
}
#pragma warning restore 1591