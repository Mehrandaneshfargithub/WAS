#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca691e2acd29a388537a9ff7fae9d4a02681473e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.UserPortion.Views_Shared_PartialViews_AppWebForms_UserPortion_wpPortionReportForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/UserPortion/wpPortionReportForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.UserPortion
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca691e2acd29a388537a9ff7fae9d4a02681473e", @"/Views/Shared/PartialViews/AppWebForms/UserPortion/wpPortionReportForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_UserPortion_wpPortionReportForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
  
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 609, "\"", 622, 1);
#nullable restore
#line 28 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
WriteAttributeValue("", 617, pull, 617, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 637, "\"", 650, 1);
#nullable restore
#line 29 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
WriteAttributeValue("", 645, font, 645, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
       Write(Localizer["PortionReport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n</div><!-- /.page-header -->\r\n\r\n\r\n<div id=\"signup-box\"");
            BeginWriteAttribute("class", " class=\"", 804, "\"", 838, 3);
            WriteAttributeValue("", 812, "signup-box", 812, 10, true);
            WriteAttributeValue(" ", 822, "no-border", 823, 10, true);
#nullable restore
#line 37 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
WriteAttributeValue(" ", 832, font, 833, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca691e2acd29a388537a9ff7fae9d4a02681473e6673", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n\r\n                    <div class=\"col-xs-12\"");
                BeginWriteAttribute("style", " style=\"", 1016, "\"", 1044, 2);
                WriteAttributeValue("", 1024, "padding:0;", 1024, 10, true);
#nullable restore
#line 43 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
WriteAttributeValue("", 1034, direction, 1034, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                        <div class=""col-xs-6"" style=""padding:0"">

                            <div class=""col-sm-6"" style=""padding:0 1rem"">

                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 50 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                                         Write(Localizer["DateFrom"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" : </label>
                                    <span class=""block input-icon input-icon-right"">
                                        <input id=""FromDate"" class=""hidden"" title=""datepicker"" style=""width: 100%;font-size:1.5rem"" type=""date"" />
                                        ");
#nullable restore
#line 53 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                    Write(Html.Kendo().DatePicker()
                                          .Name("KendoFromDate")
                                          .Format("dd/MM/yyyy")
                                          .Value(DateTime.Now)
                                          .HtmlAttributes(new { style = "width: 100%", onchange = "dateTimePickerWorkWithSpace(this)" })
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
#line 68 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                                         Write(Localizer["DateTo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" : </label>
                                    <span class=""block input-icon input-icon-right"">
                                        <input id=""ToDate"" class=""hidden"" title=""datepicker"" style=""width: 100%;font-size:1.5rem"" type=""date"" />
                                        ");
#nullable restore
#line 71 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                    Write(Html.Kendo().DatePicker()
                                          .Name("KendoDateTo")
                                          .Format("dd/MM/yyyy")
                                          .Value(DateTime.Now)
                                          .HtmlAttributes(new { style = "width: 100%", onchange = "dateTimePickerWorkWithSpace(this)" })
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
                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 88 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                                         Write(Localizer["User"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 90 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                    Write(Html.Kendo().DropDownList()
                                              .Name("ClinicSectionId")
                                              .DataTextField("UserName")
                                              .DataValueField("Guid")
                                              .OptionLabel(" ")
                                              .DataSource(source =>
                                              {
                                                  source.Read(read =>
                                                  {
                                                      read.Action("GetAllUserPortionForDropDown", "UserManagment");
                                                  })
                                                  .ServerFiltering(false);
                                              })
                                              .HtmlAttributes(new { style = "width: 100%;" })
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </span>\r\n                                </label>\r\n                            </div>\r\n\r\n                            <div class=\"col-sm-6\" style=\"padding-top:3rem\">\r\n\r\n                                ");
#nullable restore
#line 111 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                            Write(Html.Kendo().CheckBox()
                                    .Name("Detail")
                                    .Label(Localizer["InDetail"])
                                    .HtmlAttributes(new { @class = "kendoCheckbox"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n                    <div class=\"space-24\"></div>\r\n                </fieldset>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div><!-- /.widget-body -->\r\n</div><!-- /.signup-box -->\r\n<div class=\"col-sm-12\" style=\"padding: 0 2rem\">\r\n\r\n");
#nullable restore
#line 131 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
     if ((bool)ViewBag.AccessPrintPortionReport)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
    Write(Html.Kendo().Button()
        .Name("btn-CostReport-accept")
        .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = $"k-primary {pull}", onclick = "AcceptReport()" })
        .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
                                  
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 142 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserPortion\wpPortionReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    $(document).ready(function () {

        var fromDate = $(""#KendoFromDate"").data(""kendoDatePicker"");
        fromDate.element.focus();
        fromDate.element.select();
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
        if (frDay < 10)
            frDay = ""0"" + frDay;
        if (toDay < 10)
            toDay = ""0"" + toDay;

        let from = frDate.getFullYear() + ""-"" + frMonth + ""-"" + frDay;
        let too = tDate.getFullYear() + ""-"" + toMonth + ""-"" + toDay;

        $(""#FromDate"").val(from);
        $(""#ToDate"").val(too);

    })




    $('#KendoFromDate').keypress");
            WriteLiteral(@"(function (e) {

        if (e.which === 13 || e.which === 9) {
            let date = $(""#KendoDateTo"").data(""kendoDatePicker"");
            date.element.focus();
        }
    });

    $('#KendoFromDate').focus(function (e) {

        let date = $(""#KendoFromDate"").data(""kendoDatePicker"");
        date.element.select();

    });

    $('#KendoDateTo').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            $(""#btn-CostReport-accept"").focus();
        }

    });


    $('#KendoDateTo').focus(function (e) {

        let date = $(""#KendoDateTo"").data(""kendoDatePicker"");
        date.element.select();

    });


    function draw2(imgData) {

        ""use strict"";

        var dataUrl = [];
        for (let index = 0; index < imgData.allb.length; index++) {

            var pf = ""data:image/jpeg;base64,"" + imgData.allb[index];

            dataUrl.push(pf)

        }

        printJS({ printable: dataUrl, type: 'image' });

        //pri");
            WriteLiteral(@"ntJS({ printable: dataUrl, type: 'pdf' });

    }


    function AcceptReport() {

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
        if (frDay < 10)
            frDay = ""0"" + frDay;
        if (toDay < 10)
            toDay = ""0"" + toDay;

        let from = frDate.getFullYear() + "":"" + frMonth + "":"" + frDay;
        let to = tDate.getFullYear() + "":"" + toMonth + "":"" + toDay;

        $("".loader"").removeClass(""hidden"");

       
        let clinicSectionId = $(""#ClinicSectionId"").val();
        let detail = $(""#Detail"").prop('ch");
            WriteLiteral(@"ecked');
        var data = {
            fromDate: from,
            toDate: to,
            ClinicSectionId: clinicSectionId,
            Detail: detail
        };
        link = ""/UserManagment/PrintPortionReport?"";

        $("".loader"").removeClass(""hidden"");

        $.ajax({
            url: link,
            type: ""Post"",
            data: data,
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

        //}, 20);

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
