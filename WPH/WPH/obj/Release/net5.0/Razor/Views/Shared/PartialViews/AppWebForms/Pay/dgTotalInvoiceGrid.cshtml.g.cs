#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\dgTotalInvoiceGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5956fdab4c3846b86b29b517bb259baccf656766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Pay.Views_Shared_PartialViews_AppWebForms_Pay_dgTotalInvoiceGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Pay/dgTotalInvoiceGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Pay
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\dgTotalInvoiceGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5956fdab4c3846b86b29b517bb259baccf656766", @"/Views/Shared/PartialViews/AppWebForms/Pay/dgTotalInvoiceGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Pay_dgTotalInvoiceGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 8 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\dgTotalInvoiceGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.PurchaseInvoice.PurchaseInvoiceViewModel>()
    .Name("totalInvoiceKendoGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {

            columns.Bound(x => x.Description).Filterable(false).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.TotalPrice).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;" }).ClientTemplate("#= Total_Databound(TotalPrice)#");
            columns.Bound(x => x.MainInvoiceNum).Filterable(false).Title(Localizer["MainInvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;white-space: break-spaces;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceNum).Filterable(false).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;white-space: break-spaces;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceDateTxt).Filterable(false).Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(20).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.PayIds).Hidden();
            columns.Bound(x => x.Guid).Hidden();

            columns.Select().HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;"})
                            .HtmlAttributes(new { @class = "select_totalInvoice", @data_price = "#=TotalPrice#", @data_id = "#=Guid#", @data_date = "#=InvoiceDateTxt#", @data_desctiption = "#=Description#", @data_mainInvoice = "#=MainInvoiceNum#", @data_invoice = "#=InvoiceNum#", @data_payids = "#=PayIds#" });
        }
        else
        {
            columns.Select().HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;" })
                            .HtmlAttributes(new { @class = "select_totalInvoice", @data_price = "#=TotalPrice#", @data_id = "#=Guid#", @data_date = "#=InvoiceDateTxt#", @data_desctiption = "#=Description#", @data_mainInvoice = "#=MainInvoiceNum#", @data_invoice = "#=InvoiceNum#", @data_payids = "#=PayIds#" });

            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.PayIds).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(20).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;" });
            columns.Bound(x => x.InvoiceDateTxt).Filterable(false).Title(Localizer["InvoiceDate"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.InvoiceNum).Filterable(false).Title(Localizer["InvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;white-space: break-spaces;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.MainInvoiceNum).Filterable(false).Title(Localizer["MainInvoiceNum"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;white-space: break-spaces;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.TotalPrice).Title(Localizer["Total"]).Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;" }).ClientTemplate("#= Total_Databound(TotalPrice)#");
            columns.Bound(x => x.Description).Filterable(false).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;vertical-align: middle;", @class = "MyFont-Sarchia-grid" });

        }
    })

        //.DataSource(dataSource => dataSource
        //.Ajax()
        //.ServerOperation(false)
        //.Model(model =>
        //{
        //    model.Id(p => p.Guid);
        //})
        //.PageSize(10)
        //.Read(read => read.Action("GetNotPayPurchaseInvoice", "PurchaseInvoice").Data("GetSupplierAndCurrency"))
        //)
        //.Filterable(ftb => ftb.Mode(GridFilterMode.Row))
        .Selectable(selectable => selectable.Mode(GridSelectionMode.Multiple))
        .Pageable(pageable => pageable
        .Input(true)
        .PageSizes(true)
        .ButtonCount(3)
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
                text += ""<div style='white-space: nowrap;'>"" + res[i] + "" </div>"";
            }
        }
        return text;
    }


    $(document).ready(function () {

        //$(""#kendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

        //    $(""#kendoGrid"").find(""tr.k-state-selected td a.edit"").click();

        //});

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
