#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d5a9b332d473383d905cbec1454a369d9d11ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.UserHandler.Views_Shared_PartialViews_AppWebForms_UserHandler_RegisterUser), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/UserHandler/RegisterUser.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.UserHandler
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d5a9b332d473383d905cbec1454a369d9d11ca", @"/Views/Shared/PartialViews/AppWebForms/UserHandler/RegisterUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_UserHandler_RegisterUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.UserManagment.UserInformationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registerUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div id=\"signup-box\" class=\"signup-box no-border\">\r\n    <div class=\"widget-body\">\r\n        <div class=\"widget-main\">\r\n            <h4 class=\"header green lighter bigger\">\r\n                <i class=\"ace-icon fa fa-users blue\"></i>\r\n                ");
#nullable restore
#line 10 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
           Write(ViewBag.NewUserRegisteration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h4>\r\n\r\n            <div class=\"space-6\"></div>\r\n            <p> ");
#nullable restore
#line 14 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
           Write(ViewBag.EnterYourDetailsToBegin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </p>\r\n\r\n            \r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d5a9b332d473383d905cbec1454a369d9d11ca4760", async() => {
                WriteLiteral("\r\n                <fieldset>\r\n                    <label class=\"block clearfix\">\r\n                        \r\n                        <span class=\"block input-icon input-icon-right\">\r\n\r\n");
                WriteLiteral(@"                            <i class=""ace-icon fa fa-user""></i>
                            
                        </span>
                        
                        <span id=""FName-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                        
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">

");
                WriteLiteral(@"                            <i class=""ace-icon fa fa-user""></i>
                        </span>
                        <span id=""LName-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">

                            ");
#nullable restore
#line 49 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                       Write(Html.TextBoxFor(m => m.PhoneNumber, new { @id = "PhoneNumber", @class = "form-control", @placeholder = @ViewBag.PhoneNumber, @onkeypress="return OnlyNumberKey(event)" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-globe""></i>
                        </span>
                        <span id=""PhoneNumber-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">

                            ");
#nullable restore
#line 60 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Facebook, new { @id = "Facebook", @class = "form-control", @placeholder = @ViewBag.FaceBook }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-eye""></i>
                        </span>
                        <span id=""Facebook-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">
                            
                            ");
#nullable restore
#line 71 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @id = "Email", @class = "form-control", @placeholder = @ViewBag.Email }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-envelope""></i>
                        </span>
                        <span id=""Email-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">
                            ");
#nullable restore
#line 81 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Name, new { @id = "Name", @class = "form-control", @placeholder = @ViewBag.UserName }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-user""></i>
                            
                        </span>
                        <span id=""loaderuser"" class=""loader-user-exist hidden""></span>
                        <span id=""Name-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                        <span id=""userAlreadyExist"" class=""emptybox hidden"" style=""color:red;"">
                            This user is already exist
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">
                            ");
#nullable restore
#line 96 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                       Write(Html.PasswordFor(m => m.Pass3, new { @id = "Pass3", @class = "form-control", @placeholder = @ViewBag.Password }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-lock""></i>
                        </span>
                        <span id=""Pass3-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                    </label>

                    <label class=""block clearfix"">
                        <span class=""block input-icon input-icon-right"">
                            ");
#nullable restore
#line 106 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                       Write(Html.PasswordFor(m => m.Pass4, new { @id = "Pass4", @class = "form-control", @placeholder = @ViewBag.Password }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <i class=""ace-icon fa fa-retweet""></i>
                        </span>
                        <span id=""Pass4-box"" class=""emptybox hidden"" style=""color:red;"">
                            This field is empty, please fill it with proper information
                        </span>
                        <span id=""incorrectPass"" class=""emptybox hidden"" style=""color:red;"">
                            Passwords didn't match , please try again 
                        </span>
                    </label>

                    <div class=""space-24""></div>

                    <div class=""clearfix"">
                        <button type=""reset"" class=""width-30 pull-left btn btn-sm"">
                            <i class=""ace-icon fa fa-refresh""></i>
                            <span class=""bigger-110"">");
#nullable restore
#line 122 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                                                Write(ViewBag.Reset);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </button>\r\n\r\n                        <button type=\"button\" id=\"RegisterUserFunc\" class=\"width-65 pull-right btn btn-sm btn-success\">\r\n                            <span class=\"bigger-110\">");
#nullable restore
#line 126 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
                                                Write(ViewBag.Register);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                            <i class=\"ace-icon fa fa-arrow-right icon-on-right\"></i>\r\n                        </button>\r\n                    </div>\r\n                </fieldset>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"toolbar center\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 7004, "\"", 7011, 0);
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#login-box\" class=\"back-to-login-link\">\r\n                <i class=\"ace-icon fa fa-arrow-left\"></i>\r\n                ");
#nullable restore
#line 137 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\UserHandler\RegisterUser.cshtml"
           Write(ViewBag.BackToMain);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </a>
        </div>
    </div><!-- /.widget-body -->
</div><!-- /.signup-box -->


<div id=""my-modal"" class=""modal fade"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3 class=""smaller lighter blue no-margin"">Registeration Failed</h3>
            </div>

            <div class=""modal-body"">
                <span  style=""color:red;"">
                    This User could not be registered for some reason, please try again later
                </span>
            </div>

            <div class=""modal-footer"">
                <button class=""btn btn-sm btn-danger pull-right"" data-dismiss=""modal"">
                    <i class=""ace-icon fa fa-times""></i>
                    Close
                </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /");
            WriteLiteral(".modal-dialog -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.UserManagment.UserInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
