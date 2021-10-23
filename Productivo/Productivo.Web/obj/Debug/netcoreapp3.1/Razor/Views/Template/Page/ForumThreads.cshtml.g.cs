#pragma checksum "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Page\ForumThreads.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0262e2288e8c6d19b3c8b8e5d145853652d41fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Page_ForumThreads), @"mvc.1.0.view", @"/Views/Template/Page/ForumThreads.cshtml")]
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
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0262e2288e8c6d19b3c8b8e5d145853652d41fb3", @"/Views/Template/Page/ForumThreads.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Page_ForumThreads : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Page\ForumThreads.cshtml"
   
	ViewData["Title"] = "Item";
	ViewData["PageName"] = "page_forum_threads";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-plus-circle'></i>  Forum: <span class='fw-300'>Threads</span>";
	ViewData["PageDescription"] = "Forum threads page";
	ViewData["Category1"] = "Page Views";
	ViewData["Category2"] = "Forum Layouts";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral(@"<div class=""row"">
	<div class=""col-xl-12"">
		<div class=""input-group input-group-lg mb-g"">
			<input type=""text"" class=""form-control shadow-inset-2"" placeholder=""Search Threads"">
			<div class=""input-group-append"">
				<span class=""input-group-text""><i");
            BeginWriteAttribute("class", " class=\"", 623, "\"", 669, 2);
#nullable restore
#line 15 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Page\ForumThreads.cshtml"
WriteAttributeValue("", 631, Settings.Theme.IconPrefix, 631, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 659, "fa-search", 660, 10, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
			</div>
		</div>
		<div class=""card mb-g border shadow-0"">
			<div class=""card-header"">
				<div class=""row no-gutters align-items-center"">
					<div class=""col"">
						<span class=""h6 font-weight-bold text-uppercase"">Account information & Security</span>
					</div>
					<div class=""col d-flex align-items-center"">
						<a href=""javascript:void(0);"" class=""btn btn-success shadow-0 btn-sm ml-auto flex-shrink-0"">New Thread</a>
					</div>
				</div>
			</div>
			<div class=""card-header p-0"">
				<div class=""row no-gutters row-grid align-items-stretch"">
					<div class=""col-12 col-md"">
						<div class=""text-uppercase text-muted py-2 px-3"">Title</div>
					</div>
					<div class=""col-sm-6 col-md-2 col-xl-1 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Replies</div>
					</div>
					<div class=""col-sm-6 col-md-3 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Last update</div>
					</div>
				</div>
			</div>
			<div clas");
            WriteLiteral(@"s=""card-body p-0"">
				<div class=""row no-gutters row-grid"">
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
											Lorem ipsum dolor sit amet, consectetur adipiscing elit <span class=""badge badge-warning ml-auto"">Sticky</span>
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">c_lantern</a> on January 21, 2019 ");
            WriteLiteral(@"@12:30PM
										</div>
									</div>
									<div class=""d-flex"">
										<ul class=""pagination pagination-xs mb-0 mt-3 align-self-end"">
											<li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
											<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
											<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
											<li class=""paginate_button page-item disabled px-0"">…</li>
											<li class=""page-item""><a class=""page-link"" href=""#"">7</a></li>
											<li class=""page-item""><a class=""page-link"" href=""#"">25</a></li>
											<li class=""page-item"">
												<a class=""page-link"" href=""#"" aria-label=""Next"">
													<span aria-hidden=""true"">Last page</span>
												</a>
											</li>
										</ul>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">72 <i>Replies</i></span>
									<");
            WriteLiteral(@"span class=""d-block text-muted"">4314 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-admin.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Nam at justo magna. Aenean facilisis ultricies turpis
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 12:13 <a href=""javascript:void(0)"" class=""text-info"">c_lantern</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid a");
            WriteLiteral(@"lign-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
											Vestibulum molestie, ipsum vitae feugiat lacinia
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">jamie</a> on January 12, 2019 ");
            WriteLiteral(@"@4:23PM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">15 <i>Replies</i></span>
									<span class=""d-block text-muted"">4314 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-m.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Morbi id enim a ex gravida dignissim nec eu massa 
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 06:01 <a ");
            WriteLiteral(@"href=""javascript:void(0)"" class=""text-info"">jamie</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
										Nam viverra diam magna, eget lobortis orci tincidunt sed <span class=""badge badge-danger ml-auto""><i");
            BeginWriteAttribute("class", " class=\"", 6393, "\"", 6437, 2);
#nullable restore
#line 143 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Page\ForumThreads.cshtml"
WriteAttributeValue("", 6401, Settings.Theme.IconPrefix, 6401, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6429, "fa-lock", 6430, 8, true);
            EndWriteAttribute();
            WriteLiteral("></i> <span class=\"ml-1 hidden-md-down\">Locked</span></span>\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"d-block text-muted fs-sm\">\r\n\t\t\t\t\t\t\t\t\t\t\tStarted by <a href=\"javascript:void(0);\" class=\"text-info\">maggie</a> on February 17, 2019 ");
            WriteLiteral(@"@8:01AM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">764 <i>Replies</i></span>
									<span class=""d-block text-muted"">534 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-danger status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-g.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Duis placerat in sapien et placerat. Duis quis feugiat leo. Curabitur laoreet ex nec odio interdum
											</a>
											<div class=""text-muted smal");
            WriteLiteral(@"l text-truncate"">
												Today, 12:25 <a href=""javascript:void(0)"" class=""text-info"">josekras_alma</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12 disabled"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
										Proin vehicula nibh a nisl porta laoreet <span class=""badge badge-secondary ml-auto"">Disabled</span>
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">larry85</a> on December 12, 2019 ");
            WriteLiteral(@"@12:30PM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">87 <i>Replies</i></span>
									<span class=""d-block text-muted"">674 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-j.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											 Praesent mollis congue bibendum. Etiam ipsum augue, sodales id metus a, molestie hendrerit felis.
											</a>
											<div class=""text-muted sma");
            WriteLiteral(@"ll text-truncate"">
												Today, 05:25 <a href=""javascript:void(0)"" class=""text-info"">lambert</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
										Nulla auctor hendrerit purus, sit amet lacinia tellus placerat nec.
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">gi_34</a> on January 01, 2019 ");
            WriteLiteral(@"@2:30PM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">731<i>Replies</i></span>
									<span class=""d-block text-muted"">1246 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-warning status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-k.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Proin non felis lobortis, porta arcu a, iaculis arcu. Morbi tincidunt non ante et fermentum
											</a>
											<div class=""text-muted small text");
            WriteLiteral(@"-truncate"">
												Today, 05:25 <a href=""javascript:void(0)"" class=""text-info"">elmo</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
										Donec tincidunt augue auctor, ullamcorper urna ac
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">zico03</a> on August 25, 2019 ");
            WriteLiteral(@"@7:45PM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">3943<i>Replies</i></span>
									<span class=""d-block text-muted"">9843 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-a.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Sed felis eros, facilisis eu cursus at, efficitur et felis
											</a>
											<div class=""text-muted small text-truncate"">
												Today, ");
            WriteLiteral(@"05:25 <a href=""javascript:void(0)"" class=""text-info"">katty60</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
										Nullam in dictum lacus. Nulla auctor hendrerit purus, sit amet lacinia tellus placerat nec
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">c_lantern</a> on January 21, 2019 ");
            WriteLiteral(@"@12:30PM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">38<i>Replies</i></span>
									<span class=""d-block text-muted"">55 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-danger status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-h.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Phasellus quis sem diam. Sed commodo metus in ultrices consequat
											</a>
											<div class=""text-muted small text-truncate"">
												Today");
            WriteLiteral(@", 05:25 <a href=""javascript:void(0)"" class=""text-info"">laigma76</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex flex-column"">
										<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-flex align-items-start"">
										Sit amet lacinia tellus placerat nec. Nunc condimentum
										</a>
										<div class=""d-block text-muted fs-sm"">
											Started by <a href=""javascript:void(0);"" class=""text-info"">lambert89</a> on March 12, 2019 ");
            WriteLiteral(@"@7:30AM
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">24<i>Replies</i></span>
									<span class=""d-block text-muted"">100 <i>Views</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-i.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											 ullamcorper cursus. Proin sodales odio sed aliquet pulvinar. Duis ipsum erat, ultricies a dolor non, tempor dictum ante
											</a>
											<div class=""text-mute");
            WriteLiteral(@"d small text-truncate"">
												Today, 05:25 <a href=""javascript:void(0)"" class=""text-info"">laigma76</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<ul class=""pagination mt-3"">
			<li class=""page-item disabled"">
				<a class=""page-link"" href=""#"" aria-label=""Previous"">
					<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 16895, "\"", 16947, 2);
#nullable restore
#line 377 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Page\ForumThreads.cshtml"
WriteAttributeValue("", 16903, Settings.Theme.IconPrefix, 16903, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 16931, "fa-chevron-left", 16932, 16, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
				</a>
			</li>
			<li class=""page-item active"" aria-current=""page"">
				<span class=""page-link"">
					1
					<span class=""sr-only"">(current)</span>
				</span>
			</li>
			<li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
			<li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
			<li class=""page-item"">
				<a class=""page-link"" href=""#"" aria-label=""Next"">
					<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 17389, "\"", 17442, 2);
#nullable restore
#line 390 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Page\ForumThreads.cshtml"
WriteAttributeValue("", 17397, Settings.Theme.IconPrefix, 17397, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 17425, "fa-chevron-right", 17426, 17, true);
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n\t\t\t\t</a>\r\n\t\t\t</li>\r\n\t\t</ul>\r\n\t</div>\r\n</div>\r\n");
            DefineSection("ScriptsBlock", async() => {
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
