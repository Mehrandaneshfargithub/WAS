#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31582918c52a2f5a4fd30ddb73d4f5cce41d7a09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.TotalReserves.Views_Shared_PartialViews_AppWebForms_TotalReserves_wpTotalReservesForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/TotalReserves/wpTotalReservesForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.TotalReserves
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31582918c52a2f5a4fd30ddb73d4f5cce41d7a09", @"/Views/Shared/PartialViews/AppWebForms/TotalReserves/wpTotalReservesForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_TotalReserves_wpTotalReservesForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
  
    string status_title = Localizer["ChangeToVisited"];
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
            WriteLiteral("\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 628, "\"", 642, 2);
#nullable restore
#line 26 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue("", 636, pull, 636, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 641, "", 642, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 659, "\"", 672, 1);
#nullable restore
#line 28 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue("", 667, font, 667, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
       Write(Localizer["Reserve"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n</div><!-- /.page-header -->\r\n\r\n<h1 id=\"FromTo\" class=\"hidden\">");
#nullable restore
#line 35 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                          Write(ViewBag.FromToId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\" style=\"margin-top:2rem\">\r\n\r\n    <div class=\" col-sm-12\">\r\n\r\n        <div class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
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
#line 53 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
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
#line 79 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                     Write(Localizer["From"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 79 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                                        Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n\r\n                <span class=\"block input-icon input-icon-right\">\r\n\r\n                    <input id=\"DateFrom\"");
            BeginWriteAttribute("value", " value=\"", 2396, "\"", 2417, 1);
#nullable restore
#line 83 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue("", 2404, DateTime.Now, 2404, 13, false);

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
#line 93 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                     Write(Localizer["To"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 93 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                                      Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n\r\n                <span class=\"block input-icon input-icon-right\">\r\n\r\n                    <input id=\"DateTo\"");
            BeginWriteAttribute("value", " value=\"", 2873, "\"", 2894, 1);
#nullable restore
#line 97 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue("", 2881, DateTime.Now, 2881, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"datepicker\" style=\"width: 100%;font-size:1.5rem\" />\r\n\r\n                </span>\r\n            </label>\r\n        </div>\r\n\r\n        <div id=\"SearchBtnDiv\" class=\"col-xs-1 hidden\">\r\n\r\n            ");
#nullable restore
#line 105 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
        Write(Html.Kendo().Button()
            .Name("btn-search-visit")
            .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem", type = "button", @class = "k-primary pull-right", onclick = "btnSearchClick()" })
            .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>

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
            BeginWriteAttribute("class", " class=\"", 3867, "\"", 3897, 3);
            WriteAttributeValue("", 3875, "row", 3875, 3, true);
            WriteAttributeValue(" ", 3878, "Grid-Content", 3879, 13, true);
#nullable restore
#line 137 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue(" ", 3891, font, 3892, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 138 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/TotalReserves/dgTotalReservesGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n<div id=\"ShowReceiveModal\"");
            BeginWriteAttribute("class", " class=\"", 4055, "\"", 4079, 3);
            WriteAttributeValue("", 4063, "modal", 4063, 5, true);
            WriteAttributeValue(" ", 4068, "fade", 4069, 5, true);
#nullable restore
#line 143 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue(" ", 4073, font, 4074, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 4125, "\"", 4143, 1);
#nullable restore
#line 143 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue("", 4133, direction, 4133, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeReceiveModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""Receive-modal-header""");
            BeginWriteAttribute("class", " class=\"", 4420, "\"", 4464, 5);
            WriteAttributeValue("", 4428, "smaller", 4428, 7, true);
            WriteAttributeValue(" ", 4435, "lighter", 4436, 8, true);
            WriteAttributeValue(" ", 4443, "blue", 4444, 5, true);
            WriteAttributeValue(" ", 4448, "no-margin", 4449, 10, true);
#nullable restore
#line 148 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue(" ", 4458, font, 4459, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 149 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
               Write(Localizer["Received"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>

            <div id=""ShowReceiveModal-body"" style=""overflow:hidden;"" class=""modal-body"">

            </div>

            <div id=""ERROR_SomeThingWentWrong"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 159 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"EmptyDoctor\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 164 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
           Write(Localizer["InsertDoctorName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 169 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"InvalidReceptionService\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 174 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
           Write(Localizer["InvalidReceptionService"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"NotEnoughProductCount\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 179 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
           Write(Localizer["NotEnoughProductCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <div class=\"modal-footer\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 188 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
            Write(Html.Kendo().Button()
                        .Name("btn-ShowReceiveModal-close")
                        .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeReceiveModal()" })
                        .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"ConvertToVisitModal\"");
            BeginWriteAttribute("class", " class=\"", 6692, "\"", 6716, 3);
            WriteAttributeValue("", 6700, "modal", 6700, 5, true);
            WriteAttributeValue(" ", 6705, "fade", 6706, 5, true);
#nullable restore
#line 198 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue(" ", 6710, font, 6711, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 6762, "\"", 6780, 1);
#nullable restore
#line 198 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue("", 6770, direction, 6770, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3");
            BeginWriteAttribute("class", " class=\'", 7053, "\'", 7074, 2);
            WriteAttributeValue("", 7061, "smaller", 7061, 7, true);
#nullable restore
#line 203 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
WriteAttributeValue(" ", 7068, font, 7069, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'ace-icon fa fa-exclamation-triangle red \'></i>");
#nullable restore
#line 204 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                                                       Write(Localizer["SetReserveToVisited"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ConvertToVisitModal-body\" class=\"modal-body\">\r\n                ");
#nullable restore
#line 209 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
           Write(Localizer["SetReserveToVisitedBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 213 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
               Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 220 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-ConvertToVisitModal-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 224 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-ConvertToVisitModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", @data_dismiss = "modal" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 235 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 236 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    $(document).ready(function () {

        $(""#DateFrom"").kendoDatePicker({

            format: ""dd/MM/yyyy""

        });

        $(""#DateTo"").kendoDatePicker({
            format: ""dd/MM/yyyy""

        });
    })

    function LineItems_Databound(status) {
        if (status == 'Paid') {
            return ""<div style='background:lightgreen;border-radius: 5px;'>"" + status + "" </div>"";
        } else {
            return ""<div style='background:pink;border-radius: 5px;'>"" + status + "" </div>"";
        }
    }

    function ConvertToVisit_Databound(status,guid) {
        if (status == 'Visited') {
            return `<a class='tooltip-success grid-btn' data-rel='tooltip' title='Visited' data-original-title='Visited'>
                        <span class='green'>
                            <i class='ace-icon fa fa-check bigger-120'></i>
                        </span>
                    </a>`;
        } else {
            return `<a class='tooltip-success gri");
            WriteLiteral("d-btn\' onClick=\'ConvertReserveToVisited(this);\' data-id=\'${guid}\' data-rel=\'tooltip\' title=\'");
#nullable restore
#line 271 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                                                                                                                        Write(status_title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-original-title='ConvertToVisited'>
                        <span class='grey'>
                            <i class='ace-icon fa fa-check bigger-120'></i>
                        </span>
                    </a>`;
        }
    }

    function ConvertReserveToVisited(element) {

        $(""#ConvertToVisitModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#ConvertToVisitModal').modal('toggle');
        var Id = $(element).attr('data-id');
        $('#btn-ConvertToVisitModal-accept').attr('data-id', Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");
    }


    $('#btn-ConvertToVisitModal-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#ConvertToVisitModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var Id = $(this).attr('data-id');
        var link = ""/TotalReserves/ConvertToVisit"";

        var token = $(':input:hidden[name*=""Request");
            WriteLiteral(@"VerificationToken""]');
        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                Id: Id
            },
            success: function (response) {
                $('#btn-ConvertToVisitModal-accept').removeAttr(""disabled"");

                if (response === 0) {

                    $(""#ConvertToVisitModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""Visited"") {

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else {

                    $('#ConvertToVisitModal').modal('hide');
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader""");
            WriteLiteral(@").addClass(""hidden"");
                    $(""#kendoTotalReserveGrid"").find("".k-pager-refresh"").click();
                }

            }
        });
    });


    function PayVisitModal(element) {

        $(""#ShowReceiveModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");
        $(""#ShowReceiveModal #EmptyDoctor"").addClass(""hidden"");
        $(""#ShowReceiveModal #ERROR_Data"").addClass(""hidden"");
        $(""#TxtReserveDetailId"").val(Id);

        $("".loader"").removeClass(""hidden"");

        $('#ShowReceiveModal').modal('toggle');

        var link = ""/Visit/PayVisitModal?reserveDetailId="";
        var Id = $(element).attr('data-id');

        $('#ShowReceiveModal-body').load(link + Id, function (responce) {

            if (responce === ""NoVisit"") {
                $('#ShowReceiveModal').modal('toggle');
                bootbox.alert({
                    message: reserveToQueue,
                    className: 'bootbox-class'
                });
            }

            $(");
            WriteLiteral(@""".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function closeReceiveModal() {

        $('#ShowReceiveModal').modal('hide');
        $('#ShowReceiveModal-body').empty();
        $("".modal-backdrop:last"").remove();

    }


    function DeletePayVisitFunction(element) {

        $(""#DeletePayVisitModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeletePayVisitModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#DeletePayVisitModal').modal('toggle');
        var Id = $(element).attr('data-id');
        $('#btn-DeletePayVisitModal-accept').attr('data-id', Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");
    }


    $('#btn-DeletePayVisitModal-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);
        
        $(""#DeletePayVisitModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity");
            WriteLiteral(@""").addClass(""hidden"");
        $(""#DeletePayVisitModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var Id = $(this).attr('data-id');
        var link = ""/Visit/RemovePayVisit"";

        var token = $(':input:hidden[name*=""RequestVerificationToken""]');
        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                Id: Id
            },
            success: function (response) {
                $('#btn-DeletePayVisitModal-accept').removeAttr(""disabled"");

                if (response === ""SUCCESSFUL"") {
                    $('#DeletePayVisitModal').modal('hide');
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#serviceKendoGrid .k-pager-refresh"")[0].click();

                }
                el");
            WriteLiteral(@"se if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {
                    $(""#DeletePayVisitModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""ERROR_SomeThingWentWrong"") {
                    $(""#DeletePayVisitModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""AreYouSure"") {
                    AskForDelete(Id);
                }
                else if (response === ""CanNotDelete"") {
                    CanNotDelete();
                } else {
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    });


    function PeriodsC");
            WriteLiteral(@"hange() {

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
            $(""#kendoTotalReserveGrid"").find("".k-pager-refresh"").click();
        }
    }

    function btnSearchClick() {

        $(""#kendoTotalReserveGrid"").find("".k-pager-refresh"").click();
    }

    function DeleteReserve(element) {

        bootbox.confirm('");
#nullable restore
#line 471 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                    Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', function (result) {

            if (!result) {
                return;
            } else {

                $("".loader"").removeClass(""hidden"");
                var token = $(':input:hidden[name*=""RequestVerificationToken""]');
                var Id = $(element).attr('data-id');

                var link = ""/TotalReserves/Remove"";

                $.ajax({
                    url: link,
                    type: ""Post"",
                    data: {
                        __RequestVerificationToken: token.attr('value'),
                        Id: Id
                    },
                    success: function (response) {
                        if (response === ""SUCCESSFUL"") {

                            $(""#kendoTotalReserveGrid .k-pager-refresh"")[0].click();

                        } else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {

                            bootbox.alert({
                                message: '");
#nullable restore
#line 498 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                     Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                className: \'bootbox-class\'\r\n                            });\r\n\r\n                        } else if (response === \"Visited\") {\r\n\r\n                            bootbox.alert({\r\n                                message: \'");
#nullable restore
#line 505 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
                                     Write(Localizer["ThisReserveAlreadyIsVisited"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                className: \'bootbox-class\'\r\n                            });\r\n\r\n                        } else {\r\n\r\n                            bootbox.alert({\r\n                                message: \'");
#nullable restore
#line 512 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\TotalReserves\wpTotalReservesForm.cshtml"
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

</script>
");
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
