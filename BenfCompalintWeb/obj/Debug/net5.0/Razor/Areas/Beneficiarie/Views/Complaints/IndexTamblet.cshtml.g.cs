#pragma checksum "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22d16f59c50608e108f1c19830595dde931826a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Beneficiarie_Views_Complaints_IndexTamblet), @"mvc.1.0.view", @"/Areas/Beneficiarie/Views/Complaints/IndexTamblet.cshtml")]
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
#line 1 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using BenfCompalintWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using BenfCompalintWeb.Areas.Beneficiarie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22d16f59c50608e108f1c19830595dde931826a", @"/Areas/Beneficiarie/Views/Complaints/IndexTamblet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba365b73717a071cd11ab6cbd38d253b5fa5c83", @"/Areas/Beneficiarie/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Beneficiarie_Views_Complaints_IndexTamblet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Compalint>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""card"">
    <h5 class=""card-header"">Ajax Sourced Server-side</h5>
    <div class=""card-datatable text-nowrap"">
        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper dt-bootstrap5 no-footer"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-6"">
                    <div class=""dataTables_length"" id=""DataTables_Table_0_length"">
                        <label>
                            Show <select name=""DataTables_Table_0_length"" aria-controls=""DataTables_Table_0"" class=""form-select"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22d16f59c50608e108f1c19830595dde931826a5574", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22d16f59c50608e108f1c19830595dde931826a6761", async() => {
                WriteLiteral("25");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22d16f59c50608e108f1c19830595dde931826a7948", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22d16f59c50608e108f1c19830595dde931826a9135", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select> entries
                        </label>
                    </div>
                </div>
                <div class=""col-sm-12 col-md-6 d-flex justify-content-center justify-content-md-end"">
                    <div id=""DataTables_Table_0_filter"" class=""dataTables_filter"">
                        <label>
                            Search:<input type=""search""
                                          class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1319, "\"", 1333, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-controls=""DataTables_Table_0"">
                        </label>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"">
                <table class=""datatables-ajax table table-bordered dataTable no-footer"" id=""DataTables_Table_0""
                       role=""grid"" aria-describedby=""DataTables_Table_0_info"" style=""width: 1033px;"">
                    <thead>
                        <tr role=""row"">
                            <th class=""sorting sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1""
                                colspan=""1"" style=""width: 128px;"" aria-label=""Full name: activate to sort column descending""
                                aria-sort=""ascending"">Full name</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1""
                                style=""width: 160px;"" aria-label=""Email: activate to sort column ascending"">Emai");
            WriteLiteral(@"l</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1""
                                style=""width: 188px;"" aria-label=""Position: activate to sort column ascending"">Position</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1""
                                style=""width: 88px;"" aria-label=""Office: activate to sort column ascending"">Office</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1""
                                style=""width: 82px;"" aria-label=""Start date: activate to sort column ascending"">
                                Start date
                            </th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1""
                                style=""width: 82px;"" aria-label=""Salary: activate to sort co");
            WriteLiteral("lumn ascending\">Salary</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 54 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"odd\">\r\n                            <td class=\"sorting_1\">");
#nullable restore
#line 57 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml"
                                             Write(item.TitleComplaint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml"
                           Write(item.CompDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml"
                           Write(item.Governorates.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml"
                           Write(item.StatusCompalint.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>2008/11/28</td>\r\n                            <td>$162,700</td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "E:\NewProject\BenfCompalintWeb\BenfCompalintWeb\Areas\Beneficiarie\Views\Complaints\IndexTamblet.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""row"">
                <div class=""col-sm-12 col-md-6"">
                    <div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">
                        Showing 1
                        to 10 of 57 entries
                    </div>
                </div>
                <div class=""col-sm-12 col-md-6"">
                    <div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate"">
                        <ul class=""pagination"">
                            <li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous"">
                                <a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0""
                                   class=""page-link"">Previous</a>
                            </li>
                            <li class=""paginate_button page-item active"">
        ");
            WriteLiteral(@"                        <a href=""#"" aria-controls=""DataTables_Table_0""
                                   data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a>
                            </li>
                            <li class=""paginate_button page-item "">
                                <a href=""#"" aria-controls=""DataTables_Table_0""
                                   data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a>
                            </li>
                            <li class=""paginate_button page-item "">
                                <a href=""#"" aria-controls=""DataTables_Table_0""
                                   data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a>
                            </li>
                            <li class=""paginate_button page-item "">
                                <a href=""#"" aria-controls=""DataTables_Table_0""
                                   data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a>
                            </li>
         ");
            WriteLiteral(@"                   <li class=""paginate_button page-item "">
                                <a href=""#"" aria-controls=""DataTables_Table_0""
                                   data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a>
                            </li>
                            <li class=""paginate_button page-item "">
                                <a href=""#"" aria-controls=""DataTables_Table_0""
                                   data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a>
                            </li>
                            <li class=""paginate_button page-item next"" id=""DataTables_Table_0_next"">
                                <a href=""#""
                                   aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<script>
    // Language and optio");
            WriteLiteral(@"ns change
    $(document).ready(function () {
        $('#example').dataTable({
            ""language"": {
                ""lengthMenu"": 'Display'
                    < select >

                    <option value=""10"">10</option>'+',
                    < option value = ""20"" > 20</option> '+',
            < option value=""30"" > 30</option> '+',
            < option value=""40"" > 40</option > '+',
            < option value=""50"" > 50</option > '+',
            < option value=""-1"" > All</option > '+',

</select >
                    }
                   });
                 } );
</script>



<script>
    //فلترة نوع الشاكي
    $(""#FilterType"").change(function () {
        var value = $(this).val().toLowerCase();
        $("".table tbody tr"").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
        });
    });
    //
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Compalint>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
