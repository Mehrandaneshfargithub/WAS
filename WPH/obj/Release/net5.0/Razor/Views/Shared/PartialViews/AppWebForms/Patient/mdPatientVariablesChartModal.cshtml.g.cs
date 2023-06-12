#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e0dd7bc2f5d6fb408b49d553ef38b046ce8ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Patient.Views_Shared_PartialViews_AppWebForms_Patient_mdPatientVariablesChartModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Patient/mdPatientVariablesChartModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Patient
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
#line 3 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e0dd7bc2f5d6fb408b49d553ef38b046ce8ae1", @"/Views/Shared/PartialViews/AppWebForms/Patient/mdPatientVariablesChartModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Patient_mdPatientVariablesChartModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.Chart.ChartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"


<div class=""row"">

    <div class=""col-sm-12"">
        <div class=""box-col"">
            <h4>Export chart</h4>
            <button class='export-pdf k-button'>Save as PDF</button>
        </div>
        <div id=""chart""></div>

        <div style=""margin-top:2rem"">

");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml"
              
                foreach (var choosenValue in Model.AllClinicSectionChoosenValues)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n\r\n                        ");
#nullable restore
#line 25 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml"
                    Write(Html.Kendo().CheckBox()
                               .Name(choosenValue.VariableNameForView)
                               .Label(choosenValue.PatientVariableVariableName)
                               .Checked(true)
                               .HtmlAttributes(new
                                       {
                                           @class = "kendoChartCheckbox",
                                           style = "font-size:5rem",
                                           @data_type = "checkbox",
                                           @data_name = choosenValue.PatientVariableVariableName,
                                           onchange = "refreshChart()"
                                       }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </div>\r\n");
#nullable restore
#line 40 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml"

                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

    </div>




</div>


<script>



    var Values;

    var category = [];

    function createChart() {






        $(""#chart"").kendoChart({
            //dataSource: {
            //    data: internetUsers
            //},
            pdf: {
                    fileName: $(""#PatientName"").text()
                    //proxyURL: ""https://demos.telerik.com/kendo-ui/service/export""
                },
            title: {
                text: $(""#PatientName"").text()
                //text: ""Mehran daneshfar""
            },
            legend: {
                visible: true,
                position: ""bottom""
            },
            seriesDefaults: {
                type: ""line"",
                //labels: {
                //    visible: true,
                //    format: ""{0}"",
                //    background: ""transparent""
                //},
                style: ""smooth""
            },
            //series: [{
            //    ");
            WriteLiteral(@"field: ""value"",
            //    categoryField: ""year"",
            //    name: ""United States""
            //},{
            //    field: ""value"",
            //    categoryField: ""year"",
            //    name: ""United States""
            //}

            //],
            valueAxis: {
                labels: {
                    format: ""{0}""
                },
                line: {
                    visible: true
                }
            },
            categoryAxis: {
                categories: category
            },
            tooltip: {
                visible: true,
                format: ""{0}"",
                //template: ""#= category # \n #= value #""
                template: ""#= category #""
            }
        });
    }










    $(document).ready(function () {


        //let patientid = $(""#ChartModal-body"").attr(""data-id"");
        //$.ajax({

        //    url: '/Patient/GetAllPatientVariableValues',

        //    type: ""Post"",");
            WriteLiteral("\n\r\n        //    data: { patientId: patientid },\r\n\r\n        //    success: function (variableLists) {\r\n        //        Values = variableLists;\r\n        //        createChart();\r\n        //    }\r\n\r\n\r\n        //});\r\n\r\n\r\n\r\n         Values = ");
#nullable restore
#line 156 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml"
             Write(Html.Raw(Json.Serialize(@Model.AllValues)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n         category = ");
#nullable restore
#line 157 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\Patient\mdPatientVariablesChartModal.cshtml"
               Write(Html.Raw(Json.Serialize(@Model.Category)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";


        createChart();
        refreshChart();
    })




    function refreshChart() {






        var chart = $(""#chart"").data(""kendoChart"");


        var checkboxes = $("".kendoChartCheckbox:checked"");
        var checkedValues = [];


        for (let i = 0; i < checkboxes.length; i++) {
            checkedValues.push($(checkboxes[i]).attr('data-name'));
        }


        var chartOptions = chart.options;

        chartOptions.series = [];
        chartOptions.valueAxis = [];

        //chart.setOptions({ categoryAxis: { categories: [0,1,2, 3, 4, 5] } });
        //chartOptions.categoryAxis({ categories: [2, 3, 4, 5] });


        //add series
        //chartOptions.series.type = ""line"";
        for (let i = 0; i < Values.length; i++) {

            if (Values[i].length !== 0) {
                let na = Values[i][0].Name;

                if (checkedValues.find(e => e === na)) {

                    var chartValue = [];

                    for (let");
            WriteLiteral(@" j = 0; j < Values[i].length; j++) {

                        chartValue.push(Values[i][j].Value);

                    }

                    //chartOptions.series.push({name: Values[i][0].Name, type: ""line"", data: Values[i], field: ""Value"", categoryField: ""Date""});
                    let randomColor = ""#""+ Math.floor(Math.random()*16777215).toString(16);
                    chartOptions.series.push({ name: Values[i][0].Name, type: ""line"", data: chartValue, axis: Values[i][0].Name, color: randomColor, labels: { visible: true, template: ""#: value #""+Values[i][0].Unit }});
                    //let color = chartOptions.series[i].color;
                    chartOptions.valueAxis.push({ name: Values[i][0].Name, min:0, max: Math.max(...chartValue) + 5 , color: randomColor, labels: { format: ""{0}""+Values[i][0].Unit} });
                }
            }



            //chartOptions.series[i].field = ""Value"";
            //chartOptions.series[i].categoryField = ""Year"";
            //chartOptions.s");
            WriteLiteral(@"eries[i].name = Values[i][0].Name;


        }




        //chartOptions.series.push({});
        //....

        //add data to particular series
        //chartOptions.series[3].data = [//....]
        //....

        //recreate the chart
        chart.refresh();


    }



    $("".export-pdf"").click(function () {
            $(""#chart"").getKendoChart().saveAsPDF();
        });



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.Chart.ChartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
