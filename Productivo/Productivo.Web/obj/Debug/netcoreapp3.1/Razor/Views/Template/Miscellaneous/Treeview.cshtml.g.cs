#pragma checksum "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Miscellaneous\Treeview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a27df1596c1aa0a0242c66e7a65935c52e7ff919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Miscellaneous_Treeview), @"mvc.1.0.view", @"/Views/Template/Miscellaneous/Treeview.cshtml")]
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
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27df1596c1aa0a0242c66e7a65935c52e7ff919", @"/Views/Template/Miscellaneous/Treeview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Miscellaneous_Treeview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/miscellaneous/treeview/treeview.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/miscellaneous/treeview/treeview.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Miscellaneous\Treeview.cshtml"
   
	ViewData["Title"] = "Tree View";
	ViewData["PageName"] = "miscellaneous_treeview";
	ViewData["Category1"] = "Miscellaneous";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-globe'></i> Treeview<sup class='badge badge-primary fw-500'>ADDON</sup>";
	ViewData["PageDescription"] = "Tree view.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a27df1596c1aa0a0242c66e7a65935c52e7ff9195925", async() => {
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
            DefineSection("SubheaderBlock", async() => {
                WriteLiteral("\r\n\t<div class=\"subheader-block\">\r\n\t\tRight content of header\r\n\t</div>\r\n");
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
				<p>Points.</p>
				<p class=""m-0"">
					Find in-depth, guidelines, tutorials and more on Addon's <a href=""#"" target=""_blank"">Official Documentation</a> 
				</p>
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-lg-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Panel <span class=""fw-300""><i>Title</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""");
            WriteLiteral(@"tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">									
					<div class=""panel-tag"">
						Panel tag <code>code</code>
					</div>
					<div class=""tree"">
						<ul>
							<li>
								<span><i class=""fa fa-lg fa-calendar""></i> 2013, Week 2</span>
								<ul>
									<li>
										<span class=""label label-success""><i class=""fa fa-lg fa-plus-circle""></i> Monday, January 7: 8.00 hours</span>
										<ul>
											<li>
												<span><i class=""fa fa-clock-o""></i> 8.00</span> &ndash; <a href=""javascript:void(0);"">Changed CSS to accomodate...</a>
											</li>
										</ul>
							");
            WriteLiteral(@"		</li>
									<li>
										<span class=""label label-success""><i class=""fa fa-lg fa-minus-circle""></i> Tuesday, January 8: 8.00 hours</span>
										<ul>
											<li>
												<span><i class=""fa fa-clock-o""></i> 6.00</span> &ndash; <a href=""javascript:void(0);"">Altered code...</a>
											</li>
											<li>
												<span><i class=""fa fa-clock-o""></i> 2.00</span> &ndash; <a href=""javascript:void(0);"">Simplified our approach to...</a>
											</li>
										</ul>
									</li>
									<li>
										<span class=""label label-warning""><i class=""fa fa-lg fa-minus-circle""></i> Wednesday, January 9: 6.00 hours</span>
										<ul>
											<li>
												<span><i class=""fa fa-clock-o""></i> 3.00</span> &ndash; <a href=""javascript:void(0);"">Fixed bug caused by...</a>
											</li>
											<li>
												<span><i class=""fa fa-clock-o""></i> 3.00</span> &ndash; <a href=""javascript:void(0);"">Comitting latest code to Git...</a>
											</li>
										</ul>
");
            WriteLiteral(@"									</li>
									<li>
										<span class=""label label-danger""><i class=""fa fa-lg fa-minus-circle""></i> Wednesday, January 9: 4.00 hours</span>
										<ul>
											<li>
												<span><i class=""fa fa-clock-o""></i> 2.00</span> &ndash; <a href=""javascript:void(0);"">Create component that...</a>
											</li>
										</ul>
									</li>
								</ul>
							</li>
							<li>
								<span><i class=""fa fa-lg fa-calendar""></i> 2013, Week 3</span>
								<ul>
									<li>
										<span class=""label label-success""><i class=""fa fa-lg fa-minus-circle""></i> Monday, January 14: 8.00 hours</span>
										<ul>
											<li>
												<span><i class=""fa fa-clock-o""></i> 7.75</span> &ndash; <a href=""javascript:void(0);"">Writing documentation...</a>
											</li>
											<li>
												<span><i class=""fa fa-clock-o""></i> 0.25</span> &ndash; <a href=""javascript:void(0);"">Reverting code back to...</a>
											</li>
										</ul>
									</li>
								</ul>");
            WriteLiteral(@"
							</li>
						</ul>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-lg-6"">
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Panel <span class=""fw-300""><i>Title</i></span> 
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
						Panel tag <code>code</code>
					</div>
					<div class=""tree"">
							<ul>
								<li>
									<span><i class=""fa fa-lg fa-folder-open""></i> Parent</span>");
            WriteLiteral(@"
									<ul>
										<li>
											<span><i class=""fa fa-lg fa-plus-circle""></i> Administrators</span>
											<ul>
												<li style=""display:none"">
													<span> <label class=""checkbox inline-block"">
															<input type=""checkbox"" name=""checkbox-inline"">
															<i></i>Michael.Jackson</label> </span>
												</li>
												<li style=""display:none"">
													<span> <label class=""checkbox inline-block"">
															<input type=""checkbox"" checked=""checked"" name=""checkbox-inline"">
															<i></i>Sunny.Ahmed</label> </span>
												</li>
												<li style=""display:none"">
													<span> <label class=""checkbox inline-block"">
															<input type=""checkbox"" checked=""checked"" name=""checkbox-inline"">
															<i></i>Jackie.Chan</label> </span>
												</li>
											</ul>
										</li>
										<li>
											<span><i class=""fa fa-lg fa-minus-circle""></i> Child</span>
											<ul>
												<li>
				");
            WriteLiteral(@"									<span><i class=""icon-leaf""></i> Grand Child</span>
												</li>
												<li>
													<span><i class=""icon-leaf""></i> Grand Child</span>
												</li>
												<li>
													<span><i class=""fa fa-lg fa-plus-circle""></i> Grand Child</span>
													<ul>
														<li style=""display:none"">
															<span><i class=""fa fa-lg fa-plus-circle""></i> Great Grand Child</span>
															<ul>
																<li style=""display:none"">
																	<span><i class=""icon-leaf""></i> Great great Grand Child</span>
																</li>
																<li style=""display:none"">
																	<span><i class=""icon-leaf""></i> Great great Grand Child</span>
																</li>
															</ul>
														</li>
														<li style=""display:none"">
															<span><i class=""icon-leaf""></i> Great Grand Child</span>
														</li>
														<li style=""display:none"">
															<span><i class=""icon-leaf""></i> Great Grand Child");
            WriteLiteral(@"</span>
														</li>
													</ul>
												</li>
											</ul>
										</li>
									</ul>
								</li>
								<li>
									<span><i class=""fa fa-lg fa-folder-open""></i> Parent2</span>
									<ul>
										<li>
											<span><i class=""icon-leaf""></i> Child</span>
										</li>
									</ul>
								</li>
							</ul>
						</div>
				</div>
			</div>
		</div>
	</div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a27df1596c1aa0a0242c66e7a65935c52e7ff91915629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<script>\r\n\t\tdocument.addEventListener(\"DOMContentLoaded\", function(){\r\n\t\t  // Handler when the DOM is fully loaded\r\n\t\t});\r\n\t</script>\r\n");
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
