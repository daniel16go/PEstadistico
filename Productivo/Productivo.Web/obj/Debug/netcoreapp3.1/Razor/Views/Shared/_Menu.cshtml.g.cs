#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284bff0cf850b859cc3160164762576e2abcf8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Menu), @"mvc.1.0.view", @"/Views/Shared/_Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284bff0cf850b859cc3160164762576e2abcf8a7", @"/Views/Shared/_Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""js-inbox-menu"" class=""flex-wrap position-relative bg-white slide-on-mobile slide-on-mobile-left"">
	<div class=""position-absolute pos-top pos-bottom w-100"">
		<div class=""d-flex h-100 flex-column"">
			<div class=""px-3 px-sm-4 px-lg-5 py-4 align-items-center"">
				<div class=""btn-group btn-block"" role=""group"" aria-label=""Button group with nested dropdown "">
					<button type=""button"" class=""btn btn-danger btn-block fs-md"" data-action=""toggle"" data-class=""d-flex"" data-target=""#panel-compose"" data-focus=""message-to"">Compose</button>
					<div class=""btn-group"" role=""group"">
						<button id=""btnGroupDrop1"" type=""button"" class=""btn btn-danger dropdown-toggle px-2 js-waves-off"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""></button>
						<div class=""dropdown-menu p-0"" aria-labelledby=""btnGroupDrop1"">
							<a class=""dropdown-item"" href=""#"">Work group A</a>
							<a class=""dropdown-item"" href=""#"">New page</a>
							<a class=""dropdown-item"" href=""#"">Edit signature</a>
				");
            WriteLiteral("\t\t\t<div class=\"dropdown-divider m-0\"></div>\r\n\t\t\t\t\t\t\t<a class=\"dropdown-item\" href=\"#\"> <i class=\"fas fa-plus width-1\"></i> Add more</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"flex-1 pr-3\">\r\n\t\t\t\t<a href=\"/page/inboxgeneral\"");
            BeginWriteAttribute("class", " class=\"", 1273, "\"", 1508, 14);
            WriteAttributeValue("", 1281, "dropdown-item", 1281, 13, true);
            WriteAttributeValue(" ", 1294, "px-3", 1295, 5, true);
            WriteAttributeValue(" ", 1299, "px-sm-4", 1300, 8, true);
            WriteAttributeValue(" ", 1307, "pr-lg-3", 1308, 8, true);
            WriteAttributeValue(" ", 1315, "pl-lg-5", 1316, 8, true);
            WriteAttributeValue(" ", 1323, "py-2", 1324, 5, true);
            WriteAttributeValue(" ", 1328, "fs-md", 1329, 6, true);
            WriteAttributeValue(" ", 1334, "font-weight-bold", 1335, 17, true);
            WriteAttributeValue(" ", 1351, "d-flex", 1352, 7, true);
            WriteAttributeValue(" ", 1358, "justify-content-between", 1359, 24, true);
            WriteAttributeValue(" ", 1382, "rounded-pill", 1383, 13, true);
            WriteAttributeValue(" ", 1395, "border-top-left-radius-0", 1396, 25, true);
            WriteAttributeValue(" ", 1420, "border-bottom-left-radius-0", 1421, 28, true);
#nullable restore
#line 20 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_Menu.cshtml"
WriteAttributeValue(" ", 1448, ViewBag.PageName == "page_inbox_general" ? "active" : "", 1449, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
					<div>
						<i class=""fas fa-folder-open width-1""></i>Inbox
					</div>
					<div class=""fw-400 fs-xs js-unread-emails-count""></div>
				</a>
				<a href=""javascript:void(0)"" class=""dropdown-item px-3 px-sm-4 pr-lg-3 pl-lg-5 py-2 fs-md d-flex justify-content-between rounded-pill border-top-left-radius-0 border-bottom-left-radius-0"">
					<div>
						<i class=""fas fa-star width-1""></i>Starred
					</div>
					<div class=""fw-400 fs-xs"">(6)</div>
				</a>
				<a href=""javascript:void(0)"" class=""dropdown-item px-3 px-sm-4 pr-lg-3 pl-lg-5 py-2 fs-md d-flex justify-content-between rounded-pill border-top-left-radius-0 border-bottom-left-radius-0"">
					<div>
						<i class=""fas fa-edit width-1""></i>Draft
					</div>
					<div class=""fw-400 fs-xs"">(5)</div>
				</a>
				<a href=""javascript:void(0)"" class=""dropdown-item px-3 px-sm-4 pr-lg-3 pl-lg-5 py-2 fs-md d-flex justify-content-between rounded-pill border-top-left-radius-0 border-bottom-left-radius-0"">
					<div>
						<i class=""fas fa-");
            WriteLiteral(@"paper-plane width-1""></i>Sent
					</div>
				</a>
				<a href=""javascript:void(0)"" class=""dropdown-item px-3 px-sm-4 pr-lg-3 pl-lg-5 py-2 fs-md d-flex justify-content-between rounded-pill border-top-left-radius-0 border-bottom-left-radius-0"">
					<div>
						<i class=""fas fa-exclamation-triangle width-1""></i>Spam
					</div>
				</a>
				<a href=""javascript:void(0)"" class=""dropdown-item px-3 px-sm-4 pr-lg-3 pl-lg-5 py-2 fs-md font-weight-bold d-flex justify-content-between rounded-pill border-top-left-radius-0 border-bottom-left-radius-0"">
					<div>
						<i class=""fas fa-trash width-1""></i>Trash
					</div>
				</a>
			</div>
			<div class=""px-5 py-3 fs-nano fw-500"">
				1.5 GB (10%) of 15 GB used
				<div class=""progress mt-1"" style=""height: 7px;"">
					<div class=""progress-bar"" role=""progressbar"" style=""width: 11%;"" aria-valuenow=""11"" aria-valuemin=""0"" aria-valuemax=""100""></div>
				</div>
			</div>
		</div>
	</div>
</div>
<div class=""slide-backdrop"" data-action=""toggle"" data-clas");
            WriteLiteral("s=\"slide-on-mobile-left-show\" data-target=\"#js-inbox-menu\"></div>");
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
