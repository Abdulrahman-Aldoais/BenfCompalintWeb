#pragma checksum "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8cfb5e7304fd9389920d77aadc1f59d7f73f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Views\_ViewImports.cshtml"
using BenfCompalintWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8cfb5e7304fd9389920d77aadc1f59d7f73f4a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1514b9a14b3f87aa9c15b50d6f6bf96270b83d90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/vendor/libs/datatables-bs5/datatables.bootstrap5.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Beneficiarie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Complaints", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-brand-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"ar\"\r\n      class=\"light-style\"\r\n      dir=\"rtl\"\r\n      data-theme=\"theme-default\"\r\n      data-assets-path=\"/assets/\"\r\n      data-template=\"vertical-menu-template\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8cfb5e7304fd9389920d77aadc1f59d7f73f4a5792", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport""
          content=""width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0"" />

    <title>Dashboard - Analytics | Frest - Bootstrap Admin Template</title>

    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 488, "\"", 498, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

    <link rel=""icon"" type=""image/x-icon"" href=""/assets/img/favicon/favicon.ico"" />

    <!-- Fonts -->
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link href=""https://fonts.googleapis.com/css2?family=IBM+Plex+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;1,300;1,400;1,500;1,600;1,700&family=Rubik:ital,wght@0,300;0,400;0,500;0,600;0,700;1,300;1,400;1,500;1,600;1,700&display=swap""
          rel=""stylesheet"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de8cfb5e7304fd9389920d77aadc1f59d7f73f4a7046", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- Icons -->
    <link rel=""stylesheet"" href=""/assets/vendor/fonts/boxicons.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/fonts/fontawesome.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/fonts/flag-icons.css"" />

    <!-- Core CSS -->
    <link rel=""stylesheet"" href=""/assets/vendor/css/rtl/core.css"" class=""template-customizer-core-css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/css/rtl/theme-default.css"" class=""template-customizer-theme-css"" />
    <link rel=""stylesheet"" href=""/assets/css/demo.css"" />

    <!-- Vendors CSS -->
    <link rel=""stylesheet"" href=""/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/libs/typeahead-js/typeahead.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/libs/datatables-bs5/datatables.bootstrap5.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/libs/datatables-responsive-bs5/responsive.bootstrap5.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/libs/");
                WriteLiteral("flatpickr/flatpickr.css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8cfb5e7304fd9389920d77aadc1f59d7f73f4a10067", async() => {
                WriteLiteral(@"
    <!-- Layout wrapper -->
    <div class=""layout-wrapper layout-content-navbar"">
        <div class=""layout-container"">
            <!-- Menu -->

            <aside id=""layout-menu"" class=""layout-menu menu-vertical menu bg-menu-theme"">

                <div class=""app-brand demo"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8cfb5e7304fd9389920d77aadc1f59d7f73f4a10648", async() => {
                    WriteLiteral(@"
                        <span class=""app-brand-logo demo"">
                            <svg width=""26px""
                                 height=""26px""
                                 viewBox=""0 0 26 26""
                                 version=""1.1""
                                 xmlns=""http://www.w3.org/2000/svg""
                                 xmlns:xlink=""http://www.w3.org/1999/xlink"">
                                <title>icon</title>
                                <defs>
                                    <linearGradient x1=""50%"" y1=""0%"" x2=""50%"" y2=""100%"" id=""linearGradient-1"">
                                        <stop stop-color=""#5A8DEE"" offset=""0%""></stop>
                                        <stop stop-color=""#699AF9"" offset=""100%""></stop>
                                    </linearGradient>
                                    <linearGradient x1=""0%"" y1=""0%"" x2=""100%"" y2=""100%"" id=""linearGradient-2"">
                                        <stop stop-color=""#FDAC41"" o");
                    WriteLiteral(@"ffset=""0%""></stop>
                                        <stop stop-color=""#E38100"" offset=""100%""></stop>
                                    </linearGradient>
                                </defs>
                                <g id=""Pages"" stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                    <g id=""Login---V2"" transform=""translate(-667.000000, -290.000000)"">
                                        <g id=""Login"" transform=""translate(519.000000, 244.000000)"">
                                            <g id=""Logo"" transform=""translate(148.000000, 42.000000)"">
                                                <g id=""icon"" transform=""translate(0.000000, 4.000000)"">
                                                    <path d=""M13.8863636,4.72727273 C18.9447899,4.72727273 23.0454545,8.82793741 23.0454545,13.8863636 C23.0454545,18.9447899 18.9447899,23.0454545 13.8863636,23.0454545 C8.82793741,23.0454545 4.72727273,18.9447899 4.72727273,13.8863636 C4.727");
                    WriteLiteral(@"27273,13.5423509 4.74623858,13.2027679 4.78318172,12.8686032 L8.54810407,12.8689442 C8.48567157,13.19852 8.45300462,13.5386269 8.45300462,13.8863636 C8.45300462,16.887125 10.8856023,19.3197227 13.8863636,19.3197227 C16.887125,19.3197227 19.3197227,16.887125 19.3197227,13.8863636 C19.3197227,10.8856023 16.887125,8.45300462 13.8863636,8.45300462 C13.5386269,8.45300462 13.19852,8.48567157 12.8689442,8.54810407 L12.8686032,4.78318172 C13.2027679,4.74623858 13.5423509,4.72727273 13.8863636,4.72727273 Z""
                                                          id=""Combined-Shape""
                                                          fill=""#4880EA""></path>
                                                    <path d=""M13.5909091,1.77272727 C20.4442608,1.77272727 26,7.19618701 26,13.8863636 C26,20.5765403 20.4442608,26 13.5909091,26 C6.73755742,26 1.18181818,20.5765403 1.18181818,13.8863636 C1.18181818,13.540626 1.19665566,13.1982714 1.22574292,12.8598734 L6.30410592,12.859962 C6.25499466,13.1951893 6.22958398");
                    WriteLiteral(@",13.5378796 6.22958398,13.8863636 C6.22958398,17.8551125 9.52536149,21.0724191 13.5909091,21.0724191 C17.6564567,21.0724191 20.9522342,17.8551125 20.9522342,13.8863636 C20.9522342,9.91761479 17.6564567,6.70030817 13.5909091,6.70030817 C13.2336969,6.70030817 12.8824272,6.72514561 12.5388136,6.77314791 L12.5392575,1.81561642 C12.8859498,1.78721495 13.2366963,1.77272727 13.5909091,1.77272727 Z""
                                                          id=""Combined-Shape2""
                                                          fill=""url(#linearGradient-1)""></path>
                                                    <rect id=""Rectangle""
                                                          fill=""url(#linearGradient-2)""
                                                          x=""0""
                                                          y=""0""
                                                          width=""7.68181818""
                                                          height=""7.68181818""></");
                    WriteLiteral(@"rect>
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                </g>
                            </svg>
                        </span>
                        <span class=""app-brand-text demo menu-text fw-bold ms-2"" style=""font-size: 21px;"">???????? ??????????????</span>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    <a href=""javascript:void(0);"" class=""layout-menu-toggle menu-link text-large ms-auto"">
                        <i class=""bx menu-toggle-icon fs-4 d-none d-xl-block align-middle""></i>
                        <i class=""bx bx-x bx-sm d-xl-none d-block align-middle""></i>
                    </a>
                </div>


            </aside>


            <!-- / Navbar -->
            <!-- Content wrapper -->
            <!--");
#nullable restore
#line 111 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 112 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Views\Shared\_Layout.cshtml"
       Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"-->
            <!-- Content wrapper -->
            <!--</div>-->
            <!-- / Layout page -->
        </div>

        <!-- Overlay -->
        <div class=""layout-overlay layout-menu-toggle""></div>

        <!-- Drag Target Area To SlideIn Menu On Small Screens -->
        <div class=""drag-target""></div>
    </div>
    <!-- Core JS -->
    <!-- build:js assets/vendor/js/core.js -->
");
                WriteLiteral(@"
    <script src=""/assets/vendor/js/menu.js""></script>
    <!-- endbuild -->
    <!-- Vendors JS -->
    <script src=""/datatables/jquery-3.5.1.js""></script>
    <script src=""/assets/vendor/libs/datatables/jquery.dataTables.js""></script>
    <script src=""/assets/vendor/libs/datatables-bs5/datatables-bootstrap5.js""></script>
    <script src=""/assets/vendor/libs/datatables-responsive/datatables.responsive.js""></script>
    <script src=""/assets/vendor/libs/datatables-responsive-bs5/responsive.bootstrap5.js""></script>
    <!-- Flat Picker -->
    <script src=""/assets/vendor/libs/moment/moment.js""></script>
    <script src=""/assets/vendor/libs/flatpickr/flatpickr.js""></script>

    <!-- Main JS -->
    <script src=""/assets/js/main.js""></script>

    <!-- Page JS -->
    <script src=""/assets/js/tables-datatables-advanced.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
