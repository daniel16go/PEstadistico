#pragma checksum "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Documentation\HowtoContribute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a598c4bb5aad2db3dbee535d05d4870873d878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Documentation_HowtoContribute), @"mvc.1.0.view", @"/Views/Template/Documentation/HowtoContribute.cshtml")]
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
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a598c4bb5aad2db3dbee535d05d4870873d878", @"/Views/Template/Documentation/HowtoContribute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Documentation_HowtoContribute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Documentation\HowtoContribute.cshtml"
  
    ViewData["Title"] = "Howto Contribute";
    ViewData["PageName"] = "documentation_howto_contribute";
    ViewData["Heading"] = "<i class='fal fa-book'></i> Documentation: <span class='fw-300'>Howto Contribute</span>";
    ViewData["Category1"] = "Documentation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row documentation"">
    <div class=""col-xl-12"">
        <div class=""panel"">
            <div class=""panel-hdr"">
                <h2>Productivo for ASP.NET Core 3.1 - Documentation</h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">
<h3>How To Contribute</h3>
<p>At the time of this writing, we are heavily focused on expanding the core features of the product and filling out the documentation, issue lists, milestones plans and supporting any issues that arise in the meantime, as this .NET Core oriented Theme first starts to engage with the community at large. During the intial stages of this project, issues have always been made known to us by using a service like Bitbucket for beta users to log support tickets, we want to continue this trend as it is very important that we keep the quality and engagement high with you and other customers.</p>
<h4>Beta Program</h4>
<p>In addition to getting familiar with the codebase you will ");
            WriteLiteral(@"be able to register issues of any type (simple bugs, new feature requests, requirements and architectural updates) upon which you can contribute to the project or request assistance from us. In the meantime, if you do find any issues with the codebase or other content in our code please log an issue on the <a href=""https://support.gotbootstrap.com/t/asp-net-core"">Support Forum</a> and I will do my best to work with you to solve it.</p>
<p>Steps on how to apply on becoming a beta tester and gain access to these privileges will be announced very Soon™.</p>
<hr>
<p>Copyright © 2020 by Walapa. All rights reserved. This documentation or any portion thereof
may not be reproduced or used in any manner whatsoever without the express written permission of the publisher except for the use of brief quotations in a review.</p>

                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Productivo.Core.Entities.ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Productivo.Core.Entities.ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SmartSettings Settings { get; private set; }
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
