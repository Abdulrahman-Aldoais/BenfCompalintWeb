#pragma checksum "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\AddNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "558124cf5746e7ffa23e790728568a2ec7d75ad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Beneficiarie_Views_Complaints_AddNote), @"mvc.1.0.view", @"/Areas/Beneficiarie/Views/Complaints/AddNote.cshtml")]
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
#line 1 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using BenfCompalintWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Areas.Beneficiarie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558124cf5746e7ffa23e790728568a2ec7d75ad5", @"/Areas/Beneficiarie/Views/Complaints/AddNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba365b73717a071cd11ab6cbd38d253b5fa5c83", @"/Areas/Beneficiarie/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Beneficiarie_Views_Complaints_AddNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAccountSettings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"


<div class=""content-wrapper"">
    <!-- Content -->

    <div class=""container-xxl flex-grow-1 container-p-y"">
        <h4 class=""breadcrumb-wrapper py-3 mb-4"">
            <span class=""text-muted fw-light"">????????????????????    /</span> ?????????? ????????????????
        </h4>

        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""nav nav-pills flex-column flex-md-row mb-3"">
                </ul>
                <div class=""card mb-4"">
                    <h5 class=""card-header"">?????????? ????????????????  </h5>
                    <!-- Account -->
                    <div class=""card-body"">
                        <div class=""gap-4 d-flex align-items-start align-items-sm-center"">

                            <div class=""button-wrapper"">


                            </div>
                        </div>
                    </div>
                    <hr class=""my-0"" />
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "558124cf5746e7ffa23e790728568a2ec7d75ad55883", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-6 mb-3"">
                                    <label for=""firstName"" class=""form-label"">?????????? ????????????????</label>
                                    <input class=""form-control""
                                           type=""text""
                                           id=""firstName""
                                           name=""??????????""
                                           value=""?????????? ????????????????""
                                           autofocus />
                                </div>
                                <div class=""col-md-6 mb-3"">
                                    <label for=""lastName"" class=""form-label"">?????????? ????????????????</label>
                                    <input class=""form-control"" type=""text"" name=""lastName"" id=""lastName"" value=""?????????? ???????????????? "" />
                                </div>





                                <div class=""col-md-6 mb-3"">
    ");
                WriteLiteral(@"                                <label for=""email"" class=""form-label"">?????????? ????????????</label>
                                    <input class=""form-control""
                                           type=""text""
                                           id=""email""
                                           name=""?????????? ????????????""
                                           value=""548452215552 ""
                                           placeholder=""john.doe@example.com"" />
                                </div>
                                <div class=""col-md-6 mb-3"">
                                    <label for=""currency"" class=""form-label"">?????????????? ??????????????</label>
                                    <input class=""form-control"" type=""file"" id=""formFile"">
                                </div>

                            </div>
                            <div class=""mt-2"">
                                <button type=""submit"" class=""btn btn-primary me-2"">?????????? ???????????????? </button>
              ");
                WriteLiteral("                  <button type=\"reset\" class=\"btn btn-label-secondary\">??????????</button>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"content-backdrop fade\"></div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 81 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\AddNote.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
