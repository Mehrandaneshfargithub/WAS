#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d0f1be6c8cc60fb279071ca7dba2a2833177f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.UserManagment.Views_Shared_PartialViews_AppWebForms_UserManagment_mdEditCurrentUserModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/UserManagment/mdEditCurrentUserModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.UserManagment
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
#line 2 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d0f1be6c8cc60fb279071ca7dba2a2833177f7", @"/Views/Shared/PartialViews/AppWebForms/UserManagment/mdEditCurrentUserModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_UserManagment_mdEditCurrentUserModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.UserManagment.UserInformationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditCurrentUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d0f1be6c8cc60fb279071ca7dba2a2833177f74618", async() => {
                WriteLiteral("\r\n\r\n                <fieldset>\r\n\r\n                    ");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
               Write(Html.HiddenFor(x => x.Guid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
               Write(Html.HiddenFor(x => x.UserNameHolder));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 20 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                                             Write(Localizer["UserName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("UserName")
                                .Value(Model.UserName)
                                .HtmlAttributes(new { style = "width: 100%", @data_checkEmpty = "UserName-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"UserName-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 29 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </span>
                        <span id=""UserName-Exist"" class=""emptybox hidden"" style=""color:red;"">
                            TheNameIsDuplicatedPleaseTryAnotherName
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <label for=""form-field-8"">");
#nullable restore
#line 37 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                                             Write(Localizer["OldPass"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 39 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("Pass2")
                                .HtmlAttributes(new { style = "width: 100%", type = "password", @data_checkEmpty = "Pass2-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Pass2-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 45 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </span>
                        <span id=""incorrectPass2"" class=""emptybox hidden"" style=""color:red;"">
                            Old Pass Not Correct
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <label for=""form-field-8"">");
#nullable restore
#line 53 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                                             Write(Localizer["Password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 55 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("Pass3")
                                .HtmlAttributes(new { style = "width: 100%", type = "password", @data_checkEmpty = "Pass3-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Pass3-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 61 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </label>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <label for=\"form-field-8\">");
#nullable restore
#line 66 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                                             Write(Localizer["RepeatPassword"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </label>\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 68 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                        Write(Html.Kendo().TextBox()
                                .Name("Pass4")
                                .HtmlAttributes(new { style = "width: 100%", type = "password", @data_checkEmpty = "Pass4-box" })
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                        <span id=\"Pass4-box\" class=\"emptybox hidden\" data-isEssential=\"true\" style=\"color:red;\">\r\n                            ");
#nullable restore
#line 74 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdEditCurrentUserModal.cshtml"
                       Write(Localizer["ThisFieldIsEmptyPleaseFillIt"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </span>
                        <span id=""incorrectPass"" class=""emptybox hidden"" style=""color:red;"">
                            Passwords didn't match , please try again
                        </span>
                    </label>

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script type=""text/javascript"">

    $(document).ready(function () {
        $(""#Pass2"").attr('readonly', true);
        $(""#Pass3"").attr('readonly', true);
        $(""#Pass4"").attr('readonly', true);
        setTimeout(function () {

            $(""#Pass2"").removeAttr('readonly');
            $(""#Pass3"").removeAttr('readonly');
            $(""#Pass4"").removeAttr('readonly');
            $('#UserName').select();
            //$(""#Pass2"").attr('readonly', false);
        }, 500);

    });

    $('#UserName').focus(function () {
        $(""#UserName-Exist"").addClass('hidden');
        $(""#UserName-box"").addClass('hidden');
    });

    $('#UserName').on('keypress', function (e) {
        if (e.which === 13) {
            $('#Pass2').select();
        }
    });

    $('#Pass2').on('keypress', function (e) {
        if (e.which === 13) {
            $('#Pass3').select();
        }
    });

    $('#Pass3').on('keypress', function (e) {
    ");
            WriteLiteral(@"    if (e.which === 13) {
            $('#Pass4').select();
        }
    });

    $('#Pass4').on('keypress', function (e) {
        if (e.which === 13) {
            $('#btn-EditCurrentUserModal-accept').focus();
        }
    });
   

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.UserManagment.UserInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
