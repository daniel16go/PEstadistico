#pragma checksum "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2e07c3d3df31391e132ebc10d2c08d138cdf60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Contact), @"mvc.1.0.view", @"/Views/Shared/_Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2e07c3d3df31391e132ebc10d2c08d138cdf60", @"/Views/Shared/_Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""js-chat-contact"" class=""flex-wrap position-relative slide-on-mobile slide-on-mobile-left border-faded border-left-0 border-top-0 border-bottom-0"">
	<div class=""d-flex flex-column bg-faded position-absolute pos-top pos-bottom w-100"">
		<div class=""px-3 py-4"">
			<input type=""text"" class=""form-control bg-white"" placeholder=""Search key words"">
		</div>
		<div class=""flex-1 h-100 custom-scrollbar"">
			<div class=""w-100"">
				<div class=""nav-title m-0 px-3 text-muted"">Chat History</div>
				<ul class=""list-unstyled m-0"">
					<li>
						<div class=""d-flex w-100 px-3 py-2 text-dark hover-white cursor-pointer show-child-on-hover"">
							<div class=""profile-image-md rounded-circle"" style=""background-image:url('/img/demo/avatars/avatar-d.png'); background-size: cover;""></div>
							<div class=""px-2 flex-1"">
								<div class=""text-truncate text-truncate-md"">
									Tracey Chang
									<small class=""d-block text-muted text-truncate text-truncate-md"">
										2020-01-31 
									</sma");
            WriteLiteral(@"ll>
								</div>
							</div>
							<div class=""position-absolute pos-right mt-2 mr-3 show-on-hover-parent"">
								<button class=""btn btn-danger btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-danger-500&quot;></div></div>"" data-original-title=""Delete"">
									<i");
            BeginWriteAttribute("class", " class=\"", 1420, "\"", 1469, 2);
#nullable restore
#line 23 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 1428, Settings.Theme.IconPrefix, 1428, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1456, "fa-trash-alt", 1457, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</button>
							</div>
						</div>
					</li>
					<li>
						<div class=""d-flex w-100 px-3 py-2 text-dark hover-white cursor-pointer show-child-on-hover"">
							<div class=""profile-image-md rounded-circle"" style=""background-image:url('/img/demo/avatars/avatar-b.png'); background-size: cover;""></div>
							<div class=""px-2 flex-1"">
								<div class=""text-truncate text-truncate-md"">
									Oliver Kopyuv
									<small class=""d-block text-muted text-truncate text-truncate-md"">
										2019-03-15 
									</small>
								</div>
							</div>
							<div class=""position-absolute pos-right mt-2 mr-3 show-on-hover-parent"">
								<button class=""btn btn-danger btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-danger-500&quot;></div></div>"" data-original-title=""Delete"">
									<i");
            BeginWriteAttribute("class", " class=\"", 2418, "\"", 2467, 2);
#nullable restore
#line 41 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 2426, Settings.Theme.IconPrefix, 2426, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2454, "fa-trash-alt", 2455, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</button>
							</div>
						</div>
					</li>
					<li>
						<div class=""d-flex w-100 px-3 py-2 text-dark hover-white cursor-pointer show-child-on-hover"">
							<div class=""profile-image-md rounded-circle"" style=""background-image:url('/img/demo/avatars/avatar-e.png'); background-size: cover;""></div>
							<div class=""px-2 flex-1"">
								<div class=""text-truncate text-truncate-md"">
									Dr. John Cook PhD
									<small class=""d-block text-muted text-truncate text-truncate-md"">
										2023-05-27 
									</small>
								</div>
							</div>
							<div class=""position-absolute pos-right mt-2 mr-3 show-on-hover-parent"">
								<button class=""btn btn-danger btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-danger-500&quot;></div></div>"" data-original-title=""Delete"">
									<i");
            BeginWriteAttribute("class", " class=\"", 3420, "\"", 3469, 2);
#nullable restore
#line 59 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 3428, Settings.Theme.IconPrefix, 3428, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3456, "fa-trash-alt", 3457, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</button>
							</div>
						</div>				
					</li>
					<li>
						<div class=""d-flex w-100 px-3 py-2 text-dark hover-white cursor-pointer show-child-on-hover"">
							<div class=""profile-image-md rounded-circle"" style=""background-image:url('/img/demo/avatars/avatar-g.png'); background-size: cover;""></div>
							<div class=""px-2 flex-1"">
								<div class=""text-truncate text-truncate-md"">
									Ali Amdaney
									<small class=""d-block text-muted text-truncate text-truncate-md"">
										2023-06-11 
									</small>
								</div>
							</div>
							<div class=""position-absolute pos-right mt-2 mr-3 show-on-hover-parent"">
								<button class=""btn btn-danger btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-danger-500&quot;></div></div>"" data-original-title=""Delete"">
									<i");
            BeginWriteAttribute("class", " class=\"", 4420, "\"", 4469, 2);
#nullable restore
#line 77 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 4428, Settings.Theme.IconPrefix, 4428, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4456, "fa-trash-alt", 4457, 13, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</button>
							</div>
						</div>
					</li>
				</ul>
				<div class=""nav-title px-3 text-muted"">Missed calls</div>
				<ul class=""list-unstyled m-0"">
					<li>
						<div class=""d-flex w-100 px-3 py-2 text-dark hover-white cursor-pointer show-child-on-hover"">
							<div class=""profile-image-md rounded-circle"" style=""background-image:url('/img/demo/avatars/avatar-m.png'); background-size: cover;""></div>
							<div class=""px-2 flex-1"">
								<div class=""text-truncate text-truncate-md"">
									+714651347790
									<small class=""d-block font-italic fs-xs opacity-50"">
										Missed Call 
									</small>
								</div>
							</div>
							<div class=""position-absolute pos-right mt-2 mr-3 show-on-hover-parent"">
								<button class=""btn btn-success btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-success-500&quot;></div></div>"" data-original-titl");
            WriteLiteral("e=\"Play voicemail\">\r\n\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 5526, "\"", 5570, 2);
#nullable restore
#line 98 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 5534, Settings.Theme.IconPrefix, 5534, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5562, "fa-play", 5563, 8, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</button>
								<button class=""btn btn-info btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-info-500&quot;></div></div>"" data-original-title=""Call back"">
									<i");
            BeginWriteAttribute("class", " class=\"", 5875, "\"", 5920, 2);
#nullable restore
#line 101 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 5883, Settings.Theme.IconPrefix, 5883, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5911, "fa-phone", 5912, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
								</button>
							</div>
						</div>
					</li>
					<li>
						<div class=""d-flex w-100 px-3 py-2 text-dark hover-white cursor-pointer show-child-on-hover"">
							<div class=""profile-image-md rounded-circle"" style=""background-image:url('/img/demo/avatars/avatar-m.png'); background-size: cover;""></div>
							<div class=""px-2 flex-1"">
								<div class=""text-truncate text-truncate-md"">
									+13471349199
									<small class=""d-block font-italic fs-xs opacity-50"">
										Ended in 32 minutes
									</small>
								</div>
							</div>
							<div class=""position-absolute pos-right mt-2 mr-3 show-on-hover-parent"">
								<button class=""btn btn-info btn-xs btn-icon rounded-circle shadow-0"" data-toggle=""tooltip"" data-template=""<div class=&quot;tooltip&quot; role=&quot;tooltip&quot;><div class=&quot;tooltip-inner bg-info-500&quot;></div></div>"" data-original-title=""Call back"">
									<i");
            BeginWriteAttribute("class", " class=\"", 6862, "\"", 6907, 2);
#nullable restore
#line 119 "D:\Proyectos\carnes-enequipo\en_equipo\Productivo\Productivo.Web\Views\Shared\_Contact.cshtml"
WriteAttributeValue("", 6870, Settings.Theme.IconPrefix, 6870, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6898, "fa-phone", 6899, 9, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<div class=\"slide-backdrop\" data-action=\"toggle\" data-class=\"slide-on-mobile-left-show\" data-target=\"#js-chat-contact\"></div> ");
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
