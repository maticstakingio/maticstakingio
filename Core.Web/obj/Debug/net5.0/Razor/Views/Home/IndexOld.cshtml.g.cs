#pragma checksum "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac57482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexOld), @"mvc.1.0.view", @"/Views/Home/IndexOld.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac57482", @"/Views/Home/IndexOld.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66b5014f14d9daa5c6738d3858a41272ddcd8c255e4669d385dce7ff8b4049a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_IndexOld : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/home/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-app/controllers/home/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/facebook-4.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h-20px me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/github.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/linkedin-1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/twitter.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/telegram-2.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/telegram.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/demo1/dist/assets/media/svg/brand-logos/youtube-play.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
  
    ViewBag.Title = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748210131", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748211490", async() => {
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
                WriteLiteral("\r\n    <script>\r\n        var homeObj = new HomeController();\r\n        homeObj.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""d-flex flex-column flex-column-fluid"">

    <div id=""kt_app_content"" class=""app-content flex-column-fluid pt-6 pt-lg-10"">
        <div id=""kt_app_content_container"" class=""app-container container-xxl"">
            <div class=""tradingview-widget-container mb-5"">
                <div class=""tradingview-widget-container__widget"" id=""ticker-tape"">
                </div>
            </div>
            <div class=""row gx-5 gx-xl-10"">
                <div class=""col-xl-12 mb-10 mb-xl-10"">
                    ");
#nullable restore
#line 29 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_BannerPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row gx-5 gx-xl-10\">\r\n                <div class=\"col-xl-12 mb-10 mb-xl-10\">\r\n                    ");
#nullable restore
#line 34 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_ChartTokenPricePartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n\r\n            <div class=\"row gx-5 gx-xl-10\">\r\n                <div class=\"col-xl-5 mb-10 mb-xl-10\">\r\n                    ");
#nullable restore
#line 43 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_RoadmapPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-xl-7 mb-10 mb-xl-10\">\r\n                    ");
#nullable restore
#line 46 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_TokenNomicsPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row gx-5 gx-xl-10\">\r\n                <div class=\"col-xl-6 mb-5 mb-xl-5\">\r\n                    ");
#nullable restore
#line 52 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_TeamPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-xl-6 mb-5 mb-xl-5\">\r\n                    ");
#nullable restore
#line 55 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_PartnerPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row gx-5 gx-xl-10\">\r\n                <div class=\"col-xl-12 mb-5 mb-xl-5\">\r\n                    ");
#nullable restore
#line 61 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_StakingLeaderBoardPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row gx-5 gx-xl-10\">\r\n                <div class=\"col-xl-12 mb-5 mb-xl-5\">\r\n                    ");
#nullable restore
#line 67 "D:\Projects\MaticStaking\Core.Web\Views\Home\IndexOld.cshtml"
               Write(await Html.PartialAsync("_InvestProfitHistoryPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>



            <div class=""container"">
                <div class=""row py-10 py-lg-20"">

                    <div class=""col-lg-4 pe-lg-2 mb-10 mb-lg-0"">
                        <iframe width=""100%"" height=""315"" src=""https://www.youtube.com/embed/xAC-AUiT7hc?autoplay=1""
                                title=""YouTube video player"" frameborder=""0""
                                allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                                allowfullscreen></iframe>
                    </div>

                    <div class=""col-lg-4 ps-lg-10 pe-lg-2 mb-10 mb-lg-0"">
                        <div class=""rounded landing-dark-border p-9 mb-10"">
                            <h3 class=""text-dark"">Contact us via</h3>
                            <span class=""fw-normal fs-4 text-gray-700"">
                                Email us to
                                <a href=""#"" class=""text-prima");
            WriteLiteral(@"ry text-hover-primary"">support@MST.com</a>
                            </span>
                        </div>
                        <div class=""rounded landing-dark-border p-9"">
                            <h3 class=""text-dark"">Company Address</h3>
                            <span class=""fw-normal fs-4 text-gray-700"">
                                12, Scarcroft Road, Portchester, United Kingdom.
                            </span>
                        </div>
                    </div>

                    <div class=""col-lg-4 ps-lg-2"">
                        <div class=""d-flex justify-content-center"">
                            <div class=""d-flex fw-semibold flex-column me-10"">
                                <h4 class=""fw-bold text-dark mb-6"">More</h4>
                                <a href=""#"" class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Home</a>
                                <a href=""https://docs.MST.com/"" target=""_blank"" class=""text-dark opacity-50 text-hover-prim");
            WriteLiteral(@"ary fs-5 mb-6"">Document</a>
                                <a href=""/admin/investtrading/index"" class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Bot Trade</a>
                                <a href=""/admin/staking/index"" class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Staking</a>
                                <a href=""/admin/airdrop/index"" class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Airdrop</a>
                                <a href=""/admin/wallet/index"" class=""text-dark opacity-50 text-hover-primary fs-5"">Wallet</a>
                            </div>
                            <div class=""d-flex fw-semibold flex-column ms-lg-8"">
                                <h4 class=""fw-bold text-dark mb-6"">Stay Connected</h4>
                                <a href=""https://www.facebook.com/MSTteam"" target=""_blank"" class=""mb-6"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748219551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Facebook</span>
                                </a>
                                <a href=""https://github.com/MSTteam/Core"" target=""_blank"" class=""mb-6"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748221075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Github</span>
                                </a>
                                <a href=""https://www.linkedin.com/company/MST/"" target=""_blank"" class=""mb-6"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748222603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Linkedin</span>
                                </a>
                                <a href=""https://twitter.com/MST_Official"" target=""_blank"" class=""mb-6"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748224128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Twitter</span>
                                </a>
                                <a href=""https://t.me/MSTteamofficial"" target=""_blank"" class=""mb-6"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748225648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Telegram Official</span>
                                </a>
                                <a href=""https://t.me/MSTcommunities"" target=""_blank"" class=""mb-6"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748227177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <span class=\"text-dark opacity-50 text-hover-primary fs-5 mb-6\">Telegram Community</span>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7743, "\"", 7787, 2);
            WriteAttributeValue("", 7750, "https://www.youtube.com/", 7750, 24, true);
            WriteLiteral("@");
            WriteAttributeValue("", 7776, "MSTofficial", 7776, 11, true);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"mb-6\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdbe62ed5953ccc5ebd284a408ae0ce2c7d9291db5fce9168fc0daabac5748229013", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <span class=""text-dark opacity-50 text-hover-primary fs-5 mb-6"">Youtube</span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591