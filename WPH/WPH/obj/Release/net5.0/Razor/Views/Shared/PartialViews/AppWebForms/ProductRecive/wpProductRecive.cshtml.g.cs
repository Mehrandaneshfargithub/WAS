#pragma checksum "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3452725eaec0f4b2110fdd37568d0e8b52fdabb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.ProductRecive.Views_Shared_PartialViews_AppWebForms_ProductRecive_wpProductRecive), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/ProductRecive/wpProductRecive.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.ProductRecive
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
#line 3 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3452725eaec0f4b2110fdd37568d0e8b52fdabb1", @"/Views/Shared/PartialViews/AppWebForms/ProductRecive/wpProductRecive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_ProductRecive_wpProductRecive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = " ";
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 644, "\"", 657, 1);
#nullable restore
#line 25 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue("", 652, pull, 652, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 672, "\"", 685, 1);
#nullable restore
#line 26 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue("", 680, font, 680, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 27 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
       Write(Localizer["ProductRecive"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n</div><!-- /.page-header -->\r\n\r\n<div id=\"ProductReciveDetailModal\"");
            BeginWriteAttribute("class", " class=\"", 853, "\"", 877, 3);
            WriteAttributeValue("", 861, "modal", 861, 5, true);
            WriteAttributeValue(" ", 866, "fade", 867, 5, true);
#nullable restore
#line 34 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 871, font, 872, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 923, "\"", 941, 1);
#nullable restore
#line 34 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue("", 931, direction, 931, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" style=""width:85%"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeProductReciveDetailModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""ProductReciveDetailModal-header""");
            BeginWriteAttribute("class", " class=\"", 1259, "\"", 1303, 5);
            WriteAttributeValue("", 1267, "smaller", 1267, 7, true);
            WriteAttributeValue(" ", 1274, "lighter", 1275, 8, true);
            WriteAttributeValue(" ", 1282, "blue", 1283, 5, true);
            WriteAttributeValue(" ", 1287, "no-margin", 1288, 10, true);
#nullable restore
#line 39 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 1297, font, 1298, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 40 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ProductReciveDetail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>

            <div id=""ProductReciveDetailModal-body"" class=""modal-body"" style=""margin:5px;"">
            </div>

            <div id=""ProductNotConfirmed"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 49 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
           Write(Localizer["ProductNotConfirmed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 54 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 59 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-productReciveDetail-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right"})
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 64 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-productReciveDetail-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick= "closeProductReciveDetailModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n<div id=\"AddProductReciveDetailModal\"");
            BeginWriteAttribute("class", " class=\"", 2807, "\"", 2831, 3);
            WriteAttributeValue("", 2815, "modal", 2815, 5, true);
            WriteAttributeValue(" ", 2820, "fade", 2821, 5, true);
#nullable restore
#line 73 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 2825, font, 2826, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 2877, "\"", 2895, 1);
#nullable restore
#line 73 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue("", 2885, direction, 2885, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeAddProductReciveDetailModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""AddProductReciveDetailModal-header""");
            BeginWriteAttribute("class", " class=\"", 3201, "\"", 3245, 5);
            WriteAttributeValue("", 3209, "smaller", 3209, 7, true);
            WriteAttributeValue(" ", 3216, "lighter", 3217, 8, true);
            WriteAttributeValue(" ", 3224, "blue", 3225, 5, true);
            WriteAttributeValue(" ", 3229, "no-margin", 3230, 10, true);
#nullable restore
#line 78 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 3239, font, 3240, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 79 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ConfirmProduct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>

            <div id=""AddProductReciveDetailModal-body"" class=""modal-body"" style=""width:60rem"">
            </div>

            <div id=""InvalidProduct"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 88 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
           Write(Localizer["ERROR_InvalidProduct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 93 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 98 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addProductReciveDetail-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right"})
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 102 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addProductReciveDetail-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick= "closeAddProductReciveDetailModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<div id=\"DeleteProductReciveModal\"");
            BeginWriteAttribute("class", " class=\"", 4753, "\"", 4777, 3);
            WriteAttributeValue("", 4761, "modal", 4761, 5, true);
            WriteAttributeValue(" ", 4766, "fade", 4767, 5, true);
#nullable restore
#line 114 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 4771, font, 4772, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 4823, "\"", 4841, 1);
#nullable restore
#line 114 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue("", 4831, direction, 4831, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3");
            BeginWriteAttribute("class", " class=\'", 5114, "\'", 5135, 2);
            WriteAttributeValue("", 5122, "smaller", 5122, 7, true);
#nullable restore
#line 119 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 5129, font, 5130, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'ace-icon fa fa-exclamation-triangle red \'></i>");
#nullable restore
#line 120 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
                                                                       Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"DeleteProductReciveModal-body\" class=\"modal-body\">\r\n                ");
#nullable restore
#line 125 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
           Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div id=\"ERROR_ThisRecordHasDependencyOnItInAnotherEntity\" class=\"red label-white middle hidden\" style=\"height:40px;display:block;margin-top:2rem\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 128 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 132 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 138 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-deleteProductRecive-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 142 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-deleteProductRecive-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", @data_dismiss = "modal" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n<div id=\"DeleteProductReciveDetailModal\"");
            BeginWriteAttribute("class", " class=\"", 6814, "\"", 6838, 3);
            WriteAttributeValue("", 6822, "modal", 6822, 5, true);
            WriteAttributeValue(" ", 6827, "fade", 6828, 5, true);
#nullable restore
#line 151 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 6832, font, 6833, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 6884, "\"", 6902, 1);
#nullable restore
#line 151 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue("", 6892, direction, 6892, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3");
            BeginWriteAttribute("class", " class=\'", 7175, "\'", 7196, 2);
            WriteAttributeValue("", 7183, "smaller", 7183, 7, true);
#nullable restore
#line 156 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 7190, font, 7191, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'ace-icon fa fa-exclamation-triangle red \'></i>");
#nullable restore
#line 157 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
                                                                       Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"DeleteProductReciveDetailModal-body\" class=\"modal-body\">\r\n                ");
#nullable restore
#line 162 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
           Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div id=\"ERROR_ThisRecordHasDependencyOnItInAnotherEntity\" class=\"red label-white middle hidden\" style=\"height:40px;display:block;margin-top:2rem\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 165 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div id=\"ERROR_UsedInOtherTransfer\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 170 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ERROR_ThisRecordUsedInOtherTransfer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div id=\"ERROR_TransferAccepted\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 175 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ERROR_ThisRecordAcceptedInDestination"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 180 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 186 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-deleteProductReciveDetail-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 190 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-deleteProductReciveDetail-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", @data_dismiss = "modal" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n<!-- Grid -->\r\n<div");
            BeginWriteAttribute("class", " class=\"", 9457, "\"", 9487, 3);
            WriteAttributeValue("", 9465, "row", 9465, 3, true);
            WriteAttributeValue(" ", 9468, "Grid-Content", 9469, 13, true);
#nullable restore
#line 201 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
WriteAttributeValue(" ", 9481, font, 9482, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 202 "H:\Projects\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\ProductRecive\wpProductRecive.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/ProductRecive/dgProductReciveGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>


<script>

    var product_list = [];
    $(document).ready(function () {

        GetAllProductList().done(function (data) {

            product_list = data;
        });

    });

    function ConfirmProductRecive(element) {

        $(""#ProductReciveDetailModal #ProductNotConfirmed"").addClass(""hidden"");
        $(""#ProductReciveDetailModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var link = ""/ProductRecive/ConfirmProductReciveModal?Id="";
        var Id = $(element).attr('data-id');


        $('#btn-productReciveDetail-accept').attr('data-id', Id);
        $('#btn-productReciveDetail-close').attr('data-id', Id);

        $("".loader"").removeClass(""hidden"");

        $('#ProductReciveDetailModal').modal('toggle');
        $('#ProductReciveDetailModal-body').load(link + Id, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function ConfirmProductReciveDetail(element) {

    ");
            WriteLiteral(@"    $(""#AddProductReciveDetailModal #InvalidProduct"").addClass(""hidden"");
        $(""#AddProductReciveDetailModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var link = ""/ProductRecive/ConfirmModal?Id="";
        var Id = $(element).attr('data-id');

        $("".loader"").removeClass(""hidden"");

        $('#AddProductReciveDetailModal').modal('toggle');
        $('#AddProductReciveDetailModal-body').load(link + Id, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function ProductReciveDeleteFunction(element) {

        $(""#DeleteProductReciveModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteProductReciveModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#DeleteProductReciveModal').modal('toggle');
        var Id = $(element).attr('data-id');
        $('#btn-deleteProductRecive-accept').attr('data-id'");
            WriteLiteral(@", Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");

    }

    function ProductReciveDetailDeleteFunction(element) {

        $(""#DeleteProductReciveDetailModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteProductReciveDetailModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#DeleteProductReciveDetailModal').modal('toggle');
        var Id = $(element).attr('data-id');
        $('#btn-deleteProductReciveDetail-accept').attr('data-id', Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");

    }



    $('#btn-addProductReciveDetail-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#AddProductReciveDetailModal #InvalidProduct"").addClass(""hidden"");
        $(""#AddProductReciveDetailModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('.emptybox').addClass('hidden');
    ");
            WriteLiteral(@"    var isEmmpty = true;
        $('.emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    $('#btn-addProductReciveDetail-accept').removeAttr(""disabled"");
                    isEmmpty = false;
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }

        var link = ""/ProductRecive/AddProductReceive"";
        var data = $(""#addProductReceiveForm"").serialize();

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                $('#btn-addProductReciveDetail-accept').removeAttr(""disabled"");

                if (response !== 0) {
                   ");
            WriteLiteral(@" if (response === ""InvalidProduct"") {

                        $(""#AddProductReciveDetailModal #InvalidProduct"").removeClass(""hidden"");
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    }  else {

                        $('#AddProductReciveDetailModal').modal('hide');
                        $("".modal-backdrop:last"").remove();
                        $('#AddProductReciveDetailModal-body').empty();
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                        $(""#productReciveDetailKendoGrid .k-pager-refresh"")[0].click();

                    }
                } else {

                    $(""#AddProductReciveDetailModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    });

    functi");
            WriteLiteral(@"on closeAddProductReciveDetailModal() {

        $('#AddProductReciveDetailModal').modal('hide');
        $('#AddProductReciveDetailModal-body').empty();
        $("".modal-backdrop:last"").remove();

    }

    function closeProductReciveDetailModal() {

        var link = ""/ProductRecive/ResetProductReceive"";
        var Id = $(""#btn-productReciveDetail-close"").attr('data-id');

        $.ajax({
            type: ""Get"",
            url: link,
            data: {
                Id: Id
            },
            success: function (response) {

                $('#ProductReciveDetailModal').modal('hide');
                $('#ProductReciveDetailModal-body').empty();
                $("".modal-backdrop:last"").remove();
                $(""#btn-productReciveDetail-close"").attr('data-id','');
            }
        });

    }


    $('#btn-productReciveDetail-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#ProductReciveDetailModal #ProductNotCon");
            WriteLiteral(@"firmed"").addClass(""hidden"");
        $(""#ProductReciveDetailModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var Id = $(this).attr('data-id');
        var link = ""/ProductRecive/ConfirmAllProductRecive"";

        $("".loader"").removeClass(""hidden"");

        $.ajax({
            type: ""Get"",
            url: link,
            data: {
                Id: Id
            },
            success: function (response) {
                $('#btn-productReciveDetail-accept').removeAttr(""disabled"");

                if (response === ""ProductNotConfirmed"") {

                    $(""#ProductReciveDetailModal #ProductNotConfirmed"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === 0) {

                    $(""#ProductReciveDetailModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $(");
            WriteLiteral(@""".loader"").addClass(""hidden"");
                }
                else {

                    $('#ProductReciveDetailModal').modal('hide');
                    $('#ProductReciveDetailModal-body').empty();
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#productReciveKendoGrid .k-pager-refresh"")[0].click();
                }
            }
        });

    });



    $('#btn-deleteProductReciveDetail-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#DeleteProductReciveDetailModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteProductReciveDetailModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");
        $(""#DeleteProductReciveDetailModal #ERROR_UsedInOtherTransfer"").addClass(""hidden"");
        $(""#DeleteProductReciveDetailModal #ERROR_TransferAccepted"").addClass(""hidden"");
");
            WriteLiteral(@"
        var Id = $(this).attr('data-id');
        var link = ""/TransferDetail/Remove"";

        var token = $(':input:hidden[name*=""RequestVerificationToken""]');
        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                Id: Id
            },
            success: function (response) {
                $('#btn-deleteProductReciveDetail-accept').removeAttr(""disabled"");

                if (response === ""SUCCESSFUL"") {
                    $('#DeleteProductReciveDetailModal').modal('hide');
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#productReciveDetailKendoGrid .k-pager-refresh"")[0].click();
                }
                else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {

");
            WriteLiteral(@"                    $(""#DeleteProductReciveDetailModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""TransferInUse"") {

                    $(""#DeleteProductReciveDetailModal #ERROR_UsedInOtherTransfer"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""TransferAccepted"") {

                    $(""#DeleteProductReciveDetailModal #ERROR_TransferAccepted"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""ERROR_SomeThingWentWrong"") {

                    $(""#DeleteProductReciveDetailModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
          ");
            WriteLiteral(@"          $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""AreYouSure"") {
                    AskForDelete(Id);
                }
                else if (response === ""CanNotDelete"") {
                    CanNotDelete();
                } else {
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });

    });


    $('#btn-deleteProductRecive-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#DeleteProductReciveModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteProductReciveModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var Id = $(this).attr('data-id');

        var link = ""/Transfer/Remove"";

        var token = $(':input:hidden[name*=""RequestVerificationToken""]');
        $("".loader"").removeClass(""hidden""");
            WriteLiteral(@");
        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                Id: Id
            },
            success: function (response) {
                $('#btn-deleteProductRecive-accept').removeAttr(""disabled"");

                if (response === ""SUCCESSFUL"") {
                    $('#DeleteProductReciveModal').modal('hide');
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#productReciveKendoGrid .k-pager-refresh"")[0].click();
                }
                else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {

                    $(""#DeleteProductReciveModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");");
            WriteLiteral(@"
                }
                else if (response === ""ERROR_SomeThingWentWrong"") {

                    $(""#DeleteProductReciveModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""AreYouSure"") {
                    AskForDelete(Id);
                }
                else if (response === ""CanNotDelete"") {
                    CanNotDelete();
                } else {
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WPH.Models.CustomDataModels.BaseInfo.BaseInfosAndPeriodsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
