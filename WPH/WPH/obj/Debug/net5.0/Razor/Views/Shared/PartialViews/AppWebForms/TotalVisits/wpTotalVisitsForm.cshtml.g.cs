#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2442aa82332409340f4275746e85375a3c80973f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.TotalVisits.Views_Shared_PartialViews_AppWebForms_TotalVisits_wpTotalVisitsForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/TotalVisits/wpTotalVisitsForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.TotalVisits
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
#line 1 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2442aa82332409340f4275746e85375a3c80973f", @"/Views/Shared/PartialViews/AppWebForms/TotalVisits/wpTotalVisitsForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_TotalVisits_wpTotalVisitsForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
  
    string font = "", pull = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 488, "\"", 501, 1);
#nullable restore
#line 23 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
WriteAttributeValue("", 496, pull, 496, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 516, "\"", 529, 1);
#nullable restore
#line 24 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
WriteAttributeValue("", 524, font, 524, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
       Write(Localizer["AllVisits"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n</div><!-- /.page-header -->\r\n\r\n<h1 id=\"FromTo\" class=\"hidden\">");
#nullable restore
#line 31 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                          Write(ViewBag.FromToId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div class=\"row\" style=\"margin-top:2rem\">\r\n\r\n    <div class=\" col-sm-12\">\r\n\r\n        <div class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("periods")
            .DataTextField("Name")
            .DataValueField("Id")
            //.Filter("contains")
            .BindTo(@ViewBag.periods)
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "PeriodsChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("Doctor")
            .DataTextField("UserName")
            .DataValueField("Guid")
            .Filter("contains")
            .OptionLabel(" ")
            .DataSource(source =>
            {
                source.Read(read => { read.Action("GetDoctorsBaseUserAccess", "Doctor"); })
                .ServerFiltering(false);
            })
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "PeriodsChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-4"">

        </div>

    </div>

    <div class=""col-sm-12"" style=""margin-top:20px;display:flex;align-items: flex-end;"">

        <div id=""DateFromDiv"" class="" col-sm-4 hidden"">

            <label class=""block clearfix"" style=""margin-bottom: 0px;"">
                <label for=""form-field-8"">");
#nullable restore
#line 76 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                     Write(Localizer["From"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 76 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                                        Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n\r\n                <span class=\"block input-icon input-icon-right\">\r\n\r\n                    <input id=\"DateFrom\"");
            BeginWriteAttribute("value", " value=\"", 2257, "\"", 2278, 1);
#nullable restore
#line 80 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
WriteAttributeValue("", 2265, DateTime.Now, 2265, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""datepicker"" style=""width: 100%;font-size:1.5rem"" />

                </span>

            </label>
        </div>

        <div id=""DateToDiv"" class="" col-sm-4 hidden"">

            <label class=""block clearfix"" style=""margin-bottom: 0px;"">
                <label for=""form-field-8"">");
#nullable restore
#line 90 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                     Write(Localizer["To"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 90 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                                      Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n\r\n                <span class=\"block input-icon input-icon-right\">\r\n\r\n                    <input id=\"DateTo\"");
            BeginWriteAttribute("value", " value=\"", 2734, "\"", 2755, 1);
#nullable restore
#line 94 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
WriteAttributeValue("", 2742, DateTime.Now, 2742, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"datepicker\" style=\"width: 100%;font-size:1.5rem\" />\r\n\r\n                </span>\r\n            </label>\r\n        </div>\r\n\r\n        <div id=\"SearchBtnDiv\" class=\"col-xs-1 hidden\">\r\n\r\n            ");
#nullable restore
#line 102 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
        Write(Html.Kendo().Button()
            .Name("btn-search-visit")
            .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem", type = "button", @class = "k-primary pull-right", onclick = "btnSearchClick()" })
            .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div id=\"prescriptionModal\"");
            BeginWriteAttribute("class", " class=\"", 3299, "\"", 3323, 3);
            WriteAttributeValue("", 3307, "modal", 3307, 5, true);
            WriteAttributeValue(" ", 3312, "fade", 3313, 5, true);
#nullable restore
#line 111 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
WriteAttributeValue(" ", 3317, font, 3318, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" data-backdrop=""static"" data-keyboard=""false"" style=""direction:ltr"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" onclick=""closePrescriptionModal()"" aria-hidden=""true"">&times;</button>
                    <h3 id=""prescriptionModal-header"" class=""smaller lighter blue no-margin"">");
#nullable restore
#line 116 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                                                                        Write(Localizer["Prescription"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                </div>\r\n\r\n                <div id=\"prescriptionModal-body\" class=\"modal-body\" style=\"width:80vw;overflow: hidden;\">\r\n\r\n                </div>\r\n\r\n                <div class=\"modal-footer\">\r\n\r\n                    ");
#nullable restore
#line 126 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                Write(Html.Kendo().Button()
                        .Name("btn-prescriptionModal-close")
                        .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick = "closePrescriptionModal()" })
                        .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div>
</div>

<script>

    function GetPeriodForAllVisits() {


        let period = $(""#periods"").data(""kendoDropDownList"");

        let periodValue = period.value();
        var DateFrom = $(""#DateFrom"").val();
        var DateTo = $(""#DateTo"").val();

        return {
            periodId: periodValue,
            dateFrom: DateFrom,
            dateTo: DateTo,
            doctorId: $(""#Doctor"").val()
        };
    }

</script>


<div");
            BeginWriteAttribute("class", " class=\"", 4925, "\"", 4955, 3);
            WriteAttributeValue("", 4933, "row", 4933, 3, true);
            WriteAttributeValue(" ", 4936, "Grid-Content", 4937, 13, true);
#nullable restore
#line 160 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
WriteAttributeValue(" ", 4949, font, 4950, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 161 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/TotalVisits/dgTotalVisitsGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>



<script>

    $(document).ready(function () {

        $(""#DateFrom"").kendoDatePicker({

            format: ""dd/MM/yyyy""
        });

        $(""#DateTo"").kendoDatePicker({

            format: ""dd/MM/yyyy""
        });
    })

    function closePrescriptionModal() {

        $('#prescriptionModal').modal('hide');
        $('#prescriptionModal-body').empty();

    }

    function PeriodsChange() {

        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();

        var fromTo = $(""#FromTo"").text();

        if (periodValue === fromTo) {
            $(""#DateFromDiv"").removeClass(""hidden"");
            $(""#DateToDiv"").removeClass(""hidden"");
            $(""#SearchBtnDiv"").removeClass(""hidden"");

        } else {
            $(""#DateFromDiv"").addClass(""hidden"");
            $(""#DateToDiv"").addClass(""hidden"");
            $(""#SearchBtnDiv"").addClass(""hidden"");
            $(""#kendoTotalVisitGrid .k-pager-refresh"")[");
            WriteLiteral("0].click();\r\n        }\r\n\r\n    }\r\n\r\n\r\n    function btnSearchClick() {\r\n\r\n        $(\"#kendoTotalVisitGrid .k-pager-refresh\")[0].click();\r\n    }\r\n\r\n\r\n    function DeleteVisit(element) {\r\n        bootbox.confirm(\'");
#nullable restore
#line 218 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                    Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', function (result) {

            if (!result) {

                return;
            }
            else {

                $("".loader"").removeClass(""hidden"");

                var Id = $(element).attr('data-id');
                var link = ""/Visit/Remove"";

                $.ajax({
                    url: link,
                    type: ""Post"",
                    data: { Id: Id },
                    success: function (response) {

                        if (response === ""SUCCESSFUL"") {

                            $(""#kendoTotalVisitGrid .k-pager-refresh"")[0].click();

                        } else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {

                            bootbox.alert({
                                message: '");
#nullable restore
#line 244 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                     Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                className: \'bootbox-class\'\r\n                            });\r\n\r\n                        } else if (response === \"Visited\") {\r\n\r\n                            bootbox.alert({\r\n                                message: \'");
#nullable restore
#line 251 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                     Write(Localizer["ThisReserveAlreadyIsVisited"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                className: \'bootbox-class\'\r\n                            });\r\n\r\n                        } else {\r\n\r\n                            bootbox.alert({\r\n                                message: \'");
#nullable restore
#line 258 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\wpTotalVisitsForm.cshtml"
                                     Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                                className: 'bootbox-class'
                            });
                        }

                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    }
                });
            }
        })
    }

    function ShowVisitHistory(element) {

        $('#prescriptionModal').modal('toggle');

        var link = ""/Visit/GetPrescriptionByReceptionId?receptionId="";
        var Id = $(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");

        $('#prescriptionModal-body').load(link + Id + '', function (responce) {

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
