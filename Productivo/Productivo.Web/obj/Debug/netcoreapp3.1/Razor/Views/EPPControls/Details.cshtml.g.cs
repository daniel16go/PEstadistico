#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43478757e5663a0c0c20de1590e1ba8f965502dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EPPControls_Details), @"mvc.1.0.view", @"/Views/EPPControls/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43478757e5663a0c0c20de1590e1ba8f965502dc", @"/Views/EPPControls/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_EPPControls_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Productivo.Core.ViewModels.ControlEPPs.ControlEPPDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h3-Productivo  btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ConfirmFinishDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datagrid/datatables/datatables.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row wrapper border-bottom page-heading"">
    <div class=""col-lg-10"">
        <h2>Control EPP</h2>
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
                <div class=""panel-content"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43478757e5663a0c0c20de1590e1ba8f965502dc7366", async() => {
                WriteLiteral(@"
                        <ul class=""nav nav-tabs"" role=""tablist"">
                            <li class=""nav-item active""><a class=""nav-link"" data-toggle=""tab"" href=""#tab_epp_detail"" role=""tab"">Asignacion EPP</a></li>
                        </ul>
                        <div class=""tab-content p-1"">
                            <!-- ASIGNACION EPP -->
                            <div class=""tab-pane fade show active"" id=""tab_epp_detail"" role=""tabpanel"">
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <div class=""m-b-md"">
                                            <h2>Información</h2>
                                        </div>
                                        <hr />
                                        <div class=""panel-content"">
");
#nullable restore
#line 37 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                             if (Model.controlEPPDetails.Count == 0)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <h5>No hay registros de asignacion de EPP\'s.</h5>\r\n");
#nullable restore
#line 40 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <table id=""MyTable"" class=""table table-hover table-striped table-sm w-100"">
                                                    <thead>
                                                        <tr>
                                                            <th>
                                                                ");
#nullable restore
#line 47 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                           Write(Html.DisplayNameFor(model => model.controlEPPDetails[0].Employees.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </th>\r\n                                                            <th>\r\n                                                                ");
#nullable restore
#line 50 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                           Write(Html.DisplayNameFor(model => model.controlEPPDetails[0].AsignmentDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </th>\r\n                                                            <th>\r\n                                                                ");
#nullable restore
#line 53 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                           Write(Html.DisplayNameFor(model => model.controlEPPDetails[0].ReturnDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </th>\r\n                                                            <th>\r\n                                                                ");
#nullable restore
#line 56 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                           Write(Html.DisplayNameFor(model => model.controlEPPDetails[0].ProtectionElements.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </th>\r\n                                                            <th>\r\n                                                                ");
#nullable restore
#line 59 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                           Write(Html.DisplayNameFor(model => model.controlEPPDetails[0].Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </th>
                                                            <th>
                                                            </th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 66 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                         foreach (var item in Model.controlEPPDetails)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <tr>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 70 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Employees.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 73 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.AsignmentDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 76 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.ReturnDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 79 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.ProtectionElements.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 82 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                </td>
                                                                <td>
                                                                    <div class=""btn-group"">
                                                                        ");
#nullable restore
#line 86 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                                   Write(Html.ActionLink(" ", "Details", "ControlEPPDetails", new { id = item.Id }, new { @class = "btn btn-info btn-sm fal fa-info-square" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                    </div>\r\n\r\n                                                                </td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 91 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </tbody>\r\n                                                </table>\r\n");
#nullable restore
#line 94 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <p></p>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43478757e5663a0c0c20de1590e1ba8f965502dc18918", async() => {
                WriteLiteral("<i class=\"glyphicon glyphicon-step-backward\"></i> Regresar");
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
            WriteLiteral("\r\n                        ");
#nullable restore
#line 108 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
                   Write(Html.ActionLink("Adicionar Asignacion", "Create", "EPPControlDetails", new { controlEPPId = Model.controlEPP.Id }, new { @class = "h3-Productivo  btn btn-success btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43478757e5663a0c0c20de1590e1ba8f965502dc20771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 123 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\EPPControls\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43478757e5663a0c0c20de1590e1ba8f965502dc22265", async() => {
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
    <script type=""text/javascript"">
        $(document).ready(function () {
            // FinishOrder
            $(""#btnYesConfirm"").click(function () {
                window.location.pathname = window.location.pathname.replace('/Details/', '/FinishProductionOrder/');
            });

        });
    </script>


");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Productivo.Core.ViewModels.ControlEPPs.ControlEPPDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
