#pragma checksum "C:\Users\andre\Documents\WebAppPortefolioResp\WebAppPortefolio\Views\Shared\Components\Sidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09f6ad950b2fb0a2d840030b551be44b075f864b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Sidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Sidebar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Sidebar_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f6ad950b2fb0a2d840030b551be44b075f864b", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
    public class Views_Shared_Components_Sidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 238, true);
            WriteLiteral("\r\n<div class=\"main-container\">\r\n    <div class=\"sidebar\">\r\n        <nav class=\"sidebar-nav\">\r\n            <ul class=\"nav\">\r\n                <li class=\"nav-title\">Navigation</li>\r\n                <li class=\"nav-item\">\r\n                    ");
            EndContext();
            BeginContext(238, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e083640d1d4ea6811d5fe367dccdcd", async() => {
                BeginContext(278, 95, true);
                WriteLiteral("\r\n                        <i class=\"icon icon-speedometer\"></i> Dashboard\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(377, 3448, true);
            WriteLiteral(@"
                </li>
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""fa fa-address-book""></i> List
                    </a>
                </li>
                <li class=""nav-item nav-dropdown"">
                    <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                        <i class=""icon icon-energy""></i> UI Kits <i class=""fa fa-caret-left""></i>
                    </a>
                    <ul class=""nav-dropdown-items"">
                        <li class=""nav-item"">
                            <a href=""alerts.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Alerts
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""buttons.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Buttons
                            </a>
               ");
            WriteLiteral(@"         </li>
                        <li class=""nav-item"">
                            <a href=""cards.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Cards
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""modals.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Modals
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""tabs.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Tabs
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""progress-bars.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Progress Bars
                            </a>
               ");
            WriteLiteral(@"         </li>
                        <li class=""nav-item"">
                            <a href=""widgets.html"" class=""nav-link"">
                                <i class=""icon icon-energy""></i> Widgets
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item nav-dropdown"">
                    <a href=""#"" class=""nav-link nav-dropdown-toggle"">
                        <i class=""icon icon-graph""></i> Charts <i class=""fa fa-caret-left""></i>
                    </a>
                    <ul class=""nav-dropdown-items"">
                        <li class=""nav-item"">
                            <a href=""chartjs.html"" class=""nav-link"">
                                <i class=""icon icon-graph""></i> Chart.js
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item"">
                    <a href=""forms.html"" class=""nav-link"">");
            WriteLiteral(@"
                        <i class=""icon icon-puzzle""></i> Forms
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""tables.html"" class=""nav-link"">
                        <i class=""icon icon-grid""></i> Tables
                    </a>
                </li>

            </ul>
        </nav>
    </div>
");
            EndContext();
        }
        #pragma warning restore 1998
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
