#pragma checksum "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c20085e29e6d42209ec50f6e3ba1a17aa377318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.BaseInfoType.Areas_Admin_Views_Shared_PartialViews_AppWebForms_BaseInfoType_wpBaseInfoTypeForm), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/wpBaseInfoTypeForm.cshtml")]
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
#line 1 "H:\Projects\WAS\WPH\Areas\Admin\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Projects\WAS\WPH\Areas\Admin\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c20085e29e6d42209ec50f6e3ba1a17aa377318", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/wpBaseInfoTypeForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialViews_AppWebForms_BaseInfoType_wpBaseInfoTypeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
  
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
            WriteLiteral("\r\n");
#nullable restore
#line 22 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row page-header \">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 596, "\"", 610, 2);
#nullable restore
#line 25 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue("", 604, pull, 604, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 609, "", 610, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 625, "\"", 638, 1);
#nullable restore
#line 26 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue("", 633, font, 633, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 27 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
       Write(Localizer["BaseInfoType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 747, "\"", 766, 2);
#nullable restore
#line 32 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue("", 755, font, 755, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue(" ", 760, pull, 761, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n        <a class=\"btn btn-danger\" onClick=\"AddBaseInfoType(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n            ");
#nullable restore
#line 34 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
       Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n        </a>\r\n    </div>\r\n\r\n</div><!-- /.page-header -->\r\n\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 1101, "\"", 1131, 3);
            WriteAttributeValue("", 1109, "row", 1109, 3, true);
            WriteAttributeValue(" ", 1112, "Grid-Content", 1113, 13, true);
#nullable restore
#line 42 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue(" ", 1125, font, 1126, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 43 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
Write(await Html.PartialAsync("~/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/dgBaseInfoTypeGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div id=\"BaseInfoTypeModal\"");
            BeginWriteAttribute("class", " class=\"", 1298, "\"", 1322, 3);
            WriteAttributeValue("", 1306, "modal", 1306, 5, true);
            WriteAttributeValue(" ", 1311, "fade", 1312, 5, true);
#nullable restore
#line 47 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue(" ", 1316, font, 1317, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1368, "\"", 1386, 1);
#nullable restore
#line 47 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue("", 1376, direction, 1376, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeBaseInfoTypeModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""BaseInfoTypeModal-header""");
            BeginWriteAttribute("class", " class=\"", 1672, "\"", 1716, 5);
            WriteAttributeValue("", 1680, "smaller", 1680, 7, true);
            WriteAttributeValue(" ", 1687, "lighter", 1688, 8, true);
            WriteAttributeValue(" ", 1695, "blue", 1696, 5, true);
            WriteAttributeValue(" ", 1700, "no-margin", 1701, 10, true);
#nullable restore
#line 52 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue(" ", 1710, font, 1711, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 53 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
               Write(Localizer["BaseInfoType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>
            <div id=""BaseInfoTypeModal-body"" class=""modal-body"">
            </div>

            <div id=""ERROR_Data"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 61 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 66 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 70 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-BaseInfoTypeModal-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 74 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-BaseInfoTypeModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeBaseInfoTypeModal()" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"BaseInfoSectioTypeModal\"");
            BeginWriteAttribute("class", " class=\"", 3144, "\"", 3168, 3);
            WriteAttributeValue("", 3152, "modal", 3152, 5, true);
            WriteAttributeValue(" ", 3157, "fade", 3158, 5, true);
#nullable restore
#line 83 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue(" ", 3162, font, 3163, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 3214, "\"", 3232, 1);
#nullable restore
#line 83 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue("", 3222, direction, 3222, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeBaseInfoSectioTypeModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""BaseInfoSectioTypeModal-header""");
            BeginWriteAttribute("class", " class=\"", 3530, "\"", 3574, 5);
            WriteAttributeValue("", 3538, "smaller", 3538, 7, true);
            WriteAttributeValue(" ", 3545, "lighter", 3546, 8, true);
            WriteAttributeValue(" ", 3553, "blue", 3554, 5, true);
            WriteAttributeValue(" ", 3558, "no-margin", 3559, 10, true);
#nullable restore
#line 88 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
WriteAttributeValue(" ", 3568, font, 3569, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 89 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
               Write(Localizer["BaseInfoSectioType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>
            <div id=""BaseInfoSectioTypeModal-body"" class=""modal-body"">
            </div>

            <div id=""ERROR_Data"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 97 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 102 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 106 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-BaseInfoSectioTypeModal-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 110 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-BaseInfoSectioTypeModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick = "closeBaseInfoSectioTypeModal()" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"DeleteBaseInfoTypeModal\" class=\"modal fade MyFont-Roboto-grid\" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 5115, "\"", 5123, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3 class='smaller MyFont-Roboto-grid'>
                    <i class='ace-icon fa fa-exclamation-triangle red '></i>");
#nullable restore
#line 125 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
                                                                       Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n\r\n            <div id=\"DeleteBaseInfoTypeModal-body\" class=\"modal-body\">\r\n                ");
#nullable restore
#line 130 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
           Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div id=\"ERROR_ThisRecordHasDependencyOnItInAnotherEntity\" class=\"red label-white middle hidden\" style=\"height:40px;display:block;margin-top:2rem\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 133 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                    <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                    ");
#nullable restore
#line 137 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 143 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DeleteBaseInfoTypeModal-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 147 "H:\Projects\WAS\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\wpBaseInfoTypeForm.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-DeleteBaseInfoTypeModal-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", @data_dismiss = "modal" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral(@"</div>

<script>
    function SetBaseInfoSectioType(element) {

        $(""#BaseInfoSectioTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#BaseInfoSectioTypeModal').modal('toggle');

        //let header = $('#editHeader').text();
        //$('#BaseInfoSectioTypeModal-header').text(header);

        var link = ""/Admin/BaseInfoType/BaseInfoSectioTypeModal/"";
        var Id = $(element).attr('data-id');

        $("".loader"").removeClass(""hidden"");
        $('#BaseInfoSectioTypeModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function closeBaseInfoSectioTypeModal() {

        $('#BaseInfoSectioTypeModal').modal('toggle');
        $('#BaseInfoSectioTypeModal-body').empty();
    }

    function AddBaseInfoType(e) {
        $(""#BaseInfoTypeModal #ERROR_Data"").addClass(""hidden"");
        $(""#BaseInfoTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");
 ");
            WriteLiteral(@"       $(""#Mobile-wrong"").addClass('hidden');

        //let header = $(""#newHeader"").text();
        var link = ""/Admin/BaseInfoType/AddNewModal"";

        //$('#BaseInfoTypeModal-header').text(header);

        $("".loader"").removeClass(""hidden"");
        $('#BaseInfoTypeModal').modal('toggle');
        $('#BaseInfoTypeModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function EditBaseInfoType(element) {
        $(""#BaseInfoTypeModal #ERROR_Data"").addClass(""hidden"");
        $(""#BaseInfoTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#BaseInfoTypeModal').modal('toggle');

        //let header = $('#editHeader').text();
        //$('#BaseInfoTypeModal-header').text(header);

        var link = ""/Admin/BaseInfoType/EditModal/"";
        var Id = $(element).attr('data-id');

        $("".loader"").removeClass(""hidden"");
        $('#BaseInfoTypeModal-body').load(link + I");
            WriteLiteral(@"d + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });
    }

    function BaseInfoTypeDeleteFunction(element) {
        $(""#DeleteBaseInfoTypeModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteBaseInfoTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $("".loader"").removeClass(""hidden"");
        $('#DeleteBaseInfoTypeModal').modal('toggle');
        var Id = $(element).attr('data-id');
        $('#btn-DeleteBaseInfoTypeModal-accept').attr('data-id', Id);
        $("".loader"").fadeIn(""slow"");
        $("".loader"").addClass(""hidden"");
    }

    $('#btn-DeleteBaseInfoTypeModal-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#DeleteBaseInfoTypeModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").addClass(""hidden"");
        $(""#DeleteBaseInfoTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var Id = $(this).");
            WriteLiteral(@"attr('data-id');

        var link = ""/Admin/BaseInfoType/Remove"";

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
                $('#btn-DeleteBaseInfoTypeModal-accept').removeAttr(""disabled"");

                if (response === ""SUCCESSFUL"") {
                    $('#DeleteBaseInfoTypeModal').modal('hide');
                    $("".modal-backdrop:last"").remove();

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#baseInfoTypeKendoGrid .k-pager-refresh"")[0].click();
                }
                else if (response === ""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"") {
                    $(""#DeleteBaseInfoT");
            WriteLiteral(@"ypeModal #ERROR_ThisRecordHasDependencyOnItInAnotherEntity"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
                else if (response === ""ERROR_SomeThingWentWrong"") {
                    $(""#DeleteBaseInfoTypeModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
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

    $('#btn-BaseInfoTypeModal-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#BaseInfo");
            WriteLiteral(@"TypeModal #ERROR_Data"").addClass(""hidden"");
        $(""#BaseInfoTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('.emptybox').addClass('hidden');
        var isEmmpty = true;
        $('.emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() !== undefined) {
                    let text = $('[data-checkEmpty=""' + empty + '""]').val().replace(/ /g, '');
                    if (text === """") {
                        $(this).removeClass('hidden');
                        $('#btn-BaseInfoTypeModal-accept').removeAttr(""disabled"");
                        isEmmpty = false;
                        return;
                    }
                }
            }
        });

        if (isEmmpty === false) {
            return;
        }

        var data = $(""#addNewBaseInfoTypeForm"").serialize();
        var link = ""/Admin/Bas");
            WriteLiteral(@"eInfoType/AddOrUpdate"";

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                $('#btn-BaseInfoTypeModal-accept').removeAttr(""disabled"");

                if (response !== 0) {
                    if (response === ""ValueIsRepeated"") {

                        $('#Name-Exist').removeClass('hidden');

                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                    } else if (response === ""DataNotValid"") {

                        $(""#BaseInfoTypeModal #ERROR_Data"").removeClass(""hidden"");
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    } else {

                        $('#BaseInfoTypeModal').modal('hide');
                        $("".modal-backdrop:last"").remove();
                        $('#BaseInfoT");
            WriteLiteral(@"ypeModal-body').empty();
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                        $(""#baseInfoTypeKendoGrid .k-pager-refresh"")[0].click();

                    }
                } else {

                    $(""#BaseInfoTypeModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    });

    $('#btn-BaseInfoSectioTypeModal-accept').on(""click"", function () {
        $(this).attr(""disabled"", true);

        $(""#BaseInfoSectioTypeModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var list = [];
        var baseInfoTypeId = $(""#BaseInfoTypeId"").val();
        
        $('.chValue:checkbox:checked').each(function () {
            let section = {
                BaseInfoTypeId: baseInfoTypeId,
                SectionTypeId: $(this).attr('data-id')
        ");
            WriteLiteral(@"    };
            list.push(section);
        });

        var link = ""/Admin/BaseInfoType/AddBaseInfoSectioType"";
        var token = $(':input:hidden[name*=""RequestVerificationToken""]');

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: {
                __RequestVerificationToken: token.attr('value'),
                baseInfoTypeId: baseInfoTypeId,
                sectionTypes: list
            },
            success: function (response) {
                $('#btn-BaseInfoSectioTypeModal-accept').removeAttr(""disabled"");

                if (response !== 0) {

                    $('#BaseInfoSectioTypeModal').modal('hide');
                    $("".modal-backdrop:last"").remove();
                    $('#BaseInfoSectioTypeModal-body').empty();
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");

                } else {

                    $(""#BaseInfoS");
            WriteLiteral(@"ectioTypeModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    });


    function closeBaseInfoTypeModal() {
        $('#BaseInfoTypeModal').modal('toggle');
        $('#BaseInfoTypeModal-body').empty();
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
