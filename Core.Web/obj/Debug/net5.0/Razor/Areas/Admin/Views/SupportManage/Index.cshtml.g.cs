#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\SupportManage\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6dab803b5e14d2b615264d8193649d37acf7158b399d4eaf9fe317b5e1229a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SupportManage_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SupportManage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6dab803b5e14d2b615264d8193649d37acf7158b399d4eaf9fe317b5e1229a70", @"/Areas/Admin/Views/SupportManage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_SupportManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/support-manage/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/support-manage/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\SupportManage\Index.cshtml"
  
    ViewData["Title"] = "Support";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6dab803b5e14d2b615264d8193649d37acf7158b399d4eaf9fe317b5e1229a706321", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 5 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\SupportManage\Index.cshtml"
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
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dab803b5e14d2b615264d8193649d37acf7158b399d4eaf9fe317b5e1229a708490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        var supportManageObj = new SupportManageController();\r\n        supportManageObj.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""content d-flex flex-column flex-column-fluid"" id=""kt_content"">
    <div class=""container"" id=""kt_content_container"">
        <div class=""card mb-5 mb-xl-10"">
            <div class=""card-body py-3"">
                <div class=""table-responsive"">
                    <table class=""table table-row-dashed table-row-gray-300 align-middle gs-0 gy-4"">
                        <thead>
                            <tr class=""fw-bolder text-muted"">
                                <th class=""min-w-150px"">Title<br />Email</th>
                                <th class=""min-w-150px"">Content</th>
                                <th class=""min-w-100px"">Anwser</th>
                                <th class=""min-w-100px"">Date<br />Status</th>
                                <th class=""min-w-80px"">Function</th>
                            </tr>
                        </thead>
                        <tbody id=""tbl-content""></tbody>
                    </table>
                </div>
             ");
            WriteLiteral("   ");
#nullable restore
#line 33 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\SupportManage\Index.cshtml"
           Write(await Component.InvokeAsync("Paging"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td>
            <a href=""#"" class=""text-dark text-hover-primary d-block fs-7"">{{Name}}</a>
            <span class=""text-muted fw-bold text-muted d-block fs-7"">{{AppUserName}}</span>
        </td>
        <td>
            <span class=""text-muted fw-bold text-muted d-block fs-7"">{{RequestContent}}</span>
        </td>
        <td>
            <span class=""text-muted fw-bold text-muted d-block fs-7"">{{ResponseContent}}</span>
        </td>
        <td>
            <span class=""text-muted fw-bold text-muted d-block fs-7"">{{DateModified}}</span>
            <span class=""text-muted fw-bold text-muted d-block fs-7"">{{{Type}}}</span>
        </td>
        <td>
            <a data-id=""{{Id}}"" class=""btn-edit btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1"">
                <span class=""svg-icon svg-icon-3 svg-icon-warning"">
                    <svg xmlns=""");
            WriteLiteral(@"http://www.w3.org/2000/svg"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                        <path d=""M12.2674799,18.2323597 L12.0084872,5.45852451 C12.0004303,5.06114792 12.1504154,4.6768183 12.4255037,4.38993949 L15.0030167,1.70195304 L17.5910752,4.40093695 C17.8599071,4.6812911 18.0095067,5.05499603 18.0083938,5.44341307 L17.9718262,18.2062508 C17.9694575,19.0329966 17.2985816,19.701953 16.4718324,19.701953 L13.7671717,19.701953 C12.9505952,19.701953 12.2840328,19.0487684 12.2674799,18.2323597 Z"" fill=""#000000"" fill-rule=""nonzero"" transform=""translate(14.701953, 10.701953) rotate(-135.000000) translate(-14.701953, -10.701953)""></path>
                        <path d=""M12.9,2 C13.4522847,2 13.9,2.44771525 13.9,3 C13.9,3.55228475 13.4522847,4 12.9,4 L6,4 C4.8954305,4 4,4.8954305 4,6 L4,18 C4,19.1045695 4.8954305,20 6,20 L18,20 C19.1045695,20 20,19.1045695 20,18 L20,13 C20,12.4477153 20.4477153,12 21,12 C21.5522847,12 22,12.4477153 22,13 L22,18 C22,20.209139 20.209139,22 18,22 L6,22 C3.");
            WriteLiteral("790861,22 2,20.209139 2,18 L2,6 C2,3.790861 3.790861,2 6,2 L12.9,2 Z\" fill=\"#000000\" fill-rule=\"nonzero\" opacity=\"0.3\"></path>\r\n                    </svg>\r\n                </span>\r\n            </a>\r\n        </td>\r\n    </tr>\r\n</script>\r\n\r\n");
#nullable restore
#line 68 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\SupportManage\Index.cshtml"
Write(Html.Partial("_EditModal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
