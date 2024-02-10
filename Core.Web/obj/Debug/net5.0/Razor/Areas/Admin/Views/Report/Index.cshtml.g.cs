#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dc1e932b120b86daf442ba4de21749a6c1bb18a2985a631062dadebfcd4cb2e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"dc1e932b120b86daf442ba4de21749a6c1bb18a2985a631062dadebfcd4cb2e7", @"/Areas/Admin/Views/Report/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/report/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/report/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Index.cshtml"
  
    ViewBag.Title = "Report";

    var isAdmin = User.IsInRole("Admin");

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1e932b120b86daf442ba4de21749a6c1bb18a2985a631062dadebfcd4cb2e76386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Index.cshtml"
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
                WriteLiteral("\r\n    <script>\r\n        var reportObj = new ReportController();\r\n        reportObj.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc1e932b120b86daf442ba4de21749a6c1bb18a2985a631062dadebfcd4cb2e78633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 15 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"d-flex flex-column flex-column-fluid\">\r\n\r\n    ");
#nullable restore
#line 20 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Report\Index.cshtml"
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
                                    <div class=""d-flex align-items-center my-1"">
                                        <input type=""text"" id=""FromDate"" class=""form-control form-control-white form-control-sm me-5"" placeholder=""From"">
                                    </div>
                                    <div class=""d-flex align-items-center my-1"">
                                        <input type=""text"" id=""ToDate"" class=""form-control form-control-white form-control-sm me-5"" placeholder=""To"">
         ");
            WriteLiteral(@"                           </div>
                                    <a id=""btnSearch"" class=""btn btn-sm btn-icon btn-light btn-color-muted btn-active-success me-3"">
                                        <span class=""svg-icon svg-icon-2 svg-icon-success"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none""><path d=""M21.7 18.9L18.6 15.8C17.9 16.9 16.9 17.9 15.8 18.6L18.9 21.7C19.3 22.1 19.9 22.1 20.3 21.7L21.7 20.3C22.1 19.9 22.1 19.3 21.7 18.9Z"" fill=""black""></path><path opacity=""0.3"" d=""M11 20C6 20 2 16 2 11C2 6 6 2 11 2C16 2 20 6 20 11C20 16 16 20 11 20ZM11 4C7.1 4 4 7.1 4 11C4 14.9 7.1 18 11 18C14.9 18 18 14.9 18 11C18 7.1 14.9 4 11 4ZM8 11C8 9.3 9.3 8 11 8C11.6 8 12 7.6 12 7C12 6.4 11.6 6 11 6C8.2 6 6 8.2 6 11C6 11.6 6.4 12 7 12C7.6 12 8 11.6 8 11Z"" fill=""black""></path></svg>
                                        </span>
                                    </a>
                                </div>
        ");
            WriteLiteral(@"                    </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""d-flex flex-wrap flex-sm-nowrap"">
                                <div class=""flex-grow-1"">
                                    <div class=""d-flex flex-wrap justify-content-start"">
                                        <div class=""d-flex flex-wrap"">
                                            <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                                                <div class=""d-flex align-items-center"">
                                                    <span class=""svg-icon svg-icon-3 svg-icon-primary me-2"">
                                                        <i class=""fa fa-users text-primary""></i>
                                                    </span>
                                                    <div class=""fs-6 fw-bolder TotalMember"">0</div>
                        ");
            WriteLiteral(@"                        </div>
                                                <div class=""fw-bold fs-6 text-gray-400"">Total Member</div>
                                            </div>
                                            <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                                                <div class=""d-flex align-items-center"">
                                                    <span class=""svg-icon svg-icon-3 svg-icon-primary me-2"">
                                                        <i class=""fa fa-users text-warning""></i>
                                                    </span>
                                                    <div class=""fs-6 fw-bolder TodayMember"">0</div>
                                                </div>
                                                <div class=""fw-bold fs-6 text-gray-400"">Today Member</div>
                                            </div>
                     ");
            WriteLiteral(@"                       <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                                                <div class=""d-flex align-items-center"">
                                                    <span class=""svg-icon svg-icon-3 svg-icon-success me-2"">
                                                        <i class=""fa fa-users text-success""></i>
                                                    </span>
                                                    <div class=""fs-6 fw-bolder TotalMemberVerifyEmail"">0</div>
                                                </div>
                                                <div class=""fw-bold fs-6 text-gray-400"">Member Active</div>
                                            </div>
                                            <div class=""border border-gray-300 border-dashed rounded min-w-125px py-3 px-4 me-3 mb-3"">
                                                <div class=""d-flex align-items-center""");
            WriteLiteral(@">
                                                    <span class=""svg-icon svg-icon-3 svg-icon-danger me-2"">
                                                        <i class=""fa fa-users text-danger""></i>
                                                    </span>
                                                    <div class=""fs-6 fw-bolder TotalMemberInVerifyEmail"">0</div>
                                                </div>
                                                <div class=""fw-bold fs-6 text-gray-400"">Member InActive</div>
                                            </div>

                                        </div>
                                    </div>
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
