<<<<<<< HEAD
#pragma checksum "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecc4d2bcad30a6aee551879bc7e7094ebb4184d"
=======
#pragma checksum "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a5625cc8fb4476f348b0fe9041c550465d8bf9"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
<<<<<<< HEAD
#line 1 "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/_ViewImports.cshtml"
=======
#line 1 "D:\Projects\Elysium_Web\Elysium.Web\Views\_ViewImports.cshtml"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
using Elysium.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/_ViewImports.cshtml"
=======
#line 2 "D:\Projects\Elysium_Web\Elysium.Web\Views\_ViewImports.cshtml"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
using Elysium.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ecc4d2bcad30a6aee551879bc7e7094ebb4184d", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc85fc39a3ee2f9897d8c9c8db977d59e56e6d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 2 "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/Shared/Error.cshtml"
=======
#line 2 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\Error.cshtml"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
#nullable restore
<<<<<<< HEAD
#line 9 "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/Shared/Error.cshtml"
=======
#line 9 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\Error.cshtml"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
<<<<<<< HEAD
#line 12 "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/Shared/Error.cshtml"
=======
#line 12 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\Error.cshtml"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
<<<<<<< HEAD
#line 14 "/root/app_git/Elysium/Elysium_Web/Elysium.Web/Views/Shared/Error.cshtml"
=======
#line 14 "D:\Projects\Elysium_Web\Elysium.Web\Views\Shared\Error.cshtml"
>>>>>>> f4b054e272aa094adc9a77b19f81afb02deae01d
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
