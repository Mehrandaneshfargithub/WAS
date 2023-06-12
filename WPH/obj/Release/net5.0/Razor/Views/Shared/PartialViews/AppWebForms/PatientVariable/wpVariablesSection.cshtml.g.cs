#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\PatientVariable\wpVariablesSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2e683f29379e8c19f3396b3a8cc4041f9240cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.PatientVariable.Views_Shared_PartialViews_AppWebForms_PatientVariable_wpVariablesSection), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/PatientVariable/wpVariablesSection.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.PatientVariable
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2e683f29379e8c19f3396b3a8cc4041f9240cf", @"/Views/Shared/PartialViews/AppWebForms/PatientVariable/wpVariablesSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_PatientVariable_wpVariablesSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-sm-12 hidden MyFont-Roboto-grid"" id=""variables"" style=""display:flex;flex-wrap:wrap;margin-top: 1rem;direction:ltr"">


</div>


<script>

    $(document).ready(() => {


        


    })


    function onVariablechange(element) {

        let id = $(element).attr('data-id');
        let ValGuid = $(element).attr('data-valueGuid');
        let status = $(element).attr('data-status');
        let receptionId = $(""#Guid"").val();
        let patientId = $(""#PatientId"").val();
        let value = $(element).val();
        if ($(element).hasClass('checkBoxVariable')) {
            value = $(element).is(':checked');
        }


        if (ValGuid != """") {
            $.ajax({

                type: ""Post"",
                data: { VariableValueId: ValGuid, Value: value },
                url: ""/PatientVariable/UpdatePatientVariableValue"",

            })
        }



    }

    function createVariables() {
        let patientId = $(""#PatientId"").val();");
            WriteLiteral("\r\n        let receptionId = $(\"#Guid\").val();\r\n        let display = \"");
#nullable restore
#line 51 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\PatientVariable\wpVariablesSection.cshtml"
                  Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

        $.ajax({
            type: ""Post"",
            data: { PatientId: patientId, ReceptionId: receptionId, DisplayType: display },
            url: ""/PatientVariable/GetAllVariablesForPatient"",
            success: function (response) {

                if (response.length > 0) {
                    $(""#variables"").removeClass('hidden');
                }


                for (let i = 0; i < response.length; i++) {

                    let className = """";

                    if (response[i].VariableTypeName === ""Text"" || response[i].VariableTypeName === ""Numerical"") {
                        if (response[i].VariableTypeName === ""Text"")
                            className = ""TextVariable""
                        else {
                            className = ""NumericalVariable""
                        }

                        let val = (response[i].PatientVariablesValues[0] === undefined) ? """" : response[i].PatientVariablesValues[0].Value;
                        let valG");
            WriteLiteral(@"uid = (response[i].PatientVariablesValues[0] === undefined) ? """" : response[i].PatientVariablesValues[0].Guid;

                        $(""#variables"")
                            .append(""<div class='col-sm-6' style='display: flex;padding:0.5rem;margin:0;justify-content: flex-end;align-items: center'><div class='col-sm-4' style='display: flex; margin: 0;justify-content: flex-end;text-align: right'><h3 class='MyFont-Roboto-grid'>"" + response[i].VariableName + "": </h3></div>"" +
                                '<div class=""col-sm-8"" style=""display: flex;padding-right:2rem;padding-left:1.5rem""><input style = ""width: 100%; margin: 0""  class= ""boldText ' + className +
                            '"" data-status=' + response[i].VariableStatusName + ' value=""' + val + '"" onchange = ""onVariablechange(this)""   data-id=""' + response[i].Id + '""  data-valueGuid=""' + valGuid +'"" data-variable=""""/></div> ' +
                                ""</div>"");
                    }
                    else {
                ");
            WriteLiteral(@"        className = ""checkBoxVariable""
                        let val = (response[i].PatientVariablesValues[0] === undefined) ? false : response[i].PatientVariablesValues[0].Value;
                        let valGuid = (response[i].PatientVariablesValues[0] === undefined) ? """" : response[i].PatientVariablesValues[0].Guid;

                        let chk;

                        if (val === false)
                            chk = """";
                        else
                            chk = ""checked""

                        $(""#variables"")
                            .append(""<div class='col-sm-6' style='display: flex;padding:0;margin:0;align-items:center'>"" +
                                '<div class=""col-sm-12"" style=""display: flex;padding:0;margin:0;align-items:flex-start;justify-content: center""><span style=""margin:0 0.5rem"">' + response[i].VariableName +
                                '</span><input  type = ""checkbox""  class= ""boldText ' + className + '"" data-status=' + response");
            WriteLiteral(@"[i].VariableStatusName +
                            ' value=' + true + ' ' + chk + ' onchange = ""onVariablechange(this)""   data-id=""' + response[i].Id + '"" data-valueGuid=""' + valGuid +'"" data-variable=""""/></div> ' +
                                ""</div>"");

                    }

                }


                //let allText = $("".TextVariable"");

                //for (let i = 0; i < allText.length; i++) {

                //    let val = ($(allText[i]).attr('data-value') === undefined) ? """" : $(allText[i]).attr('data-value');

                //    console.log(val);

                //    $(allText[i]).kendoTextBox({
                //        value: val
                //    });
                //}

                $("".TextVariable"").kendoTextBox({
                    value: $(this).attr('data-value')
                });


                $("".NumericalVariable"").kendoNumericTextBox({
                    value: $(this).attr('data-value')
                });


         ");
            WriteLiteral("   }\r\n        });\r\n    }\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
