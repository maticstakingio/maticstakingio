#pragma checksum "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Profile), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a", @"/Areas/Admin/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2dffb24d9cb6ba15f179ef9432cc1c75f63f6b98023b4db7d1953accf4118aaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUserViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/client-app/controllers/account/my-profile.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery-qrcode-master/src/jquery.qrcode.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery-qrcode-master/src/qrcode.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("heading-left-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client-side/earntoken/assets/images/icons/steps.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Steps-Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
  
    ViewBag.Title = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a8336", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a10312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 8 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a12289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 9 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
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
                WriteLiteral(@"
    <script>
        var myProfileObj = new MyProfileController();
        myProfileObj.initialize();
    </script>

    <script>
        document.getElementById(""btnCopyReferralLink"").addEventListener(""click"", function () {
            copyToClipboard(document.getElementById(""txtReferralLink""));
        });

        function copyToClipboard(elem) {
            // create hidden text element, if it doesn't already exist
            var targetId = ""_hiddenCopyText_"";
            var isInput = elem.tagName === ""INPUT"" || elem.tagName === ""TEXTAREA"";
            var origSelectionStart, origSelectionEnd;
            if (isInput) {
                // can just use the original source element for the selection and copy
                target = elem;
                origSelectionStart = elem.selectionStart;
                origSelectionEnd = elem.selectionEnd;
            } else {
                // must use a temporary form element for the selection and copy
                target = document.g");
                WriteLiteral(@"etElementById(targetId);
                if (!target) {
                    var target = document.createElement(""textarea"");
                    target.style.position = ""absolute"";
                    target.style.left = ""-9999px"";
                    target.style.top = ""0"";
                    target.id = targetId;
                    document.body.appendChild(target);
                }
                target.textContent = elem.textContent;
            }
            // select the content
            var currentFocus = document.activeElement;
            target.focus();
            target.setSelectionRange(0, target.value.length);

            // copy the selection
            var succeed;
            try {
                succeed = document.execCommand(""copy"");
            } catch (e) {
                succeed = false;
            }
            // restore original focus
            if (currentFocus && typeof currentFocus.focus === ""function"") {
                currentFocus.focus();
");
                WriteLiteral(@"            }

            if (isInput) {
                // restore prior selection
                elem.setSelectionRange(origSelectionStart, origSelectionEnd);
            } else {
                // clear temporary content
                target.textContent = """";
            }

            be.notify('Copy to clipboard is successful', 'success');

            return succeed;
        }
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""gamfi-breadcrumbs-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-5"">
                <div class=""breadcrumbs-area sec-heading"">
                    <div class=""sub-inner mb-15"">
                        <a class=""breadcrumbs-link"" href=""/"">Home</a>
                        <span class=""sub-title"">Account</span>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a17307", async() => {
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
            WriteLiteral("\r\n                    </div>\r\n                    <h2 class=\"title mb-0\">Profile</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3561, "\"", 3581, 1);
#nullable restore
#line 92 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3569, Model.Email, 3569, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""email"" />


<div class=""gamfi-explore-content gamfi-previous-section pt-70 md-pt-80 pb-200 md-pb-200"">
    <div class=""container"">
        <!-- Tab Menu Section Start -->
        <div class=""project-menu-area d-flex align-items-center justify-content-between"">
            <div class=""project-left-menu"">
                <ul class=""nav"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""tab-link active"" id=""home-tab"" data-bs-toggle=""tab""
                                data-bs-target=""#open-igo"" type=""button"" role=""tab""
                                aria-controls=""open-igo"" aria-selected=""true"">
                            Profile
                        </button>
                    </li>
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""tab-link"" id=""profile-tab"" data-bs-toggle=""tab""
                                data-bs-target=""#upcoming"" type=""button"" rol");
            WriteLiteral(@"e=""tab""
                                aria-controls=""upcoming"" aria-selected=""false"">
                            Change password
                        </button>
                    </li>
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""tab-link"" id=""fa-tab"" data-bs-toggle=""tab""
                                data-bs-target=""#fa"" type=""button"" role=""tab""
                                aria-controls=""2fa"" aria-selected=""false"">
                            2FA Management
                        </button>
                    </li>
                </ul>
            </div>

        </div>

        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""open-igo"" role=""tabpanel"" aria-labelledby=""home-tab"">
                <div class=""PoolAndTokenInfo_card"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h2>Profile Info <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a21267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span></h2>
                            <div class=""PoolAndTokenInfo_List"">
                                
                                <ul>
                                    <li>
                                        <p class=""PoolAndTokenInfo_List_left"">Email</p>
                                        <p class=""PoolAndTokenInfo_ListRight"">");
#nullable restore
#line 138 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
                                                                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </li>
                                    
                                    <li>
                                        <p class=""PoolAndTokenInfo_List_left"">Created Date</p>
                                        <p class=""PoolAndTokenInfo_ListRight"">");
#nullable restore
#line 143 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
                                                                         Write(Model.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </li>
                                    <li>
                                        <p class=""PoolAndTokenInfo_List_left"">Two Factor Authentication</p>
                                        <p class=""PoolAndTokenInfo_ListRight"">");
#nullable restore
#line 147 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
                                                                          Write(Model.Enabled2FA ? "Enabled":"Disabled");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </li>

                                    
                                </ul>
                                
                        </div>
                        
                               </div>
                        <div class=""col-md-6"">
                            <div class=""kycForm GetinTouchForm"">
                                <h2>Sponsor ID <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a24774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span></h2>\r\n                                <div class=\"InputNameSect\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a26108", async() => {
                WriteLiteral(@"
                                        <div class=""input-button group"">
                                            <i class=""icon-share"" id=""btnCopyReferralLink""></i>
                                            <input type=""text"" class=""enter"" id=""txtReferralLink""");
                BeginWriteAttribute("value", " value=\"", 7657, "\"", 7687, 1);
#nullable restore
#line 163 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
WriteAttributeValue("", 7665, $"{Model.Sponsor}" , 7665, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\">\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>

                               </div>
                    </div>
                </div>
            </div>

            <div class=""tab-pane fade"" id=""upcoming"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                <div class=""gamfi-form-content pt-10 md-pt-45 pb-120 md-pb-80"">
                    <div class=""container"">
                        <div class=""address-form project-item"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a28661", async() => {
                WriteLiteral(@"
                                <div class=""input-button"">
                                    <input type=""password"" id=""txtOld"" placeholder=""Enter old password"">
                                    <label for=""txtOld"">Current Password</label>
                                </div>

                                <div class=""input-button"">
                                    <input type=""password"" id=""txtNew"" placeholder=""Enter new password"">
                                    <label for=""txtNew"">New Password</label>
                                </div>

                                <div class=""input-button"">
                                    <input type=""password"" id=""txtConfirm"" placeholder=""Confirm new password"">
                                    <label for=""txtConfirm"">Confirm New password</label>
                                </div>

                                <div class=""text-center black-shape-big mt-20 mb-30"">
                                    <button id=""btnChan");
                WriteLiteral("gePassword\" name=\"submit\">Submit</button>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>

            <div class=""tab-pane fade"" id=""fa"" role=""tabpanel"" aria-labelledby=""fa-tab"">
                <div class=""gamfi-form-content pt-20 md-pt-45 pb-120 md-pb-80"">
                    <div class=""container"">
                        <div class=""address-form project-item"">

");
#nullable restore
#line 208 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
                             if (!Model.Enabled2FA)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 style=\"color:#ffa800\">Please use your authentication app (such as Duo or Google Authenticator) to scan this QR code.</h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a31993", async() => {
                WriteLiteral(@"
                                    <div style=""text-align: center; width: 100%; background: white; padding: 20px 0px;"" class=""qr-code"" id=""qrcodeAuthenticatorCode""></div>

                                    <div class=""input-button"">
                                        <input type=""text"" id=""txtAuthenticatorCode""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10460, "\"", 10474, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 10475, "\"", 10507, 1);
#nullable restore
#line 215 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
WriteAttributeValue("", 10483, Model.AuthenticatorCode, 10483, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>

                                    <div class=""input-button"">
                                        <input type=""text"" id=""verifyCode"" placeholder=""Authentication Code"">
                                        <label for=""verifyCode"">Authentication Code</label>
                                    </div>

                                    <div class=""project-btn-area text-center black-shape-big mt-20 mb-30"">
                                        <button id=""btnVerifyCode"">Verify Code</button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 227 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
                            }
                            else
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 style=\"color: #ffe501\">2FA is enabled , input your current password to disabled 2FA</h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef65ecfb5f0408aca70380c235f12963cdcd99e5e9b47ee975a850e934a230a35204", async() => {
                WriteLiteral(@"
                                    <div class=""input-button"">
                                        <input type=""password"" id=""confirmedPassword2FA"" placeholder=""Enter current password"">
                                        <label for=""confirmedPassword2FA"">Current Password</label>
                                    </div>

                                    <div class=""project-btn-area text-center black-shape-big mt-20 mb-30"">
                                        <button id=""btnDisabled2FA"">Disabled 2FA</button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 242 "D:\Projects\MaticStaking\Core.Web\Areas\Admin\Views\Account\Profile.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
