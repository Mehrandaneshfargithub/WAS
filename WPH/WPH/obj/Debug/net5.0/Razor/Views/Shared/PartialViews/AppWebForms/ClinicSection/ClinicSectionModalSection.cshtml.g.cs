#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1913f01c053ceb8f8222668ee5b588c24d316b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ClinicSection.Views_Shared_PartialViews_AppWebForms_ClinicSection_ClinicSectionModalSection), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ClinicSection/ClinicSectionModalSection.cshtml")]
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
#line 1 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1913f01c053ceb8f8222668ee5b588c24d316b", @"/Views/Shared/PartialViews/AppWebForms/ClinicSection/ClinicSectionModalSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ClinicSection_ClinicSectionModalSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div id=\"ClinicSectionModal\"");
            BeginWriteAttribute("class", " class=\"", 169, "\"", 661, 4);
            WriteAttributeValue("", 177, "modal", 177, 5, true);
            WriteAttributeValue(" ", 182, "fade", 183, 5, true);
            WriteAttributeValue(" ", 187, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 6 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 8 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 10 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 188, 472, false);
            WriteAttributeValue(" ", 660, "", 661, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 707, "\"", 838, 1);
            WriteAttributeValue("", 715, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 10 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                                                                                                                 if (HttpContextAccessor.HttpContext.Session.GetString("culture")!= "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("direction:rtl\r\n");
#nullable restore
#line 12 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 715, 123, false);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" aria-hidden=""true"" onclick = ""CloseClinicSection()"">&times;</button>
                <h3 id=""ClinicSectionModal-header""");
            BeginWriteAttribute("class", " class=\"", 1123, "\"", 1635, 6);
            WriteAttributeValue("", 1131, "smaller", 1131, 7, true);
            WriteAttributeValue(" ", 1138, "lighter", 1139, 8, true);
            WriteAttributeValue(" ", 1146, "blue", 1147, 5, true);
            WriteAttributeValue(" ", 1151, "no-margin", 1152, 10, true);
            WriteAttributeValue(" ", 1161, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 17 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                                                          if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 19 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 21 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1162, 472, false);
            WriteAttributeValue(" ", 1634, "", 1635, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
               Write(Localizer["Section"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
                                     Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ClinicSectionModal-body\" class=\"modal-body \" style=\"width:70rem\">\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-ClinicSectionModal-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right ", onclick= "AddNewClinicSection()" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ClinicSection\ClinicSectionModalSection.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-ClinicSectionModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right ", onclick = "CloseClinicSection()" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </div>
</div>

<script>

    

    function AddNewClinicSection() {


        $('#addNewClinicSectionOrUserForm .emptybox').addClass('hidden');
        var isEmmpty = true;
        $('#addNewClinicSectionOrUserForm .emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() !== undefined) {
                    let text = $('[data-checkEmpty=""' + empty + '""]').val().replace(/ /g, '');
                    if (text === """") {
                        $(this).removeClass('hidden');
                        isEmmpty = false;
                        return;
                    }
                }

            }
        });


        
        if (isEmmpty === false) {
            return;
        }



        var link = ""/ClinicSection/AddOrUpdate"";
        
        var data = $(""#addNewClinicSec");
            WriteLiteral(@"tionOrUserForm"").serialize();

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                if (response !== 0) {
                    if (response === ""ValueIsRepeated"") {

                        $('#Name-Exist').removeClass('hidden');

                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                    } else {

                        $('#ClinicSectionModal').modal('toggle');
                        $('#ClinicSectionModal-body').empty();
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                        $(""#kendoClinicSectionGrid .k-pager-refresh"").click();
                    }
                }
            }
        });
    }


    function CloseClinicSection() {

        $('#ClinicSectionModal').modal('hide');
   ");
            WriteLiteral("     $(\'#ClinicSectionModal-body\').empty();\r\n\r\n    }\r\n\r\n</script>\r\n\r\n");
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
