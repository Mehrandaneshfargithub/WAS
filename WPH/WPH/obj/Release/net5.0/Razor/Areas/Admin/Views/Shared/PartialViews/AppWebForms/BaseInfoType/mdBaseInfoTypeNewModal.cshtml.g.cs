#pragma checksum "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76903016aab5d396eb0848567ea9e16a9d15b42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.BaseInfoType.Areas_Admin_Views_Shared_PartialViews_AppWebForms_BaseInfoType_mdBaseInfoTypeNewModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/mdBaseInfoTypeNewModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.BaseInfoType
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
#line 1 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76903016aab5d396eb0848567ea9e16a9d15b42e", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/mdBaseInfoTypeNewModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialViews_AppWebForms_BaseInfoType_mdBaseInfoTypeNewModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Areas.Admin.Models.BaseInfoType.BaseInfoTypeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addNewBaseInfoTypeForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76903016aab5d396eb0848567ea9e16a9d15b42e4362", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 11 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
               Write(Html.HiddenFor(m => m.Guid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                                             Write(Localizer["Ename"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 17 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("EName")
                                .Value(Model.Ename)
                                .HtmlAttributes(new { style = "width: 100%", @data_checkEmpty = "EName-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"EName-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 24 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Name-Exist\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 27 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                       Write(Localizer["TheNameIsDuplicatedPleaseTryAnotherName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 32 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                                             Write(Localizer["Fname"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 34 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("FName")
                                .Value(Model.Fname)
                                .HtmlAttributes(new { style = "width: 100%", @data_checkEmpty = "FName-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"FName-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 41 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\mdBaseInfoTypeNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n\r\n                    </label>\r\n\r\n\r\n\r\n                    <div class=\"space-24\"></div>\r\n                </fieldset>\r\n            ");
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
            $(""#EName"").focus();
        }, 200);
    });

    $('#EName').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {
            $('#FName').focus();
        }
    })
    
    $('#FName').keypress(function (e) {

        if (e.which === 13 || e.which === 9) {

            $('#btn-BaseInfoTypeModal-accept').focus();
        }
    })


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Areas.Admin.Models.BaseInfoType.BaseInfoTypeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
