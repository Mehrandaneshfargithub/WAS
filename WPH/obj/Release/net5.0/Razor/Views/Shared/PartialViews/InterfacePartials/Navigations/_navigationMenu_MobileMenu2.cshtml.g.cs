#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53516a597edb14d6788eb1eabdbfd9b717b8ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.InterfacePartials.Navigations.Views_Shared_PartialViews_InterfacePartials_Navigations__navigationMenu_MobileMenu2), @"mvc.1.0.view", @"/Views/Shared/PartialViews/InterfacePartials/Navigations/_navigationMenu_MobileMenu2.cshtml")]
namespace WPH.Pages.Shared.PartialViews.InterfacePartials.Navigations
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
#line 1 "H:\Projects\WAS\WPH\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Projects\WAS\WPH\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53516a597edb14d6788eb1eabdbfd9b717b8ca7", @"/Views/Shared/PartialViews/InterfacePartials/Navigations/_navigationMenu_MobileMenu2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_InterfacePartials_Navigations__navigationMenu_MobileMenu2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-user-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/assets/images/avatars/avatar5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Jason\'s Photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
  
    String navbarFixed = "";
    if (ViewBag.FixedNavbar == "True")
    {
        navbarFixed = "navbar-fixed-top";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"navbar\"");
            BeginWriteAttribute("class", " class=\"", 252, "\"", 309, 4);
            WriteAttributeValue("", 260, "navbar", 260, 6, true);
            WriteAttributeValue(" ", 266, "navbar-default", 267, 15, true);
            WriteAttributeValue(" ", 281, "ace-save-state", 282, 15, true);
#nullable restore
#line 11 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
WriteAttributeValue(" ", 296, navbarFixed, 297, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
      
        String pullr = "";
        String pulll = "";
        if (ViewBag.Rtl == "True")
        {
            pullr = "pull-right";
            pulll = "pull-left";
        }
        else
        {
            pullr = "pull-left";
            pulll = "pull-right";
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""navbar-container ace-save-state"" id=""navbar-container"">
        <div class=""navbar-header "" style=""text-align:center"">
            <a href=""index.html"" class=""navbar-brand"" style=""font-size:3rem"">
                <i class=""fa fa-leaf""></i>
                ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
           Write(ViewBag.ClinicSectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 968, "\"", 1011, 3);
            WriteAttributeValue("", 976, "navbar-buttons", 976, 14, true);
            WriteAttributeValue(" ", 990, "navbar-header", 991, 14, true);
#nullable restore
#line 34 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
WriteAttributeValue(" ", 1004, pulll, 1005, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"navigation\">\r\n            <ul class=\"nav ace-nav\">\r\n");
            WriteLiteral("\r\n                <li class=\"light-blue dropdown-modal MyFont-Merriweather-grid\" style=\"font-weight:400\">\r\n                    <a data-toggle=\"dropdown\" href=\"#\" class=\"dropdown-toggle\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f53516a597edb14d6788eb1eabdbfd9b717b8ca77460", async() => {
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
            WriteLiteral("\r\n                        <span class=\"user-info\">\r\n                            <small>");
#nullable restore
#line 295 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
                              Write(ViewBag.Welcome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            ");
#nullable restore
#line 296 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
                       Write(ViewBag.NameOfUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>

                        <i class=""ace-icon fa fa-caret-down""></i>
                    </a>

                    <ul class=""user-menu dropdown-menu-right dropdown-menu dropdown-yellow dropdown-caret dropdown-close"">
                        <li>
                            <a href=""#"" id=""settings-page-Navigation-menu"">
                                <i class=""ace-icon fa fa-cog""></i>
                                ");
#nullable restore
#line 306 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
                           Write(ViewBag.Setting);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n\r\n");
            WriteLiteral("\r\n                        <li class=\"divider\"></li>\r\n\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 16218, "\"", 16261, 1);
#nullable restore
#line 320 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
WriteAttributeValue("", 16225, Url.Action("Logout", "UserHandler"), 16225, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\'ace-icon fa fa-power-off\'></i>\r\n                                ");
#nullable restore
#line 322 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu2.cshtml"
                           Write(ViewBag.LogOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n");
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n\r\n        </div>\r\n    </div><!-- /.navbar-container -->\r\n</div>");
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
