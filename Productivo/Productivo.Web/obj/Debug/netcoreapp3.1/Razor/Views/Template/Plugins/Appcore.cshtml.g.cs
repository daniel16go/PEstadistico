#pragma checksum "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Plugins\Appcore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e95202b669b95b0af9abec0d8e3f2a7a3b045471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Plugins_Appcore), @"mvc.1.0.view", @"/Views/Template/Plugins/Appcore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95202b669b95b0af9abec0d8e3f2a7a3b045471", @"/Views/Template/Plugins/Appcore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Plugins_Appcore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/theme-demo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Plugins\Appcore.cshtml"
   
	ViewData["Title"] = "App.Core";
	ViewData["PageName"] = "plugins_appcore";
	ViewData["Category1"] = "Core Plugins";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-shield-alt'></i> App.core.js <sup class='badge badge-danger fw-500'>CORE</sup>";
	ViewData["PageDescription"] = "The heart and soul of Productivo - Responsive WebApp";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e95202b669b95b0af9abec0d8e3f2a7a3b0454715523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Debugging <span class=""fw-300""><i>console.log</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						view the app.core.js debugger in realtime; assists in the detection and correction of errors
					</div>
					<div id=""app-eventlog"" class=""alert alert-primary p-1 h-auto mb-3""></div>
					<d");
            WriteLiteral(@"iv class=""d-flex"">
						<div>
							<div class=""custom-control d-flex custom-switch"">
								<input id=""eventlog-switch"" type=""checkbox"" class=""custom-control-input"" checked=""checked"">
								<label class=""custom-control-label fw-500"" for=""eventlog-switch"">Debugger Active</label>
							</div>
						</div>         
						<div class=""flex-1 text-right"">
							<a href=""#"" class=""btn btn-sm btn-outline-primary mr-1 ml-0"" data-toggle=""modal"" data-target="".js-modal-settings"">
								Toggle Settings
							</a>
							<a href=""#"" class=""btn btn-sm btn-outline-danger"" onclick=""clearlogText(); return false;"">
								Clear Log
							</a>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					App <span class=""fw-300""><i>API</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse"">");
            WriteLiteral(@"</button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						Control options for the app API
					</div>
					<table class=""table table-hover table-bordered m-0"">
						<thead class=""thead-themed"">
							<tr>
								<th>
									Usage
								</th>
								<th>
									Returns
								</th>
								<th>
									Description
								</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.saveSettings()"">initApp.saveSettings()</button>
								</td>
								<td>
									<i class=""text-muted"">null");
            WriteLiteral(@"</i>
								</td>
								<td class=""fs-sm"">
									Pushes selected classes from the <code>body</code> tag to localstorage/database
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.resetSettings()"">initApp.resetSettings()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Remove classes from <code>body</code> & saves to localstorage/database
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.factoryReset()"">initApp.factoryReset()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Clears your localStorage effectively removing all settings and panel configs
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.acce");
            WriteLiteral(@"ssIndicator()"">initApp.accessIndicator()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Indicator for Save Settings (mostly aesthetics)
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.pushSettings()"">initApp.pushSettings()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Push array to <code>body</code> tag. See <a href=""/settings/savingdb"">saving to database</a> for more details
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.getSettings()"">initApp.getSettings()</button>
								</td>
								<td>
									<i class=""fw-500 text-primary"">string</i>
								</td>
								<td class=""fs-sm"">
									Fetch class names from <code>body</code> and convert them to JSON string. See <a hre");
            WriteLiteral(@"f=""/settings/savingdb"">saving to database</a> for more details
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.detectBrowserType()"">initApp.detectBrowserType()</button>
								</td>
								<td>
									<i class=""fw-500 text-primary"">string</i>
								</td>
								<td class=""fs-sm"">
									Detects webkit and chrome browsers
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.addDeviceType()"">initApp.addDeviceType()</button>
								</td>
								<td>
									<i class=""fw-500 text-primary"">string</i>
								</td>
								<td class=""fs-sm"">
									Detects whether device is desktop or mobile
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.windowScrollEvents()"">initApp.windowScrollEvents()</button>
								</td>
								<td>
									<i class=""t");
            WriteLiteral(@"ext-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Saves app settings to localstorage
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.checkNavigationOrientation()"">initApp.checkNavigationOrientation()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Saves app settings to localstorage
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.buildNavigation(id)"">initApp.buildNavigation(id)</button>
								</td>
								<td>
									<i class=""fw-500 text-primary"">string</i>
								</td>
								<td class=""fs-sm"">
									Saves app settings to localstorage
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.mobileCheckActivation()"">initApp.mobileCheckActivation()</button>");
            WriteLiteral(@"
								</td>
								<td>
									<i class=""fw-500 text-danger"">bool</i>
								</td>
								<td class=""fs-sm"">
									Saves app settings to localstorage
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.toggleVisibility()"">initApp.toggleVisibility()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Saves app settings to localstorage
								</td>
							</tr>
							<tr>
								<td>
									<button class=""btn btn-outline-dark btn-sm mr-2"" onclick=""initApp.domReadyMisc()"">initApp.domReadyMisc()</button>
								</td>
								<td>
									<i class=""text-muted"">-</i>
								</td>
								<td class=""fs-sm"">
									Fires a series of events, see ""Initialization shell"" to your left, for more details.
								</td>
							</tr>                
						</tbody>
					</table>
				</div>
			</div>
		</div>
		<div id=""panel-3""");
            WriteLiteral(@" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Action <span class=""fw-300""><i>buttons</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						Allows you to add action to any HTML element on 'mouseUp' event
					</div>
					<table class=""table table-hover table-bordered m-0"">
						<thead class=""thead-themed"">
							<tr>
								<th style=""width:150px"">
									Action Type
								</th>
							");
            WriteLiteral(@"	<th>
									Description
								</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>
									<code>toggle</code>
								</td>
								<td class=""fs-sm"">
									Push data-class to <code>body</code> element 
									<br>
									<code>data-action=""toggle"" data-class=""class-a class-b"" data-target=""#ID""</code>
								</td>
							</tr>
							<tr>
								<td>
									<code>toggle-swap</code>
								</td>
								<td class=""fs-sm"">
									<code>data-action=""toggle-swap"" data-class=""class-a class-b"" data-target=""#ID""</code>
								</td>
							</tr>
							<tr>
								<td>
									<code>toggle-replace</code>
								</td>
								<td class=""fs-sm"">
									<code>data-action=""toggle-replace"" data-replaceclass=""classesToReplace"" data-class=""replaceWithClass"" data-target=""body""</code>
								</td>
							</tr>
							<tr>
								<td>
									<code>data-panel-*</code>
								</td>
								<td class=""fs-sm"">
									Push array to <code>body");
            WriteLiteral(@"</code> tag. See <a href=""/settings/savingdb"">saving to database</a> for more details
								</td>
							</tr>
							<tr>
								<td>
									<code>theme-update</code>
								</td>
								<td class=""fs-sm"">
									<code>data-action=""theme-update"" data-theme=""path_to_css/css.css""</code>
								</td>
							</tr>
							<tr>
								<td>
									<code>app-reset</code>
								</td>
								<td class=""fs-sm"">
									<code>data-action=""app-reset""</code>
								</td>
							</tr> 
							<tr>
								<td>
									<code>factory-reset</code>
								</td>
								<td class=""fs-sm"">
									<code>data-action=""factory-reset""</code>
								</td>
							</tr> 
							<tr>
								<td>
									<code>app-print</code>
								</td>
								<td class=""fs-sm"">
									Print page (similar to pressing CTRL/CMD + P)
									<code>data-action=""app-print""</code>
								</td>
							</tr> 
							<tr>
								<td>
									<code>app-fullscreen</code>
								</td>
						");
            WriteLiteral(@"		<td class=""fs-sm"">
									Activates broswer's fullscreen command (may not work in all browsers)
									<code>data-action=""app-fullscreen""</code>
								</td>
							</tr>  
							<tr>
								<td>
									<code>app-loadscript</code>
								</td>
								<td class=""fs-sm"">
									Load scripts on demand
									<code>data-action=""app-fullscreen"" data-loadurl=""script.js"" data-loadfunction=""functionName()""</code> or you can also use <code>initApp.loadScript(""js/my_lovely_script.js"", myFunction)</code>
								</td>
							</tr>
							<tr>
								<td>
									<code>playsound</code>
								</td>
								<td class=""fs-sm"">
									Play sounds using <code>data-action=""playsound"" data-soundpath=""media/sound/"" data-soundfile=""filename"" (no file extensions)</code>
								</td>
							</tr>            
						</tbody>
					</table>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Con");
            WriteLiteral(@"fig <span class=""fw-300""><i>settings</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						Define preferred application behaviors or configuration options; can modify some functionality of the app
					</div>
<pre class=""prettyprint mb-0"">
var myapp_config = {
	root_: $('body'),
	root_logo: $('.page-sidebar > .page-logo')
	throttleDelay: 450,
	filterDelay: 150,
	thisDevice: null, 
	isMobile: (/iphone|ipad|");
            WriteLiteral(@"ipod|android|blackberry|mini|windows\sce|palm/i.test(navigator.userAgent.toLowerCase())), 
	mobileMenuTrigger: null,
	mobileResolutionTrigger: 992,
	isWebkit: ((!!window.chrome && !!window.chrome.webstore) === true || Object.prototype.toString.call(window.HTMLElement).indexOf('Constructor') > 0 === true),
	isChrome: (/chrom(e|ium)/.test(navigator.userAgent.toLowerCase())),
	isIE: ( (window.navigator.userAgent.indexOf('Trident/') ) > 0 === true ),
	debugState: true, 
	rippleEffect: true, 
	mythemeAnchor: '#mytheme',
	navAnchor: '#js-primary-nav',
	navHooks: '#js-primary-nav > ul.navigation'
	navClosedSign: 'ni ni-chevron-down',
	navOpenedSign: 'ni ni-chevron-up',
	navAccordion: true,
	navInitalized: 'js-nav-built',
	navFilterInput: $('#nav_filter_input'),
	navHorizontalWrapperId: 'js-nav-menu-wrapper',
	navSpeed: 500, 
	navClosedSign: 'fal fa-angle-down',
	navOpenedSign: 'fal fa-angle-up',
	appDateHook: $('.js-get-date'),
	storeLocally: true,
	jsArray : []
};</pre>
				</div>
			</div>");
            WriteLiteral(@"
		</div>
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Initilization <span class=""fw-300""><i>shell</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						Showcasing app JS skeleton
					</div>
<pre class=""prettyprint mb-0"">
/* App initialize */
var initApp = (function(app) {
	app.saveSettings = function () { ... }
	app.resetSettings = function () { ... }
	app.accessIndicat");
            WriteLiteral(@"or = function () { ... }
	app.pushSettings = function (DB_string) { ... }
	app.getSettings = function () { ... }
	app.detectBrowserType = function () { ... }
	app.addDeviceType = function() { ... }
	app.windowScrollEvents = function () { ... }
	app.checkNavigationOrientation = function() { ... }
	app.buildNavigation = function() { ... }
	app.mobileCheckActivation = function(){ ... }
	app.toggleVisibility = function (id) { ... }
	app.domReadyMisc = function() { 
	   /* get app date */
	   /* activate last tab used */
	   /* activate/destroy slimscroll */
	   /* activates tooltip */
	   /* activates image lazyload mechanic */
	   /* enable dropdown */
	   /* enable ripple effect */
	   /* attach action buttons */
	   /* menu tap actions (for mobile) */
	   /* initialize windows mobile 8 fix for BS4 */
	   ...
	}
	return app;
})({});
/* Bind the throttled handler to the resize event */
$(window).resize(
	$.throttle( myapp_config.throttleDelay, function (e) {
		/* (1a) ADD CLASS WHEN B");
            WriteLiteral(@"ELOW CERTAIN WIDTH (MOBILE MENU) */
		initApp.mobileCheckActivation(); 
	})
); 
/* Bind the throttled handler to the scroll event */
$(window).scroll(
	$.throttle( myapp_config.throttleDelay, function (e) {
		/* EVENTS */
		...
	})
);
/* Initiate scroll events */
$(window).on('scroll', initApp.windowScrollEvents);
/* Document loaded event */
jQuery(document).ready(function() {
	/* detect desktop or mobile */
	initApp.addDeviceType();
	/* detect Webkit Browser */
	initApp.detectBrowserType();
	/* a. check for mobile view width and add class .mobile-view-activated */
	initApp.mobileCheckActivation();
	/* b. build navigation */
	initApp.buildNavigation(myapp_config.navHooks);
	/* c. run DOM misc functions */
	initApp.domReadyMisc();
});</pre>
				</div>
			</div>
		</div>
	</div>  
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral(@"
<script src=""https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js""></script>
<script>
	/* state debug state for debug msg */
	myapp_config.debugState = true;
	/* variables */
	var lastMsg = """",
		repeatCount = 0,
		/* get new time date on page load */
		getTime = function () {
			var dt = new Date(),
				time = dt.getHours() + "":"" + dt.getMinutes() + "":"" + dt.getSeconds();
			return time;
		};
	/* define type */    
	if (typeof console  != ""undefined"") 
		if (typeof console.log != 'undefined') {
			console.nglog = console.log;
		}
		else {
			console.nglog = function() {};
		}
	/* push console messages to #div */
	console.log = function(message) {
		console.nglog(message); 
		if (lastMsg != message) {
			$('#app-eventlog').append('<div class=""highlight p-1""><span class=""d-flex align-items-center"">' + '<span class=""badge badge-primary mr-2 p-1 width-6"">' + getTime() + '</span>' + message + '</span></div>');
			lastMsg = message;
			repeatCount = 0;
			 $('#app");
                WriteLiteral(@"-eventlog').animate({ scrollTop: $('#app-eventlog').prop(""scrollHeight"")}, 200);
		} else {
			lastMsg = message;
			repeatCount = repeatCount + 1;
			$('#app-eventlog >:last-child').remove();
			$('#app-eventlog').append('<div class=""highlight p-1""><span class=""d-flex align-items-center"">'+ '<span class=""badge badge-primary mr-2 p-1 width-6"">' + getTime() + '</span>' + '<span class=""badge badge-success mr-1"">' + repeatCount + '</span>' + message + '</span></div>');
			$('#app-eventlog').animate({ scrollTop: $('#app-eventlog').prop(""scrollHeight"")}, 200);
		}
	};
	/* compile messages to one log */
	console.error = console.debug = console.info =  console.log
	$('#eventlog-switch').click(function(){
		if ($('input[type=checkbox]').prop('checked')) {
			console.log(""debugState ON"")
			myapp_config.debugState = true;
		} else {
			console.log(""debugState OFF"");
			myapp_config.debugState = false;
		}
	});
	var clearlogText = function (){
		$('#app-eventlog').empty();
	};
</script>
");
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
