#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2c64be86f48fd0309bc1ccc4a3b32fd83f868e5ca3036afc3369ae8f8277d998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_Staking), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/Staking.cshtml")]
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
#line 3 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
using Core.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2c64be86f48fd0309bc1ccc4a3b32fd83f868e5ca3036afc3369ae8f8277d998", @"/Areas/Admin/Views/Report/Staking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Report_Staking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.Application.ViewModels.Report.ReportStakingSummaryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/report/staking.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
  
    var role = User.GetSpecificClaim("RoleName");
    ViewBag.Title = "Staking Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c64be86f48fd0309bc1ccc4a3b32fd83f868e5ca3036afc3369ae8f8277d9986341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        var stakingReportController = new StakingReportController();\r\n        stakingReportController.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"d-flex flex-column flex-column-fluid\">\r\n\r\n    ");
#nullable restore
#line 29 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
Write(await Html.PartialAsync("_ToolbarPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div id=\"kt_app_content\" class=\"app-content flex-column-fluid pt-6 pt-lg-10\">\r\n        <div id=\"kt_app_content_container\" class=\"app-container container-xxl\">\r\n\r\n");
#nullable restore
#line 34 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
             if (User.GetSpecificClaim("RoleName") == "Admin")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-xl-12 mb-5 mb-xl-10"">
                    <div class=""card"">
                        <div class=""card-header py-5"">
                            <div class=""card-toolbar"">
                                <div class=""d-flex flex-stack flex-wrap gap-4"">
                                    <div class=""d-flex align-items-center fw-bold"">
                                        <input type=""text"" id=""txt-search-keyword"" class=""form-control form-control-white form-control-sm"" placeholder=""Search"">
                                    </div>

                                    <div class=""d-flex align-items-center fw-bold"">
                                        <button type=""button"" id=""btnSearch"" class=""btn btn-sm btn-success"">
                                            <span class=""indicator-label"">Search</span>
                                        </button>
                                    </div>
                                </div>
                        ");
            WriteLiteral("    </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 55 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""d-flex flex-wrap flex-stack my-6"">
                <h4 class=""fw-bold my-2"">Profit Info</h4>
            </div>

            <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">
                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <div class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 stakingProfit"">0</span>
                                    <span class=""fs-4 fw-semibold text-gray-500 me-1 align-self-start"">");
#nullable restore
#line 68 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                                                                                                   Write(CommonConstants.TOKEN_IN_CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <span class=""text-dark pt-1 fw-bolder fs-5"">
                                    Profit
                                </span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <div class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 stakingReferralDirect"">0</span>
                                    <span class=""fs-4 fw-semibold text-gray-500 me-1 align-self-start"">");
#nullable restore
#line 84 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                                                                                                   Write(CommonConstants.TOKEN_IN_CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <span class=""text-dark pt-1 fw-bolder fs-5"">
                                    Referral Direct
                                </span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <div class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 stakingAffiliateOnProfit"">0</span>
                                    <span class=""fs-4 fw-semibold text-gray-500 me-1 align-self-start"">");
#nullable restore
#line 100 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                                                                                                   Write(CommonConstants.TOKEN_IN_CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <span class=""text-dark pt-1 fw-bolder fs-5"">
                                    Affiliate on Profit
                                </span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <div class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 stakingLeadership"">0</span>
                                    <span class=""fs-4 fw-semibold text-gray-500 me-1 align-self-start"">");
#nullable restore
#line 116 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                                                                                                   Write(CommonConstants.TOKEN_IN_CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <span class=""text-dark pt-1 fw-bolder fs-5"">
                                    Leadership
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""d-flex flex-wrap flex-stack my-6"">
                <h4 class=""fw-bold my-2"">
                    Staking Info
                    <span class=""fs-6 text-primary fw-semibold ms-1 d-block"">( Maxout = Profit + Referral Direct + Affiliate on Profit )</span>
                </h4>
            </div>

            <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">
                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <d");
            WriteLiteral(@"iv class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 lblStakingAmount"">0</span>
                                    <span class=""fs-4 fw-semibold text-gray-500 me-1 align-self-start"">");
#nullable restore
#line 141 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                                                                                                   Write(CommonConstants.TOKEN_IN_CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                    Staking Amount
                                </span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <div class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 lblStakingAffiliateAmount"">0</span>
                                    <span class=""fs-4 fw-semibold text-gray-500 me-1 align-self-start"">");
#nullable restore
#line 157 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                                                                                                   Write(CommonConstants.TOKEN_IN_CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                    Staking Affiliate
                                </span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                    <div class=""card card-flush"">
                        <div class=""card-header pt-1"">
                            <div class=""card-title d-flex flex-column"">
                                <div class=""d-flex align-items-center"">
                                    <span class=""fs-2 fw-bold text-dark me-2 lh-1 ls-n2 lblStakingMaxout"">0</span>
                                    <span class=""fs-4 fw-bolder text-gray-500 me-1 align-self-start"">%</span>
                                </div>
                                <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
     ");
            WriteLiteral(@"                               Staking Maxout
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class=""card mb-5 mb-xl-10"" id=""kt_profile_details_view"">
                <div class=""card-body p-9"">
                    <div class=""row mb-10"">
                        <label class=""col-lg-2 fw-bold text-muted"">Affiliate F1</label>
                        <div class=""col-lg-2"">
");
#nullable restore
#line 190 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 193 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 197 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F2</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 201 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 204 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 208 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F3</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 212 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 215 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 219 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row mb-10\">\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F4</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 226 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 229 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 233 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F5</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 237 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 5)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 240 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 244 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F6</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 248 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 6)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 251 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 255 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row mb-10\">\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F7</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 262 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 7)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 265 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 269 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <label class=\"col-lg-2 fw-bold text-muted\">Affiliate F8</label>\r\n                        <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 273 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                             if (Model.ReferralLevel >= 8)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-success me-auto\">YES</span>\r\n");
#nullable restore
#line 276 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-light-danger me-auto\">NO</span>\r\n");
#nullable restore
#line 280 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Staking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.Application.ViewModels.Report.ReportStakingSummaryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591