#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f227a480389b285abe7ed304bde19ba4f0b0ef8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.HospitalPatients.Views_Shared_PartialViews_AppWebForms_HospitalPatients_wpPatientsLabReportForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/HospitalPatients/wpPatientsLabReportForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.HospitalPatients
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f227a480389b285abe7ed304bde19ba4f0b0ef8d", @"/Views/Shared/PartialViews/AppWebForms/HospitalPatients/wpPatientsLabReportForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_HospitalPatients_wpPatientsLabReportForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 8 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
  
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
            BeginWriteAttribute("class", " class=\"", 577, "\"", 590, 1);
#nullable restore
#line 28 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
WriteAttributeValue("", 585, pull, 585, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 605, "\"", 618, 1);
#nullable restore
#line 29 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
WriteAttributeValue("", 613, font, 613, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
       Write(Localizer["PatientToAnotherSectionReport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n</div><!-- /.page-header -->\r\n\r\n\r\n<div id=\"signup-box\"");
            BeginWriteAttribute("class", " class=\"", 790, "\"", 824, 3);
            WriteAttributeValue("", 798, "signup-box", 798, 10, true);
            WriteAttributeValue(" ", 808, "no-border", 809, 10, true);
#nullable restore
#line 38 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
WriteAttributeValue(" ", 818, font, 819, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f227a480389b285abe7ed304bde19ba4f0b0ef8d6621", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n\r\n                    <div class=\"col-xs-12\"");
                BeginWriteAttribute("style", " style=\"", 1002, "\"", 1021, 2);
#nullable restore
#line 44 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
WriteAttributeValue("", 1010, direction, 1010, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1020, "", 1021, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">

                        <div class=""col-xs-6"" style=""padding:0"">

                            <div class=""col-sm-6"" style=""padding:0 1rem"">
                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 50 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                                         Write(Localizer["Section"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 52 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                    Write(Html.Kendo().DropDownList()
                                        .Name("Section")
                                        .DataValueField("Guid")
                                        .DataTextField("Name")
                                        .Filter("contains")
                                        .OptionLabel(" ")
                                        .DataSource(source =>
                                        {
                                            source.Read(read =>
                                            {
                                                read.Action("GetAllParentClinicSections", "ClinicSection");
                                            })
                                            .ServerFiltering(false);
                                        })
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
#line 75 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                                         Write(Localizer["DateFrom"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 77 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                    Write(Html.Kendo().DatePicker()
                                          .Name("FromDate")
                                          .Format("dd/MM/yyyy")
                                          .Value(DateTime.Now)
                                          .HtmlAttributes(new { style = "width: 100%" })
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </span>
                                </label>
                            </div>

                        </div>

                        <div class=""col-xs-6"" style=""padding: 0; display: flex; align-items: end"">
                            <div class=""col-sm-6"" style=""padding:0 1rem"">
                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 92 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                                         Write(Localizer["DateTo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 94 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                    Write(Html.Kendo().DatePicker()
                                          .Name("ToDate")
                                          .Format("dd/MM/yyyy")
                                          .Value(DateTime.Now)
                                          .HtmlAttributes(new { style = "width: 100%"})
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </span>\r\n\r\n                                </label>\r\n                            </div>\r\n\r\n                            <div class=\"col-sm-6\" style=\"padding-bottom:0.5rem\">\r\n");
#nullable restore
#line 106 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                 if ((bool)ViewBag.AccessPrintFundReportFromSections)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                Write(Html.Kendo().Button()
                                        .Name("btn-SalaryReport-accept")
                                        .HtmlAttributes(new { style = "font-size:15px;height:35px;", type = "button", @class = $"k-primary ", onclick = "AcceptReport()" })
                                        .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
                                                                  
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"space-24\"></div>\r\n                </fieldset>\r\n            ");
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
            BeginWriteAttribute("style", " style=\"", 5297, "\"", 5370, 5);
            WriteAttributeValue("", 5305, "padding-top:1rem;display:", 5305, 25, true);
            WriteAttributeValue(" ", 5330, "flex;align-items:", 5331, 18, true);
            WriteAttributeValue(" ", 5348, "flex-end;", 5349, 10, true);
#nullable restore
#line 126 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
WriteAttributeValue(" ", 5358, direction, 5359, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5369, "", 5370, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 5388, "\"", 5410, 2);
            WriteAttributeValue("", 5396, "col-xs-6", 5396, 8, true);
#nullable restore
#line 128 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
WriteAttributeValue(" ", 5404, font, 5405, 5, false);

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

            </div>

            <div class=""col-sm-6"">

               


            </div>
        </div>

    </div>

</div>


");
#nullable restore
#line 160 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 161 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\HospitalPatients\wpPatientsLabReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    function BackToHospitalPatient() {
        $("".loader"").removeClass(""hidden"");

        let link = ""/HospitalPatient/Form"";

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


    function draw2(imgDat");
            WriteLiteral(@"a) {

        ""use strict"";

        var dataUrl = [];
        for (let index = 0; index < imgData.allb.length; index++) {

            var pf = ""data:image/jpeg;base64,"" + imgData.allb[index];

            dataUrl.push(pf)

        }

        printJS({ printable: dataUrl, type: 'image' });
    }


    function GetPeriodForPatientToAnotherSection() {

        var fromDate = $(""#FromDate"").data(""kendoDatePicker"");
        var toDate = $(""#ToDate"").data(""kendoDatePicker"");

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

        let from = frDate.ge");
            WriteLiteral(@"tFullYear() + ""-"" + frMonth + ""-"" + frDay;
        let too = tDate.getFullYear() + ""-"" + toMonth + ""-"" + toDay;

        var period = $(""#Section"").data(""kendoDropDownList"");

        var periodValue = period.value();
        var periodText = period.text();

        let section = { Id: periodValue, Name: periodText }

        return {

            dateFrom: from,
            dateTo: too,
            section: section,
        };
    }

    function AcceptReport() {

        $("".loader"").removeClass(""hidden"");

        var data = GetPeriodForPatientToAnotherSection();

        link = ""/HospitalPatient/PrintPatientToAnotherSectionReport"";

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
            error: f");
            WriteLiteral("unction (response) {\r\n                console.log(response);\r\n                console.log(response.data);\r\n                console.log(response.error);\r\n            }\r\n        });\r\n\r\n    }\r\n\r\n</script>\r\n");
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
