#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79cac6a8cdb567f0f2f69946b2edb68a9fbe342a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Reminder.Views_Shared_PartialViews_AppWebForms_Reminder_mdReminderNewModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Reminder/mdReminderNewModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.Reminder
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79cac6a8cdb567f0f2f69946b2edb68a9fbe342a", @"/Views/Shared/PartialViews/AppWebForms/Reminder/mdReminderNewModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Reminder_mdReminderNewModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.Reminder.ReminderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addNewReminderForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79cac6a8cdb567f0f2f69946b2edb68a9fbe342a4174", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 11 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
               Write(Html.HiddenFor(m => m.Guid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                                             Write(Localizer["Explanation"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n\r\n                            ");
#nullable restore
#line 18 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                        Write(Html.Kendo().TextArea()
                                    .Name("Explanation")
                                    .Value(Model.Explanation)
                                    .Rows(3)
                                    .HtmlAttributes(new { style = "width: 100%", @data_checkEmpty = "Exp-box" })
                                    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </span>\r\n                        <span id=\"Exp-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 27 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 33 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                                             Write(Localizer["ReminderDate"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 35 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                        Write(Html.Kendo().DatePicker()
                                    .Name("TxtReminderDate")
                                    .Value(Model.ReminderDate ?? DateTime.Now)
                                    .Format("dd/MM/yyyy")
                                    .HtmlAttributes(new { style = "width: 100%;", @data_checkEmpty = "Date-box" })
                                    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Date-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 43 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n\r\n                        <span id=\"Date-valid\" class=\"emptybox hidden\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 47 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\mdReminderNewModal.cshtml"
                       Write(Localizer["DateNotValid"]);

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


        //setTimeout(function () {
        //    $(""#Name"").focus();
        //}, 200);

    });


    //$('#Name').focus(function () {
    //    $(""#Name-Exist"").addClass('hidden');
    //    $(""#Name-box"").addClass('hidden');
    //    $(""#Name"").select();
    //});

    //$('#Name').on('keypress', function (e) {

    //    if (e.which === 13) {
    //        $('#ReminderTypeName').data(""kendoAutoComplete"").focus();
    //    }
    //});



   
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.Reminder.ReminderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
