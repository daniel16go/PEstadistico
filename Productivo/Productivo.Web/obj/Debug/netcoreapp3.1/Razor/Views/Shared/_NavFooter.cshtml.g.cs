#pragma checksum "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_NavFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c86e8fa056306a17617e86cb382399d40762dddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavFooter), @"mvc.1.0.view", @"/Views/Shared/_NavFooter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86e8fa056306a17617e86cb382399d40762dddc", @"/Views/Shared/_NavFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NavFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""nav-footer shadow-top"">
    <a href=""#"" onclick=""return false;"" data-action=""toggle"" data-class=""nav-function-minify"" class=""hidden-md-down"">
        <i class=""ni ni-chevron-right""></i>
        <i class=""ni ni-chevron-right""></i>
    </a>
    <ul class=""list-table m-auto nav-footer-buttons"">
        <li>
            <a href=""javascript:void(0);"" data-toggle=""tooltip"" data-placement=""top"" title=""Chat Help Desk"">
                <i");
            BeginWriteAttribute("class", " class=\"", 453, "\"", 501, 2);
#nullable restore
#line 9 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_NavFooter.cshtml"
WriteAttributeValue("", 461, Settings.Theme.IconPrefix, 461, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 489, "fa-comments", 490, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"mailto:soporte@productivo.co\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Support Email\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 692, "\"", 739, 2);
#nullable restore
#line 14 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_NavFooter.cshtml"
WriteAttributeValue("", 700, Settings.Theme.IconPrefix, 700, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 728, "fa-mailbox", 729, 11, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"javascript:void(0);\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Llamar a Productivo\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 927, "\"", 972, 2);
#nullable restore
#line 19 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_NavFooter.cshtml"
WriteAttributeValue("", 935, Settings.Theme.IconPrefix, 935, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 963, "fa-phone", 964, 9, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</div>");
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
