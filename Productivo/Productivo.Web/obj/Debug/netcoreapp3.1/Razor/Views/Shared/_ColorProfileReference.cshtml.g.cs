#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ColorProfileReference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b388caab2e4887c4c3d7a5c1b7164775ea588b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ColorProfileReference), @"mvc.1.0.view", @"/Views/Shared/_ColorProfileReference.cshtml")]
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
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b388caab2e4887c4c3d7a5c1b7164775ea588b6", @"/Views/Shared/_ColorProfileReference.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ColorProfileReference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<p id=""js-color-profile"" class=""d-none"">
	<span class=""color-primary-50""></span>
	<span class=""color-primary-100""></span>
	<span class=""color-primary-200""></span>
	<span class=""color-primary-300""></span>
	<span class=""color-primary-400""></span>
	<span class=""color-primary-500""></span>
	<span class=""color-primary-600""></span>
	<span class=""color-primary-700""></span>
	<span class=""color-primary-800""></span>
	<span class=""color-primary-900""></span>
	<span class=""color-info-50""></span>
	<span class=""color-info-100""></span>
	<span class=""color-info-200""></span>
	<span class=""color-info-300""></span>
	<span class=""color-info-400""></span>
	<span class=""color-info-500""></span>
	<span class=""color-info-600""></span>
	<span class=""color-info-700""></span>
	<span class=""color-info-800""></span>
	<span class=""color-info-900""></span>
	<span class=""color-danger-50""></span>
	<span class=""color-danger-100""></span>
	<span class=""color-danger-200""></span>
	<span class=""color-danger-300""></span>
	<span clas");
            WriteLiteral(@"s=""color-danger-400""></span>
	<span class=""color-danger-500""></span>
	<span class=""color-danger-600""></span>
	<span class=""color-danger-700""></span>
	<span class=""color-danger-800""></span>
	<span class=""color-danger-900""></span>
	<span class=""color-warning-50""></span>
	<span class=""color-warning-100""></span>
	<span class=""color-warning-200""></span>
	<span class=""color-warning-300""></span>
	<span class=""color-warning-400""></span>
	<span class=""color-warning-500""></span>
	<span class=""color-warning-600""></span>
	<span class=""color-warning-700""></span>
	<span class=""color-warning-800""></span>
	<span class=""color-warning-900""></span>	
	<span class=""color-success-50""></span>
	<span class=""color-success-100""></span>
	<span class=""color-success-200""></span>
	<span class=""color-success-300""></span>
	<span class=""color-success-400""></span>
	<span class=""color-success-500""></span>
	<span class=""color-success-600""></span>
	<span class=""color-success-700""></span>
	<span class=""color-success-800""><");
            WriteLiteral(@"/span>
	<span class=""color-success-900""></span>
	<span class=""color-fusion-50""></span>
	<span class=""color-fusion-100""></span>
	<span class=""color-fusion-200""></span>
	<span class=""color-fusion-300""></span>
	<span class=""color-fusion-400""></span>
	<span class=""color-fusion-500""></span>
	<span class=""color-fusion-600""></span>
	<span class=""color-fusion-700""></span>
	<span class=""color-fusion-800""></span>
	<span class=""color-fusion-900""></span>	
</p>
");
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
