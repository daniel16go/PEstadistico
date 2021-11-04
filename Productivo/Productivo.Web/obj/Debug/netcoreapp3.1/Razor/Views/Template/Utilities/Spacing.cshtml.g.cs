#pragma checksum "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\Spacing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63260c3ae1ee9856dc6461719236c3a84e1534f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Utilities_Spacing), @"mvc.1.0.view", @"/Views/Template/Utilities/Spacing.cshtml")]
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
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63260c3ae1ee9856dc6461719236c3a84e1534f", @"/Views/Template/Utilities/Spacing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Utilities_Spacing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\Spacing.cshtml"
   
	ViewData["Title"] = "Spacing";
	ViewData["PageName"] = "utilities_spacing";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-bolt'></i>  Spacing";
	ViewData["Category1"] = "Utilities";
	ViewData["PageDescription"] = "Bootstrap includes a wide range of shorthand responsive margin and padding utility classes to modify an element’s appearance.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d63260c3ae1ee9856dc6461719236c3a84e1534f5484", async() => {
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
				<i");
            BeginWriteAttribute("class", " class=\"", 800, "\"", 889, 5);
#nullable restore
#line 17 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\Spacing.cshtml"
WriteAttributeValue("", 808, Settings.Theme.IconPrefix, 808, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 836, "fa-shekel-sign", 837, 15, true);
            WriteAttributeValue(" ", 851, "icon-stack-1x", 852, 14, true);
            WriteAttributeValue(" ", 865, "opacity-100", 866, 12, true);
            WriteAttributeValue(" ", 877, "color-white", 878, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
			</span>
		</div>
		<div class=""d-flex flex-fill"">
			<div class=""flex-fill"">
				<span class=""h5"">How it works</span>
				<p>Assign responsive-friendly <code>margin</code> or <code>padding</code> values to an element or a subset of its sides with shorthand classes. Includes support for individual properties, all properties, and vertical and horizontal properties. Classes are built from a default Sass map ranging from <code>.25rem</code> to <code>3rem</code>.</p> 
				<p>
					We have further added quick margin and padding options for by using gutter space variable <code>.m-g</code>, margin bottom gutter <code>.mb-g</code>. Padding gutter can be adding by using <code>.p-g</code> modifier. The <code>*-g</code> will change based on the gutter variable.
				</p>
				Learn more about this component on bootstrap's
				<a");
            BeginWriteAttribute("href", " href=\"", 1736, "\"", 1805, 3);
            WriteAttributeValue("", 1743, "https://getbootstrap.com/docs/", 1743, 30, true);
#nullable restore
#line 28 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Utilities\Spacing.cshtml"
WriteAttributeValue("", 1773, ViewBag.Bs4v, 1773, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1786, "/utilities/spacing/", 1786, 19, true);
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">official documentation</a> also on this <a href=""https://codepen.io/nextgenadmin/pen/VRExxJ"" target=""_blank"">codepen example</a>
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Default <span class=""fw-300""><i>Panel</i></span> 
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
						<p>Spacing utilities that apply to all br");
            WriteLiteral(@"eakpoints, from <code>xs</code> to <code>xl</code>, have no breakpoint abbreviation in them. This is because those classes are applied from <code>min-width: 0</code> and up, and thus are not bound by a media query. The remaining breakpoints, however, do include a breakpoint abbreviation.</p>
						<p>The classes are named using the format <code>{property}{sides}-{size}</code> for <code>xs</code> and <code>{property}{sides}-{breakpoint}-{size}</code> for <code>sm</code>, <code>md</code>, <code>lg</code>, and <code>xl</code>.</p>
					</div>
					<p>Where <em>property</em> is one of:</p>
					<ul class=""list-spaced"">
					  <li><code>t</code> - for classes that set <code>margin-top</code> or <code>padding-top</code></li>
					  <li><code>b</code> - for classes that set <code>margin-bottom</code> or <code>padding-bottom</code></li>
					  <li><code>l</code> - for classes that set <code>margin-left</code> or <code>padding-left</code></li>
					  <li><code>r</code> - for classes that set <code>margin-right");
            WriteLiteral(@"</code> or <code>padding-right</code></li>
					  <li><code>x</code> - for classes that set both <code>*-left</code> and <code>*-right</code></li>
					  <li><code>y</code> - for classes that set both <code>*-top</code> and <code>*-bottom</code></li>
					  <li>blank - for classes that set a <code>margin</code> or <code>padding</code> on all 4 sides of the element</li>
					</ul>
					<p>Where <em>size</em> is one of:</p>
					<ul class=""list-spaced"">
					  <li><code>0</code> - for classes that eliminate the <code>margin</code> or <code>padding</code> by setting it to <code>0</code></li>
					  <li><code>1</code> - (by default) for classes that set the <code>margin</code> or <code>padding</code> to <code>$spacer * .25</code></li>
					  <li><code>2</code> - (by default) for classes that set the <code>margin</code> or <code>padding</code> to <code>$spacer * .5</code></li>
					  <li><code>3</code> - (by default) for classes that set the <code>margin</code> or <code>padding</code> to <code>$spacer</c");
            WriteLiteral(@"ode></li>
					  <li><code>4</code> - (by default) for classes that set the <code>margin</code> or <code>padding</code> to <code>$spacer * 1.5</code></li>
					  <li><code>5</code> - (by default) for classes that set the <code>margin</code> or <code>padding</code> to <code>$spacer * 2</code></li>
					  <li><code>6</code> - (by default) for classes that set the <code>margin</code> or <code>padding</code> to <code>$spacer * 2.5</code></li>
					  <li><code>auto</code> - for classes that set the <code>margin</code> to auto</li>
					</ul>
					<p>
						Example padding:
					</p>
					<div class=""demo"">
						<div class=""p-2 p-sm-3 p-md-4 p-lg-5 p-xl-6 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-2 .p-sm-3 .p-md-4 .p-lg-5 .p-xl-6</div>
						</div>
						<div class=""p-1 p-sm-2 p-md-3 p-lg-4 p-xl-5 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-1 .p-sm-2 .p-md-3 .p-lg-4 .p-xl-5</div>
						</div>
						<div class=""p-0 p-sm-1 p-md-2 p");
            WriteLiteral(@"-lg-3 p-xl-4 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-0 .p-sm-1 .p-md-2 .p-lg-3 .p-xl-4</div>
						</div>
						<div class=""p-3 p-sm-0 p-md-1 p-lg-2 p-xl-3 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-1 .p-sm-0 .p-md-1 .p-lg-2 .p-xl-3</div>
						</div>
						<div class=""p-4 p-sm-4 p-md-0 p-lg-1 p-xl-2 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-4 .p-sm-4 .p-md-0 .p-lg-1 .p-xl-2</div>
						</div>
						<div class=""p-5 p-sm-6 p-md-3 p-lg-0 p-xl-1 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-5 .p-sm-6 .p-md-3 .p-lg-0 .p-xl-1</div>
						</div>
						<div class=""p-6 p-sm-5 p-md-5 p-lg-6 p-xl-0 bg-danger-50 pattern-2"">
							<div class=""bg-success-600 pattern-1 pl-2"">.p-6 .p-sm-5 .p-md-5 .p-lg-6 .p-xl-0</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-2a"" class=""panel"">
			<div class=""panel-hdr");
            WriteLiteral(@""">	
				<h2 data-filter-tags=""child hover"">
					Horizontal <span class=""fw-300""><i>centering</i></span> 
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
						<p>Additionally, Bootstrap also includes an <code>.mx-auto</code> class for horizontally centering fixed-width block level content—that is, content that has <code>display: block</code> and a <code>width</code> set—by setting the horizontal margins to <code>auto</code>.</p>
					</div>
				");
            WriteLiteral(@"	<div class=""w-100 bg-danger-50 pattern-2 p-3"">
						<div class=""mx-auto p-2 bg-info-500 pattern-1 shadow"" style=""width:200px"">
							Centered element
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2 data-filter-tags=""child hover"">
					Negative <span class=""fw-300""><i>margin</i></span> 
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
						The syntax is nearly ");
            WriteLiteral(@"the same as the default, positive margin utilities, but with the addition of <code>n</code> before the requested size. 
					</div>
					<p>
						Here’s an example of customizing the Bootstrap grid at the medium (<code>md</code>) breakpoint and above. We’ve increased the <code>.col</code> padding with <code>.px-md-5</code> and then counteracted that with <code>.mx-md-n5</code> on the parent <code>.row</code>.
					</p>
					<div class=""row mx-md-n5"">
						<div class=""col px-md-5""><div class=""p-3 border bg-light"">Custom column padding</div></div>
						<div class=""col px-md-5""><div class=""p-3 border bg-light"">Custom column padding</div></div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
				<div class=""panel-hdr"">	
					<h2 data-filter-tags=""child hover"">
						Margin <span class=""fw-300""><i>examples</i></span> 
					</h2>
					<div class=""panel-toolbar"">
						<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10""");
            WriteLiteral(@" data-original-title=""Collapse""></button>
						<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
						<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
					</div>
				</div>
				<div class=""panel-container show"">
					<div class=""panel-content"">									
						<div class=""panel-tag"">
							Margin specific viewports example
							<div class=""row mt-1 text-dark"">
								<div class=""col-12 col-sm-6 col-md-6 col-lg-2 col-lg-2"">
									*-xs-* &lt;576px
								</div>
								<div class=""col-12 col-sm-6 col-md-6 col-lg-2 col-lg-2"">
									*-sm-* ≥576px
								</div>
								<div class=""col-12 col-sm-6 col-md-6 col-lg-2 col-lg-2"">
									*-md-* ≥768px
								</div>
								<div class=""col-12 col-sm-6 col-md-6 col-lg-2 col-lg-2"">
									*-lg-* ≥992px
								</div>
								<div class=""col-12 col-sm-6 co");
            WriteLiteral(@"l-md-6 col-lg-2 col-lg-2"">
									*-xl-* ≥1200px
								</div>
							</div>
						</div>
						<div class=""demo"">
							<div class=""row bg-danger-50 pattern-2"">
								<div class=""col bg-info text-white ml-1 ml-sm-2 ml-md-3 ml-lg-4 ml-xl-5 pattern-1"">
									.ml-1 .ml-sm-2 .ml-md-3 .ml-lg-4 .ml-xl-5
								</div>
							</div>
							<div class=""row bg-danger-50 pattern-2"">
								<div class=""col bg-info text-white mx-xs-1 mx-sm-2 mx-md-3 mx-lg-4 mx-xl-5 pattern-1"">
									.mx-1 .mx-sm-2 .mx-md-3 .mx-lg-4 .mx-xl-5
								</div>
							</div>
							<div class=""row bg-danger-50 pattern-2"">
								<div class=""col bg-info text-white my-1 my-sm-2 my-md-3 my-lg-4 my-xl-5 pattern-1"">
									.my-1 .my-sm-2 .my-md-3 .my-lg-4 .my-xl-5
								</div>
							</div>
							<div class=""row bg-danger-50 pattern-2"">
								<div class=""col bg-info text-white m-1 m-sm-2 m-md-3 m-lg-4 m-xl-5 pattern-1"">
									.m-1 .m-sm-2 .m-md-3 .m-lg-4 .m-xl-5
								</div>
							</div>
						<");
            WriteLiteral("/div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
