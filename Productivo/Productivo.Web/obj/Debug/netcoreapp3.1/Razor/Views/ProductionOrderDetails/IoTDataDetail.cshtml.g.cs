#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b87998d58a914834c798921be288d7c48180a73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductionOrderDetails_IoTDataDetail), @"mvc.1.0.view", @"/Views/ProductionOrderDetails/IoTDataDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87998d58a914834c798921be288d7c48180a73e", @"/Views/ProductionOrderDetails/IoTDataDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductionOrderDetails_IoTDataDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Productivo.Core.ViewModels.ProductionOrderDetails.IoTDataDetailViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/FusionCharts/fusioncharts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/FusionCharts/themes/fusioncharts.theme.fusion.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b87998d58a914834c798921be288d7c48180a73e5010", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Refresh\" content=\"300\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b87998d58a914834c798921be288d7c48180a73e5325", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b87998d58a914834c798921be288d7c48180a73e6424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        FusionCharts.ready(function () {

            $.getJSON(window.location.href.replace('/IoTDataDetail/', '/getMachinesList/'), {},
                function (data) {
                    $.each(data, function (index, rowv) {
                        $.getJSON(window.location.href.replace('/IoTDataDetail/', '/getVariableList/'), { machineId: rowv[""machinesId""] },
                            function (variable) {
                                $.each(variable, function (index, variableLine) {
                                    var _startDate = '");
#nullable restore
#line 17 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
                                                 Write(ViewBag.StartTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                                    var _endDate = \'");
#nullable restore
#line 18 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
                                               Write(ViewBag.EndTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                                    var char_name = ""chart-container-"" + rowv[""machinesId""] + ""|"" + variableLine[""id""];
                                    console.log(char_name);

                                    $.getJSON(window.location.href.replace('/IoTDataDetail/', '/LastRecordsDataSearch/'), { iotId: variableLine[""codeIoT""], variableName: variableLine[""name""], startDate: _startDate, endDate: _endDate },
                                        function (iotData) {
                                            var Data = [];
                                            var Chart = iotData[""chart""];

                                            for (let i = 0; i < iotData[""categories""].length; i++) {
                                                Data.push(JSON.parse(JSON.stringify({ label: iotData[""categories""][i], value: iotData[""data""][i] })));
                                            }
                                            var myChart = new FusionCharts({
                     ");
                WriteLiteral(@"                           type: ""line"",
                                                renderAt: char_name,
                                                width: ""100%"",
                                                height: ""400"",
                                                dataFormat: ""json"",
                                                dataSource: {
                                                    chart: Chart,
                                                    data: Data
                                                }
                                            }).render();
                                    });
                                })

                            });
                    })
                });
        });

    </script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b87998d58a914834c798921be288d7c48180a73e11388", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 55 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>No hay registros de produccion asociados aun en la orden.</h5>\r\n");
#nullable restore
#line 58 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-xl-12\">\r\n                    <div id=\"panel-1\" class=\"panel\">\r\n                        <div class=\"panel-hdr\">\r\n                            <h2>");
#nullable restore
#line 67 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
                           Write(item.Machine.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                            <div class=""panel-toolbar"">
                                <button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Minimizar""></button>
                                <button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Maximizar""></button>
                                <button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Cerrar""></button>
                            </div>
                        </div>
                        <div class=""panel-container show"">
                            <div class=""panel-content"">
");
#nullable restore
#line 76 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
                                 foreach (var variable in item.Variables)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"panel-hdr\">\r\n                                        <h4>");
#nullable restore
#line 79 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
                                       Write(variable.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                    </div>\r\n                                    <div class=\"panel-container show\">\r\n                                        <div class=\"panel-content\">\r\n                                            <div");
                BeginWriteAttribute("id", " id=\"", 4485, "\"", 4535, 4);
                WriteAttributeValue("", 4490, "chart-container-", 4490, 16, true);
#nullable restore
#line 83 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
WriteAttributeValue("", 4506, item.Machine.Id, 4506, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4522, "|", 4522, 1, true);
#nullable restore
#line 83 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
WriteAttributeValue("", 4523, variable.Id, 4523, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Productivo Core Loading Data!!!</div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 86 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 92 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 97 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\IoTDataDetail.cshtml"
           Write(Html.ActionLink("Regresar", "Details", "ProductionOrders", new { id = ViewBag.OrderId }, new { @class = "h3-Productivo  btn btn-warning btn-sm glyphicon glyphicon-step-backward", title = "Regresar" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Productivo.Core.ViewModels.ProductionOrderDetails.IoTDataDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
