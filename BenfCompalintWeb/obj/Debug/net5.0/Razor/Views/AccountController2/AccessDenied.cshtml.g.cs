#pragma checksum "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Views\AccountController2\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e655238729e09fb830c57dd58e7097b697ef9d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountController2_AccessDenied), @"mvc.1.0.view", @"/Views/AccountController2/AccessDenied.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e655238729e09fb830c57dd58e7097b697ef9d00", @"/Views/AccountController2/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1514b9a14b3f87aa9c15b50d6f6bf96270b83d90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AccountController2_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-3""></div>
    <div class=""col-md-6"">
        <div class=""top-buffer""></div>
        <div class=""panel panel-danger"">
            <div class=""panel-heading"">Access Denied</div>
            <div class=""panel-body"">
                <section>
                    <h1 class=""text-danger"">401 ! Access Denied</h1>
                    <br />
                    <a href=""javascript:void(0)"" onClick=""backAway()"" class=""btn btn-success"">Back</a>
                </section>
            </div>
        </div>
    </div>
    <div class=""col-md-3""></div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

            function backAway() {
                if (history.length === 1) {
                    window.location = ""http://localhost:50841/""
                } else {
                    history.back();
                }
            }
    </script>
");
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
