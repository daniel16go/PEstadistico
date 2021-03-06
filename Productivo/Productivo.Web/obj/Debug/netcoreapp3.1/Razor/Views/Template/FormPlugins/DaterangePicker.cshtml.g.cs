#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b54af65217845fe1ebafffdef1f15ee763551fb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_FormPlugins_DaterangePicker), @"mvc.1.0.view", @"/Views/Template/FormPlugins/DaterangePicker.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54af65217845fe1ebafffdef1f15ee763551fb7", @"/Views/Template/FormPlugins/DaterangePicker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_FormPlugins_DaterangePicker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/formplugins/bootstrap-daterangepicker/bootstrap-daterangepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dependency/moment/moment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/formplugins/bootstrap-daterangepicker/bootstrap-daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml"
   
	ViewData["Title"] = "Date Range Picker";
	ViewData["PageName"] = "form_plugins_daterange_picker";
	ViewData["Category1"] = "Form Plugins";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-credit-card-front'></i> Date Range Picker<sup class='badge badge-primary fw-500'>ADDON</sup>";
	ViewData["PageDescription"] = "A JavaScript component for choosing date ranges, dates and times.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b54af65217845fe1ebafffdef1f15ee763551fb76437", async() => {
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
				<p>This date range picker component creates a dropdown menu from which a user can select a range of dates. I created it while building the UI for Improvely, which needed a way to select date ranges for reports. Features include limiting the selectable date range, localizable strings and date formats, a single date picker mode, a time picker, and predefined date ranges.</p>
				<p class=""m-0"">
					Find in-depth, guidelines, tutorials and more on Addon's <a href=""http://www.daterangepicker.co");
            WriteLiteral(@"m/"" target=""_blank"">Official Documentation</a> 
				</p>
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-12"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr"">	
				<h2>
					Datepicker Range Picker<span class=""fw-300""><i>Examples</i></span> 
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
						Below you will find various date picker examples which you can use for your project
					</div>
					<div cl");
            WriteLiteral(@"ass=""form-group row"">
						<label class=""col-form-label col-12 col-lg-3 form-label text-lg-right"">Minimum Setup</label>
						<div class=""col-12 col-lg-6 "">
							<input type=""text"" class=""form-control"" id=""datepicker-1"" placeholder=""Select date"" value=""01/01/2018 - 01/15/2018"">
						</div>
					</div>
					<div class=""form-group row"">
						<label class=""col-form-label col-12 col-lg-3 form-label text-lg-right"">Date Range Picker With Times</label>
						<div class=""col-12 col-lg-6"">
							<div class=""input-group"">
								<input type=""text"" class=""form-control"" placeholder=""Select date"" id=""datepicker-2"">
								<div class=""input-group-append"">
									<span class=""input-group-text fs-xl"">
										<i");
            BeginWriteAttribute("class", " class=\"", 3336, "\"", 3384, 2);
#nullable restore
#line 62 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml"
WriteAttributeValue("", 3344, Settings.Theme.IconPrefix, 3344, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3372, "fa-calendar", 3373, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
									</span>
								</div>
							</div>
						</div>
					</div>
					<div class=""form-group row"">
						<label class=""col-form-label col-12 col-lg-3 form-label text-lg-right"">Single Date Picker</label>
						<div class=""col-12 col-lg-6"">
							<div class=""input-group"" >
								<input type=""text"" class=""form-control""  value=""07/17/2020"" id=""datepicker-3"">
								<div class=""input-group-append"">
									<span class=""input-group-text fs-xl"">
										<i");
            BeginWriteAttribute("class", " class=\"", 3870, "\"", 3922, 2);
#nullable restore
#line 75 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml"
WriteAttributeValue("", 3878, Settings.Theme.IconPrefix, 3878, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3906, "fa-calendar-alt", 3907, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
									</span>
								</div>
							</div>
							<span class=""help-block"">Enable clear and today helper buttons</span>
						</div>
					</div>
					<div class=""form-group row"">
						<label class=""col-form-label col-12 col-lg-3 form-label text-lg-right"">Predefined Ranges</label>
						<div class=""col-12 col-lg-6"">
							<input type=""text"" class=""form-control ""  value=""07/17/2020"" id=""datepicker-4"">
						</div>
					</div>
					<div class=""form-group row"">
						<label class=""col-form-label col-12 col-lg-3 form-label text-lg-right"">Advanced Options</label>
						<div class=""col-12 col-lg-6"">
							<input type=""text"" class=""form-control"" id=""custom-range"">
						</div>
					</div>
					<div class=""form-group row"">
						<label class=""col-form-label col-12 col-lg-3 form-label text-lg-right"">Modal Demos</label>
						<div class=""col-12 col-lg-6"">
							<a");
            BeginWriteAttribute("href", " href=\"", 4823, "\"", 4830, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#default-example-modal"">Show inside datepicker</a>
						</div>
					</div>
					<div class=""modal fade"" id=""default-example-modal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
						<div class=""modal-dialog"" role=""document"">
							<div class=""modal-content"">
								<div class=""modal-header"">
									<h4 class=""modal-title"">
										Date picker inside modal
									</h4>
									<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
										<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 5406, "\"", 5451, 2);
#nullable restore
#line 108 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml"
WriteAttributeValue("", 5414, Settings.Theme.IconPrefix, 5414, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5442, "fa-times", 5443, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
									</button>
								</div>
								<div class=""modal-body"">
									<div class=""form-group"">
										<label class=""form-label"" for=""datepicker-modal-2"">Minimum Setup</label>
										<div class=""input-group"">
											<div class=""input-group-prepend"">
												<span class=""input-group-text fs-xl""><i");
            BeginWriteAttribute("class", " class=\"", 5789, "\"", 5837, 2);
#nullable restore
#line 116 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml"
WriteAttributeValue("", 5797, Settings.Theme.IconPrefix, 5797, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5825, "fa-calendar", 5826, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
											</div>
											<input type=""text"" id=""datepicker-modal-2"" class=""form-control"" placeholder=""Select a date"" aria-label=""date"" aria-describedby=""datepicker-modal-2"">
										</div>
										<span class=""help-block"">Some help content goes here</span>
									</div>
									<div class=""form-group"">
										<label class=""form-label"" for=""datepicker-modal-3"">Date Range Picker With Times</label>
										<div class=""input-group"">
											<input type=""text"" id=""datepicker-modal-3"" class=""form-control"" placeholder=""End date"" aria-label=""date"" aria-describedby=""datepicker-modal-3"">
											<div class=""input-group-append"">
												<span class=""input-group-text fs-xl""><i");
            BeginWriteAttribute("class", " class=\"", 6561, "\"", 6613, 2);
#nullable restore
#line 127 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Template\FormPlugins\DaterangePicker.cshtml"
WriteAttributeValue("", 6569, Settings.Theme.IconPrefix, 6569, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6597, "fa-calendar-alt", 6598, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
											</div>
										</div>
										<span class=""help-block"">Some help content goes here</span>
									</div>
								</div>
								<div class=""modal-footer"">
									<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
									<button type=""button"" class=""btn btn-primary"">Save changes</button>
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b54af65217845fe1ebafffdef1f15ee763551fb717063", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b54af65217845fe1ebafffdef1f15ee763551fb718161", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	<script>
		$(document).ready(function () {
			$('#datepicker-1, #datepicker-modal-2').daterangepicker({
			    opens: 'left'
			  }, function(start, end, label) {
			    console.log(""A new date selection was made: "" + start.format('YYYY-MM-DD') + ' to ' + end.format('YYYY-MM-DD'));
			});
			$('#datepicker-2, #datepicker-modal-3').daterangepicker({
			    timePicker: true,
			    startDate: moment().startOf('hour'),
			    endDate: moment().startOf('hour').add(32, 'hour'),
			    locale: {
			      format: 'M/DD hh:mm A'
			    }
			});
			$('#datepicker-3').daterangepicker({
			    singleDatePicker: true,
			    showDropdowns: true
			});
			$(function() {
			    var start = moment().subtract(29, 'days');
			    var end = moment();
			    function cb(start, end) {
			        $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
			    }
			    $('#datepicker-4').daterangepicker({
			        startDate: start,
			        endDate: end,
			");
                WriteLiteral(@"        ranges: {
			           'Today': [moment(), moment()],
			           'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
			           'Last 7 Days': [moment().subtract(6, 'days'), moment()],
			           'Last 30 Days': [moment().subtract(29, 'days'), moment()],
			           'This Month': [moment().startOf('month'), moment().endOf('month')],
			           'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
			        }
			    }, cb);
			    cb(start, end);
			});
			$('#custom-range').daterangepicker({
				""showDropdowns"": true,
			    ""showWeekNumbers"": true,
			    ""showISOWeekNumbers"": true,
			    ""timePicker"": true,
			    ""timePicker24Hour"": true,
			    ""timePickerSeconds"": true,
			    ""autoApply"": true,
			    ""maxSpan"": {
			        ""days"": 7
			    },
			    ranges: {
			        'Today': [moment(), moment()],
			        'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, '");
                WriteLiteral(@"days')],
			        'Last 7 Days': [moment().subtract(6, 'days'), moment()],
			        'Last 30 Days': [moment().subtract(29, 'days'), moment()],
			        'This Month': [moment().startOf('month'), moment().endOf('month')],
			        'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
			    },
			    ""alwaysShowCalendars"": true,
			    ""startDate"": ""05/12/2019"",
			    ""endDate"": ""05/18/2019"",
			    ""applyButtonClasses"": ""btn-default shadow-0"",
    			""cancelClass"": ""btn-success shadow-0""
			}, function(start, end, label) {
			  console.log('New date range selected: ' + start.format('YYYY-MM-DD') + ' to ' + end.format('YYYY-MM-DD') + ' (predefined range: ' + label + ')');
			});
		});
	</script>
");
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
