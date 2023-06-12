#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgPurchaseInvoiceDetailSelectGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993ba222bc354e884b879ac0fcb55ecad614ed48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReturnPurchaseInvoiceDetail.Views_Shared_PartialViews_AppWebForms_ReturnPurchaseInvoiceDetail_dgPurchaseInvoiceDetailSelectGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoiceDetail/dgPurchaseInvoiceDetailSelectGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ReturnPurchaseInvoiceDetail
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgPurchaseInvoiceDetailSelectGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993ba222bc354e884b879ac0fcb55ecad614ed48", @"/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoiceDetail/dgPurchaseInvoiceDetailSelectGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReturnPurchaseInvoiceDetail_dgPurchaseInvoiceDetailSelectGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div style=\" width: 100%;\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"col-sm-6 hidden\" id=\"multiReasonContainer\">\r\n            <label class=\"block clearfix \">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 11 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgPurchaseInvoiceDetailSelectGrid.cshtml"
                                     Write(Localizer["Reason"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgPurchaseInvoiceDetailSelectGrid.cshtml"
                Write(Html.Kendo().AutoComplete()
                    .Name("MultiReason")
                    .DataTextField("Name")
                    .Filter("contains")
                    .HighlightFirst(true)
                    .ClearButton(false)
                    .DataSource(source =>
                    {
                        source.Read(read =>
                        {
                            read.Action("GetAllReasons", "BaseInfo");
                        })
                        .ServerFiltering(false);
                    })
                    .HtmlAttributes(new { style = "width:100%;"})
                    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n                <span id=\"MultiReason-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                    ");
#nullable restore
#line 31 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgPurchaseInvoiceDetailSelectGrid.cshtml"
               Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n        </div>\r\n    </div>\r\n\r\n    <div style=\"clear:both;\">\r\n\r\n        ");
#nullable restore
#line 39 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgPurchaseInvoiceDetailSelectGrid.cshtml"
    Write(Html.Kendo().Grid<WPH.Models.ReturnPurchaseInvoiceDetail.ReturnPurchaseInvoiceDetailSelectViewModel>()
        .Name("purchaseHistoryKendoGrid")
        .Columns(columns =>
        {

            if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
            {

                columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= CheckBox_Databound(Guid,TransferDetailId,RemainingNum,PurchasePrice,Currency,InvoiceNum,InvoiceDateTxt,ExpireDateTxt)#");

                columns.Bound(x => x.Consideration).Title(Localizer["Consideration"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.RemainingNum).Title(Localizer["Rem"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.SellingPriceCurrency).Title(Localizer["SalePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.TotalAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= TotalAfterDiscount_Databound(TotalAfterDiscount,Currency)#");
                columns.Bound(x => x.Discount).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= Discount_Databound(Discount,Currency)#");
                columns.Bound(x => x.Total).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= TotalCurrency_Databound(Total,Currency)#");
                columns.Bound(x => x.PurchaseCurrency).Title(Localizer["PurchasePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.FreeNum).Format("{0:#,#.##}").Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Num).Format("{0:#,#.##}").Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.ExpireDate).Title(Localizer["ExpDate"]).Format("{0: dd/MM/yyyy}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.BujNumber).Title(Localizer["BujNumber"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.MainInvoiceNum).Title(Localizer["MainInvoiceNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.InvoiceDate).Title(Localizer["Date"]).Format("{0: dd/MM/yyyy}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.InvoiceNum).Title(Localizer["InvoiceNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.ReturnType).Title(Localizer["Type"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.ExpireDateTxt).Hidden();
                columns.Bound(x => x.InvoiceDateTxt).Hidden();
                columns.Bound(x => x.PurchasePrice).Hidden();
                columns.Bound(x => x.Currency).Hidden();
                columns.Bound(x => x.TransferDetailId).Hidden();
                columns.Bound(x => x.Guid).Hidden();
            }
            else
            {
                columns.Bound(x => x.Guid).Hidden();
                columns.Bound(x => x.TransferDetailId).Hidden();
                columns.Bound(x => x.PurchasePrice).Hidden();
                columns.Bound(x => x.Currency).Hidden();
                columns.Bound(x => x.InvoiceDateTxt).Hidden();
                columns.Bound(x => x.ExpireDateTxt).Hidden();
                columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.ReturnType).Title(Localizer["Type"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.InvoiceNum).Title(Localizer["InvoiceNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.InvoiceDate).Title(Localizer["Date"]).Format("{0: dd/MM/yyyy}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.MainInvoiceNum).Title(Localizer["MainInvoiceNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.BujNumber).Title(Localizer["BujNumber"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.ExpireDate).Title(Localizer["ExpDate"]).Format("{0: dd/MM/yyyy}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Num).Format("{0:#,#.##}").Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.FreeNum).Format("{0:#,#.##}").Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.PurchaseCurrency).Title(Localizer["PurchasePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Total).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= TotalCurrency_Databound(Total,Currency)#");
                columns.Bound(x => x.Discount).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= Discount_Databound(Discount,Currency)#");
                columns.Bound(x => x.TotalAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= TotalAfterDiscount_Databound(TotalAfterDiscount,Currency)#");
                columns.Bound(x => x.SellingPriceCurrency).Title(Localizer["SalePrice"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.RemainingNum).Title(Localizer["Rem"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                columns.Bound(x => x.Consideration).Title(Localizer["Consideration"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

                columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= CheckBox_Databound(Guid,TransferDetailId,RemainingNum,PurchasePrice,Currency,InvoiceNum,InvoiceDateTxt,ExpireDateTxt)#");

            }
        })

            .DataSource(dataSource => dataSource
            .Ajax()
            .ServerOperation(false)
            .Model(model =>
            {
                model.Id(p => p.Index);
            })
            .PageSize(10)
            .Read(read => read.Action("GetDetailsForReturn", "PurchaseInvoiceDetail").Data("GetParametersForSelectReturn"))
            )
            .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
            .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
            .Pageable(pageable => pageable
            .Input(true)
            .Refresh(true)
            .PageSizes(true)
            .ButtonCount(5)
            .Numeric(true)) // Enable paging
            .Sortable().HtmlAttributes(new { @style = "direction:ltr;" }) // Enable sorting
        );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>


<script>
    var set_show = 0;

    function TotalCurrency_Databound(Total, CurrencyName) {

        if (Total == 0)
            return 0;

        return `<div style=""white-space: nowrap;margin: 0px 2px;""> ${CurrencyName} ${parseFloat(Total).toLocaleString('en')} </div>`;
    }

    function Discount_Databound(Discount, CurrencyName) {

        if (Discount == 0)
            return 0;

        return `<div style=""white-space: nowrap;margin: 0px 2px;""> ${CurrencyName} ${parseFloat(Discount).toLocaleString('en')} </div>`;
    }

    function TotalAfterDiscount_Databound(TotalAfterDiscount, CurrencyName) {

        if (TotalAfterDiscount == 0)
            return 0;

        return `<div style=""white-space: nowrap;""> ${CurrencyName} ${parseFloat(TotalAfterDiscount).toLocaleString('en')} </div>`;
    }

    function SelectReturnChange(element) {
        
        if (element.checked == true) {
            set_show++;
        } else {
            set_show--;");
            WriteLiteral(@"
        }


        if (set_show > 1)
            $(""#multiReasonContainer"").removeClass(""hidden"");
        else
            $(""#multiReasonContainer"").addClass(""hidden"");
    }


    $(""#MultiReason"").on(""focus"", function (e) {
        let reason = $('#MultiReason').data(""kendoAutoComplete"");
        let value = reason.value();
        reason.search(value);
    });

    function CheckBox_Databound(Guid, TransferDetailId, RemainingNum, PurchasePrice, Currency, InvoiceNum, InvoiceDate, ExpireDateTxt) {

        return `<div style=''> <input type=""checkbox"" class=""k-checkbox select_return"" style="""" data-txt=""${InvoiceNum} | ${InvoiceDate} | ${ExpireDateTxt}"" data-currency=""${Currency}""  data-rem=""${RemainingNum}"" data-price=""${PurchasePrice}"" data-id=""${Guid}"" data-transfer=""${TransferDetailId}"" onchange=""SelectReturnChange(this)"" /> </div>`;
    }

    $(document).ready(function () {

        //$(""#purchaseHistoryKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {
");
            WriteLiteral("\n        //    $(\"#purchaseHistoryKendoGrid\").find(\"tr.k-state-selected td a.edit\").click();\r\n\r\n        //});\r\n\r\n    })\r\n\r\n</script>");
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
