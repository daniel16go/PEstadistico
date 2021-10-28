#pragma checksum "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Statistics\Easypiechart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71d643e020a86f8fc4c034f7aac733b8d1792515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Statistics_Easypiechart), @"mvc.1.0.view", @"/Views/Template/Statistics/Easypiechart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d643e020a86f8fc4c034f7aac733b8d1792515", @"/Views/Template/Statistics/Easypiechart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Statistics_Easypiechart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/demo/avatars/avatar-admin.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-image rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dr. Codex Lantern"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-image-md rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-image-sm rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/statistics/easypiechart/easypiechart.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Statistics\Easypiechart.cshtml"
   
	ViewData["Title"] = "Easy Pie Chart";
	ViewData["PageName"] = "statistics_easypiechart";
	ViewData["Category1"] = "Statistics";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-chart-pie'></i> Easy Pie Chart <sup class='badge badge-primary fw-500'>ADDON</sup>";
	ViewData["PageDescription"] = "Lightweight plugin to render simple, animated and retina optimized pie charts.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            DefineSection("SubheaderBlock", async() => {
                WriteLiteral(@"	
	<div class=""subheader-block d-none d-sm-flex align-items-center"">
		<div class=""d-inline-flex flex-column justify-content-center mr-3"">
			<span class=""fw-300 fs-xs d-block opacity-50"">
				<small>EXPENSES</small> 
			</span>
			<span class=""fw-500 fs-xl d-block color-info-500"">
				$47,000
			</span>
		</div>
		<span class=""js-easy-pie-chart color-primary-500 position-relative d-flex align-items-center justify-content-center"" data-percent=""45"" data-scalelength=""2"">
			<span class=""js-percent d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom""></span>
		</span>
	</div>
	<div class=""subheader-block d-none d-sm-flex align-items-center border-faded border-right-0 border-top-0 border-bottom-0 ml-3 pl-3"">
		<div class=""d-inline-flex flex-column justify-content-center mr-3"">
			<span class=""fw-300 fs-xs d-block opacity-50"">
				<small>MY PROFITS</small> 
			</span>
			<span class=""fw-500 fs-xl d-block color-danger-500"">
				$38,500
			</s");
                WriteLiteral(@"pan>
		</div>
		<span class=""js-easy-pie-chart color-danger-500 position-relative d-flex align-items-center justify-content-center"" data-percent=""86"" data-scalelength=""2"">
			<span class=""js-percent d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom""></span>
		</span>
	</div>
");
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
				<span class=""h5"">About</span>
				<p>Easy Pie Charts are highly customizable, very easy to implement, and resolution independent (retina optimized). It uses <code>requestAnimationFrame</code> for smooth animations on modern devices and works in all modern browsers. Since it is a SVG file output, it can be resized to any width and height.</p>
				<p class=""m-0"">
					Find in-depth, guidelines, tutorials and more on Easy Pie Chart's <a href=""https://github.com/rendro/easy-pie-chart"" target=""_blank"">GitHub Page</a> 
				</p>
");
            WriteLiteral(@"			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Color <span class=""fw-300""><i>Change</i></span> 
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
						Colors are inherited from the parent font color, so you could literally change the any of the font colors available within this WebApp <code>.js-easy-pie-chart.color-danger-500</code>
				");
            WriteLiteral(@"	</div>
					<div class=""demo"">
						<div class=""js-easy-pie-chart color-danger-500 d-inline-flex"" data-percent=""30"" data-piesize=""95"" data-scalelength=""3""></div>
						<div class=""js-easy-pie-chart color-success-500 d-inline-flex"" data-percent=""60"" data-piesize=""95"" data-scalelength=""3""></div>
						<div class=""js-easy-pie-chart color-primary-500 d-inline-flex"" data-percent=""90"" data-piesize=""95"" data-scalelength=""3""></div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Scale <span class=""fw-300""><i>& Color</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-togg");
            WriteLiteral(@"le=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Change the size of the chart using <code>data-piesize</code> and the line width by using <code>data-linewidth</code>
					</div>
					<div class=""demo"">
						<div class=""js-easy-pie-chart color-danger-500 d-inline-flex"" data-percent=""30"" data-piesize=""95"" data-linewidth=""40"" data-scalelength=""2""></div>
						<div class=""js-easy-pie-chart color-success-500 d-inline-flex"" data-percent=""60"" data-piesize=""80"" data-linewidth=""20"" data-scalelength=""2""></div>
						<div class=""js-easy-pie-chart color-primary-500 d-inline-flex"" data-percent=""75"" data-piesize=""50"" data-linewidth=""5"" data-scalelength=""2""></div>
						<div class=""js-easy-pie-chart color-info-500 d-inline-flex"" data-percent=""95"" data-piesize=""30"" data-linewidth=""3"" data-scalelength=""2""></div>
					</div>
				</div>
			</div>
		</div>
	");
            WriteLiteral(@"	<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Data <span class=""fw-300""><i>Percentage</i></span> 
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
						Data percentage is displayed by using various class utilities and a container with the class <code>.js-percent</code>
					</div>
					<div class=""demo"">
						<div class=""js-easy-pie-chart color-primary-300 position-relative d-inline-flex align-items-center justify");
            WriteLiteral(@"-content-center"" data-percent=""86"" data-piesize=""95"" data-linewidth=""5"" data-linecap=""round"" data-scalelength=""7"">
							<div class=""d-flex flex-column align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom fw-300 fs-xl"">
								<span class=""js-percent d-block text-dark""></span>
								<div class=""d-block fs-xs text-dark opacity-70"">
									<small>Memory</small>
								</div>
							</div>
						</div>
						<div class=""js-easy-pie-chart color-primary-400 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""46"" data-piesize=""80"" data-linewidth=""5"" data-linecap=""round"" data-scalelength=""5"">
							<div class=""d-flex flex-column align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom fw-300 fs-lg"">
								<span class=""js-percent d-block text-dark""></span>
								<div class=""d-block fs-xs text-dark opacity-70"">
									<small>CPU</small>
								</div>
							</div>
			");
            WriteLiteral(@"			</div>
						<div class=""js-easy-pie-chart color-primary-400 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""56"" data-piesize=""70"" data-linewidth=""5"" data-linecap=""round"" data-scalelength=""4"">
							<div class=""d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom fs-md"">
								<span class=""js-percent d-block""></span>
							</div>
						</div>
						<div class=""js-easy-pie-chart color-primary-600 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""36"" data-piesize=""60"" data-linewidth=""5"" data-linecap=""round"" data-scalelength=""3"">
							<span class=""js-percent d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom fw-300 fs-xs""></span>
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
					Avatar <spa");
            WriteLiteral(@"n class=""fw-300""><i>Usage</i></span> 
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
						Here we nested the image using various class utilities to center it within the graph. The graph is also using <code>data-scalelength</code> to change the scales to various sizes
					</div>
					<div class=""demo"">
						<div class=""js-easy-pie-chart color-danger-400 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""75""");
            WriteLiteral(" data-piesize=\"95\" data-linewidth=\"10\" data-scalelength=\"5\">\r\n\t\t\t\t\t\t\t<div class=\"d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71d643e020a86f8fc4c034f7aac733b8d179251517320", async() => {
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
            WriteLiteral(@"
							</div>
						</div>
						<div class=""js-easy-pie-chart color-success-500 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""86"" data-piesize=""80"" data-linewidth=""7"" data-scalelength=""4"">
							<div class=""d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71d643e020a86f8fc4c034f7aac733b8d179251518900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
						<div class=""js-easy-pie-chart color-info-500 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""65"" data-piesize=""50"" data-linewidth=""3"" data-scalelength=""1"" data-scalecolor=""#fff"">
							<div class=""d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71d643e020a86f8fc4c034f7aac733b8d179251520502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Nested <span class=""fw-300""><i>Charts</i></span> 
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
						Just as the example above, we can create nested charts by using the <code>position-absolute</code> utility
					</div>	
					<div class=""demo"">							
						<div class=""js-easy-pie-chart color-dange");
            WriteLiteral(@"r-400 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""35"" data-piesize=""95"" data-linewidth=""10"" data-scalelength=""5"">
							<div class=""js-easy-pie-chart color-info-500 position-relative position-absolute pos-left pos-right pos-top pos-bottom d-flex align-items-center justify-content-center"" data-percent=""65"" data-piesize=""60"" data-linewidth=""5"" data-scalelength=""1"" data-scalecolor=""#fff"">
								<div class=""js-easy-pie-chart color-success-500 position-relative position-absolute pos-left pos-right pos-top pos-bottom d-flex align-items-center justify-content-center"" data-percent=""35"" data-piesize=""40"" data-linewidth=""3"" data-scalelength=""1"" data-scalecolor=""#fff"">
									<span class=""js-percent d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom fw-300 fs-xs""></span>
								</div>
							</div>	
						</div>
						<div class=""js-easy-pie-chart color-primary-600 position-relative d-inline-flex align-items-c");
            WriteLiteral(@"enter justify-content-center"" data-percent=""35"" data-piesize=""95"" data-linewidth=""10"" data-scalelength=""5"">
							<div class=""js-easy-pie-chart color-primary-500 position-relative position-absolute pos-left pos-right pos-top pos-bottom d-flex align-items-center justify-content-center"" data-percent=""65"" data-piesize=""60"" data-linewidth=""5"" data-scalelength=""1"" data-scalecolor=""#fff"">
								<div class=""js-easy-pie-chart color-primary-400 position-relative position-absolute pos-left pos-right pos-top pos-bottom d-flex align-items-center justify-content-center"" data-percent=""35"" data-piesize=""40"" data-linewidth=""3"" data-scalelength=""1"" data-scalecolor=""#fff"">
									<span class=""js-percent d-flex align-items-center justify-content-center position-absolute pos-left pos-right pos-top pos-bottom fw-300 fs-xs text-primary""></span>
								</div>
							</div>	
						</div>
					</div>	
				</div>
			</div>
		</div>
		<div id=""panel-6"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Dynamic");
            WriteLiteral(@" <span class=""fw-300""><i>Usage</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div id=""update-chart"" class=""d-flex flex-column align-items-center"">
						<div class=""js-easy-pie-chart color-primary-900 position-relative d-flex align-items-center justify-content-center"" data-percent=""50"" data-piesize=""145"" data-linewidth=""20"" data-trackcolor=""#ccbfdf"" data-scalelength=""8"">
							<div class=""d-flex flex-column align-items-center justify-content-center position-");
            WriteLiteral(@"absolute pos-left pos-right pos-top pos-bottom fw-300 fs-xl"">
								<span class=""js-percent d-block text-dark""></span>
								<div class=""d-block fs-xs text-dark opacity-70"">
									<small>Random</small>
								</div>
							</div>
						</div>
						<button class=""js-update btn btn-outline-primary mt-3"">Update Chart</button>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71d643e020a86f8fc4c034f7aac733b8d179251526613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script>	
	$(document).ready(function () {
		/* update chart */
		var chart = window.chart = $('#update-chart .js-easy-pie-chart').data('easyPieChart');
		$('.js-update').on('click', function() {
			chart.update(Math.random()*200-100);
		});
	});
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
