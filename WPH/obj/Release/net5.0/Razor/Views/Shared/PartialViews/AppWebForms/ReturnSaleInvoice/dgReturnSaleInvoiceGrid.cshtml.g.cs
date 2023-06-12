#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\dgReturnSaleInvoiceGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49dc635cf7718939c0e3bd3bfa6b6d8109c95245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReturnSaleInvoice.Views_Shared_PartialViews_AppWebForms_ReturnSaleInvoice_dgReturnSaleInvoiceGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReturnSaleInvoice/dgReturnSaleInvoiceGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ReturnSaleInvoice
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\dgReturnSaleInvoiceGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49dc635cf7718939c0e3bd3bfa6b6d8109c95245", @"/Views/Shared/PartialViews/AppWebForms/ReturnSaleInvoice/dgReturnSaleInvoiceGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReturnSaleInvoice_dgReturnSaleInvoiceGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\dgReturnSaleInvoiceGrid.cshtml"
  
    string edit_title = Localizer["EditReturnSaleInvoice"];
    string remove_title = Localizer["RemoveReturnSaleInvoice"];
    string discount_title = Localizer["ReturnReturnSaleInvoice"];
    string total_title = Localizer["ReturnSaleInvoiceTotalPrice"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\dgReturnSaleInvoiceGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.ReturnSaleInvoice.ReturnSaleInvoiceViewModel>()
    .Name("returnSaleInvoiceKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if((bool)ViewBag.AccessDeleteReturnSaleInvoice)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-error grid-btn' onClick='GridDeleteFunctionWithPass(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessEditReturnSaleInvoice)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn edit' onClick='EditReturnSaleInvoice(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            //columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            //.ClientTemplate(
            //    $@"<a class='tooltip-success grid-btn ' onClick='ShowDiscountsList(this)' data-id='#=Guid#' data-rel='tooltip' title='{discount_title}' data-original-title='Discounts'>
            //        <span class='purple'>
            //            <i class='ace-icon fa fa-percent bigger-120'></i>
            //        </span>
            //    </a>
            //");

            //columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            //.ClientTemplate(
            //    $@"<a class='tooltip-success grid-btn ' onClick='ShowTotalPrice(this)' data-id='#=Guid#' data-rel='tooltip' title='{total_title}' data-original-title='Total'>
            //        <span class='green'>
            //            <i class='ace-icon  fa-regular fa-envelope-open-text  bigger-120'></i>
            //        </span>
            //    </a>
            //");

            columns.Bound(x => x.Description).Filterable(false).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.TotalPrice).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Total_Databound(TotalPrice)#");
            columns.Bound(x => x.TotalDiscount).Title(Localizer["TotalDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Total_Databound(TotalDiscount)#");
            columns.Bound(x => x.TotalPrice).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= AddDiscount(TotalDiscount,TotalPrice)#");
            columns.Bound(x => x.CustomerName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Customer"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceDate).Format("{0: dd/MM/yyyy}").Filterable(false).Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.InvoiceDate).Format("{0: dd/MM/yyyy}").Filterable(false).Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceNum).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.CustomerName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Customer"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.TotalPrice).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= AddDiscount(TotalDiscount,TotalPrice)#");
            columns.Bound(x => x.TotalDiscount).Title(Localizer["TotalDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Total_Databound(TotalDiscount)#");
            columns.Bound(x => x.TotalPrice).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Total_Databound(TotalPrice)#");
            columns.Bound(x => x.Description).Filterable(false).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            //columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            //.ClientTemplate(
            //    $@"<a class='tooltip-success grid-btn ' onClick='ShowTotalPrice(this)' data-id='#=Guid#' data-rel='tooltip' title='{total_title}' data-original-title='Total'>
            //        <span class='green'>
            //            <i class='ace-icon  fa-regular fa-envelope-open-text  bigger-120'></i>
            //        </span>
            //    </a>
            //");

            //columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
            //.ClientTemplate(
            //    $@"<a class='tooltip-success grid-btn ' onClick='ShowDiscountsList(this)' data-id='#=Guid#' data-rel='tooltip' title='{discount_title}' data-original-title='Discounts'>
            //        <span class='purple'>
            //            <i class='ace-icon fa fa-percent bigger-120'></i>
            //        </span>
            //    </a>
            //");

            if ((bool)ViewBag.AccessEditReturnSaleInvoice)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-success grid-btn edit' onClick='EditReturnSaleInvoice(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }

            if ((bool)ViewBag.AccessDeleteReturnSaleInvoice)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                    $@"<a class='tooltip-error grid-btn' onClick='GridDeleteFunctionWithPass(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
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
            .Read(read => read.Action("GetAll", "ReturnSaleInvoice").Data("GetPeriodAndFilterForRetunSale"))
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


    function AddDiscount(discount, total) {
        if (discount == '' || discount == null || discount == 'null')
            return Total_Databound(total);

        let total_dis = discount.split(""_"");
        let amount = total.split(""_"");
        let result = """";

        for (var i = 0; i < amount.length; i++) {
            var money = amount[i].split("" "");
            var add_dis;

            for (var j = 0; j < total_dis.length; j++) {
                if (total_dis[j].includes(money[0])) {
                    add_dis = total_dis[j];
                    break;
                }
            }

            if (add_dis == '' || add_dis == null || add_dis == 'null') {

                result += `${money[0]} ${money[1]}_`;
            }
            else {
                let sum = Number(GetFirstNumber(money[1]));
                let dis = Number(GetFirstNumber(add_dis));

                sum += dis;

                result += `${money[0]} ${parseFloat(s");
            WriteLiteral(@"um).toLocaleString('en')}_`;
            }
        }

        return Total_Databound(result);
    }

    function Total_Databound(total) {
        let text = """";
        if (total != null) {

            let res = total.toString().split(""_"");
            for (let i = 0; i < res.length; i++) {
                text += ""<div style='white-space: nowrap;'>"" + res[i] + "" </div>"";
            }
        }
        return text;
    }


    $(document).ready(function () {

        $(""#returnSaleInvoiceKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#returnSaleInvoiceKendoGrid"").find(""tr.k-state-selected td a.edit"").click();

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
