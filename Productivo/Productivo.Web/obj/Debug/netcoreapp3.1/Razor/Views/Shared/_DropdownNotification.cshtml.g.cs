#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\_DropdownNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6871fd36edfaf6228c8c371cfe08c8b913381777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DropdownNotification), @"mvc.1.0.view", @"/Views/Shared/_DropdownNotification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6871fd36edfaf6228c8c371cfe08c8b913381777", @"/Views/Shared/_DropdownNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DropdownNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""dropdown-header bg-trans-gradient d-flex justify-content-center align-items-center rounded-top mb-2"">
    <h4 class=""m-0 text-center color-white"" id=""panel-count-notification""></h4>
</div>
<ul class=""nav nav-tabs nav-tabs-clean"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link px-4 fs-md js-waves-on fw-500"" data-toggle=""tab"" href=""#tab-messages"" data-i18n=""drpdwn.messages"">Mensajes</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link px-4 fs-md js-waves-on fw-500"" data-toggle=""tab"" href=""#tab-events"" data-i18n=""drpdwn.feeds"">Eventos</a>
    </li>
    <!--otros menus

        <li class=""nav-item"">
            <a class=""nav-link px-4 fs-md js-waves-on fw-500"" data-toggle=""tab"" href=""#tab-events"" data-i18n=""drpdwn.events"">Eventos</a>
        </li>
    -->
</ul>
<div class=""tab-content tab-notification"">
    <div class=""tab-pane active p-3 text-center"">
        <h5 class=""mt-4 pt-4 fw-500"">
            <span class=""d-block fa-3x pb-4 text-muted"">
");
            WriteLiteral(@"                <i class=""ni ni-arrow-up text-gradient opacity-70""></i>
            </span> Select a tab above to activate
            <small class=""mt-3 fs-b fw-400 text-muted"">
                This blank page message helps protect your privacy, or you can show the first message here automatically through
                <a href=""#"">settings page</a>
            </small>
        </h5>
    </div>
    <div class=""tab-pane"" id=""tab-messages"" role=""tabpanel"">
        <div class=""custom-scroll h-100"">
            <ul class=""notification"" id=""notification-list"">
            </ul>
        </div>
    </div>
    <div class=""tab-pane"" id=""tab-events"" role=""tabpanel"">
        <div class=""custom-scroll h-100"">
            <ul class=""notification"" id=""event-list"">
            </ul>
        </div>
    </div>

</div>
<div class=""py-2 px-3 bg-faded d-block rounded-bottom text-right border-faded border-bottom-0 border-right-0 border-left-0"">
    <a href=""#"" class=""fs-xs fw-500 ml-auto"">ver todas las no");
            WriteLiteral("tificaciones</a>\r\n</div>");
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
