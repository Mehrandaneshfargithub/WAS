#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisItem\dgAnalysisItemGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdb14f63dbc87395bf47af7a12ebe25fad57d8b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.AnalysisItem.Views_Shared_PartialViews_AppWebForms_AnalysisItem_dgAnalysisItemGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/AnalysisItem/dgAnalysisItemGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.AnalysisItem
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisItem\dgAnalysisItemGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb14f63dbc87395bf47af7a12ebe25fad57d8b5", @"/Views/Shared/PartialViews/AppWebForms/AnalysisItem/dgAnalysisItemGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_AnalysisItem_dgAnalysisItemGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisItem\dgAnalysisItemGrid.cshtml"
  

    string edit_title = Localizer["EditAnalysisItem"];
    string remove_title = Localizer["RemoveAnalysisItem"];
    string up_title = Localizer["IncreasePriority"];
    string down_title = Localizer["DecreasePriority"];
    string chart_title = Localizer["CreateChartInResult"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 17 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisItem\dgAnalysisItemGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.AnalysisItem.AnalysisItemViewModel>
    ()
    .Name("kendoAnalysisItemGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeleteAnalysisItem)
            {
                columns.Bound("").Title(" ").Width(10)
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='GridDeleteFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete' data-toggle='modal'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessEditAnalysisItem)
            {
                columns.Bound("").Title(" ").Width(10)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn edit' onClick='EditAnalysisItem(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            columns.Bound("").Title(string.Empty).Width(30)
            .ClientTemplate(
               $@"<a class='tooltip-success grid-btn' onClick='GridAnalysisItemUpPriorityFunction(this);' data-id='#=Guid#' data-Priority='#=Priority#' data-rel='tooltip' title='{up_title}' data-original-title='Up'>
                    <span class='blue'>
                        <i class='ace-icon fa fa-arrow-up bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound("").Title(string.Empty).Width(30)
            .ClientTemplate(
               $@"<a class='tooltip-success grid-btn' onClick='GridAnalysisItemDownPriorityFunction(this);' data-id='#=Guid#' data-Priority='#=Priority#' data-rel='tooltip' title='{down_title}' data-original-title='Down'>
                    <span class='red'>
                        <i class='ace-icon fa fa-arrow-down bigger-120'></i>
                    </span>
                </a>
            ");

            if (HttpContextAccessor.HttpContext.Session.GetString("ClinicSectionName") != "Radiology")
            {
                columns.Bound("").Title(" ").Width(30).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                   "#if(ValueTypeName!='Optional'){#<a class='tooltip-success grid-btn ' onClick='CreateChartInResult(this)' data-id='#=Guid#' data-rel='tooltip' title='" + chart_title + "' data-original-title='CreateChartInResult'> " +
                        @"<span class='#if(ShowChart){#green#}else{#grey#}#'>
                            <i class='ace-icon fa fa-chart-column bigger-120'></i>
                        </span>
                    </a>#}#
                ");
            }


            columns.Bound(x => x.ModifiedUserName).Filterable(false).Title(Localizer["Name"] + ' ' + Localizer["User"] + '(' + Localizer["Modified"] + ')').HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.CreatedUserName).Filterable(false).Title(Localizer["Name"] + ' ' + Localizer["User"] + '(' + Localizer["New"] + ')').HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ValueTypeName).Filterable(false).Width(50).Title(Localizer["Type"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.UnitName).Filterable(false).Width(50).Title(Localizer["Unit"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            if (ViewBag.useDollar == "true")
            {
                columns.Bound(x => x.AmountCurrencyName).Filterable(false).Width(50).Title(Localizer["Type"] + ' ' + Localizer["Currency"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            }
            columns.Bound(x => x.Amount).Filterable(false).Width(100).Format("{0:n0}").Title(Localizer["Amount"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.NormalValues).Filterable(false).Title(Localizer["NormalRange"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Note).Filterable(false).Width(100).Title(Localizer["AnalysisNote"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Abbreviation).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Width(50).Title(Localizer["Abbreviation"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Code).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Width(30).Title(Localizer["Code"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["AnalysisItemName"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(10).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Priority).Hidden();
            columns.Bound(x => x.ShowChart).Hidden();
        }
        else
        {
            columns.Bound(x => x.ShowChart).Hidden();
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Priority).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(10).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Width(300).Title(Localizer["AnalysisItemName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Code).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Width(300).Title(Localizer["Code"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Abbreviation).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Width(300).Title(Localizer["Abbreviation"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Note).Filterable(false).Title(Localizer["AnalysisNote"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.NormalValues).Filterable(false).Title(Localizer["NormalRange"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Amount).Filterable(false).Format("{0:n0}").Title(Localizer["Amount"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            if (ViewBag.useDollar == "true")
            {
                columns.Bound(x => x.AmountCurrencyName).Filterable(false).Width(50).Title(Localizer["Type"] + ' ' + Localizer["Currency"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            }
            columns.Bound(x => x.UnitName).Filterable(false).Width(300).Title(Localizer["Unit"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ValueTypeName).Filterable(false).Width(50).Title(Localizer["Type"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.CreatedUserName).Filterable(false).Title(Localizer["Name"] + ' ' + Localizer["User"] + '(' + Localizer["New"] + ')').HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ModifiedUserName).Filterable(false).Title(Localizer["Name"] + ' ' + Localizer["User"] + '(' + Localizer["Modified"] + ')').HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            if (HttpContextAccessor.HttpContext.Session.GetString("ClinicSectionName") != "Radiology")
            {
                columns.Bound("").Title(" ").Width(30).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                   "#if(ValueTypeName!='Optional'){#<a class='tooltip-success grid-btn ' onClick='CreateChartInResult(this)' data-id='#=Guid#' data-rel='tooltip' title='" + chart_title + "' data-original-title='CreateChartInResult'> " +
                        @"<span class='#if(ShowChart){#green#}else{#grey#}#'>
                            <i class='ace-icon fa fa-chart-column bigger-120'></i>
                        </span>
                    </a>#}#
                ");
            }


            columns.Bound("").Title(string.Empty).Width(30)
            .ClientTemplate(
               $@"<a class='tooltip-success grid-btn' onClick='GridAnalysisItemDownPriorityFunction(this);' data-id='#=Guid#' data-Priority='#=Priority#' data-rel='tooltip' title='{down_title}' data-original-title='Down'>
                    <span class='red'>
                        <i class='ace-icon fa fa-arrow-down bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound("").Title(string.Empty).Width(30)
            .ClientTemplate(
               $@"<a class='tooltip-success grid-btn' onClick='GridAnalysisItemUpPriorityFunction(this);' data-id='#=Guid#' data-Priority='#=Priority#' data-rel='tooltip' title='{up_title}' data-original-title='Up'>
                    <span class='blue'>
                        <i class='ace-icon fa fa-arrow-up bigger-120'></i>
                    </span>
                </a>
            ");

            if ((bool)ViewBag.AccessEditAnalysisItem)
            {
                columns.Bound("").Title(" ").Width(10)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn edit' onClick='EditAnalysisItem(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessDeleteAnalysisItem)
            {
                columns.Bound("").Title(" ").Width(10)
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='GridDeleteFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete' data-toggle='modal'>
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
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(100)
        .Read(read => read.Action("GetAll", "AnalysisItem").Data("GetPeriodForAnalysisItem"))
        )
        .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
        .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
        .Pageable(pageable => pageable
        .Input(true)
        .Refresh(true)
        .PageSizes(true)
        .ButtonCount(5)
        .Numeric(true)) // Enable paging
        .Sortable().HtmlAttributes(new { @style = "direction: ltr;margin-top:2rem;font-size:1.3rem;overflow:auto", @class = "MyFont-Roboto-grid" }) // Enable sorting
    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>

    $(document).ready(function () {


        $(""#kendoAnalysisItemGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoAnalysisItemGrid"").find(""tr.k-state-selected td a.edit"").click();

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
