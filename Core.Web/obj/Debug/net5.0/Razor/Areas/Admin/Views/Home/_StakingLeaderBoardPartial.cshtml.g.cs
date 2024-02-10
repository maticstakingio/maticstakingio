#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Home\_StakingLeaderBoardPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0be43d2729236b495f1ad2a6884edc4bfd59cb4f8f915b95a8c2b5aa88a9533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home__StakingLeaderBoardPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/_StakingLeaderBoardPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e0be43d2729236b495f1ad2a6884edc4bfd59cb4f8f915b95a8c2b5aa88a9533", @"/Areas/Admin/Views/Home/_StakingLeaderBoardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home__StakingLeaderBoardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row gx-5 gx-xl-10"">
    <div class=""col-xl-12 mb-5 mb-xl-5"">
        <div class=""card"">
            <div class=""card-header pt-5"">
                <h4 class=""card-title align-items-start flex-column"">
                    <span class=""card-label fw-bold fs-5"">Staking Leaderboard</span>
                    <span class=""text-gray-400 mt-1 fw-semibold fs-6"">Latest leaderboard list</span>
                </h4>
                <div class=""card-toolbar"">
                    <div class=""d-flex flex-stack flex-wrap gap-4"">
                        <a href=""/admin/staking/leaderboard"" class=""text-gray-600"">View All</a>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-row-dashed table-row-gray-300 align-middle gs-0 gy-4"">
                        <thead>
                            <tr class=""fw-bolder"">
                                <th class");
            WriteLiteral(@"=""min-w-90px"">
                                    <span class=""d-block"">ID</span>
                                    <span class=""d-block"">Address</span>
                                    <span class=""d-block"">Email</span>
                                </th>
                                <th>MATIC Amount</th>
                                <th>USD Amount</th>
                                <th>Time Line</th>
                                <th>Interest Rate</th>
                                <th>Receive USD</th>
                                <th>Receive Latest</th>
                                <th>Type</th>
                                <th>Create Date</th>
                            </tr>
                        </thead>
                        <tbody id=""tbl-content-staking""></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<script id=""table-template-staking"" type=""x-tmpl-mustache"">
    <tr>
        <t");
            WriteLiteral(@"d>
            <span class=""fw-bold text-gray-700 d-block fs-7"">{{Sponsor}}</span>
            <span class=""fw-bold text-dark d-block fs-7"">{{AppUserName}}</span>
            <span class=""fw-bold text-dark d-block fs-7"">{{Email}}</span>
        </td>
        <td>
            <span class=""text-dark fw-bold d-block fs-7"">{{StakingMATICAmount}}</span>
        </td>
        <td>
            <span class=""text-dark fw-bold d-block fs-7"">{{StakingUSDAmount}}</span>
        </td>
        <td>
            <span class=""text-gray-700 fw-bold d-block fs-7"">{{TimeLineName}}</span>
        </td>
        <td>
            <span class=""fw-bolder text-dark d-block fs-7"">{{InterestRate}}%</span>
        </td>
        <td>
            <span class=""text-dark fw-bold d-block fs-7"">{{ReceiveUSDAmount}}</span>
        </td>
        <td>
            <span class=""text-gray-700 fw-bold d-block fs-7"">{{ReceiveLatest}}</span>
        </td>
        <td>
            <span class=""text-info fw-bold d-block fs-7"">{{Typ");
            WriteLiteral("eName}}</span>\r\n        </td>\r\n        <td>\r\n            <span class=\"text-dark fw-bold d-block fs-7\">{{DateCreated}}</span>\r\n        </td>\r\n    </tr>\r\n</script>\r\n");
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
