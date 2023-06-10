#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc60d1c5f198a5a7e1fe26b4aaf4c156395f9706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.PatientReception.Views_Shared_PartialViews_AppWebForms_PatientReception_wpPatientReceptionForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/PatientReception/wpPatientReceptionForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.PatientReception
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
#line 3 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc60d1c5f198a5a7e1fe26b4aaf4c156395f9706", @"/Views/Shared/PartialViews/AppWebForms/PatientReception/wpPatientReceptionForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_PatientReception_wpPatientReceptionForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function GetPeriodAndStatusForPatientReception() {

        var periodId = $('#period-id').attr('data-Value');

        var fromDate = $(""#KendoFromDate"").data(""kendoDatePicker"");
        var toDate = $(""#KendoDateTo"").data(""kendoDatePicker"");

        var frDate = fromDate.value();
        var tDate = toDate.value();
        let frMonth = frDate.getMonth() + 1;
        let frDay = frDate.getDate();
        let toMonth = tDate.getMonth() + 1;
        let toDay = tDate.getDate();

        if (frMonth < 10)
            frMonth = ""0"" + frMonth;
        if (toMonth < 10)
            toMonth = ""0"" + toMonth;
        if (frDay < 10)
            frDay = ""0"" + frDay;
        if (toDay < 10)
            toDay = ""0"" + toDay;

        let from = frDate.getFullYear() + ""-"" + frMonth + ""-"" + frDay;
        let too = tDate.getFullYear() + ""-"" + toMonth + ""-"" + toDay;

        let statusType = $(""#status"").data(""kendoDropDownList"");


        var period = $(""#sections"").data(""k");
            WriteLiteral(@"endoDropDownList"");

        var periodValue = period.value();
        var periodText = period.text();

        let section = { Id: periodValue, Name: periodText }

        return {

            periodId: periodId,
            dateFrom: from,
            dateTo: too,
            section: section,
            status: statusType.value()
        };
    }
</script>
<div class=""row page-header "">

    <div");
            BeginWriteAttribute("class", " class=\"", 2051, "\"", 2064, 1);
#nullable restore
#line 75 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue("", 2059, pull, 2059, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 2079, "\"", 2092, 1);
#nullable restore
#line 76 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue("", 2087, font, 2087, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
       Write(Localizer["Reception"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n\r\n\r\n</div><!-- /.page-header -->\r\n\r\n\r\n\r\n<input class=\"hidden\" type=\"text\" id=\"period-id\" data-Value=\"");
#nullable restore
#line 88 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
                                                        Write(Model.periods.FirstOrDefault().Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<h1 id=\"FromTo\" class=\"hidden\">");
#nullable restore
#line 89 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
                          Write(ViewBag.FromToId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"space-10\"></div>\r\n<div");
            BeginWriteAttribute("class", " class=\"", 2422, "\"", 2439, 2);
            WriteAttributeValue("", 2430, "row", 2430, 3, true);
#nullable restore
#line 92 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue(" ", 2433, font, 2434, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n    <div class=\"col-xs-12\" style=\"padding:0;margin-bottom:1rem\">\r\n\r\n        <div class=\"col-xs-2 labSections\" style=\"padding-left:unset;padding-right:unset;\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().DropDownList()
    .Name("sections")
    .BindTo(Model.sections)
    .DataTextField("Name")
    .DataValueField("Id")
    .Filter("contains")
    .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "SectionChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-xs-2 labSections hidden"" style=""padding-left:unset;padding-right:unset;""></div>
        <div class=""col-xs-2 labSections"" style=""padding-left:unset;padding-right:unset;""></div>

        <div class=""col-xs-2"" style=""padding-left:unset;padding-right:unset;"">
            ");
#nullable restore
#line 111 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().DropDownList()
    .Name("periods")
    .BindTo(Model.periods)
    .DataTextField("Name")
    .DataValueField("Id")
    .Filter("contains")

    .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "PeriodsChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-xs-2\" style=\"padding-left:unset;padding-right:unset;\"></div>\r\n\r\n");
#nullable restore
#line 124 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
          
            var hid = "hidden";
            var hid2 = "";
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
         if (HttpContextAccessor.HttpContext.Session.GetString("SectionTypeName") == "Hospital")
        {
            hid = "";
            hid2 = "hidden";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 3861, "\"", 3882, 2);
            WriteAttributeValue("", 3869, "col-xs-2", 3869, 8, true);
#nullable restore
#line 133 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue(" ", 3877, hid, 3878, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding-left:unset;padding-right:unset;\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("status")
            .BindTo(Model.clearances)
            .DataTextField("Name")
            .DataValueField("Id")
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "SectionChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 4268, "\"", 4301, 3);
            WriteAttributeValue("", 4276, "col-xs-2", 4276, 8, true);
            WriteAttributeValue(" ", 4284, "pull-right", 4285, 11, true);
#nullable restore
#line 143 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue(" ", 4295, hid2, 4296, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding-left:unset;padding-right:unset;\">\r\n\r\n            ");
#nullable restore
#line 145 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().CheckBox()
                .Name("HospitalReceptions")
                .Label(Localizer["Reception"] + " " + Localizer["From"] + " " + Localizer["Hospital"])
                .HtmlAttributes(new { @class = "kendoCheckbox", onchange = "showHospitalReceptions(this)" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>




    </div>

    <div class=""col-xs-12"" style=""padding:0;margin-bottom:1rem"">

        <div class=""col-xs-2"" style=""padding-left:unset;padding-right:unset;""></div>

        <div class=""col-xs-2 DateFromDiv hidden"" style=""padding-left:unset;padding-right:unset;text-align:center;"">
            <h5 class=""MyFont-Roboto-grid"">");
#nullable restore
#line 163 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
                                      Write(Localizer["FromDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n\r\n        <div class=\"col-xs-2 DateFromDiv hidden\" style=\"padding-left:unset;padding-right:unset;\">\r\n            ");
#nullable restore
#line 167 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().DatePicker()
            .Name("KendoFromDate")
            .Value(DateTime.Now)
            .Format("dd/MM/yyyy")
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-xs-2 DateToDiv hidden\" style=\"padding-left:unset;padding-right:unset;text-align:center;\">\r\n            <h5 class=\"MyFont-Roboto-grid\">");
#nullable restore
#line 176 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
                                      Write(Localizer["ToDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n\r\n        <div class=\"col-xs-2 DateToDiv hidden\" style=\"padding-left:unset;padding-right:unset;\">\r\n            ");
#nullable restore
#line 180 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().DatePicker()
            .Name("KendoDateTo")
            .Value(DateTime.Now)
            .Format("dd/MM/yyyy")
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div id=\"SearchBtnDiv\" class=\"col-xs-2 hidden\" style=\"padding-left:unset;padding-right:unset;text-align:center;\">\r\n\r\n            ");
#nullable restore
#line 190 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
        Write(Html.Kendo().Button()
            .Name("btn-search-visit")
            .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem", type = "button", @class = "k-primary ", onclick = "btnSearchClick()" })
            .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<div id=\"GridArea\">\r\n    ");
#nullable restore
#line 202 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/PatientReception/dgPatientReceptionGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"ShowAttachmentsModal\"");
            BeginWriteAttribute("class", " class=\"", 6711, "\"", 6735, 3);
            WriteAttributeValue("", 6719, "modal", 6719, 5, true);
            WriteAttributeValue(" ", 6724, "fade", 6725, 5, true);
#nullable restore
#line 205 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue(" ", 6729, font, 6730, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 6781, "\"", 6799, 1);
#nullable restore
#line 205 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue("", 6789, direction, 6789, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""width:80%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeShowAttachmentsModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""ShowAttachmentsModal-header""");
            BeginWriteAttribute("class", " class=\"", 7109, "\"", 7153, 5);
            WriteAttributeValue("", 7117, "smaller", 7117, 7, true);
            WriteAttributeValue(" ", 7124, "lighter", 7125, 8, true);
            WriteAttributeValue(" ", 7132, "blue", 7133, 5, true);
            WriteAttributeValue(" ", 7137, "no-margin", 7138, 10, true);
#nullable restore
#line 210 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
WriteAttributeValue(" ", 7147, font, 7148, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 211 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
               Write(Localizer["Attachments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ShowAttachmentsModal-body\" class=\"modal-body\">\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 220 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-showAttachments-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick = "addNewPatientBed()" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 224 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-showAttachments-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick="closeShowAttachmentsModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 236 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 237 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientReception\wpPatientReceptionForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>

    function ShowAttachments(element) {

        $('#AddPatientBedModal').modal('toggle');
        var room_id = $(element).attr('data-room');
        var link = ""/Reception/SelectModal?RoomId="";
        $("".loader"").removeClass(""hidden"");
        $('#AddPatientBedModal-body').load(link + room_id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");

        });
    }

    function PeriodsChange() {

        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();


        $('#period-id').attr('data-Value', periodValue);

        var fromTo = $(""#FromTo"").text();

        if (periodValue === fromTo) {
            $("".DateFromDiv"").removeClass(""hidden"");
            $("".DateToDiv"").removeClass(""hidden"");
            $(""#SearchBtnDiv"").removeClass(""hidden"");
            let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
            date.element.focus();
            ");
            WriteLiteral(@"date.element.select();

        } else {
            $("".DateFromDiv"").addClass(""hidden"");
            $("".DateToDiv"").addClass(""hidden"");
            $(""#SearchBtnDiv"").addClass(""hidden"");

            if ($(""#HospitalReceptions"").is("":checked"")) {
                $(""#ReceptionClinicSectionGrid"").find("".k-i-reload"").click();

            } else {

                $(""#kendoPatientReceptionGrid"").find("".k-i-reload"").click();
            }
        }

    }

    function SectionChange() {
        
        if ($(""#HospitalReceptions"").is("":checked"")) {
            $(""#ReceptionClinicSectionGrid"").find("".k-i-reload"").click();

        } else {

            $(""#kendoPatientReceptionGrid"").find("".k-i-reload"").click();
        }

    }

    function btnSearchClick() {
        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();

        $('#period-id').attr('data-Value', periodValue);

        if ($(""#HospitalReceptions"").is("":checked""))");
            WriteLiteral(@" {
            $(""#ReceptionClinicSectionGrid"").find("".k-i-reload"").click();

        } else {

            $(""#kendoPatientReceptionGrid"").find("".k-i-reload"").click();
        }
    }


    function AddPatientReceptionAnalysis() {

        $("".loader"").removeClass(""hidden"");
        $("".page-content"").load(""/PatientReceptionAnalysis/Form"", function (responce) {

            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })

    }


    $('#KendoFromDate').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            let date = $(""#KendoDateTo"").data(""kendoDatePicker"");
            date.element.focus();
        }
    });

    $('#KendoFromDate').focus(function (e) {

        let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
        date.element.select();

    });

    $('#KendoDateTo').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            $(""#btn-search-visit"").focus();
       ");
            WriteLiteral(@" }
    });


    $('#KendoDateTo').focus(function (e) {

        let date = $(""#KendoDateTo"").data(""kendoDatePicker"");
        date.element.select();

    });

    function showHospitalReceptions(element) {

        if ($(element).is("":checked"")) {
            let link = ""/Reception/GetReceptionClinicSectionGrid"";
            $("".loader"").removeClass(""hidden"");
            $(""#GridArea"").empty();
            $('#GridArea').load(link, function () {
                $("".loader"").fadeIn(""slow"");
                $("".loader"").addClass(""hidden"");

            });

            //$("".labSections"").css(""display"", ""none"");
            $("".labSections"").toggleClass('hidden');
        }
        else {

            let link = ""/Reception/GetReceptionGrid"";
            $("".loader"").removeClass(""hidden"");
            $(""#GridArea"").empty();
            $('#GridArea').load(link, function () {
                $("".loader"").fadeIn(""slow"");
                $("".loader"").addClass(""hidden"");

     ");
            WriteLiteral(@"       });

            //$("".labSections"").css(""display"", ""block"");
            $("".labSections"").toggleClass('hidden');
        }


    }

    function EditHospitalReception(element) {

        let receptionClinicSectionId = $(element).attr('data-Id');
        let patientId = $(element).attr('data-patientId');
        let doctorId = $(element).attr('data-doctorId');
        let Desc = $(element).attr('data-desc');

        $("".loader"").removeClass(""hidden"");

        let link = ""/PatientReceptionAnalysis/EditModal?PatientId="" + patientId + ""&&DoctorId="" + doctorId + ""&&ReceptionClinicSectionId="" + receptionClinicSectionId;

        $("".page-content"").load(link, function (responce) {


            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
