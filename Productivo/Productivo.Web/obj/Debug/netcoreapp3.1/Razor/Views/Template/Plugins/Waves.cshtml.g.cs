#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Plugins\Waves.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e2902e43af4bf8b0db920a94ec389acebd1645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Plugins_Waves), @"mvc.1.0.view", @"/Views/Template/Plugins/Waves.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e2902e43af4bf8b0db920a94ec389acebd1645", @"/Views/Template/Plugins/Waves.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Plugins_Waves : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Plugins\Waves.cshtml"
   
	ViewData["Title"] = "waves";
	ViewData["PageName"] = "plugins_waves";
	ViewData["Category1"] = "Core Plugins";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-shield-alt'></i> Waves <sup class='badge badge-success fw-500'>EXTENSION</sup>";
	ViewData["PageDescription"] = "waves description";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33e2902e43af4bf8b0db920a94ec389acebd16455317", async() => {
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
                <i class=""ni ni-blog-read icon-stack-1x opacity-100 color-white""></i>
            </span>
        </div>
        <div class=""d-flex flex-fill"">
            <div class=""flex-fill"">
                <span class=""h5"">About</span>
                <p>Waves is an external library that we've included in ");
#nullable restore
#line 23 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Template\Plugins\Waves.cshtml"
                                                                  Write(Settings.App);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" to allow us to create the ink effect you notice on Google's Material Design concept. To put the waves effect on an element, you just add the class <code>.js-waves-on</code>. Waves are automatically attached to all <code>.btn</code> classes and nav elements, if you like to turn this feature off for any reason you can add <code>.js-waves-off</code> </p>    
                <p class=""m-0"">
                    Find in-depth, guidelines, tutorials and more on Waves's <a href=""http://fian.my.id/Waves/#start"" target=""_blank"">Official Documentation</a> 
                </p>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-xl-6"">
        <div id=""panel-1"" class=""panel"">
            <div class=""panel-hdr""> 
                <h2>
                    Waves <span class=""fw-300""><i>turned on manually</i></span> 
                </h2>
                <div class=""panel-toolbar"">
                    <button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggl");
            WriteLiteral(@"e=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
                </div>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">                                 
                    <div class=""panel-tag"">
                        Below we use <code>.js-waves-on</code> class to add the waves effect to div element. You can do this for any element with a CSS style <code>.d-block</code> or <code>.d-flex</code>.
                    </div>
                    <h5 class=""frame-heading"">Waves are on by default</h5>
                    <div class=""frame-wrap"">
                        <div class=""row no-gutters row-grid"">
                            <div class=""col-6"">
                                <div class=""w-100 js-waves-on bg-primary-500 cursor-auto"" style=""height:12rem"">
                                </div>
                            </div>
                            <div class=""col-6"">
                            ");
            WriteLiteral(@"    <div class=""w-100 js-waves-on bg-fusion-500 cursor-auto"" style=""height:12rem"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-6"">
        <div id=""panel-2"" class=""panel"">
            <div class=""panel-hdr""> 
                <h2>
                    Waves <span class=""fw-300""><i>disable and auto attach</i></span> 
                </h2>
                <div class=""panel-toolbar"">
                    <button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
                </div>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">                                 
                    <div class=""panel-tag"">
                        The waves function is automatically attach");
            WriteLiteral(@"ed to all .btn classes and nav elements. You can disable this by adding <code>.js-waves-off</code>
                    </div>
                    <h5 class=""frame-heading"">Waves are on by default</h5>
                    <div class=""frame-wrap"">
                        <div class=""demo"">
                            <button type=""button"" class=""btn btn-primary btn-lg"">Primary</button>
                            <button type=""button"" class=""btn btn-secondary btn-lg"">Secondary</button>
                            <button type=""button"" class=""btn btn-outline-primary btn-lg"">Primary Outline</button>
                            <button type=""button"" class=""btn btn-outline-secondary btn-lg"">Secondary Outline</button>
                        </div>
                    </div>
                    <h5 class=""frame-heading"">Waves are off using a class</h5>
                    <div class=""frame-wrap"">
                        <button type=""button"" class=""btn btn-primary btn-lg js-waves-off"">Waves disabled</bu");
            WriteLiteral(@"tton>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-12"">
        <div id=""panel-3"" class=""panel"">
            <div class=""panel-hdr""> 
                <h2>
                    Waves <span class=""fw-300""><i>Config</i></span> 
                </h2>
                <div class=""panel-toolbar"">
                    <button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
                </div>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">                                 
                    <h5 class=""frame-heading"">Turn off via global config through app.config.js</h5>
                    <div class=""frame-wrap"">
                        <pre class=""prettyprint"">
rippleEffect: true, // material design effect that appears on all buttons</pre>
                    </div>
     ");
            WriteLiteral(@"                <h5 class=""frame-heading"">Script that turns on the plugin in app.core.js</h5>
                     <div class=""frame-wrap"">
                        <pre class=""prettyprint"">
if (window.Waves && myapp_config.rippleEffect) {
    Waves.attach('.nav-menu:not(.js-waves-off) a, .btn:not(.js-waves-off):not(.btn-switch), .js-waves-on', ['waves-themed']);
    Waves.init();
    ... 
} </pre>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n<script src=\"https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js\"></script>\r\n");
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
