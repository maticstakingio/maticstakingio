#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5ad00e583c103f9663d028b49da4f71488fd3a4dc909691dae96dd9c3a31cecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Staking_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Staking/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
using Core.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
using Core.Utilities.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5ad00e583c103f9663d028b49da4f71488fd3a4dc909691dae96dd9c3a31cecb", @"/Areas/Admin/Views/Staking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Staking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/staking/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
  
    ViewBag.Title = "Staking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ad00e583c103f9663d028b49da4f71488fd3a4dc909691dae96dd9c3a31cecb6094", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        var stakingObj = new StakingController();\r\n        stakingObj.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n<input type=\"hidden\" id=\"transactionType\" />\r\n<input type=\"hidden\" id=\"tokenCode\"");
            BeginWriteAttribute("value", " value=\"", 423, "\"", 463, 1);
#nullable restore
#line 24 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
WriteAttributeValue("", 431, UnitType.MATIC.GetDescription(), 431, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<div class=\"d-flex flex-column flex-column-fluid\">\r\n\r\n    ");
#nullable restore
#line 28 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
Write(await Html.PartialAsync("_ToolbarPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div id=""kt_app_content"" class=""app-content flex-column-fluid pt-6 pt-lg-10"">
        <div id=""kt_app_content_container"" class=""app-container container-xxl"">

            <div class=""d-flex flex-column flex-lg-row"">
                <div class=""d-flex flex-center flex-column flex-lg-row-auto w-100 mb-8 mb-lg-0"">
                    <div class=""w-100 w-lg-450px w-xxl-450px mb-8 mb-lg-0"">
                        <div class=""card"">
                            <div class=""card-body"">

                                ");
#nullable restore
#line 39 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"mb-5 text-center\">\r\n                                    <label class=\"fs-4 form-label fw-bold text-dark\">\r\n                                        Staking ");
#nullable restore
#line 43 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
                                            Write(UnitType.MATIC);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </label>\r\n                                    <h5 class=\"text-info\">Minimum staking <span class=\"numberFormat minStaking\">0</span> ");
#nullable restore
#line 45 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
                                                                                                                     Write(UnitType.MATIC);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>

                                <div class=""mb-5"">
                                    <label class=""fs-6 form-label fw-bold text-gray-700"">
                                        MATIC Price: <span class=""maticPrice fw-bolder text-danger fs-4"">0.0000</span>
                                        <a href=""https://coinmarketcap.com/currencies/polygon/"" target=""_blank"" class=""text-decoration-underline fs-8"">Refer CMC</a>
                                    </label>
                                </div>

                                <div class=""mb-5"">
                                    <label class=""fs-6 form-label text-gray-700"">
                                        Balance: <span class=""CurrentBalance fw-bold text-dark"">0.0000</span> <span class=""ddlWalletCode"">");
#nullable restore
#line 57 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Staking\Index.cshtml"
                                                                                                                                     Write(UnitType.MATIC.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </label>
                                </div>

                                <div class=""mb-10"">
                                    <label class=""fs-6 fw-semibold form-label text-gray-700"">Staking Amount</label>
                                    <div class=""position-relative"">
                                        <input type=""text"" class=""form-control numberFormat4"" value=""0"" id=""txtAmount"">
                                        <button type=""button"" class=""btn btn-icon position-absolute translate-middle-y top-50 end-0"" id=""btnMax"">
                                            Max
                                        </button>
                                    </div>
                                </div>

                                <div class=""mb-10"">
                                    <label class=""fs-5 form-label fw-bold text-dark mb-5"">Staking Info:</label>
                                    <div class=""d-flex flex-stack mb");
            WriteLiteral(@"-5"">
                                        <label class=""fs-6 fw-semibold text-gray-700"">Staking MATIC</label>
                                        <label class=""text-gray-700 fw-bold lblStakingMATIC"">0.0000</label>
                                    </div>
                                    <div class=""d-flex flex-stack mb-5"">
                                        <label class=""fs-6 fw-semibold text-gray-700"">Staking USD</label>
                                        <label class=""text-gray-700 fw-bold lblStakingUSD"">0.0000</label>
                                    </div>
                                    <div class=""d-flex flex-stack mb-5"">
                                        <label class=""fs-6 fw-semibold text-gray-700"">Interest Rate </label>
                                        <label class=""text-gray-700 fw-bold lblInterestRate"">10%</label>
                                    </div>
                                </div>

                                <div class=""d-fl");
            WriteLiteral(@"ex align-items-center justify-content-center"">
                                    <a href=""/home"" class=""btn btn-active-light-warning btn-color-gray-600 me-3"">Cancel</a>
                                    <button class=""btn btn-info text-white"" id=""btnConfirmStaking"">Confirm</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
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