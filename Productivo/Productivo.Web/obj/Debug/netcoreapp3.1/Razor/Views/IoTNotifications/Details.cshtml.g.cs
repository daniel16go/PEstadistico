#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b05f17a72c896d04e45aa1cf6505a87f3e068122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IoTNotifications_Details), @"mvc.1.0.view", @"/Views/IoTNotifications/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05f17a72c896d04e45aa1cf6505a87f3e068122", @"/Views/IoTNotifications/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_IoTNotifications_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Productivo.Core.Entities.IoTNotificationEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteDialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row wrapper border-bottom page-heading"">
    <div class=""col-sm-4"">
        <h2>Notificaciones</h2>
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

                    <div class=""row"">
                     ");
            WriteLiteral(@"   <div class=""col-lg-8"">
                            <div class=""m-b-md"">
                                <h2>Información</h2>
                            </div>
                            <div>
                                <hr />
                                <dl class=""row"">
                                    <dt class=""col-sm-4"">
                                        ");
#nullable restore
#line 33 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-8\">\r\n                                        ");
#nullable restore
#line 36 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-4\">\r\n                                        ");
#nullable restore
#line 39 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.IoTAlertsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-8\">\r\n                                        ");
#nullable restore
#line 42 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.IoTAlertsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-4\">\r\n                                        ");
#nullable restore
#line 45 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Emails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-8\">\r\n                                        ");
#nullable restore
#line 48 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Emails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-4\">\r\n                                        ");
#nullable restore
#line 51 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-8\">\r\n                                        ");
#nullable restore
#line 54 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n                            </div>\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b05f17a72c896d04e45aa1cf6505a87f3e06812210111", async() => {
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
#line 59 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
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
            WriteLiteral(" |\r\n                                <button data-id=\"");
#nullable restore
#line 60 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger btn-sm deleteItem\" data-toggle=\"modal\" data-target=\"#deleteDialog\">Borrar</button> |\r\n                                ");
#nullable restore
#line 61 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
                           Write(Html.ActionLink("Regresar", "Details", "IoTs", new { id = Model.IoTsId }, new { @class = "h3-Pandora  btn btn-secondary btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b05f17a72c896d04e45aa1cf6505a87f3e06812213448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\IoTNotifications\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script type=""text/javascript"">
        $(document).ready(function () {
            // Delete item
            $('.deleteItem').click((e) => {
                item_to_delete = e.currentTarget.dataset.id;
            });
            $(""#btnYesDelete"").click(function () {

                window.location.pathname = window.location.pathname.replace('/Details/', '/Delete/');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Productivo.Core.Entities.IoTNotificationEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
