#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dfb49e9f8637c4b0f82661c6a8cd74294d31ce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.SaleInvoiceDiscount.Views_Shared_PartialViews_AppWebForms_SaleInvoiceDiscount_wpSaleInvoiceDiscount), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/SaleInvoiceDiscount/wpSaleInvoiceDiscount.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.SaleInvoiceDiscount
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dfb49e9f8637c4b0f82661c6a8cd74294d31ce6", @"/Views/Shared/PartialViews/AppWebForms/SaleInvoiceDiscount/wpSaleInvoiceDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_SaleInvoiceDiscount_wpSaleInvoiceDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newDiscountText\" class=\"hidden\">");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                                             Write(Localizer["Discount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newDiscountText\" class=\"hidden\">");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                           Write(Localizer["Discount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                                                  Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editDiscountText\" class=\"hidden\">");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                        Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                                           Write(Localizer["Discount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 26 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 889, "\"", 903, 2);
#nullable restore
#line 28 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue("", 897, pull, 897, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 902, "", 903, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 918, "\"", 931, 1);
#nullable restore
#line 29 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue("", 926, font, 926, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
       Write(Localizer["Discounts"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1039, "\"", 1058, 2);
#nullable restore
#line 36 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue("", 1047, pull, 1047, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue(" ", 1052, font, 1053, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n        <a class=\"btn btn-danger\" onClick=\"AddDiscount()\" href=\"#\" style=\"padding:0.2rem\">\r\n            ");
#nullable restore
#line 38 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
       Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <i class=""ace-icon glyphicon  glyphicon-plus align-top bigger-125""></i>
        </a>
    </div>

    <button type=""button"" class=""close"" onclick=""closeShowDiscountsListModal()"" aria-hidden=""true"">&times;</button>

</div>

<div class=""space-10""></div>

<div class=""row MyFont-Roboto-grid"">


</div>



<div");
            BeginWriteAttribute("class", " class=\"", 1568, "\"", 1598, 3);
            WriteAttributeValue("", 1576, "row", 1576, 3, true);
            WriteAttributeValue(" ", 1579, "Grid-Content", 1580, 13, true);
#nullable restore
#line 56 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue(" ", 1592, font, 1593, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 57 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/SaleInvoiceDiscount/dgSaleInvoiceDiscountGrid.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div id=\"DiscountModal\"");
            BeginWriteAttribute("class", " class=\"", 1770, "\"", 1795, 3);
            WriteAttributeValue("", 1778, "modal", 1778, 5, true);
            WriteAttributeValue(" ", 1783, "fade", 1784, 5, true);
#nullable restore
#line 61 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue("  ", 1788, font, 1790, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\" static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1842, "\"", 1860, 1);
#nullable restore
#line 61 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue("", 1850, direction, 1850, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""position: fixed; left: 0; right: 0;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeDiscountModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""DiscountModal-header""");
            BeginWriteAttribute("class", " class=\"", 2182, "\"", 2226, 5);
            WriteAttributeValue("", 2190, "smaller", 2190, 7, true);
            WriteAttributeValue(" ", 2197, "lighter", 2198, 8, true);
            WriteAttributeValue(" ", 2205, "blue", 2206, 5, true);
            WriteAttributeValue(" ", 2210, "no-margin", 2211, 10, true);
#nullable restore
#line 66 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue(" ", 2220, font, 2221, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 67 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
               Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>

            <div id=""DiscountModal-body"" class=""modal-body"" style=""width:70rem"">
            </div>

            <div id=""AmountOverFlow"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 76 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
           Write(Localizer["DiscountIsGreaterThanTheAmount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"Currency_NotExist\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 81 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
           Write(Localizer["CantAddWithThisCurrency"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 86 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"InvoiceInUse\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 91 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
           Write(Localizer["InvoiceInUse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 96 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
           Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 100 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DiscountModal-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 104 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DiscountModal-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeDiscountModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"DeleteDiscountModal\"");
            BeginWriteAttribute("class", " class=\"", 4387, "\"", 4411, 3);
            WriteAttributeValue("", 4395, "modal", 4395, 5, true);
            WriteAttributeValue(" ", 4400, "fade", 4401, 5, true);
#nullable restore
#line 115 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue(" ", 4405, font, 4406, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 4457, "\"", 4475, 1);
#nullable restore
#line 115 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue("", 4465, direction, 4465, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"" style=""position: fixed; left: 0; right: 0;"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" onclick=""closeDeleteDiscountModal()"" aria-hidden=""true"">&times;</button>
                <h3");
            BeginWriteAttribute("class", " class=\'", 4808, "\'", 4829, 2);
            WriteAttributeValue("", 4816, "smaller", 4816, 7, true);
#nullable restore
#line 120 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
WriteAttributeValue(" ", 4823, font, 4824, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'ace-icon fa fa-exclamation-triangle red \'></i>");
#nullable restore
#line 121 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                                                       Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"DeleteDiscountModal-body\" class=\"modal-body\">\r\n                ");
#nullable restore
#line 126 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
           Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div id=\"ERROR_ThisRecordHasDependencyOnItInAnotherEntity\" class=\"red label-white middle hidden\" style=\"height:40px;display:block;margin-top:2rem\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 129 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div id=\"InvoiceInUse\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 134 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
               Write(Localizer["InvoiceInUse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 139 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 146 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DeleteDiscount-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 150 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DeleteDiscount-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeDeleteDiscountModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>



<script type=""text/javascript"">
    var totalContainer = document.getElementById(""purchaseInvoiceDetailTotalPrice"");

    function closeDiscountModal() {

        $('#DiscountModal').modal('toggle');
        $('#DiscountModal-body').empty();
    }

    function AddDiscount() {
        $(""#DiscountModal #AmountOverFlow"").addClass(""hidden"");
        $(""#DiscountModal #Currency_NotExist"").addClass(""hidden"");
        $(""#DiscountModal #ERROR_Data"").addClass(""hidden"");
        $(""#DiscountModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DiscountModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        let header = $(""#newDiscountText"").text();
        $(""#DiscountModal-header"").text(header);

        var link = `/SaleInvoiceDiscount/AddNewModal?SaleInvoiceId=${'");
#nullable restore
#line 180 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\SaleInvoiceDiscount\wpSaleInvoiceDiscount.cshtml"
                                                                 Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'}`;

        $("".loader"").removeClass(""hidden"");
        $('#DiscountModal').modal('toggle');
        $('#DiscountModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function EditDiscount(element) {
        $(""#DiscountModal #AmountOverFlow"").addClass(""hidden"");
        $(""#DiscountModal #Currency_NotExist"").addClass(""hidden"");
        $(""#DiscountModal #ERROR_Data"").addClass(""hidden"");
        $(""#DiscountModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DiscountModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        let header = $(""#editDiscountText"").text();
        $(""#DiscountModal-header"").text(header);

        var link = ""/SaleInvoiceDiscount/EditModal?Id="";
        var Id = $(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");
        $('#DiscountModal').modal('toggle');
        $('#DiscountModal-body').load(link + Id, function () {
            $("".load");
            WriteLiteral(@"er"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }


    $(""#btn-DiscountModal-accept"").on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#DiscountModal #AmountOverFlow"").addClass(""hidden"");
        $(""#DiscountModal #Currency_NotExist"").addClass(""hidden"");
        $(""#DiscountModal #ERROR_Data"").addClass(""hidden"");
        $(""#DiscountModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DiscountModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");


        $('#DiscountModal .emptybox').addClass('hidden');
        var isEmmpty = true;
        $('#DiscountModal .emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    isEmmpty = false;

                    $('#btn-DiscountModal-accept').removeAttr(");
            WriteLiteral(@"""disabled"");
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }

        var link = ""/SaleInvoiceDiscount/AddOrUpdate"";
        var data = $(""#addNewDiscountForm"").serialize();

        $("".loader"").removeClass(""hidden"");

        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                $('#btn-DiscountModal-accept').removeAttr(""disabled"");
                if (response === 0) {

                    $(""#DiscountModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""InvoiceInUse"") {

                    $(""#DiscountModal #InvoiceInUse"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

        ");
            WriteLiteral(@"        } else if (response === ""DiscountIsGreaterThanTheAmount"") {

                    $(""#DiscountModal #AmountOverFlow"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                }  else if (response === ""CantAddWithThisCurrency"") {

                    $(""#DiscountModal #Currency_NotExist"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""DataNotValid"") {

                    $(""#DiscountModal #ERROR_Data"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else {

                    $('#DiscountModal').modal('hide');
                    $("".modal-backdrop:last"").remove();
                    $('#DiscountModal-body').empty();
                    $("".loader"").fadeIn(""slow"");
                ");
            WriteLiteral(@"    $("".loader"").addClass(""hidden"");
                    $(""#kendoDiscountGrid .k-pager-refresh"")[0].click();

                    if (totalContainer)
                        SetTotalPrice(response);
                }
            }
        });


    });

    function closeDeleteDiscountModal() {

        $('#DeleteDiscountModal').modal('hide');
        $("".modal-backdrop:last"").remove();
    }

    function GridDeleteDiscountFunction(element) {
        $(""#DeleteDiscountModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteDiscountModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DeleteDiscountModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#DeleteDiscountModal').modal('toggle');
        var Id = $(element).attr('data-id');

        

        $('#btn-DeleteDiscount-accept').attr('data-id', Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");
");
            WriteLiteral(@"    }


    $(""#btn-DeleteDiscount-accept"").on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#DeleteDiscountModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteDiscountModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DeleteDiscountModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var token = $(':input:hidden[name*=""RequestVerificationToken""]');
        var link = ""/SaleInvoiceDiscount/Remove"";
        var Id = $(this).attr('data-id');

        $("".loader"").removeClass(""hidden"");

        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                SaleInvoiceDiscountId: Id
            },
            success: function (response) {
                $('#btn-DeleteDiscount-accept').removeAttr(""disabled"");

                if (response === 0) {

                    $(""#DeleteDiscountModal #ERROR_SomeTh");
            WriteLiteral(@"ingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {

                    $(""#DeleteDiscountModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""InvoiceInUse"") {

                    $(""#DiscountModal #InvoiceInUse"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""ERROR_SomeThingWentWrong"") {

                    $(""#DiscountModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else {

              ");
            WriteLiteral(@"      $('#DeleteDiscountModal').modal('hide');
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#kendoDiscountGrid .k-pager-refresh"")[0].click();

                    if (totalContainer)
                        SetTotalPrice(response);
                }
            }
        });


    });




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guid> Html { get; private set; }
    }
}
#pragma warning restore 1591
