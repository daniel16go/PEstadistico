#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\ButtonGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8712e9ea54d301ac7e711f3b110547d6f7fda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Ui_ButtonGroup), @"mvc.1.0.view", @"/Views/Template/Ui/ButtonGroup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8712e9ea54d301ac7e711f3b110547d6f7fda2", @"/Views/Template/Ui/ButtonGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Ui_ButtonGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\ButtonGroup.cshtml"
   
	ViewData["Title"] = "Button Group";
	ViewData["PageName"] = "ui_button_group";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-window'></i>  Button Group";
	ViewData["Category1"] = "UI Components";
	ViewData["PageDescription"] = "Group a series of buttons together on a single line with the button group, and super-power them with JavaScript.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eb8712e9ea54d301ac7e711f3b110547d6f7fda25376", async() => {
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
            WriteLiteral(@"<div class=""row"">
	<div class=""col-sm-12"">
		<div class=""alert alert-primary"">
			<div class=""d-table w-100"">
				<div class=""d-table-cell align-top width-6"">
					<span class=""icon-stack icon-stack-lg"">
						<i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i> 
						<i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i> 
						<i");
            BeginWriteAttribute("class", " class=\"", 863, "\"", 945, 5);
#nullable restore
#line 19 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Ui\ButtonGroup.cshtml"
WriteAttributeValue("", 871, Settings.Theme.IconPrefix, 871, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 899, "fa-info", 900, 8, true);
            WriteAttributeValue(" ", 907, "icon-stack-1x", 908, 14, true);
            WriteAttributeValue(" ", 921, "opacity-100", 922, 12, true);
            WriteAttributeValue(" ", 933, "color-white", 934, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
					</span>
				</div>
				<div class=""d-table-cell pl-1"">
					<span class=""h5"">Ensure correct <code>role</code> and provide a label</span>
					<p class=""mb-0"">The <code>.btn</code> styles can be applied to other elements, such as <code>&lt;label></code>s, to provide checkbox or radio style button toggling. Add <code>data-toggle=""buttons""</code> to a <code>.btn-group</code> containing those modified buttons to enable toggling in their respective styles. The checked state for these buttons is <strong>only updated via</strong> click <strong>event</strong> on the button. If you use another method to update the input—e.g., with <code>&lt;input type=""reset""></code> or by manually applying the input’s checked property—you’ll need to toggle <code>.active</code> on the <code>&lt;label></code> manually.</p>					
				</div>
			</div>
		</div>
    </div>
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Sizes <span class=""fw-300""><i>example</i></s");
            WriteLiteral(@"pan> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""demo demo-v-spacing-lg"">
						<div class=""btn-group btn-group-lg"">
							<button type=""button"" class=""btn btn-secondary"">Left</button>
							<button type=""button"" class=""btn btn-secondary"">Middle</button>
							<button type=""button"" class=""btn btn-secondary"">Right</button>
						</div>
						<br>
						<div class=""btn-group"">
							<button type=""button"" class=""btn btn-secondary"">Left</button>
			");
            WriteLiteral(@"				<button type=""button"" class=""btn btn-secondary"">Middle</button>
							<button type=""button"" class=""btn btn-secondary"">Right</button>
						</div>
						<br>
						<div class=""btn-group btn-group-sm"">
							<button type=""button"" class=""btn btn-secondary"">Left</button>
							<button type=""button"" class=""btn btn-secondary"">Middle</button>
							<button type=""button"" class=""btn btn-secondary"">Right</button>
						</div>
						<br>
						<div class=""btn-group btn-group-xs"">
							<button type=""button"" class=""btn btn-secondary"">Left</button>
							<button type=""button"" class=""btn btn-secondary"">Middle</button>
							<button type=""button"" class=""btn btn-secondary"">Right</button>
						</div>
					</div>
				</div>
			</div>
		</div>		
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Toolbar <span class=""fw-300""><i>example</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""to");
            WriteLiteral(@"oltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Fuse button groups into toolbars for a comprehensize component. Utility classes is needed to set margins to groups and buttons. 
					</div>
					<div></div>
					<div class=""d-flex justify-content-start flex-wrap demo"">
						<div class=""btn-group mr-2"" role=""group"" aria-label=""Group A"">
							<button type=""button"" class=""btn btn-secondary"">1</button>
							<button type=""button"" class=""btn btn-secondary"">2</button>
							<button type=""button"" class=""btn btn-secondary"">3</button>
							<button type=""button""");
            WriteLiteral(@" class=""btn btn-secondary"">4</button>
						</div>
						<div class=""btn-group mr-2"" role=""group"" aria-label=""Group B"">
							<button type=""button"" class=""btn btn-secondary"">5</button>
							<button type=""button"" class=""btn btn-secondary"">6</button>
							<button type=""button"" class=""btn btn-secondary"">7</button>
							<button type=""button"" class=""btn btn-secondary"">8</button>
						</div>
						<div class=""btn-group"" role=""group"" aria-label=""Group C"">
							<button type=""button"" class=""btn btn-secondary"">9</button>
							<button type=""button"" class=""btn btn-secondary"">10</button>
							<button type=""button"" class=""btn btn-danger"">11</button>
							<button type=""button"" class=""btn btn-secondary"">12</button>
						</div>
					</div>
				</div>
			</div>
		</div>		
		<div id=""panel-4"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Verticle <span class=""fw-300""><i>example</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action");
            WriteLiteral(@"=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Make a set of buttons appear vertically stacked rather than horizontally using class <code>.btn-group-vertical</code>. <strong>Split button dropdowns are not supported here.</strong>
					</div>
					<div class=""btn-group-vertical"" role=""group"" aria-label=""Vertical button group"">
						<button type=""button"" class=""btn btn-secondary"">Button</button>
						<button type=""button"" class=""btn btn-secondary"">Button</button>
						<div class=""btn-group"" role=""group"">
							<button id=""bt");
            WriteLiteral(@"nGroupVerticalDrop1"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
							Dropdown
							</button>
							<div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop1"">
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
							</div>
						</div>
						<button type=""button"" class=""btn btn-secondary"">Button</button>
						<button type=""button"" class=""btn btn-secondary"">Button</button>
						<div class=""btn-group"" role=""group"">
							<button id=""btnGroupVerticalDrop2"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
							Dropdown
							</button>
							<div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop2"">
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
							</div>
						</div>
			");
            WriteLiteral(@"			<div class=""btn-group"" role=""group"">
							<button id=""btnGroupVerticalDrop3"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
							Dropdown
							</button>
							<div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop3"">
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
							</div>
						</div>
						<div class=""btn-group"" role=""group"">
							<button id=""btnGroupVerticalDrop4"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
							Dropdown
							</button>
							<div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop4"">
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
								<a class=""dropdown-item"" href=""#"">Dropdown link</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>		
	</div>
	<div class=""col-xl-6"">	
");
            WriteLiteral(@"		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Nesting <span class=""fw-300""><i>example</i></span> 
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
						Place a <code>.btn-group</code> within another <code>.btn-group</code> when you want dropdown menus mixed with a series of buttons
					</div>
					<div class=""btn-group"" id=""js-demo-nesting"" role=""group"" aria-label=""Button group with nested dropdown"">
						<butto");
            WriteLiteral(@"n type=""button"" class=""btn btn-secondary"">1</button>
						<button type=""button"" class=""btn btn-secondary"">2</button>
						<div class=""btn-group"" role=""group"">
							<button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"">Dropdown</button>
							<div class=""dropdown-menu"">
								<a class=""dropdown-item"" href=""javascript:void(0)"">Dropdown link</a>
								<a class=""dropdown-item"" href=""javascript:void(0)"">Dropdown link</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>			
		<div id=""panel-5"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Input <span class=""fw-300""><i>checkbox & radio</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></butt");
            WriteLiteral(@"on>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						<code>.button</code> styles can be applied to other elements, such as <code>&lt;label&gt;</code>s, to provide checkbox or radio style button toggling. Add <code>data-toggle=""buttons""</code> to a <code>.btn-group</code> containing those modified buttons to enable their toggling behavior via JavaScript and add <code>.btn-group-toggle</code> to style the <code>&lt;input&gt;</code>s within your buttons. <strong>Note that you can create single input-powered buttons or groups of them.</strong>
					</div>
					<div class=""alert alert-info"">
						The checked state for these buttons is <strong>only updated via <code>click</code> event</strong> on the button. If you use another method to update the input—e.g., with <code>&lt;input ty");
            WriteLiteral(@"pe=""reset""&gt;</code> or by manually applying the input’s <code>checked</code> property—you’ll need to toggle <code>.active</code> on the <code>&lt;label&gt;</code> manually.
					</div>
					<h5 class=""frame-heading"">
						Checkbox
					</h5>
					<div class=""frame-wrap"">
						<div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
							<label class=""btn btn-primary active"">
								<input type=""checkbox"" name=""options"" id=""check1"" checked=""checked""> Checked
							</label>
							<label class=""btn btn-primary"">
								<input type=""checkbox"" name=""options"" id=""check2""> Unchecked
							</label>
							<label class=""btn btn-primary"">
								<input type=""checkbox"" name=""options"" id=""check3""> Unchecked
							</label>
						</div>
					</div>
					<h5 class=""frame-heading"">
						Radio
					</h5>
					<div class=""frame-wrap mb-0"">
						<div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
							<label class=""btn btn-info active"">
								<input type=""radio"" name=""");
            WriteLiteral(@"options"" id=""option1"" checked=""checked""> Active
							</label>
							<label class=""btn btn-info"">
								<input type=""radio"" name=""options"" id=""option2""> Radio
							</label>
							<label class=""btn btn-info"">
								<input type=""radio"" name=""options"" id=""option3""> Radio
							</label>
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
