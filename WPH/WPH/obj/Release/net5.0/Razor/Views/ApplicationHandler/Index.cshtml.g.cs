#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f32d97ddd777f789fe6da2cea4d86bfea178f69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.ApplicationHandler.Views_ApplicationHandler_Index), @"mvc.1.0.view", @"/Views/ApplicationHandler/Index.cshtml")]
namespace WPH.Pages.ApplicationHandler
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f32d97ddd777f789fe6da2cea4d86bfea178f69", @"/Views/ApplicationHandler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationHandler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/mainViews/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
  
    string pull = "", direction = "", font = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = "MyFont-Roboto-grid";
        pull = " pull-right ";
        direction = " direction:ltr; ";

    }
    else
    {
        font = "MyFont-Sarchia-grid";
        pull = " pull-left ";
        direction = " direction:rtl; ";

    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 653, "\"", 944, 4);
            WriteAttributeValue("", 661, "main-container", 661, 14, true);
            WriteAttributeValue(" ", 675, "ace-save-state", 676, 15, true);
            WriteAttributeValue(" ", 690, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 32 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
                                           if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("rtl\r\n");
#nullable restore
#line 34 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
                                                                                  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 691, 252, false);
            WriteAttributeValue(" ", 943, "", 944, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"main-container\">\r\n    ");
#nullable restore
#line 35 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_indexMainContainer.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div><!-- /.main-container -->\r\n\r\n\r\n\r\n<div id=\"MoneyConvertStartModal\"");
            BeginWriteAttribute("class", " class=\"", 1145, "\"", 1169, 3);
            WriteAttributeValue("", 1153, "modal", 1153, 5, true);
            WriteAttributeValue(" ", 1158, "fade", 1159, 5, true);
#nullable restore
#line 40 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
WriteAttributeValue(" ", 1163, font, 1164, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1215, "\"", 1233, 1);
#nullable restore
#line 40 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
WriteAttributeValue("", 1223, direction, 1223, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""CloseMoneyConvertStart()"" aria-hidden=""true"">&times;</button>
                <h3 id=""MoneyConvertStartModal-header"" class=""smaller lighter blue no-margin MyFont-Merriweather-grid"">");
#nullable restore
#line 45 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
                                                                                                                  Write(Localizer["MoneyConvert"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n\r\n            <div id=\"MoneyConvertStartModal-body\" class=\"modal-body col-xs-12\" style=\"background-color:white\">\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer col-xs-12\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-MoneyConvertStartModal-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right ", onclick = "AddMoneyConvertStart()" })
                    .Content(@Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-MoneyConvertStartModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right ", onclick = "CloseMoneyConvertStart()" })
                    .Content(@Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 67 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
 if ((ViewBag.UnReadMessage ?? 0) > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"UnReadMessageModal\" class=\"modal fade \" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 2695, "\"", 2714, 1);
#nullable restore
#line 69 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
WriteAttributeValue(" ", 2703, direction, 2704, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 2880, "\"", 2899, 2);
            WriteAttributeValue("", 2888, "close", 2888, 5, true);
#nullable restore
#line 73 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
WriteAttributeValue(" ", 2893, pull, 2894, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-dismiss=""modal"" aria-hidden=""true"" style="" "">
                        &times;
                    </button>
                    <h3 id=""RemaningDays-header"" class=""smaller lighter blue no-margin "">
                        <i class='ace-icon fa fa-exclamation-triangle red '></i>");
#nullable restore
#line 77 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
                                                                           Write(Localizer["UnReadMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n\r\n                <div id=\"RemaningDays-body\" class=\"modal-body\" style=\"width:60rem;display: flex;justify-content: space-between;\">\r\n                    <h2>\r\n                        ");
#nullable restore
#line 83 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
                   Write(ViewBag.UnReadMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 83 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
                                          Write(Localizer["UnReadMessageInReminder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n\r\n                    <h2>\r\n                        <a class=\' grid-btn \' onClick=\'GoToReminder()\'>\r\n                            <span");
            BeginWriteAttribute("class", " class=\'", 3674, "\'", 3682, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: rgba(0, 0, 74,0.9);"">
                                <i class='ace-icon fa fa fa-bell-o bigger-120'></i>
                            </span>
                        </a>
                    </h2>

                </div>


                <div class=""modal-footer"">


                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            $(\'#UnReadMessageModal\').modal(\'toggle\');\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 111 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\ApplicationHandler\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>


    $(document).ready(function () {

        //var link = ""/MoneyConvert/AddNewModal"";
        //$("".loader"").removeClass(""hidden"");
        //$('#MoneyConvertStartModal').modal('toggle');
        //$('#MoneyConvertStartModal-body').load(link, function () {
        //    $("".loader"").fadeIn(""slow"");
        //    $("".loader"").addClass(""hidden"");
        //    let numerictextbox = $(""#Amount"").data(""kendoNumericTextBox"");
        //    numerictextbox.focus();
        //});

    })

    function GoToReminder() {

        $("".loader"").removeClass(""hidden"");
        $('#UnReadMessageModal').modal('toggle');

        let link = ""/Reminder/Form"";

        $("".page-content"").load(link, function (responce) {

            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })
    }

    function AddMoneyConvertStart() {

        let amount = $(""#Amount"").data(""kendoNumericTextBox"").value();

        if (amount === 0 || amount === """" || amo");
            WriteLiteral(@"unt === null) {

            bootbox.alert({
                message: ""please Insert Amount"",
                className: 'bootbox-class'

            });
            return;

        }


        var token = $(':input:hidden[name*=""RequestVerificationToken""]');


        $.ajax({
            type: ""Post"",
            data: { __RequestVerificationToken: token.attr('value'), BaseCurrencyId: 12, DestCurrencyId: 11, Amount: amount },
            url: ""/MoneyConvert/AddOrUpdate"",
            success: function (response) {
                $('#MoneyConvertStartModal').modal('toggle');
                $('#MoneyConvertStartModal-body').empty();
            }
        });
    }

    function CloseMoneyConvertStart() {
        $('#MoneyConvertStartModal').modal('toggle');
        $('#MoneyConvertStartModal-body').empty();
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
