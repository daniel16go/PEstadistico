#pragma checksum "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Documentation\LicensingInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbfee0230dee69ea7cb4f5ac114fa11f97b0590a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Documentation_LicensingInformation), @"mvc.1.0.view", @"/Views/Template/Documentation/LicensingInformation.cshtml")]
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
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbfee0230dee69ea7cb4f5ac114fa11f97b0590a", @"/Views/Template/Documentation/LicensingInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Documentation_LicensingInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Documentation\LicensingInformation.cshtml"
  
    ViewData["Title"] = "Licensing Information";
    ViewData["PageName"] = "documentation_licensing_information";
    ViewData["Heading"] = "<i class='fal fa-book'></i> Documentation: <span class='fw-300'>Licensing Information</span>";
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
<h3>Licensing Information</h3>
<p>With the purchase of both a Single License as well as an Extended License you are eligible to <strong>3 months</strong> of support after your purchase date. During this period you are able to ask questions relating to the .NET Core side of things as well as parts of the Theme itself and you are eligible to receive limited support for discussing modifications you are planning to make as part of your project. Please do note that extended support is <strong>not</strong> provided for the Seed edition of this product.</p>
<h4>Extended Support</h4>
<p>There is currently no possibility to purchase and/or otherwise obtain extended support for this product. If any plans ar");
            WriteLiteral(@"e announced in the near future we will update our Licensing Terms in accordance with what WrapBootstrap provides, at which point we will inform you as well of the outcome and how it affects your purchase. There is always the possibility of purchasing another Single License to extend your support, but we do not want this to be your only option moving forward, so please stay stuned!</p>
<h4>Customization Support</h4>
<p>If you wish to contact us regarding customization quotes you can reach us on: <a");
            BeginWriteAttribute("href", " href=\"", 1821, "\"", 1855, 2);
            WriteAttributeValue("", 1828, "mailto:smartadmin", 1828, 17, true);
            WriteLiteral("@");
            WriteAttributeValue("", 1847, "walpa.nl", 1847, 8, true);
            EndWriteAttribute();
            WriteLiteral(">smartadmin");
            WriteLiteral(@"@walapa.nl</a>. Include as much description as possible to ensure we can understand your exact inquiry and/or which parts of the project you are asking support for.</p>
<p>All customization work is quoted based on the amount of hours required for the effort to be documented, agreed and delivered, with the exception of the following fixed price tasks:</p>
<ol>
<li>Theme Customization - <strong>200 EUR</strong></li>
<li>Project Structure - <strong>100 EUR</strong></li>
<li>Git Integration - <strong>100 EUR</strong></li>
</ol>
<p>Please ensure your license receipt is added to the email to verify your purchase.</p>
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
