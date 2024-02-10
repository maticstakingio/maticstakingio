#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Home\_InvestProfitHistoryPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a20d81fccb49c31b5a3c5d14e16a4c85f00c16208c02bbce2465079815d6d0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home__InvestProfitHistoryPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/_InvestProfitHistoryPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.BlockChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.Valuesshare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Utilities.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a20d81fccb49c31b5a3c5d14e16a4c85f00c16208c02bbce2465079815d6d0bb", @"/Areas/Admin/Views/Home/_InvestProfitHistoryPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home__InvestProfitHistoryPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header pt-5"">
        <h4 class=""card-title align-items-start flex-column"">
            <span class=""card-label fw-bold fs-5"">Trade History</span>
            <span class=""text-gray-400 mt-1 fw-semibold fs-6"">Bot Trade Profit</span>
        </h4>
        <div class=""card-toolbar"">
            <div class=""d-flex flex-stack flex-wrap gap-4"">
                <a href=""/admin/investtrading/index"" class=""text-gray-600"">View All</a>
            </div>
        </div>
    </div>

    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-row-dashed table-row-gray-300 align-middle gs-0 gy-4"">
                <thead>
                    <tr class=""fw-bolder text-muted"">
                        <th>Start Price</th>
                        <th>Stop Price</th>
                        <th>Type</th>
                        <th>Margin</th>
                        <th>Profit Amount</th>
                        <th>Profi");
            WriteLiteral("t Percent</th>\r\n                        <th>Result</th>\r\n                        <th>Date Created</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"tbl-content\"></tbody>\r\n            </table>\r\n        </div>\r\n        ");
#nullable restore
#line 32 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Home\_InvestProfitHistoryPartial.cshtml"
   Write(await Component.InvokeAsync("Paging"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

</div>

<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td><span class=""fw-bold text-dark d-block fs-7"">{{StartPrice}} <span class=""text-gray-700 fs-8"">BTC/USD</span></span></td>
        <td><span class=""fw-bold text-dark d-block fs-7"">{{StopPrice}} <span class=""text-gray-700 fs-8"">BTC/USD</span></span></td>
        <td><span class=""fw-bold {{TypeColor}} d-block fs-7"">{{TypeName}}</span></td>
        <td><span class=""fw-bold text-dark d-block fs-7"">{{Margin}}</span></td>
        <td><span class=""fw-bold text-dark d-block fs-7""><span class=""text-gray-700 fs-8"">$</span>{{ProfitAmount}}</span></td>
        <td><span class=""fw-bold text-dark d-block fs-7"">{{ProfitPercent}}<span class=""text-gray-700 fs-8"">%</span></span></td>
        <td><span class=""fw-bold {{ResultColor}} d-block fs-7"">{{Result}}</span></td>
        <td><span class=""fw-bold text-muted d-block fs-7"">{{DateCreated}}</span></td>
    </tr>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591