#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e714635a1cb63c209514b8296719385d3ae115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ReceptionService.Views_Shared_PartialViews_AppWebForms_ReceptionService_wpReceptionService), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ReceptionService/wpReceptionService.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ReceptionService
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e714635a1cb63c209514b8296719385d3ae115", @"/Views/Shared/PartialViews/AppWebForms/ReceptionService/wpReceptionService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ReceptionService_wpReceptionService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 589, "\"", 602, 1);
#nullable restore
#line 28 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue("", 597, pull, 597, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 617, "\"", 630, 1);
#nullable restore
#line 29 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue("", 625, font, 625, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
       Write(Localizer["Services"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 735, "\"", 754, 2);
#nullable restore
#line 35 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue("", 743, font, 743, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue(" ", 748, pull, 749, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"visibility:hidden;margin:0 2rem;transform:translateY(-10%)\">\r\n        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onClick", " onClick=\"", 858, "\"", 868, 0);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" style=\"padding:0.2rem\">\r\n            ");
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
       Write(Localizer["Print"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <i class=\"ace-icon align-top bigger-125\"></i>\r\n        </a>\r\n    </div>\r\n\r\n</div><!-- /.page-header -->\r\n<!-- Modal -->\r\n<div id=\"AddReceptionServiceModal\"");
            BeginWriteAttribute("class", " class=\"", 1104, "\"", 1128, 3);
            WriteAttributeValue("", 1112, "modal", 1112, 5, true);
            WriteAttributeValue(" ", 1117, "fade", 1118, 5, true);
#nullable restore
#line 44 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue(" ", 1122, font, 1123, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1174, "\"", 1192, 1);
#nullable restore
#line 44 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue("", 1182, direction, 1182, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""position:fixed;left: 0;right: 0;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeAddReceptionServiceModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""AddReceptionServiceModal-header""");
            BeginWriteAttribute("class", " class=\"", 1533, "\"", 1577, 5);
            WriteAttributeValue("", 1541, "smaller", 1541, 7, true);
            WriteAttributeValue(" ", 1548, "lighter", 1549, 8, true);
            WriteAttributeValue(" ", 1556, "blue", 1557, 5, true);
            WriteAttributeValue(" ", 1561, "no-margin", 1562, 10, true);
#nullable restore
#line 49 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue(" ", 1571, font, 1572, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 50 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
               Write(Localizer["Pay"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>

            <div id=""AddReceptionServiceModal-body"" class=""modal-body"" style=""width:60rem;padding:0px !important;"">
            </div>

            <div id=""ERROR_SomeThingWentWrong"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_Data\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 64 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 69 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addReceptionService-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 73 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addReceptionService-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick="closeAddReceptionServiceModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n<!-- Grid -->\r\n<div style=\"margin-top:102px\"");
            BeginWriteAttribute("class", " class=\"", 3084, "\"", 3114, 3);
            WriteAttributeValue("", 3092, "row", 3092, 3, true);
            WriteAttributeValue(" ", 3095, "Grid-Content", 3096, 13, true);
#nullable restore
#line 83 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
WriteAttributeValue(" ", 3108, font, 3109, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 84 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ReceptionService\wpReceptionService.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/ReceptionService/dgReceptionServiceGrid.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>


<script>

    function EditReceptionService(element) {

        $('#AddReceptionServiceModal').modal('toggle');

        var link = ""/ReceptionService/EditModal?Id="";
        var Id = $(element).attr('data-id');
        var rem = $(element).attr('data-remain');
        $('#btn-addReceptionService-accept').attr('data-id', Id);
        $("".loader"").removeClass(""hidden"");
        $('#AddReceptionServiceModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
            $(""#ReceivedAmount"").data(""kendoNumericTextBox"").value(rem);
        });
    }

    $('#btn-addReceptionService-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $('#AddReceptionServiceModal #ERROR_SomeThingWentWrong').addClass('hidden');
        $('#AddReceptionServiceModal #ERROR_Data').addClass('hidden');

        var div = $(""#pay-tabstrip"").find(""> div.k-state-active"")[0];
        var id = div.");
            WriteLiteral(@"getAttribute(""id"");
        $(""#"" + id + "" .emptybox"").addClass(""hidden"");

        var isEmmpty = true;
        $(""#"" + id + "" .emptybox"").each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    $('#btn-addReceptionService-accept').removeAttr(""disabled"");
                    isEmmpty = false;
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }

        var _payerName;
        var _amount;
        var _amountStatus;
        var _currencyId;
        var _receptionInvoiceNum;

        if (id == 'pay-tabstrip-1') {

            _payerName = $(""#PayerName"").val();
            _amount = $(""#ReceivedAmount"").val();
            _amountStatus = false;
            _receptionInvoiceNum = $");
            WriteLiteral(@"(""#ReceivedReceptionInvoiceNum"").val();
            var cur = document.getElementById(""ReciveCurrencyId"");
            if (cur != null)
                _currencyId = cur.value;

        } else if (id == 'pay-tabstrip-2') {

            _payerName = $(""#ReciverName"").val();
            _amount = $(""#ReturnedAmount"").val();
            _amountStatus = true;
            _receptionInvoiceNum = $(""#ReturnedReceptionInvoiceNum"").val();
            var cur = document.getElementById(""ReturnCurrencyId"");
            if (cur != null)
                _currencyId = cur.value;
        }

        var data = {
            ReceptionServiceId: $(this).attr('data-id'),
            PayerName: _payerName,
            Amount: _amount,
            AmountStatus: _amountStatus,
            CurrencyId: _currencyId,
            ReceptionInvoiceNum: _receptionInvoiceNum
        };

        var link = ""/ReceptionServiceReceived/PayService"";

        $("".loader"").removeClass(""hidden"");
        $.ajax({
      ");
            WriteLiteral(@"      type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                $('#btn-addReceptionService-accept').removeAttr(""disabled"");

                if (response !== 0) {
                    if (response === ""SomeThingWentWrong"") {

                        $('#AddReceptionServiceModal #ERROR_SomeThingWentWrong').removeClass('hidden');

                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                    } else if (response === ""ERROR_Data"") {

                        $('#AddReceptionServiceModal #ERROR_Data').removeClass('hidden');

                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    } else {

                        $('#AddReceptionServiceModal').modal('hide');
                        $("".modal-backdrop:last"").remove();
                        $('#AddReceptionServiceModal-body').empty();
    ");
            WriteLiteral(@"                    $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                        $(""#serviceKendoGrid .k-pager-refresh"")[0].click();
                        $(""#kendoPatientReceptionGrid .k-pager-refresh"")[0].click();

                    }
                }
            }
        });
    });

    function closeAddReceptionServiceModal() {

        $('#AddReceptionServiceModal').modal('hide');
        $('#AddReceptionServiceModal-body').empty();
        $("".modal-backdrop:last"").remove();

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guid> Html { get; private set; }
    }
}
#pragma warning restore 1591
