#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b054d69d89f20e1bf6b7f8bba96a8165c14cc900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.CustomerAccount.Views_Shared_PartialViews_AppWebForms_CustomerAccount_dgCustomerAccountGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/CustomerAccount/dgCustomerAccountGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.CustomerAccount
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b054d69d89f20e1bf6b7f8bba96a8165c14cc900", @"/Views/Shared/PartialViews/AppWebForms/CustomerAccount/dgCustomerAccountGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_CustomerAccount_dgCustomerAccountGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
  
    string edit_title = Localizer["EditReceive"];
    string remove_title = Localizer["RemoveReceive"];
    string edit_purchase = Localizer["EditSaleInvoice"];
    string edit_return = Localizer["EditReturnSaleInvoice"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /*    #kendoGrid.k-grid tr td {
        border-color: #000 !important;
    }*/
</style>

<script>

    function KendoGridDataBound(e) {

        var items = $(""#kendoGrid"").data(""kendoGrid"").dataSource.data();

        if (items.length > 0) {

            if (items[0].RecordType == 'Sale') {
                let first_amount = items[0].GetAmount.toString().split(""_"");
                let amount_txt = '';
                let rem_txt = '';
                for (let i = 0; i < first_amount.length; i++) {
                    let money = first_amount[i].split("" "");
                    if (money.length > 1) {

                        let sum = Number(GetFirstNumber(money[1]));
                        amount_txt += `${money[0]} ${parseFloat(sum).toLocaleString('en')}_`;
                        rem_txt += `${money[0]} -${parseFloat(sum).toLocaleString('en')}_`;
                    }
                }
                if (amount_txt != '')
                    items[0].GetAmount =");
            WriteLiteral(@" amount_txt;

                if (rem_txt != '')
                    items[0].Remain = rem_txt;

            } else {

                let first_amount = items[0].GetAmount.toString().split(""_"");
                if (items[0].RecordType == 'Receive')
                    first_amount = items[0].ReceiveAmount.toString().split(""_"");

                let amount_txt = '';
                let rem_txt = '';
                for (let i = 0; i < first_amount.length; i++) {
                    let money = first_amount[i].split("" "");
                    if (money.length > 1) {

                        let sum = Number(GetFirstNumber(money[1]));
                        //if (money[1].includes('-'))
                        //    sum = -sum;

                        amount_txt += `${money[0]} ${parseFloat(sum).toLocaleString('en')}_`;
                        rem_txt += `${money[0]} ${parseFloat(sum).toLocaleString('en')}_`;
                    }
                }
                if (amount_txt != '')");
            WriteLiteral(@"
                    items[0].ReceiveAmount = amount_txt;

                if (rem_txt != '')
                    items[0].Remain = rem_txt;
            }


            for (var row = 1; row < items.length; row++) {

                let Receive_amount = items[row].ReceiveAmount.split(""_"");
                let Receive_txt = '';
                for (let i = 0; i < Receive_amount.length; i++) {
                    let money = Receive_amount[i].split("" "");
                    if (money.length > 1) {

                        let sum = Number(GetFirstNumber(money[1]));
                        //if (money[1].includes('-'))
                        //    sum = -sum;

                        Receive_txt += `${money[0]} ${parseFloat(sum).toLocaleString('en')}_`;
                    }
                }

                if (Receive_txt != '')
                    items[row].ReceiveAmount = Receive_txt;

                var last = items[row - 1].Remain;
                var current = items[row];
");
            WriteLiteral(@"                current.Remain = '';

                if (current.RecordType == 'Sale') {

                    let res = current.GetAmount.toString().split(""_"");

                    for (let i = 0; i < res.length; i++) {
                        let money = res[i].split("" "");

                        if (money.length > 1) {

                            if (last.includes(money[0])) {
                                let last_res = last.toString().split(""_"");

                                for (let j = 0; j < last_res.length; j++) {
                                    if (last_res[j].includes(money[0])) {
                                        let last_money = last_res[j].split("" "");

                                        let sum = Number(GetFirstNumber(money[1]));
                                        let last_sum = Number(GetFirstNumber(last_money[1]));

                                        sum = -sum;

                                        //if (last_money[1].includes(""-""))");
            WriteLiteral(@"
                                        //    last_sum = -last_sum;

                                        sum += last_sum;
                                        current.Remain += `${money[0]} ${parseFloat(sum).toLocaleString('en')}_`;
                                    }
                                }

                            } else {

                                current.Remain += `${money[0]} -${money[1]}_`;
                            }

                        }
                    }

                } else {

                    let res = current.GetAmount.toString().split(""_"");
                    if (current.RecordType == 'Receive')
                        res = current.ReceiveAmount.toString().split(""_"");

                    for (let i = 0; i < res.length; i++) {
                        let money = res[i].split("" "");

                        if (money.length > 1) {

                            if (last.includes(money[0])) {
                                l");
            WriteLiteral(@"et last_res = last.toString().split(""_"");

                                for (let j = 0; j < last_res.length; j++) {
                                    if (last_res[j].includes(money[0])) {
                                        let last_money = last_res[j].split("" "");

                                        let sum = Number(GetFirstNumber(money[1]));
                                        let last_sum = Number(GetFirstNumber(last_money[1]));
                                        //if (money[1].includes('-'))
                                        //    sum = -sum;

                                        //if (last_money[1].includes(""-""))
                                        //    last_sum = -last_sum;

                                        sum += last_sum;
                                        current.Remain += `${money[0]} ${parseFloat(sum).toLocaleString('en')}_`;
                                    }
                                }

                            } else ");
            WriteLiteral(@"{

                                current.Remain += `${money[0]} ${money[1]}_`;
                            }

                        }
                    }


                }


                var last_rem = last.split(""_"");
                var rem = current.Remain;
                for (var i = 0; i < last_rem.length; i++) {
                    let money = last_rem[i].split("" "");
                    if (!rem.includes(money[0]) && money.length > 1) {
                        current.Remain += `${money[0]} ${money[1]}_`;
                    }
                }
            }
        }

    }
</script>

<div>
    ");
#nullable restore
#line 192 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomerAccount.CustomerAccountViewModel>()
    .Name("kendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeleteReceive)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate("#= Delete_Databound(Guid,RecordType,ReceiveType)#");
            }

            if ((bool)ViewBag.AccessEditReceive)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate("#= Edit_Databound(Guid,RecordType,ReceiveType)#");
            }

            columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;height:1px;padding: 0.5rem 0.5rem;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= RecordType_Databound(RecordType,LineColor)#");

            columns.Bound(x => x.Remain).Filterable(false).Title(Localizer["Remain"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= Remain_Databound(Remain)#");
            columns.Bound(x => x.GetAmount).Filterable(false).Title(Localizer["Debt"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= GetAmount_Databound(GetAmount)#");
            columns.Bound(x => x.ReceiveAmount).Filterable(false).Title(Localizer["ReceiveAmount"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= ReceiveAmount_Databound(ReceiveAmount)#");
            columns.Bound(x => x.Description).Filterable(false).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" }).ClientTemplate("#= Description_Databound(Description,RecordType,Invoices,ReceiveType,ReturnInvoices)#");
            columns.Bound(x => x.InvoiceNum).Width(100).Filterable(false).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Date).Filterable(false).Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.RecordType).Hidden();
            columns.Bound(x => x.LineColor).Hidden();
            columns.Bound(x => x.ReceiveType).Hidden();
            columns.Bound(x => x.Invoices).Hidden();
            columns.Bound(x => x.ReturnInvoices).Hidden();
            columns.Bound(x => x.Guid).Hidden();

        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.ReturnInvoices).Hidden();
            columns.Bound(x => x.Invoices).Hidden();
            columns.Bound(x => x.ReceiveType).Hidden();
            columns.Bound(x => x.LineColor).Hidden();
            columns.Bound(x => x.RecordType).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" });
            columns.Bound(x => x.Date).Filterable(false).Title(Localizer["Date"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" });
            columns.Bound(x => x.InvoiceNum).Filterable(false).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" });
            columns.Bound(x => x.Description).Filterable(false).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" }).ClientTemplate("#= Description_Databound(Description,RecordType,Invoices,ReceiveType,ReturnInvoices)#");
            columns.Bound(x => x.ReceiveAmount).Filterable(false).Title(Localizer["ReceiveAmount"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" }).ClientTemplate("#= ReceiveAmount_Databound(ReceiveAmount)#");
            columns.Bound(x => x.GetAmount).Filterable(false).Title(Localizer["Debt"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" }).ClientTemplate("#= GetAmount_Databound(GetAmount)#");
            columns.Bound(x => x.Remain).Filterable(false).Title(Localizer["Remain"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;color:white;" }).ClientTemplate("#= Remain_Databound(Remain)#");

            columns.Bound("").Title("").Filterable(false).HtmlAttributes(new { @style = "text-align:center;height:1px;padding: 0.5rem 0.5rem;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).ClientTemplate("#= RecordType_Databound(RecordType,LineColor)#");

            if ((bool)ViewBag.AccessEditReceive)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate("#= Edit_Databound(Guid,RecordType,ReceiveType)#");
            }

            if ((bool)ViewBag.AccessDeleteReceive)
            {
                columns.Bound("").Title(string.Empty).Width(10).HtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate("#= Delete_Databound(Guid,RecordType,ReceiveType)#");
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
    .PageSize(100)
    .Read(read => read.Action("GetAllCustomerAccount", "CustomerAccount").Data("GetCustomerId"))
    )
    .Events(e=>e.DataBinding("KendoGridDataBound"))
    //.Filterable(ftb => ftb.Mode(GridFilterMode.Row))
    .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
    .Pageable(pageable => pageable
    .Input(true)
    .PageSizes(new int[] {20,50,100 })
    .Refresh(true)
    .PageSizes(true)
    .ButtonCount(5)
    .Numeric(true)) // Enable paging
    .HtmlAttributes(new { @style = "direction: ltr;margin-top:2rem;overflow:auto" }) // Enable sorting
    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>

    function RecordType_Databound(RecordType, LineColor) {

        let text = ""<span style='font-size: 16px;' class='white'>"";

        if (RecordType == 'Sale') {
            text += ` <i class='ace-icon fa fa-file-invoice-dollar bigger-120'></i> `;
        } else if (RecordType == 'Return') {
            text += ` <i class='ace-icon fa fa-rotate-left bigger-120'></i> `;
        } else if (RecordType == 'Receive') {
            text += ` <i class='ace-icon fa fa-credit-card bigger-120'></i> `;
        }

        text += '</span>';

        let color = ""gray"";
        switch (LineColor) {
            case ""brown"":
                color = ""sandybrown"";
                break;
            case ""green"":
                color = ""limegreen"";
                break;
            case ""red"":
                color = ""orangered"";
                break;
            case ""pink"":
                color = ""lightpink"";
                break;
            case ""light_gray"":
 ");
            WriteLiteral(@"               color = ""darkgray"";
                break;
        }

        return `<div style='padding: 3px 0px;display: flex;background:${color};border-radius: 5px;height: 100%;align-items: center;justify-content: center;'>${text}</div>`;

    }

    function Edit_Databound(Guid, RecordType, ReceiveType) {

        let text = """";

        if (RecordType == 'Receive') {
            if (ReceiveType == 'ReceiveInFactor') {
                text = `<a class='tooltip-success grid-btn edit' onClick='GoToSaleByReceive(this)' data-id='${Guid}' data-rel='tooltip' title='");
#nullable restore
#line 329 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
                                                                                                                                          Write(edit_purchase);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>`;
            } else {
                text = `<a class='tooltip-success grid-btn edit' onClick='EditReceive(this)' data-id='${Guid}' data-ReceiveType='${ReceiveType}' data-rel='tooltip' title='");
#nullable restore
#line 335 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
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

        } else if (RecordType == 'Sale') {
            text = `<a class='tooltip-success grid-btn edit' onClick='GoToSale(this)' data-id='${Guid}' data-rel='tooltip' title='");
#nullable restore
#line 343 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
                                                                                                                             Write(edit_purchase);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>`;
        } else if (RecordType == 'Return') {
            text = `<a class='tooltip-success grid-btn edit' onClick='GoToReturn(this)' data-id='${Guid}'  data-rel='tooltip' title='");
#nullable restore
#line 349 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
                                                                                                                                Write(edit_return);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>`;
        }

        return text;
    }

    function Delete_Databound(Guid, RecordType, ReceiveType) {

        let text = """";

        if (RecordType == 'Receive' && ReceiveType != 'ReceiveInFactor') {
            text = `<a class='tooltip-error grid-btn' onClick='GridDeleteFunctionWithPass(this)' data-id='${Guid}' data-rel='tooltip' title='");
#nullable restore
#line 364 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\CustomerAccount\dgCustomerAccountGrid.cshtml"
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

        return text;
    }

    function Description_Databound(Description, RecordType, Invoices, ReceiveType, ReturnInvoices) {

        let text = ""<div style=''>"" + RecordType + "" </div>"";
        if (RecordType == 'Receive') {
            if (ReceiveType == 'PartialReceive' || ReceiveType == 'Receive' || ReceiveType == 'ReceiveInFactor') {
                let unique_list = RemoveNullAndDuplicates(Invoices.split("",""));
                text = ""<div style=''>"" + ReceiveType + "" -> ("" + unique_list.join() + "") </div>"";

                if (ReturnInvoices != '' && ReturnInvoices != 'null' && ReturnInvoices != null) {
                    let unique_retun = RemoveNullAndDuplicates(ReturnInvoices.split("",""));
                    text += ""<div style=''>"" + ReceiveType + "" -");
            WriteLiteral(@"> Return("" + unique_retun.join() + "") </div>"";
                }

            }
        }

        if (Description != null) {

            let res = Description.toString().split(""|"");
            for (let i = 0; i < res.length; i++) {
                if (res[i] != '' && res[i] != null)
                    text += ""<div style=''>"" + res[i] + "" </div>"";
            }
        }

        return text;
    }

    function GetAmount_Databound(GetAmount) {
        var currencyIdFilter = $(""#CurrencyIdFilter"").data(""kendoDropDownList"");
        let currency = currencyIdFilter.text();

        let text = """";
        if (GetAmount != null) {

            let res = GetAmount.toString().split(""_"");
            for (let i = 0; i < res.length; i++) {
                if (res[i].includes(currency) || res[i] == 0) {
                    text += ""<div style=''>"" + res[i] + "" </div>"";
                }
            }
        }
        return text;
    }

    function ReceiveAmount_Databound(Recei");
            WriteLiteral(@"veAmount) {
        var currencyIdFilter = $(""#CurrencyIdFilter"").data(""kendoDropDownList"");
        let currency = currencyIdFilter.text();

        let text = """";
        if (ReceiveAmount != null) {

            let res = ReceiveAmount.toString().split(""_"");
            for (let i = 0; i < res.length; i++) {
                if (res[i].includes(currency) || res[i] == 0) {
                    text += ""<div style=''>"" + res[i] + "" </div>"";
                }
            }
        }
        return text;
    }

    function Remain_Databound(Remain) {
        var currencyIdFilter = $(""#CurrencyIdFilter"").data(""kendoDropDownList"");
        let currency = currencyIdFilter.text();

        let text = """";
        if (Remain != null) {

            let res = Remain.toString().split(""_"");
            for (let i = 0; i < res.length; i++) {
                if (res[i].includes(currency) || res[i] == 0) {
                    text += ""<div style=''>"" + res[i] + "" </div>"";
                }
     ");
            WriteLiteral(@"       }
        }
        return text;
    }

    $(document).ready(function () {

        $(""#kendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoGrid"").find(""tr.k-state-selected td a.edit"").click();

        });

    })

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
