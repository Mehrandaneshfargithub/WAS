#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e1f77db5477b72d1cfc2eef6d4e71050d282181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Hospital.Views_Shared_PartialViews_AppWebForms_Hospital_wpHospital), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Hospital/wpHospital.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Hospital
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
#line 1 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e1f77db5477b72d1cfc2eef6d4e71050d282181", @"/Views/Shared/PartialViews/AppWebForms/Hospital/wpHospital.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Hospital_wpHospital : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newHospitalText\" class=\"hidden\">");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
                                           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
                                                             Write(Localizer["Hospital"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newHospitalText\" class=\"hidden\">");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
                                           Write(Localizer["Hospital"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
                                                                  Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editHospitalText\" class=\"hidden\">");
#nullable restore
#line 24 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
                                        Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
                                                           Write(Localizer["Hospital"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 859, "\"", 872, 1);
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue("", 867, pull, 867, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 887, "\"", 900, 1);
#nullable restore
#line 31 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue("", 895, font, 895, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 32 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
       Write(Localizer["Hospital"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n    </div>\r\n");
#nullable restore
#line 35 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
     if ((bool)ViewBag.AccessNewHospital)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1055, "\"", 1074, 2);
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue("", 1063, font, 1063, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue(" ", 1068, pull, 1069, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n            <a class=\"btn btn-danger\" onClick=\"AddHospital(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n                ");
#nullable restore
#line 39 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 43 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div><!-- /.page-header -->\r\n<!-- Modal -->\r\n<div id=\"AddHospitalModal\"");
            BeginWriteAttribute("class", " class=\"", 1468, "\"", 1492, 3);
            WriteAttributeValue("", 1476, "modal", 1476, 5, true);
            WriteAttributeValue(" ", 1481, "fade", 1482, 5, true);
#nullable restore
#line 48 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue(" ", 1486, font, 1487, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1538, "\"", 1556, 1);
#nullable restore
#line 48 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue("", 1546, direction, 1546, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeAddHospitalModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""AddHospitalModal-header""");
            BeginWriteAttribute("class", " class=\"", 1840, "\"", 1884, 5);
            WriteAttributeValue("", 1848, "smaller", 1848, 7, true);
            WriteAttributeValue(" ", 1855, "lighter", 1856, 8, true);
            WriteAttributeValue(" ", 1863, "blue", 1864, 5, true);
            WriteAttributeValue(" ", 1868, "no-margin", 1869, 10, true);
#nullable restore
#line 53 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue(" ", 1878, font, 1879, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"AddHospitalModal-body\" class=\"modal-body\" style=\"width:60rem\">\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 63 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addHospital-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick = "addNewHospital()" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 67 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-addHospital-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick="closeAddHospitalModal()" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n<!-- Grid -->\r\n<div");
            BeginWriteAttribute("class", " class=\"", 2820, "\"", 2850, 3);
            WriteAttributeValue("", 2828, "row", 2828, 3, true);
            WriteAttributeValue(" ", 2831, "Grid-Content", 2832, 13, true);
#nullable restore
#line 79 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
WriteAttributeValue(" ", 2844, font, 2845, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 80 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/Hospital/dgHospitalGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 82 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 83 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Hospital\wpHospital.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    function AddHospital(element) {

        var link = ""/Hospital/AddAndNewModal"";
        $("".loader"").removeClass(""hidden"");

        let header = $(""#newHospitalText"").text();

        $('#AddHospitalModal-header').text(header);
        $('#AddHospitalModal').modal('toggle');
        $('#AddHospitalModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });

    }

    function EditHospital(element) {

        $('#AddHospitalModal').modal('toggle');
        let header = $(""#editHospitalText"").text();
        $('#AddHospitalModal-header').text(header);
        var link = ""/Hospital/EditModal?Id="";
        var Id = $(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");
        $('#AddHospitalModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");

        });

    }

    function addNewHosp");
            WriteLiteral(@"ital() {

        $('.emptybox').addClass('hidden');
        var isEmmpty = true;
        $('.emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    isEmmpty = false;
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }

        var link = ""/Hospital/AddOrUpdate"";

        var data = $(""#addNewHospitalForm"").serialize();

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                if (response !== 0) {
                    if (response === ""ValueIsRepeated"") {

                        $('#Name-Exist').removeClass('hidden');

           ");
            WriteLiteral(@"             $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                    } else {

                        $('#AddHospitalModal').modal('hide');
                        $("".modal-backdrop:last"").remove();
                        $('#AddHospitalModal-body').empty();
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                        $("".k-pager-refresh"")[0].click();

                    }
                }
            }
        });
    }

    function closeAddHospitalModal() {

        $('#AddHospitalModal').modal('hide');
        $('#AddHospitalModal-body').empty();
        $("".modal-backdrop:last"").remove();

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
