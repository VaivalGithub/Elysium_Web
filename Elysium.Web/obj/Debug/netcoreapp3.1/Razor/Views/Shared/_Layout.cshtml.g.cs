#pragma checksum "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3723f1b0085ea24afe7ce20e4355a31e52f722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\Elysium_Web\Elysium.Web\Views\_ViewImports.cshtml"
using Elysium.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Elysium_Web\Elysium.Web\Views\_ViewImports.cshtml"
using Elysium.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c3723f1b0085ea24afe7ce20e4355a31e52f722", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2deca9c6d198610e8f41659b22e7ffed3b8482", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("shortcut icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("size", new global::Microsoft.AspNetCore.Html.HtmlString("16*16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/favicon.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3723f1b0085ea24afe7ce20e4355a31e52f7226550", async() => {
                WriteLiteral("\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c3723f1b0085ea24afe7ce20e4355a31e52f7226959", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Stylesheet CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2c3723f1b0085ea24afe7ce20e4355a31e52f7228346", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <title>Elysium | Substrate based Smart Contract Platform</title>\r\n    <meta name=\"description\" content=\"Elysium is a new Substrate based smart contract platform that makes it easy to build natively interoperable blockchain applications.\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3723f1b0085ea24afe7ce20e4355a31e52f72210485", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <header id=""header"">
            <nav class=""navbar navbar-dark navbar-expand-lg py-2"">
                <div class=""container position-relative"">
                    <a class=""navbar-brand"" href=""/Home/Index"">
                        <img src=""/images/logo.png"" alt=""Logo"" class=""img-fluid"" />
                    </a>
                    <button class=""navbar-toggler shadow-none collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#Menu"" aria-controls=""Menu"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div id=""Menu"" class=""navbar-collapse collapse p-4 p-lg-0"">
                        <div class=""d-flex justify-content-between"">
                            <button class=""navbar-toggler shadow-none border-0 p-0 collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#Menu"" aria-controls=""Menu"" aria-expanded=""false""");
                WriteLiteral(@" aria-label=""Toggle navigation"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""19.357"" height=""19.357"" viewBox=""0 0 19.357 19.357"">
                                    <path id=""close"" d=""M24.973,84.781l8.5-8.5a.688.688,0,1,0-.972-.973L24,83.808l-8.5-8.5a.688.688,0,0,0-.973.973l8.505,8.5-8.505,8.5a.688.688,0,0,0,.973.973l8.5-8.5,8.505,8.5a.688.688,0,1,0,.972-.973Z"" transform=""translate(-14.322 -75.102)"" fill=""#fff""></path>
                                </svg>
                            </button>
");
                WriteLiteral(@"                        </div>
                        <ul class=""navbar-nav align-items-lg-center ms-auto"">
                            <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-lg-0"">
                                <a id=""Technology"" class=""nav-link text-uppercase"" href=""/Home/Index"">
                                    TECHNOLOGY
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-lg-0"">
                                <a id=""Community"" class=""nav-link text-uppercase"" href=""/Community"">
                                    COMMUNITY
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-lg-0"">
                                <a id=""About"" class=""nav-link text-uppercase"" href=""/About"">
                                    ABOUT
                                </a>
                            </li>
 ");
                WriteLiteral(@"                           <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-lg-0"">
                                <a id=""Developer"" class=""nav-link text-uppercase"" href=""/Developer"">
                                    DEVELOPER
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-lg-0"">
                                <a id=""Blog"" class=""nav-link text-uppercase"" href=""/Blog"">
                                    BLOG
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-lg-0"">
                                <a id=""Contact"" class=""nav-link text-uppercase"" href=""/Contact"">
                                    CONTACT
                                </a>
                            </li>
                            <li class=""nav-item pt-2 pt-lg-0 d-none d-lg-inline-block"">
                                <a c");
                WriteLiteral(@"lass=""BtnGreen text-uppercase py-2 px-3 rounded-pill d-inline-block"" href=""#"">
                                    GET STARTED
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </header>
        ");
#nullable restore
#line 79 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <footer id=""footer"" class=""Fsize_14 RobotoLight text-white"">
            <div class=""container"">
                <div class=""border-top border-bottom py-5"">
                    <div class=""row pt-5"">
                        <div class=""col-md-3 mb-5 mb-md-0"">
                            <img src=""/images/logo-white.png"" alt=""Logo"" class=""img-fluid d-block mb-2 mb-md-4"" />
                            <a");
                BeginWriteAttribute("class", " class=\"", 5199, "\"", 5207, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" href=\"#\"><i class=\"icon-facebook Fsize_42\"></i></a>\r\n                            <a");
                BeginWriteAttribute("class", " class=\"", 5308, "\"", 5316, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" href=\"#\"><i class=\"icon-twitter Fsize_42\"></i></a>\r\n                            <a");
                BeginWriteAttribute("class", " class=\"", 5416, "\"", 5424, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" href=\"#\"><i class=\"icon-instagram Fsize_42\"></i></a>\r\n                            <a");
                BeginWriteAttribute("class", " class=\"", 5526, "\"", 5534, 0);
                EndWriteAttribute();
                WriteLiteral(@" target=""_blank"" href=""#""><i class=""icon-linkedin Fsize_42""></i></a>
                        </div>
                        <div class=""col-md-2 mb-5 mb-md-0 ms-md-auto"">
                            <h6 class=""mb-2 mb-md-4"">ELYSIUM</h6>
                            <ul class=""list-unstyled mb-0"">
                                <li class=""py-1""><a href=""/About"">About</a></li>
                                <li class=""py-1""><a href=""#"">FAQ</a></li>
                                <li class=""py-1""><a href=""#"">Support</a></li>
                                <li class=""py-1""><a href=""#"">Build</a></li>
                                <li class=""py-1""><a class=""RobotoBold"" href=""#"">Grants and Bounties</a></li>
                                <li class=""py-1""><a href=""#"">Careers</a></li>
                            </ul>
                        </div>
                        <div class=""col-md-2 mb-5 mb-md-0 ms-md-auto"">
                            <h6 class=""mb-2 mb-md-4"">TECHNOLOGY</h6>
           ");
                WriteLiteral(@"                 <ul class=""list-unstyled mb-0"">
                                <li class=""py-1""><a href=""/Home"">Technology</a></li>
                                <li class=""py-1""><a href=""#"">Roadmap</a></li>
                                <li class=""py-1""><a href=""#"">Token</a></li>
                                <li class=""py-1""><a href=""#"">Telemetry</a></li>
                                <li class=""py-1""><a class=""RobotoBold"" href=""#"">Substrate</a></li>
                                <li class=""py-1""><a href=""#"">Lightpaper</a></li>
                            </ul>
                        </div>
                        <div class=""col-md-2 ms-md-auto"">
                            <h6 class=""mb-2 mb-md-4"">COMMUNITY</h6>
                            <ul class=""list-unstyled mb-0"">
                                <li class=""py-1""><a href=""/Community"">Community</a></li>
                                <li class=""py-1""><a href=""#"">Documentation</a></li>
                                <li cl");
                WriteLiteral(@"ass=""py-1""><a href=""#"">Brand Assets</a></li>
                                <li class=""py-1""><a href=""/Home/Blog"">Blog</a></li>
                                <li class=""py-1""><a class=""RobotoBold"" href=""#"">Element Chat</a></li>
                                <li class=""py-1""><a href=""#"">Medium</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""d-sm-flex justify-content-between py-3 py-sm-5"">
                    © 2022 Elysium
                    <ul class=""d-inline-flex list-unstyled mb-0 pt-2 pt-sm-0"">
                        <li class=""me-3""><a href=""#"">Disclaimer</a></li>
                        <li class=""me-3""><a href=""/Privacy"">Privacy</a></li>
                        <li><a href=""#"">Cookie Settings</a></li>
                    </ul>
                </div>
            </div>
        </footer>

    </div>

    <script src=""https://kit.fontawesome.com/4f472b9b00.js"" crossorigin=""an");
                WriteLiteral("onymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3723f1b0085ea24afe7ce20e4355a31e52f72219868", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3723f1b0085ea24afe7ce20e4355a31e52f72220968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3723f1b0085ea24afe7ce20e4355a31e52f72222068", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 143 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>

    var currentLocation = window.location.href;
    if (currentLocation.indexOf(""Home"") >= 0) {
        $(""#Technology"").addClass('active');
    }
    else if (currentLocation.indexOf(""Community"") >= 0) {
        $(""#Community"").addClass('active');
    }
    else if (currentLocation.indexOf(""About"") >= 0) {
        $(""#About"").addClass('active');
    }
    else if (currentLocation.indexOf(""Developer"") >= 0) {
        $(""#Developer"").addClass('active');
    }
    else if (currentLocation.indexOf(""Contact"") >= 0) {
        $(""#Contact"").addClass('active');
    }

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
