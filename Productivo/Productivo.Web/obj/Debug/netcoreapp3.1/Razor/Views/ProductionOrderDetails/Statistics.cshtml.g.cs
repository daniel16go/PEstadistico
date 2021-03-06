#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c06d7c95e8b3d553de14f686e45957e23ebdaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductionOrderDetails_Statistics), @"mvc.1.0.view", @"/Views/ProductionOrderDetails/Statistics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c06d7c95e8b3d553de14f686e45957e23ebdaf", @"/Views/ProductionOrderDetails/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductionOrderDetails_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Productivo.Core.Entities.ProductionOrderDetailEntity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row wrapper border-bottom page-heading"">
    <div class=""col-sm-4"">
        <h2>Registro Produccion</h2>
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
            WriteLiteral(@"        <div class=""col-lg-12"">
                            <div class=""m-b-md"">
                                <h2>Indicadores</h2>
                            </div>
                            <div>
                                <hr />
                                <div class=""justify-content-md-center text-center"">
                                    <div class=""panel-content"">
                                        <h2 class=""colortitle-Productivo"">OEE Evolucion de Produccion</h2>
                                        <div id=""chart-container2"">Productivo Core Loading Data!!!</div>
                                    </div>
                                </div>
                            </div>
                            <div>
                                ");
#nullable restore
#line 39 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\Statistics.cshtml"
                           Write(Html.ActionLink("Regresar", "Details", "ProductionOrders", new { id = Model.ProductionOrdersId }, new { @class = "h3-Pandora  btn btn-secondary btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        FusionCharts.ready(function () {


             var fusioncharts = new FusionCharts({
                type: 'angulargauge',
                renderAt: 'chart-container2',
                width: '100%',
                height: '300',
                dataFormat: 'json',
                dataSource: {
                    ""chart"": {
                        ""showBorder"": ""0"",
                        ""showShadow"": ""0"",
                        ""use3DLighting"": ""0"",
                        ""showLabels"": ""0"",
                        ""showValues"": ""0"",
                        ""paletteColors"": ""#58E2C2, #F7E53B"",
                        ""bgColor"": ""#ffffff"",
                        ""bgAlpha"": ""100"",
                        ""canvasBgAlpha"": ""0"",
                        ""decimals"": ""0"",
                        ""baseFont"": ""Arial"",
                        ""setAdaptiveMin"": ""1"",
                        ""baseFontColor"": ""#000000"",
                        ");
                WriteLiteral(@"""chartTopMargin"": ""0"",
                        ""canvasTopMargin"": ""0"",
                        ""chartBottomMargin"": ""70"",
                        ""chartLeftMargin"": ""10"",
                        ""chartRightMargin"": ""10"",
                        ""showTickMarks"": ""0"",
                        ""showTickValues"": ""0"",
                        ""showLimits"": ""0"",
                        ""majorTMAlpha"": ""0"",
                        ""minorTMAlpha"": ""0"",
                        ""pivotFillAlpha"": ""0"",
                        ""showPivotBorder"": ""0"",
                        ""gaugeouterradius"": ""150"",
                        ""gaugeInnerradius"": ""125"",
                        ""showGaugeBorder"": ""0"",
                        ""gaugeFillMix"": ""{light+0}"",
                        ""toolTipBgcolor"": ""#484E69"",
                        ""toolTipPadding"": ""7"",
                        ""toolTipBorderRadius"": ""3"",
                        ""toolTipBorderAlpha"": ""30"",
                        ""tooltipBorderThickness"": ""0.7""");
                WriteLiteral(@",
                        ""toolTipColor"": ""#FDFDFD"",
                        ""transposeAnimation"": ""1""
                    },
                    ""annotations"": {
                        ""groups"": [{
                            ""items"": [
                                {
                                    ""id"": ""2"",
                                    ""type"": ""text"",
                                    ""text"": """);
#nullable restore
#line 105 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\Statistics.cshtml"
                                        Write(ViewBag.OEE);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"%"",
                                    ""align"": ""center"",
                                    ""font"": ""Arial"",
                                    ""bold"": ""1"",
                                    ""fontSize"": ""45"",
                                    ""color"": ""#000000"",
                                    ""x"": ""$chartcenterX"",
                                    ""y"": ""$chartCenterY""
                                }, {
                                    ""id"": ""3"",
                                    ""type"": ""text"",
                                    ""text"": ""80% OEE Min."",
                                    ""align"": ""center"",
                                    ""font"": ""Arial"",
                                    ""bold"": ""0"",
                                    ""fontSize"": ""25"",
                                    ""color"": ""#000000"",
                                    ""x"": ""$chartcenterX"",
                                    ""y"": ""$chartCenterY + 45""
                                }]
");
                WriteLiteral("                        }]\r\n                    },\r\n\r\n                    \"colorRange\": {\r\n                        \"color\": [{\r\n                            \"minValue\": \"0\",\r\n                            \"maxValue\": \"");
#nullable restore
#line 131 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\Statistics.cshtml"
                                    Write(ViewBag.OEE);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                            ""code"": ""#58E2C2""
                        },
                        {
                            ""minValue"": ""0"",
                            ""maxValue"": ""100"",
                            ""code"": ""#48506E""
                        }
                        ]
                    },
                    ""dials"": {
                        ""dial"": [{
                            ""value"": """);
#nullable restore
#line 143 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\ProductionOrderDetails\Statistics.cshtml"
                                 Write(ViewBag.OEE);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                            ""alpha"": ""0"",
                            ""borderAlpha"": ""0"",
                            ""radius"": ""0"",
                            ""baseRadius"": ""0"",
                            ""rearExtension"": ""0"",
                            ""baseWidth"": ""0"",
                            ""showValue"": ""0""
                        }]
                    }

                }
            });
            fusioncharts.render();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Productivo.Core.Entities.ProductionOrderDetailEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
