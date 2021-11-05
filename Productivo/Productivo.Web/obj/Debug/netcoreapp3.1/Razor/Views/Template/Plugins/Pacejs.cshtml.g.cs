#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Plugins\Pacejs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "685f896f798d5425fdb040d10d5e8a2e30293ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Plugins_Pacejs), @"mvc.1.0.view", @"/Views/Template/Plugins/Pacejs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685f896f798d5425fdb040d10d5e8a2e30293ac1", @"/Views/Template/Plugins/Pacejs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Plugins_Pacejs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/theme-demo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/demo/s-1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Plugins\Pacejs.cshtml"
   
	ViewData["Title"] = "PaceJS";
	ViewData["PageName"] = "plugins_pacejs";
	ViewData["Category1"] = "Core Plugins";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-shield-alt'></i> PaceJS <sup class='badge badge-warning fw-500'>RECOMMENDED</sup>";
	ViewData["PageDescription"] = "Include pace.js and a CSS theme of your choice, and you get a beautiful progress indicator for your page load and ajax navigation.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "685f896f798d5425fdb040d10d5e8a2e30293ac16480", async() => {
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
            WriteLiteral(@"<div class=""alert alert-primary"">
    <div class=""d-flex flex-start w-100"">
        <div class=""mr-2 hidden-md-down"">
            <span class=""icon-stack icon-stack-lg"">
                <i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i>
                <i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i>
                <i class=""ni ni-blog-read icon-stack-1x opacity-100 color-white""></i>
            </span>
        </div>
        <div class=""d-flex flex-fill"">
            <div class=""flex-fill"">
                <span class=""h5"">Important information</span>
                <p>This plugin is not required but <strong>highly recommended</strong>. If you decide to remove PaceJS from core, Internet Explorer may have some CSS issues during page load. Some animations will execute before a page is fully loaded, resulting 'jumpy / jerky' animations.</p>
                <p class=""m-0"">
                    Find in-depth, guidelines, tutorials and mo");
            WriteLiteral(@"re on Pace's <a href=""https://github.hubspot.com/pace/"" target=""_blank"">Official Documentation</a>
                </p>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Default <span class=""fw-300""><i>Settings</i></span> 
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
						Default paceJS settings, no changes needed!
");
            WriteLiteral(@"					</div>
					<div class=""demo-window m-auto shadow-1 rounded mb-g"" style=""max-width:550px"">
						<div class=""demo-window-content"">
							<div class=""app-body-demo d-flex flex-column border-0 position-relative"">
								<div class=""position-absolute pos-top w-100"">
									<div class=""progress rounded-0 progress-xs bg-transparent"">
										<div class=""progress-bar"" role=""progressbar"" style=""width: 75%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
									</div>
								</div>
								<div class=""flex-1"">
									<div class=""d-flex app-body-demo border-top-0 border-left-0"">
										<div class=""app-nav-demo bg-success-500 p-1 pt-0 pattern-1""></div>
										<div class=""d-flex flex-column flex-1"">
											<div class=""app-header-demo bg-success-50 pattern-1""></div>
											<div class=""app-container-demo flex-1 p-3"">
												");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "685f896f798d5425fdb040d10d5e8a2e30293ac110915", async() => {
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
            WriteLiteral(@"
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Custom <span class=""fw-300""><i>CSS</i></span> 
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
						Custom location by adding class <code>.mod-pace-custom</code>
					</div>
					<div class=");
            WriteLiteral(@"""demo-window m-auto shadow-1 rounded mb-g"" style=""max-width:550px"">
						<div class=""demo-window-content"">
							<div class=""app-body-demo d-flex flex-column border-0"">
								<div class=""flex-1"">
									<div class=""d-flex app-body-demo border-top-0 border-left-0"">
										<div class=""app-nav-demo bg-success-500 p-1 pt-0 pattern-1""></div>
										<div class=""d-flex flex-column flex-1"">
											<div class=""app-header-demo bg-success-50 pattern-1""></div>
											<div class=""app-container-demo bg-faded d-flex align-items-center justify-content-center flex-1"">
												<div class=""text-center"" style=""width:100px"">
													<div class=""progress progress-sm bg-white rounded-0"" style=""border:1px solid #dadada"">
													  <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 65%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
													</div>
												</div>
											</div>
										</div>
									</div>
								</div>
");
            WriteLiteral(@"							</div>
						</div>
					</div>	
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-12"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Core <span class=""fw-300""><i>API</i></span> 
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
						");
#nullable restore
#line 132 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Plugins\Pacejs.cshtml"
                   Write(Settings.AppName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" comes with integrated and customized styles for PaceJS plugin. PaceJS in short, improves usability from an user's point of view
					</div>
					<div class=""row"">
						<div class=""col-xl-12"">
							<h5 class=""frame-heading"">Methods</h5>
							<div class=""frame-wrap"">
								<table class=""table table-bordered mb-0"">
									<thead>
										<tr>
											<th style=""width:150px"">
												Methods
											</th>
											<th>
												Description
											</th>
										</tr>
									</thead>
									<tbody>
										<tr>
											<td>
												<code>Pace.start</code>
											</td>
											<td class=""fs-sm"">
												Show the progress bar and start updating. Called automatically if you don't use AMD or CommonJS.
											</td>
										</tr>
										<tr>
											<td>
												<code>Pace.restart</code>
											</td>
											<td class=""fs-sm"">
												 Show the progress bar if it's hidden and start reporting the progress fro");
            WriteLiteral(@"m scratch.
											</td>
										</tr>
										<tr>
											<td>
												<code>Pace.stop</code>
											</td>
											<td class=""fs-sm"">
												Hide the progress bar and stop updating it
											</td>
										</tr>
										<tr>
											<td>
												<code>Pace.track</code>
											</td>
											<td class=""fs-sm"">
												Explicitly track one or more requests, see Tracking below
											</td>
										</tr>
										<tr>
											<td>
												<code>Pace.ignore</code>
											</td>
											<td class=""fs-sm"">
												Expliticly ignore one or more requests, see Tracking below
											</td>
										</tr>
									</tbody>
								</table>
							</div>					
							<h5 class=""frame-heading"">Configuration
								<small>
								Pace is fully automatic, no configuration is necessary to get started. If you would like to make some tweaks, here's how. You can set <code>window.paceOptions</code> before bringing in t");
            WriteLiteral(@"he file:</small>
							</h5>
							<div class=""frame-wrap"">					
<pre class=""prettyprint"">
paceOptions = {
  // Disable the 'elements' source
  elements: false,
  // Only show the progress on regular and ajax-y page navigation,
  // not every request
  restartOnRequestAfter: false
}
</pre>
							</div>
							<h5 class=""frame-heading"">You can also put options on the script tag</h5>
							<div class=""frame-wrap"">	
<pre class=""prettyprint"">
&lt;script data-pace-options='{ ""ajax"": false }' src='pace.js'&gt;&lt;/script&gt;
</pre>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>		
	</div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n<script src=\"https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js\"></script>\r\n");
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
