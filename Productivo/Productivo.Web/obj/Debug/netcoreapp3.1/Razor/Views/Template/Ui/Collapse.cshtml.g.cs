#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b1c28ea81e807507b9fcf4bee9776bf77da071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Ui_Collapse), @"mvc.1.0.view", @"/Views/Template/Ui/Collapse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b1c28ea81e807507b9fcf4bee9776bf77da071", @"/Views/Template/Ui/Collapse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Ui_Collapse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
   
	ViewData["Title"] = "Collapse";
	ViewData["PageName"] = "ui_collapse";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i>  Collapse";
	ViewData["Category1"] = "UI Components";
	ViewData["PageDescription"] = "Toggle the visibility of content across your project with a few classes.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "51b1c28ea81e807507b9fcf4bee9776bf77da0715418", async() => {
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
            WriteLiteral("<div class=\"alert alert-primary alert-dismissible\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">\r\n            <i");
            BeginWriteAttribute("class", " class=\"", 599, "\"", 644, 2);
#nullable restore
#line 14 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 607, Settings.Theme.IconPrefix, 607, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 635, "fa-times", 636, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
        </span>
    </button>
    <div class=""d-flex flex-start w-100"">
        <div class=""mr-2"">
            <span class=""icon-stack icon-stack-lg"">
                <i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i>
                <i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i>
                <i");
            BeginWriteAttribute("class", " class=\"", 1022, "\"", 1104, 5);
#nullable restore
#line 22 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 1030, Settings.Theme.IconPrefix, 1030, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1058, "fa-info", 1059, 8, true);
            WriteAttributeValue(" ", 1066, "icon-stack-1x", 1067, 14, true);
            WriteAttributeValue(" ", 1080, "opacity-100", 1081, 12, true);
            WriteAttributeValue(" ", 1092, "color-white", 1093, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
            </span>
        </div>
        <div class=""d-flex flex-fill"">
            <div class=""flex-fill"">
                <span class=""h5"">How it works</span>
                <br> The collapse JavaScript plugin is used to show and hide content. Buttons or anchors are used as triggers that are mapped to specific elements you toggle. Collapsing an element will animate the height from its current value to 0. Given how CSS handles animations, you cannot use padding on a .collapse element. Instead, use the class as an independent wrapping element. Find more facts and uses at the bootstrap <a");
            BeginWriteAttribute("href", " href=\"", 1714, "\"", 1785, 3);
            WriteAttributeValue("", 1721, "https://getbootstrap.com/docs/", 1721, 30, true);
#nullable restore
#line 28 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 1751, ViewBag.Bs4v, 1751, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1764, "/components/collapse/", 1764, 21, true);
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
						The most basic example of cards with enforced width
					</div>
					Click the buttons below to show and hide another element via");
            WriteLiteral(@" class changes:
					<ul class=""list-spaced mt-3"">
						<li><code>.collapse</code> hides content</li>
						<li><code>.collapsing</code> is applied during transitions</li>
						<li><code>.collapse.show</code> shows content</li>
					</ul>
					You can use a link with the href attribute, or a button with the <code>data-target</code> attribute. In both cases, the <code>data-toggle=""collapse""</code> is required.
					<div class=""frame-wrap mt-3 mb-0 w-100"">
						<p class=""demo"">
							<a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
							Link with href
							</a>
							<button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
							Button with data-target
							</button>
						</p>
						<div class=""collapse"" id=""collapseExample"">
							<div class=""card card-body"">
								Anim pariatur cliche re");
            WriteLiteral(@"prehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Multiple <span class=""fw-300""><i>Targets</i></span> 
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
						A <code>&lt;button&g");
            WriteLiteral(@"t;</code> or <code>&lt;a&gt;</code> can show and hide multiple elements by referencing them with a JQuery selector in its <code>href</code> or <code>data-target</code> attribute.
						Multiple <code>&lt;button&gt;</code> or <code>&lt;a&gt;</code> can show and hide an element if they each reference it with their <code>href</code> or <code>data-target</code> attribute
					</div>
					<div class=""frame-wrap mb-0 w-100"">
						<p class=""demo"">
							<a class=""btn btn-primary"" data-toggle=""collapse"" href=""#multiCollapseExample1"" role=""button"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Toggle first element</a>
							<button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample2"">Toggle second element</button>
							<button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target="".multi-collapse"" aria-expanded=""false"" aria-controls=""multiCollapseExample1 multiCollapseExa");
            WriteLiteral(@"mple2"">Toggle both elements</button>
						</p>
						<div class=""row"">
							<div class=""col"">
								<div class=""collapse multi-collapse"" id=""multiCollapseExample1"">
									<div class=""card card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
									</div>
								</div>
							</div>
							<div class=""col"">
								<div class=""collapse multi-collapse"" id=""multiCollapseExample2"">
									<div class=""card card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
									</div>
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
				<h");
            WriteLiteral(@"2>
					Accordion <span class=""fw-300""><i>example</i></span> 
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
						Add some navigation to a card’s header (or block) with built-in nav components. You can reveal or hide elements during <code>.collapse</code> state using the classes <code>.collapsed-reveal</code> and <code>.collapsed-hidden</code>
						<br><br>
						<strong>Make sure the <code>.collapsed-*</code> classes are inside the <code>data-");
            WriteLiteral(@"toggle=""collapse""</code> element or adjacent to it</strong>
					</div>
					<div class=""frame-wrap w-100"">
						<div class=""accordion"" id=""accordionExample"">
							<div class=""card"">
								<div class=""card-header"" id=""headingOne"">
									<a href=""javascript:void(0);"" class=""card-title"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
										Collapsible Group Item #1
										<span class=""ml-auto"">
											<span class=""collapsed-reveal"">
												<i");
            BeginWriteAttribute("class", " class=\"", 8460, "\"", 8524, 3);
#nullable restore
#line 147 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 8468, Settings.Theme.IconPrefix, 8468, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8496, "fa-minus-circle", 8497, 16, true);
            WriteAttributeValue(" ", 8512, "text-danger", 8513, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 8610, "\"", 8674, 3);
#nullable restore
#line 150 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 8618, Settings.Theme.IconPrefix, 8618, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8646, "fa-plus-circle", 8647, 15, true);
            WriteAttributeValue(" ", 8661, "text-success", 8662, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
									</div>
								</div>
							</div>
							<div class=""card"">
								<div class=""card-header"" id=""headingTwo"">
									<a href=""javascript:void(0);"" class=""card-title c");
            WriteLiteral("ollapsed\" data-toggle=\"collapse\" data-target=\"#collapseTwo\" aria-expanded=\"false\" aria-controls=\"collapseTwo\">\r\n\t\t\t\t\t\t\t\t\t\tCollapsible Group Item #2\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"ml-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-reveal\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 9940, "\"", 10004, 3);
#nullable restore
#line 167 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 9948, Settings.Theme.IconPrefix, 9948, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9976, "fa-minus-circle", 9977, 16, true);
            WriteAttributeValue(" ", 9992, "text-danger", 9993, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 10090, "\"", 10154, 3);
#nullable restore
#line 170 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 10098, Settings.Theme.IconPrefix, 10098, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10126, "fa-plus-circle", 10127, 15, true);
            WriteAttributeValue(" ", 10141, "text-success", 10142, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
									</div>
								</div>
							</div>
							<div class=""card"">
								<div class=""card-header"" id=""headingThree"">
									<a href=""javascript:void(0);"" class=""card-title coll");
            WriteLiteral("apsed\" data-toggle=\"collapse\" data-target=\"#collapseThree\" aria-expanded=\"false\" aria-controls=\"collapseThree\">\r\n\t\t\t\t\t\t\t\t\t\tCollapsible Group Item #3\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"ml-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-reveal\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 11421, "\"", 11485, 3);
#nullable restore
#line 187 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 11429, Settings.Theme.IconPrefix, 11429, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11457, "fa-minus-circle", 11458, 16, true);
            WriteAttributeValue(" ", 11473, "text-danger", 11474, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 11571, "\"", 11635, 3);
#nullable restore
#line 190 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 11579, Settings.Theme.IconPrefix, 11579, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11607, "fa-plus-circle", 11608, 15, true);
            WriteAttributeValue(" ", 11622, "text-success", 11623, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
									</div>
								</div>
							</div>
							<div class=""card"">
								<div class=""card-header"" id=""headingFour"">
									<a href=""javascript:void(0);"" class=""card-title c");
            WriteLiteral("ollapsed\" data-toggle=\"collapse\" data-target=\"#collapseFour\" aria-expanded=\"false\" aria-controls=\"collapseFour\">\r\n\t\t\t\t\t\t\t\t\t\tCollapsible Group Item #4\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"ml-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-reveal\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 12903, "\"", 12967, 3);
#nullable restore
#line 207 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 12911, Settings.Theme.IconPrefix, 12911, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 12939, "fa-minus-circle", 12940, 16, true);
            WriteAttributeValue(" ", 12955, "text-danger", 12956, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"collapsed-hidden\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 13053, "\"", 13117, 3);
#nullable restore
#line 210 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\Collapse.cshtml"
WriteAttributeValue("", 13061, Settings.Theme.IconPrefix, 13061, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 13089, "fa-plus-circle", 13090, 15, true);
            WriteAttributeValue(" ", 13104, "text-success", 13105, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
											</span>
										</span>
									</a>
								</div>
								<div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordionExample"">
									<div class=""card-body"">
										Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
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
