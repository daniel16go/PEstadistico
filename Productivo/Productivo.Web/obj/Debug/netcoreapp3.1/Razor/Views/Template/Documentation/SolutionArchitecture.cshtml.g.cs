#pragma checksum "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Documentation\SolutionArchitecture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8bc31af52468a6ec9317c478f4a6bf29bbda15c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Documentation_SolutionArchitecture), @"mvc.1.0.view", @"/Views/Template/Documentation/SolutionArchitecture.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8bc31af52468a6ec9317c478f4a6bf29bbda15c", @"/Views/Template/Documentation/SolutionArchitecture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4063a92509016e34f5fa38813b43f5c4dd013", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Documentation_SolutionArchitecture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "documentation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "customizations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fragment", "Datastore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Customizations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fragment", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danii\Documents\GitHub\PEstadistico\Productivo\Productivo.Web\Views\Template\Documentation\SolutionArchitecture.cshtml"
  
    ViewData["Title"] = "Solution Architecture";
    ViewData["PageName"] = "documentation_solution_architecture";
    ViewData["Heading"] = "<i class='fal fa-book'></i> Documentation: <span class='fw-300'>Solution Architecture</span>";
    ViewData["Category1"] = "Documentation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row documentation"">
    <div class=""col-xl-12"">
        <div class=""panel"">
            <div class=""panel-hdr"">
                <h2>Productivo for ASP.NET Core 3.1 - Documentation</h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content"">
<h3>Tooling</h3>
<p>The Productivo for ASP.NET Core Theme is targeting ASP.NET Core 3.1 and has been verified to work with Visual Studio 2019 Community, Professional and Enterprise. Depending how comfortable you are with your development tools, the project can also be used with <a href=""https://code.visualstudio.com"">Visual Studio Code</a> and <a href=""https://www.jetbrains.com/rider"">Jetbrains Rider</a>.</p>
<blockquote>
<p>Note: ASP.NET Core 3.x does not support Visual Studio 2017. Although you could still use .NET Core 2.1 to host your project we high recommend you upgrade when this choice is available to you.</p>
</blockquote>
<h3>Dependencies</h3>
<p>Productivo for ASP.NET Core relies on t");
            WriteLiteral(@"he following frameworks:</p>
<ul>
<li><strong>Bootstrap 4.5</strong>: Responsive layouts on mobile devices and beyond</li>
<li><strong>FontAwesome 5.13</strong>: A vast library of scalable vector icons (Pro included!)</li>
<li><strong>jQuery 3.5</strong>: ubiquitous JavaScript library that supports all major browsers</li>
<li><strong>Productivo 4.5</strong>: The heart and back-bone of this template</li>
</ul>
<h3>Cloud services</h3>
<p>The ASP.NET Core project was designed with hosting on the Cloud in mind and can easily be expanded to suit any cloud platform, such as <a href=""https://aws.amazon.com"">AWS</a> or <a href=""https://azure.microsoft.com/en-us"">Azure</a>. The Live Preview of the website is hosted on Azure and the following services were used for the application when deploying to Azure:</p>
<ul>
<li><strong>Azure App Service</strong>: For providing serverless hosting of the .NET Core web application (on Linux Unbuntu!)</li>
<li><strong>SQL Serverless</strong>: Serverless data storage of re");
            WriteLiteral(@"lational data used by the application when it is being used</li>
<li><strong>Azure Storage</strong>: Storage of uploaded data and/or static assets required by the application (optional, but recommended for static content)</li>
</ul>
<blockquote>
<p><strong>Note:</strong> An on-premise database scenario is also supported and can be just as easily configured by adjusting the connection string and data provider within the Startup of the Application!</p>
</blockquote>
<p>Please see the ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bc31af52468a6ec9317c478f4a6bf29bbda15c8584", async() => {
                WriteLiteral("Changing the Data Store");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Fragment = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" page for more details on how to configure this part of the the Application.</p>
</div></div></div><div class=""panel""><div class=""panel-hdr""><h2 id=""AuthenticationandAuthorization"">Authentication and Authorization</h2></div><div class=""panel-container show""><div class=""panel-content"">
<p>Productivo for ASP.NET Core uses <strong>ASP.NET Core Identity</strong> for providing support for common authentication scenario's. Not only does this give you an out of the box secure experience but also showcases how we were able to have these two frameworks seemlessly work together and co-exist as they were shaped to match the <strong>Productivo 4</strong> Theme look and feel.</p>
<blockquote>
<p><strong>Hint:</strong> Out of the box <strong>ASP.NET Core Identity</strong> uses a <code>string</code> for the primary key of the default schema tables. If you wish to change this to <code>int</code> please check the instructions on the ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bc31af52468a6ec9317c478f4a6bf29bbda15c11107", async() => {
                WriteLiteral("Customizations");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Fragment = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" page.</p>
</blockquote>
<p>All of this, resting comfortably on the back of <a href=""https://docs.microsoft.com/en-us/ef/core/"">EntityFramework Core</a> which has been setup with Migration support to get you started on adding your own tables and entity classes!</p>
<p>Storing the data is not in any way limited to a specific data store, however the project was written with <code>SQLite</code> as the storage provider as this comes out of the box when generating a .NET Core project using the <a href=""https://docs.microsoft.com/en-us/dotnet/core/tools"">.NET CLI</a>. It will not impose any restriction on using cloud-based database services that provide SQL Server instances, MySql, or cloud specific data stores such as Aurora, Cosmos DB and Dynamo DB.</p>
<blockquote>
<p><strong>Note:</strong> If you are uncomfortable using <strong>EntityFramework Core</strong> then using an alternative ORM such as <a href=""https://stackexchange.github.io/Dapper"">Dapper</a> is certainly also possible, but <strong>will</strong>");
            WriteLiteral(@" take time and additional customizations to get you started and progressed equally with what comes out-of-the-box as part of the template when the default setup is used.</p>
</blockquote>
<blockquote>
<p><strong>Hint:</strong> For more ORM options please see: <a href=""https://www.slant.co/topics/16667/~orms-for-c"">What are popular ORMs for C#</a></p>
</blockquote>
<h3>Authorization</h3>
<p>Most pages on the site are accessible anonymously, meaning, you do not have to login first in order to see the content of the pages. However, some pages <strong>are</strong> enabled to be viewable only by authenticated users. Typically this is done by specifying the <code>[Authorize]</code> attribute on either your <strong>Controller</strong> or <strong>PageModel</strong> class.</p>
<p>Productivo for .NET Core makes use of the global filters to ensure that every page that does <strong>not</strong> have any attribute specified is marked for Authentication, as such that the user will have to login in order to see the c");
            WriteLiteral(@"ontent.</p>
<h4>Startup.cs</h4>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">services
    .AddControllersWithViews(options =&gt;
    {
        var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
        options.Filters.Add(new AuthorizeFilter(policy));
    });
</pre>
<p>Here we can see that we are using Controllers and Views (MVC) and we build a specific policy to require authenticated users only by utilizing the <code>AuthorizationPolicyBuilder</code> class to build our required policy. We then add this to the <code>Filters</code> collection so that it is registered for each <code>Controller</code> class in the project.</p>
<h4>Razor Pages</h4>
<p>For Razor Pages this is done slightly different.</p>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">app.UseEndpoints(endpoints =&gt;
{
    endpoints.MapRazorPages().RequireAuthorization();
});
</pre>
<p>Here we simply add a call to <code>RequireAuthorization()</code> to provide the same type of functionality as shown");
            WriteLiteral(@" in the MVC example above this one.</p>
</div></div></div><div class=""panel""><div class=""panel-hdr""><h2 id=""Configuration"">Configuration</h2></div><div class=""panel-container show""><div class=""panel-content"">
<p>The project relies on configuration settings at runtime, such as whether to use a local database or a Azure SQL Database for data storage, whether to load sample data, default account information and/or determining which theme sections are visible by default. These setting are now stored in the <code>appSettings.json</code> file. However, doing this could make it easier to accidentally expose secrets and/or sensitive information, so please be aware of who has access to this information.</p>
<blockquote>
<p><strong>Important:</strong> When you publish the project to Azure or any other hosting provider, you should take care to protect these values.</p>
</blockquote>
<p>Previously the project included values for toggles features in the configuration through the use of an <code>ActionFilter</code>. ");
            WriteLiteral(@"After giving it some thought we decided it would be a better approach to provide these settings to you by using <strong>strong-typed</strong> setting classes instead.</p>
<h3>SmartSettings</h3>
<p>The settings that the <strong>Productivo for .NET Core</strong> application uses are mapped to the <code>SmartSettings.cs</code> class, located in the <strong>Models</strong> folder of the project.</p>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">&quot;SmartSettings&quot;: {
  &quot;Version&quot;: &quot;4.2.0&quot;,
  &quot;App&quot;: &quot;Productivo&quot;,
  &quot;AppName&quot;: &quot;Productivo WebApp&quot;,
  &quot;AppFlavor&quot;: &quot;ASP.NET Core 3.1&quot;,
  &quot;AppFlavorSubscript&quot;: &quot;.NET Core 3.1&quot;,
  &quot;Theme&quot;: {
    &quot;ThemeVersion&quot;: &quot;4.4.5&quot;,
    &quot;IconPrefix&quot;: &quot;fal&quot;,
    &quot;Logo&quot;: &quot;logo.png&quot;,
    &quot;User&quot;: &quot;Dr. Codex Lantern&quot;,
    &quot;Email&quot;: &quot;drlantern");
            WriteLiteral(@"@gotbootstrap.com&quot;,
    &quot;Twitter&quot;: &quot;codexlantern&quot;,
    &quot;Avatar&quot;: &quot;avatar-admin.png&quot;
  },
  &quot;Features&quot;: {
    &quot;AppSidebar&quot;: true,
    &quot;AppHeader&quot;: true,
    &quot;AppLayoutShortcut&quot;: true,
    &quot;AppFooter&quot;: true,
    &quot;ShortcutMenu&quot;: true,
    &quot;ChatInterface&quot;: true,
    &quot;LayoutSettings&quot;: true
  }
},
</pre>
<p>The setting values in the root of the <code>SmartSettings</code> node contains the base settings used throughout the Application to provide the name and context. The <code>Theme</code> section includes settings that are specific to the rendering of the Productivo Theme and assist with pre-filling the <strong>Login</strong> and <strong>Register</strong> page.</p>
<blockquote>
<p><strong>Warning:</strong> Please do <strong>not</strong> use this approach for your own project! Never expose sensitive information, such as user credentials in the source of your pages!</p>
</bloc");
            WriteLiteral(@"kquote>
<p>The <code>Features</code> section contains the Theme features that can be toggled on or off in order to limit what is visible/accessible when the application is started. When you add more features to your project and/or if you wish to include more sections of the Theme, feel free to add them here.</p>
<h4>Example</h4>
<p>One of the page sections that you might be inclined to hide could be the <strong>Settings</strong> panel that is accessed from the cogwheel on the right side of the Site. Although you could still expose this as part of a Management Portal, typically you would not want to expose this to every visitor of your site, or maybe you do, but let's assume for now that you don't.</p>
<h4>Using SmartSettings</h4>
<p>The first part of exposing the <code>SmartSettings</code> class is done in <code>Startup.cs</code></p>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">public void ConfigureServices(IServiceCollection services)
{
    services.Configure&lt;SmartSettings&gt;(Configuration.GetS");
            WriteLiteral(@"ection(SmartSettings.SectionName));

    // yoink!
}
</pre>
<p>Here we tell .NET to create and inject an instance of the <code>SmartSettings</code> class and bind the (public) properties to the values found in the <code>SmartSettings</code> section of the <code>appsettings.json</code> file. The output is added to the <code>ServiceCollection</code> which serves as a container with all of the registered types and instances made available to the Application using <a href=""https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1"">Dependency Injection</a>.</p>
<hr>
<p>Now that the <code>SmartSettings</code> class is registered through <a href=""https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1"">DI</a> we can make it available globally by <strong>injecting</strong> it in the <code>_ViewImports.cshtml</code> file.</p>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">");
            WriteLiteral("@using Productivo.Web\r\n");
            WriteLiteral("@using Productivo.Web.Extensions\r\n");
            WriteLiteral("@using Productivo.Web.Models\r\n");
            WriteLiteral("@inject SmartSettings Settings // &lt;--- Over here!\r\n");
            WriteLiteral("@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers\r\n");
            WriteLiteral(@"@addTagHelper *, Productivo.Web
</pre>
<p>And to wrap it up we reference the <code>Settings</code> variable from the injection step earlier and access the <code>Features</code> property, which exposes each listed feature element from the JSON file as a <code>boolean</code> property.</p>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">");
            WriteLiteral(@"@if (Settings.Features.LayoutSettings)
{
  &lt;div&gt;
    // ommitted for demonstration purpose
  &lt;/div&gt;
}
</pre>
<p>The <code>if</code>-statament checks whether the <strong>LayoutSettings</strong> feature is enabled before showing the rendered content inside.</p>
</div></div></div><div class=""panel""><div class=""panel-hdr""><h2 id=""TemplateStructure"">Template Structure</h2></div><div class=""panel-container show""><div class=""panel-content"">
<p>The application makes heavy use of both <a href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-3.1#sections"">Sections</a> and <a href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/views/partial"">Partials</a> which are an intricate part of the Razor engine for ASP.NET Core used by both MVC as well as Razor Pages. We ensured that the names of these components match those of the HTML Theme so that any information listed regarding these sections is still applicable and relevant to the .NET Core Flavor.</p>
<h3>Layout</h3>
");
            WriteLiteral(@"<p>The main layout of the Theme is defined in <code>/Views/Shared/_Layout.cshtml</code>.</p>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">&lt;!DOCTYPE html&gt;
&lt;partial name=&quot;_CopyrightHeader&quot;/&gt;
&lt;html lang=&quot;en&quot;&gt;
  &lt;head&gt;
    &lt;partial name=&quot;_Head&quot;/&gt;
    ");
            WriteLiteral("@RenderSection(&quot;HeadBlock&quot;, required: false)\r\n  &lt;/head&gt;\r\n  &lt;body class=&quot;mod-bg-1 mod-nav-link ");
            WriteLiteral(@"@ViewBag.PreemptiveClass&quot;&gt;
    &lt;partial name=&quot;_ScriptsLoadingSaving&quot;/&gt;
    &lt;div class=&quot;page-wrapper&quot;&gt;
      &lt;div class=&quot;page-inner&quot;&gt;
        &lt;partial name=&quot;_LeftPanel&quot;/&gt;
        &lt;div class=&quot;page-content-wrapper&quot;&gt;
          &lt;partial name=&quot;_PageHeader&quot;/&gt;
            &lt;main id=&quot;js-page-content&quot; role=&quot;main&quot; class=&quot;page-content&quot;&gt;
                &lt;partial name=&quot;_PageBreadcrumb&quot;/&gt;
                &lt;div class=&quot;subheader&quot;&gt;
                    &lt;partial name=&quot;_PageHeading&quot;/&gt;
                    ");
            WriteLiteral("@RenderSection(&quot;SubheaderBlock&quot;, required: false)\r\n                &lt;/div&gt;\r\n                ");
            WriteLiteral(@"@RenderBody()
            &lt;/main&gt;
          &lt;partial name=&quot;_PageContentOverlay&quot;/&gt;
          &lt;partial name=&quot;_PageFooter&quot;/&gt;
          &lt;partial name=&quot;_ShortcutModal&quot;/&gt;
          &lt;partial name=&quot;_ColorProfileReference&quot;/&gt;
        &lt;/div&gt;
      &lt;/div&gt;
    &lt;/div&gt;
    &lt;partial name=&quot;_ShortcutMenu&quot;/&gt;
    &lt;partial name=&quot;_ShortcutMessenger&quot;/&gt;
    &lt;partial name=&quot;_PageSettings&quot;/&gt;
    &lt;partial name=&quot;_GoogleAnalytics&quot;/&gt;
    &lt;partial name=&quot;_ScriptsBasePlugins&quot;/&gt;
    ");
            WriteLiteral(@"@RenderSection(&quot;ScriptsBlock&quot;, required: false)
  &lt;/body&gt;
&lt;/html&gt;
</pre>
<h3>Partials</h3>
<p>Each <code>&lt;partial /&gt;</code> element can be controlled by their respective <code>Feature</code> setting in the <code>appsettings.json</code> file (See <a href=""#Configuration"">Configuration</a>). Simply change <code>true</code> to <code>false</code> and the partial content will not be rendered. As an alternative, and/or when you simply do not wish to include a feature in its entirety, just remove the <code>partial</code> element from the <code>_Layout.cshtml</code> file and it will not be included.</p>
<h3>Sections</h3>
<p>The application uses <strong>Sections</strong> to denote dynamic content that can be influenced from within each content page inside the <strong>Views</strong> and/or <strong>Pages</strong> folder of the project.</p>
<p>The following sections are available in <code>_Layout.cshtml</code>:</p>
<table class=""table table-bordered"">
<thead>
<tr>
<th>Section</th>");
            WriteLiteral(@"
<th>Purpose</th>
<th>Reference</th>
<th style=""text-align:center"">Optional</th>
</tr>
</thead>
<tbody>
<tr>
<td>HeadBlock</td>
<td>Contains the page specific CSS files that are required</td>
<td><code>Line 6</code></td>
<td style=""text-align:center"">yes</td>
</tr>
<tr>
<td>SubheaderBlock</td>
<td>Contains the page specific heading content</td>
<td><code>Line 22</code></td>
<td style=""text-align:center"">yes</td>
</tr>
<tr>
<td>ScriptsBlock</td>
<td>Contains the page specific scripts and/or plugins that are required</td>
<td><code>Line 39</code></td>
<td style=""text-align:center"">yes</td>
</tr>
</tbody>
</table>
<p>This setup allows for referencing plugin specific CSS and JS files required by a page without having to include it in every page, even when it is not used at all. However, if you do have specific files that should be made available throughout the Application then you can use the <code>_Head.cshtml</code> file for styles and the <code>_ScriptsBasePlugins.cshtml</code> file f");
            WriteLiteral(@"or scripts.</p>
<h3>Content</h3>
<p>The majority of the included files are a direct representation of the associated page in the HTML Theme of Productivo. However, page specific <strong>style</strong> and/or <strong>script</strong> files are loaded in through the aforementioned <strong>sections</strong> defined in the <code>_Layout.cshtml</code> page.</p>
<h4>/Views/FormPlugins/Select2.cshtml</h4>
<pre class=""prettyprint lang-csharp mb-2 mt-0"">");
            WriteLiteral("@section HeadBlock {\r\n  &lt;link rel=&quot;stylesheet&quot; media=&quot;screen, print&quot; href=&quot;~/css/formplugins/select2/select2.bundle.css&quot;&gt;\r\n}\r\n\r\n&lt;!-- // page specific content there --&gt;\r\n\r\n");
            WriteLiteral(@"@section ScriptsBlock {
  &lt;script src=&quot;~/js/formplugins/select2/select2.bundle.js&quot;&gt;&lt;/script&gt;
  &lt;script&gt;
    $(document).ready(function () {
        $('.select2').select2();
    });
  &lt;/script&gt;
}
</pre>
<blockquote>
<p><strong>Note:</strong> The above example is a snippet from the <strong>FormPlugins/Select2</strong> page and shows how the <a href=""https://select2.org"">Select2</a> plugin specific stylesheet and script is included in order to properly render the example content.</p>
</blockquote>
<h3>Routing</h3>
<p>The routing between both the <strong>MVC</strong> and <strong>Razor Pages</strong> flavors is largely kept the same. This means that <code>/foo/bar</code> is routed to the same equivalent content page for both technologies. Routing for MVC is handled by the <strong>Action</strong> methods of each <code>Controller</code> class inside the <strong>/Controllers/</strong> folder. When Razor Pages is used however the route is determined based on conventions, ");
            WriteLiteral("and where needed can be specified as part of the <code>");
            WriteLiteral(@"@page</code> directive on the first line of the respective <code>.cshtml</code> file.</p>
<blockquote>
<p><strong>Note:</strong> Automatic highlighting of the current menu item is done by inspecting the current route; this applies to both the parent and child menu item. Although .NET Core has a <a href=""https://damienbod.com/2018/08/13/is-active-route-tag-helper-for-asp-net-mvc-core-with-razor-page-support"">community taghelper</a> to assist with this, the usage for how the Theme menu is currently rendered makes it impractical to use.</p>
</blockquote>
<hr>
<p>Copyright © 2020 by Walapa. All rights reserved. This documentation or any portion thereof
may not be reproduced or used in any manner whatsoever without the express written permission of the publisher except for the use of brief quotations in a review.</p>

                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js\"></script>\r\n");
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
