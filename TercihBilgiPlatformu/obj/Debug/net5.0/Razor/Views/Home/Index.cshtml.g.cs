#pragma checksum "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "592b45a38ea0c62d1d488f63c213f8de8a164bb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592b45a38ea0c62d1d488f63c213f8de8a164bb3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ed2d02e85b3bf5308a89a7f32067c0147ede3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("kt_login_yorumYapma_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/SoruEkle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/custom/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/custom/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";
  var sorular = (List<Soru>)TempData["sorular"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--begin::Container-->
<div class=""container"">
  <!--begin::Dashboard-->
  <!--begin::Row-->
  <div class=""row mt-0 mt-lg-8"">
    <div class=""col-xl-12"">
      <!--begin::Charts Widget 5-->
      <!--begin::Card-->
      <div class=""card card-custom gutter-b"">
        <!--begin::Card header-->
        <div class=""card-header h-auto border-0"">
          <div style=""margin:25px;"" class=""login-container order-2 order-lg-1 flex-center flex-row-fluid px-7 pt-lg-0 pb-lg-0 pt-4 pb-6 bg-white"">
            <!--begin::Wrapper-->
            <div class=""login-content d-flex flex-column pt-lg-0 pt-12"">
              <!--begin::Signin-->
              <div class=""login-form"">
                <!--begin::Form-->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "592b45a38ea0c62d1d488f63c213f8de8a164bb37125", async() => {
                WriteLiteral(@"
                  <!--begin::Form group-->
                  <div class=""form-group"">
                    <label class=""font-size-h6 font-weight-bolder text-dark pt-5"">Sorunuzu Yazınız</label>
                    <textarea class=""form-control form-control-solid h-auto py-7 px-6 rounded-lg border-0"" cols=""40"" rows=""5"" name=""Icerik"" autocomplete=""off""></textarea>
                  </div>
                  <!--end::Form group-->

                  <div class=""form-group"">
                    <label class=""font-size-h6 font-weight-bolder text-dark pt-5"">Üniversite Etiketi Seçiniz</label>
                    <div class=""tag-wrapper unselected form-control  h-auto py-7 px-6 rounded-lg border-0"">
                      <div class=""tag-item"" data-id=""1"">Karadeniz Teknik Üniversitesi</div>
                      <div class=""tag-item"" data-id=""2"">Hitit Üniversitesi</div>
                      <div class=""tag-item"" data-id=""3"">Ankara Üniversitesi</div>
                      <div class=""tag-item"" data-id=""4""");
                WriteLiteral(@">Orta Doğu Teknik Üniversitesi</div>
                      <div class=""tag-item"" data-id=""5"">Hacettepe Üniversitesi</div>
                    </div><br />
                    <label class=""font-size-h6 font-weight-bolder text-dark pt-5"">Sorunuz İle İlgili Etiketi Seçiniz</label>
                    <div class=""tag-wrapper unselected form-control  h-auto py-7 px-6 rounded-lg border-0"">
                      <div class=""tag-item"" data-id=""10"">Akademik Kadro</div>
                      <div class=""tag-item"" data-id=""11"">Eğitim Kalitesi</div>
                      <div class=""tag-item"" data-id=""12"">Yaşam Standartları</div>
                      <div class=""tag-item"" data-id=""13"">Kültür</div>
                    </div>
                    <label class=""font-size-h6 font-weight-bolder text-dark pt-5"">Seçili Etiketler</label>
                    <div class=""tag-wrapper selected form-control h-auto py-7 px-6 rounded-lg border-0"">
                    </div>
                  </div>

                  <!");
                WriteLiteral(@"--begin::Action-->
                  <div class=""pb-lg-0 pb-5"">
                    <button type=""submit"" class=""btn btn-primary font-weight-bolder font-size-h6 px-8 py-4 my-3 mr-3"">Soruyu Sor</button>
                  </div>
                  <!--end::Action-->
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <!--end::Form-->
              </div>
              <!--end::Signin-->
            </div>
            <!--end::Wrapper-->
          </div>
        </div>
        <!--end:: Card header-->
      </div>
      <!--end:: Card-->
      <!--end:: Charts Widget 5-->
    </div>
  </div>
  <!--end::Row-->

  <a href=""/Home/OnerilenSorular"" class=""btn btn-primary font-weight-bolder font-size-h6 px-8 py-4 my-3 mr-3"">Önerilen Soruları Listele</a>

  <!--begin::Row-->
  <div class=""row mt-0 mt-lg-8"">
    <div class=""col-xl-12"">
      <!--begin::Charts Widget 5-->
      <!--begin::Card-->
      <div class=""card card-custom gutter-b"">
        <!--begin::Card header-->
        <div class=""card-header h-auto border-0"">
          <div class=""card-title py-5"">
            <h3 class=""card-label"">
              <span class=""d-block text-dark font-weight-bolder"">Önerilen Sorular</span>
              <span class=""d-block text-muted mt-2 font-size-sm"">İlgi Alanlarınıza Göre Listelenen Sor");
            WriteLiteral(@"ular</span>
            </h3>
          </div>
        </div>
        <!--end:: Card header-->
        <!--begin::Card body-->
        <div class=""card-body"">
          <div class=""row"">
            <div class=""tab-content mt-5"" id=""myTabTables5"">
              <!--begin::Tap pane-->
              <div class=""tab-pane fade show active"" id=""kt_tab_pane_5_3"" role=""tabpanel"" aria-labelledby=""kt_tab_pane_5_3"">
                <!--begin::Table-->
                <div class=""table-responsive"">
                  <table class=""table table-borderless table-vertical-center"">
                    <thead>
                      <tr>
                        <th class=""p-0 w-50px""></th>
                        <th class=""p-0 min-w-350px""></th>
                        <th class=""p-0 min-w-250px""></th>
                        <th class=""p-0 min-w-150px""></th>
                        <th class=""p-0 min-w-50px""></th>
                      </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 112 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                       if (sorular != null)
                      {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                         foreach (var item in sorular)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\r\n                            <td class=\"py-5 pl-0\">\r\n                              <div class=\"symbol symbol-50 symbol-light mr-2\">\r\n                                <span class=\"symbol-label\">\r\n");
#nullable restore
#line 120 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                                   if (item.IlgiAlaniEtiketi == 1)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <img src=\"/assets/media/svg/misc/008-infography.svg\" class=\"h-50 align-self-center\"");
            BeginWriteAttribute("alt", " alt=\"", 5939, "\"", 5945, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 123 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                                  }
                                  else if (item.IlgiAlaniEtiketi == 2)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"/assets/media/svg/misc/003-puzzle.svg\" class=\"h-50 align-self-center\"");
            BeginWriteAttribute("alt", " alt=\"", 6208, "\"", 6214, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 127 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                                  }
                                  else if (item.IlgiAlaniEtiketi == 3)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"/assets/media/svg/misc/009-hot-air-balloon.svg\" class=\"h-50 align-self-center\"");
            BeginWriteAttribute("alt", " alt=\"", 6486, "\"", 6492, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 131 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                                  }
                                  else if (item.IlgiAlaniEtiketi == 4)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"/assets/media/svg/misc/013-rgb.svg\" class=\"h-50 align-self-center\"");
            BeginWriteAttribute("alt", " alt=\"", 6752, "\"", 6758, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 135 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                              </div>\r\n                            </td>\r\n                            <td class=\"pl-0\">\r\n                              <a");
            BeginWriteAttribute("href", " href=\"", 6994, "\"", 7026, 2);
            WriteAttributeValue("", 7001, "/Yorum/Index/", 7001, 13, true);
#nullable restore
#line 140 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
WriteAttributeValue("", 7014, item.SoruID, 7014, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark font-weight-bolder text-hover-primary mb-1 font-size-lg\">");
#nullable restore
#line 140 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                                                                                                                                       Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n");
#nullable restore
#line 143 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                               if (item.UniversiteEtiketi == 1)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-dark label-inline\">Karadeniz Teknik Üniversitesi</span>\r\n");
#nullable restore
#line 146 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }
                              else if (item.UniversiteEtiketi == 2)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-dark label-inline\">Hitit Üniversitesi</span>\r\n");
#nullable restore
#line 150 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }
                              else if (item.UniversiteEtiketi == 3)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-dark label-inline\">Ankara Üniversitesi</span>\r\n");
#nullable restore
#line 154 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }
                              else if (item.UniversiteEtiketi == 4)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-dark label-inline\">Orta Doğu Teknik Üniversitesi</span>\r\n");
#nullable restore
#line 158 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n");
#nullable restore
#line 162 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                               if (item.IlgiAlaniEtiketi == 1)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-danger label-inline\">Akademik Kadro</span>\r\n");
#nullable restore
#line 165 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }
                              else if (item.IlgiAlaniEtiketi == 2)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-success label-inline\">Eğitim Kalitesi</span>\r\n");
#nullable restore
#line 169 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }
                              else if (item.IlgiAlaniEtiketi == 3)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-warning label-inline\">Yaşam Standartları</span>\r\n");
#nullable restore
#line 173 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }
                              else if (item.IlgiAlaniEtiketi == 4)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-lg label-light-info label-inline\">Kültür</span>\r\n");
#nullable restore
#line 177 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td class=\"text-right pr-0\">\r\n                              <a");
            BeginWriteAttribute("href", " href=\"", 9449, "\"", 9481, 2);
            WriteAttributeValue("", 9456, "/Yorum/Index/", 9456, 13, true);
#nullable restore
#line 180 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
WriteAttributeValue("", 9469, item.SoruID, 9469, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-icon btn-light btn-sm"">
                                <span class=""svg-icon svg-icon-md svg-icon-success"">
                                  <!--begin::Svg Icon | path:/assets/media/svg/icons/Navigation/Arrow-right.svg-->
                                  <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                                    <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                      <polygon points=""0 0 24 0 24 24 0 24"" />
                                      <rect fill=""#000000"" opacity=""0.3"" transform=""translate(12.000000, 12.000000) rotate(-90.000000) translate(-12.000000, -12.000000)"" x=""11"" y=""5"" width=""2"" height=""14"" rx=""1"" />
                                      <path d=""M9.70710318,15.7071045 C9.31657888,16.0976288 8.68341391,16.0976288 8.29288961,15.7071045 C7.90236532,15.3165802 7.90236532,14.6834152 8.29288961,14.29289");
            WriteLiteral(@"09 L14.2928896,8.29289093 C14.6714686,7.914312 15.281055,7.90106637 15.675721,8.26284357 L21.675721,13.7628436 C22.08284,14.136036 22.1103429,14.7686034 21.7371505,15.1757223 C21.3639581,15.5828413 20.7313908,15.6103443 20.3242718,15.2371519 L15.0300721,10.3841355 L9.70710318,15.7071045 Z"" fill=""#000000"" fill-rule=""nonzero"" transform=""translate(14.999999, 11.999997) scale(1, -1) rotate(90.000000) translate(-14.999999, -11.999997)"" />
                                    </g>
                                  </svg>
                                  <!--end::Svg Icon-->
                                </span>
                              </a>
                            </td>
                          </tr>
");
#nullable restore
#line 195 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\Ramazan\source\repos\TercihBilgiPlatformu\TercihBilgiPlatformu\Views\Home\Index.cshtml"
                         
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                  </table>
                </div>
                <!--end::Table-->
              </div>
              <!--end::Tap pane-->
            </div>
          </div>
        </div>
        <!--end:: Card body-->
      </div>
      <!--end:: Card-->
      <!--end:: Charts Widget 5-->
    </div>
  </div>
  <!--end::Row-->
  <!--end::Dashboard-->
</div>
<!--end::Container-->


");
            DefineSection("CustomStyles", async() => {
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "592b45a38ea0c62d1d488f63c213f8de8a164bb325756", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("CustomJs", async() => {
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "592b45a38ea0c62d1d488f63c213f8de8a164bb327090", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591