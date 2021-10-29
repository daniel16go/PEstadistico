#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667a5196b7d44834b947638588c3b9d1ed569bd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Ui_Toasts), @"mvc.1.0.view", @"/Views/Template/Ui/Toasts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667a5196b7d44834b947638588c3b9d1ed569bd6", @"/Views/Template/Ui/Toasts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Ui_Toasts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("brand-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
   
	ViewData["Title"] = "Toasts";
	ViewData["PageName"] = "ui_toasts";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i> Toasts";
	ViewData["Category1"] = "UI Components";
	ViewData["PageDescription"] = "Push notifications to your visitors with a toast, a lightweight and easily customizable alert message.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral("<div class=\"alert alert-primary alert-dismissible\">\r\n\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t<span aria-hidden=\"true\">\r\n\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 527, "\"", 572, 2);
#nullable restore
#line 12 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
WriteAttributeValue("", 535, Settings.Theme.IconPrefix, 535, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 563, "fa-times", 564, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
		</span>
	</button>
	<div class=""d-flex flex-start w-100"">
		<div class=""mr-2 hidden-md-down"">
			<span class=""icon-stack icon-stack-lg"">
				<i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i>
				<i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i>
				<i");
            BeginWriteAttribute("class", " class=\"", 902, "\"", 984, 5);
#nullable restore
#line 20 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
WriteAttributeValue("", 910, Settings.Theme.IconPrefix, 910, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 938, "fa-info", 939, 8, true);
            WriteAttributeValue(" ", 946, "icon-stack-1x", 947, 14, true);
            WriteAttributeValue(" ", 960, "opacity-100", 961, 12, true);
            WriteAttributeValue(" ", 972, "color-white", 973, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
			</span>
		</div>
		<div class=""d-flex flex-fill"">
			<div class=""flex-fill"">
				<span class=""h5"">About toasts</span>
				<br> Toasts are lightweight notifications designed to mimic the push notifications that have been popularized by mobile and desktop operating systems. They’re built with flexbox, so they’re easy to align and position.
				<br>
				<br> Learn more about this plugin on bootstrap's
				<a");
            BeginWriteAttribute("href", " href=\"", 1411, "\"", 1480, 3);
            WriteAttributeValue("", 1418, "https://getbootstrap.com/docs/", 1418, 30, true);
#nullable restore
#line 29 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
WriteAttributeValue("", 1448, ViewBag.Bs4v, 1448, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1461, "/components/toasts/", 1461, 19, true);
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">official documentation</a>.
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Basic <span class=""fw-300""><i>Toasts</i></span> 
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
						Toasts are as flexible as you need and have very little required markup. At a minimum, we require a single element to contain your “toasted” co");
            WriteLiteral("ntent and strongly encourage a dismiss button.\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"toast fade show\" role=\"alert\" aria-live=\"assertive\" aria-atomic=\"true\" data-toggle=\"toast\">\r\n\t\t\t\t\t\t<div class=\"toast-header\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667a5196b7d44834b947638588c3b9d1ed569bd69646", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t<strong class=\"mr-auto\">");
#nullable restore
#line 55 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
                                               Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
							<small>11 mins ago</small>
							<button type=""button"" class=""ml-2 close"" data-dismiss=""toast"" aria-label=""Close"">
								<span aria-hidden=""true"">×</span>
							</button>
						</div>
						<div class=""toast-body"">
							Hello, world! This is a toast message.
						</div>
					</div>		
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Stacking <span class=""fw-300""><i>Toasts</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container sh");
            WriteLiteral(@"ow"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						When you have multiple toasts, we default to vertiaclly stacking them in a readable manner.
					</div>
					<div class=""position-relative height-lg bg-primary pattern-1"" aria-live=""polite"" aria-atomic=""true"">
						<div class=""position-absolute pos-top pos-right mt-3 mr-3"">
							<div class=""toast fade show"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" data-toggle=""toast"">
								<div class=""toast-header"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667a5196b7d44834b947638588c3b9d1ed569bd612884", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<strong class=\"mr-auto\">");
#nullable restore
#line 89 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
                                                       Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
									<small class=""text-muted"">just now</small>
									<button type=""button"" class=""ml-2 close"" data-dismiss=""toast"" aria-label=""Close"">
									<span aria-hidden=""true"">×</span>
									</button>
								</div>
								<div class=""toast-body"">
									See? Just like this.
								</div>
							</div> 
							<div class=""toast fade show"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" data-toggle=""toast"">
								<div class=""toast-header"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667a5196b7d44834b947638588c3b9d1ed569bd614996", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<strong class=\"mr-auto\">");
#nullable restore
#line 102 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
                                                       Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
									<small class=""text-muted"">2 seconds ago</small>
									<button type=""button"" class=""ml-2 close"" data-dismiss=""toast"" aria-label=""Close"">
									<span aria-hidden=""true"">×</span>
									</button>
								</div>
								<div class=""toast-body"">
									Heads up, toasts will stack automatically
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
					Translucent <span class=""fw-300""><i>Toasts</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-off");
            WriteLiteral(@"set=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Toasts are slightly translucent, too, so they blend over whatever they might appear over. For browsers that support the backdrop-filter CSS property, we’ll also attempt to blur the elements under a toast.
					</div>
					<div class=""p-3 bg-secondary"">
						<div class=""toast fade show"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" data-toggle=""toast"">
							<div class=""toast-header"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667a5196b7d44834b947638588c3b9d1ed569bd618325", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<strong class=\"mr-auto\">");
#nullable restore
#line 139 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
                                                   Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
								<small>11 mins ago</small>
								<button type=""button"" class=""ml-2 close"" data-dismiss=""toast"" aria-label=""Close"">
									<span aria-hidden=""true"">×</span>
								</button>
							</div>
							<div class=""toast-body"">
								Hello, world! This is a toast message.
							</div>
						</div> 
					</div>							
				</div>
			</div>
		</div>
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Placement <span class=""fw-300""><i>Toasts</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<");
            WriteLiteral(@"div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Place toasts with custom CSS as you need them. The top right is often used for notifications, as is the top middle. If you’re only ever going to show one toast at a time, put the positioning styles right on the <code>.toast</code>
					</div>
					<div aria-live=""polite"" aria-atomic=""true"" class=""d-flex justify-content-center align-items-center height-lg bg-info pattern-1"">
						<div class=""toast fade show"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" data-toggle=""toast"">
							<div class=""toast-header"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667a5196b7d44834b947638588c3b9d1ed569bd621695", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<strong class=\"mr-auto\">");
#nullable restore
#line 173 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Toasts.cshtml"
                                                   Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
								<small>11 mins ago</small>
								<button type=""button"" class=""ml-2 close"" data-dismiss=""toast"" aria-label=""Close"">
								<span aria-hidden=""true"">×</span>
								</button>
							</div>
							<div class=""toast-body"">
								Hello, world! This is a toast message.
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
