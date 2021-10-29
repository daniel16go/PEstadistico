#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\ResponsiveGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "577c91559702e8153163a6fa421e43c2caa99499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Utilities_ResponsiveGrid), @"mvc.1.0.view", @"/Views/Template/Utilities/ResponsiveGrid.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"577c91559702e8153163a6fa421e43c2caa99499", @"/Views/Template/Utilities/ResponsiveGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Utilities_ResponsiveGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\ResponsiveGrid.cshtml"
   
	ViewData["PageName"] = "utilities_responsive_grid";
	ViewData["Heading"] = "Responsive Grid";
	ViewData["Category1"] = "Utilities";
	ViewData["PageDescription"] = "Bootstrap includes a powerful mobile-first flexbox grid system for building layouts of all shapes and sizes.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral("<div class=\"alert alert-primary alert-dismissible\">\r\n\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">\r\n            <i");
            BeginWriteAttribute("class", " class=\"", 492, "\"", 537, 2);
#nullable restore
#line 11 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\ResponsiveGrid.cshtml"
WriteAttributeValue("", 500, Settings.Theme.IconPrefix, 500, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 528, "fa-times", 529, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
        </span>
    </button>
    <div class=""d-flex flex-start w-100"">
        <div class=""mr-2"">
            <span class=""icon-stack icon-stack-lg"">
                <i class=""base-4 icon-stack-3x color-primary-400""></i>
                <i class=""base-4 icon-stack-2x color-primary-600 opacity-70""></i>
                <i");
            BeginWriteAttribute("class", " class=\"", 874, "\"", 952, 5);
#nullable restore
#line 19 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\ResponsiveGrid.cshtml"
WriteAttributeValue("", 882, Settings.Theme.IconPrefix, 882, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 910, "fa-th", 911, 6, true);
            WriteAttributeValue(" ", 916, "icon-stack-1x", 917, 14, true);
            WriteAttributeValue(" ", 930, "text-white", 931, 11, true);
            WriteAttributeValue(" ", 941, "opacity-90", 942, 11, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
            </span>
        </div>
        <div class=""d-flex flex-fill"">
            <div class=""flex-fill"">
                <span class=""h5"">Improved Grid System</span>
                <br> The default bootstrap grid provides 5 variances, each variance serves a device width. 
            </div>
        </div>
    </div>
</div>	
<div class=""card mb-g bg-white"">
	<table class=""table table-bordered table-striped m-0"">
		<thead>
			<tr>
				<th class=""border-top-0""></th>
				<th>
					Extra small devices 
					<small class=""d-block fs-sm text-muted"">
						Phones (&lt;0px)
					</small>
				</th>
				<th> 
					Small devices 
					<small class=""d-block fs-sm text-muted"">
						Tablets (≥576px)
					</small>
				</th>
				<th>
					Medium devices 
					<small class=""d-block fs-sm text-muted"">
						Desktops (≥768px)
					</small>
				</th>
				<th>
					Large devices 
					<small class=""d-block fs-sm text-muted"">
						Desktops (≥992px)
					</small>
				</th>
				<t");
            WriteLiteral(@"h> 
					Extra Large devices 
					<small class=""d-block fs-sm text-muted"">
						Desktops (≥1200px)
					</small>
				</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<th>Grid behavior</th>
				<td>Horizontal at all times</td>
				<td colspan=""3"">Collapsed to start, horizontal above breakpoints</td>
			</tr>
			<tr>
				<th>Max container</th>
				<td>None (auto)</td>
				<td>576px</td>
				<td>768px</td>
				<td>992px</td>
				<td>1200px</td>
			</tr>
			<tr>
				<th>Class prefix</th>
				<td>
				<code>
					.col-xs-
				</code></td>
				<td>
				<code>
					.col-sm-
				</code></td>
				<td>
				<code>
					.col-md-
				</code></td>
				<td>
				<code>
					.col-lg-
				</code></td>
				<td>
				<code>
					.col-xl-
				</code></td>
			</tr>
			<tr>
				<th>Number of columns</th>
				<td colspan=""5"">12</td>
			</tr>
			<tr>
				<th>Max column width</th>
				<td class=""text-muted"">Auto</td>
				<td>60px</td>
				<td>78px</td>
				<td>95px</td>
				<td>95");
            WriteLiteral(@"px</td>
			</tr>
			<tr>
				<th>Gutter width</th>
				<td colspan=""5"">1.5rem (0.75rem on each side of a column)</td>
			</tr>
			<tr>
				<th>Nestable</th>
				<td colspan=""5"">Yes</td>
			</tr>
			<tr>
				<th>Offsets</th>
				<td class=""text-muted"">N/A</td>
				<td>Yes</td>
				<td colspan=""3"">Yes</td>
			</tr>
			<tr>
				<th>Column ordering</th>
				<td class=""text-muted"">N/A</td>
				<td>Yes</td>
				<td colspan=""3"">Yes</td>
			</tr>
		</tbody>
	</table>
</div>
<div class=""card p-g d-block"">
	<h2>
		How it works
		<small>
			Bootstrap’s grid system uses a series of containers, rows, and columns to layout and align content. It’s built with flexbox and is fully responsive. Below is an example and an in-depth look at how the grid comes together.
		</small>
	</h2>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
			  <div class=""row"">
			    <div class=""col-sm"">
			      One of three columns
			    </div>
			    <div cla");
            WriteLiteral(@"ss=""col-sm"">
			      One of three columns
			    </div>
			    <div class=""col-sm"">
			      One of three columns
			    </div>
			  </div>
			</div>
		</div>
	</div>
	<hr>
	<h3 class=""mt-3"">
		Auto-layout columns
		<small>
			Utilize breakpoint-specific column classes for equal-width columns. Add any number of unit-less classes for each breakpoint you need and every column will be the same width.
		</small>
	</h3>
	<h4>
		Equal-width
		<small>
			For example, here are two grid layouts that apply to every device and viewport, from <code>xs</code> to <code>xl</code>.
		</small>
	</h4>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
			  <div class=""row"">
			    <div class=""col"">
			      1 of 2
			    </div>
			    <div class=""col"">
			      1 of 2
			    </div>
			  </div>
			  <div class=""row"">
			    <div class=""col"">
			      1 of 3
			    </div>
			    <div class=""col"">
			      1 of 3
			    </div>
			    <div cl");
            WriteLiteral(@"ass=""col"">
			      1 of 3
			    </div>
			  </div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Setting one column width
		<small>
			Auto-layout for flexbox grid columns also means you can set the width of one column and the others will automatically resize around it. You may use predefined grid classes (as shown below), grid mixins, or inline widths. Note that the other columns will resize no matter the width of the center column.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
			  <div class=""row"">
			    <div class=""col"">
			      1 of 3
			    </div>
			    <div class=""col-6"">
			      2 of 3 (wider)
			    </div>
			    <div class=""col"">
			      3 of 3
			    </div>
			  </div>
			  <div class=""row"">
			    <div class=""col"">
			      1 of 3
			    </div>
			    <div class=""col-5"">
			      2 of 3 (wider)
			    </div>
			    <div class=""col"">
			      3 of 3
			    </div>
			  </div>
			</div>
		");
            WriteLiteral(@"</div>
	</div>
	<hr>
	<h3>
		Variable width content
		<small>
			Using the <code>col-{breakpoint}-auto</code> classes, columns can size itself based on the natural width of its content. This is super handy with single line content like inputs, numbers, etc. This, in conjunction with horizontal alignment classes, is very useful for centering layouts with uneven column sizes as viewport width changes.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
			  <div class=""row justify-content-md-center"">
			    <div class=""col col-lg-2"">
			      1 of 3
			    </div>
			    <div class=""col-12 col-md-auto"">
			      Variable width content
			    </div>
			    <div class=""col col-lg-2"">
			      3 of 3
			    </div>
			  </div>
			  <div class=""row"">
			    <div class=""col"">
			      1 of 3
			    </div>
			    <div class=""col-12 col-md-auto"">
			      Variable width content
			    </div>
			    <div class=""col col-lg-2"">
");
            WriteLiteral(@"			      3 of 3
			    </div>
			  </div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Equal-width multi-row
		<small>
			Create equal-width columns that span multiple rows by inserting a <code>.w-100</code> where you want the columns to break to a new line. Make the breaks responsive by mixing the <code>.w-100</code> with some responsive display utilities.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
				<div class=""row"">
				  <div class=""col"">col</div>
				  <div class=""col"">col</div>
				  <div class=""w-100""></div>
				  <div class=""col"">col</div>
				  <div class=""col"">col</div>
				</div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Responsive classes
		<small>
			Bootstrap’s grid includes five tiers of predefined classes for building complex responsive layouts. Customize the size of your columns on extra small, small, medium, large, or extra large devices however you see fit.
		</small>
	</h3>
	<h4>
		All ");
            WriteLiteral(@"breakpoints
		<small>
			For grids that are the same from the smallest of devices to the largest, use the <code>.col</code> and <code>.col-*</code> classes. Specify a numbered class when you need a particularly sized column; otherwise, feel free to stick to <code>.col</code>.
		</small>
	</h4>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
				<div class=""row"">
				  <div class=""col"">col</div>
				  <div class=""col"">col</div>
				  <div class=""col"">col</div>
				  <div class=""col"">col</div>
				</div>
				<div class=""row"">
				  <div class=""col-8"">col-8</div>
				  <div class=""col-4"">col-4</div>
				</div>
			</div>	
		</div>
	</div>
	<hr>
	<h3>
		Stacked to horizontal
		<small>
			Using a single set of <code>.col-sm-*</code> classes, you can create a basic grid system that starts out stacked on extra small devices before becoming horizontal on desktop (medium) devices.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd");
            WriteLiteral(@"-example-row"">
			<div class=""container container-demo""> 
				<div class=""row"">
				  <div class=""col-sm-8"">col-sm-8</div>
				  <div class=""col-sm-4"">col-sm-4</div>
				</div>
				<div class=""row"">
				  <div class=""col-sm"">col-sm</div>
				  <div class=""col-sm"">col-sm</div>
				  <div class=""col-sm"">col-sm</div>
				</div>	
			</div>	
		</div>
	</div>
	<hr>
	<h3>
		Mix and match
		<small>
			Don’t want your columns to simply stack in some grid tiers? Use a combination of different classes for each tier as needed. See the example below for a better idea of how it all works.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo""> 
				<div class=""row"">
				  <div class=""col col-md-8"">.col .col-md-8</div>
				  <div class=""col-6 col-md-4"">.col-6 .col-md-4</div>
				</div>
				<div class=""row"">
				  <div class=""col-6 col-md-4"">.col-6 .col-md-4</div>
				  <div class=""col-6 col-md-4"">.col-6 .col-md-4</div>
				  <div cla");
            WriteLiteral(@"ss=""col-6 col-md-4"">.col-6 .col-md-4</div>
				</div>
				<div class=""row"">
				  <div class=""col-6"">.col-6</div>
				  <div class=""col-6"">.col-6</div>
				</div>
			</div>	
		</div>
	</div>
	<hr>
	<h3>
		Alignment
		<small>
			Use flexbox alignment utilities to vertically and horizontally align columns.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row bd-example-row-flex-cols"">
			<div class=""container container-demo""> 
				  <div class=""row align-items-start"">
				    <div class=""col"">
				      One of three columns
				    </div>
				    <div class=""col"">
				      One of three columns
				    </div>
				    <div class=""col"">
				      One of three columns
				    </div>
				  </div>
				  <div class=""row align-items-center"">
				    <div class=""col"">
				      One of three columns
				    </div>
				    <div class=""col"">
				      One of three columns
				    </div>
				    <div class=""col"">
				      One of three columns
				    </div>
				 ");
            WriteLiteral(@" </div>
				  <div class=""row align-items-end"">
				    <div class=""col"">
				      One of three columns
				    </div>
				    <div class=""col"">
				      One of three columns
				    </div>
				    <div class=""col"">
				      One of three columns
				    </div>
				  </div>
			</div>	
		</div>
	</div>
	<hr>
	<h3>
		Horizontal alignment
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""container container-demo"">
			  <div class=""row justify-content-start"">
			    <div class=""col-4"">
			      One of two columns
			    </div>
			    <div class=""col-4"">
			      One of two columns
			    </div>
			  </div>
			  <div class=""row justify-content-center"">
			    <div class=""col-4"">
			      One of two columns
			    </div>
			    <div class=""col-4"">
			      One of two columns
			    </div>
			  </div>
			  <div class=""row justify-content-end"">
			    <div class=""col-4"">
			      One of two columns
			    </div>
			    <div class=""col-4"">
			  ");
            WriteLiteral(@"    One of two columns
			    </div>
			  </div>
			  <div class=""row justify-content-around"">
			    <div class=""col-4"">
			      One of two columns
			    </div>
			    <div class=""col-4"">
			      One of two columns
			    </div>
			  </div>
			  <div class=""row justify-content-between"">
			    <div class=""col-4"">
			      One of two columns
			    </div>
			    <div class=""col-4"">
			      One of two columns
			    </div>
			  </div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		No gutters
		<small>
			The gutters between columns in the predefined grid classes can be removed with <code>.no-gutters</code>. This removes the negative margins from <code>.row</code> and the horizontal padding from all immediate children columns.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">
			<div class=""row no-gutters"">
			  <div class=""col-12 col-sm-6 col-md-8"">.col-12 .col-sm-6 .col-md-8</div>
			  <div class=""col-6 col-md-4"">.col-6 .col-md-4</div>
			</div>
		</di");
            WriteLiteral(@"v>
	</div>
	<hr>
	<h3>
		Column wrapping
		<small>
			If more than 12 columns are placed within a single row, each group of extra columns will, as one unit, wrap onto a new line.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">	
			<div class=""container container-demo"">
				<div class=""row"">
				  <div class=""col-9"">.col-9</div>
				  <div class=""col-4"">.col-4<br>Since 9 + 4 = 13 &gt; 12, this 4-column-wide div gets wrapped onto a new line as one contiguous unit.</div>
				  <div class=""col-6"">.col-6<br>Subsequent columns continue along the new line.</div>
				</div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Column resets
		<small>
			With the handful of grid tiers available, you’re bound to run into issues where, at certain breakpoints, your columns don’t clear quite right as one is taller than the other. To fix that, use a combination of a <code>.clearfix</code> and responsive utility classes.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-e");
            WriteLiteral(@"xample-row"">	
			<div class=""container container-demo"">
				<div class=""row"">
				  <div class=""col-6 col-sm-3"">.col-6 .col-sm-3</div>
				  <div class=""col-6 col-sm-3"">.col-6 .col-sm-3</div>
				  <div class=""clearfix hidden-sm-up""></div>
				  <div class=""col-6 col-sm-3"">.col-6 .col-sm-3</div>
				  <div class=""col-6 col-sm-3"">.col-6 .col-sm-3</div>
				</div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Reordering with Flex order
		<small>
			Use flexbox utilities for controlling the visual order of your content.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">	
			<div class=""container container-demo"">
			  <div class=""row"">
			    <div class=""col flex-unordered"">
			      First, but unordered
			    </div>
			    <div class=""col flex-last"">
			      Second, but last
			    </div>
			    <div class=""col flex-first"">
			      Third, but first
			    </div>
			  </div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Offsetting columns
		<small>
			Move ");
            WriteLiteral(@"columns to the right using <code>.offset-md-*</code> classes. These classes increase the left margin of a column by <code>*</code> columns. For example, <code>.offset-md-4</code> moves <code>.col-md-4</code> over four columns.
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">	
			<div class=""container container-demo"">
				<div class=""row"">
					<div class=""col-md-4"">.col-md-4</div>
					<div class=""col-md-4 ml-auto"">.col-md-4 .ml-auto</div>
				</div>
				<div class=""row"">
					<div class=""col-md-3 ml-md-auto"">.col-md-3 .ml-md-auto</div>
					<div class=""col-md-3 ml-md-auto"">.col-md-3 .ml-md-auto</div>
				</div>
				<div class=""row"">
					<div class=""col-auto mr-auto"">.col-auto .mr-auto</div>
					<div class=""col-auto"">.col-auto</div>
				</div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Push and pull
		<small>
			Easily change the order of our built-in grid columns with <code>.push-md-*</code> and <code>.pull-md-*</code> modifier classes.
		</small>
	</h3>
");
            WriteLiteral(@"	<div class=""bd-example"">
		<div class=""bd-example-row"">	
			<div class=""container container-demo"">
				<div class=""row"">
				  <div class=""col-md-9 push-md-3"">.col-md-9 .push-md-3</div>
				  <div class=""col-md-3 pull-md-9"">.col-md-3 .pull-md-9</div>
				</div>
			</div>
		</div>
	</div>
	<hr>
	<h3>
		Nesting
		<small>
			To nest your content with the default grid, add a new <code>.row</code> and set of <code>.col-sm-*</code> columns within an existing <code>.col-sm-*</code> column. Nested rows should include a set of columns that add up to 12 or fewer (it is not required that you use all 12 available columns).
		</small>
	</h3>
	<div class=""bd-example"">
		<div class=""bd-example-row"">	
			<div class=""container container-demo"">
				<div class=""row"">
				  <div class=""col-sm-9"">
				    Level 1: .col-sm-9
				    <div class=""row"">
				      <div class=""col-8 col-sm-6"">
				        Level 2: .col-8 .col-sm-6
				      </div>
				      <div class=""col-4 col-sm-6"">
				        Level 2: ");
            WriteLiteral(".col-4 .col-sm-6\r\n\t\t\t\t      </div>\r\n\t\t\t\t    </div>\r\n\t\t\t\t  </div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n}\r\n");
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
