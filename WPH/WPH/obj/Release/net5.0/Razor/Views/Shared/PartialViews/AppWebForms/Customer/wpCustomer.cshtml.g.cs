#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba7f8c53a2427ccc142883c4c883b4d0c8ff366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Customer.Views_Shared_PartialViews_AppWebForms_Customer_wpCustomer), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Customer/wpCustomer.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Customer
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
#line 1 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba7f8c53a2427ccc142883c4c883b4d0c8ff366", @"/Views/Shared/PartialViews/AppWebForms/Customer/wpCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Customer_wpCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newCustomerText\" class=\"hidden\">");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
                                           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
                                                             Write(Localizer["Customer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newCustomerText\" class=\"hidden\">");
#nullable restore
#line 19 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
                                           Write(Localizer["Customer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
                                                                  Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editCustomerText\" class=\"hidden\">");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
                                        Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
                                                           Write(Localizer["Customer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n\r\n<style>\r\n\r\n\r\n    ");
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

        #AddCustomerModal-body {
            width: 90vw;
        }
    }

    ");
            WriteLiteral("@media (min-width:768px) {\r\n        #AddCustomerModal-body {\r\n            width: 60vw;\r\n        }\r\n    }\r\n</style>\r\n\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1409, "\"", 1423, 2);
#nullable restore
#line 58 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue("", 1417, pull, 1417, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1422, "", 1423, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 1438, "\"", 1451, 1);
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue("", 1446, font, 1446, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 60 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
       Write(Localizer["Customers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n");
#nullable restore
#line 65 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
     if ((bool)ViewBag.AccessNewCustomer)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1611, "\"", 1630, 2);
#nullable restore
#line 67 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue("", 1619, font, 1619, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue(" ", 1624, pull, 1625, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n            <a class=\"btn btn-danger\" onClick=\"AddCustomer(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n                ");
#nullable restore
#line 69 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 73 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div><!-- /.page-header -->\r\n<!-- Modal -->\r\n<div id=\"AddCustomerModal\"");
            BeginWriteAttribute("class", " class=\"", 2024, "\"", 2048, 3);
            WriteAttributeValue("", 2032, "modal", 2032, 5, true);
            WriteAttributeValue(" ", 2037, "fade", 2038, 5, true);
#nullable restore
#line 78 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue(" ", 2042, font, 2043, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 2094, "\"", 2112, 1);
#nullable restore
#line 78 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue("", 2102, direction, 2102, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeAddCustomerModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""AddCustomerModal-header""");
            BeginWriteAttribute("class", " class=\"", 2396, "\"", 2440, 5);
            WriteAttributeValue("", 2404, "smaller", 2404, 7, true);
            WriteAttributeValue(" ", 2411, "lighter", 2412, 8, true);
            WriteAttributeValue(" ", 2419, "blue", 2420, 5, true);
            WriteAttributeValue(" ", 2424, "no-margin", 2425, 10, true);
#nullable restore
#line 83 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue(" ", 2434, font, 2435, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </h3>
            </div>

            <div id=""AddCustomerModal-body"" class=""modal-body"" >

            </div>

            <div id=""ERROR_Data"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 93 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 98 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 103 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addCustomer-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 107 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addCustomer-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick= "closeAddCustomerModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n<!-- Grid -->\r\n<div");
            BeginWriteAttribute("class", " class=\"", 3815, "\"", 3845, 3);
            WriteAttributeValue("", 3823, "row", 3823, 3, true);
            WriteAttributeValue(" ", 3826, "Grid-Content", 3827, 13, true);
#nullable restore
#line 119 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
WriteAttributeValue(" ", 3839, font, 3840, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 120 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/Customer/dgCustomerGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 122 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 123 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Customer\wpCustomer.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>

    function AddCustomer(element) {
        $(""#AddCustomerModal #ERROR_Data"").addClass(""hidden"");
        $(""#AddCustomerModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var link = ""/Customer/AddNewModal"";
        $("".loader"").removeClass(""hidden"");

        let header = $(""#newCustomerText"").text();

        $('#AddCustomerModal-header').text(header);
        $('#AddCustomerModal').modal('toggle');
        $('#AddCustomerModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });

    }

    function EditCustomer(element) {
        $(""#AddCustomerModal #ERROR_Data"").addClass(""hidden"");
        $(""#AddCustomerModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#AddCustomerModal').modal('toggle');
        let header = $(""#editCustomerText"").text();
        $('#AddCustomerModal-header').text(header);
        var link = ""/Customer/EditModal?Id="";
        var Id = ");
            WriteLiteral(@"$(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");
        $('#AddCustomerModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    $('#btn-addCustomer-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#AddCustomerModal #ERROR_Data"").addClass(""hidden"");
        $(""#AddCustomerModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var mobile = $(""#AddCustomerModal #Mobile-wrong"");
        if (mobile) {
            mobile.addClass(""hidden"");

            if ($('[validate-mobile=""Mobile-wrong""]').val() !== undefined) {
                let text = $('[validate-mobile=""Mobile-wrong""]').val();
                if (text != """" & text.trim().length < 8) {
                    mobile.removeClass(""hidden"");
                    $('#btn-addCustomer-accept').removeAttr(""disabled"");
                    return;
                }
            ");
            WriteLiteral(@"}
        }

        $('.emptybox').addClass('hidden');
        var isEmmpty = true;
        $('.emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    $('#btn-addCustomer-accept').removeAttr(""disabled"");
                    isEmmpty = false;
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }
            

        var link = ""/Customer/AddOrUpdate"";
        var data = $(""#addNewCustomerForm"").serialize();

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                $('#btn-addCustomer-accept').removeAttr(""disabled"");

                ");
            WriteLiteral(@"if (response !== 0) {
                    if (response === ""ValueIsRepeated"") {

                        $('#Name-Exist').removeClass('hidden');
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    } else if (response === ""DataNotValid"") {

                        $(""#AddCustomerModal #ERROR_Data"").removeClass(""hidden"");
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    } else if (response === ""WrongMobile"") {

                        $(""#AddCustomerModal #Mobile-wrong"").removeClass(""hidden"");
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    } else {

                        $('#AddCustomerModal').modal('hide');
                        $("".modal-backdrop:last"").remove();
                        $('#AddCustomerModal-body').empty();
                  ");
            WriteLiteral(@"      $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                        $("".k-pager-refresh"")[0].click();
                    }
                } else {

                    $(""#AddCustomerModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    });

    function closeAddCustomerModal() {
        $('#AddCustomerModal').modal('hide');
        $('#AddCustomerModal-body').empty();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
