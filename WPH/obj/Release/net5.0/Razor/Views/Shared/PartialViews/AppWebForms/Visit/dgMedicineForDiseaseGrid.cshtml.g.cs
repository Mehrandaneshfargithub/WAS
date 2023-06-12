#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Visit\dgMedicineForDiseaseGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110f07a82cc94c3ba2067b5a9ab4a1ebe8b8ffe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Visit.Views_Shared_PartialViews_AppWebForms_Visit_dgMedicineForDiseaseGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Visit/dgMedicineForDiseaseGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Visit
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110f07a82cc94c3ba2067b5a9ab4a1ebe8b8ffe9", @"/Views/Shared/PartialViews/AppWebForms/Visit/dgMedicineForDiseaseGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Visit_dgMedicineForDiseaseGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 3 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Visit\dgMedicineForDiseaseGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.Disease.Medicine_DiseaseViewModel>()
    .Name("KendoMedicineDiseaseGrid")
    .HtmlAttributes(new { ID = "idGridSymptomList", Class = "k-grid-header" })
    .Selectable(selectable => selectable
            .Mode(GridSelectionMode.Multiple))
    .PersistSelection(true) 
    .Columns(columns =>
    {

        

            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Id).Hidden();
            columns.Select().Width(50).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.MedicineJoineryName).Width(1000).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title("MedicineName").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.MedicineId).Hidden();
        

    })

        .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(false)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(10)
        .Read(read => read.Action("GetAllMedicineForDisease", "Visit").Data("GetDiseaseIdForMedicines"))
        )
        .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
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
