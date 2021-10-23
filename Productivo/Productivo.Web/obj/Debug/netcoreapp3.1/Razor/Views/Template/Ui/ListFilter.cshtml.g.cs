#pragma checksum "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd86b77580aa5160c5117c3f81756faa3c778996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Ui_ListFilter), @"mvc.1.0.view", @"/Views/Template/Ui/ListFilter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd86b77580aa5160c5117c3f81756faa3c778996", @"/Views/Template/Ui/ListFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Ui_ListFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
   
	ViewData["Title"] = "List filter";
	ViewData["PageName"] = "ui_list_filter";
	ViewData["Category1"] = "UI Components";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i> List filter";
	ViewData["PageDescription"] = "Allow any lists to be filtered via the included filter plugin. Very easy to setup, no programming needed!";

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
					Default <span class=""fw-300""><i>List filter</i></span> 
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
						To create a list filter, you will need to first create an <code>input</code> and an list, assigning ID to each. For each list item you will add related filter tags separated by spaces <code>data-filter-tags=""*""</code> wh");
            WriteLiteral(@"ich will be used to filter out the list item. Activate the filter tags by initlizing the script <code>initApp.listFilter($('list_id'), $('input_id'));</code> 
					</div>
					<div id=""js_default_list"">
						<div class=""input-group mb-g"">
							<input type=""text"" class=""form-control form-control-lg shadow-inset-2"" id=""js_default_list_filter"" placeholder=""Filter list"">
							<div class=""input-group-append"">
								<div class=""input-group-text"">
									<i");
            BeginWriteAttribute("class", " class=\"", 1873, "\"", 1925, 3);
#nullable restore
#line 32 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 1881, Settings.Theme.IconPrefix, 1881, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1909, "fa-search", 1910, 10, true);
            WriteAttributeValue(" ", 1919, "fs-xl", 1920, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</div>
							</div>
						</div>
						<ul class=""list-group"">
							<li class=""list-group-item"">
								<span data-filter-tags=""reports file"">Reports</span>
							</li>
							<li class=""list-group-item"">
								<span data-filter-tags=""analytics graphs"">Analytics</span>
							</li>
							<li class=""list-group-item"">
								<span data-filter-tags=""export download"">Export</span>
							</li>
							<li class=""list-group-item"">
								<span data-filter-tags=""storage"">Storage</span>
							</li>
						</ul>
					</div>	
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Filter <span class=""fw-300""><i>Accordions</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=");
            WriteLiteral(@"""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						You can arrange your filters like so to filter accordion headings
					</div>
					<div class=""border bg-light rounded-top"">
						<div class=""form-group p-2 m-0 rounded-top"">
							<input type=""text"" class=""form-control form-control-lg shadow-inset-2 m-0"" id=""js_list_accordion_filter"" placeholder=""Filter accordion"">
						</div>
						<div id=""js_list_accordion"" class=""accordion accordion-hover accordion-clean"">
							<div class=""card border-top-left-radius-0 border-top-right-radius-0"">
								<div class=""card-header"">
									<a href=""javascript:void(0);"" class=""card-title"" data-toggle=""collapse"" data-target=""#js_list_accordion-a"" aria-expanded=""true"" data-filter-tags=");
            WriteLiteral("\"settings\">\r\n\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 3999, "\"", 4056, 4);
#nullable restore
#line 78 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 4007, Settings.Theme.IconPrefix, 4007, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4035, "fa-cog", 4036, 7, true);
            WriteAttributeValue(" ", 4042, "width-2", 4043, 8, true);
            WriteAttributeValue(" ", 4050, "fs-xl", 4051, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\tSettings\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"ml-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-reveal\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 4176, "\"", 4232, 3);
#nullable restore
#line 82 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 4184, Settings.Theme.IconPrefix, 4184, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4212, "fa-chevron-up", 4213, 14, true);
            WriteAttributeValue(" ", 4226, "fs-xl", 4227, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 4318, "\"", 4376, 3);
#nullable restore
#line 85 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 4326, Settings.Theme.IconPrefix, 4326, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4354, "fa-chevron-down", 4355, 16, true);
            WriteAttributeValue(" ", 4370, "fs-xl", 4371, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""js_list_accordion-a"" class=""collapse show"" data-parent=""#js_list_accordion"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.
									</div>
								</div>
							</div>
							<div class=""card"">
								<div class=""card-header"">
									<a href=""javascript:void(0);"" class=""card-title collapsed"" data-toggle=""collapse"" data-target=""#js_list_accordion-b"" aria-expanded=""false"" data-filter-tags=""merge"">
										<i");
            BeginWriteAttribute("class", " class=\"", 5052, "\"", 5116, 4);
#nullable restore
#line 99 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 5060, Settings.Theme.IconPrefix, 5060, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5088, "fa-code-merge", 5089, 14, true);
            WriteAttributeValue(" ", 5102, "width-2", 5103, 8, true);
            WriteAttributeValue(" ", 5110, "fs-xl", 5111, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\tMerge reports\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"ml-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-reveal\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 5241, "\"", 5297, 3);
#nullable restore
#line 103 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 5249, Settings.Theme.IconPrefix, 5249, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5277, "fa-chevron-up", 5278, 14, true);
            WriteAttributeValue(" ", 5291, "fs-xl", 5292, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 5383, "\"", 5441, 3);
#nullable restore
#line 106 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 5391, Settings.Theme.IconPrefix, 5391, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5419, "fa-chevron-down", 5420, 16, true);
            WriteAttributeValue(" ", 5435, "fs-xl", 5436, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""js_list_accordion-b"" class=""collapse"" data-parent=""#js_list_accordion"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. 
									</div>
								</div>
							</div>
							<div class=""card"">
								<div class=""card-header"">
									<a href=""javascript:void(0);"" class=""card-title collapsed"" data-toggle=""collapse"" data-target=""#js_list_accordion-c"" aria-expanded=""false"" data-filter-tags=""backup"">
										<i");
            BeginWriteAttribute("class", " class=\"", 6114, "\"", 6184, 4);
#nullable restore
#line 120 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 6122, Settings.Theme.IconPrefix, 6122, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6150, "fa-cloud-upload-alt", 6151, 20, true);
            WriteAttributeValue(" ", 6170, "width-2", 6171, 8, true);
            WriteAttributeValue(" ", 6178, "fs-xl", 6179, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\tBackup reports\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"ml-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-reveal\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 6310, "\"", 6366, 3);
#nullable restore
#line 124 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 6318, Settings.Theme.IconPrefix, 6318, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6346, "fa-chevron-up", 6347, 14, true);
            WriteAttributeValue(" ", 6360, "fs-xl", 6361, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 6452, "\"", 6510, 3);
#nullable restore
#line 127 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 6460, Settings.Theme.IconPrefix, 6460, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6488, "fa-chevron-down", 6489, 16, true);
            WriteAttributeValue(" ", 6504, "fs-xl", 6505, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""js_list_accordion-c"" class=""collapse"" data-parent=""#js_list_accordion"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.
									</div>
								</div>
							</div>
						</div>
						<span class=""filter-message js-filter-message""></span>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Custom <span class=""fw-300""><i>response message</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-ori");
            WriteLiteral(@"ginal-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						To add a response message for the filter input, you can add a container with the class <code>.filter-message.js-filter-message</code> right after the list group
					</div>
					<div class=""frame-heading"">
						Typing something to see the response message
					</div>
					<div class=""bg-warning-100 border border-warning rounded"">
						<div class=""input-group p-2 mb-0"">
							<input type=""text"" class=""form-control form-control-lg shadow-inset-2 bg-warning-50 border-warning"" id=""js-list-msg-filter"" placeholder=""Filter list"">
							<div class=""input-group-append"">
								<div class=""input-group-text bg-warning-500 border-warning"">
									<i");
            BeginWriteAttribute("class", " class=\"", 8514, "\"", 8566, 3);
#nullable restore
#line 170 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 8522, Settings.Theme.IconPrefix, 8522, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8550, "fa-search", 8551, 10, true);
            WriteAttributeValue(" ", 8560, "fs-xl", 8561, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</div>
							</div>
						</div>
						<ul id=""js-list-msg"" class=""list-group px-2 pb-2"">
							<li class=""list-group-item"">
								<span data-filter-tags=""reports file"">Reports</span>
							</li>
							<li class=""list-group-item"">
								<span data-filter-tags=""analytics graphs"">Analytics</span>
							</li>
							<li class=""list-group-item"">
								<span data-filter-tags=""export download"">Export</span>
							</li>
							<li class=""list-group-item"">
								<span data-filter-tags=""storage"">Storage</span>
							</li>
						</ul>
						<div class=""filter-message js-filter-message mt-0 fs-sm""></div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Nested <span class=""fw-300""><i>filter</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<b");
            WriteLiteral(@"utton class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""bg-success-900 rounded bg-info-gradient"">
						<div class=""d-flex position-relative py-3 px-4"">
							<i");
            BeginWriteAttribute("class", " class=\"", 10105, "\"", 10222, 10);
#nullable restore
#line 208 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Ui\ListFilter.cshtml"
WriteAttributeValue("", 10113, Settings.Theme.IconPrefix, 10113, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10141, "fa-search", 10142, 10, true);
            WriteAttributeValue(" ", 10151, "color-success-700", 10152, 18, true);
            WriteAttributeValue(" ", 10169, "position-absolute", 10170, 18, true);
            WriteAttributeValue(" ", 10187, "pos-left", 10188, 9, true);
            WriteAttributeValue(" ", 10196, "fs-lg", 10197, 6, true);
            WriteAttributeValue(" ", 10202, "px-3", 10203, 5, true);
            WriteAttributeValue(" ", 10207, "py-2", 10208, 5, true);
            WriteAttributeValue(" ", 10212, "mt-1", 10213, 5, true);
            WriteAttributeValue(" ", 10217, "ml-4", 10218, 5, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
							<input type=""text"" id=""js_nested_list_filter"" class=""form-control shadow-inset-1 pl-6 border-success"" placeholder=""Filter nested items (e.g buttons, chart)"">
						</div>
						<ul id=""js_nested_list"" class=""nav-menu nav-menu-reset nav-menu-compact bg-success-900 bg-info-gradient mb-sm-4 mb-md-0 rounded"" data-nav-accordion=""true"">
							<li class=""open active"">
								<a href=""#"" data-filter-tags=""user interface buttons compass action dropdown navigation sidebars""> 
									<span class=""nav-link-text"">User Interface </span> 
									<strong class=""dl-ref bg-primary-500"">&nbsp;1.0&nbsp;</strong>
								</a>
								<ul style=""display:block;"">
									<li class=""active"">
										<a href=""#"" data-filter-tags=""user interface buttons""> 
											<span class=""nav-link-text"">
												Buttons
											</span>
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""user interface compass""> 
											<span class=""nav-link-text"">
												");
            WriteLiteral(@"Compass
											</span>
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""user interface action dropdown navigation sidebars""> 
											<span class=""nav-link-text"">
												Action
											</span> 
										<strong class=""dl-ref bg-primary-500"">&nbsp;1.3&nbsp;</strong>
										</a>
										<ul>
											<li>
												<a href=""#"" data-filter-tags=""user interface action dropdown""> 
													<span class=""nav-link-text"">
														Dropdown
													</span>
												</a>
											</li>
											<li>
												<a href=""#"" data-filter-tags=""user interface action navigation""> 
													<span class=""nav-link-text"">
														Navigation
													</span>
												</a>
											</li>
											<li>
												<a href=""#"" data-filter-tags=""user interface action sidebars""> 
													<span class=""nav-link-text"">
														Sidebars
													</span>
												</a>
											</li>
				");
            WriteLiteral(@"						</ul>
									</li>
								</ul>
							</li>
							<li>
								<a href=""#"" data-filter-tags=""graphs flot chart pie sythentic graphs polygraphs""> 
									<span class=""nav-link-text"">
										Graphs
									</span> 
									<strong class=""dl-ref bg-primary-500"">&nbsp;2.0&nbsp;</strong>
								</a>						
								<ul>
									<li>
										<a href=""#"" data-filter-tags=""graphs flot chart""> 
											<span class=""nav-link-text"">
												Flot chart
											</span> 
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""graphs pie chart""> 
											<span class=""nav-link-text"">
												Pie charts
											</span> 
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""graphs sythentic""> 
											<span class=""nav-link-text"">
												Sythentic graphs
											</span> 
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""graphs flot polygraphs""> 
							");
            WriteLiteral(@"				<span class=""nav-link-text"">
												Polygraphs
											</span> 
										</a>
									</li>
								</ul>
							</li>
							<li>
								<a href=""#"" data-filter-tags=""forms controls loaders other elements buttons input checkbox""> 
									<span class=""nav-link-text"">Forms </span> 
									<strong class=""dl-ref bg-primary-500"">&nbsp;3.0&nbsp;</strong>
								</a>
								<ul>
									<li>
										<a href=""#"" data-filter-tags=""forms controls""> 
											<span class=""nav-link-text""> Controls</span> 
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""forms loaders""> 
											<span class=""nav-link-text""> Loaders</span> 
										</a>
									</li>
									<li>
										<a href=""#"" data-filter-tags=""forms other elements buttons input checkbox""> 
											<span class=""nav-link-text"">
												Other elements
											</span> 
											<strong class=""dl-ref bg-primary-500"">&nbsp;3.3&nbsp;</strong>
										</a>
				");
            WriteLiteral(@"						<ul>
											<li>
												<a href=""#"" data-filter-tags=""forms other elements buttons""> 
													<span class=""nav-link-text"">
														Buttons
													</span>
												</a>
											</li>
											<li>
												<a href=""#"" data-filter-tags=""forms other elements input""> 
													<span class=""nav-link-text"">
														Input
													</span>
												</a>
											</li>
											<li data-filter-tags=""forms other elements checkbox"">
												<a href=""#""> 
													<span class=""nav-link-text"">
														Checkbox
													</span>
												</a>
											</li>
										</ul>
									</li>
								</ul>
							</li>
						</ul>
						<div class=""filter-message js-filter-message m-0 text-left pl-4 py-3 fw-500""></div>
					</div>
				</div>
			</div>
		</div>		
	</div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral(@"
<script>
	// default list filter
	initApp.listFilter($('#js_default_list'), $('#js_default_list_filter'));
	// custom response message
	initApp.listFilter($('#js-list-msg'), $('#js-list-msg-filter'));
	//accordion filter
	initApp.listFilter($('#js_list_accordion'), $('#js_list_accordion_filter'));
	// nested list filter
	initApp.listFilter($('#js_nested_list'), $('#js_nested_list_filter'));
	//init navigation 
	initApp.buildNavigation($('#js_nested_list'));
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
