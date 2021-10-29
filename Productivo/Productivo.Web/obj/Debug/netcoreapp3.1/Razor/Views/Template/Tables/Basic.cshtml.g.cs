#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Tables\Basic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49b962e5518c93dfab66004424bdd07ad37765c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Tables_Basic), @"mvc.1.0.view", @"/Views/Template/Tables/Basic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b962e5518c93dfab66004424bdd07ad37765c5", @"/Views/Template/Tables/Basic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Tables_Basic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Tables\Basic.cshtml"
   
	ViewData["Title"] = "Basic Tables";
	ViewData["PageName"] = "tables_basic";
	ViewData["Heading"] = "<i class='fal fa-th-list text-primary'></i>  Basic tables";
	ViewData["Category1"] = "Tables";
	ViewData["PageDescription"] = "Documentation and examples for opt-in styling of tables (given their prevelant use in JavaScript plugins) with Bootstrap.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral(@"<div class=""row"">
	<div class=""col-lg-12 col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Basic <span class=""fw-300""><i>Tables</i></span> 
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
						Using the most basic table markup, here’s how <code>.table</code>-based tables look in ");
#nullable restore
#line 25 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Tables\Basic.cshtml"
                                                                                                          Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@". You can inverse a table by using the class <code>.table-dark</code>
					</div>
					<h5 class=""frame-heading"">
						Default
					</h5>
					<div class=""frame-wrap"">
						<table class=""table m-0"">
							<thead>
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@twitter</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">4</th>\r\n\t\t\t\t\t\t\t\t\t<td colspan=\"2\">Larry the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
					<h5 class=""frame-heading"">
						Inverse
					</h5>
					<div class=""frame-wrap"">
						<table class=""table table-dark m-0"">
							<thead>
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>		
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Table <span class=""fw-300""><i>head</i></span> 
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
						Similar to default and inverse tables, use one of two modifier classes to make <code>&lt;thead&gt;</code>s appear custom, dark gray, white and themed.
					</div");
            WriteLiteral(@">
					<h5 class=""frame-heading"">
						Inverse
					</h5>
					<div class=""frame-wrap"">
						<table class=""table m-0"">
							<thead class=""thead-dark"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@twitter</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<h5 class=\"frame-heading\">\r\n\t\t\t\t\t\tCustom <a href=\"/utilities/colorpallet\" title=\"Color Pallets\"><i");
            BeginWriteAttribute("class", " class=\"", 4925, "\"", 4970, 2);
#nullable restore
#line 157 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Tables\Basic.cshtml"
WriteAttributeValue("", 4933, Settings.Theme.IconPrefix, 4933, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4961, "fa-reply", 4962, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i> </a>
					</h5>
					<div class=""frame-wrap"">
						<table class=""table m-0"">
							<thead class=""bg-fusion-50"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
					<h5 class=""frame-heading"">
						Dark
					</h5>
					<div class=""frame-wrap"">
						<table class=""table m-0"">
							<thead class=""thead-dark"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
					<h5 class=""frame-heading"">
						Themed
					</h5>
					<div class=""frame-wrap"">
						<table class=""table m-0"">
							<thead class=""thead-themed"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>		
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Table <span class=""fw-300""><i>rows</i></span> 
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
						Add <code>.table-striped</code> to add zebra-striping to any table, and add <code>.table-dark</code> for inverse pattern
					</div>
					<h5 class=""frame-headi");
            WriteLiteral(@"ng"">
						Pattern
					</h5>
					<div class=""frame-wrap"">
						<table class=""table table-striped m-0"">
							<thead>
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
					<h5 class=""frame-heading"">
						Pattern inverse
					</h5>
					<div class=""frame-wrap"">
						<table class=""table table-striped table-dark m-0"">
							<thead>
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>		
	</div>
	<div class=""col-lg-12 col-xl-6"">
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Table <span class=""fw-300""><i>Bordered</i></span> 
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
						Add <code>.table-bordered</code> for borders on all sides of the table and cells.
					</div>
					<table class=");
            WriteLiteral(@"""table table-bordered m-0"">
						<thead>
							<tr>
								<th>#</th>
								<th>First Name</th>
								<th>Last Name</th>
								<th>Username</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<th scope=""row"">1</th>
								<td>Mark</td>
								<td>Otto</td>
								<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t<td>Mark</td>\r\n\t\t\t\t\t\t\t\t<td>Otto</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@TwBootstrap</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">4</th>\r\n\t\t\t\t\t\t\t\t<td colspan=\"2\">Larry the Bird</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
							</tr>
						</tbody>
					</table>
				</div>
			</div>
		</div>		
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Table <span class=""fw-300""><i>Hover</i></span> 
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
						Add <code>.table-hover</code> to enable a hover state on table rows within a <code>&lt;tbody&gt;</code>
					</div>
					<h5 class=""frame-heading"">
						Hoverable
					</h5");
            WriteLiteral(@">
					<div class=""frame-wrap"">
						<table class=""table table-bordered table-hover m-0"">
							<thead class=""thead-themed"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Jhon</td>
									<td>Stone</td>
									<td>");
            WriteLiteral("@jhon</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Lisa</td>\r\n\t\t\t\t\t\t\t\t\t<td>Nilson</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@lisa</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
					<h5 class=""frame-heading"">
						Inverse
					</h5>
					<div class=""frame-wrap"">
						<table class=""table table-bordered table-hover table-dark m-0"">
							<thead class=""thead-themed"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Jhon</td>
									<td>Stone</td>
									<td>");
            WriteLiteral("@jhon</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Lisa</td>\r\n\t\t\t\t\t\t\t\t\t<td>Nilson</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@lisa</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td>Larry</td>\r\n\t\t\t\t\t\t\t\t\t<td>the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>		
		<div id=""panel-6"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Contextual <span class=""fw-300""><i>classes</i></span> 
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
						Use contextual classes to color table rows or individual cells. See the full list of <a href=""/utilities/colorpallet"" title=""Color Pallets"" target=""_blank");
            WriteLiteral(@""">color selection</a>
					</div>
					<table class=""table m-0"">
						<thead>
							<tr>
								<th>#</th>
								<th>First Name</th>
								<th>Last Name</th>
								<th>Username</th>
							</tr>
						</thead>
						<tbody>
							<tr class=""active"">
								<th scope=""row"">1</th>
								<td>Lisa</td>
								<td>Nilson</td>
								<td>");
            WriteLiteral("@lisa</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr class=\"bg-primary-400\">\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t<td>Lisa</td>\r\n\t\t\t\t\t\t\t\t<td>Nilson</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@lisa</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr class=\"bg-success-100\">\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t<td>Nick</td>\r\n\t\t\t\t\t\t\t\t<td>looper</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@king</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr class=\"bg-info-500\">\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">4</th>\r\n\t\t\t\t\t\t\t\t<td>Joan</td>\r\n\t\t\t\t\t\t\t\t<td>thestar</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@joan</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr class=\"bg-warning-500\">\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">5</th>\r\n\t\t\t\t\t\t\t\t<td>Sean</td>\r\n\t\t\t\t\t\t\t\t<td>coder</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@coder</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t<tr class=\"bg-danger-500\">\r\n\t\t\t\t\t\t\t\t<th scope=\"row\">6</th>\r\n\t\t\t\t\t\t\t\t<td>Sean</td>\r\n\t\t\t\t\t\t\t\t<td>coder</td>\r\n\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@coder</td>
							</tr>
						</tbody>
					</table>
				</div>
			</div>
		</div>		
		<div id=""panel-7"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Table <span class=""fw-300""><i>Small</i></span> 
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
						Add <code> .table-sm</code> to make tables more compact by cutting cell padding in half. See the full list of <a href=""/utilities/colorpallet"" title=""Color Pallets"">color selectio");
            WriteLiteral(@"n</a> to add backgrounds as well
					</div>
					<h5 class=""frame-heading"">
						Compact
					</h5>
					<div class=""frame-wrap"">
						<table class=""table table-sm m-0"">
							<thead class=""bg-primary-500"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td colspan=\"2\">Larry the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
					<h5 class=""frame-heading"">
						With background
					</h5>
					<div class=""frame-wrap"">
						<table class=""table table-sm bg-info-900 table-bordered m-0"">
							<thead class=""bg-info-500"">
								<tr>
									<th>#</th>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Username</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Mark</td>
									<td>Otto</td>
									<td>");
            WriteLiteral("@mdo</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">2</th>\r\n\t\t\t\t\t\t\t\t\t<td>Jacob</td>\r\n\t\t\t\t\t\t\t\t\t<td>Thornton</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral("@fat</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th scope=\"row\">3</th>\r\n\t\t\t\t\t\t\t\t\t<td colspan=\"2\">Larry the Bird</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
            WriteLiteral(@"@twitter</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>		
		<div id=""panel-8"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Table <span class=""fw-300""><i>Responsive</i></span> 
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
						Make table responsive with <code>.table-responsive</code>. Maximum breakpoint can be applied by adding <code>.table-responsive-sm</code>,  <code>.table-resp");
            WriteLiteral(@"onsive-ms</code>,  <code>.table-responsive-lg</code>,  <code>.table-responsive-xl</code>
					</div>
					<div class=""table-responsive-lg"">
						<table class=""table table-bordered m-0"">
							<thead>
								<tr>
									<th>#</th>
									<th>Table heading</th>
									<th>Table heading</th>
									<th>Table heading</th>
									<th>Table heading</th>
									<th>Table heading</th>
									<th>Table heading</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<th scope=""row"">1</th>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
								</tr>
								<tr>
									<th scope=""row"">2</th>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
								</tr>
								<tr>
									<th scope=""row"">3</th>
					");
            WriteLiteral(@"				<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
									<td>Table cell</td>
								</tr>
							</tbody>
						</table>
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
