#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64120c9a31741f596da96ad744c1cf165c8d1780dfea302005b71b27c20bc5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_Leadership), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/Leadership.cshtml")]
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
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"64120c9a31741f596da96ad744c1cf165c8d1780dfea302005b71b27c20bc5ec", @"/Areas/Admin/Views/Report/Leadership.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Report_Leadership : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/report-leadership/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/report-leadership/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64120c9a31741f596da96ad744c1cf165c8d1780dfea302005b71b27c20bc5ec6227", async() => {
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
                WriteLiteral("\r\n    <script>\r\n        var reportController = new ReportController();\r\n        reportController.initialize();\r\n    </script>\r\n");
            }
            );
#nullable restore
#line 9 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml"
      
    ViewBag.Title = "Leadership report";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64120c9a31741f596da96ad744c1cf165c8d1780dfea302005b71b27c20bc5ec7810", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n    <div class=\"d-flex flex-column flex-column-fluid\">\r\n\r\n        ");
#nullable restore
#line 19 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml"
   Write(await Html.PartialAsync("_ToolbarPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <div id=""kt_app_content"" class=""app-content flex-column-fluid pt-6 pt-lg-10"">
            <div id=""kt_app_content_container"" class=""app-container container-xxl"">
                <div class=""row gx-5 gx-xl-10"">
                    <div class=""col-xl-12 mb-5 mb-xl-10"">
                        <div class=""card"">
                            <div class=""card-header pt-5"">
                                <div class=""card-toolbar"">
                                    <div class=""d-flex flex-stack flex-wrap gap-4"">
                                        <div class=""d-flex align-items-center fw-bold"">
                                            <input type=""text"" id=""txt-query"" class=""form-control form-control-white form-control-sm me-5"" placeholder=""Username"">
                                        </div>
                                        <div class=""d-flex align-items-center fw-bold"">
                                            <input type=""text"" id=""FromDate"" class=""form-control form");
            WriteLiteral(@"-control-white form-control-sm me-5"" placeholder=""From"">
                                        </div>
                                        <div class=""d-flex align-items-center fw-bold"">
                                            <input type=""text"" id=""ToDate"" class=""form-control form-control-white form-control-sm me-5"" placeholder=""To"">
                                        </div>
                                        <div class=""d-flex align-items-center fw-bold"">
                                            <a id=""btnSearch"" class=""btn btn-sm btn-icon btn-light btn-color-muted btn-active-success me-3"">
                                                <span class=""svg-icon svg-icon-2 svg-icon-success"">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none""><path d=""M21.7 18.9L18.6 15.8C17.9 16.9 16.9 17.9 15.8 18.6L18.9 21.7C19.3 22.1 19.9 22.1 20.3 21.7L21.7 20.3C22.1 19.9 22.1 19.3 21.7 18.9Z"" fill=");
            WriteLiteral(@"""black""></path><path opacity=""0.3"" d=""M11 20C6 20 2 16 2 11C2 6 6 2 11 2C16 2 20 6 20 11C20 16 16 20 11 20ZM11 4C7.1 4 4 7.1 4 11C4 14.9 7.1 18 11 18C14.9 18 18 14.9 18 11C18 7.1 14.9 4 11 4ZM8 11C8 9.3 9.3 8 11 8C11.6 8 12 7.6 12 7C12 6.4 11.6 6 11 6C8.2 6 6 8.2 6 11C6 11.6 6.4 12 7 12C7.6 12 8 11.6 8 11Z"" fill=""black""></path></svg>
                                                </span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>

                <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">


                    <div attr-id=""1-BNB"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
               ");
            WriteLiteral(@"                 <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-deposit-bnb"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">BNB</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Deposit BNB
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""2-BNB"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <");
            WriteLiteral(@"div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-withdraw-bnb"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">BNB</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Withdraw BNB
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""1-USDT"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card");
            WriteLiteral(@"-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-deposit-usdt"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">USDT</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Deposit USDT
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""2-USDT"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex ");
            WriteLiteral(@"flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-withdraw-usdt"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">USDT</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Withdraw USDT
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">


                    <div attr-id=""1-MNI"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-h");
            WriteLiteral(@"eader pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-deposit-mni"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNI</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Deposit MNI
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""2-MNI"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
    ");
            WriteLiteral(@"                            <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-withdraw-mni"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNI</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Withdraw MNI
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""1-MNO"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                    ");
            WriteLiteral(@"            <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-deposit-mno"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNO</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Deposit MNO
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""2-MNO"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div c");
            WriteLiteral(@"lass=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-withdraw-mno"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNO</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Withdraw MNO
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">


                    <div attr-id=""15-BNB"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                        ");
            WriteLiteral(@"    <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-transfer-bnb"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">BNB</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Transfer BNB
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""23-BNB"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=");
            WriteLiteral(@"""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-received-transfer-bnb"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">BNB</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Received Transfer BNB
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""15-USDT"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""c");
            WriteLiteral(@"ard-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-transfer-usdt"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">USDT</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Transfer USDT
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""23-USDT"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush"">
                            <div class=""card-header ");
            WriteLiteral(@"pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-received-transfer-usdt"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">USDT</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Received Transfer USDT
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">


                    <div attr-id=""15-MNO"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                  ");
            WriteLiteral(@"      <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-transfer-mno"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNO</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Transfer MNO
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""23-MNO"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div clas");
            WriteLiteral(@"s=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-received-transfer-mno"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNO</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Received Transfer MNO
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""15-MNI"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""");
            WriteLiteral(@"card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-transfer-mni"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNI</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Transfer MNI
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div attr-id=""23-MNI"" class=""wallet-inout col-md-6 col-lg-6 col-xl-6 col-xxl-3"">
                        <div class=""card card-flush");
            WriteLiteral(@""">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-received-transfer-mni"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">MNI</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Received Transfer MNI
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row g-5 g-xl-10 mb-5 mb-xl-10"">


                    <div class=""exchange-inout col-md-6 col-lg-6 co");
            WriteLiteral(@"l-xl-6 col-xxl-6"">
                        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-exchange"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">USD</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Exchange USD
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""saving-inout col-md-6 col-lg-6 col-xl-6 col-xxl-6"">
                ");
            WriteLiteral(@"        <div class=""card card-flush"">
                            <div class=""card-header pt-1"">
                                <div class=""card-title d-flex flex-column"">
                                    <div class=""d-flex align-items-center"">
                                        <span class=""fs-1 fw-bold text-dark me-2 lh-1 ls-n2 lblTotalValueLocked lb-total-saving"">0 </span>
                                        <span class=""fs-3 fw-semibold text-gray-400 me-1 align-self-start"">USD</span>
                                    </div>
                                    <span class=""text-gray-600 pt-1 fw-bolder fs-5"">
                                        Total Saving USD
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row gx-5 gx-xl-10"">
                <div class=""col-xl-12 mb-5 mb-xl-10"">
               ");
            WriteLiteral(@"     <ul class=""nav nav-tabs nav-line-tabs nav-line-tabs-2x mb-5 fs-6"">
                        <li class=""nav-item"" >
                            <a id=""OpenProject"" class=""nav-link active"" data-bs-toggle=""tab"" href=""#kt_tab_pane_4"">WALLET</a>
                        </li>
                        <li class=""nav-item"" >
                            <a id=""OpenProject2"" class=""nav-link"" data-bs-toggle=""tab"" href=""#kt_tab_pane_5"">EXCHANGE</a>
                        </li>
                        <li class=""nav-item"" >
                            <a id=""OpenProject3"" class=""nav-link"" data-bs-toggle=""tab"" href=""#kt_tab_pane_6"">SAVING</a>
                        </li>
                    </ul>

                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""kt_tab_pane_4"" role=""tabpanel"">
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                ");
            WriteLiteral(@"    <table class=""table table-row-dashed table-row-gray-300 align-middle gs-0 gy-4"">
                                        <thead>
                                        <tr class=""fw-bolder text-muted"">
                                            <th>Email</th>
                                            <th>Amount</th>
                                            <th>USD</th>
                                            <th>Type</th>
                                            <th>Created Date</th>
                                            
                                        </tr>
                                        </thead>
                                        <tbody id=""tbl-1-content""></tbody>
                                    </table>

                                    ");
#nullable restore
#line 392 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml"
                               Write(await Component.InvokeAsync("AjaxPagingCommission"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        </div>
                            <div class=""tab-pane fade"" id=""kt_tab_pane_5"" role=""tabpanel"">
                                
                                <div class=""card-body"">
                                    

                                    <div class=""table-responsive"">
                                        <table class=""table table-row-dashed table-row-gray-300 align-middle gs-0 gy-4"">
                                        <thead>
                                            <tr class=""fw-bolder text-muted"">
                                                <th>Email</th>
                                                <th >Amount</th>
                                                <th>USD</th>
                                                <th>Type</th>
                                                <th>Created Date</th>
                                            </tr>
    ");
            WriteLiteral("                                        </thead>\r\n                                            <tbody id=\"tbl-2-content\"></tbody>\r\n                                        </table>\r\n\r\n                                        ");
#nullable restore
#line 415 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml"
                                   Write(await Component.InvokeAsync("AjaxPagingLeaderSale"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                    </div>
                                
                        </div>
                        <div class=""tab-pane fade"" id=""kt_tab_pane_6"" role=""tabpanel"">
                            <div class=""table-responsive"">
                                <table class=""table table-row-dashed table-row-gray-300 align-middle gs-0 gy-4"">
                                    <thead>
                                    <tr class=""fw-bolder text-muted"">
                                        <th>Email</th>
                                        <th>Token Code</th>
                                        <th>Amount</th>
                                        <th>USD</th>
                                        <th>Profit</th>
                                        <th>Created Date</th>
                                    </tr>
                                    </thead>
                                    <tbody id=""tbl-3-");
            WriteLiteral("content\"></tbody>\r\n                                </table>\r\n\r\n                                ");
#nullable restore
#line 436 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Leadership.cshtml"
                           Write(await Component.InvokeAsync("AjaxPaging"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
            </div>







        </div>
    </div>










    <script id=""table-1-template"" type=""x-tmpl-mustache"">
        <tr class=""{{bgName}}"">
                                 <td>{{Email}}</td>
                                 <td>{{Amount}} {{Unit}}</td>
                                <td>{{AmountUSDT}}</td>
                                <td>{{Type}}</td>
                                <td>{{CreatedOn}}</td>
                             </tr>
</script>

<script id=""table-2-template"" type=""x-tmpl-mustache"">
        <tr class=""{{bgName}}"">
                                 <td>{{Email}}</td>
                                 <td>{{Amount}} {{Unit}}</td>
                                <td>{{AmountUSDT}} </td>
                                <td>{{TypeName}}</td>
                        ");
            WriteLiteral(@"        <td>{{CreatedOn}}</td>
                             </tr>
</script>

<script id=""table-3-template"" type=""x-tmpl-mustache"">
        <tr class=""{{bgName}}"">
                               <td>{{Email}}</td>
        <td>{{TokenCode}}</td>
        <td>{{SavingAmount}}</td>
        <td>{{SavingAmountUSD}} USD</td>
        <td>{{ProfitAmount}}</td>
        <td>{{CreatedOn}}</td>
                         </tr>
</script>");
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
