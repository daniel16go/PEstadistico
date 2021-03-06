#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Spinners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ca5f3f9141a9ef5995b883b9d695171386c2db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Ui_Spinners), @"mvc.1.0.view", @"/Views/Template/Ui/Spinners.cshtml")]
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
#line 1 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ca5f3f9141a9ef5995b883b9d695171386c2db", @"/Views/Template/Ui/Spinners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Ui_Spinners : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Spinners.cshtml"
   
	ViewData["Title"] = "Spinners";
	ViewData["PageName"] = "ui_spinners";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i>  Spinners";
	ViewData["Category1"] = "UI Components";
	ViewData["PageDescription"] = "Indicate the loading state of a component or page with spinners, built entirely with HTML, CSS, and no JavaScript!";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral(@"<div class=""alert alert-primary"">
	<div class=""d-flex flex-start w-100"">
		<div class=""mr-2 hidden-md-down"">
			<span class=""icon-stack icon-stack-lg"">
				<i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i>
				<i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i>
				<i");
            BeginWriteAttribute("class", " class=\"", 714, "\"", 796, 5);
#nullable restore
#line 15 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Spinners.cshtml"
WriteAttributeValue("", 722, Settings.Theme.IconPrefix, 722, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 750, "fa-info", 751, 8, true);
            WriteAttributeValue(" ", 758, "icon-stack-1x", 759, 14, true);
            WriteAttributeValue(" ", 772, "opacity-100", 773, 12, true);
            WriteAttributeValue(" ", 784, "color-white", 785, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
			</span>
		</div>
		<div class=""d-flex flex-fill"">
			<div class=""flex-fill"">
				<span class=""h5"">About</span>
				<br> 
				CSS ???spinners??? can be used to show the loading state in your projects. They???re built only with HTML and CSS, meaning you don???t need any JavaScript to create them. You will, however, need some custom JavaScript to toggle their visibility. Their appearance, alignment, and sizing can be easily customized with our amazing utility classes.
				<br> 
				<br> 
				Learn more about this plugin on bootstrap's <a");
            BeginWriteAttribute("href", " href=\"", 1348, "\"", 1419, 3);
            WriteAttributeValue("", 1355, "https://getbootstrap.com/docs/", 1355, 30, true);
#nullable restore
#line 25 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Spinners.cshtml"
WriteAttributeValue("", 1385, ViewBag.Bs4v, 1385, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1398, "/components/spinners/", 1398, 21, true);
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
					Border <span class=""fw-300""><i>spinner</i></span> 
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
						Use the border spinners for a lightweight loading indicator
					</div>
					<div class=""spinner-border"" role=""status"">
						<span class=");
            WriteLiteral(@"""sr-only"">Loading...</span>
					</div>
				</div>
			</div>
		</div>	
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Color <span class=""fw-300""><i>spinners</i></span> 
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
						The border spinner uses <code>currentColor</code> for its <code>border-color</code>, meaning you can customize the color with <a href=""#"" target=""_blank"">text color utilities</a>. You can use a");
            WriteLiteral(@"ny of our text color utilities on the standard spinner
					</div>
					<div class=""demo"">
						<div class=""spinner-border text-primary"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-secondary"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-success"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-danger"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-warning"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-info"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-light"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border text-dark"" role=""status"">");
            WriteLiteral(@"
							<span class=""sr-only"">Loading...</span>
						</div>						
					</div>
				</div>
			</div>
		</div>	
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Spinner <span class=""fw-300""><i>Alignment</i></span> 
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
					</div>
					<h5 class=""frame-heading"">
						Flex
					</h5>
					<div class=""frame-wrap"">
						<div class=""border p-3"">
							<div class=""d-fl");
            WriteLiteral(@"ex justify-content-center"">
								<div class=""spinner-border"" role=""status"">
									<span class=""sr-only"">Loading...</span>
								</div>
							</div>
						</div>
					</div>
					<h5 class=""frame-heading"">
						Float
					</h5>
					<div class=""frame-wrap"">
						<div class=""border p-3"">
							<div class=""d-flex align-items-center"">
								<strong>Loading...</strong>
								<div class=""spinner-border ml-auto"" role=""status"" aria-hidden=""true""></div>
							</div>
						</div>
					</div>
					<h5 class=""frame-heading"">
						Text align
					</h5>
					<div class=""frame-wrap"">
						<div class=""border p-3"">
							<div class=""text-left"">
								<div class=""spinner-border"" role=""status"">
									<span class=""sr-only"">Loading...</span>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>	
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Spinner <span class=""fw-300""><i>sizes</i></span> 
				</h2>
				<div");
            WriteLiteral(@" class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Add <code>.spinner-border-sm</code> to make a smaller spinner that can quickly be used within other components. Or, use custom CSS or inline styles to change the dimensions as needed.
					</div>
					<div class=""demo-h-spacing"">
						<div class=""spinner-border"" style=""width: 3rem; height: 3rem;"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border"" role=""");
            WriteLiteral(@"status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border spinner-border-sm"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Shape <span class=""fw-300""><i>changes</i></span> 
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
						Change the shape of yo");
            WriteLiteral(@"ur spinner using border utilities
					</div>
					<div class=""demo-h-spacing"">
						<div class=""spinner-border rounded-0 text-primary"" style=""width: 3rem; height: 3rem;"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border rounded-0 text-danger"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-border rounded-0 text-info spinner-border-sm"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-6"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Spinner <span class=""fw-300""><i>nested</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-origin");
            WriteLiteral(@"al-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Use spinners within buttons to indicate an action is currently processing or taking place. You may also swap the text out of the spinner element and utilize button text as needed.
					</div>
					<div class=""demo"">
						<button class=""btn btn-success btn-icon rounded-circle"" type=""button"" disabled>
							<span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span>
							<span class=""sr-only"">Loading...</span>
						</button>
						<button class=""btn btn-primary"" type=""button"" disabled>
							<span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span>
							<span class=""sr-only"">Loading...</span>
						</button>
						<button class");
            WriteLiteral(@"=""btn btn-info"" type=""button"" disabled>
							<span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span>
							Loading...
						</button>
						<button class=""btn btn-danger rounded-pill"" type=""button"" disabled>
							<span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span>
							Loading...
						</button>
					</div>
				</div>
			</div>
		</div>	
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-7"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Growing <span class=""fw-300""><i>spinner</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-");
            WriteLiteral(@"offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						If you don???t fancy a border spinner, switch to the grow spinner
					</div>
					<div class=""spinner-grow"" role=""status"">
						<span class=""sr-only"">Loading...</span>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-8"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Growing <span class=""fw-300""><i>spinner colors</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""><");
            WriteLiteral(@"/button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Once again, this spinner is built with <code>currentColor</code>, so you can easily change its appearance with <a href=""#"" target=""_blank"">text color utilities</a>
					</div>
					<div class=""demo"">
						<div class=""spinner-grow text-primary"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-secondary"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-success"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-danger"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-warning"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-info"" role=""status""");
            WriteLiteral(@">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-light"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow text-dark"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-9"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Growing <span class=""fw-300""><i>spinner alignment</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-co");
            WriteLiteral(@"ntainer show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
					</div>
					<h5 class=""frame-heading"">
						Flex
					</h5>
					<div class=""frame-wrap"">
						<div class=""border p-3"">
							<div class=""d-flex justify-content-center"">
								<div class=""spinner-grow"" role=""status"">
									<span class=""sr-only"">Loading...</span>
								</div>
							</div>
						</div>
					</div>
					<h5 class=""frame-heading"">
						Float
					</h5>
					<div class=""frame-wrap"">
						<div class=""border p-3"">
							<div class=""d-flex align-items-center"">
								<strong>Loading...</strong>
								<div class=""spinner-grow ml-auto"" role=""status"" aria-hidden=""true""></div>
							</div>
						</div>
					</div>
					<h5 class=""frame-heading"">
						Text align
					</h5>
					<div class=""frame-wrap"">
						<div class=""border p-3"">
							<div class=""text-left"">
								<div class=""spinner-grow"" role=""status"">
									<span class=""sr-only"">Loading...</span>
				");
            WriteLiteral(@"				</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-10"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Growing <span class=""fw-300""><i>spinner sizes</i></span> 
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
						Add <code>.spinner-grow-sm</code> to make a smaller spinner that can quickly be used within other components. Or, use custom CSS or inline styles to change the dimensions as ");
            WriteLiteral(@"needed.
					</div>
					<div class=""demo-h-spacing"">
						<div class=""spinner-grow"" style=""width: 3rem; height: 3rem;"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow spinner-grow-sm"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-11"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Shape <span class=""fw-300""><i>shifting</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data");
            WriteLiteral(@"-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Change the shape of your growing spinner using border utilities
					</div>
					<div class=""demo-h-spacing"">
						<div class=""spinner-grow rounded-0 text-primary"" style=""width: 3rem; height: 3rem;"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow rounded-0 text-danger"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
						<div class=""spinner-grow spinner-grow-sm rounded-0 text-info"" role=""status"">
							<span class=""sr-only"">Loading...</span>
						</div>
					</div>
				</div>
			</div>
		</div>	
		<div id=""panel-12"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Growing <span class=""fw-300""><i>spinner nested</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button clas");
            WriteLiteral(@"s=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Use spinners within buttons to indicate an action is currently processing or taking place. You may also swap the text out of the spinner element and utilize button text as needed.
					</div>
					<div class=""demo"">
						<button class=""btn btn-success btn-icon rounded-circle"" type=""button"" disabled>
							<span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>
							<span class=""sr-only"">Loading...</span>
						</button>");
            WriteLiteral(@"
						<button class=""btn btn-primary"" type=""button"" disabled>
							<span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>
							<span class=""sr-only"">Loading...</span>
						</button>
						<button class=""btn btn-info"" type=""button"" disabled>
							<span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>
							Loading...
						</button>
						<button class=""btn btn-danger rounded-pill"" type=""button"" disabled>
							<span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>
							Loading...
						</button>
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
