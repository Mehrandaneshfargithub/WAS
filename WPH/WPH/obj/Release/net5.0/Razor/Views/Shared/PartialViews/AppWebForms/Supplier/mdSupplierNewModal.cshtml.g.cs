#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8cf542153b5a8799b4a551b911287dfef08508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Supplier.Views_Shared_PartialViews_AppWebForms_Supplier_mdSupplierNewModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Supplier/mdSupplierNewModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Supplier
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8cf542153b5a8799b4a551b911287dfef08508", @"/Views/Shared/PartialViews/AppWebForms/Supplier/mdSupplierNewModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Supplier_mdSupplierNewModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.Supplier.SupplierViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addNewSupplierForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<style>\r\n\r\n    .k-nodata{\r\n        height: 1px !important;\r\n    }\r\n\r\n</style>\r\n\r\n<div id=\"signup-box\" class=\"signup-box no-border\">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b8cf542153b5a8799b4a551b911287dfef085084271", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 19 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
               Write(Html.HiddenFor(m => m.Guid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
               Write(Html.HiddenFor(m => m.NameHolder));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"block clearfix\">\r\n                        <span class=\"red fa fa-asterisk smaller-60 redStar\"></span><label for=\"form-field-8\">");
#nullable restore
#line 23 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                                                                                        Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 25 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
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
#line 32 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Name-Exist\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 35 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                       Write(Localizer["TheNameIsDuplicatedPleaseTryAnotherName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 40 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                             Write(Localizer["Mobile"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 42 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                    .Name("PhoneNumber")
                                    .Value(Model.PhoneNumber)
                                    .HtmlAttributes(new { style = "width: 100%", @validate_mobile = "Mobile-wrong", maxlength = "11", onkeypress = "return OnlyNumberKey(event)" })
                                );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Mobile-wrong\" class=\"hidden\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 49 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                       Write(Localizer["MobileNotCorrect"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n\r\n                    </label>\r\n\r\n                    \r\n                    <label class=\"block clearfix\">\r\n");
                WriteLiteral("<label for=\"form-field-8\">");
#nullable restore
#line 56 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                                                                                            Write(Localizer["SupplierType"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right \">\r\n");
                WriteLiteral("                            ");
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                        Write(Html.Kendo().AutoComplete()
                            .Name("SupplierTypeName")
                            .DataTextField("Name")
                            //.Events(events => events.Select("OnPatientSelectInEmergencyReception"))
                            .Filter("contains")
                            .HighlightFirst(true)
                            .ClearButton(false)
                            .HtmlAttributes(new { style = "width:100%;"/*, @data_checkEmpty = "Supplier-box" */})
                            .DataSource(source =>
                            {
                                source.Read(read =>
                                {
                                    read.Action("GetAllBaseInfosByBaseInfoTypeName", "BaseInfo",new { TypeName = "SupplierType" });
                                })
                                .ServerFiltering(false);
                            })
                            .Value(Model.SupplierTypeName)
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </span>\r\n                        <span id=\"Supplier-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 80 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n\r\n                    </label>\r\n\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 87 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                             Write(Localizer["Country"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right \">\r\n\r\n                            ");
#nullable restore
#line 90 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                        Write(Html.Kendo().AutoComplete()
                            .Name("CountryName")
                            .DataTextField("Name")
                            //.Events(events => events.Select("OnPatientSelectInEmergencyReception"))
                            .Filter("contains")
                            .HighlightFirst(true)
                            .ClearButton(false)
                            .HtmlAttributes(new { style = "width:100%;" })
                            .DataSource(source =>
                            {
                                source.Read(read =>
                                {
                                read.Action("GetAllBaseInfosByBaseInfoTypeName", "BaseInfo", new { TypeName = "Country" });
                            })
                                .ServerFiltering(false);
                            })
                            .Value(Model.CountryName)
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </span>\r\n\r\n\r\n                    </label>\r\n\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 116 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                             Write(Localizer["City"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right \">\r\n\r\n                            ");
#nullable restore
#line 119 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                        Write(Html.Kendo().AutoComplete()
                            .Name("CityName")
                            .DataTextField("Name")
                            //.Events(events => events.Select("OnPatientSelectInEmergencyReception"))
                            .Filter("contains")
                            .HighlightFirst(true)
                            .ClearButton(false)
                            .HtmlAttributes(new { style = "width:100%;"})
                            .DataSource(source =>
                            {
                                source.Read(read =>
                                {
                                    read.Action("GetAllBaseInfosByBaseInfoTypeName", "BaseInfo", new { TypeName = "City" });
                                })
                                .ServerFiltering(false);
                            })
                            .Value(Model.CityName)
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </span>\r\n\r\n\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 144 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                             Write(Localizer["Address"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 146 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                            .Name("Address")
                            .Value(Model.Address)
                            .HtmlAttributes(new { style = "width: 100%",id= "Address1" })
                                );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 155 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                                             Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 157 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Supplier\mdSupplierNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                            .Name("Description")
                            .Value(Model.Description)
                            .HtmlAttributes(new { style = "width: 100%", id = "Description1" })
                                );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <div class=\"space-24\"></div>\r\n                </fieldset>\r\n            ");
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
            $('#PhoneNumber').focus();
        }
    });

    $('#PhoneNumber').on('keypress', function (e) {

        if (e.which === 13) {
            e.preventDefault();
            $('#SupplierTypeName').data(""kendoAutoComplete"").focus();
        }
    });

    $('#SupplierTypeName').on('keypress', function (e) {

        if (e.which === 13) {
            $('#CountryName').data(""kendoAutoComplete"").focus();
        }
    });

    $('#CountryName').on('keypress', function (e) {

   ");
            WriteLiteral(@"     if (e.which === 13) {
            $('#CityName').data(""kendoAutoComplete"").focus();
        }
    });

    $('#CityName').on('keypress', function (e) {

        if (e.which === 13) {
            $('#Address1').focus();
        }
    });

    $('#Address1').on('keypress', function (e) {

        if (e.which === 13) {
            $('#Description1').focus();
        }
    });

    $(""#SupplierTypeName"").on('focus', function (e) {
        
        let inputAuto = $(""#SupplierTypeName"").data(""kendoAutoComplete"");
        let value = inputAuto.value();
        inputAuto.search(value);
    });

    $(""#CountryName"").on('focus', function (e) {

        let inputAuto = $(""#CountryName"").data(""kendoAutoComplete"");
        let value = inputAuto.value();
        inputAuto.search(value);
    });

    $(""#CityName"").on('focus', function (e) {

        let inputAuto = $(""#CityName"").data(""kendoAutoComplete"");
        let value = inputAuto.value();
        inputAuto.search(value);
 ");
            WriteLiteral("   });\r\n\r\n    $(\'#Description1\').on(\'keypress\', function (e) {\r\n\r\n        if (e.which === 13) {\r\n\r\n            $(\'#btn-addSupplier-accept\').focus();\r\n        }\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.Supplier.SupplierViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
