#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198aebf5217475aceaa8e4277d3a40430441ca7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReturnSaleInvoice.Views_Shared_PartialViews_AppWebForms_ReturnSaleInvoice_wpReturnSaleInvoice), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReturnSaleInvoice/wpReturnSaleInvoice.cshtml")]
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
#line 3 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198aebf5217475aceaa8e4277d3a40430441ca7f", @"/Views/Shared/PartialViews/AppWebForms/ReturnSaleInvoice/wpReturnSaleInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReturnSaleInvoice_wpReturnSaleInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
  
    string font = "", pull = "", dir = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        dir = "  ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newReturnSaleInvoiceText\" class=\"hidden\">");
#nullable restore
#line 14 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                    Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                                      Write(Localizer["ReturnSaleInvoices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        dir = " direction:rtl; ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newReturnSaleInvoiceText\" class=\"hidden\">");
#nullable restore
#line 21 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                    Write(Localizer["ReturnSaleInvoices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                                                     Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editReturnSaleInvoiceText\" class=\"hidden\">");
#nullable restore
#line 23 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                 Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                                    Write(Localizer["ReturnSaleInvoices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 967, "\"", 980, 1);
#nullable restore
#line 28 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue("", 975, pull, 975, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 995, "\"", 1008, 1);
#nullable restore
#line 29 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue("", 1003, font, 1003, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
       Write(Localizer["ReturnSaleInvoiceList"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
     if ((bool)ViewBag.AccessNewReturnSaleInvoice)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1187, "\"", 1206, 2);
#nullable restore
#line 36 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue("", 1195, font, 1195, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue(" ", 1200, pull, 1201, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n            <a class=\"btn btn-danger\" onClick=\"AddReturnSaleInvoice(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div><!-- /.page-header -->\r\n\r\n<style>\r\n\r\n\r\n    ");
            WriteLiteral(@"@media (max-width:767px) {
        .modal-dialog {
            width: 70vw;
            margin: 30px auto
        }

        .modal-content {
            -webkit-box-shadow: 0 5px 15px rgba(0,0,0,.5);
            box-shadow: 0 5px 15px rgba(0,0,0,.5)
        }

        .modal-sm {
            width: 300px
        }

        
    }

</style>


<script>
    function GetPeriodAndFilterForRetunSale() {

        var periodId = $('#period-id').attr('data-Value');

        var fromDate = $(""#KendoFromDate"").data(""kendoDatePicker"");
        var toDate = $(""#KendoDateTo"").data(""kendoDatePicker"");

        var frDate = fromDate.value();
        var tDate = toDate.value();
        let frMonth = frDate.getMonth() + 1;
        let frDay = frDate.getDate();
        let toMonth = tDate.getMonth() + 1;
        let toDay = tDate.getDate();

        if (frMonth < 10)
            frMonth = ""0"" + frMonth;
        if (toMonth < 10)
            toMonth = ""0"" + toMonth;
        if (frDay < 10");
            WriteLiteral(@")
            frDay = ""0"" + frDay;
        if (toDay < 10)
            toDay = ""0"" + toDay;

        let from = frDate.getFullYear() + ""-"" + frMonth + ""-"" + frDay;
        let too = tDate.getFullYear() + ""-"" + toMonth + ""-"" + toDay;

        let Supplier = $(""#Supplier"").data(""kendoDropDownList"");
        let Currency = $(""#Currency"").data(""kendoDropDownList"");

        let filterViewModel = {
            PeriodId: periodId,
            TxtDateFrom: from,
            TxtDateTo: too,
            Supplier: Supplier.value(),
            Currency: Currency.value(),
            InvoiceNum: $(""#InvoiceNum"").val(),
            MainInvoiceNum: $(""#MainInvoiceNumFilterTxt"").val()
        };

        return filterViewModel;
    }
</script>

<div style=""overflow:hidden"">

    <div class=""col-sm-12 MyFont-Roboto-grid"">

        <div class=""col-sm-3"">
            ");
#nullable restore
#line 120 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("periods")
            .BindTo(Model.periods)
            .DataTextField("Name")
            .DataValueField("Id")
            .Filter("contains")
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "PeriodsChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("filters")
            .BindTo(Model.filters)
            .DataTextField("Name")
            .DataValueField("Id")
            .OptionLabel(" ")
            .Filter("contains")
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;", onchange = "FiltersChange()" })
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-3 hidden\" id=\"SupplierFilter\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("Supplier")
            .DataTextField("Name")
            .DataValueField("Guid")
            .Filter("contains")
            .OptionLabel(" ")
            .DataSource(source =>
            {
                source.Read(read =>
                {
                    read.Action("GetAllSuppliers", "Supplier");
                })
                .ServerFiltering(false);
            })
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;", onchange = "SetFilter()" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-3 hidden\" id=\"CurrencyFilter\">\r\n            ");
#nullable restore
#line 162 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
        Write(Html.Kendo().DropDownList()
            .Name("Currency")
            .DataTextField("Name")
            .DataValueField("Id")
            .OptionLabel(" ")
            .DataSource(source =>
            {
                source.Read(read =>
                {
                    read.Action("GetAllCurrencies", "BaseInfo");
                })
                .ServerFiltering(false);
            })
            .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;", onchange = "SetFilter()" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-4 hidden\" id=\"InvoiceNumFilter\">\r\n\r\n            <div class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 182 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
            Write(Html.Kendo().TextBox()
                .Name("InvoiceNum")
                .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-1\">\r\n                ");
#nullable restore
#line 189 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-search-invoiceNum")
                .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem;margin-bottom:5px;", type = "button", @class = "k-primary ", onclick = "SetFilter()" })
                .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-sm-4 hidden\" id=\"MainInvoiceNumFilter\">\r\n\r\n            <div class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 200 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
            Write(Html.Kendo().TextBox()
                .Name("MainInvoiceNumFilterTxt")
                .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-1\">\r\n                ");
#nullable restore
#line 207 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-search-mainInvoiceNum")
                .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem;margin-bottom:5px;", type = "button", @class = "k-primary ", onclick = "SetFilter()" })
                .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"col-sm-12 hidden\" id=\"searchDiv\"");
            BeginWriteAttribute("style", " style=\"", 7017, "\"", 7080, 3);
            WriteAttributeValue("", 7025, "margin-top:20px;display:flex;align-items:", 7025, 41, true);
            WriteAttributeValue(" ", 7066, "flex-end;", 7067, 10, true);
#nullable restore
#line 217 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue("", 7076, dir, 7076, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div class=\"col-sm-3 \"");
            BeginWriteAttribute("style", " style=\"", 7116, "\"", 7124, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <label class=\"block clearfix\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 221 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                     Write(Localizer["FromDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 223 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                Write(Html.Kendo().DatePicker()
                        .Name("KendoFromDate")
                        .Value(DateTime.Now)
                        .Format("dd/MM/yyyy")
                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n        </div>\r\n\r\n        <div class=\"col-sm-3 \"");
            BeginWriteAttribute("style", " style=\"", 7763, "\"", 7771, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <label class=\"block clearfix\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 235 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                     Write(Localizer["ToDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 237 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                Write(Html.Kendo().DatePicker()
                        .Name("KendoDateTo")
                        .Value(DateTime.Now)
                        .Format("dd/MM/yyyy")
                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem", onchange = "dateTimePickerWorkWithSpace(this)" })
                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </label>\r\n        </div>\r\n\r\n        <div");
            BeginWriteAttribute("id", " id=\"", 8388, "\"", 8393, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"col-sm-2 \"");
            BeginWriteAttribute("style", " style=\"", 8412, "\"", 8420, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 249 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
        Write(Html.Kendo().Button()
                .Name("btn-search-sale")
                .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem;margin-bottom:5px;", type = "button", @class = "k-primary ", onclick = "btnSearchClick()" })
                .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<input class=\"hidden\" type=\"text\" id=\"period-id\" data-Value=\"");
#nullable restore
#line 260 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                                                        Write(Model.periods.FirstOrDefault().Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<h1 id=\"FromTo\" class=\"hidden\">");
#nullable restore
#line 261 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
                          Write(ViewBag.FromToId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div id=\"ShowDiscountsListModal\"");
            BeginWriteAttribute("class", " class=\"", 8971, "\"", 8995, 3);
            WriteAttributeValue("", 8979, "modal", 8979, 5, true);
            WriteAttributeValue(" ", 8984, "fade", 8985, 5, true);
#nullable restore
#line 263 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue(" ", 8989, font, 8990, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 9041, "\"", 9053, 1);
#nullable restore
#line 263 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue("", 9049, dir, 9049, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""width:80%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeShowDiscountsListModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""ShowDiscountsListModal-header""");
            BeginWriteAttribute("class", " class=\"", 9367, "\"", 9411, 5);
            WriteAttributeValue("", 9375, "smaller", 9375, 7, true);
            WriteAttributeValue(" ", 9382, "lighter", 9383, 8, true);
            WriteAttributeValue(" ", 9390, "blue", 9391, 5, true);
            WriteAttributeValue(" ", 9395, "no-margin", 9396, 10, true);
#nullable restore
#line 268 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue(" ", 9405, font, 9406, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ShowDiscountsListModal-body\" class=\"modal-body\"");
            BeginWriteAttribute("style", " style=\"", 9528, "\"", 9536, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 277 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"InvoiceInUse\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 282 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
           Write(Localizer["InvoiceInUse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        \r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 287 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 292 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-ShowDiscountsList-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick= "closeShowDiscountsListModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n<div id=\"ShowTotalPriceModal\"");
            BeginWriteAttribute("class", " class=\"", 10788, "\"", 10812, 3);
            WriteAttributeValue("", 10796, "modal", 10796, 5, true);
            WriteAttributeValue(" ", 10801, "fade", 10802, 5, true);
#nullable restore
#line 301 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue(" ", 10806, font, 10807, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 10858, "\"", 10870, 1);
#nullable restore
#line 301 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue("", 10866, dir, 10866, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""width:80%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeShowTotalPriceModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""ShowTotalPriceModal-header""");
            BeginWriteAttribute("class", " class=\"", 11178, "\"", 11222, 5);
            WriteAttributeValue("", 11186, "smaller", 11186, 7, true);
            WriteAttributeValue(" ", 11193, "lighter", 11194, 8, true);
            WriteAttributeValue(" ", 11201, "blue", 11202, 5, true);
            WriteAttributeValue(" ", 11206, "no-margin", 11207, 10, true);
#nullable restore
#line 306 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue(" ", 11216, font, 11217, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 307 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
               Write(Localizer["TotalReturnSaleInvoice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ShowTotalPriceModal-body\" class=\"modal-body\"");
            BeginWriteAttribute("style", " style=\"", 11394, "\"", 11402, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 316 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 321 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 326 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-ShowTotalPrice-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick= "closeShowTotalPriceModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n<!-- Grid -->\r\n<div");
            BeginWriteAttribute("class", " class=\"", 12395, "\"", 12425, 3);
            WriteAttributeValue("", 12403, "row", 12403, 3, true);
            WriteAttributeValue(" ", 12406, "Grid-Content", 12407, 13, true);
#nullable restore
#line 338 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
WriteAttributeValue(" ", 12419, font, 12420, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 339 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/ReturnSaleInvoice/dgReturnSaleInvoiceGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 341 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 342 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnSaleInvoice\wpReturnSaleInvoice.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    function SetFilter() {

        $(""#returnSaleInvoiceKendoGrid"").find("".k-i-reload"").click();
    }

    function PeriodsChange() {

        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();

        $('#period-id').attr('data-Value', periodValue);

        var fromTo = $(""#FromTo"").text();

        if (periodValue === fromTo) {

            $(""#searchDiv"").removeClass(""hidden"");

            let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
            date.element.focus();
            date.element.select();

        } else {

            $(""#searchDiv"").addClass(""hidden"");

            $(""#returnSaleInvoiceKendoGrid"").find("".k-i-reload"").click();

        }

    }

    function btnSearchClick() {
        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();

        $('#period-id').attr('data-Value', periodValue);

        $(""#returnSaleInvoiceKendoGri");
            WriteLiteral(@"d"").find("".k-i-reload"").click();
    }

    function FiltersChange() {

        var filter = $(""#filters"").data(""kendoDropDownList"");
        var filterValue = filter.value();

        var supplier = $(""#Supplier"").data(""kendoDropDownList"");
        supplier.value("""");
        var currency = $(""#Currency"").data(""kendoDropDownList"");
        currency.value("""");

        $(""#InvoiceNum"").val("""");
        $(""#MainInvoiceNumFilterTxt"").val("""");

        if (filterValue == '1') {

            $(""#SupplierFilter"").removeClass(""hidden"");
            $(""#CurrencyFilter"").addClass(""hidden"");
            $(""#InvoiceNumFilter"").addClass(""hidden"");
            $(""#MainInvoiceNumFilter"").addClass(""hidden"");

        } else if (filterValue == '2') {

            $(""#SupplierFilter"").addClass(""hidden"");
            $(""#CurrencyFilter"").removeClass(""hidden"");
            $(""#InvoiceNumFilter"").addClass(""hidden"");
            $(""#MainInvoiceNumFilter"").addClass(""hidden"");

        } else if (filt");
            WriteLiteral(@"erValue == '3') {

            $(""#SupplierFilter"").addClass(""hidden"");
            $(""#CurrencyFilter"").addClass(""hidden"");
            $(""#InvoiceNumFilter"").removeClass(""hidden"");
            $(""#MainInvoiceNumFilter"").addClass(""hidden"");

        } else if (filterValue == '4') {

            $(""#SupplierFilter"").addClass(""hidden"");
            $(""#CurrencyFilter"").addClass(""hidden"");
            $(""#InvoiceNumFilter"").addClass(""hidden"");
            $(""#MainInvoiceNumFilter"").removeClass(""hidden"");

        } else {

            $(""#SupplierFilter"").addClass(""hidden"");
            $(""#CurrencyFilter"").addClass(""hidden"");
            $(""#InvoiceNumFilter"").addClass(""hidden"");
            $(""#MainInvoiceNumFilter"").addClass(""hidden"");
            $(""#returnSaleInvoiceKendoGrid"").find("".k-i-reload"").click();

        }

    }

    function AddReturnSaleInvoice(element) {

        $("".loader"").removeClass(""hidden"");
        $("".page-content"").load(""/ReturnSaleInvoice/AddAndNewModa");
            WriteLiteral(@"l"", function (responce) {

            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })

    }

    function EditReturnSaleInvoice(element) {

        $("".loader"").removeClass(""hidden"");
        var link = ""/ReturnSaleInvoice/EditModal?Id="";
        var Id = $(element).attr('data-id');
        $("".page-content"").load(link + Id, function (responce) {

            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })

    }

    function ShowDiscountsList(element) {

        $(""#ShowDiscountsListModal #ERROR_Data"").addClass(""hidden"");
        $(""#ShowDiscountsListModal #InvoiceInUse"").addClass(""hidden"");
        $(""#ShowDiscountsListModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#ShowDiscountsListModal').modal('toggle');

        var link = ""/ReturnSaleInvoiceDiscount/Form?returnSaleInvoiceId="";
        var Id = $(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");
        $('#");
            WriteLiteral(@"ShowDiscountsListModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");

        });
    };

    function closeShowDiscountsListModal() {

        $('#ShowDiscountsListModal').modal('hide');
        $('#ShowDiscountsListModal-body').empty();
        $("".modal-backdrop:last"").remove();
    }

    function ShowTotalPrice(element) {

        $(""#ShowTotalPriceModal #ERROR_Data"").addClass(""hidden"");
        $(""#ShowTotalPriceModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#ShowTotalPriceModal').modal('toggle');

        var link = ""/ReturnSaleInvoice/TotalPriceModal?Id="";
        var Id = $(element).attr('data-id');

        $("".loader"").removeClass(""hidden"");
        $('#ShowTotalPriceModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");

        });
    };

    function closeShowTotalPriceModal() {

    ");
            WriteLiteral("    $(\'#ShowTotalPriceModal\').modal(\'hide\');\r\n        $(\'#ShowTotalPriceModal-body\').empty();\r\n        $(\".modal-backdrop:last\").remove();\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
