#pragma checksum "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75bea5bc6fdcd569013c4407b170f15e75e13253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navigation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75bea5bc6fdcd569013c4407b170f15e75e13253", @"/Views/Shared/Components/Navigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Navigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartNavigation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
  
    var pageName = ViewData["PageName"]?.ToString().ToLower();

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul id=\"js-nav-menu\" class=\"nav-menu\">\r\n");
#nullable restore
#line 6 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
     foreach (var group in Model.Lists)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
         if (group.Items.Any())
        {
            var groups = group.Items.Select(x => x.Href.ToPage()).Where(x => !x.IsVoid()).ToList();

            group.Items.ForEach(item =>
            {
                var result = item.Items?.Select(x => x.Href.ToPage()).Where(x => !x.IsVoid()).ToList();
                if (result?.Any() == true)
                {
                    groups = groups.Concat(result).ToList();
                }
            });

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 667, "\"", 724, 1);
#nullable restore
#line 20 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 675, groups.Contains(pageName) ? "active open" : "", 675, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 755, "\"", 775, 1);
#nullable restore
#line 21 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 763, group.Title, 763, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 21 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                              Write(group.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 832, "\"", 851, 1);
#nullable restore
#line 22 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 840, group.Icon, 840, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 23 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                      Write(group.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 23 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                   Write(group.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                     if (group.Span.HasValue())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span");
            BeginWriteAttribute("class", " class=\"", 1060, "\"", 1085, 1);
#nullable restore
#line 26 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 1068, group.Span.Class, 1068, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                   Write(group.Span.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n                <ul>\r\n");
#nullable restore
#line 30 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                      
                        foreach (var item in group.Items)
                        {
                            var items = item.Items?.Select(x => x.Href.ToPage()).Where(x => !x.IsVoid()).ToList();

                            if (item.Disabled)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li class=\"disabled\">\r\n                                ");
#nullable restore
#line 39 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                       
                            }
                            else
                            {
                                if (items?.Any() == true)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li");
            BeginWriteAttribute("class", " class=\"", 1907, "\"", 1993, 1);
#nullable restore
#line 46 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 1915, items.Contains(pageName) || item.IsRelatedTo(pageName) ? "active open" : "", 1915, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 47 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                           
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li");
            BeginWriteAttribute("class", " class=\"", 2233, "\"", 2290, 1);
#nullable restore
#line 52 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2241, pageName == item.Href.ToPage() ? "active" : "", 2241, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 53 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                           
                                }
                            }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2475, "\"", 2493, 1);
#nullable restore
#line 57 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2482, item.Route, 2482, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2494, "\"", 2513, 1);
#nullable restore
#line 57 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2502, item.Title, 2502, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 2514, "\"", 2535, 1);
#nullable restore
#line 57 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2523, item.Target, 2523, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 57 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                             Write(item.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 58 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                      Write(item.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 58 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                  Write(item.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                     if (item.Span.HasValue())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span");
            BeginWriteAttribute("class", " class=\"", 2831, "\"", 2855, 1);
#nullable restore
#line 61 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2839, item.Span.Class, 2839, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                  Write(item.Span.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\r\n                            ");
#nullable restore
#line 64 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                   
                            if (item.Items?.Any() == true)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <ul>\r\n");
#nullable restore
#line 69 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                         foreach (var subItem in item.Items)
                                        {
                                            if (subItem.Disabled)
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <li class=\"disabled\">\r\n                                                ");
#nullable restore
#line 75 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                       
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <li");
            BeginWriteAttribute("class", " class=\"", 3846, "\"", 3906, 1);
#nullable restore
#line 80 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 3854, pageName == subItem.Href.ToPage() ? "active" : "", 3854, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 81 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                       
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 4060, "\"", 4081, 1);
#nullable restore
#line 83 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4067, subItem.Route, 4067, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4082, "\"", 4104, 1);
#nullable restore
#line 83 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4090, subItem.Title, 4090, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 4105, "\"", 4129, 1);
#nullable restore
#line 83 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4114, subItem.Target, 4114, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 83 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                                                  Write(subItem.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 84 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                  Write(subItem.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 84 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                 Write(subItem.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </a>\r\n                                        ");
            WriteLiteral("</li>\r\n");
#nullable restore
#line 87 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                ");
#nullable restore
#line 89 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                       
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral("</li>\r\n");
#nullable restore
#line 92 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </li>\r\n");
#nullable restore
#line 96 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
        }
        else
        {
            if (group.Type == ItemType.Category)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-title\">");
#nullable restore
#line 101 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                 Write(group.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 102 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 4909, "\"", 4967, 1);
#nullable restore
#line 105 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4917, pageName == group.Href.ToPage() ? "active" : "", 4917, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4993, "\"", 5012, 1);
#nullable restore
#line 106 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 5000, group.Route, 5000, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5013, "\"", 5033, 1);
#nullable restore
#line 106 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 5021, group.Title, 5021, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 5034, "\"", 5056, 1);
#nullable restore
#line 106 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 5043, group.Target, 5043, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 106 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                    Write(group.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 5117, "\"", 5136, 1);
#nullable restore
#line 107 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 5125, group.Icon, 5125, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 108 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                          Write(group.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 108 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
                                                                       Write(group.Title.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 111 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "E:\Proyectos\en_equipo\Productivo\Productivo.Web\Views\Shared\Components\Navigation\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartNavigation> Html { get; private set; }
    }
}
#pragma warning restore 1591
