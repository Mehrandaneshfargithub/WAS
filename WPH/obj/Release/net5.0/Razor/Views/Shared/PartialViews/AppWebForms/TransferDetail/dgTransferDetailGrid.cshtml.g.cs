#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TransferDetail\dgTransferDetailGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a24de45a96a0207fb4b6577242ed2e2c628e20f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.TransferDetail.Views_Shared_PartialViews_AppWebForms_TransferDetail_dgTransferDetailGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/TransferDetail/dgTransferDetailGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.TransferDetail
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TransferDetail\dgTransferDetailGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a24de45a96a0207fb4b6577242ed2e2c628e20f7", @"/Views/Shared/PartialViews/AppWebForms/TransferDetail/dgTransferDetailGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_TransferDetail_dgTransferDetailGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TransferDetail\dgTransferDetailGrid.cshtml"
  
    string edit_title = Localizer["EditProduct"];
    string remove_title = Localizer["RemoveProduct"];
    string salePrice_title = Localizer["SalePrices"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\TransferDetail\dgTransferDetailGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.TransferDetail.TransferDetailGridViewModel>()
    .Name("transferDetailKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeleteTransferDetail)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-error grid-btn' onClick='TransferDetailDeleteFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessEditTransferDetail)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn edit' onClick='EditTransferDetail(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)(ViewBag.AccessTransferDetailSalePrice ?? false))
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn ' onClick='AddSalePrice(this);' data-id='#=Guid#' data-rel='tooltip' title='{salePrice_title}' data-original-title='SalePrices'>
                        <span class='purple'>
                            <i class='ace-icon fa fa-money-bills bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            columns.Bound(x => x.Consideration).Title(Localizer["Consideration"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            if ((bool)(ViewBag.AccessCanUseWholeSellPrice ?? false))
            {
                columns.Bound(x => x.WholeSellPriceCurrency).Title(Localizer["WholeSellPrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            }
            if ((bool)(ViewBag.AccessCanUseMiddleSellPrice ?? false))
            {
                columns.Bound(x => x.MiddleSellPriceCurrency).Title(Localizer["MiddleSellPrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            }

            columns.Bound(x => x.SellingPriceCurrency).Title(Localizer["SalePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.PurchasePriceCurrency).Title(Localizer["PurchasePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Num).Title(Localizer["Num"]).Format("{0: #,0.##}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ExpireDate).Title(Localizer["ExpDate"]).Format("{0: dd/MM/yyyy}").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.DestinationProductName).Title($"{Localizer["Product"]} - {Localizer["Destination"]}").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ProductName).Title($"{Localizer["Product"]} - {Localizer["Source"]}").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ProductName).Title($"{Localizer["Product"]} - {Localizer["Source"]}").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.DestinationProductName).Title($"{Localizer["Product"]} - {Localizer["Destination"]}").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ExpireDate).Title(Localizer["ExpDate"]).Format("{0: dd/MM/yyyy}").Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Num).Title(Localizer["Num"]).Format("{0: #,0.##}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.PurchasePriceCurrency).Title(Localizer["PurchasePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.SellingPriceCurrency).Title(Localizer["SalePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            if ((bool)(ViewBag.AccessCanUseMiddleSellPrice ?? false))
            {
                columns.Bound(x => x.MiddleSellPriceCurrency).Title(Localizer["MiddleSellPrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            }
            if ((bool)(ViewBag.AccessCanUseWholeSellPrice ?? false))
            {
                columns.Bound(x => x.WholeSellPriceCurrency).Title(Localizer["WholeSellPrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            }

            columns.Bound(x => x.Consideration).Title(Localizer["Consideration"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            if ((bool)(ViewBag.AccessTransferDetailSalePrice ?? false))
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn ' onClick='AddSalePrice(this);' data-id='#=Guid#' data-rel='tooltip' title='{salePrice_title}' data-original-title='SalePrices'>
                        <span class='purple'>
                            <i class='ace-icon fa fa-money-bills bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessEditTransferDetail)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn edit' onClick='EditTransferDetail(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessDeleteTransferDetail)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-error grid-btn' onClick='TransferDetailDeleteFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
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
        .Read(read => read.Action("GetAll", "TransferDetail").Data("GetTransferId"))
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

        $(""#transferDetailKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#transferDetailKendoGrid"").find(""tr.k-state-selected td a.edit"").click();

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
