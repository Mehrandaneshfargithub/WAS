#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca585a8449552b3011a6ceff7ba4d31baff8291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.AnalysisResultTemplate.Views_Shared_PartialViews_AppWebForms_AnalysisResultTemplate_wpAnalysisResultTemplate), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/AnalysisResultTemplate/wpAnalysisResultTemplate.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.AnalysisResultTemplate
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
#nullable restore
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca585a8449552b3011a6ceff7ba4d31baff8291", @"/Views/Shared/PartialViews/AppWebForms/AnalysisResultTemplate/wpAnalysisResultTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_AnalysisResultTemplate_wpAnalysisResultTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
  
    string font = "", pull = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newSymptomText\" class=\"hidden\">");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
                                          Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
                                                            Write(Localizer["Template"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newSymptomText\" class=\"hidden\">");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
                                          Write(Localizer["Template"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
                                                                 Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 683, "\"", 696, 1);
#nullable restore
#line 28 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
WriteAttributeValue("", 691, pull, 691, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 711, "\"", 724, 1);
#nullable restore
#line 29 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
WriteAttributeValue("", 719, font, 719, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
       Write(Localizer["Template"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n");
#nullable restore
#line 35 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
     if ((bool)ViewBag.AccessNewTemplate)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 883, "\"", 902, 2);
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
WriteAttributeValue("", 891, pull, 891, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
WriteAttributeValue(" ", 896, font, 897, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n            <a class=\"btn btn-danger\" onClick=\"AddTemplate(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n                ");
#nullable restore
#line 39 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 43 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div><!-- /.page-header -->\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 1262, "\"", 1292, 3);
            WriteAttributeValue("", 1270, "row", 1270, 3, true);
            WriteAttributeValue(" ", 1273, "Grid-Content", 1274, 13, true);
#nullable restore
#line 49 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
WriteAttributeValue(" ", 1286, font, 1287, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 50 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/AnalysisResultTemplate/dgAnalysisResultTemplateGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 53 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResultTemplate\wpAnalysisResultTemplate.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>


    function AddTemplate(element) {
        var link = $(""#GridAddLink"").attr(""data-Value"");
        let header = $(""#newSymptomText"").text();
        $('#new-modal-header').text(header);
        $("".loader"").removeClass(""hidden"");
        $('#my-modal-new').modal('toggle');
        $('#new-modal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }


</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public WPH.Resources.SharedViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
