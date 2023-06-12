#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Product\dgProductSaleReportGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aebf11169c7ce2b4ad1075084511a82f0c69842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Product.Views_Shared_PartialViews_AppWebForms_Product_dgProductSaleReportGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Product/dgProductSaleReportGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Product
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Product\dgProductSaleReportGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aebf11169c7ce2b4ad1075084511a82f0c69842", @"/Views/Shared/PartialViews/AppWebForms/Product/dgProductSaleReportGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Product_dgProductSaleReportGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div style=\"clear:both\">\r\n\r\n    ");
#nullable restore
#line 9 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Product\dgProductSaleReportGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.Product.ProductReportResultViewModel>()
    .Name("saleReportKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {


            //if ((bool)ViewBag.AccessDeleteStoreroom)
            //{
            //    columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            //    .ClientTemplate(
            //        "#if(ChildrensCount < 1){#  <a class='tooltip-error grid-btn' onClick='GridMaterialProductDeleteFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='" + remove_title + @"' data-original-title='Delete'>
            //            <span class='red'>
            //                <i class='ace-icon fa fa-trash-can bigger-120'></i>
            //            </span>
            //        </a>#}#
            //    ");
            //}

            columns.Bound(x => x.TotalSaleAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.TotalSaleCurrency).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.DiscountCurrency).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.MoneyConvert).Title(Localizer["MoneyConvert"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.SalePrice).Title(Localizer["SalePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.PriceCurrency).Title(Localizer["PurchasePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.FreeNum).Format("{0:#,0.##}").Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Num).Format("{0:#,0.##}").Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.BujNumber).Title(Localizer["BujNumber"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ExpireDate).Title(Localizer["ExpireDate"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Description).Title(Localizer["Description"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Supplier_Customer).Title(Localizer["Supplier"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceNum).Title(Localizer["InvoiceNum"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceDate).Title(Localizer["InvoiceDate"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.InvoiceDate).Title(Localizer["InvoiceDate"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.InvoiceNum).Title(Localizer["InvoiceNum"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Supplier_Customer).Title(Localizer["Supplier"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Description).Title(Localizer["Description"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ExpireDate).Title(Localizer["ExpireDate"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.BujNumber).Title(Localizer["BujNumber"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Num).Format("{0:#,0.##}").Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.FreeNum).Format("{0:#,0.##}").Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.PriceCurrency).Format("{0:#,0.##}").Title(Localizer["PurchasePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.SalePrice).Format("{0:#,0.##}").Title(Localizer["SalePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.MoneyConvert).Title(Localizer["MoneyConvert"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.DiscountCurrency).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.TotalSaleCurrency).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.TotalSaleAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });




            //if ((bool)ViewBag.AccessDeleteStoreroom)
            //{
            //    columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            //    .ClientTemplate(
            //        "#if(ChildrensCount < 1){#<a class='tooltip-error grid-btn' onClick='GridMaterialProductDeleteFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='" + remove_title + @"' data-original-title='Delete'>
            //            <span class='red'>
            //                <i class='ace-icon fa fa-trash-can bigger-120'></i>
            //            </span>
            //        </a>#}#
            //    ");
            //}


        }
    })
        //.DataSource(dataSource => dataSource
        //.Ajax()
        //.ServerOperation(false)
        //.Model(model =>
        //{
        //    model.Id(p => p.Guid);
        //})
        //    .PageSize(10)
        //    .Read(read => read.Action("GetAll", "Product").Data("GetClinicSectionId"))
        //)
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

        //$(""#saleReportKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

        //    click_dblClick = false;
        //    $(""#saleReportKendoGrid"").find(""tr.k-state-selected td a.edit"").click();
        //});

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
