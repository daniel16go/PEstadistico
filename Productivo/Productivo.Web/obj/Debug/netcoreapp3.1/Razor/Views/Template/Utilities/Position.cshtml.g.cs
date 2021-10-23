#pragma checksum "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8902fb861780651f76e424a995f7867458ed18ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Utilities_Position), @"mvc.1.0.view", @"/Views/Template/Utilities/Position.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8902fb861780651f76e424a995f7867458ed18ba", @"/Views/Template/Utilities/Position.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Utilities_Position : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
   
	ViewData["Title"] = "Position";
	ViewData["PageName"] = "utilities_position";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i>  Position";
	ViewData["Category1"] = "Utilities";
	ViewData["PageDescription"] = "Use these shorthand utilities for quickly configuring the position of an element.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral("<div class=\"alert alert-primary alert-dismissible\">\r\n\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t<span aria-hidden=\"true\">\r\n\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 516, "\"", 561, 2);
#nullable restore
#line 12 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
WriteAttributeValue("", 524, Settings.Theme.IconPrefix, 524, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 552, "fa-times", 553, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
		</span>
	</button>
	<div class=""d-flex flex-start w-100"">
		<div class=""mr-2 d-sm-none d-md-block"">
			<span class=""icon-stack icon-stack-lg"">
				<i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i>
				<i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i>
				<i");
            BeginWriteAttribute("class", " class=\"", 897, "\"", 979, 5);
#nullable restore
#line 20 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
WriteAttributeValue("", 905, Settings.Theme.IconPrefix, 905, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 933, "fa-info", 934, 8, true);
            WriteAttributeValue(" ", 941, "icon-stack-1x", 942, 14, true);
            WriteAttributeValue(" ", 955, "opacity-100", 956, 12, true);
            WriteAttributeValue(" ", 967, "color-white", 968, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
			</span>
		</div>
		<div class=""d-flex flex-fill"">
			<div class=""flex-fill"">
				<span class=""h5"">Mobile friendly classes</span>
				<br> 
				Positions can also be changed for mobile viewports by adding the following classes, <code>.position-on-mobile-absolute</code>, <code>.position-on-mobile-relative</code>, and <code>.position-on-mobile-static</code>
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Position <span class=""fw-300""><i>Fixed</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset");
            WriteLiteral(@"=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						An element with <code>.position-fixed</code>; is positioned relative to the viewport, which means it always stays in the same place even if the page is scrolled. The <code>top</code>, <code>right</code>, <code>bottom</code>, and <code>left</code> properties are used to position the element
					</div>
					<button type=""button"" class=""btn btn-outline-danger hidden-sm-down"" data-toggle=""popover"" data-template='<div class=""popover max-width-reset"" role=""tooltip""><div class=""arrow""></div><div class=""popover-body p-3""></div></div>' data-placement=""top"" data-trigger=""hover""");
            BeginWriteAttribute("title", " title=\"", 2768, "\"", 2776, 0);
            EndWriteAttribute();
            WriteLiteral(" data-html=\"true\" data-content=\'<img src=\"~/img/demo/position-fixed.gif\" alt=\"\" style=\"width:360px\">\'><i");
            BeginWriteAttribute("class", " class=\"", 2881, "\"", 2930, 3);
#nullable restore
#line 50 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
WriteAttributeValue("", 2889, Settings.Theme.IconPrefix, 2889, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2917, "fa-play", 2918, 8, true);
            WriteAttributeValue(" ", 2925, "mr-2", 2926, 5, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>Live example</button>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Position <span class=""fw-300""><i>Relative</i></span> 
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
						In <code>.position-relative</code>, the element is positioned relative to itself. However, an absolute positioned element is relative to its parent. An element with <code>position: absolute</code> is remov");
            WriteLiteral(@"ed from the normal document flow. ... If it doesn't have any parent elements, then the initial document <code>html</code> will be its parent
					</div>
					<div class=""row"">
						<div class=""col-sm-6"">
							<div class=""demo-window rounded shadow-1 mb-4 mb-sm-0"">
								<div class=""demo-window-content"">
									<div class=""d-flex flex-row"" style=""height:15rem"">
										<div class=""flex-grow-1 w-100 bg-info-50 p-3 position-relative d-flex flex-column"">
											<div class=""border border-danger flex-grow-1 p-2 position-relative"">
												.position-relative
												<p class=""position-absolute pos-right pos-bottom p-2 bg-fusion-500 m-0"">.position-absolute</p>
											</div>
										</div>
									</div>
								</div>
							</div>							
						</div>
						<div class=""col-sm-6"">
							<div class=""demo-window rounded shadow-1"">
								<div class=""demo-window-content"">
									<div class=""d-flex flex-row"" style=""height:15rem"">
										<div class=""w-100 flex-grow-1 ");
            WriteLiteral(@"bg-success-50 p-3 position-relative d-flex flex-column"">
											<div class=""border border-danger flex-grow-1 p-6 position-relative d-flex flex-column"">
												<div class=""position-absolute pos-top pos-left p-2"">.position-relative</div>
												<div class=""border border-danger flex-grow-1 p-2 position-relative"">
													.position-relative
													<p class=""position-absolute pos-right pos-bottom p-2 bg-fusion-500 m-0"">.position-absolute</p>
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
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Position <span class=""fw-300""><i>Absolute</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""pane");
            WriteLiteral(@"l-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						An element with <code>.position-absolute</code>; is positioned relative to the nearest positioned ancestor (instead of positioned relative to the viewport, like fixed). However; if an absolute positioned element has no positioned ancestors, it uses the document body, and moves along with page scrolling. You can use <code>.pos-top</code>, <code>.pos-right</code>, <code>.pos-bottom</code>, and <code>.pos-left</code> to position relavant to its closest relative positioned ancenstor
					</div>
					<div class=""demo-window rounded mb-g shadow-1"">
						<div class=""demo-window-content"">
							<div class=""position-relative"" style=""height");
            WriteLiteral(@":15rem"">
								<div class=""bg-primary-50 p-2 position-absolute w-100 pos-top"">
									.position-absolute .pos-top
								</div>
								<div class=""bg-info-50 p-2 position-absolute w-100 pos-bottom"">
									.position-absolute .pos-bottom
								</div>
								<div class=""bg-danger-50 p-2 position-absolute h-100 pos-right d-flex align-items-center"" style=""width:120px;"">
									<span class=""rotate-270 text-nowrap"">.position-absolute .pos-right</span> 
								</div>
							</div>
						</div>
					</div>
					<button type=""button"" class=""btn btn-outline-danger hidden-sm-down"" data-toggle=""popover"" data-template='<div class=""popover max-width-reset"" role=""tooltip""><div class=""arrow""></div><div class=""popover-body p-3""></div></div>' data-placement=""top"" data-trigger=""hover""");
            BeginWriteAttribute("title", " title=\"", 7830, "\"", 7838, 0);
            EndWriteAttribute();
            WriteLiteral(" data-html=\"true\" data-content=\'<img src=\"~/img/demo/position-absolute.gif\" alt=\"\" style=\"width:360px\">\'><i");
            BeginWriteAttribute("class", " class=\"", 7946, "\"", 7995, 3);
#nullable restore
#line 137 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
WriteAttributeValue("", 7954, Settings.Theme.IconPrefix, 7954, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7982, "fa-play", 7983, 8, true);
            WriteAttributeValue(" ", 7990, "mr-2", 7991, 5, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>Live example</button>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Position <span class=""fw-300""><i>Sticky</i></span> 
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
						<p>Position an element at the top of the viewport, from edge to edge, but only after you scroll past it. The <code>.sticky-top</code> utility uses CSS’s <code>position: stic");
            WriteLiteral("ky</code>, which isn’t fully supported in all browsers.</p>\r\n\t\t\t\t\t\t<p><strong>IE11 and IE10 will render <code>position: sticky</code> as <code>position: relative</code>.</strong> As such, we wrap the styles in a <code>");
            WriteLiteral(@"@supports</code> query, limiting the stickiness to only browsers that can render it properly.</p>
					</div>
					<div class=""demo-window rounded shadow-1 mb-g"">
						<div class=""demo-window-content"">
							<div class=""d-flex flex-row"">
								<div class=""position-relative overflow-auto p-3"" style=""height: 300px;"">
									<h5 class=""fw-500 opacity-70"">
										Sticky Element: Scroll Down to See the Effect
										<small>
											Scroll down this page to see how sticky positioning works
										</small>
									</h5>
									<nav class=""navbar navbar-expand-lg sticky-top bg-faded"">
										<a class=""navbar-brand d-flex align-items-center fw-500"" href=""#"">
											");
#nullable restore
#line 172 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
                                       Write(Settings.AppName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
										</a>
										<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSticky"" aria-expanded=""false"" aria-label=""Toggle navigation"">
											<span class=""navbar-toggler-icon""></span>
										</button>
										This will be sticky
									</nav>
									<br>
									<p class=""opacity-70"">Some example text..</p>
									<h5 class=""opacity-70"">Scroll back up again to ""remove"" the sticky position.</h5>
									<p class=""opacity-50"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus imperdiet, nulla et dictum interdum, nisi lorem egestas odio, vitae scelerisque enim ligula venenatis dolor. Maecenas nisl est, ultrices</p>
									<p>1..</p>
									<p>...</p>
									<p>...</p>
									<p>...</p>
									<p>4..</p>
									<p>...</p>
									<p>...</p>
									<p>...</p>
									<p>8..</p>
									<p>...</p>
									<p>...</p>
									<p>...</p>
									<p>12.</p>
									<p>...</p>
									<p>...</p>
				");
            WriteLiteral(@"					<p>...</p>
									<p>16.</p>
									<p>...</p>
									<p>...</p>
									<p>...</p>
									<p>20.</p>
									<p>...</p>
									<p>...</p>
									<p>...</p>
									<p>24.</p>
								</div>
							</div>
						</div>
					</div>		
					<button type=""button"" class=""btn btn-outline-danger hidden-sm-down"" data-toggle=""popover"" data-template='<div class=""popover max-width-reset"" role=""tooltip""><div class=""arrow""></div><div class=""popover-body p-3""></div></div>' data-placement=""top"" data-trigger=""hover""");
            BeginWriteAttribute("title", " title=\"", 11525, "\"", 11533, 0);
            EndWriteAttribute();
            WriteLiteral(" data-html=\"true\" data-content=\'<img src=\"~/img/demo/position-sticky.gif\" alt=\"\" style=\"width:360px\">\'><i");
            BeginWriteAttribute("class", " class=\"", 11639, "\"", 11688, 3);
#nullable restore
#line 212 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Utilities\Position.cshtml"
WriteAttributeValue("", 11647, Settings.Theme.IconPrefix, 11647, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11675, "fa-play", 11676, 8, true);
            WriteAttributeValue(" ", 11683, "mr-2", 11684, 5, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>Live example</button>
				</div>
			</div>
		</div>
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Position <span class=""fw-300""><i>Static</i></span> 
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
						Every element has a static position by default, so the element will stick to the normal page flow. So if there is a left/right/top/bottom/z-index set then there will be no effect on that element. Adding <cod");
            WriteLiteral(@"e>.position-static</code> will generally 'reset' these properties
					</div>
					<div class=""demo-window rounded shadow-1 mb-g"">
						<div class=""demo-window-content"">
							<div class=""d-flex flex-row"" style=""height:15rem"">
								<div class=""w-100 flex-grow-1 bg-highlight p-3 position-relative d-flex flex-column"">
									<div class=""border border-danger flex-grow-1 p-6 position-relative d-flex flex-column"">
										<div class=""position-absolute pos-top pos-left p-2"">.position-relative</div>
										<div class=""border border-danger flex-grow-1 p-2"" id=""js-position-change"">
											<strong class=""text-danger"" id=""js-position-text"">.position-static</strong>
											<p class=""position-absolute pos-right pos-bottom p-2 bg-fusion-500 m-0"">.position-absolute</p>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<button class=""btn btn-outline-success"" onclick=""swapPositions();"" id=""js-position-btn"">Change to RELATIVE</button>
				</div>
	");
            WriteLiteral("\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral(@"
<script type=""text/javascript"">
	var swapPositions = function (){
		console.log(""test2"")
		$('#js-position-change').toggleClass('position-relative');
		$('#js-position-text').toggleText('.position-static', '.position-relative');
		$('#js-position-btn').toggleText('Change to RELATIVE', 'Change to STATIC');
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
