#pragma checksum "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1870cb7092a95576db1fc5d196f9ecbc7a2064c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Page_ForumList), @"mvc.1.0.view", @"/Views/Template/Page/ForumList.cshtml")]
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
#line 1 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\_ViewImports.cshtml"
using Productivo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1870cb7092a95576db1fc5d196f9ecbc7a2064c", @"/Views/Template/Page/ForumList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Page_ForumList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
   
	ViewData["Title"] = "List";
	ViewData["PageName"] = "page_forum_list";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-plus-circle'></i>  Forum: <span class='fw-300'>List</span>";
	ViewData["PageDescription"] = "Forum list page";
	ViewData["Category1"] = "Page Views";
	ViewData["Category2"] = "Forum";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
            }
            );
            WriteLiteral(@"<div class=""row"">
	<div class=""col-xl-12"">
		<div class=""input-group input-group-lg mb-g"">
			<input type=""text"" class=""form-control shadow-inset-2"" placeholder=""Search topics"">
			<div class=""input-group-append"">
				<span class=""input-group-text""><i");
            BeginWriteAttribute("class", " class=\"", 605, "\"", 651, 2);
#nullable restore
#line 15 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
WriteAttributeValue("", 613, Settings.Theme.IconPrefix, 613, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 641, "fa-search", 642, 10, true);
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
			</div>
		</div>
		<div class=""card mb-g border shadow-0"">
			<div class=""card-header"">
				<div class=""row no-gutters align-items-center"">
					<div class=""col"">
						<span class=""h6 font-weight-bold text-uppercase"">General</span>
					</div>
					<div class=""col d-flex"">
						<a href=""javascript:void(0);"" class=""btn btn-outline-success btn-sm ml-auto mr-2 flex-shrink-0"">Add</a>
						<a href=""javascript:void(0);"" class=""btn btn-outline-danger btn-sm flex-shrink-0"">Edit</a>
					</div>
				</div>
			</div>
			<div class=""card-header p-0"">
				<div class=""row no-gutters row-grid align-items-stretch"">
					<div class=""col-12 col-md"">
						<div class=""text-uppercase text-muted py-2 px-3"">Title</div>
					</div>
					<div class=""col-sm-6 col-md-2 col-xl-1 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Status</div>
					</div>
					<div class=""col-sm-6 col-md-3 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Last posts</div");
            WriteLiteral(@">
					</div>
				</div>
			</div>
			<div class=""card-body p-0"">
				<div class=""row no-gutters row-grid"">
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base-2 icon-stack-3x color-primary-400""></i>
											<i class=""base-10 text-white icon-stack-1x""></i>
											<i class=""ni md-profile color-primary-800 icon-stack-2x""></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Account information & Security <span class=""badge badge-warning rounded"">Sticky</span>
											</a>
											<div class=""d-block text-muted fs-sm"">
												Fusce at velit viverra, luctus augue nec, dapibus urna
											</div>
										</div>
									</div>
								</div>
							</div>
		");
            WriteLiteral(@"					<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">243 <i>Topics</i></span>
									<span class=""d-block text-muted"">407 <i>Posts</i></span>
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
											Duis vitae sapien urna. Proin pellentesque laoreet ligula pharetra semper. 
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 12:12 <a href=""javascript:void(0)"" class=""text-info"">katty60</");
            WriteLiteral(@"a>
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
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base-7 icon-stack-3x color-primary-500""></i>
											<i class=""base-7 icon-stack-2x color-primary-700""></i>
											<i class=""ni ni-graph icon-stack-1x text-white""></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Global Stats
											</a>
											<div class=""d-block text-muted fs-sm"">
												Sed felis eros, facilisis eu cursus at, efficitur et felis
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div");
            WriteLiteral(@" class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">64 <i>Topics</i></span>
									<span class=""d-block text-muted"">102 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-b.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Nunc id varius nisl, a feugiat eros
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 05:01 <a href=""javascript:void(0)"" class=""text-info"">gsnoopy520</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					<");
            WriteLiteral(@"/div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base-19 icon-stack-3x color-primary-400""></i>
											<i class=""base-7 icon-stack-2x color-primary-300""></i>
											<i class=""base-7 icon-stack-1x fs-xxl color-primary-200""></i>
											<i class=""base-7 icon-stack-1x color-primary-500""></i>
											<i");
            BeginWriteAttribute("class", " class=\"", 6313, "\"", 6394, 5);
#nullable restore
#line 147 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
WriteAttributeValue("", 6321, Settings.Theme.IconPrefix, 6321, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6349, "fa-globe", 6350, 9, true);
            WriteAttributeValue(" ", 6358, "icon-stack-1x", 6359, 14, true);
            WriteAttributeValue(" ", 6372, "text-white", 6373, 11, true);
            WriteAttributeValue(" ", 6383, "opacity-85", 6384, 11, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Global Accouncements
											</a>
											<div class=""d-block text-muted fs-sm"">
												Curabitur scelerisque ipsum nec dui lacinia bibendum
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">124 <i>Topics</i></span>
									<span class=""d-block text-muted"">314 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-c.png'); backgroun");
            WriteLiteral(@"d-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Integer id eros vitae leo semper sodales vel a est.
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 02:25 <a href=""javascript:void(0)"" class=""text-info"">lerem03</a>
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
		<div class=""card mb-g border shadow-0"">
			<div class=""card-header"">
				<div class=""row no-gutters align-items-center"">
					<div class=""col"">
						<span class=""h6 font-weight-bold text-uppercase"">Hospital Policy</span>
					</div>
					<div class=""col d-flex"">
						<a href=""javascript:void(0);"" class=""btn btn-outline-success btn-sm ml-auto mr-2 flex-shrink-0"">Add</a>
						<a href=""javascript:void(0);"" class=""btn btn-outline-danger btn-sm flex-shrink-0"">Edit</a>
					</div>
		");
            WriteLiteral(@"		</div>
			</div>
			<div class=""card-header p-0"">
				<div class=""row no-gutters row-grid align-items-stretch"">
					<div class=""col-12 col-md"">
						<div class=""text-uppercase text-muted py-2 px-3"">Title</div>
					</div>
					<div class=""col-sm-6 col-md-2 col-xl-1 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Status</div>
					</div>
					<div class=""col-sm-6 col-md-3 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Last posts</div>
					</div>
				</div>
			</div>
			<div class=""card-body p-0"">
				<div class=""row no-gutters row-grid"">
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base base-2 icon-stack-3x opacity-100 color-info-800""></i> 
											<i class=""base base-3 icon-stack-2x opacity-100 color-info-500""></i> 
	");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 9479, "\"", 9564, 5);
#nullable restore
#line 223 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
WriteAttributeValue("", 9487, Settings.Theme.IconPrefix, 9487, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9515, "fa-user-md", 9516, 11, true);
            WriteAttributeValue(" ", 9526, "icon-stack-1x", 9527, 14, true);
            WriteAttributeValue(" ", 9540, "opacity-100", 9541, 12, true);
            WriteAttributeValue(" ", 9552, "color-white", 9553, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Patients & Staff
											</a>
											<div class=""d-block text-muted fs-sm"">
												Fusce at velit viverra, luctus augue nec, dapibus urna
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">72 <i>Topics</i></span>
									<span class=""d-block text-muted"">89 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-d.png'); background-si");
            WriteLiteral(@"ze: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Nam at justo magna. Aenean facilisis ultricies turpis
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 08:13 <a href=""javascript:void(0)"" class=""text-info"">erakalambert</a>
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
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base base-7 icon-stack-3x opacity-100 color-success-800""></i> 
											<i class=""base base-4 icon-stack-2x opacity-100 color-success-600""></i> 
											<i");
            BeginWriteAttribute("class", " class=\"", 11514, "\"", 11598, 5);
#nullable restore
#line 269 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
WriteAttributeValue("", 11522, Settings.Theme.IconPrefix, 11522, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11550, "fa-medkit", 11551, 10, true);
            WriteAttributeValue(" ", 11560, "icon-stack-1x", 11561, 14, true);
            WriteAttributeValue(" ", 11574, "opacity-100", 11575, 12, true);
            WriteAttributeValue(" ", 11586, "color-white", 11587, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Pharmacy & Medical Equipments
											</a>
											<div class=""d-block text-muted fs-sm"">
												Nulla laoreet dignissim justo, id viverra nibh suscipit in. 
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">99 <i>Topics</i></span>
									<span class=""d-block text-muted"">72 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-f.p");
            WriteLiteral(@"ng'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											 Integer felis justo, condimentum vitae pharetra vel, hendrerit eget orci. 
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 06:01 <a href=""javascript:void(0)"" class=""text-info"">elisamury</a>
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
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base base-15 icon-stack-3x opacity-100 color-success-800""></i>
											<i class=""base base-10 icon-stack-2x opacity-100 color-success-600""></i> 
											<i");
            BeginWriteAttribute("class", " class=\"", 13587, "\"", 13676, 5);
#nullable restore
#line 315 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
WriteAttributeValue("", 13595, Settings.Theme.IconPrefix, 13595, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 13623, "fa-dollar-sign", 13624, 15, true);
            WriteAttributeValue(" ", 13638, "icon-stack-1x", 13639, 14, true);
            WriteAttributeValue(" ", 13652, "opacity-100", 13653, 12, true);
            WriteAttributeValue(" ", 13664, "color-white", 13665, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Billing Department
											</a>
											<div class=""d-block text-muted fs-sm"">
												Curabitur scelerisque ipsum nec dui lacinia bibendum
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">88 <i>Topics</i></span>
									<span class=""d-block text-muted"">109 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-g.png'); background-s");
            WriteLiteral(@"ize: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Duis placerat in sapien et placerat. Duis quis feugiat leo. Curabitur laoreet ex nec odio interdum
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 12:25 <a href=""javascript:void(0)"" class=""text-info"">josekras_alma</a>
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
									<div class=""d-flex"">
										<span class=""icon-stack display-4 mr-3 flex-shrink-0"">
											<i class=""base base-3 icon-stack-3x opacity-100 color-warning-800""></i> 
											<i class=""base base-3 icon-stack-2x opacity-100 color-warning-400""></i> 
											<i");
            BeginWriteAttribute("class", " class=\"", 15673, "\"", 15764, 5);
#nullable restore
#line 361 "C:\Users\daniel.gomez\Documents\MEGA\Trabajos Externos\Estadistico\Productivo\Productivo.Web\Views\Template\Page\ForumList.cshtml"
WriteAttributeValue("", 15681, Settings.Theme.IconPrefix, 15681, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 15709, "fa-question", 15710, 12, true);
            WriteAttributeValue(" ", 15721, "icon-stack-1x", 15722, 14, true);
            WriteAttributeValue(" ", 15735, "opacity-100", 15736, 12, true);
            WriteAttributeValue(" ", 15747, "color-fusion-800", 15748, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
										</span>
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Miscellaneous, Lost & Found
											</a>
											<div class=""d-block text-muted fs-sm"">
												Phasellus pharetra felis et leo malesuada
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">50 <i>Topics</i></span>
									<span class=""d-block text-muted"">66 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-h.png'); background-size");
            WriteLiteral(@": cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											 Nunc id varius nisl, a feugiat eros. Nulla laoreet dignissim justo, id viverra nibh suscipit in. Curabitur scelerisque ipsum nec dui lacinia bibendum
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 05:25 <a href=""javascript:void(0)"" class=""text-info"">kraluakosh</a>
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
		<div class=""card mb-g border shadow-0"">
			<div class=""card-header"">
				<div class=""row no-gutters align-items-center"">
					<div class=""col"">
						<span class=""h6 font-weight-bold text-uppercase"">Hospital Staff (password protected)</span>
					</div>
					<div class=""col d-flex"">
						<a href=""javascript:void(0);"" class=""btn btn-outline-success btn-sm ml-auto mr-2 flex-shrink-0"">Add</a");
            WriteLiteral(@">
						<a href=""javascript:void(0);"" class=""btn btn-outline-danger btn-sm flex-shrink-0"">Edit</a>
					</div>
				</div>
			</div>
			<div class=""card-header p-0"">
				<div class=""row no-gutters row-grid align-items-stretch"">
					<div class=""col-12 col-md"">
						<div class=""text-uppercase text-muted py-2 px-3"">Title</div>
					</div>
					<div class=""col-sm-6 col-md-2 col-xl-1 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Status</div>
					</div>
					<div class=""col-sm-6 col-md-3 hidden-md-down"">
						<div class=""text-uppercase text-muted py-2 px-3"">Last posts</div>
					</div>
				</div>
			</div>
			<div class=""card-body p-0"">
				<div class=""row no-gutters row-grid"">
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex"">
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-bl");
            WriteLiteral(@"ock"">
											Physician (ER doctors, surgeons, hospitalists) <span class=""badge badge-success"">Has Access</span>
											</a>
											<div class=""d-block text-muted fs-sm"">
												Proin pellentesque laoreet ligula pharetra semper
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">1024 <i>Topics</i></span>
									<span class=""d-block text-muted"">5431 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-admin.png'); background-size: cover;""></span>
										</div>
										<div cl");
            WriteLiteral(@"ass=""flex-1 min-width-0"">
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
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex"">
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Nurse (CRNA, RN, LPN/LVN, CNS) <span class=""badge badge-success"">Has Access</span>
											</a>
											<div class=""d-block text-muted fs-sm"">
												Nulla laoreet dignissim justo, id viverra nibh suscipit in. 
											</div>
										</div>
									</");
            WriteLiteral(@"div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">1205 <i>Topics</i></span>
									<span class=""d-block text-muted"">4314 <i>Posts</i></span>
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
												Today, 06:01 <a href=""javascript:void(0)"" class=""text");
            WriteLiteral(@"-info"">jamie</a>
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
									<div class=""d-flex"">
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Therapist (Physical Therapist, Radiation Therapist) <span class=""badge badge-danger"">Password</span>
											</a>
											<div class=""d-block text-muted fs-sm"">
												Curabitur scelerisque ipsum nec dui lacinia bibendum
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">764 <i>Topics</i></span>
									<span class=""d-block text-muted"">534 <i>Posts</i></span>
								</div>
							</div>
");
            WriteLiteral(@"							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-g.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate text-blur"">
											Duis placerat in sapien et placerat. Duis quis feugiat leo. Curabitur laoreet ex nec odio interdum
											</a>
											<div class=""text-muted small text-truncate"">
												Today, 12:25 <a href=""javascript:void(0)"" class=""text-info"">josekras_alma</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-12"">
						<div class=""row no-gutters row-grid align-items-stretch"">
							<div ");
            WriteLiteral(@"class=""col-md"">
								<div class=""p-3"">
									<div class=""d-flex"">
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Pharmacists <span class=""badge badge-danger"">Password</span>
											</a>
											<div class=""d-block text-muted fs-sm"">
												Duis placerat in sapien et placerat
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">87 <i>Topics</i></span>
									<span class=""d-block text-muted"">674 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" s");
            WriteLiteral(@"tyle=""background-image:url('/img/demo/avatars/avatar-j.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate text-blur"">
											 Praesent mollis congue bibendum. Etiam ipsum augue, sodales id metus a, molestie hendrerit felis.
											</a>
											<div class=""text-muted small text-truncate"">
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
									<div class=""d-flex"">
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Surgery & Labworks <span class=""badge badge-success"">Has Access</span>
											</a>
	");
            WriteLiteral(@"										<div class=""d-block text-muted fs-sm"">
												Duis placerat in sapien et placerat
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span class=""d-block text-muted"">731<i>Topics</i></span>
									<span class=""d-block text-muted"">1246 <i>Posts</i></span>
								</div>
							</div>
							<div class=""col-8 col-md-3 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<div class=""d-flex align-items-center"">
										<div class=""d-inline-block align-middle status status-success status-sm mr-2"">
											<span class=""profile-image-md rounded-circle d-block"" style=""background-image:url('/img/demo/avatars/avatar-k.png'); background-size: cover;""></span>
										</div>
										<div class=""flex-1 min-width-0"">
											<a href=""javascript:void(0)"" class=""d-block text-truncate"">
											Proin non felis lobortis, porta arcu a, iaculi");
            WriteLiteral(@"s arcu. Morbi tincidunt non ante et fermentum
											</a>
											<div class=""text-muted small text-truncate"">
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
									<div class=""d-flex"">
										<div class=""d-inline-flex flex-column"">
											<a href=""javascript:void(0)"" class=""fs-lg fw-500 d-block"">
											Dietitian <span class=""badge badge-success"">Has Access</span>
											</a>
											<div class=""d-block text-muted fs-sm"">
												Sit amet luctus nulla suscipit. Phasellus pharetra felis
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-4 col-md-2 col-xl-1 hidden-md-down"">
								<div class=""p-3 p-md-3"">
									<span c");
            WriteLiteral(@"lass=""d-block text-muted"">3943<i>Topics</i></span>
									<span class=""d-block text-muted"">9843 <i>Posts</i></span>
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
												Today, 05:25 <a href=""javascript:void(0)"" class=""text-info"">katty60</a>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div");
            WriteLiteral(">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n\t<script>\r\n\t\t$(document).ready(function () {\r\n\t\t});\r\n\t</script>\r\n");
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