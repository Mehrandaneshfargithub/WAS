#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\SectionManagement\mdSubsystemsAccessModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd17abe1a2338ac952c54d2029adac1e7e5472f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.SectionManagement.Areas_Admin_Views_Shared_PartialViews_AppWebForms_SectionManagement_mdSubsystemsAccessModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/SectionManagement/mdSubsystemsAccessModal.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.SectionManagement
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
#line 1 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17abe1a2338ac952c54d2029adac1e7e5472f5", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/SectionManagement/mdSubsystemsAccessModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialViews_AppWebForms_SectionManagement_mdSubsystemsAccessModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<style>\r\n\r\n    #SubsystemSectionContainer li,\r\n    #SubsystemAccessContainer li {\r\n        list-style: none;\r\n        padding-bottom: 1em;\r\n    }\r\n</style>\r\n\r\n<input type=\"hidden\" id=\"SubSystemId\"");
            BeginWriteAttribute("value", " value=\"", 265, "\"", 279, 1);
#nullable restore
#line 14 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\SectionManagement\mdSubsystemsAccessModal.cshtml"
WriteAttributeValue("", 273, Model, 273, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<div style=\" overflow: hidden;\">\r\n\r\n    <div class=\"col-sm-12\">\r\n\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"modal-header\">\r\n                <h2 class=\"smaller lighter no-margin \">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\SectionManagement\mdSubsystemsAccessModal.cshtml"
               Write(Localizer["Section"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>
            <div style=""padding: 15px 0px;"">
                <ul id=""SubsystemSectionContainer"">
                </ul>
            </div>
        </div>

        <div class=""col-sm-6"">
            <div class=""modal-header"">
                <h2 class=""smaller lighter no-margin "">
                    ");
#nullable restore
#line 35 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\SectionManagement\mdSubsystemsAccessModal.cshtml"
               Write(Localizer["Access"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>
            <div style=""padding: 15px 0px;"">
                <ul id=""SubsystemAccessContainer"">
                </ul>
            </div>
        </div>

    </div>

</div>

<script>

    $(document).ready(function () {

        $.ajax({
            type: ""Get"",
            url: ""/Admin/BaseInfoType/GetSubsystemSectioType?subSystemId=");
#nullable restore
#line 54 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\SectionManagement\mdSubsystemsAccessModal.cshtml"
                                                                    Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            success: function (response) {
                var elements = '';

                for (var i = 0; i < response.length; i++) {

                    if (response[i].Checked) {
                        elements +=
                            `<li>
                                <input id=""ch${i}"" type=""checkbox"" checked=""checked"" data-id=""${response[i].SectionTypeId}"" class=""sectionChValue""/>
                                <label for=""ch${i}"">${response[i].SectionTypeName}</label>
                            </li>`;

                    } else {
                        elements +=
                            `<li>
                                <input id=""ch${i}"" type=""checkbox"" data-id=""${response[i].SectionTypeId}"" class=""sectionChValue""/>
                                <label for=""ch${i}"">${response[i].SectionTypeName}</label>
                            </li>`;

                    }

                }

                var ul = document.getElementById(""SubsystemSect");
            WriteLiteral("ionContainer\");\r\n                ul.insertAdjacentHTML(\'afterbegin\', elements);\r\n\r\n            }\r\n        });\r\n\r\n        $.ajax({\r\n            type: \"Get\",\r\n            url: \"/Admin/SectionManagement/GetSubsystemAccess?subSystemId=");
#nullable restore
#line 86 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\SectionManagement\mdSubsystemsAccessModal.cshtml"
                                                                     Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            success: function (response) {
                var elements = '';

                for (var i = 0; i < response.length; i++) {

                    if (response[i].Checked) {
                        elements +=
                            `<li>
                                <input id=""ch${i}"" type=""checkbox"" checked=""checked"" data-id=""${response[i].AccessId}"" class=""accessChValue""/>
                                <label for=""ch${i}"">${response[i].AccessName}</label>
                            </li>`;

                    } else {
                        elements +=
                            `<li>
                                <input id=""ch${i}"" type=""checkbox"" data-id=""${response[i].AccessId}"" class=""accessChValue""/>
                                <label for=""ch${i}"">${response[i].AccessName}</label>
                            </li>`;

                    }

                }

                var ul = document.getElementById(""SubsystemAccessContainer"");
      ");
            WriteLiteral("          ul.insertAdjacentHTML(\'afterbegin\', elements);\r\n\r\n            }\r\n        });\r\n\r\n    });\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public WPH.Resources.SharedViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
