#pragma checksum "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\AdminGeneralFederation\Views\ManageCategoryes\AddCirculars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1777abc7aeeeb37a45049c0eed982227029afa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminGeneralFederation_Views_ManageCategoryes_AddCirculars), @"mvc.1.0.view", @"/Areas/AdminGeneralFederation/Views/ManageCategoryes/AddCirculars.cshtml")]
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
#line 1 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\AdminGeneralFederation\Views\_ViewImports.cshtml"
using BenfCompalintWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\AdminGeneralFederation\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\AdminGeneralFederation\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Areas.Beneficiarie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\My_GitHub\BenfCompalintWeb\BenfCompalintWeb\Areas\AdminGeneralFederation\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1777abc7aeeeb37a45049c0eed982227029afa", @"/Areas/AdminGeneralFederation/Views/ManageCategoryes/AddCirculars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba365b73717a071cd11ab6cbd38d253b5fa5c83", @"/Areas/AdminGeneralFederation/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminGeneralFederation_Views_ManageCategoryes_AddCirculars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Offcanvas to add new user -->
<!--<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasAddUser"" aria-labelledby=""offcanvasAddUserLabel"" data-select2-id=""offcanvasAddUser"" style=""visibility: hidden;"" aria-hidden=""true"">
    <div class=""offcanvas-header border-bottom"">
        <h6 id=""offcanvasAddUserLabel"" class=""offcanvas-title"">اضافة تعميم</h6>
        <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
    </div>
    <div class=""offcanvas-body flex-grow-0 mx-0"" data-select2-id=""6"">
        <form class=""add-new-user pt-0 fv-plugins-bootstrap5 fv-plugins-framework"" id=""addNewUserForm"" onsubmit=""return false"" novalidate=""novalidate"" data-select2-id=""addNewUserForm"">

            <div class=""mb-3 fv-plugins-icon-container"">
                <label class=""form-label"" for=""add-user-fullname"">
                    عنوان التعميم                 
              <form class=""add-new-user pt-0 fv-plugins-bootstrap5 fv-plugins-framework"" i");
            WriteLiteral(@"d=""addNewUserForm"" onsubmit=""return false"" novalidate=""novalidate"" data-select2-id=""addNewUserForm"">
                </label>
                <input type=""text"" class=""form-control"" id=""add-user-fullname"" placeholder=""عنوان التعميم "" name=""userFullname"" aria-label=""John Doe"">
                <div class=""fv-plugins-message-container invalid-feedback""></div>
            </div>





            <label class=""form-label"" for=""user-role""> الجمعية </label>
            <select id=""user-role"" class=""form-select"">

                <option value=""employee"">اختر</option>
                <option value=""employee"">صنعاء</option>
                <option value=""employee"">تعز </option>
                <option value=""employee"">ابين</option>
                <option value=""employee"">شبوة</option>
            </select>
    </div>
    <div class=""mb-3"">
        <label class=""form-label"" for=""payment-note"">محتوى التعميم</label>
        <textarea class=""form-control"" id=""payment-note"" rows=""2""></textarea>
    ");
            WriteLiteral(@"</div>

    <div class=""mb-3"">
        <label class=""form-label"" for=""payment-note"">اضافة مرفق</label>

        <input type=""file"" class=""form-control"" id=""inputGroupFile02"">
    </div>


    <div class=""mb-3 fv-plugins-icon-container buttom-top-margin"">

        <button type=""button"" class=""btn btn-primary d-grid w-100 mb-2"">إضافة</button>
        <button type=""button"" class=""btn btn-label-secondary d-grid w-100"" data-bs-dismiss=""offcanvas"">
            إلغاء
        </button>
    </div>

    </form>
</div>-->");
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