#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71a0f9f13bd9a7191bbd98a5a2c50c46fc2cc42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.MedicineReport.Views_Shared_PartialViews_AppWebForms_MedicineReport_wpMedicineReportForm), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/MedicineReport/wpMedicineReportForm.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.MedicineReport
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
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71a0f9f13bd9a7191bbd98a5a2c50c46fc2cc42", @"/Views/Shared/PartialViews/AppWebForms/MedicineReport/wpMedicineReportForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_MedicineReport_wpMedicineReportForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row page-header\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 218, "\"", 388, 2);
            WriteAttributeValue("", 226, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 10 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("pull-right\r\n");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
        }
        else {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("pull-left\r\n");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 226, 161, false);
            WriteAttributeValue(" ", 387, "", 388, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 403, "\"", 883, 1);
            WriteAttributeValue("", 411, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 16 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 18 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 411, 472, false);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
       Write(Localizer["MedicineReport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n</div><!-- /.page-header -->\r\n\r\n\r\n<div id=\"signup-box\"");
            BeginWriteAttribute("class", " class=\"", 1038, "\"", 1539, 3);
            WriteAttributeValue("", 1046, "signup-box", 1046, 10, true);
            WriteAttributeValue(" ", 1056, "no-border", 1057, 10, true);
            WriteAttributeValue(" ", 1066, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 28 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                  if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Roboto-grid\r\n");
#nullable restore
#line 30 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                                                  } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                    ");
                WriteLiteral("MyFont-Sarchia-grid\r\n");
#nullable restore
#line 32 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1067, 472, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71a0f9f13bd9a7191bbd98a5a2c50c46fc2cc429308", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n\r\n                    <div class=\"col-xs-12\"");
                BeginWriteAttribute("style", " style=\"", 1717, "\"", 1896, 2);
                WriteAttributeValue("", 1725, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 38 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                   if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                    WriteLiteral("direction:rtl\r\n");
#nullable restore
#line 40 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                }
        else {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                    WriteLiteral("ltr\r\n");
#nullable restore
#line 43 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
        }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 1725, 170, false);
                WriteAttributeValue(" ", 1895, "", 1896, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">

                        <div class=""col-xs-6"" style=""padding:0"">

                            <div class=""col-sm-6"" style=""padding:0 1rem"">

                                <label class=""block clearfix"">
                                    <label for=""form-field-8"">");
#nullable restore
#line 50 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                         Write(Localizer["DateFrom"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" : </label>
                                    <span class=""block input-icon input-icon-right"">
                                        <input id=""FromDate"" class=""hidden"" title=""datepicker"" style=""width: 100%;font-size:1.5rem"" type=""date"" />
                                        ");
#nullable restore
#line 53 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
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
#line 68 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                         Write(Localizer["DateTo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" : </label>
                                    <span class=""block input-icon input-icon-right"">
                                        <input id=""ToDate"" class=""hidden"" title=""datepicker"" style=""width: 100%;font-size:1.5rem"" type=""date"" />
                                        ");
#nullable restore
#line 71 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
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

                        <script>

                            function OnSelectMedicineOrProducer(e) {

                                var DataItem = this.dataItem(e.item.index());
                                var id = this.element.attr('id');

                                if (id === ""MedicineName"") {
                                    $(""#MedicineId"").text(DataItem.Guid);
                                    return
                                }

                                if (id === ""ProducerName"") {
                                    $(""#ProducerId"").text(DataItem.Guid);
                                    return
                                }

                                
                            }




                        </script>

                        <div class=""col-xs-6"" style=""padd");
                WriteLiteral("ing:0\">\r\n\r\n                            <div class=\"col-sm-6\" style=\"padding:0 1rem\">\r\n\r\n                                <label class=\"block clearfix\">\r\n                                    <label for=\"form-field-8\">");
#nullable restore
#line 115 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                         Write(Localizer["Medicine"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 117 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                    Write(Html.Kendo().AutoComplete()
                                              .Name("MedicineName")
                                              .DataTextField("JoineryName")
                                              .Events(events => events.Select("OnSelectMedicineOrProducer"))
                                              .Filter("contains")
                                              .HighlightFirst(true)
                                              .ClearButton(false)
                                              .HtmlAttributes(new { @id = "MedicineName", style = "width:100%"})
                                              .DataSource(source =>
                                              {
                                                  source.Read(read =>
                                                  {
                                                      read.Action("GetAllMedicine", "Medicine");
                                                  })
                                                  .ServerFiltering(false);
                                              })
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
#line 143 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                                         Write(Localizer["Producer"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                                    <span class=\"block input-icon input-icon-right\">\r\n                                        ");
#nullable restore
#line 145 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                    Write(Html.Kendo().AutoComplete()
                                              .Name("ProducerName")
                                              .DataTextField("Name")
                                              .Events(events => events.Select("OnSelectMedicineOrProducer"))
                                              .Filter("contains")
                                              .HighlightFirst(true)
                                              .ClearButton(false)
                                              .HtmlAttributes(new { @id = "ProducerName", style = "width:100%"})
                                              .DataSource(source =>
                                              {
                                                  source.Read(read =>
                                                  {
                                                      read.Action("GetAllProducers", "BaseInfo");
                                                  })
                                                  .ServerFiltering(false);
                                              })
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </span>

                                </label>

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
            WriteLiteral("\r\n        </div>\r\n    </div><!-- /.widget-body -->\r\n</div><!-- /.signup-box -->\r\n<div class=\"col-sm-12\">\r\n\r\n");
#nullable restore
#line 181 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
      
        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
        Write(Html.Kendo().Button()
                    .Name("btn-MedicineReport-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick = "AcceptReport()" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                              
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
        Write(Html.Kendo().Button()
                    .Name("btn-MedicineReport-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-left", onclick = "AcceptReport()" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
                                              
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<h3 class=\"hidden\" id=\"MedicineId\"></h3>\r\n<h3 class=\"hidden\" id=\"ProducerId\"></h3>\r\n\r\n");
#nullable restore
#line 205 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 206 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\MedicineReport\wpMedicineReportForm.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>



    //var canvas;
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




    $('#K");
            WriteLiteral(@"endoFromDate').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            let date = $(""#KendoDateTo"").data(""kendoDatePicker"");
            date.element.focus();
            //date.element.select();
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


            var img = new Image();
            img.src = ""data:image/jpeg;base64,"" + imgData.allb[index];
            dat");
            WriteLiteral(@"aUrl.push(img.src)


        }

        printJS({ printable: dataUrl, type: 'image' });

    }

    $(""#MedicineName"").on('focus', function (e) {
        let medicineAuto = $(""#MedicineName"").data(""kendoAutoComplete"");
        let value = medicineAuto.value();
        medicineAuto.search(value);
    });

    $(""#ProducerName"").on('focus', function (e) {
        let producerAuto = $(""#ProducerName"").data(""kendoAutoComplete"");
        let value = producerAuto.value();
        producerAuto.search(value);
    });


    function AcceptReport() {

        var fromDate = $(""#KendoFromDate"").data(""kendoDatePicker"");
        var toDate = $(""#KendoDateTo"").data(""kendoDatePicker"");

        let medicineAuto = $(""#MedicineName"").data(""kendoAutoComplete"");
        let producerAuto = $(""#ProducerName"").data(""kendoAutoComplete"");

        var frDate = fromDate.value();
        var tDate = toDate.value();
        let frMonth = frDate.getMonth() + 1;
        let frDay = frDate.getDate();
    ");
            WriteLiteral(@"    let toMonth = tDate.getMonth() + 1;
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

        setTimeout(function () {



            let from = $(""#FromDate"").val();
            let to = $(""#ToDate"").val();
            let medicineId = $(""#MedicineId"").text();
            let producerId = $(""#ProducerId"").text();

            if (medicineAuto.value() === """" || medicineAuto.value() === null) {
                medicineId = """";
            }

            if (producerAuto.value() === """" || producerAuto.value() === null) {
                producerId ");
            WriteLiteral(@"= """";
            }


            var data = { fromDate: from, toDate: to, MedicineId: medicineId, ProducerId: producerId};
            link = ""/MedicineReport/PrintMedicineReport"";

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


        }, 20);




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
