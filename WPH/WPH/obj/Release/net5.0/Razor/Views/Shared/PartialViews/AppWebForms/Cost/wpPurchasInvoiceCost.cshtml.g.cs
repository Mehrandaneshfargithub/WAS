#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8949086a958e27db7f5abbe61b2347eebcc4d18b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Cost.Views_Shared_PartialViews_AppWebForms_Cost_wpPurchasInvoiceCost), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Cost/wpPurchasInvoiceCost.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Cost
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
#line 3 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8949086a958e27db7f5abbe61b2347eebcc4d18b", @"/Views/Shared/PartialViews/AppWebForms/Cost/wpPurchasInvoiceCost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Cost_wpPurchasInvoiceCost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newCostText\" class=\"hidden\">");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                       Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                                         Write(Localizer["Cost"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newCostText\" class=\"hidden\">");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                       Write(Localizer["Cost"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                                          Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editCostText\" class=\"hidden\">");
#nullable restore
#line 23 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                    Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                                       Write(Localizer["Cost"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 27 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 867, "\"", 881, 2);
#nullable restore
#line 29 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue("", 875, pull, 875, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 880, "", 881, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 896, "\"", 909, 1);
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue("", 904, font, 904, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 31 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
       Write(Localizer["Costs"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1013, "\"", 1032, 2);
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue("", 1021, pull, 1021, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue(" ", 1026, font, 1027, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n        <a class=\"btn btn-danger\" onClick=\"AddCost()\" href=\"#\" style=\"padding:0.2rem\">\r\n            ");
#nullable restore
#line 39 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
       Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n        </a>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div class=\"space-10\"></div>\r\n\r\n<div class=\"row MyFont-Roboto-grid\">\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 1419, "\"", 1449, 3);
            WriteAttributeValue("", 1427, "row", 1427, 3, true);
            WriteAttributeValue(" ", 1430, "Grid-Content", 1431, 13, true);
#nullable restore
#line 55 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue(" ", 1443, font, 1444, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 56 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/Cost/dgPurchasInvoiceCostGrid.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div id=\"CostModal\"");
            BeginWriteAttribute("class", " class=\"", 1601, "\"", 1626, 3);
            WriteAttributeValue("", 1609, "modal", 1609, 5, true);
            WriteAttributeValue(" ", 1614, "fade", 1615, 5, true);
#nullable restore
#line 60 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue("  ", 1619, font, 1621, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\" static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1673, "\"", 1691, 1);
#nullable restore
#line 60 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue("", 1681, direction, 1681, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""position: fixed; left: 0; right: 0;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeCostModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""CostModal-header""");
            BeginWriteAttribute("class", " class=\"", 2005, "\"", 2049, 5);
            WriteAttributeValue("", 2013, "smaller", 2013, 7, true);
            WriteAttributeValue(" ", 2020, "lighter", 2021, 8, true);
            WriteAttributeValue(" ", 2028, "blue", 2029, 5, true);
            WriteAttributeValue(" ", 2033, "no-margin", 2034, 10, true);
#nullable restore
#line 65 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue(" ", 2043, font, 2044, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 66 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
               Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>

            <div id=""CostModal-body"" class=""modal-body"" style=""width:70rem"">
            </div>

            <div id=""ERROR_Data"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 75 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"InvoiceInUse\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 80 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
           Write(Localizer["InvoiceInUse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            \r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 85 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
           Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 89 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-CostModal-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 93 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-CostModal-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeCostModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"DeleteCostModal\"");
            BeginWriteAttribute("class", " class=\"", 3686, "\"", 3710, 3);
            WriteAttributeValue("", 3694, "modal", 3694, 5, true);
            WriteAttributeValue(" ", 3699, "fade", 3700, 5, true);
#nullable restore
#line 103 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue(" ", 3704, font, 3705, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 3756, "\"", 3774, 1);
#nullable restore
#line 103 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue("", 3764, direction, 3764, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"" style=""position: fixed; left: 0; right: 0;"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" onclick=""closeDeleteCostModal()"" aria-hidden=""true"">&times;</button>
                <h3");
            BeginWriteAttribute("class", " class=\'", 4103, "\'", 4124, 2);
            WriteAttributeValue("", 4111, "smaller", 4111, 7, true);
#nullable restore
#line 108 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
WriteAttributeValue(" ", 4118, font, 4119, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'ace-icon fa fa-exclamation-triangle red \'></i>");
#nullable restore
#line 109 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                                                       Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"DeleteCostModal-body\" class=\"modal-body\">\r\n                ");
#nullable restore
#line 114 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
           Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div id=\"ERROR_ThisRecordHasDependencyOnItInAnotherEntity\" class=\"red label-white middle hidden\" style=\"height:40px;display:block;margin-top:2rem\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 117 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div id=\"InvoiceInUse\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 122 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
               Write(Localizer["InvoiceInUse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                
                <div id=""ERROR_SomeThingWentWrong"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                    <i class=""ace-icon fa fa-stop bigger-120""></i>
                    ");
#nullable restore
#line 127 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 134 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DeleteCost-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 138 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DeleteCost-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeDeleteCostModal()" })
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

    function closeCostModal() {

        $('#CostModal').modal('toggle');
        $('#CostModal-body').empty();

    }

    function AddCost() {
        $(""#CostModal #ERROR_Data"").addClass(""hidden"");
        $(""#CostModal #InvoiceInUse"").addClass(""hidden"");
        $(""#CostModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        let header = $(""#newCostText"").text();
        $(""#CostModal-header"").text(header);

        var link = `/Cost/PurchasInvoiceCostAddNewModal?purchaseInvoiceId=${'");
#nullable restore
#line 168 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Cost\wpPurchasInvoiceCost.cshtml"
                                                                        Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'}`;

        $("".loader"").removeClass(""hidden"");
        $('#CostModal').modal('toggle');
        $('#CostModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function EditCost(element) {
        $(""#CostModal #ERROR_Data"").addClass(""hidden"");
        $(""#CostModal #InvoiceInUse"").addClass(""hidden"");
        $(""#CostModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        let header = $(""#editCostText"").text();
        $(""#CostModal-header"").text(header);

        var link = ""/Cost/PurchasInvoiceCostEditModal?Id="";
        var Id = $(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");
        $('#CostModal').modal('toggle');
        $('#CostModal-body').load(link + Id, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }


    $(""#btn-CostModal-accept"").on(""click"", function () {
        $(this).attr");
            WriteLiteral(@"(""disabled"", true);

        $(""#CostModal #ERROR_Data"").addClass(""hidden"");
        $(""#CostModal #InvoiceInUse"").addClass(""hidden"");
        $(""#CostModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#CostModal .emptybox').addClass('hidden');
        var isEmmpty = true;
        $('#CostModal .emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    $('#btn-CostModal-accept').removeAttr(""disabled"");
                    isEmmpty = false;
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }

        var link = ""/Cost/PurchasInvoiceCostAddOrUpdate"";
        var data = $(""#addNewCostForm"").serialize();

        $("".loader"").removeClass(""hidden"");

        $.aj");
            WriteLiteral(@"ax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                $('#btn-CostModal-accept').removeAttr(""disabled"");

                if (response === 0) {

                    $(""#CostModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""InvoiceInUse"") {

                    $(""#CostModal #InvoiceInUse"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""DataNotValid"") {

                    $(""#CostModal #ERROR_Data"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else {

                    $('#CostModal').modal('hide');
                    $("".modal-backd");
            WriteLiteral(@"rop:last"").remove();
                    $('#CostModal-body').empty();
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#kendoCostGrid .k-pager-refresh"")[0].click();

                    if (totalContainer)
                        SetTotalPrice(response);
                }
            }
        });


    });

    function closeDeleteCostModal() {

        $('#DeleteCostModal').modal('hide');
        $("".modal-backdrop:last"").remove();
    }

    function GridDeleteCostFunction(element) {
        $(""#DeleteCostModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteCostModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DeleteCostModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#DeleteCostModal').modal('toggle');
        var Id = $(element).attr('data-id');
        $('#btn-DeleteCost-accept').attr('data-id");
            WriteLiteral(@"', Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");
    }


    $(""#btn-DeleteCost-accept"").on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#DeleteCostModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteCostModal #InvoiceInUse"").addClass(""hidden"");
        $(""#DeleteCostModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var token = $(':input:hidden[name*=""RequestVerificationToken""]');
        var link = ""/Cost/PurchasInvoiceCostRemove"";
        var Id = $(this).attr('data-id');

        $("".loader"").removeClass(""hidden"");

        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                costId: Id
            },
            success: function (response) {
                $('#btn-DeleteCost-accept').removeAttr(""disabled"");

                if (response === 0) {

");
            WriteLiteral(@"                    $(""#DeleteCostModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {

                    $(""#DeleteCostModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""InvoiceInUse"") {

                    $(""#DeleteCostModal #InvoiceInUse"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else if (response === ""ERROR_SomeThingWentWrong"") {

                    $(""#DeleteCostModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hi");
            WriteLiteral(@"dden"");

                } else {

                    $('#DeleteCostModal').modal('hide');
                    $("".modal-backdrop:last"").remove();
                    $('#DeleteCostModal-body').empty();
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#kendoCostGrid .k-pager-refresh"")[0].click();

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
