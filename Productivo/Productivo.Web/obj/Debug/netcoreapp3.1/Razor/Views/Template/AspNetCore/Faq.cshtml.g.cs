#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\AspNetCore\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e19390eea68e423ddf9c95f42b5ac9de388e6421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_AspNetCore_Faq), @"mvc.1.0.view", @"/Views/Template/AspNetCore/Faq.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e19390eea68e423ddf9c95f42b5ac9de388e6421", @"/Views/Template/AspNetCore/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_AspNetCore_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AspNetCore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\AspNetCore\Faq.cshtml"
  
    ViewData["Title"] = "FAQ";
    ViewData["PageName"] = "aspnetcore_faq";
    ViewData["Heading"] = "<i class='fal fa-folder-open'></i> FAQ: <span class='fw-300'>Common issues</span>";
    ViewData["Category1"] = "Solution Overview";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xl-12\">\r\n        <div class=\"panel\">\r\n            <div class=\"panel-hdr\">\r\n                <h2>\r\n                    Frequently Asked Questions for ");
#nullable restore
#line 13 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\AspNetCore\Faq.cshtml"
                                              Write(Settings.AppFlavor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-container show"">
                    <div class=""panel-content"">
                        <div class=""accordion accordion-hover"" id=""js_demo_accordion-5"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <a href=""javascript:void(0);"" class=""card-title pb-2 pt-2 bg-white text-primary fs-lg border-bottom border-dashed border-faded"">
                                        <i class=""fal fa-cog width-2 fs-xl""></i>
                                        Installation: I am getting a message stating that <code class=""bg-transparent mx-1"">dotnet</code> is not a valid command?
                                    </a>
                                </div>
                                <div class=""collapse show"">
                                    <div class=""card-body"">
                  ");
            WriteLiteral(@"                      This happens when <code>cmd.exe</code> is running as a 32-bit process. You can install the 32-bit version of the ASP.NET Core 3.1 SDK in order to use the <code>dotnet</code> command in your command line tool of choice.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"">
                                    <a href=""javascript:void(0);"" class=""card-title pb-2 pt-2 bg-white text-primary fs-lg border-bottom border-dashed border-faded"">
                                        <i class=""fal fa-shield width-2 fs-xl""></i>
                                        I am getting a browser warning about an insecure website?
                                    </a>
                                </div>
                                <div class=""collapse show"">
                                    <div class=""card-body"">
 ");
            WriteLiteral(@"                                       This is most likely because there is no localhost certificate available on your computer or the one installed has not been marked trusted yet.
                                        You can run <code>dotnet dev-certs https --trust</code> in an elevated command prompt to enable trust on the development certificate.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"">
                                    <a href=""javascript:void(0);"" class=""card-title pb-2 pt-2 bg-white text-primary fs-lg border-bottom border-dashed border-faded"">
                                        <i class=""fal fa-database width-2 fs-xl""></i>
                                        I am getting an error that the application cannot start because of missing database migrations?
                                    </a>
       ");
            WriteLiteral(@"                         </div>
                                <div class=""collapse show"">
                                    <div class=""card-body"">
                                        You can follow the instructions shown on the page and click the big <strong>blue</strong> button that says: <code>Apply migration</code>.
                                        This will initialize your database platform with the necessary tables to allow you to create and authenticate users.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"">
                                    <a href=""javascript:void(0);"" class=""card-title pb-2 pt-2 bg-white text-primary fs-lg border-bottom border-dashed border-faded"">
                                        <i class=""fal fa-lock width-2 fs-xl""></i>
                                        I am getting an ");
            WriteLiteral(@"error similar to: 'Invalid login attempt'?
                                    </a>
                                </div>
                                <div class=""collapse show"">
                                    <div class=""card-body"">
                                        This means that the preconfigured user does not exist (yet) in your local database.
                                        You can go ahead to the Register page to create the user and afterwards you should be able to login with the <strong>pre-filled credentials</strong> to enter the main website.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"">
                                    <a href=""javascript:void(0);"" class=""card-title pb-2 pt-2 bg-white text-primary fs-lg border-bottom border-dashed border-faded"">
                                        <");
            WriteLiteral(@"i class=""fal fa-lock width-2 fs-xl""></i>
                                        Why is the <code class=""bg-transparent mx-1"">nav.json</code> file served from the root of the project?
                                    </a>
                                </div>
                                <div class=""collapse show"">
                                    <div class=""card-body"">
                                        Typically most websites will have <strong>StaticFiles</strong> enabled and this would allow the files to be downloaded.
                                        All files that should be accesible by your visitors is served from the <strong>wwwroot</strong> directory; the navigation sources do not qualify for this as the file is assumed to be of temporary nature.
                                        Furthermore it exists mainly for demo purposes as the assumption is made that you would most likely add the ability to generate a dynamic menu from other data sources, such as a database.");
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header"">
                                    <a href=""javascript:void(0);"" class=""card-title pb-2 pt-2 bg-white text-primary fs-lg border-bottom border-dashed border-faded"">
                                        <i class=""fal fa-lock width-2 fs-xl""></i>
                                        Why is feature <code class=""bg-transparent mx-1"">Xyz</code> or functionality <code class=""bg-transparent mx-1"">Acme</code> not included in the project by default?
                                    </a>
                                </div>
                                <div class=""collapse show"">
                                    <div class=""card-body"">
                                        <p>
                                            First and foremost, this project is not meant to s");
            WriteLiteral(@"erve as a <strong>1-in-all</strong> solution for your project start to finish.
                                            It was built and structured in such a way that it can be used as a starting point based on the set of features that speak the most to your intent and purpose (Please see the ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e19390eea68e423ddf9c95f42b5ac9de388e642113119", async() => {
                WriteLiteral("Editions");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" page to help you decide).
                                        </p>
                                        <p>
                                            While we certainly understand your frustration when a specific feature you were looking forward to is not included, we also assume you yourself are perfectly capable of expanding the features of your project over time.
                                            <br/>
                                            If and when a new update happens to include the feature you were (patiently) waiting for, great!
                                            <br/>
                                            Still not added to the project? What?! Don't worry :-) Feel free to let us know on the <a href=""https://support.gotbootstrap.com/t/asp-net-core"" target=""_blank"">Supports Forum</a> so we track the interest and see about getting it added in the next version of the template.
                                        </p>
                                 ");
            WriteLiteral("   </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
