#pragma checksum "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ScriptsLoadingSaving.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f5a590bea569952eedbc39704cc612e4e0d1792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScriptsLoadingSaving), @"mvc.1.0.view", @"/Views/Shared/_ScriptsLoadingSaving.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f5a590bea569952eedbc39704cc612e4e0d1792", @"/Views/Shared/_ScriptsLoadingSaving.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScriptsLoadingSaving : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
	/**
	 *	This script should be placed right after the body tag for fast execution 
	 *	Note: the script is written in pure javascript and does not depend on thirdparty library
	 **/
	'use strict';
	var classHolder = document.getElementsByTagName(""BODY"")[0],
	/** 
	 * Load from localstorage
	 **/
	themeSettings =  (localStorage.getItem('themeSettings')) ? JSON.parse(localStorage.getItem('themeSettings')) : {},
	themeURL = themeSettings.themeURL || '',
	themeOptions = themeSettings.themeOptions || '';
	/** 
	 * Load theme options
	 **/
	if (themeSettings.themeOptions) {
		classHolder.className = themeSettings.themeOptions;
		console.log(""%c✔ Theme settings loaded"", ""color: #148f32"");
	} else {
		console.log(""%c✔ Heads up! Theme settings is empty or does not exist, loading default settings..."", ""color: #ed1c24"");
	}
	if (themeSettings.themeURL && !document.getElementById('mytheme') ) {
		var cssfile  = document.createElement('link');
			cssfile.id = 'mytheme';
			cssfile.rel  = ");
            WriteLiteral(@"'stylesheet';
			cssfile.href = themeURL;
			document.getElementsByTagName('head')[0].appendChild(cssfile);
	} else if (themeSettings.themeURL && document.getElementById('mytheme')) {
		document.getElementById('mytheme').href = themeSettings.themeURL;
	} 
	/** 
	 * Save to localstorage 
	 **/
	var saveSettings = function (){
		themeSettings.themeOptions =  String(classHolder.className).split(/[^\w-]+/).filter(function(item) {
			return /^(nav|header|footer|mod|display)-/i.test(item);
		}).join(' ');
		if ( document.getElementById('mytheme') ){ 
			themeSettings.themeURL = document.getElementById('mytheme').getAttribute(""href""); 
		};
		localStorage.setItem( 'themeSettings', JSON.stringify(themeSettings) );
	}
	/** 
	 * Reset settings
	 **/
	var resetSettings = function (){
		localStorage.setItem(""themeSettings"", """");
	}
</script>
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
