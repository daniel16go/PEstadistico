#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc8c152fa7996729f40bac8f32ce63bd5f4f5d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProtectionElements_Details), @"mvc.1.0.view", @"/Views/ProtectionElements/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc8c152fa7996729f40bac8f32ce63bd5f4f5d0", @"/Views/ProtectionElements/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_ProtectionElements_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Productivo.Core.Entities.ProtectionElementEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h3-Pandora  btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
  
    var photopath = "~/images/SST/ProtectionElements/" + (Model.ImageElement ?? "No-Image.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc8c152fa7996729f40bac8f32ce63bd5f4f5d06638", async() => {
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc8c152fa7996729f40bac8f32ce63bd5f4f5d07604", async() => {
                WriteLiteral(@"

    <div class=""row wrapper border-bottom page-heading"">
        <div class=""col-sm-4"">
            <h2>Elementos de Proteccion</h2>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-xl-12"">
            <div id=""panel-1"" class=""panel"">
                <div class=""panel-hdr"">
                    <h2></h2>
                    <div class=""panel-toolbar"">
                        <button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Minimizar""></button>
                        <button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Maximizar""></button>
                        <button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Cerrar""></button>
                    </div>
                </div>
                <div class=""panel-container show"">
                    <div class");
                WriteLiteral(@"=""panel-content"">

                        <div class=""row"">
                            <div class=""col-lg-8"">
                                <div class=""m-b-md"">
                                    <h2>Información</h2>
                                </div>
                                <div>
                                    <hr />
                                    <dl class=""row"">
                                        <dt class=""col-sm-4"">
                                            ");
#nullable restore
#line 42 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 45 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 48 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 51 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                    <dl class=\"row\">\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 56 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CodeERP));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 59 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.CodeERP));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 62 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Units.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 65 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Units.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                    <dl class=\"row\">\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 70 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Minimum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 73 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Minimum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 76 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Maximum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 79 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Maximum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                    <dl class=\"row\">\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 84 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Factor1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 87 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Factor1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 90 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Factor2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 93 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Factor2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                    <dl class=\"row\">\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 98 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.MaxDayAsignment));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 101 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.MaxDayAsignment));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 104 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 107 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                    <dl class=\"row\">\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 112 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.ProtectionTypes.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 115 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.ProtectionTypes.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                    <dl class=\"row\">\r\n                                        <dt class=\"col-sm-4\">\r\n                                            ");
#nullable restore
#line 120 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-8\">\r\n                                            ");
#nullable restore
#line 123 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n                                </div>\r\n                                <div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc8c152fa7996729f40bac8f32ce63bd5f4f5d021603", async() => {
                    WriteLiteral("Editar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc8c152fa7996729f40bac8f32ce63bd5f4f5d024023", async() => {
                    WriteLiteral("Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-4\">\r\n                                <div class=\"m-b-md\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0dc8c152fa7996729f40bac8f32ce63bd5f4f5d025562", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 134 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
                                  WriteLiteral(photopath);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <div id=""myDiv"" style=""width:100%;height:300px;""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 150 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProtectionElements\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Productivo.Core.Entities.ProtectionElementEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
