#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\User\IndexTree.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13b29cdaa8316b25064d0379e65aea04d1e343df6ffc2326e2e7c4ba889c0293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_IndexTree), @"mvc.1.0.view", @"/Areas/Admin/Views/User/IndexTree.cshtml")]
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
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\User\IndexTree.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\User\IndexTree.cshtml"
using Core.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"13b29cdaa8316b25064d0379e65aea04d1e343df6ffc2326e2e7c4ba889c0293", @"/Areas/Admin/Views/User/IndexTree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_IndexTree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/plugins/custom/jstree/jstree.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/user/indextree.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/plugins/custom/jstree/jstree.bundle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\User\IndexTree.cshtml"
  
    ViewBag.Title = "Tree View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b29cdaa8316b25064d0379e65aea04d1e343df6ffc2326e2e7c4ba889c02937200", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b29cdaa8316b25064d0379e65aea04d1e343df6ffc2326e2e7c4ba889c02938323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 12 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\User\IndexTree.cshtml"
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
                WriteLiteral("\r\n    <script>\r\n        var customerTreeObj = new CustomerTreeController();\r\n        customerTreeObj.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13b29cdaa8316b25064d0379e65aea04d1e343df6ffc2326e2e7c4ba889c029310591", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
#line 25 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\User\IndexTree.cshtml"
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
                            <ul class=""breadcrumb breadcrumb-dot fw-bold fs-base my-1"">
                                <li class=""breadcrumb-item"">Address - Email</li>
                                <li class=""breadcrumb-item"">[Staking / Affiliate]</li>
                            </ul>
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <div id=""jstree""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
