#pragma checksum "D:\Projects\MaticStaking\Core.Web\Views\Blog\BlogDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "390c429a66ae3ffac280b6b73e5e6ccb597ded878da8ce0c855f5a88c5e99fb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetail), @"mvc.1.0.view", @"/Views/Blog/BlogDetail.cshtml")]
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
#line 1 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.BlockChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.Saving;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Application.ViewModels.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\MaticStaking\Core.Web\Views\_ViewImports.cshtml"
using Core.Utilities.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"390c429a66ae3ffac280b6b73e5e6ccb597ded878da8ce0c855f5a88c5e99fb0", @"/Views/Blog/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66b5014f14d9daa5c6738d3858a41272ddcd8c255e4669d385dce7ff8b4049a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.Models.BlogViewModels.DetailViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\MaticStaking\Core.Web\Views\Blog\BlogDetail.cshtml"
  
    Layout = "_LayoutBlog";

    ViewBag.Title = Model.Blog.SeoPageTitle;
    ViewBag.Keywords = Model.Blog.SeoKeywords;
    ViewBag.Description = Model.Blog.SeoDescription;
    ViewBag.Image = Model.Blog.Image;
    ViewBag.Url = $"https://icdefi.org/{Model.Blog.SeoAlias}-b.{Model.Blog.Id}.html";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        img {\r\n            max-width: 100%;\r\n        }\r\n\r\n        .news {\r\n            padding-top: 130px;\r\n            padding-bottom: 130px;\r\n        }\r\n    </style>\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<section class=""news"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <div class=""section-header section-header--center section-header--small-margin"">
                    <span style=""color:red;font-family:Roboto"">");
#nullable restore
#line 31 "D:\Projects\MaticStaking\Core.Web\Views\Blog\BlogDetail.cshtml"
                                                          Write(Model.Blog.DateModified.ToString("MM-dd-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h1 style=\"max-width:100%;font-size:30px;\">");
#nullable restore
#line 32 "D:\Projects\MaticStaking\Core.Web\Views\Blog\BlogDetail.cshtml"
                                                          Write(Model.Blog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
#nullable restore
#line 38 "D:\Projects\MaticStaking\Core.Web\Views\Blog\BlogDetail.cshtml"
           Write(Html.Raw(Model.Blog.MildContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.Models.BlogViewModels.DetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591