#pragma checksum "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "806c274424d5ff341445c32675dac255da53d45a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806c274424d5ff341445c32675dac255da53d45a", @"/Views/Shared/_Layout.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "806c274424d5ff341445c32675dac255da53d45a6550", async() => {
                WriteLiteral("\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "806c274424d5ff341445c32675dac255da53d45a6959", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "806c274424d5ff341445c32675dac255da53d45a8346", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "806c274424d5ff341445c32675dac255da53d45a10485", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <header id=""header"">
            <nav class=""navbar navbar-dark navbar-expand-xl py-2"">
                <div class=""container position-relative"">
                    <a class=""navbar-brand"" href=""/Home/Index"">
                        <img src=""/images/logo.png"" alt=""Logo"" class=""img-fluid"" />
                    </a>
                    <button class=""navbar-toggler shadow-none collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#Menu"" aria-controls=""Menu"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div id=""Menu"" class=""navbar-collapse collapse p-4 p-xl-0"">
                        <div class=""d-flex justify-content-between"">
                            <button class=""navbar-toggler shadow-none border-0 p-0 collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#Menu"" aria-controls=""Menu"" aria-expanded=""false""");
                WriteLiteral(@" aria-label=""Toggle navigation"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""19.357"" height=""19.357"" viewBox=""0 0 19.357 19.357"">
                                    <path id=""close"" d=""M24.973,84.781l8.5-8.5a.688.688,0,1,0-.972-.973L24,83.808l-8.5-8.5a.688.688,0,0,0-.973.973l8.505,8.5-8.505,8.5a.688.688,0,0,0,.973.973l8.5-8.5,8.505,8.5a.688.688,0,1,0,.972-.973Z"" transform=""translate(-14.322 -75.102)"" fill=""#fff""></path>
                                </svg>
                            </button>
                            <a class=""BtnGreen text-uppercase py-2 px-3 rounded-pill d-inline-block d-xl-none"" target=""_blank"" href=""https://elysiumscan.vulcanforged.com/"">
                                Explorer
                            </a>
                        </div>
                        <ul class=""navbar-nav align-items-xl-center ms-auto"">
                            <li class=""nav-item me-2 me-lg-2 me-xl-4 pt-2 pt-xl-0"">
                                <a i");
                WriteLiteral(@"d=""Technology"" class=""nav-link text-uppercase"" href=""/Home/Index"">
                                    TECHNOLOGY
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-xl-2 me-xxl-4 pt-2 pt-xl-0"">
                                <a id=""Community"" class=""nav-link text-uppercase"" href=""/Community"">
                                    COMMUNITY
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-xl-2 me-xxl-4 pt-2 pt-xl-0"">
                                <a id=""About"" class=""nav-link text-uppercase"" href=""/About"">
                                    ABOUT
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-xl-2 me-xxl-4 pt-2 pt-xl-0"">
                                <a id=""Developer"" class=""nav-link text-uppercase"" href=""/Developer"">
                                    DEVELOP");
                WriteLiteral(@"ER
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-xl-2 me-xxl-4 pt-2 pt-xl-0"">
                                <a id=""Blog"" class=""nav-link text-uppercase"" href=""/Blog"">
                                    BLOG
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-xl-2 me-xxl-4 pt-2 pt-xl-0"">
                                <a id=""Contact"" class=""nav-link text-uppercase"" href=""/Contact"">
                                    CONTACT
                                </a>
                            </li>
                            <li class=""nav-item me-2 me-xl-2 me-xxl-4 pt-2 pt-xl-0 d-none d-xl-inline-block"">
                                <a class=""BtnGreen text-uppercase py-2 px-3 rounded-pill d-inline-block"" target=""_blank"" href=""https://elysiumscan.vulcanforged.com/"">
                                    Explorer
                           ");
                WriteLiteral(@"     </a>
                            </li>
                            <li class=""nav-item pt-2 pt-xl-0 d-none d-xl-inline-block"">
                                <a class=""BtnGreen text-uppercase py-2 px-3 rounded-pill d-inline-block"" href=""/Home/GetStarted"">
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
#line 84 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\_Layout.cshtml"
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
");
                WriteLiteral("                            <a");
                BeginWriteAttribute("class", " class=\"", 5775, "\"", 5783, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" href=\"https://twitter.com/VulcanForged\">\r\n");
                WriteLiteral(@"                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""48"" height=""48"" viewBox=""0 0 48 48"">
                                    <g id=""icon-twitter"" transform=""translate(0 -81.182)"">
                                        <rect id=""Rectangle_8885"" data-name=""Rectangle 8885"" width=""48"" height=""48"" transform=""translate(0 81.182)"" fill=""none"" />
                                        <g id=""Group_20396"" data-name=""Group 20396"">
                                            <g id=""Group_20395"" data-name=""Group 20395"">
                                                <path id=""Path_44097"" data-name=""Path 44097"" d=""M18.716,118.939a17.264,17.264,0,0,1-9.367-2.732.688.688,0,0,1,.431-1.262c.429.036.873.053,1.338.053a11.305,11.305,0,0,0,5.463-1.414,6.164,6.164,0,0,1-2.036-1.034,6.44,6.44,0,0,1-2.242-3.177.689.689,0,0,1,.453-.869,6.47,6.47,0,0,1-1.054-1.027,6.641,6.641,0,0,1-1.495-4.154v-.13a.688.688,0,0,1,1.028-.6l.026.015A7.15,7.15,0,0,1,10.208,99.1a6.937,6.937,0,0,1,.929-3.338.687.687,0,0,");
                WriteLiteral(@"1,1.127-.087,15.965,15.965,0,0,0,5.081,4.118,15.614,15.614,0,0,0,5.653,1.7c-.013-.2-.02-.39-.02-.584a6.616,6.616,0,0,1,1.866-4.6,6.554,6.554,0,0,1,9.141-.16A11.247,11.247,0,0,0,37.152,94.9a.687.687,0,0,1,.993.823,7.092,7.092,0,0,1-.885,1.73c.248-.091.493-.19.736-.3a.687.687,0,0,1,.847,1.017,13.615,13.615,0,0,1-2.8,2.987c.012.144.018.283.018.415a17.534,17.534,0,0,1-2.028,8.067,16.876,16.876,0,0,1-15.321,9.3Zm-6.28-2.642a16.389,16.389,0,0,0,6.274,1.267,15.5,15.5,0,0,0,14.1-8.544,16.157,16.157,0,0,0,1.88-7.444,4.706,4.706,0,0,0-.049-.631.686.686,0,0,1,.271-.646,12.271,12.271,0,0,0,1.28-1.094q-.582.132-1.173.209a.679.679,0,0,1-.734-.448.688.688,0,0,1,.277-.814,5.651,5.651,0,0,0,1.308-1.135,12.809,12.809,0,0,1-1.979.549.687.687,0,0,1-.632-.2,5.175,5.175,0,0,0-7.434-.1,5.2,5.2,0,0,0-1.472,3.657,7.421,7.421,0,0,0,.1,1.21.687.687,0,0,1-.167.573.677.677,0,0,1-.553.226,17.161,17.161,0,0,1-7.026-1.919,17.357,17.357,0,0,1-4.8-3.652,5.669,5.669,0,0,0-.322,1.729,5.341,5.341,0,0,0,2.329,4.323.687.687,0,0,1-.449,1.247,7.214,");
                WriteLiteral(@"7.214,0,0,1-1.777-.359,5.131,5.131,0,0,0,4.039,4.076.688.688,0,0,1,.01,1.342,7.635,7.635,0,0,1-1.71.185,5.081,5.081,0,0,0,4.418,2.585.688.688,0,0,1,.406,1.228A12.292,12.292,0,0,1,12.436,116.3Z"" fill=""#fff"" />
                                            </g>
                                        </g>
                                    </g>
                                </svg>
                            </a>
");
                WriteLiteral("                            <a");
                BeginWriteAttribute("class", " class=\"", 8532, "\"", 8540, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" href=\"https://www.linkedin.com/company/vulcan-forged/\">\r\n");
                WriteLiteral(@"                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""48"" height=""48"" viewBox=""0 0 48 48"">
                                    <g id=""icon-linkedin"" transform=""translate(-1.498 -68.954)"">
                                        <rect id=""Rectangle_8887"" data-name=""Rectangle 8887"" width=""48"" height=""48"" transform=""translate(1.498 68.954)"" fill=""none"" />
                                        <g id=""Group_20404"" data-name=""Group 20404"" transform=""translate(0 -2)"">
                                            <g id=""Group_20403"" data-name=""Group 20403"">
                                                <path id=""Path_44100"" data-name=""Path 44100"" d=""M38.145,106.294H32.892a.687.687,0,0,1-.687-.688V97.36a7.146,7.146,0,0,0-.307-2.727c-.132-.413-.459-.972-1.758-1.048-1.5.045-1.828.738-1.937.966a5.673,5.673,0,0,0-.5,2.673v8.382a.688.688,0,0,1-.688.688H21.765a.687.687,0,0,1-.687-.688V88.718a.686.686,0,0,1,.687-.687h5.083a.687.687,0,0,1,.688.687v.425a6.568,6.568,0,0,1,.751-.553,6.821,6.821,0");
                WriteLiteral(@",0,1,3.568-1.011c2.841.083,4.763.976,5.752,2.654a11.842,11.842,0,0,1,1.226,6.132v9.241A.688.688,0,0,1,38.145,106.294Zm-4.565-.688h0Zm0-.687h3.878V96.344a10.541,10.541,0,0,0-1.045-5.431c-.724-1.226-2.261-1.892-4.558-1.96a5.443,5.443,0,0,0-2.823.793,3.927,3.927,0,0,0-1.506,1.582.685.685,0,0,1-.621.393.737.737,0,0,1-.744-.687V89.406H22.453v15.513h3.878V97.247a7.025,7.025,0,0,1,.631-3.29,3.319,3.319,0,0,1,3.2-1.746c2.033.118,2.773,1.153,3.046,2a8.421,8.421,0,0,1,.37,3.2Zm-15.091,1.375H13.237a.688.688,0,0,1-.688-.688V88.718a.687.687,0,0,1,.688-.687h5.252a.686.686,0,0,1,.687.687v16.888A.687.687,0,0,1,18.489,106.294Zm-4.565-1.375H17.8V89.406H13.924Zm2-17.829a3.827,3.827,0,0,1-2.662-1.1h0a3.734,3.734,0,0,1,4.457-5.906,3.74,3.74,0,0,1,1.913,3.251,3.772,3.772,0,0,1-3.708,3.76Zm-1.689-2.077a2.425,2.425,0,0,0,1.689.7,2.4,2.4,0,0,0,1.632-.7,2.434,2.434,0,0,0,.7-1.691,2.338,2.338,0,0,0-1.2-2.039,2.365,2.365,0,0,0-3.528,2.112A2.393,2.393,0,0,0,14.231,85.013Z"" fill=""#fff"" />
                                            </g>");
                WriteLiteral(@"
                                        </g>
                                    </g>
                                </svg>
                            </a>
                        </div>
                        <div class=""col-md-2 mb-5 mb-md-0 ms-md-auto"">
                            <h6 class=""mb-2 mb-md-4"">ELYSIUM</h6>
                            <ul class=""list-unstyled mb-0"">
                                <li class=""py-1""><a href=""/About"">About</a></li>
                                <li class=""py-1""><a href=""/Home/GetStarted"">FAQ</a></li>
                                <li class=""py-1""><a href=""https://vulcanforged.zendesk.com/hc/en-us"">Support</a></li>
");
                WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""col-md-2 mb-5 mb-md-0 ms-md-auto"">
                            <h6 class=""mb-2 mb-md-4"">TECHNOLOGY</h6>
                            <ul class=""list-unstyled mb-0"">
                                <li class=""py-1""><a href=""/Home"">Technology</a></li>
");
                WriteLiteral("                                <li class=\"py-1\"><a class=\"RobotoBold\" href=\"/Home/GetStarted\">Substrate</a></li>\r\n");
                WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""col-md-2 ms-md-auto"">
                            <h6 class=""mb-2 mb-md-4"">COMMUNITY</h6>
                            <ul class=""list-unstyled mb-0"">
                                <li class=""py-1""><a href=""/Community"">Community</a></li>
                                <li class=""py-1""><a href=""/Home/GetStarted"">Documentation</a></li>
                                <li class=""py-1""><a href=""/Home/GetStarted"">Brand Assets</a></li>
                                <li class=""py-1""><a href=""/Blog"">Blog</a></li>
");
                WriteLiteral(@"                                <li class=""py-1""><a href=""https://vulcanforgedco.medium.com/"">Medium</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""d-sm-flex justify-content-between py-4 py-sm-5"">
                    © 2022 Elysium
                    <ul class=""d-inline-flex list-unstyled mb-0"">
                        <li class=""ms-3""><a href=""/Home/GetStarted"">Terms & Conditions</a></li>
                        <li class=""ms-3""><a href=""/Home/GetStarted"">Privacy</a></li>
");
                WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </footer>\r\n\r\n    </div>\r\n\r\n    <script src=\"https://kit.fontawesome.com/4f472b9b00.js\" crossorigin=\"anonymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "806c274424d5ff341445c32675dac255da53d45a24506", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "806c274424d5ff341445c32675dac255da53d45a25606", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "806c274424d5ff341445c32675dac255da53d45a26706", async() => {
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
#line 172 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\_Layout.cshtml"
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
    else if (currentLocation.indexOf(""Blog"") >= 0) {
        $(""#Blog"").addClass('active');
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
