#pragma checksum "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ShortcutMessenger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b78b8a48071e313a5042c3c79ec51c20fcaff7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShortcutMessenger), @"mvc.1.0.view", @"/Views/Shared/_ShortcutMessenger.cshtml")]
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
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b78b8a48071e313a5042c3c79ec51c20fcaff7a", @"/Views/Shared/_ShortcutMessenger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShortcutMessenger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TabMsgr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ShortcutMessenger.cshtml"
 if (Settings.Features.ChatInterface)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade js-modal-messenger modal-backdrop-transparent"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
   <div class=""modal-dialog modal-dialog-right"">
	  <div class=""modal-content h-100"">
		 <div class=""dropdown-header bg-trans-gradient d-flex align-items-center w-100"">
			<div class=""d-flex flex-row align-items-center mt-1 mb-1 color-white"">
				<span class=""mr-2"">
					<span class=""rounded-circle profile-image d-block"" style=""background-image:url('/img/demo/avatars/avatar-d.png'); background-size: cover;""></span>
				</span>
				<div class=""info-card-text"">
					<a href=""javascript:void(0);"" class=""fs-lg text-truncate text-truncate-lg text-white"" data-toggle=""dropdown"" aria-expanded=""false"">
						Tracey Chang 
						<i");
            BeginWriteAttribute("class", " class=\"", 800, "\"", 887, 6);
#nullable restore
#line 14 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ShortcutMessenger.cshtml"
WriteAttributeValue("", 808, Settings.Theme.IconPrefix, 808, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 836, "fa-angle-down", 837, 14, true);
            WriteAttributeValue(" ", 850, "d-inline-block", 851, 15, true);
            WriteAttributeValue(" ", 865, "ml-1", 866, 5, true);
            WriteAttributeValue(" ", 870, "text-white", 871, 11, true);
            WriteAttributeValue(" ", 881, "fs-md", 882, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
					</a>
					<div class=""dropdown-menu"">
						<a class=""dropdown-item"" href=""#"">Send Email</a>
						<a class=""dropdown-item"" href=""#"">Create Appointment</a>
						<a class=""dropdown-item"" href=""#"">Block User</a>
					</div>
					<span class=""text-truncate text-truncate-md opacity-80"">IT Director</span>
				</div>
			</div>
			<button type=""button"" class=""close text-white position-absolute pos-top pos-right p-2 m-1 mr-2"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 1405, "\"", 1450, 2);
#nullable restore
#line 25 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ShortcutMessenger.cshtml"
WriteAttributeValue("", 1413, Settings.Theme.IconPrefix, 1413, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1441, "fa-times", 1442, 9, true);
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n\t\t\t</button>\r\n\t\t </div>\r\n\t\t <div class=\"modal-body p-0 h-100 d-flex\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b78b8a48071e313a5042c3c79ec51c20fcaff7a6975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t </div>\r\n\t  </div>\r\n   </div>\r\n</div>\r\n");
#nullable restore
#line 34 "F:\Daniel Gomez\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_ShortcutMessenger.cshtml"
}

#line default
#line hidden
#nullable disable
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
