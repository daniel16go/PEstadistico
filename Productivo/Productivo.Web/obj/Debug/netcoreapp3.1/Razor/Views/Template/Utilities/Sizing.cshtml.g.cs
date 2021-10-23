#pragma checksum "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Utilities\Sizing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b07e2265ceba1e8c006db336d860a6cc39f746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Utilities_Sizing), @"mvc.1.0.view", @"/Views/Template/Utilities/Sizing.cshtml")]
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
#line 1 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b07e2265ceba1e8c006db336d860a6cc39f746", @"/Views/Template/Utilities/Sizing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Utilities_Sizing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Utilities\Sizing.cshtml"
   
	ViewData["Title"] = "Sizing";
	ViewData["PageName"] = "utilities_sizing";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i>  Sizing";
	ViewData["Category1"] = "Utilities";
	ViewData["PageDescription"] = "Easily make an element as wide or as tall with our width and height utilities.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral("<div class=\"alert alert-primary alert-dismissible\">\r\n\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t<span aria-hidden=\"true\">\r\n\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 507, "\"", 552, 2);
#nullable restore
#line 12 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Utilities\Sizing.cshtml"
WriteAttributeValue("", 515, Settings.Theme.IconPrefix, 515, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 543, "fa-times", 544, 9, true);
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
            BeginWriteAttribute("class", " class=\"", 888, "\"", 970, 5);
#nullable restore
#line 20 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Utilities\Sizing.cshtml"
WriteAttributeValue("", 896, Settings.Theme.IconPrefix, 896, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 924, "fa-info", 925, 8, true);
            WriteAttributeValue(" ", 932, "icon-stack-1x", 933, 14, true);
            WriteAttributeValue(" ", 946, "opacity-100", 947, 12, true);
            WriteAttributeValue(" ", 958, "color-white", 959, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
			</span>
		</div>
		<div class=""d-flex flex-fill"">
			<div class=""flex-fill"">
				<span class=""h5"">Additional modifiers</span>
				<br> 
				You are able to reset the height and width of an object by adding class <code>.height-mobile-auto</code> and <code>.width-mobile-auto</code>. Expand full height and width of your mobile device by adding <code>.expand-full-height-on-mobile</code> and <code>.expand-full-width-on-mobile</code>. Reset max and minium width/height by using the following modifier: <code>.h-auto</code>, <code>.w-auto</code>, <code>.max-width-reset</code>, <code>.max-height-reset</code>, and <code>.min-width-0</code>
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-12"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Width <span class=""fw-300""><i>presets</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-or");
            WriteLiteral(@"iginal-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Uniform widths to keep things aligned. See <code>helpers.scss</code> file for more details. You can also set <code>.width-0</code> to remove any given width, or you can use <code>.w-auto</code> to undo explicitly specified widths
					</div>
					<div class=""row"">
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-1
										</code>
									</p>
									<strong>
									");
            WriteLiteral(@"	Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 1.5rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-1""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-2
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 2rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-2""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div ");
            WriteLiteral(@"class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-3
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 2.5rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-3""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-4
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 2.75rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 widt");
            WriteLiteral(@"h-4""></div>						
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-5
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 3rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-5""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-6
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
							");
            WriteLiteral(@"			<i>change width to 3.25rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-6""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-7
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 3.5rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-7""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
");
            WriteLiteral(@"										<code>
											.width-8
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 3.75rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-8""></div>						
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-9
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 4rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-9""></div>
								</div>
							</div>
						</div>
						<di");
            WriteLiteral(@"v class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-10
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 4.25rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-10""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-xs
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change <u>min-width</u> to 5rem</i>
									</p>
									");
            WriteLiteral(@"<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-xs"" style=""max-width:5rem""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-4 col-xl-4"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-sm
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change <u>min-width</u> to 10rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-sm"" style=""max-width:10rem""></div>
								</div>
							</div>
						</div>
						<div class=""col-lg-6"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
            WriteLiteral(@"
											.width-lg
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change <u>min-width</u> to 15rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-lg"" style=""max-width:15rem""></div>
								</div>
							</div>
						</div>
						<div class=""col-lg-6"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.width-xl
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change <u>min-width</u> to 20rem</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 width-xl"" style=""max-width:20rem""></div>
								</div>
						");
            WriteLiteral(@"	</div>
						</div>	
					</div>
					<hr class=""my-5"">	
					<div class=""row"">		
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.w-25
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 25%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 w-25""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.w-50
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-mu");
            WriteLiteral(@"ted"">
										<i>change width to 50%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 w-50""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.w-75
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 75%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 w-75""></div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
		");
            WriteLiteral(@"								<code>
											.w-100
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change width to 100%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block bg-danger-50 height-1 opacity-50 mt-2 w-100""></div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Height <span class=""fw-300""><i>presets</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10""");
            WriteLiteral(@" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Uniform heights to keep things aligned. See <code>variables.scss</code> file for more details on <code>$p-*</code> values.
					</div>
					<div class=""card-columns"">
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-1
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 1.5rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-1 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
				");
            WriteLiteral(@"						.height-2
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 2rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-2 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-3
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 2.5rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-3 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<cod");
            WriteLiteral(@"e>
										.height-4
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 2.75rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-4 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-5
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 3rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-5 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
				");
            WriteLiteral(@"					<code>
										.height-6
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 3.25rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-6 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-7
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 3.5rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-7 opacity-50 mt-2 width-1""></div>
							</div>
						</div>	
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
					");
            WriteLiteral(@"			<p>
									<code>
										.height-8
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 3.75rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-8 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-9
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 4rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-9 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</stron");
            WriteLiteral(@"g>
								<p>
									<code>
										.height-10
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change height to 4.25rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-10 opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-xs
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change <u>min-height</u> to 5rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-xs opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
				");
            WriteLiteral(@"				<strong>Class</strong>
								<p>
									<code>
										.height-sm
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change <u>min-height</u> to 10rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-sm opacity-50 mt-2 width-1""></div>
							</div>
						</div>
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
							<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-lg
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change <u>min-height</u> to 15rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-lg opacity-50 mt-2 width-1""></div>
							</div>
						</div>	
						<div class=""card shadow-1 shadow-hover-5 mb-g"">
					");
            WriteLiteral(@"		<div class=""card-body p-3"">
								<strong>Class</strong>
								<p>
									<code>
										.height-xl
									</code>
								</p>
								<strong>
									Description
								</strong>
								<p class=""text-muted"">
									<i>change <u>min-height</u> to 20rem</i>
								</p>
								<strong>
									Example
								</strong>
								<div class=""d-block bg-info-50 height-xl opacity-50 mt-2 width-1""></div>
							</div>
						</div>		
					</div>
					<hr class=""my-5"">
					<div class=""row"">
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.h-25
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change height to 25%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-bloc");
            WriteLiteral(@"k height-10 mt-2 width-1 border border-primary"">
										<div class=""d-block bg-info-500 h-25 opacity-50 width-1""></div>
									</div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.h-50
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change height to 50%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block height-10 mt-2 width-1 border border-primary"">
										<div class=""d-block bg-info-500 h-50 opacity-50 width-1""></div>
									</div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>");
            WriteLiteral(@"Class</strong>
									<p>
										<code>
											.h-75
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change height to 75%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block height-10 mt-2 width-1 border border-primary"">
										<div class=""d-block bg-info-500 h-75 opacity-50 width-1""></div>
									</div>
								</div>
							</div>
						</div>
						<div class=""col-md-6 col-lg-6 col-xl-3"">
							<div class=""card shadow-1 shadow-hover-5 mb-g"">
								<div class=""card-body p-3"">
									<strong>Class</strong>
									<p>
										<code>
											.h-100
										</code>
									</p>
									<strong>
										Description
									</strong>
									<p class=""text-muted"">
										<i>change height to 100%</i>
									</p>
									<strong>
										Example
									</strong>
									<div class=""d-block height-");
            WriteLiteral("10 mt-2 width-1 border border-primary\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"d-block bg-info-500 h-100 opacity-50 width-1\"></div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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