#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e82f633a83149d9572a05f20acbad2573e4a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpeechTest_BioCareSurvey), @"mvc.1.0.view", @"/Views/SpeechTest/BioCareSurvey.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8e82f633a83149d9572a05f20acbad2573e4a0d", @"/Views/SpeechTest/BioCareSurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_SpeechTest_BioCareSurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Productivo.Core.ViewModels.BioCareSurveyAnswers.BioCareSurveyAnswerCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label h4-Pandora"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mic-state"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/GrayPoint.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-image rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("temperature"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4 colortitle-Productivo"">Productivo Bio-Care - Encuesta Sintomas</h1>
    <p></p>
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
            WriteLiteral(@"         <div class=""col-sm-12"">
                            <div id=""sendData"" class=""alert alert-success"" role=""alert"">
                                <strong>Encuesta terminada</strong>
                            </div>
                        </div>
                        <div class=""col-sm-12 d-flex justify-content-center"">

                            <div class=""form-group"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e82f633a83149d9572a05f20acbad2573e4a0d8685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 27 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeesId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <input id=""employeeId"" class=""form-control"" onkeypress=""return keyPressCheck(event)"" />
                                <span id=""document-error"" class=""text-danger""></span>
                                <br />
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8e82f633a83149d9572a05f20acbad2573e4a0d10520", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr />
                        <div class=""row"">
                            <div class=""col-sm-10"">
                                <div>
                                    <dl class=""row"">
                                        <dt class=""col-sm-10 d-flex justify-content-lg-start"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e82f633a83149d9572a05f20acbad2573e4a0d12237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 40 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Temperature);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-2\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8e82f633a83149d9572a05f20acbad2573e4a0d13944", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 43 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Temperature);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e82f633a83149d9572a05f20acbad2573e4a0d15612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 44 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Temperature);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </dd>\r\n");
#nullable restore
#line 46 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
                                         foreach (var question in Model.Questions)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <dt class=\"col-sm-10 d-flex justify-content-lg-start\">\r\n                                                <label class=\"control-label h4-Pandora\">");
#nullable restore
#line 49 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
                                                                                   Write(question.QuestionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            </dt>\r\n                                            <dd class=\"col-sm-2\">\r\n                                                <input");
            BeginWriteAttribute("id", " id=\"", 3394, "\"", 3413, 2);
            WriteAttributeValue("", 3399, "q-", 3399, 2, true);
#nullable restore
#line 52 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
WriteAttributeValue("", 3401, question.Id, 3401, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" readonly />\r\n                                            </dd>\r\n");
#nullable restore
#line 54 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\SpeechTest\BioCareSurvey.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </dl>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        const questions = [];
        const responses = [];
        let index = 0;
        let start_survey = 0;
        let access = 1;
        let wordRecognition = 1;
        const question = document.getElementById('question');

        let recognition = new webkitSpeechRecognition();
        let speech = new SpeechSynthesisUtterance();
        let id = 0;
        let img = document.getElementById(""mic-state"");
        let msgError = document.getElementById(""document-error"");
        document.getElementById(""employeeId"").focus();
        document.getElementById(""sendData"").style.display = 'none';


        recognition.lang = 'es-ES';
        recognition.continuous = false;
        recognition.interimResult = false;
        recognition.start();
        //obtiene las preguntas
        $.getJSON(window.location.pathname.replace('/BioCareSurvey', '/Survey'), {},
            function (data) {
                $.each(data, function (index, rowv) {
 ");
                WriteLiteral(@"                   console.log(rowv);
                    questions.push(rowv);
                })

                console.log(questions);
            }
        );

        //Definicion de eventos
        speech.onend = (event) => {
            recognition.start();
        }

        recognition.onresult = (event) => {

            if (start_survey !== 0) {
                wordRecognition = 1;
                console.log(""Start-survey "" + start_survey)
                const result = event.results;
                const textdata = result[0][0].transcript;

                if (textdata === ""s??"") {
                    access = 0;
                }

                if (textdata === ""s??"" || textdata === ""no"") {
                    let id = ""q-"" + questions[index].id;
                    let response = document.getElementById(id);
                    response.value = textdata;
                    responses.push(questions[index].id + "":"" + textdata);
                } else {
         ");
                WriteLiteral(@"           wordRecognition = 0;
                }

            } 

        }

        recognition.onend = function () {
            if (start_survey !== 0) {
                img.src = img.src.replace(""BluePoint"", ""GrayPoint"");
                console.log('Reconocimiento finalizado');
                if (index < (questions.length - 1)) {
                    if (wordRecognition === 1) {
                        index += 1;
                    }
                    setTimeout(""startRecognition()"", 1000);
                } else {
                    console.log([questions, responses]);
                    sendAnswerData();

                    if (access === 1) {
                        speechText(""Encuesta terminada, Bienvenido."");
                    } else {
                        speechText(""Encuesta finalizada, usted no esta autorizado para ingresar."");
                    }

                    document.getElementById(""sendData"").style.display = 'block';
                    setTim");
                WriteLiteral(@"eout(""location.reload()"", 3000);
                }
            }
        };

        recognition.onstart = function () {
            if (start_survey !== 0) {
                console.log('Reconocimiento iniciado');
                img.src = img.src.replace(""GrayPoint"", ""BluePoint"");
            } else {
                recognition.stop();
            }
        }


        //Funciones personalizadas para el desarrollo
        function keyPressCheck(e) {
            msgError.innerHTML = """";
            if (e.keyCode == 13) {
                start_survey = 1;
                access = 1;
                let EmployeeId = document.getElementById(""employeeId"").value;
                $.getJSON(window.location.pathname.replace('/BioCareSurvey', '/CheckDocument'), { document: EmployeeId },
                    function (data) {
                        if (data === 'failed') {
                            msgError.innerHTML = ""Documento no registrado."";
                        } else {
         ");
                WriteLiteral(@"                   id = data;
                            console.log(""ID encuesta :"" + data);
                            startSurvey();
                        }
                    }
                );

            }
        }

        function startSurvey() {
            index = 0;
            responses.splice(0);
            console.log(""Inicio Test encuesta sin contacto"");
            startRecognition();
        }

        function startRecognition() {
            console.log(""Inicia reconocimeinto"");
            var dataQuestion = questions[index].questionName;
            speechText(dataQuestion);
        }

        function sendAnswerData() {

            let Temperature = document.getElementById(""temperature"").value;
            $.post(window.location.pathname.replace('/BioCareSurvey', '/Answers'), { employeesId: id, temperature: Temperature, data: responses },);

        }

        function speechText(dataText) {
            console.log('Speech : ' + dataText);
     ");
                WriteLiteral("       speech.text = dataText;\r\n            speech.volume = 1;\r\n            speech.rate = 1;\r\n            speech.pich = 1;\r\n            window.speechSynthesis.speak(speech);\r\n        }\r\n\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Productivo.Core.ViewModels.BioCareSurveyAnswers.BioCareSurveyAnswerCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
