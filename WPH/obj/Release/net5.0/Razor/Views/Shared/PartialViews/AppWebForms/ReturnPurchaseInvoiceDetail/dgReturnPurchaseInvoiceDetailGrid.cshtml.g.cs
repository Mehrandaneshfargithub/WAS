#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74337d57af1b2685d3982c44b97093c5ea9388c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReturnPurchaseInvoiceDetail.Views_Shared_PartialViews_AppWebForms_ReturnPurchaseInvoiceDetail_dgReturnPurchaseInvoiceDetailGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoiceDetail/dgReturnPurchaseInvoiceDetailGrid.cshtml")]
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74337d57af1b2685d3982c44b97093c5ea9388c0", @"/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoiceDetail/dgReturnPurchaseInvoiceDetailGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReturnPurchaseInvoiceDetail_dgReturnPurchaseInvoiceDetailGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
  
    string edit_title = Localizer["EditProduct"];
    string remove_title = Localizer["RemoveProduct"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input id=\"TotalTxt\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 292, "\"", 324, 1);
#nullable restore
#line 12 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
WriteAttributeValue("", 300, Localizer["TotalPrice"], 300, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input id=\"TotalDiscountTxt\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 372, "\"", 407, 1);
#nullable restore
#line 13 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
WriteAttributeValue("", 380, Localizer["TotalDiscount"], 380, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input id=\"TotalPriceAfterDiscountTxt\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 465, "\"", 510, 1);
#nullable restore
#line 14 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
WriteAttributeValue("", 473, Localizer["TotalPriceAfterDiscount"], 473, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<style>

    .elementBox {
        height: 100px;
        border-radius: 0.5rem;
        background-color: #fff;
        padding: 1rem;
        border: 1px solid rgba(0, 0, 0, .125);
        background-clip: border-box;
        box-shadow: rgba(146, 168, 209,0.7) 0px 0px 5px 0.1px;
        overflow-x: hidden;
        overflow-y: auto;
    }

    .elementStyle {
        overflow-wrap: break-word;
        font-size: 18px;
    }
</style>

<script>

    function onDataBound() {
        var data = this.dataSource.data();

        $.each(data, function (i, row) {
            let cont = row.get(""ChildrenCount"");
            if (cont == 1) {
                $('tr[data-uid=""' + row.uid + '""] ').find("".k-hierarchy-cell a"").remove();;
            }
        });
    }
</script>

<div>
    ");
#nullable restore
#line 51 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.ReturnPurchaseInvoiceDetail.ReturnPurchaseInvoiceDetailViewModel>()
    .Name("purchaseInvoiceDetailKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeleteReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
            {
                columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Delete_Databound(Guid,ChildrenCount)#");
            }

            if ((bool)ViewBag.AccessEditReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
            {
                columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Edit_Databound(Guid,ChildrenCount)#");
            }

            columns.Bound(x => x.ReasonTxt).Title(Localizer["Reason"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Reason_Databound(ReasonTxt,ChildrenCount)#");

            columns.Bound(x => x.TotalAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            columns.Bound(x => x.Discount).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= Discount_Databound(Discount,CurrencyName)#");
            columns.Bound(x => x.Total).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= TotalCurrency_Databound(Total,CurrencyName)#");
            columns.Bound(x => x.PurchaseCurrency).Title(Localizer["PurchasePrice"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.FreeNum).Format("{0:#,#.##}").Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Num).Format("{0:#,#.##}").Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            columns.Bound(x => x.ProductName).Title(Localizer["Product"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.ChildrenGuids).Hidden();
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.ChildrenCount).Hidden().HtmlAttributes(new { @class = "ChildrenCount" });

        }
        else
        {
            columns.Bound(x => x.ChildrenCount).Hidden().HtmlAttributes(new { @class = "ChildrenCount" });
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.ChildrenGuids).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.ProductName).Title(Localizer["Product"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            columns.Bound(x => x.Num).Format("{0:#,#.##}").Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.FreeNum).Format("{0:#,#.##}").Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.PurchaseCurrency).Title(Localizer["PurchasePrice"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Total).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= TotalCurrency_Databound(Total,CurrencyName)#");
            columns.Bound(x => x.Discount).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= Discount_Databound(Discount,CurrencyName)#");

            columns.Bound(x => x.TotalAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

            columns.Bound(x => x.ReasonTxt).Title(Localizer["Reason"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Reason_Databound(ReasonTxt,ChildrenCount)#");


            if ((bool)ViewBag.AccessEditReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
            {
                columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Edit_Databound(Guid,ChildrenCount)#");
            }

            if ((bool)ViewBag.AccessDeleteReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
            {
                columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= Delete_Databound(Guid,ChildrenCount)#");
            }
        }
    })
    .ClientDetailTemplateId("template")
    .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(false)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(1000)
        .Read(read => read.Action("GetAll", "ReturnPurchaseInvoiceDetail").Data("GetReturnPurchaseInvoiceId"))
    )
    .Events(events => events
            .DataBound("onDataBound")
        )
    .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
    .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
    .Pageable(pageable => pageable
    .Input(false)
    .Refresh(true)
    .PageSizes(false)
    .ButtonCount(5)
    .Numeric(true)) // Enable paging
    .Sortable().HtmlAttributes(new { @style = "direction: ltr;margin-top:2rem;overflow:auto" }) // Enable sorting
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    <script id=\"template\" type=\"text/kendo-tmpl\">\r\n\r\n        #if(ChildrenCount>1)\r\n        {#");
#nullable restore
#line 145 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
      Write(Html.Kendo().Grid<WPH.Models.ReturnPurchaseInvoiceDetail.SubReturnPurchaseInvoiceDetailViewModel>()
            .Name("kendoGrid_#=Index#")
            .Columns(columns =>
            {

                if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
                {
                    if ((bool)ViewBag.AccessDeleteReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
                    {

                        columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("\\#= Delete_Databound(SubGuid,0)\\#");

                    }

                    if ((bool)ViewBag.AccessEditReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
                    {

                        columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("\\#= Edit_Databound(SubGuid,0)\\#");

                    }

                    columns.Bound(o => o.SubReasonTxt).Title(Localizer["Reason"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubTotalAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubDiscount).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("\\#= SubDiscount_Databound(SubDiscount)\\#");
                    columns.Bound(o => o.SubTotal).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("\\#= SubTotal_Databound(SubTotal)\\#");
                    columns.Bound(o => o.SubPurchaseCurrency).Title(Localizer["PurchasePrice"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubFreeNum).Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubNum).Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubProductName).Title(Localizer["Product"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubIndex).Filterable(false).Width(20).Title(" ").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubGuid).Hidden();

                }
                else
                {
                    columns.Bound(o => o.SubGuid).Hidden();
                    columns.Bound(o => o.SubIndex).Filterable(false).Title(" ").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
                    columns.Bound(o => o.SubProductName).Title(Localizer["Product"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubNum).Title(Localizer["Num"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubFreeNum).Title(Localizer["FreeNum"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubPurchaseCurrency).Title(Localizer["PurchasePrice"]).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubTotal).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("\\#= SubTotal_Databound(SubTotal)\\#");
                    columns.Bound(o => o.SubDiscount).Title(Localizer["Discount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("\\#= SubDiscount_Databound(SubDiscount)\\#");
                    columns.Bound(o => o.SubTotalAfterDiscount).Title(Localizer["TotalAfterDiscount"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
                    columns.Bound(o => o.SubReasonTxt).Title(Localizer["Reason"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });

                    if ((bool)ViewBag.AccessEditReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
                    {
                        columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("\\#= Edit_Databound(SubGuid,0)\\#");

                    }

                    if ((bool)ViewBag.AccessDeleteReturnPurchaseInvoiceDetail && !(bool)(ViewBag.ReturnPurchasePaid ?? false))
                    {
                        columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("\\#= Delete_Databound(SubGuid,0)\\#");

                    }
                }
            })

            .DataSource(dataSource => dataSource
                .Ajax()
                .PageSize(100)
                .Read(read => read.Action("GetAllChildren", "ReturnPurchaseInvoiceDetail", new { children = "#=ChildrenGuids#" }))
            )
            //.Filterable(ftb => ftb.Mode(GridFilterMode.Row))
            //.Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
            .Pageable() // Enable paging
            .Sortable()
            .ToClientTemplate()
            );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"#}
        else
        {# #}#

    </script>

</div>
<div id=""purchaseInvoiceDetailTotalPrice"">

</div>

<script>

    function TotalCurrency_Databound(Total, CurrencyName) {

        if (Total == 0)
            return 0;

        return `<div style=""white-space: nowrap;margin: 0px 2px;""> ${CurrencyName} ${parseFloat(Total).toLocaleString('en')} </div>`;
    }

    function SubTotal_Databound(Total) {

        return `<div style=""white-space: nowrap;margin: 0px 2px;""> ${Total} </div>`;
    }

    function SubDiscount_Databound(Discount) {

        return `<div style=""white-space: nowrap;margin: 0px 2px;""> ${Discount} </div>`;
    }


    function Discount_Databound(Discount, CurrencyName) {

        if (Discount == 0)
            return 0;

        return `<div style=""white-space: nowrap;margin: 0px 2px;""> ${CurrencyName} ${parseFloat(Discount).toLocaleString('en')} </div>`;
    }


    function Reason_Databound(ReasonTxt, ChildrenCount) {

        if (ChildrenCount");
            WriteLiteral(@" > 1) {
            return """";
        }

        return ReasonTxt;
    }

    function Delete_Databound(Guid, ChildrenCount) {

        if (ChildrenCount > 1) {
            return """";
        }

        return `<a class='tooltip-error grid-btn' onClick='ReturnPurchaseInvoiceDetailDeleteFunction(this)' data-id='${Guid}' data-rel='tooltip' title='");
#nullable restore
#line 271 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
                                                                                                                                                   Write(remove_title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-original-title='Delete'>
                    <span class='red'>
                        <i class='ace-icon fa fa-trash-can bigger-120'></i>
                    </span>
                </a>`;
    }

    function Edit_Databound(Guid, ChildrenCount) {

        if (ChildrenCount > 1) {
            return """";
        }

        return `<a class='tooltip-success grid-btn edit' onClick='EditReturnPurchaseInvoiceDetail(this);' data-id='${Guid}' data-rel='tooltip' title='");
#nullable restore
#line 284 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoiceDetail\dgReturnPurchaseInvoiceDetailGrid.cshtml"
                                                                                                                                                 Write(edit_title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-original-title='Edit'>
                    <span class='green'>
                        <i class='ace-icon fa fa-pencil bigger-120'></i>
                    </span>
                </a>`;
    }

    $(document).ready(function () {

        $(""#purchaseInvoiceDetailKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#purchaseInvoiceDetailKendoGrid"").find(""tr.k-state-selected td a.edit"").click();

        });
    })

    function hiddenArrow() {
        let all = $("".k-hierarchy-cell"");

        for (let i = 0; i < all.length; i++) {
            let su = $(all[i]).closest('td').next('td').find('.ChildrenCount');
            console.log(su);
        }
    }

</script>
");
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
