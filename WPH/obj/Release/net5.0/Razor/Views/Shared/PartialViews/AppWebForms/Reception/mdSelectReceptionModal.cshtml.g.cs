#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa18a93d09035784680eedf1419a0bc5a7b46f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Reception.Views_Shared_PartialViews_AppWebForms_Reception_mdSelectReceptionModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Reception/mdSelectReceptionModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Reception
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
#line 3 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa18a93d09035784680eedf1419a0bc5a7b46f1", @"/Views/Shared/PartialViews/AppWebForms/Reception/mdSelectReceptionModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Reception_mdSelectReceptionModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<input class=\"hidden\" type=\"text\" id=\"period-id\" data-Value=\"");
#nullable restore
#line 8 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                                                        Write(Model.periods.FirstOrDefault().Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<h1 id=\"FromTo\" class=\"hidden\">");
#nullable restore
#line 9 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                          Write(ViewBag.FromToId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"space-10\"></div>\r\n<div");
            BeginWriteAttribute("class", " class=\"", 409, "\"", 893, 2);
            WriteAttributeValue("", 417, "row", 417, 3, true);
            WriteAttributeValue(" ", 420, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 12 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 16 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 421, 472, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
            WriteLiteral("\r\n    <div class=\"col-xs-2\" style=\"padding-left:unset;padding-right:unset;\">\r\n        ");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
    Write(Html.Kendo().DropDownList()
        .Name("periods")
        .BindTo(Model.periods)
        .DataTextField("Name")
        .DataValueField("Id")
        .Filter("contains")

        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "PeriodsChangeData()" })
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-xs-10\">\r\n\r\n        <div id=\"DateFromDiv\" class=\"col-xs-12 col-sm-5 hidden\">\r\n            <div class=\"col-xs-4 \" style=\"text-align:left\">\r\n\r\n                <h5 class=\"MyFont-Roboto-grid\">");
#nullable restore
#line 37 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                                          Write(Localizer["FromDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n            </div>\r\n            <div class=\"col-xs-8\">\r\n                ");
#nullable restore
#line 41 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
            Write(Html.Kendo().DatePicker()
                .Name("KendoFromDate")
                .Value(DateTime.Now)
                .Format("dd/MM/yyyy")
                .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div id=\"DateToDiv\" class=\"col-xs-12 col-sm-5 hidden\">\r\n\r\n            <div class=\"col-xs-4\" style=\"text-align:left\">\r\n                <h5 class=\"MyFont-Roboto-grid\">");
#nullable restore
#line 54 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                                          Write(Localizer["ToDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n\r\n            <div class=\"col-xs-8\">\r\n\r\n                ");
#nullable restore
#line 59 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
            Write(Html.Kendo().DatePicker()
                .Name("KendoDateTo")
                .Value(DateTime.Now)
                .Format("dd/MM/yyyy")
                .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div id=\"SearchBtnDiv\" class=\"col-xs-1 hidden\">\r\n\r\n            ");
#nullable restore
#line 71 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
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
        function GetPeriodForReception() {

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

        //var period = document.getElementById('sections');
        //var periodValu");
            WriteLiteral("e = $(\"#sections\").attr(\'data-Value\');\r\n        //var periodText = $(\"#sections\").attr(\'data-text\');\r\n        \r\n        var periodValue = \'");
#nullable restore
#line 112 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                      Write(ViewBag.SectionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var periodText = \'");
#nullable restore
#line 113 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
                     Write(ViewBag.SectionText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        let section = { Id: periodValue, Name: periodText }

        return {

            periodId: periodId,
            dateFrom: from,
            dateTo: too,
            section: section,
            receptionId: old_reception_value,
            status: 1
        };
    }
</script>

<div>
    ");
#nullable restore
#line 130 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.PatientReception.PatientReceptionViewModel>()
    .Name("kendoPatientReceptionGrid")
    .HtmlAttributes(new { ID = "idGridSymptomList", Class = "k-grid-header" })
    .Columns(columns =>
    {

    if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
    {
    columns.Bound("").Title("").Width(30)
    .ClientTemplate(
    @"<a class='tooltip-success grid-btn ' onClick='SelectPatientReception(this);' data-id='#=Guid#' data-bed='#=RoomBedId#' data-rel='tooltip' title='Select' data-original-title='Edit'>
    <span class='green'>
    <i class='ace-icon fa fa-check-square-o bigger-120'></i>
    </span>
    </a>
    ");

    columns.Bound(x => x.RoomBedName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Room|Bed"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.User.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.Age).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.User.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.InvoiceNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.InvoiceDate).Filterable(false).Format("{0: dd/MM/yyyy}").Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Index).Filterable(false).Width(5).Title("#").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).Width(30);
    columns.Bound(x => x.RoomBedId).Hidden();
    columns.Bound(x => x.Guid).Hidden();
    columns.Bound(x => x.Id).Hidden();
    }
    else
    {
    columns.Bound(x => x.Guid).Hidden();
    columns.Bound(x => x.RoomBedId).Hidden();
    columns.Bound(x => x.Id).Hidden();
    columns.Bound(x => x.Index).Filterable(false).Title("#").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).Width(30);
    columns.Bound(x => x.InvoiceDate).Filterable(false).Format("{0: dd/MM/yyyy}").Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.InvoiceNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.User.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.Age).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.Patient.User.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
    columns.Bound(x => x.RoomBedName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Room|Bed"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

    columns.Bound("").Title("").Width(30)
    .ClientTemplate(
    @"<a class='tooltip-success grid-btn ' onClick='SelectPatientReception(this);' data-id='#=Guid#' data-bed='#=RoomBedId#' data-rel='tooltip' title='Select' data-original-title='Edit'>
    <span class='green'>
    <i class='ace-icon fa fa-check-square-o bigger-120'></i>
    </span>
    </a>
    ");

    }

    })

    .DataSource(dataSource => dataSource
    .Ajax()
    .Model(model =>
    {
    model.Id(p => p.Guid);
    })
    //.Sort(sort => sort.Add("InvoiceDate").Descending())
    .PageSize(10)
    .Read(read => read.Action("GetAllForRoomBed", "PatientReception").Data("GetPeriodForReception"))
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
            WriteLiteral(@"
</div>

<div id=""DeleteRoomBedModal-body"" class=""modal-body"">
    <div id=""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"" class=""red label-white middle hidden"" style=""height:40px;display:block;margin-top:2rem"">
        <i class=""ace-icon fa fa-stop bigger-120""></i>
        ");
#nullable restore
#line 212 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
   Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n        <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n        ");
#nullable restore
#line 216 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Reception\mdSelectReceptionModal.cshtml"
   Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<script>
    function PeriodsChangeData() {

        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();


        $('#period-id').attr('data-Value', periodValue);

        var fromTo = $(""#FromTo"").text();

        if (periodValue === fromTo) {
            $(""#DateFromDiv"").removeClass(""hidden"");
            $(""#DateToDiv"").removeClass(""hidden"");
            $(""#SearchBtnDiv"").removeClass(""hidden"");
            let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
            date.element.focus();
            date.element.select();
        }

        else {
            $(""#DateFromDiv"").addClass(""hidden"");
            $(""#DateToDiv"").addClass(""hidden"");
            $(""#SearchBtnDiv"").addClass(""hidden"");
            $(""#kendoPatientReceptionGrid"").find("".k-i-reload"").click();
        }

    }

    function SectionChange() {

        $(""#kendoPatientReceptionGrid"").find("".k-i-reload"").click();

    }

   ");
            WriteLiteral(@" function btnSearchClick() {
        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();


        $('#period-id').attr('data-Value', periodValue);
        $(""#kendoPatientReceptionGrid"").find("".k-i-reload"").click();

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
            //date.element.select();
        }


    });

    $('#KendoFromDate').focus(function (e) {

        let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
        date.element.select();

    });

    $('#KendoDateTo')");
            WriteLiteral(@".keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            $(""#btn-search-visit"").focus();
        }

    });


    $('#KendoDateTo').focus(function (e) {

        let date = $(""#KendoDateTo"").data(""kendoDatePicker"");
        date.element.select();

    });


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
