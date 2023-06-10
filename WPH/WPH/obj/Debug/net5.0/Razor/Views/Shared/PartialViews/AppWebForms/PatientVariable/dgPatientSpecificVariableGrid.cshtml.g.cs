#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientVariable\dgPatientSpecificVariableGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24e81aa96be9fba0433b1448a3967ff0cb78297c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.PatientVariable.Views_Shared_PartialViews_AppWebForms_PatientVariable_dgPatientSpecificVariableGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/PatientVariable/dgPatientSpecificVariableGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.PatientVariable
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
#line 3 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientVariable\dgPatientSpecificVariableGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e81aa96be9fba0433b1448a3967ff0cb78297c", @"/Views/Shared/PartialViews/AppWebForms/PatientVariable/dgPatientSpecificVariableGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_PatientVariable_dgPatientSpecificVariableGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.BaseInfo.SectionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientVariable\dgPatientSpecificVariableGrid.cshtml"
  
    string remove_title = Localizer["RemoveVariableValue"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 12 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\PatientVariable\dgPatientSpecificVariableGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.PatientVariableValue.PatientVariablesValueViewModel>()
        .Name("PatientVariablesValueKendoGrid")
        .Columns(columns =>
        {
        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
        columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
        .ClientTemplate(
           $@"<a class='tooltip-error grid-btn edit' onClick='DeleteReceptionTemperature(this);' data-id='#=Guid#' data-type='PatientVariable' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                <span class='red'>
                    <i class='ace-icon fa fa-trash-can bigger-120'></i>
                </span>
            </a>
        ");

        columns.Bound(x => x.Value).Title(Localizer["PatientProgress"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
        columns.Bound(x => x.VariableInsertedDate).Filterable(false).Format("{0: dd/MM/yyyy HH:mm}").Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
        columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
        columns.Bound(x => x.Guid).Hidden();
        columns.Bound(x => x.ReceptionId).Hidden();

        }
        else
        {
        columns.Bound(x => x.ReceptionId).Hidden();
        columns.Bound(x => x.Guid).Hidden();
        columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
        columns.Bound(x => x.VariableInsertedDate).Filterable(false).Format("{0: dd/MM/yyyy HH:mm}").Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
        columns.Bound(x => x.Value).Title(Localizer["PatientProgress"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

        columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
        .ClientTemplate(
           $@"<a class='tooltip-error grid-btn edit' onClick='DeleteReceptionTemperature(this)' data-id='#=Guid#' data-type='PatientVariable' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                <span class='red'>
                    <i class='ace-icon fa fa-trash-can bigger-120'></i>
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
        .PageSize(10)
        .Read(read => read.Action("GetAllPatientSpeceficVariable", "Patient",new{ ReceptionId = Model.Id, VariableName = Model.Name }))
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

        $(""#roomKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#roomKendoGrid"").find(""tr.k-state-selected td a.edit"").click();

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.BaseInfo.SectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
