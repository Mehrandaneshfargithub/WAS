#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDetail\dgSaleInvoiceDetailReceiveHistoryGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14142aafcf5ff3fb7897d5e8dd4193a17c465b5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.SaleInvoiceDetail.Views_Shared_PartialViews_AppWebForms_SaleInvoiceDetail_dgSaleInvoiceDetailReceiveHistoryGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/SaleInvoiceDetail/dgSaleInvoiceDetailReceiveHistoryGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.SaleInvoiceDetail
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDetail\dgSaleInvoiceDetailReceiveHistoryGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14142aafcf5ff3fb7897d5e8dd4193a17c465b5c", @"/Views/Shared/PartialViews/AppWebForms/SaleInvoiceDetail/dgSaleInvoiceDetailReceiveHistoryGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_SaleInvoiceDetail_dgSaleInvoiceDetailReceiveHistoryGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDetail\dgSaleInvoiceDetailReceiveHistoryGrid.cshtml"
  
    string edit_title = Localizer["EditSaleInvoice"];
    string remove_title = Localizer["Remove"];
    string discount_title = Localizer["SaleInvoiceDiscount"];
    string cost_title = Localizer["SaleInvoiceCost"];
    string total_title = Localizer["SaleInvoiceTotalPrice"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 id=\"currencyId-receiveAmount-history\" class=\"hidden\">");
#nullable restore
#line 14 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDetail\dgSaleInvoiceDetailReceiveHistoryGrid.cshtml"
                                                    Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<script>

    let id = $(""#currencyId-receiveAmount-history"").text();

    function GetSaleInvoiceId() {

        return {
            SaleInvoiceId: $(""#Guid"").val(),
            CurrencyId: id
        }

    }

</script>

<div>
    ");
#nullable restore
#line 32 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDetail\dgSaleInvoiceDetailReceiveHistoryGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.Receive.ReceiveAmountViewModel>()
    .Name("SaleInvoiceReceiveHistoryKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if((bool)ViewBag.AccessDeleteReceiveAmount)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='DeleteReceiveAmount(this);' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }


            columns.Bound(x => x.AmountTxt).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Amount"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ReceiveDate).Format("{0: dd/MM/yyyy}").Filterable(false).Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ReceiveDate).Format("{0: dd/MM/yyyy}").Filterable(false).Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.AmountTxt).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Amount"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            if ((bool)ViewBag.AccessDeleteReceiveAmount)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='DeleteReceiveAmount(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete'>
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
            .Read(read => read.Action("GetAllReceiveAmount", "Receive").Data("GetSaleInvoiceId"))
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

    function Total_Databound(total) {
        let text = """";
        if (total != null) {

            let res = total.toString().split(""_"");
            for (let i = 0; i < res.length; i++) {
                text += ""<div style=''>"" + res[i] + "" </div>"";
            }
        }
        return text;
    }

    function DeleteReceiveAmount(element) {

        let guid = $(element).attr('data-id');


        bootbox.confirm({
            message: ""Delete This Record?"",
            className: 'bootbox-class MyFont-Sarchia-grid',
            buttons: {
                confirm: {
                    label: 'Yes',
                    className: 'k-primary k-button'
                },
                cancel: {
                    label: 'No',
                    className: 'k-button'
                }
            },
            callback: function (result) {

                if (result) {

                    $.ajax({
                        data: { Id: guid ");
            WriteLiteral(@"},
                        url: ""/Receive/RemoveReceiveAmount"",
                        type: ""Post"",
                        success: function (response) {
                            if (response != 0) {

                                $(""#SaleInvoiceReceiveHistoryKendoGrid"").find("".k-i-reload"").click();

                            }
                        }
                    });


                }
                else {
                    return;
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
