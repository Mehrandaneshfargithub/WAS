#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e094b7dbfa495989be7a036758cd4c1c2f0305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.UserManagment.Views_Shared_PartialViews_AppWebForms_UserManagment_mdAdminLoginModal), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/UserManagment/mdAdminLoginModal.cshtml")]
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
#line 3 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e094b7dbfa495989be7a036758cd4c1c2f0305", @"/Views/Shared/PartialViews/AppWebForms/UserManagment/mdAdminLoginModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_UserManagment_mdAdminLoginModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.UserManagment.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("adminLoginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div id=""login-box"" class=""login-box visible widget-box no-border"">
    <div class=""widget-body"">
        <div class=""widget-main"">
            <h4 class=""header blue lighter bigger"">
                <i class=""ace-icon fa fa-coffee green""></i>
                ");
#nullable restore
#line 12 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
           Write(Localizer["plsEnterYourInformation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h4>\r\n\r\n            <div id=\"loginError\" class=\"hidden\">\r\n                <span id=\"loginErrorText\" class=\"text-danger\">");
#nullable restore
#line 16 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                                                         Write(Localizer["ErrorInLogin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div id=\"accessError\" class=\"hidden\">\r\n                <span class=\"text-danger\">");
#nullable restore
#line 20 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                                     Write(Localizer["AccessDenied"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            \r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"hidden\">\r\n                <span class=\"text-danger\">");
#nullable restore
#line 24 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                                     Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"space-6\"></div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49e094b7dbfa495989be7a036758cd4c1c2f03056285", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <fieldset>\r\n\r\n                    <label class=\"block clearfix\">\r\n                        <span class=\"block input-icon input-icon-right\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                       Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control", @lang = "en", @placeholder = @Localizer["Username"] }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-user""></i>
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">
                            ");
#nullable restore
#line 41 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                       Write(Html.PasswordFor(m => m.Pass3, new { @class = "form-control", @lang = "en", @placeholder = @Localizer["Password"] }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-lock""></i>
                        </span>
                    </label>

                    <div class=""space""></div>
                    <div class=""clearfix"">

                        <button id=""adminLoginUserFunc"" type=""button""");
                BeginWriteAttribute("class", " class=\"", 2160, "\"", 2365, 6);
                WriteAttributeValue("", 2168, "pull-right", 2168, 10, true);
                WriteAttributeValue(" ", 2178, "btn", 2179, 4, true);
                WriteAttributeValue(" ", 2182, "btn-xs", 2183, 7, true);
                WriteAttributeValue(" ", 2189, "btn-primary", 2190, 12, true);
                WriteAttributeValue(" ", 2201, "radius-4", 2202, 9, true);
                WriteAttributeValue(" ", 2210, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 49 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                                                                                                                         if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en") {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    WriteLiteral("pull-left\r\n");
#nullable restore
#line 51 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                              }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 2211, 154, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i class=\"ace-icon fa fa-key\"></i>\r\n                            <span class=\"bigger-110\">");
#nullable restore
#line 53 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserManagment\mdAdminLoginModal.cshtml"
                                                Write(Localizer["Login"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </button>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"space-4\"></div>\r\n                </fieldset>\r\n            ");
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

    </div>
</div>



<style>

    .chooseLang:hover {
        cursor: pointer
    }
</style>

<script>

    $('#adminLoginUserFunc').on(""click"", function () {
        $(this).attr(""disabled"", true);
        
        var data = $(""#adminLoginForm"").serialize();

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: ""/UserManagment/AdminLogin"",
            data: data,
            success: function (response) {
                $('#adminLoginUserFunc').removeAttr(""disabled"");
                
                if (response === ""AccessDenied"") {

                    $('#AdminLoginModal #accessError').removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                } else if (response == true) {

                    window.location.href = ""/Admin/SectionManagement/Index"";
                    $("".loader"").fadeIn(""slow"");

              ");
            WriteLiteral(@"  } else if (response == 0) {

                    $('#AdminLoginModal #ERROR_SomeThingWentWrong').removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else {

                    $('#AdminLoginModal #loginError').removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.UserManagment.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
