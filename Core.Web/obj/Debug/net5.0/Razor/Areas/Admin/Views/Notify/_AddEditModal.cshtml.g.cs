#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Notify\_AddEditModal.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2edfab800b544f91ea805f1e7e788893fa441573a2d259a07f13413f407c0ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Notify__AddEditModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Notify/_AddEditModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2edfab800b544f91ea805f1e7e788893fa441573a2d259a07f13413f407c0ef6", @"/Areas/Admin/Views/Notify/_AddEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Notify__AddEditModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""modal-add-edit"" class=""modal fade"" tabindex=""-1"" data-backdrop=""static""  aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title badge badge-secondary-light"" id=""exampleModalLabel"">
                    Thêm & cập nhật bài viết
                </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">
                        &times;
                    </span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2edfab800b544f91ea805f1e7e788893fa441573a2d259a07f13413f407c0ef66115", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <input type=""hidden"" id=""hidId"" value=""0"" />
                        <label for=""txtName"" class=""form-control-label""> Tên Bài Viết</label>
                        <input type=""text"" id=""txtName"" class=""form-control"">
                    </div>

                    <div class=""form-group"">
                        <label for=""ddlBlogCategoryId"" class=""form-control-label"">Loại Bài Viết</label>
                        <input id=""ddlBlogCategoryId"" class=""form-control"" name=""ddlBlogCategoryId""");
                BeginWriteAttribute("value", " value=\"", 1340, "\"", 1348, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"txtName\" class=\"form-control-label\">Chủ Đề (Tags)</label>\r\n                        ");
#nullable restore
#line 30 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Notify\_AddEditModal.cshtml"
                   Write(Html.DropDownList("Tags", null, new { id = "ddlTags", multiple = true, @class = "form-control select2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                    <div class=""form-group"">
                        <label for=""txtImage"" class=""form-control-label""> Ảnh bìa</label>
                        <div class=""input-group"">
                            <input type=""text"" id=""txtImage"" class=""form-control"" />
                            <input type=""file"" id=""fileInputImage"" style=""display:none"" />
                            <span class=""input-group-btn"">
                                <input type=""button"" id=""btnSelectImg"" class=""btn btn-default"" value=""Browser"" />
                            </span>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""txtDescription"" class=""form-control-label""> Tóm tắt</label>
                        <textarea id=""txtDescription"" rows=""4"" class=""form-control""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""");
                WriteLiteral(@"txtName"" class=""form-control-label"">Link Giới Thiệu</label>
                        <input type=""text"" id=""txtReferralLink"" class=""form-control"">
                    </div>

                    <div class=""form-group"">
                        <label for=""txtName"" class=""form-control-label"">Link Quy Tắt</label>
                        <input type=""text"" id=""txtReferralLinkRule"" class=""form-control"">
                    </div>

                    <div class=""form-group"">
                        <label for=""txtVideo"" class=""form-control-label""> Video</label>
                        <textarea id=""txtVideo"" rows=""2"" class=""form-control""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""txtComment"" class=""form-control-label""> Comment</label>
                        <textarea id=""txtComment"" rows=""2"" class=""form-control""></textarea>
                    </div>

                    <div class=""form-group"">
                     ");
                WriteLiteral(@"   <label for=""txtShare"" class=""form-control-label""> Share</label>
                        <textarea id=""txtShare"" rows=""2"" class=""form-control""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""txtLike"" class=""form-control-label""> Like</label>
                        <textarea id=""txtLike"" rows=""2"" class=""form-control""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""txtContent"" class=""form-control-label""> Tổng quan</label>
                        <textarea id=""txtContent"" rows=""20"" class=""form-control""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""txtSeoPageTitle"" class=""form-control-label""> Seo Page Title</label>
                        <input type=""text"" id=""txtSeoPageTitle"" class=""form-control"">
                    </div>

                    <div class=""form-group"">
   ");
                WriteLiteral(@"                     <label for=""txtSeoKeywords"" class=""form-control-label""> Seo Keywords</label>
                        <input type=""text"" id=""txtSeoKeywords"" class=""form-control"">
                    </div>

                    <div class=""form-group"">
                        <label for=""txtSeoDescription"" class=""form-control-label""> Seo Description</label>
                        <input type=""text"" id=""txtSeoDescription"" class=""form-control"">
                    </div>

                    <div class=""form-group"">
                        <label class=""custom-control custom-checkbox"">
                            <input type=""checkbox"" class=""custom-control-input"" checked=""checked"" id=""ckStatus"">
                            <span class=""custom-control-label"">Trạng thái</span>
                        </label>

                        <label class=""custom-control custom-checkbox"">
                            <input type=""checkbox"" class=""custom-control-input"" checked=""checked"" id=""ckHot"">
   ");
                WriteLiteral(@"                         <span class=""custom-control-label"">Bài viết hot</span>
                        </label>

                        <label class=""custom-control custom-checkbox"">
                            <input type=""checkbox"" class=""custom-control-input"" checked=""checked"" id=""ckShowHome"">
                            <span class=""custom-control-label"">Hiển thị trang chủ</span>
                        </label>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""button"" id=""btnSave"" class=""btn btn-success"">Lưu</button>
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