#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f152f0984aa672bab7ea4ddca56e2e58fe2a5553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.InterfacePartials.Navigations.Views_Shared_PartialViews_InterfacePartials_Navigations__navigationMenu_MobileMenu3), @"mvc.1.0.view", @"/Views/Shared/PartialViews/InterfacePartials/Navigations/_navigationMenu_MobileMenu3.cshtml")]
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
#line 1 "H:\Projects\WAS\WPH\WPH\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Projects\WAS\WPH\WPH\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f152f0984aa672bab7ea4ddca56e2e58fe2a5553", @"/Views/Shared/PartialViews/InterfacePartials/Navigations/_navigationMenu_MobileMenu3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_InterfacePartials_Navigations__navigationMenu_MobileMenu3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/assets/images/avatars/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Jason\'s Photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-user-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/assets/images/avatars/avatar5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
  
    String navbarFixed = "";
    if (ViewBag.FixedNavbar == "True")
    {
        navbarFixed = "navbar-fixed-top";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"navbar\"");
            BeginWriteAttribute("class", " class=\"", 244, "\"", 317, 5);
            WriteAttributeValue("", 252, "navbar", 252, 6, true);
            WriteAttributeValue(" ", 258, "navbar-default", 259, 15, true);
            WriteAttributeValue(" ", 273, "navbar-collapse", 274, 16, true);
            WriteAttributeValue(" ", 289, "ace-save-state", 290, 15, true);
#nullable restore
#line 11 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
WriteAttributeValue(" ", 304, navbarFixed, 305, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
      
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
        <div class=""navbar-header"" style=""text-align:center"">
            <a href=""index.html"" class=""navbar-brand"" style=""font-size:3rem"">
                <i class=""fa fa-leaf""></i>
               ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
          Write(ViewBag.ClinicSectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n\r\n            <button");
            BeginWriteAttribute("class", " class=\"", 965, "\"", 1021, 4);
#nullable restore
#line 33 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
WriteAttributeValue("", 973, pulll, 973, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 979, "navbar-toggle", 980, 14, true);
            WriteAttributeValue(" ", 993, "navbar-toggle-img", 994, 18, true);
            WriteAttributeValue(" ", 1011, "collapsed", 1012, 10, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" data-toggle=\"collapse\" data-target=\".navbar-buttons\">\r\n                <span class=\"sr-only\">Toggle user menu</span>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f152f0984aa672bab7ea4ddca56e2e58fe2a55537848", async() => {
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
            WriteLiteral("\r\n            </button>\r\n\r\n            <button");
            BeginWriteAttribute("class", " class=\"", 1293, "\"", 1331, 3);
#nullable restore
#line 39 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
WriteAttributeValue("", 1301, pulll, 1301, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1307, "navbar-toggle", 1308, 14, true);
            WriteAttributeValue(" ", 1321, "collapsed", 1322, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" data-toggle=""collapse"" data-target=""#sidebar"">
                <span class=""sr-only"">Toggle sidebar</span>

                <span class=""icon-bar""></span>

                <span class=""icon-bar""></span>

                <span class=""icon-bar""></span>
            </button>
        </div>

        <div");
            BeginWriteAttribute("class", " class=\"", 1659, "\"", 1728, 5);
            WriteAttributeValue("", 1667, "navbar-buttons", 1667, 14, true);
            WriteAttributeValue(" ", 1681, "navbar-header", 1682, 14, true);
#nullable restore
#line 50 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
WriteAttributeValue(" ", 1695, pulll, 1696, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 1702, "collapse", 1704, 10, true);
            WriteAttributeValue(" ", 1712, "navbar-collapse", 1713, 16, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"navigation\">\r\n            <ul class=\"nav ace-nav\">\r\n");
            WriteLiteral("\r\n                <li class=\"light-blue dropdown-modal MyFont-Merriweather-grid\" style=\"font-weight:400\">\r\n                    <a data-toggle=\"dropdown\" href=\"#\" class=\"dropdown-toggle\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f152f0984aa672bab7ea4ddca56e2e58fe2a555310926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span class=\"user-info\">\r\n                            <small>");
#nullable restore
#line 250 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
                              Write(ViewBag.Welcome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            ");
#nullable restore
#line 251 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
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
#line 261 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
                           Write(ViewBag.Setting);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n\r\n");
            WriteLiteral("\r\n                        <li class=\"divider\"></li>\r\n\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 16161, "\"", 16204, 1);
#nullable restore
#line 275 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
WriteAttributeValue("", 16168, Url.Action("Logout", "UserHandler"), 16168, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\'ace-icon fa fa-power-off\'></i>\r\n                                ");
#nullable restore
#line 277 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\InterfacePartials\Navigations\_navigationMenu_MobileMenu3.cshtml"
                           Write(ViewBag.LogOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div><!-- /.navbar-container -->\r\n</div>\r\n");
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
