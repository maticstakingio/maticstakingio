#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28e59999454452ee484e2d060c1c411b4a880b78e61520a6f67ea39b059668ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MenuGroup_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MenuGroup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28e59999454452ee484e2d060c1c411b4a880b78e61520a6f67ea39b059668ac", @"/Areas/Admin/Views/MenuGroup/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_MenuGroup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/menu-group/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/menu-group/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
  
    ViewBag.Title = "Menu Group";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e59999454452ee484e2d060c1c411b4a880b78e61520a6f67ea39b059668ac6371", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
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
                WriteLiteral("\r\n    <script>\r\n        var menuGroupObj = new MenuGroupController();\r\n        menuGroupObj.initialize();\r\n    </script>\r\n");
            }
            );
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28e59999454452ee484e2d060c1c411b4a880b78e61520a6f67ea39b059668ac8595", async() => {
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
#line 12 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
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
            WriteLiteral(@"
<div class=""app-content icon-content"">
    <div class=""section"">
        <!-- Page-header opened -->
        <div class=""page-header"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-package mr-1""></i> Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
#nullable restore
#line 21 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
                                                                  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</li>\r\n            </ol>\r\n            <div class=\"mt-3 mt-lg-0\">\r\n");
            WriteLiteral(@"            </div>
        </div>
        <!-- Page-header closed -->
        <!-- row opened -->
        <div class=""row"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""card-title"">Menu Group</div>
                        <div class=""card-options"">
                            <a href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                            <a href=""#"" class=""card-options-fullscreen"" data-toggle=""card-fullscreen""><i class=""fe fe-maximize""></i></a>
                            <a href=""#"" class=""card-options-remove"" data-toggle=""card-remove""><i class=""fe fe-x""></i></a>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive product-datatable"">
                            <div id=""example_wrapper"" class=""dataTables");
            WriteLiteral(@"_wrapper dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12 col-md-4"">
                                        <div id=""example_filter"" class=""dataTables_filter"">
                                            <label>Search:<input type=""search"" id=""txt-search-keyword"" class=""form-control form-control-sm""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2805, "\"", 2819, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-controls=""example""></label>
                                        </div>
                                    </div>
                                    <div class=""col-sm-12 col-md-4"">
                                        <div id=""example_filter"" class=""dataTables_filter"">
                                            <label>
                                                Role: ");
#nullable restore
#line 56 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
                                                 Write(Html.DropDownList("RoleId", null, "All", new { @class = "custom-select custom-select-sm form-control form-control-sm", id = "SearchRoleId" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </label>
                                        </div>
                                    </div>
                                    <div class=""col-sm-12 col-md-4"">
                                        <div class=""dataTables_component"">
                                            <button id=""btn-create"" type=""button"" class=""btn btn-sm btn-success "" data-toggle=""modal"" data-target="".bd-example-modal-lg""><i class=""fa fa-plus""></i> Create</button>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table id=""example"" class=""table table-striped table-bordered dataTable no-footer"" role=""grid"" aria-describedby=""example_info"">
                                            <thead>
                                                <tr");
            WriteLiteral(@">
                                                    <th>No</th>
                                                    <th>Name</th>
                                                    <th>Role</th>
                                                    <th>Status</th>
                                                    <th width=""100"">Function</th>
                                                </tr>
                                            </thead>
                                            <tbody id=""tbl-content""></tbody>
                                        </table>
                                    </div>
                                </div>
                                ");
#nullable restore
#line 82 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
                           Write(await Component.InvokeAsync("Paging"));

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

<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td>{{Id}}</td>
        <td>{{Name}}</td>
        <td>{{Role}}</td>
        <td>{{{Status}}}</td>
        <td width=""130"">
            <a href=""/admin/menuitem/index/{{Id}}"" class=""btn-detail btn btn-primary btn-sm mb-2 mb-xl-0 text-white"" data-toggle=""tooltip"" data-original-title=""Menu Item""><i class=""fa fa-eye""></i></a>
            <a href=""#"" data-id=""{{Id}}"" class=""btn-edit btn btn-warning btn-sm mb-2 mb-xl-0 text-white"" data-toggle=""tooltip"" data-original-title=""Cập Nhật""><i class=""fa fa-edit""></i></a>
            <a href=""#"" data-id=""{{Id}}"" class=""btn-delete btn btn-danger btn-sm mb-xl-0 text-white"" data-toggle=""tooltip"" data-original-title=""Xóa""><i class=""fa fa-trash-o""></i></a>
        </td>
    </tr>
</script>
");
#nullable restore
#line 105 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\MenuGroup\Index.cshtml"
Write(Html.Partial("_AddEditModal"));

#line default
#line hidden
#nullable disable
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
