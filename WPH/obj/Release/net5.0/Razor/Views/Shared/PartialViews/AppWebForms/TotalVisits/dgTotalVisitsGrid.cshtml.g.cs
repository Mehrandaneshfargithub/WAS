#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\dgTotalVisitsGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d886ddd1e41f3cccb6881fafa867bfda83dab692"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.TotalVisits.Views_Shared_PartialViews_AppWebForms_TotalVisits_dgTotalVisitsGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/TotalVisits/dgTotalVisitsGrid.cshtml")]
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\dgTotalVisitsGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d886ddd1e41f3cccb6881fafa867bfda83dab692", @"/Views/Shared/PartialViews/AppWebForms/TotalVisits/dgTotalVisitsGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_TotalVisits_dgTotalVisitsGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\dgTotalVisitsGrid.cshtml"
  

    string detail_title = Localizer["PrescriptionDetail"];
    string remove_title = Localizer["RemoveVisit"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TotalVisits\dgTotalVisitsGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.Visit.VisitViewModel>()
    .Name("kendoTotalVisitGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeleteTotalVisits)
            {

                columns.Bound("").Title(string.Empty).Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='DeleteVisit(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
               $@"<a class='tooltip-success grid-btn edit' onClick='ShowVisitHistory(this)' data-id='#=Guid#' data-rel='tooltip' title='{detail_title}' data-original-title='History'>
                    <span class='green'>
                        <i class='ace-icon fa fa-list-ul bigger-120'></i>
                    </span>
                </a>
            ");

            //columns.Bound(x => x.VisitTime).Title(@ViewBag.TimeTranslated).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.VisitDate).Format("{0:dd/MM/yyyy}").Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.StatusName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Status"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ReserveDetail.Patient.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            if (ViewBag.useform)
            {
                columns.Bound(x => x.ReserveDetail.Patient.FormNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientRecordNumber"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            }
            else
            {
                columns.Bound(x => x.ReserveDetail.Patient.FileNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientRecordNumber"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            }
            columns.Bound(x => x.ReserveDetail.Patient.Age).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ReserveDetail.Patient.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ReserveDetail.Patient.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.StatusId).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).Width(40);
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {

            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).Width(40);
            columns.Bound(x => x.StatusId).Hidden();
            columns.Bound(x => x.ReserveDetail.Patient.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ReserveDetail.Patient.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            if (ViewBag.useform)
            {
                columns.Bound(x => x.ReserveDetail.Patient.FormNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientRecordNumber"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            }
            else
            {
                columns.Bound(x => x.ReserveDetail.Patient.FileNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientRecordNumber"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            }columns.Bound(x => x.ReserveDetail.Patient.Age).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ReserveDetail.Patient.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("startswith").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.StatusName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Status"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.VisitDate).Format("{0:dd/MM/yyyy}").Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            //columns.Bound(x => x.VisitTime).Title(@ViewBag.TimeTranslated).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
               $@"<a class='tooltip-success grid-btn edit' onClick='ShowVisitHistory(this)' data-id='#=Guid#' data-rel='tooltip' title='{detail_title}' data-original-title='History'>
                    <span class='green'>
                        <i class='ace-icon fa fa-list-ul bigger-120'></i>
                    </span>
                </a>
            ");

            if ((bool)ViewBag.AccessDeleteTotalVisits)
            {
                columns.Bound("").Title(string.Empty).Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='DeleteVisit(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }
        }

    })

        .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(false)
        .Sort(x=>x.Add("VisitDate").Descending())
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(10)
        .Read(read => read.Action("GetAllVisits", "Visit").Data("GetPeriodForAllVisits"))
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


<script>

    $(document).ready(function () {

        $(""#kendoTotalVisitGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoTotalVisitGrid"").find(""tr.k-state-selected td a.edit"").click();

        });

    })

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
