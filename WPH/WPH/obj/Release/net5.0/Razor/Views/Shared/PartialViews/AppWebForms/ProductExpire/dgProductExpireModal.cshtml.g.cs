#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductExpire\dgProductExpireModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99227d670bf3215d0eb2d68a04be8a595f203a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ProductExpire.Views_Shared_PartialViews_AppWebForms_ProductExpire_dgProductExpireModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ProductExpire/dgProductExpireModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ProductExpire
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductExpire\dgProductExpireModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99227d670bf3215d0eb2d68a04be8a595f203a6", @"/Views/Shared/PartialViews/AppWebForms/ProductExpire/dgProductExpireModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ProductExpire_dgProductExpireModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductExpire\dgProductExpireModal.cshtml"
  
    string select_title = Localizer["SelectProduct"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h1 id=\"ExpireProductId\" class=\"hidden\">");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductExpire\dgProductExpireModal.cshtml"
                                       Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    ");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductExpire\dgProductExpireModal.cshtml"
Write(Html.Kendo().Grid<WPH.Models.Product.ProductWithExpireViewModel>()
    .Name("productExpireKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-error grid-btn edit' onClick='SelectExpire(this);' data-id='#=Guid#' data-type='#=SaleType#'   data-rel='tooltip' title='{select_title}' data-original-title='select'>
                    <span class='green'>
                        <i class='ace-icon fa fa-check-square bigger-120'></i>
                    </span>
                </a>
            ");

            //columns.Bound(x => x.PurchaseDate).Format("{0: dd/MM/yyyy}").Title(Localizer["PurchaseDate"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Stock).Format("{0:N0}").Title(Localizer["Number"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ExpireDate).Format("{0: dd/MM/yyyy}").Title(Localizer["ExpireDate"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.SaleType).Title(Localizer["Name"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.SaleType).Title(Localizer["Name"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ExpireDate).Format("{0: dd/MM/yyyy}").Title(Localizer["ExpireDate"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Stock).Format("{0:N0}").Title(Localizer["Number"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            //columns.Bound(x => x.PurchaseDate).Format("{0: dd/MM/yyyy}").Title(Localizer["PurchaseDate"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-error grid-btn edit' onClick='SelectExpire(this);' data-id='#=Guid#' data-type='#=SaleType#' data-rel='tooltip' title='{select_title}' data-original-title='select'>
                    <span class='green'>
                        <i class='ace-icon fa fa-check-square bigger-120'></i>
                    </span>
                </a>
            ");
        }
    })

        .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(true)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
            .PageSize(10)
            .Read(read => read.Action("GetAllProductExpireList", "Product", new { Id = Model }))
        )
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

        $(""#productKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#productKendoGrid"").find(""tr.k-state-selected td a.edit"").click();

        });

    })

    function SelectExpire(element) {
        let saleTypeText = $(""#SalePriceTypeId"").data(""kendoDropDownList"").dataItem();

        let saleType = saleTypeText.Name;
        //let saleType = $(""#SalePriceTypeId"").data(""kendoDropDownList"").text();

        let Guid = $(element).attr('data-id');
        let type = $(element).attr('data-type');
        let productId = $(""#ExpireProductId"").text();
        let latsetPrice = $(""#LatestSellingPrice"").is("":checked"");

        $.ajax({
            data: { InvoiceId: Guid, InvoiceType: type, SaleType: saleType, ProductId: productId, LatestPrice: latsetPrice },
            url: ""/Product/GetProductDetailsFromExpireList"",
            /**/
            success: function (response) {
       ");
            WriteLiteral(@"         /**/
                if (response != 0) {
                    SetProductDetails(response, productId);
                    
                    $('#ExpireListModal').modal('toggle');
                    $('#ExpireListModal-body').empty();
                    const freeNumChild = $(""#SaleInvoiceDetailKendoGrid tr:eq(1) td[data-field='Num']"");
                    const freeNumIndex = $(freeNumChild).parent().children().index(freeNumChild);
                    let grid = $(""#SaleInvoiceDetailKendoGrid"").data(""kendoGrid"");

                    grid.editCell($(""#SaleInvoiceDetailKendoGrid tr:eq(1) td:eq("" + freeNumIndex + "")""));
                }
                else {
                    $(""#ProductStock-box"").removeClass(""hidden"");
                }
            }
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guid> Html { get; private set; }
    }
}
#pragma warning restore 1591
