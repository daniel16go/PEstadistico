#pragma checksum "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beabb995c127715893c5f02b6766afab6a535169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompareDiagnostics_ReportPDF), @"mvc.1.0.view", @"/Views/CompareDiagnostics/ReportPDF.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beabb995c127715893c5f02b6766afab6a535169", @"/Views/CompareDiagnostics/ReportPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_CompareDiagnostics_ReportPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDictionary<string, List<Productivo.Core.ViewModels.CompareModels.CompareModelViewModel>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Productivo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Productivo Small.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Pandora + / Diagnostico vs Modelo ideal";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beabb995c127715893c5f02b6766afab6a5351696865", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "beabb995c127715893c5f02b6766afab6a5351697192", async() => {
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
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    <title>Productivo / Diagnostico vs Modelo ideal</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beabb995c127715893c5f02b6766afab6a5351699447", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "beabb995c127715893c5f02b6766afab6a5351699784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-8 text-right\">\r\n            <h2>Diagnostico vs Modelo ideal\r\n            </h2>\r\n        </div>\r\n    </div>\r\n    <div class=\"panel-container show\">\r\n        <div class=\"panel-content\">\r\n");
#nullable restore
#line 30 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
             foreach (string key in Model.Keys)
            {
                decimal totalScore = 0;
                decimal totalIdealScore = 0;


#line default
#line hidden
#nullable disable
                WriteLiteral("                <th style=\"width: 50%;\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
               Write(key);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </th>
                <table id=""MyTable"" class=""table table-hover table-striped table-sm w-100"">
                    <thead>
                        <tr>
                            <th style=""width: 50%;"">
                                ");
#nullable restore
#line 42 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].QuestionName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 45 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].DiagnosticExecution));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 48 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].IdealExecution));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 51 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].Difference));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 54 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].Compliance));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 57 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].Score));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 60 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                           Write(Html.DisplayNameFor(model => model[Model.Keys.FirstOrDefault()][0].IdealScore));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                         foreach (var item in Model[key])
                        {
                            totalScore += item.Score;
                            totalIdealScore += item.IdealScore;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 71 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                               Write(Html.DisplayFor(modelItem => item.QuestionName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 74 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DiagnosticExecution));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 77 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IdealExecution));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 80 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Difference));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    % ");
#nullable restore
#line 83 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Compliance));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 86 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 89 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IdealScore));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 92 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <tr>
                            <td>
                                <h5><strong>TOTAL:</strong></h5>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                                <h5><strong>");
#nullable restore
#line 106 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                                       Write(totalScore.ToString("F"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h5>\r\n                            </td>\r\n                            <td>\r\n                                <h5><strong>");
#nullable restore
#line 109 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"
                                       Write(totalIdealScore.ToString("F"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h5>\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n                <hr size=\"2\" />\r\n");
#nullable restore
#line 115 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\CompareDiagnostics\ReportPDF.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDictionary<string, List<Productivo.Core.ViewModels.CompareModels.CompareModelViewModel>>> Html { get; private set; }
    }
}
#pragma warning restore 1591