#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c6c8e8998ea46177ea00aa1a350cb249fab62c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ClinicSection.Views_Shared_PartialViews_AppWebForms_ClinicSection_wpClinicSectionForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ClinicSection/wpClinicSectionForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ClinicSection
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
#line 1 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c6c8e8998ea46177ea00aa1a350cb249fab62c", @"/Views/Shared/PartialViews/AppWebForms/ClinicSection/wpClinicSectionForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ClinicSection_wpClinicSectionForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 179, "\"", 349, 2);
            WriteAttributeValue("", 187, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 6 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("pull-right\r\n");
#nullable restore
#line 8 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
        }
        else {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("pull-left\r\n");
#nullable restore
#line 11 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 187, 161, false);
            WriteAttributeValue(" ", 348, "", 349, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 364, "\"", 844, 1);
            WriteAttributeValue("", 372, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 16 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 372, 472, false);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 17 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
       Write(Localizer["Sections"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 947, "\"", 1182, 1);
            WriteAttributeValue("", 955, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("pull-right\r\n            ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 24 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
        }
        else {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("pull-left\r\n         ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 28 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 955, 227, false);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n        <a class=\"btn btn-danger\" onClick=\"AddClinicSection()\" href=\"#\" style=\"padding:0.2rem\">\r\n            ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
       Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n        </a>\r\n");
            WriteLiteral("    </div>\r\n\r\n\r\n</div><!-- /.page-header -->\r\n<!-- Modal -->\r\n<!-- Grid -->\r\n\r\n\r\n\r\n");
#nullable restore
#line 45 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/ClinicSection/dgClinicSectionGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 47 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/ClinicSection/ClinicSectionModalSection.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 52 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
  
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newHospitalText\" class=\"hidden\">");
#nullable restore
#line 55 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                                             Write(Localizer["Section"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 56 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newHospitalText\" class=\"hidden\">");
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                           Write(Localizer["Section"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                                                 Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 60 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editHospitalText\" class=\"hidden\">");
#nullable restore
#line 62 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                        Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\wpClinicSectionForm.cshtml"
                                                           Write(Localizer["Section"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral(@"
<script>


    function AddClinicSection() {

        var link = ""/ClinicSection/AddNewModal""
        $("".loader"").removeClass(""hidden"");
        $('#ClinicSectionModal').modal('toggle');
        $('#ClinicSectionModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });

    }



    function EditClinicSection(element) {

        var Id = $(element).attr('data-id');
        let link = ""/ClinicSection/EditModal?Id="";

        $("".loader"").removeClass(""hidden"");
        $('#ClinicSectionModal').modal('toggle');
        $('#ClinicSectionModal-body').load(link + Id, function () {
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
