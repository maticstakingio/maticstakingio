#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Partials\_PresaleReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6f7bdeafb46789cab1a2f726c30cc116aa658b536bddf4c9519409bcf211edbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_Partials__PresaleReport), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/Partials/_PresaleReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6f7bdeafb46789cab1a2f726c30cc116aa658b536bddf4c9519409bcf211edbc", @"/Areas/Admin/Views/Report/Partials/_PresaleReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Report_Partials__PresaleReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card-header border-0 pt-5"">
    <h3 class=""card-title align-items-start flex-column"">
        <span class=""card-label fw-bolder fs-5 mb-1"">Presale Statistics</span>
    </h3>
</div>
<div class=""card-body pt-1 pb-0"">
    <div class=""d-flex flex-wrap flex-sm-nowrap pb-6"">
        <div class=""flex-grow-1"">
            <div class=""d-flex flex-wrap justify-content-start"">
                <div class=""d-flex flex-wrap"">
                    <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                        <div class=""d-flex align-items-center"">
                            <span class=""svg-icon svg-icon-3 svg-icon-primary me-2"">
                                <i class=""fa fa-wallet text-success""></i>
                            </span>
                            <div class=""fs-6 fw-bolder TotalBNBDeposit"">0</div>
                        </div>
                        <div class=""fw-bold fs-6 text-gray-400"">Total BNB Deposit</div>
        ");
            WriteLiteral(@"            </div>
                    <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                        <div class=""d-flex align-items-center"">
                            <span class=""svg-icon svg-icon-3 svg-icon-success me-2"">
                                <i class=""fa fa-wallet text-success""></i>
                            </span>
                            <div class=""fs-6 fw-bolder TodayBNBDeposit"">0</div>
                        </div>
                        <div class=""fw-bold fs-6 text-gray-400"">Today BNB Deposit</div>
                    </div>
                    <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                        <div class=""d-flex align-items-center"">
                            <span class=""svg-icon svg-icon-3 svg-icon-danger me-2"">
                                <i class=""fa fa-wallet text-danger""></i>
                            </span>
                          ");
            WriteLiteral(@"  <div class=""fs-6 fw-bolder TotalICDWithdraw"">0</div>
                        </div>
                        <div class=""fw-bold fs-6 text-gray-400"">Total ICD Withdraw</div>
                    </div>

                    <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                        <div class=""d-flex align-items-center"">
                            <span class=""svg-icon svg-icon-3 svg-icon-danger me-2"">
                                <i class=""fa fa-wallet text-danger""></i>
                            </span>
                            <div class=""fs-6 fw-bolder TodayICDWithdraw"">0</div>
                        </div>
                        <div class=""fw-bold fs-6 text-gray-400"">Today ICD Withdraw</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
