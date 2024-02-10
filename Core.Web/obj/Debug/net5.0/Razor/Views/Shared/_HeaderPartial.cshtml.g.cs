#pragma checksum "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "edfe3b774c150690404d59d2e33c41785917bc12b2e27cabdc235b4309fea091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/_HeaderPartial.cshtml")]
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
#nullable restore
#line 1 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
using Core.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"edfe3b774c150690404d59d2e33c41785917bc12b2e27cabdc235b4309fea091", @"/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66b5014f14d9daa5c6738d3858a41272ddcd8c255e4669d385dce7ff8b4049a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<header class=""header-area wow fadeInDown"" data-wow-delay=""0.2s"">
    <div class=""classy-nav-container breakpoint-off"">
        <div class=""container"">
            <!-- Classy Menu -->
            <nav class=""classy-navbar justify-content-between"" id=""dreamNav"">

                <!-- Logo -->
                <a class=""nav-brand logo-top"" href=""/""><img draggable=""false"" src=""/images/tokenlogo.png"" alt=""MaticStaking""></a>

                <!-- Navbar Toggler -->
                <div class=""classy-navbar-toggler"">
                    <span class=""navbarToggler""><span></span><span></span><span></span></span>
                </div>

                <!-- Menu -->
                <div class=""classy-menu"">

                    <!-- close btn -->
                    <div class=""classycloseIcon"">
                        <div class=""cross-wrap""><span class=""top""></span><span class=""bottom""></span></div>
                    </div>

                    <!-- Nav Start -->
                    <div c");
            WriteLiteral(@"lass=""classynav"">
                        <ul id=""nav"">
                            <li><a href=""#home"">Home</a></li>
                            <li><a href=""#about"">About</a></li>
                            <li><a href=""#services"">Staking</a></li>
                            <li><a href=""#roadmap"">Roadmap</a></li>
                            <li><a href=""#team"">Team</a></li>
                            <li><a href=""#partnership"">Partnership</a></li>
                            <li><a href=""https://docs.maticstaking.io/"" target=""_blank"">Whitepaper</a></li>
                            <li><a href=""#contact"">Contact</a></li>
                        </ul>

                        <!-- Button -->
");
#nullable restore
#line 44 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" id=\"txtIsAuthed\" value=\"true\" />\r\n                            <input type=\"hidden\" id=\"txtIdentityAddr\"");
            BeginWriteAttribute("value", " value=\"", 2180, "\"", 2217, 1);
#nullable restore
#line 47 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
WriteAttributeValue("", 2188, User.Identity.Name.ToUpper(), 2188, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 49 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
                             if (User.GetSpecificClaim("RoleName") != "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"/home\" class=\"btn login-btn ml-50\">My Account</a>\r\n");
#nullable restore
#line 52 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"/home\" class=\"btn login-btn ml-50\">System</a>\r\n");
#nullable restore
#line 56 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"javascript:void(0)\" onclick=\"return dapp.ProcessConnectWallet()\" class=\"btn login-btn ml-50\">Connect Wallet</a>\r\n");
#nullable restore
#line 61 "D:\Projects\MaticStaking\Core.Web\Views\Shared\_HeaderPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <!-- Nav End -->\r\n                </div>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
