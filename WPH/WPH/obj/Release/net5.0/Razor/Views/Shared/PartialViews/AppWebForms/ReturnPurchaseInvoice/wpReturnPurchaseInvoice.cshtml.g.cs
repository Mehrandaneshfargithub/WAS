#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6117c980312d33f1dd78cc721d55a570d349ada5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReturnPurchaseInvoice.Views_Shared_PartialViews_AppWebForms_ReturnPurchaseInvoice_wpReturnPurchaseInvoice), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoice/wpReturnPurchaseInvoice.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ReturnPurchaseInvoice
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
#line 3 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6117c980312d33f1dd78cc721d55a570d349ada5", @"/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoice/wpReturnPurchaseInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReturnPurchaseInvoice_wpReturnPurchaseInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
  
    string font = "", pull = "", dir = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        dir = "  ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newReturnPurchaseInvoiceText\" class=\"hidden\">");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                        Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                                          Write(Localizer["ReturnPurchaseInvoices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        dir = " direction:rtl; ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newReturnPurchaseInvoiceText\" class=\"hidden\">");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                        Write(Localizer["ReturnPurchaseInvoices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                                                             Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editReturnPurchaseInvoiceText\" class=\"hidden\">");
#nullable restore
#line 23 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                     Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                                        Write(Localizer["ReturnPurchaseInvoices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 991, "\"", 1004, 1);
#nullable restore
#line 28 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue("", 999, pull, 999, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 1019, "\"", 1032, 1);
#nullable restore
#line 29 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue("", 1027, font, 1027, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
       Write(Localizer["ReturnPurchaseInvoiceList"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n");
#nullable restore
#line 34 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
     if ((bool)ViewBag.AccessNewReturnPurchaseInvoice)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1219, "\"", 1238, 2);
#nullable restore
#line 36 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue("", 1227, font, 1227, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue(" ", 1232, pull, 1233, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n            <a class=\"btn btn-danger\" onClick=\"AddReturnPurchaseInvoice(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n                ");
#nullable restore
#line 38 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 42 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
    function GetPeriodAndFilterForRetunPurchase() {

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
        if (");
            WriteLiteral(@"frDay < 10)
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
#line 121 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
#line 132 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
#line 144 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
#line 163 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
#line 183 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
            Write(Html.Kendo().TextBox()
                .Name("InvoiceNum")
                .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-1\">\r\n                ");
#nullable restore
#line 190 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-search-invoiceNum")
                .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem;margin-bottom:5px;", type = "button", @class = "k-primary ", onclick = "SetFilter()" })
                .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-sm-4 hidden\" id=\"MainInvoiceNumFilter\">\r\n\r\n            <div class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 201 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
            Write(Html.Kendo().TextBox()
                .Name("MainInvoiceNumFilterTxt")
                .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem;" })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-1\">\r\n                ");
#nullable restore
#line 208 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-search-mainInvoiceNum")
                .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem;margin-bottom:5px;", type = "button", @class = "k-primary ", onclick = "SetFilter()" })
                .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"col-sm-12 hidden\" id=\"searchDiv\"");
            BeginWriteAttribute("style", " style=\"", 7063, "\"", 7126, 3);
            WriteAttributeValue("", 7071, "margin-top:20px;display:flex;align-items:", 7071, 41, true);
            WriteAttributeValue(" ", 7112, "flex-end;", 7113, 10, true);
#nullable restore
#line 218 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue("", 7122, dir, 7122, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div class=\"col-sm-3 \"");
            BeginWriteAttribute("style", " style=\"", 7162, "\"", 7170, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <label class=\"block clearfix\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 222 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                     Write(Localizer["FromDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 224 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
            BeginWriteAttribute("style", " style=\"", 7809, "\"", 7817, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <label class=\"block clearfix\">\r\n                <label for=\"form-field-8\">");
#nullable restore
#line 236 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                     Write(Localizer["ToDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </label>\r\n                <span class=\"block input-icon input-icon-right\">\r\n                    ");
#nullable restore
#line 238 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
            BeginWriteAttribute("id", " id=\"", 8434, "\"", 8439, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"col-sm-2 \"");
            BeginWriteAttribute("style", " style=\"", 8458, "\"", 8466, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 250 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
        Write(Html.Kendo().Button()
                .Name("btn-search-purchase")
                .HtmlAttributes(new { style = "font-size:1.5rem;padding:0.7rem;margin-bottom:5px;", type = "button", @class = "k-primary ", onclick = "btnSearchClick()" })
                .Content("<i class='fa fa-search'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<input class=\"hidden\" type=\"text\" id=\"period-id\" data-Value=\"");
#nullable restore
#line 261 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                                                        Write(Model.periods.FirstOrDefault().Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<h1 id=\"FromTo\" class=\"hidden\">");
#nullable restore
#line 262 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
                          Write(ViewBag.FromToId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div id=\"ShowDiscountsListModal\"");
            BeginWriteAttribute("class", " class=\"", 9021, "\"", 9045, 3);
            WriteAttributeValue("", 9029, "modal", 9029, 5, true);
            WriteAttributeValue(" ", 9034, "fade", 9035, 5, true);
#nullable restore
#line 264 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue(" ", 9039, font, 9040, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 9091, "\"", 9103, 1);
#nullable restore
#line 264 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue("", 9099, dir, 9099, 4, false);

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
            BeginWriteAttribute("class", " class=\"", 9417, "\"", 9461, 5);
            WriteAttributeValue("", 9425, "smaller", 9425, 7, true);
            WriteAttributeValue(" ", 9432, "lighter", 9433, 8, true);
            WriteAttributeValue(" ", 9440, "blue", 9441, 5, true);
            WriteAttributeValue(" ", 9445, "no-margin", 9446, 10, true);
#nullable restore
#line 269 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue(" ", 9455, font, 9456, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ShowDiscountsListModal-body\" class=\"modal-body\"");
            BeginWriteAttribute("style", " style=\"", 9578, "\"", 9586, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 278 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"InvoiceInUse\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 283 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
           Write(Localizer["InvoiceInUse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        \r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 288 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 293 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
            BeginWriteAttribute("class", " class=\"", 10838, "\"", 10862, 3);
            WriteAttributeValue("", 10846, "modal", 10846, 5, true);
            WriteAttributeValue(" ", 10851, "fade", 10852, 5, true);
#nullable restore
#line 302 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue(" ", 10856, font, 10857, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 10908, "\"", 10920, 1);
#nullable restore
#line 302 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue("", 10916, dir, 10916, 4, false);

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
            BeginWriteAttribute("class", " class=\"", 11228, "\"", 11272, 5);
            WriteAttributeValue("", 11236, "smaller", 11236, 7, true);
            WriteAttributeValue(" ", 11243, "lighter", 11244, 8, true);
            WriteAttributeValue(" ", 11251, "blue", 11252, 5, true);
            WriteAttributeValue(" ", 11256, "no-margin", 11257, 10, true);
#nullable restore
#line 307 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue(" ", 11266, font, 11267, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 308 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
               Write(Localizer["TotalReturnPurchaseInvoice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"ShowTotalPriceModal-body\" class=\"modal-body\"");
            BeginWriteAttribute("style", " style=\"", 11448, "\"", 11456, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 317 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 322 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 327 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
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
            BeginWriteAttribute("class", " class=\"", 12449, "\"", 12479, 3);
            WriteAttributeValue("", 12457, "row", 12457, 3, true);
            WriteAttributeValue(" ", 12460, "Grid-Content", 12461, 13, true);
#nullable restore
#line 339 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
WriteAttributeValue(" ", 12473, font, 12474, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 340 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/ReturnPurchaseInvoice/dgReturnPurchaseInvoiceGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 342 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 343 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReturnPurchaseInvoice\wpReturnPurchaseInvoice.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    function SetFilter() {

        $(""#returnPurchaseInvoiceKendoGrid"").find("".k-i-reload"").click();
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

            $(""#returnPurchaseInvoiceKendoGrid"").find("".k-i-reload"").click();

        }

    }

    function btnSearchClick() {
        var period = $(""#periods"").data(""kendoDropDownList"");

        var periodValue = period.value();

        $('#period-id').attr('data-Value', periodValue);

        $(""#returnPurchaseInv");
            WriteLiteral(@"oiceKendoGrid"").find("".k-i-reload"").click();
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

        } e");
            WriteLiteral(@"lse if (filterValue == '3') {

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
            $(""#returnPurchaseInvoiceKendoGrid"").find("".k-i-reload"").click();

        }

    }

    function AddReturnPurchaseInvoice(element) {

        $("".loader"").removeClass(""hidden"");
        $("".page-content"").load(""/ReturnPurch");
            WriteLiteral(@"aseInvoice/AddAndNewModal"", function (responce) {

            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })

    }

    function EditReturnPurchaseInvoice(element) {

        $("".loader"").removeClass(""hidden"");
        var link = ""/ReturnPurchaseInvoice/EditModal?Id="";
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

        var link = ""/ReturnPurchaseInvoiceDiscount/Form?returnPurchaseInvoiceId="";
        var Id = $(element).attr('data-id');
        $("".loade");
            WriteLiteral(@"r"").removeClass(""hidden"");
        $('#ShowDiscountsListModal-body').load(link + Id + '', function () {
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

        var link = ""/ReturnPurchaseInvoice/TotalPriceModal?Id="";
        var Id = $(element).attr('data-id');

        $("".loader"").removeClass(""hidden"");
        $('#ShowTotalPriceModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");

        });
    };

    f");
            WriteLiteral("unction closeShowTotalPriceModal() {\r\n\r\n        $(\'#ShowTotalPriceModal\').modal(\'hide\');\r\n        $(\'#ShowTotalPriceModal-body\').empty();\r\n        $(\".modal-backdrop:last\").remove();\r\n    }\r\n\r\n</script>");
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
