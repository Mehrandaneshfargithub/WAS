#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a5052950528f87b0a72e02d6d2e2f65a21126a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Pay.Views_Shared_PartialViews_AppWebForms_Pay_wpPayReportForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Pay/wpPayReportForm.cshtml")]
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5052950528f87b0a72e02d6d2e2f65a21126a9", @"/Views/Shared/PartialViews/AppWebForms/Pay/wpPayReportForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Pay_wpPayReportForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addNewForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
  
    string font = "", pull = "", direction = "", pull_rev = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";
        pull_rev = " pull-right ";
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";
        pull_rev = " pull-left ";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 663, "\"", 676, 1);
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue("", 671, pull, 671, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 691, "\"", 704, 1);
#nullable restore
#line 31 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue("", 699, font, 699, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 32 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
       Write(Localizer["PurchaseReport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 815, "\"", 832, 1);
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue("", 823, pull_rev, 823, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 895, "\"", 903, 0);
            EndWriteAttribute();
            WriteLiteral(@" onClick=""BackToPay()"" style=""padding:0.2rem;cursor:pointer;font-size: 20px;"">
            <span>
                <i class=""ace-icon fa fa-arrow-left align-top bigger-125""></i>
            </span>
        </a>
    </div>
</div><!-- /.page-header -->


<div id=""signup-box""");
            BeginWriteAttribute("class", " class=\"", 1185, "\"", 1219, 3);
            WriteAttributeValue("", 1193, "signup-box", 1193, 10, true);
            WriteAttributeValue(" ", 1203, "no-border", 1204, 10, true);
#nullable restore
#line 47 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue(" ", 1213, font, 1214, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a5052950528f87b0a72e02d6d2e2f65a21126a97251", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n\r\n\r\n                    <div class=\"col-xs-12\"");
                BeginWriteAttribute("style", " style=\"", 1399, "\"", 1417, 1);
#nullable restore
#line 54 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue("", 1407, direction, 1407, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                        <div class=\"col-xs-6\" style=\"padding:0;display: flex;align-items: flex-end;\">\r\n\r\n                            <div class=\"col-sm-6\" style=\"padding:0 1rem\">\r\n                                <label");
                BeginWriteAttribute("class", " class=\"", 1641, "\"", 1669, 3);
                WriteAttributeValue("", 1649, "block", 1649, 5, true);
                WriteAttributeValue(" ", 1654, "clearfix", 1655, 9, true);
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue(" ", 1663, font, 1664, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <label for=\"form-field-8\">");
#nullable restore
#line 60 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                                         Write(Localizer["Suppliers"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 62 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                    Write(Html.Kendo().DropDownList()
                                        .Name("Supplier")
                                        .DataTextField("Name")
                                        .DataValueField("Guid")
                                        .Filter("contains")
                                        .DataSource(source =>
                                        {
                                            source.Read(read =>
                                            {
                                                read.Action("GetAllSuppliers", "Supplier");
                                            })
                                            .ServerFiltering(false);
                                        })
                                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem" })
                                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </span>\r\n\r\n                                </label>\r\n                            </div>\r\n\r\n                            <div class=\"col-sm-6\" style=\"padding:0 1rem\">\r\n                                <label");
                BeginWriteAttribute("class", " class=\"", 3042, "\"", 3070, 3);
                WriteAttributeValue("", 3050, "block", 3050, 5, true);
                WriteAttributeValue(" ", 3055, "clearfix", 3056, 9, true);
#nullable restore
#line 83 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue(" ", 3064, font, 3065, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <label for=\"form-field-8\"> </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 86 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                    Write(Html.Kendo().DropDownList()
                                        .Name("PayReportFilter")
                                        .DataTextField("Name")
                                        .DataValueField("Id")
                                        .DataSource(source =>
                                        {
                                            source.Read(read =>
                                            {
                                                read.Action("GetAllPayReportFilter", "SupplierAccount");
                                            })
                                            .ServerFiltering(false);
                                        })
                                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem" })
                                            );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </span>

                                </label>
                            </div>

                        </div>

                        <div class=""col-xs-6"" style=""padding:0"">
                            <div class=""col-sm-6"" style=""padding:0 1rem"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 4475, "\"", 4503, 3);
                WriteAttributeValue("", 4483, "block", 4483, 5, true);
                WriteAttributeValue(" ", 4488, "clearfix", 4489, 9, true);
#nullable restore
#line 109 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue(" ", 4497, font, 4498, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <label for=\"form-field-8\">");
#nullable restore
#line 110 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                                         Write(Localizer["Currency"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 112 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
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
                                        .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem" })
                                            );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </span>

                                </label>
                            </div>

                            <div class=""col-sm-6"" style=""padding-top:3rem"">

                            </div>
                        </div>

                    </div>

                    <div class=""col-xs-12""");
                BeginWriteAttribute("style", " style=\"", 5980, "\"", 5998, 1);
#nullable restore
#line 139 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue("", 5988, direction, 5988, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 140 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                          
                            var now = DateTime.Now;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""col-xs-6"" style=""padding:0"">

                            <div class=""col-sm-6"" style=""padding:0 1rem"">
                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 147 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                                         Write(Localizer["DateFrom"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 149 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                    Write(Html.Kendo().DatePicker()
                                          .Name("FromDate")
                                          .Format("dd/MM/yyyy")
                                          .Value(new DateTime(now.Year, 1, 1))
                                          .HtmlAttributes(new { style = "width: 100%" })
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </span>
                                </label>
                            </div>

                            <div class=""col-sm-6"" style=""padding:0 1rem"">
                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 161 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                                         Write(Localizer["DateTo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 163 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                                    Write(Html.Kendo().DatePicker()
                                          .Name("ToDate")
                                          .Format("dd/MM/yyyy")
                                          .Value(now)
                                          .HtmlAttributes(new { style = "width: 100%"})
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </span>

                                </label>
                            </div>

                        </div>

                        <div class=""col-xs-6"" style=""padding:0"">
                            <div class=""col-sm-6"" style=""padding:0 1rem;margin-top:3rem;"">
                                ");
#nullable restore
#line 178 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
                            Write(Html.Kendo().CheckBox()
                                .Name("Detail")
                                .Label(Localizer["InDetail"])
                                .HtmlAttributes(new { @class = "kendoCheckbox"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </div>

                            <div class=""col-sm-6"" style=""padding-top:3rem"">

                            </div>
                        </div>

                    </div>

                    <div class=""space-24""></div>
                </fieldset>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div><!-- /.widget-body -->\r\n</div><!-- /.signup-box -->\r\n<div class=\"col-sm-12\">\r\n\r\n    <div class=\"col-xs-12\"");
            BeginWriteAttribute("style", " style=\"", 8757, "\"", 8830, 5);
            WriteAttributeValue("", 8765, "padding-top:1rem;display:", 8765, 25, true);
            WriteAttributeValue(" ", 8790, "flex;align-items:", 8791, 18, true);
            WriteAttributeValue(" ", 8808, "flex-end;", 8809, 10, true);
#nullable restore
#line 200 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue(" ", 8818, direction, 8819, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8829, "", 8830, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 8848, "\"", 8870, 2);
            WriteAttributeValue("", 8856, "col-xs-6", 8856, 8, true);
#nullable restore
#line 202 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
WriteAttributeValue(" ", 8864, font, 8865, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""padding:0"">

            <div class=""col-sm-6"">
            </div>

            <div class=""col-sm-6"">
            </div>

        </div>

        <div class=""col-xs-6"" style=""padding:0"">
            <div class=""col-sm-6"">
                ");
#nullable restore
#line 214 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-PayReport-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = $"k-primary {pull_rev}", onclick = "AcceptReport()" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"col-sm-6\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 231 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 232 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Pay\wpPayReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    function BackToPay() {
        $("".loader"").removeClass(""hidden"");

        let link = ""/SupplierAccount/Form"";

        $("".page-content"").load(link, function (responce) {

            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        })
    }

    $('#FromDate').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            let date = $(""#ToDate"").data(""kendoDatePicker"");
            date.element.focus();
        }
    });

    $('#FromDate').focus(function (e) {

        let date = $(""#FromDate"").data(""kendoDatePicker"");
        date.element.select();

    });

    $('#ToDate').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            $(""#btn-CostReport-accept"").focus();
        }

    });


    $('#ToDate').focus(function (e) {

        let date = $(""#ToDate"").data(""kendoDatePicker"");
        date.element.select();

    });


    function draw2(imgData) {

    ");
            WriteLiteral(@"    ""use strict"";

        var dataUrl = [];
        for (let index = 0; index < imgData.allb.length; index++) {

            var pf = ""data:image/jpeg;base64,"" + imgData.allb[index];

            dataUrl.push(pf)

        }

        printJS({ printable: dataUrl, type: 'image' });
    }


    function AcceptReport() {

        $("".loader"").removeClass(""hidden"");

        let detail = $(""#Detail"").prop('checked');
        var cur = $(""#Currency"").data(""kendoDropDownList"");

        var data = {
            SupplierId: $(""#Supplier"").val(),
            FilterId: $(""#PayReportFilter"").val(),
            CurrencyId: cur.value(),
            CurrencyName: cur.text(),
            TxtFromDate: $(""#FromDate"").val(),
            TxtToDate: $(""#ToDate"").val(),
            Detail: detail,
        };

        link = ""/SupplierAccount/PrintPayReport"";

        $("".loader"").removeClass(""hidden"");

        $.ajax({
            url: link,
            type: ""Post"",
            data: data");
            WriteLiteral(@",
            success: function (response) {

                draw2(response);
                $("".loader"").fadeIn(""slow"");
                $("".loader"").addClass(""hidden"");
            },
            error: function (response) {
                console.log(response);
                console.log(response.data);
                console.log(response.error);
            }
        });

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
