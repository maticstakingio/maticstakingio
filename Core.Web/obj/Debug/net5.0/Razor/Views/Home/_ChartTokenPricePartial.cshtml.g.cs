#pragma checksum "D:\Projects\MaticStaking\Core.Web\Views\Home\_ChartTokenPricePartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d8ed1df0325b67c2cb357faf64a1f064f382a5bffce4fd2c1e2e80b39439d665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ChartTokenPricePartial), @"mvc.1.0.view", @"/Views/Home/_ChartTokenPricePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d8ed1df0325b67c2cb357faf64a1f064f382a5bffce4fd2c1e2e80b39439d665", @"/Views/Home/_ChartTokenPricePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66b5014f14d9daa5c6738d3858a41272ddcd8c255e4669d385dce7ff8b4049a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__ChartTokenPricePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""elementor-section elementor-top-section elementor-element elementor-element-299853f elementor-section-boxed elementor-section-height-default elementor-section-height-default"" id=""299853f22"" data-id=""299853f"" data-element_type=""section"">
    <div class=""elementor-container elementor-column-gap-default jws_section_"">
        <div class=""elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-8c6cb4f"" data-id=""8c6cb4f"" data-element_type=""column"">
            <div class=""elementor-widget-wrap elementor-element-populated"">
                <div class=""elementor-element elementor-element-557d9be elementor-widget elementor-widget-heading"" data-id=""557d9be"" data-element_type=""widget"" data-widget_type=""heading.default"">
                    <div class=""elementor-widget-container"">
                        <h4 class=""elementor-heading-title elementor-size-default"">Chart Price Histories</h4>
");
            WriteLiteral(@"                    </div>
                </div>
                <section class=""elementor-section elementor-inner-section elementor-element elementor-element-460ad53 elementor-section-full_width elementor-section-height-default elementor-section-height-default"" data-id=""460ad53"" data-element_type=""section"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 1470, "\"", 1478, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <script type=\"text/javascript\"");
            BeginWriteAttribute("src", " src=\"", 1536, "\"", 1608, 2);
            WriteAttributeValue("", 1542, "https://unpkg.com/", 1542, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 1562, "coinpaprika/widget-currency/dist/widget.min.js", 1562, 46, true);
            EndWriteAttribute();
            WriteLiteral(@"></script><div class=""coinpaprika-currency-widget"" data-primary-currency=""usd"" data-currency=""MST-hebeto"" data-modules='[""chart""]' data-update-active=""false""></div>
                    </div>
                </section>
            </div>
        </div>
    </div>
</section>");
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
