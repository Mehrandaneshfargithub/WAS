#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84e35c06cd0e9da99d4277be0a5165a6d85c08ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Ambulance.Views_Shared_PartialViews_AppWebForms_Ambulance_mdAmbulanceNewModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Ambulance/mdAmbulanceNewModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Ambulance
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84e35c06cd0e9da99d4277be0a5165a6d85c08ec", @"/Views/Shared/PartialViews/AppWebForms/Ambulance/mdAmbulanceNewModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Ambulance_mdAmbulanceNewModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.Ambulance.AmbulanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addNewAmbulanceForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div id=\"signup-box\" class=\"signup-box no-border\">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84e35c06cd0e9da99d4277be0a5165a6d85c08ec4287", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 11 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
               Write(Html.HiddenFor(m => m.Guid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
               Write(Html.HiddenFor(m => m.NameHolder));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 15 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                                             Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 17 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("Name")
                                .Value(Model.Name)
                                .HtmlAttributes(new { style = "width: 100%", @data_checkEmpty = "Name-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Name-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Name-Exist\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                       Write(Localizer["TheNameIsDuplicatedPleaseTryAnotherName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 32 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                                             Write(Localizer["Code"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("Code")
                                .Value(Model.Code)
                                .HtmlAttributes(new { style = "width: 100%" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 43 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                                             Write(Localizer["Hospital"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <span class=\"block input-icon input-icon-right \">\r\n\r\n                            ");
#nullable restore
#line 46 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                        Write(Html.Kendo().AutoComplete()
                            .Name("HospitalName")
                            .DataTextField("Name")
                            //.Events(events => events.Select("OnPatientSelectInEmergencyReception"))
                            .Filter("contains")
                            .HighlightFirst(true)
                            .ClearButton(false)
                            .HtmlAttributes(new { style = "width:100%;", @data_checkEmpty = "Hospital-box" })
                            .DataSource(source =>
                            {
                                source.Read(read =>
                                {
                                    read.Action("GetAllHospitals", "Hospital");
                                })
                                .ServerFiltering(false);
                            })
                            .Value(Model.HospitalName)
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </span>\r\n                        <span id=\"Hospital-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 67 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Ambulance\mdAmbulanceNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n\r\n                    </label>\r\n\r\n                    <div class=\"space-24\"></div>\r\n                </fieldset>\r\n            ");
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
            WriteLiteral(@"
        </div>
    </div><!-- /.widget-body -->
</div><!-- /.signup-box -->

<script>

    $(document).ready(function () {
        setTimeout(function () {
            $(""#Name"").focus();
        }, 200);

    });


    $('#Name').focus(function () {
        $(""#Name-Exist"").addClass('hidden');
        $(""#Name-box"").addClass('hidden');
        $(""#Name"").select();
    });

    $('#Name').on('keypress', function (e) {

        if (e.which === 13) {
            e.preventDefault();
            $('#Code').focus();
        }
    });

    $('#Code').on('keypress', function (e) {

        if (e.which === 13) {
            $('#HospitalName').data(""kendoAutoComplete"").focus();
        }
    });

    $(""#HospitalName"").on('focus', function (e) {

        let inputAuto = $(""#HospitalName"").data(""kendoAutoComplete"");
        let value = inputAuto.value();
        inputAuto.search(value);
    });

    $('#HospitalName').on('keypress', function (e) {

        if (e.which === 1");
            WriteLiteral("3) {\r\n\r\n            $(\'#btn-addAmbulance-accept\').focus();\r\n        }\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.Ambulance.AmbulanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
