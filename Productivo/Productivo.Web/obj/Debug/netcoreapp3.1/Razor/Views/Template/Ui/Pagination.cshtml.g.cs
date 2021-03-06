#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef576a0364326c881545dfd1a78fde001c24915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Ui_Pagination), @"mvc.1.0.view", @"/Views/Template/Ui/Pagination.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef576a0364326c881545dfd1a78fde001c24915", @"/Views/Template/Ui/Pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Ui_Pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
   
	ViewData["Title"] = "Pagination";
	ViewData["PageName"] = "ui_pagination";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i> Pagination";
	ViewData["Category1"] = "UI Components";
	ViewData["PageDescription"] = "Examples for showing pagination to indicate a series of related content exists across multiple pages.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral(@"<div class=""row"">
	 <div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Basic <span class=""fw-300""><i>example</i></span> 
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
						<p>We use a large block of connected links for our pagination, making links hard to miss and easily scalable???all while providing large hit areas. Pagination is built with list HTML elements so screen readers can announce the ");
            WriteLiteral(@"number of available links. Use a wrapping <code>&lt;nav&gt;</code> element to identify it as a navigation section to screen readers and other assistive technologies.</p>
						<p>In addition, as pages likely have more than one such navigation section, it???s advisable to provide a descriptive <code>aria-label</code> for the <code>&lt;nav&gt;</code> to reflect its purpose. For example, if the pagination component is used to navigate between a set of search results, an appropriate label could be <code>aria-label=""Search results pages""</code>.</p>						
					</div>
					<nav aria-label=""Page navigation example"">
						<ul class=""pagination"">
							<li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
							<li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
							<li class=""page-item active"" aria-current=""page"">
								<a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
							</li>
							<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>");
            WriteLiteral(@"
							<li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
						</ul>
					</nav>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Different <span class=""fw-300""><i>states</i></span> 
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
						<p>Pagination links are customizable for different circumstances. Use <code>.disabled</code> for links that appear un-clickable and ");
            WriteLiteral(@"<code>.active</code> to indicate the current page.</p>
						<p>While the <code>.disabled</code> class uses <code>pointer-events: none</code> to <em>try</em> to disable the link functionality of <code>&lt;a&gt;</code>s, that CSS property is not yet standardized and doesn???t account for keyboard navigation. As such, you should always add <code>tabindex=""-1""</code> on disabled links and use custom JavaScript to fully disable their functionality.</p>
					</div>
					<nav aria-label=""..."">
						<ul class=""pagination"">
							<li class=""page-item disabled"">
								<a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
							</li>
							<li class=""page-item disabled"">
								<a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">1</a>
							</li>
							<li class=""page-item active"" aria-current=""page"">
								<a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
							</li>
							<li class=""page-item""><a class=""page-link"" href=""#"">3</a></l");
            WriteLiteral(@"i>
							<li class=""page-item"">
								<a class=""page-link"" href=""#"">Next</a>
							</li>
						</ul>
					</nav>
					<hr class=""my-5""> 
					<p>You can optionally swap out active or disabled anchors for <code>&lt;span&gt;</code>, or omit the anchor in the case of the prev/next arrows, to remove click functionality and prevent keyboard focus while retaining intended styles.</p>
					<nav aria-label=""..."">
						<ul class=""pagination"">
							<li class=""page-item disabled"">
								<span class=""page-link"">Previous</span>
							</li>
							<li class=""page-item disabled"">
								<a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">1</a>
							</li>
							<li class=""page-item active"" aria-current=""page"">
								<span class=""page-link"">
								2
								<span class=""sr-only"">(current)</span>
								</span>
							</li>
							<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
							<li class=""page-item"">
								<a class=""page-link"" href=""#"">Next</a>
		");
            WriteLiteral(@"					</li>
						</ul>
					</nav>
				</div>
			</div>
		</div>
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Using <span class=""fw-300""><i>icons</i></span> 
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
						Looking to use an icon or symbol in place of text for some pagination links? Be sure to provide proper screen reader support with aria attributes.
					</div>
					<div class=""row"">
						<div class");
            WriteLiteral(@"=""col-lg-4"">
							<nav aria-label=""Page navigation example"">
								<ul class=""pagination"">
									<li class=""page-item"">
										<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true"">&laquo;</span>
										</a>
									</li>
									<li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
									<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
									<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
									<li class=""page-item"">
										<a class=""page-link"" href=""#"" aria-label=""Next"">
										<span aria-hidden=""true"">&raquo;</span>
										</a>
									</li>
								</ul>
							</nav>	
						</div>
						<div class=""col-lg-4"">
							<nav aria-label=""Page navigation example"">
								<ul class=""pagination justify-content-center"">
									<li class=""page-item"">
										<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 7505, "\"", 7555, 2);
#nullable restore
#line 142 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 7513, Settings.Theme.IconPrefix, 7513, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7541, "fa-angle-left", 7542, 14, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
										</a>
									</li>
									<li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
									<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
									<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
									<li class=""page-item"">
										<a class=""page-link"" href=""#"" aria-label=""Next"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 7951, "\"", 8002, 2);
#nullable restore
#line 150 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 7959, Settings.Theme.IconPrefix, 7959, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7987, "fa-angle-right", 7988, 15, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
										</a>
									</li>
								</ul>
							</nav>	
						</div>
						<div class=""col-lg-4"">
							<nav aria-label=""Page navigation example"">
								<ul class=""pagination justify-content-end"">
									<li class=""page-item"">
										<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 8362, "\"", 8417, 2);
#nullable restore
#line 161 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 8370, Settings.Theme.IconPrefix, 8370, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8398, "fa-hand-point-left", 8399, 19, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
										</a>
									</li>
									<li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
									<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
									<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
									<li class=""page-item"">
										<a class=""page-link"" href=""#"" aria-label=""Next"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 8813, "\"", 8869, 2);
#nullable restore
#line 169 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 8821, Settings.Theme.IconPrefix, 8821, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8849, "fa-hand-point-right", 8850, 20, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
										</a>
									</li>
								</ul>
							</nav>	
						</div>						
					</div>
				</div>
			</div>
		</div>
	 </div>
	 <div class=""col-xl-6"">
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Pagination <span class=""fw-300""><i>sizing</i></span> 
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
						<p>Fancy larger or smaller pagination? Add <code>.pagination-lg</code> or <code>.pagina");
            WriteLiteral(@"tion-sm</code> for additional sizes.</p>
					</div>
					<h5 class=""frame-heading"">
						Large
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""..."">
							<ul class=""pagination pagination-lg"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 10255, "\"", 10307, 2);
#nullable restore
#line 205 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 10263, Settings.Theme.IconPrefix, 10263, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10291, "fa-chevron-left", 10292, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
									1
									<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"" aria-label=""Next"">
									<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 10811, "\"", 10864, 2);
#nullable restore
#line 218 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 10819, Settings.Theme.IconPrefix, 10819, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10847, "fa-chevron-right", 10848, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
							</ul>
						</nav>						
					</div>
					<h5 class=""frame-heading"">
						Default
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""..."">
							<ul class=""pagination"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 11250, "\"", 11302, 2);
#nullable restore
#line 232 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 11258, Settings.Theme.IconPrefix, 11258, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11286, "fa-chevron-left", 11287, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
									1
									<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"" aria-label=""Next"">
									<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 11806, "\"", 11859, 2);
#nullable restore
#line 245 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 11814, Settings.Theme.IconPrefix, 11814, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11842, "fa-chevron-right", 11843, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
							</ul>
						</nav>						
					</div>					
					<h5 class=""frame-heading"">
						Small
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""..."">
							<ul class=""pagination pagination-sm"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 12262, "\"", 12314, 2);
#nullable restore
#line 259 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 12270, Settings.Theme.IconPrefix, 12270, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 12298, "fa-chevron-left", 12299, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
										1
										<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"" aria-label=""Next"">
									<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 12820, "\"", 12873, 2);
#nullable restore
#line 272 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 12828, Settings.Theme.IconPrefix, 12828, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 12856, "fa-chevron-right", 12857, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
							</ul>
						</nav>						
					</div>
					<h5 class=""frame-heading"">
						Extra Small
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""..."">
							<ul class=""pagination pagination-xs"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" aria-label=""Previous"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 13277, "\"", 13329, 2);
#nullable restore
#line 286 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 13285, Settings.Theme.IconPrefix, 13285, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 13313, "fa-chevron-left", 13314, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
										1
										<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"" aria-label=""Next"">
									<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 13835, "\"", 13888, 2);
#nullable restore
#line 299 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Pagination.cshtml"
WriteAttributeValue("", 13843, Settings.Theme.IconPrefix, 13843, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 13871, "fa-chevron-right", 13872, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</a>
								</li>
							</ul>
						</nav>						
					</div>
				</div>
			</div>
		</div>	
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Aligning <span class=""fw-300""><i>pagination</i></span> 
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
						With left being default, you may change the alignment of pagination components with flexbox utilities.
					</div>
					<h5 class=""frame-");
            WriteLiteral(@"heading"">
						Default
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""Page navigation example"">
							<ul class=""pagination"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
										1
										<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">Next</a>
								</li>
							</ul>
						</nav>
					</div>					
					<h5 class=""frame-heading text-center"">
						Center
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""Page navigation example"">
							<ul class=""pagination justify-content-center"">
								<li class=""page-item disabled"">
					");
            WriteLiteral(@"				<a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
										1
										<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">Next</a>
								</li>
							</ul>
						</nav>
					</div>
					<h5 class=""frame-heading text-right"">
						Right
					</h5>
					<div class=""frame-wrap"">
						<nav aria-label=""Page navigation example"">
							<ul class=""pagination justify-content-end"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
								</li>
								<li class=""page-item active"" aria-current=""page"">
									<span class=""page-link"">
										1
		");
            WriteLiteral(@"								<span class=""sr-only"">(current)</span>
									</span>
								</li>
								<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
								<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">Next</a>
								</li>
							</ul>
						</nav>					
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
