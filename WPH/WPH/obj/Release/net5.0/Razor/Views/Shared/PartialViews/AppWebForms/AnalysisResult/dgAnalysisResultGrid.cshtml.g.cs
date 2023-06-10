#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResult\dgAnalysisResultGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28aa58f280c50881e2448faf735e87a0c911cf7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.AnalysisResult.Views_Shared_PartialViews_AppWebForms_AnalysisResult_dgAnalysisResultGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/AnalysisResult/dgAnalysisResultGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.AnalysisResult
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
#line 1 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResult\dgAnalysisResultGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28aa58f280c50881e2448faf735e87a0c911cf7f", @"/Views/Shared/PartialViews/AppWebForms/AnalysisResult/dgAnalysisResultGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_AnalysisResult_dgAnalysisResultGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResult\dgAnalysisResultGrid.cshtml"
  
    string edit_title = Localizer["EditAnalysisResult"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\AnalysisResult\dgAnalysisResultGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.PatientReception.PatientReceptionViewModel>()
    .Name("kendoPatientReceptionGrid")
    .HtmlAttributes(new { ID = "idGridSymptomList", Class = "k-grid-header" })
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {


            columns.Bound("").Title(string.Empty).Width(30)
            .ClientTemplate(
                $@"<a class='tooltip-success grid-btn edit' onClick='GoToAnalysisResult(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                    <span class='green'>
                        <i class='ace-icon fa fa-pencil bigger-120'></i>
                    </span>
                </a>
            ");


            columns.Bound(x => x.InvoiceNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceDate).Filterable(false).Format("{0: dd/MM/yyyy}").Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Patient.User.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Patient.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Patient.Age).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Patient.User.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(5).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).Width(30);
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Id).Hidden();
        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Id).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Width(5).Title("#").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).Width(30);
            columns.Bound(x => x.Patient.User.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Patient.Age).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Patient.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Patient.User.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.InvoiceDate).Filterable(false).Format("{0: dd/MM/yyyy}").Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.InvoiceNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound("").Title(string.Empty).Width(30).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-success grid-btn edit' onClick='GoToAnalysisResult(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                    <span class='green'>
                        <i class='ace-icon fa fa-pencil bigger-120'></i>
                    </span>
                </a>
            ");

        }

    })

        .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(false)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .Sort(sort=>sort.Add("InvoiceDate").Descending())
        .PageSize(10)
        .Read(read => read.Action("GetAll", "PatientReception").Data("GetPeriodForPatentReception"))
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

        $(""#kendoPatientReceptionGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoPatientReceptionGrid"").find(""tr.k-state-selected td a.edit"").click();

        });

    })

    function GoToAnalysisResult(element) {
        $("".loader"").removeClass(""hidden"");
        let id = $(element).attr(""data-id"");
        $("".page-content"").load(""/AnalysisResult/EditModal?Id="" + id, function (responce) {

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
