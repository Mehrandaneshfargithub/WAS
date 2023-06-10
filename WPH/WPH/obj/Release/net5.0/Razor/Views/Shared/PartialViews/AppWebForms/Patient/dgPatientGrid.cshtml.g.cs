#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Patient\dgPatientGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5b2f693bfdab6cd9002f47edaee131ce1e4a07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Patient.Views_Shared_PartialViews_AppWebForms_Patient_dgPatientGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Patient/dgPatientGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Patient
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
#line 1 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Patient\dgPatientGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a5b2f693bfdab6cd9002f47edaee131ce1e4a07", @"/Views/Shared/PartialViews/AppWebForms/Patient/dgPatientGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Patient_dgPatientGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Patient\dgPatientGrid.cshtml"
  
    string edit_title = Localizer["EditPatient"];
    string remove_title = Localizer["RemovePatient"];
    string variable_title = Localizer["PatientVariable"];
    string disease_title = Localizer["PatientDisease"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 13 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Patient\dgPatientGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.Patient.PatientViewModel>()
    .Name("kendoPatientGrid")
    .HtmlAttributes(new { ID = "idGridPatientList", Class = "k-grid-header" })
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeletePatient)
            {
                columns.Bound("").Title(" ").Width(30)
                .ClientTemplate(
                    $@"<a class='tooltip-error grid-btn' onClick='GridDeleteFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                     </a>
                ");

            }

            if ((bool)ViewBag.AccessEditPatient)
            {
                columns.Bound("").Title(" ").Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn edit' onClick='EditPatient(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if (HttpContextAccessor.HttpContext.Session.GetString("SectionTypeName") == "Clinic")
            {
                columns.Bound("").Title(string.Empty).Width(30)
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn' onClick='GridPatientDiseaseRecordFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='{disease_title}' data-original-title='PatientDisease'>
                         <span class='green'>
                            <i class='ace-icon fa fa-book bigger-120'></i>
                         </span>
                     </a>
                 ");

                columns.Bound("").Title(string.Empty).Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn' onClick='GridPatientVariablesFunction(this);' data-id='#=Guid#' data-name='#=Name#' data-rel='tooltip' title='{variable_title}' data-original-title='PatientVariable'>
                        <span class='green'>
                            <i class='ace-icon fa fa-folder-open bigger-120'></i>
                        </span>
                    </a>
                 ");
            }

            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.DateOfBirth).ClientTemplate("#=PatinetAge(DateOfBirth)#").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            if (HttpContextAccessor.HttpContext.Session.GetString("SectionTypeName") == "Clinic")
            {
                columns.Bound(x => x.FormNumber).ClientTemplate("#if(FileNumChoose) {# #=FormNumber  ##}  else {# #=FileNum ##}#").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["FormNumber"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            }
            columns.Bound(x => x.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(5).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).Width(30);
            columns.Bound(x => x.Id).Hidden();
            columns.Bound(x => x.BloodType).Hidden();
            columns.Bound(x => x.UserName).Hidden();
            columns.Bound(x => x.Facebook).Hidden();
            columns.Bound(x => x.Active).Hidden();
            columns.Bound(x => x.FileNumChoose).Hidden();
            columns.Bound(x => x.Email).Hidden();
        }
        else
        {
            columns.Bound(x => x.FileNumChoose).Hidden();
            columns.Bound(x => x.Active).Hidden();
            columns.Bound(x => x.Email).Hidden();
            columns.Bound(x => x.Facebook).Hidden();
            columns.Bound(x => x.UserName).Hidden();
            columns.Bound(x => x.BloodType).Hidden();
            columns.Bound(x => x.Id).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Width(5).Title("#").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).Width(30);
            columns.Bound(x => x.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["PatientName"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            if (HttpContextAccessor.HttpContext.Session.GetString("SectionTypeName") == "Clinic")
            {
                columns.Bound(x => x.FormNumber).ClientTemplate("#if(FileNumChoose) {# #=FormNumber  ##}  else {# #=FileNum ##}#").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["FormNumber"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            }
            columns.Bound(x => x.DateOfBirth).ClientTemplate("#=PatinetAge(DateOfBirth)#").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Age"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.UserGenderName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Gender"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Guid).Hidden();


            if (HttpContextAccessor.HttpContext.Session.GetString("SectionTypeName") == "Clinic")
            {
                columns.Bound("").Title(string.Empty).Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn' onClick='GridPatientVariablesFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='{variable_title}' data-original-title='PatientVariable'>
                        <span class='green'>
                            <i class='ace-icon fa fa-folder-open bigger-120'></i>
                        </span>
                    </a>
                ");

                columns.Bound("").Title(string.Empty).Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn' onClick='GridPatientDiseaseRecordFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='{disease_title}' data-original-title='PatientDisease'>
                        <span class='green'>
                            <i class='ace-icon fa fa-book bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessEditPatient)
            {
                columns.Bound("").Title(" ").Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn edit' onClick='EditPatient(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }


            if ((bool)ViewBag.AccessDeletePatient)
            {
                columns.Bound("").Title(" ").Width(30)
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='GridDeleteFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
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
        .PageSize(10)
        .Read(read => read.Action("GetAll", "Patient"))
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

        $(""#kendoPatientGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoPatientGrid"").find(""tr.k-state-selected td a.edit"").click();

        });
    })


    function PatinetAge(birthDate) {

        if (birthDate === null)
            return """";
        var today = new Date();
        var age = today.getFullYear() - birthDate.getFullYear();
        var m = today.getMonth() - birthDate.getMonth();
        if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
            age--;
            m = 12 + m;
        }

        var Age = age + '  year ' + m + ' month ';

        return Age;
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
