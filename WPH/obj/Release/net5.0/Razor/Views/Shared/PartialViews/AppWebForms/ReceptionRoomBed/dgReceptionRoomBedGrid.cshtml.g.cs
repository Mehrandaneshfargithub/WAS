#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f061798fb5b71a10734a16e7e756a6dd1a37a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReceptionRoomBed.Views_Shared_PartialViews_AppWebForms_ReceptionRoomBed_dgReceptionRoomBedGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReceptionRoomBed/dgReceptionRoomBedGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ReceptionRoomBed
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
#nullable restore
#line 3 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f061798fb5b71a10734a16e7e756a6dd1a37a2a", @"/Views/Shared/PartialViews/AppWebForms/ReceptionRoomBed/dgReceptionRoomBedGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReceptionRoomBed_dgReceptionRoomBedGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <div class=\"row page-header clearfix\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 278, "\"", 486, 2);
            WriteAttributeValue("  ", 286, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 9 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                       if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("pull-right\r\n");
#nullable restore
#line 11 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                }
                else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("pull-left\r\n");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 288, 197, false);
            WriteAttributeValue(" ", 485, "", 486, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h1");
            BeginWriteAttribute("class", " class=\"", 505, "\"", 985, 1);
            WriteAttributeValue("", 513, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 15 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                        if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 17 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 19 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 513, 472, false);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n                ");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
           Write(Localizer["History"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h1>

        </div>
    </div>
    <script>

        function btnSearchClick() {
            var period = $(""#periods"").data(""kendoDropDownList"");

            var periodValue = period.value();


            $('#period-id').attr('data-Value', periodValue);
            $(""#receptionRoomBedKendoGrid .k-pager-refresh"")[0].click();

        }

        function PeriodsChange() {

            var period = $(""#periods"").data(""kendoDropDownList"");

            var periodValue = period.value();


            $('#period-id').attr('data-Value', periodValue);

            var fromTo = $(""#FromTo"").text();

            if (periodValue === fromTo) {
                $("".date_item"").removeClass(""hidden"");
                let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
                date.element.focus();
                date.element.select();
            }

            else {
                $("".date_item"").addClass(""hidden"");
                $(""#receptionRoomBedK");
            WriteLiteral("endoGrid .k-pager-refresh\")[0].click();\r\n            }\r\n\r\n        }\r\n\r\n        function historyFilterChange() {\r\n            $(\"#receptionRoomBedKendoGrid .k-pager-refresh\")[0].click();\r\n        }\r\n    </script>\r\n\r\n    <div>\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 2314, "\"", 2554, 3);
            WriteAttributeValue("", 2322, "display:flex;align-items:center;", 2322, 32, true);
            WriteAttributeValue(" ", 2354, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 69 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                                      if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {


#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("direction: rtl;\r\n");
#nullable restore
#line 72 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("direction: ltr;\r\n");
#nullable restore
#line 75 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
            }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 2355, 198, false);
            WriteAttributeValue(" ", 2553, "", 2554, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <label class=\"block clearfix\" style=\"margin:0px 10px;flex:3;\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 77 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                     Write(Localizer["Room"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 79 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                Write(Html.Kendo().DropDownList()
                    .Name("HistoryRoom")
                    .DataTextField("SectionRoomName")
                    .DataValueField("Guid")
                    .OptionLabel(" ")
                    .Filter("contains")
                    .DataSource(source =>
                    {
                    source.Read(read =>
                    {
                    read.Action("GetAllRooms", "Room");
                    })
                    .ServerFiltering(false);
                    })
                    .Events(e =>
                    {
                    e.Change("historyFilterChange");
                    })
                    .HtmlAttributes(new { style = "width: 100%;" })
                    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </span>
            </label>
            <script>
                function FilterRoom() {
                    return {
                        roomId: $(""#HistoryRoom"").val()
                    };
                }
                function FilterHistory() {

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
     ");
            WriteLiteral(@"               if (frDay < 10)
                        frDay = ""0"" + frDay;
                    if (toDay < 10)
                        toDay = ""0"" + toDay;

                    let from = frDate.getFullYear() + ""-"" + frMonth + ""-"" + frDay;
                    let too = tDate.getFullYear() + ""-"" + toMonth + ""-"" + toDay;


                    return {
                        periodId: periodId,
                        dateFrom: from,
                        dateTo: too,
                        roomId: $(""#HistoryRoom"").val(),
                        roomBedId: $(""#HistoryRoomBed"").val(),
                        patientId: $(""#HistoryPatient"").val()
                    };
                }
            </script>
            <label class=""block clearfix"" style=""margin:0px 10px;flex:3;"">
                <label for=""form-field-8"">");
#nullable restore
#line 145 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                     Write(Localizer["RoomBed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 147 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                Write(Html.Kendo().DropDownList()
                    .Name("HistoryRoomBed")
                    .DataTextField("Name")
                    .DataValueField("Guid")
                    .OptionLabel(" ")
                    .DataSource(source =>
                    {
                    source.Read(read =>
                    {
                    read.Action("GetRoomBedByRoomId", "RoomBed").Data("FilterRoom");
                    })
                    .ServerFiltering(true);
                    })
                    .AutoBind(false)
                    .Filter("contains")
                    .CascadeFrom("HistoryRoom")
                    .Events(e =>
                    {
                    e.Change("historyFilterChange");
                    })
                    .HtmlAttributes(new { style = "width: 100%;" })
                    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n\r\n            <label class=\"block clearfix\" style=\"margin:0px 10px;flex:3;\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 173 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                     Write(Localizer["Patient"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 175 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                Write(Html.Kendo().DropDownList()
                    .Name("HistoryPatient")
                    .DataTextField("NamePhone")
                    .DataValueField("Guid")
                    .OptionLabel(" ")
                    .Filter("contains")
                    .DataSource(source =>
                    {
                    source.Read(read =>
                    {
                    read.Action("GetPatientName", "Reception");
                    })
                    .ServerFiltering(false);
                    })
                    .Events(e =>
                    {
                    e.Change("historyFilterChange");
                    })
                    .HtmlAttributes(new { style = "width: 100%;" })
                    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n            <div class=\"block clearfix\" style=\"margin:0px 10px;flex:1;\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n\r\n        <div");
            BeginWriteAttribute("style", " style=\"", 7671, "\"", 7930, 4);
            WriteAttributeValue("", 7679, "margin-top:15px;", 7679, 16, true);
            WriteAttributeValue(" ", 7695, "display:flex;align-items:flex-end;", 7696, 35, true);
            WriteAttributeValue(" ", 7730, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 205 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                                                         if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {


#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("direction: rtl;\r\n");
#nullable restore
#line 208 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("direction: ltr;\r\n");
#nullable restore
#line 211 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
            }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 7731, 198, false);
            WriteAttributeValue(" ", 7929, "", 7930, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n            <label class=\"block clearfix\" style=\"margin:0px 10px;flex:3;\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 215 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                     Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 217 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
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
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n\r\n            <label class=\" block clearfix \" style=\"margin:0px 10px;flex:3;\">\r\n                <span class=\"date_item hidden\">\r\n                    <label for=\"form-field-8\">");
#nullable restore
#line 231 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                         Write(Localizer["FromDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n                    <span class=\"block input-icon input-icon-right\">\r\n                        ");
#nullable restore
#line 233 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                    Write(Html.Kendo().DatePicker()
                        .Name("KendoFromDate")
                        .Value(DateTime.Now)
                        .Format("dd/MM/yyyy")
                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </span>\r\n            </label>\r\n\r\n            <label class=\" block clearfix \" style=\"margin:0px 10px;flex:3;\">\r\n                <span class=\"date_item hidden\">\r\n                    <label for=\"form-field-8\">");
#nullable restore
#line 245 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                                         Write(Localizer["ToDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n                    <span class=\"block input-icon input-icon-right\">\r\n                        ");
#nullable restore
#line 247 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                    Write(Html.Kendo().DatePicker()
                        .Name("KendoDateTo")
                        .Value(DateTime.Now)
                        .Format("dd/MM/yyyy")
                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </span>\r\n            </label>\r\n\r\n            <div class=\" block clearfix \" style=\"margin:0px 10px;flex:1;\">\r\n                <span class=\"date_item hidden\">\r\n                    ");
#nullable restore
#line 259 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
                Write(Html.Kendo().Button()
                    .Name("btn-search-room")
                    .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem", type = "button", @class = "k-primary ", onclick = "btnSearchClick()" })
                    .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 272 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionRoomBed\dgReceptionRoomBedGrid.cshtml"
    Write(Html.Kendo().Grid<WPH.Models.ReceptionRoomBed.ReceptionRoomBedViewModel>()
        .Name("receptionRoomBedKendoGrid")
        .Columns(columns =>
        {
            if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
            {

                columns.Bound(x => x.ExitDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: HH:mm}").Title(Localizer["Time"] + " " + Localizer["Exit"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.ExitDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: dd/MM/yyyy}").Title(Localizer["Date"] + " " + Localizer["Exit"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.EntranceDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: HH:mm}").Title(Localizer["Time"] + " " + Localizer["Entrance"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.EntranceDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: dd/MM/yyyy}").Title(Localizer["Date"]+" "+ Localizer["Entrance"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.PatientName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.RoomBedName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Bed"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.RoomName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Room"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Guid).Hidden();
                columns.Bound(x => x.Id).Hidden();

            }
            else
            {
                columns.Bound(x => x.Guid).Hidden();
                columns.Bound(x => x.Id).Hidden();
                columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.RoomName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Room"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.RoomBedName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Bed"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.PatientName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.EntranceDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: dd/MM/yyyy}").Title(Localizer["Date"] + " " + Localizer["Entrance"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.EntranceDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: HH:mm}").Title(Localizer["Time"] + " " + Localizer["Entrance"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.ExitDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: dd/MM/yyyy}").Title(Localizer["Date"] + " " + Localizer["Exit"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                columns.Bound(x => x.ExitDate).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Format("{0: HH:mm}").Title(Localizer["Time"] + " " + Localizer["Exit"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            }
        })

        .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(false)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(10)
        .Read(read => read.Action("GetAll", "ReceptionRoomBed").Data("FilterHistory"))
        )
        .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
        .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
        .Pageable(pageable => pageable
        .Input(true)
        .Refresh(true)
        .PageSizes(true)
        .ButtonCount(5)
        .Numeric(true)) // Enable paging
        .Sortable().HtmlAttributes(new { @style = "direction: ltr;margin-top:2rem;overflow:auto" }) // Enable sorting
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
