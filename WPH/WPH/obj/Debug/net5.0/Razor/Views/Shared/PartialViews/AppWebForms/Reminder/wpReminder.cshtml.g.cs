#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ad8cd59639ed4f7327caaba47f68d178a8a0ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.Reminder.Views_Shared_PartialViews_AppWebForms_Reminder_wpReminder), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/Reminder/wpReminder.cshtml")]
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
#line 1 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ad8cd59639ed4f7327caaba47f68d178a8a0ba", @"/Views/Shared/PartialViews/AppWebForms/Reminder/wpReminder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_Reminder_wpReminder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
  
    string font = "", pull = "", direction = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        font = " MyFont-Roboto-grid ";
        pull = " pull-left ";
        direction = "  ";


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newReminderText\" class=\"hidden\">");
#nullable restore
#line 13 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                                           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                                                             Write(Localizer["Reminder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 14 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
    }
    else
    {
        font = " MyFont-Sarchia-grid ";
        pull = " pull-right ";
        direction = " direction:rtl; ";


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"newReminderText\" class=\"hidden\">");
#nullable restore
#line 21 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                                           Write(Localizer["Reminder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                                                                  Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"editReminderText\" class=\"hidden\">");
#nullable restore
#line 23 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                                        Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                                                           Write(Localizer["Reminder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("\r\n<div class=\"row page-header \">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 856, "\"", 869, 1);
#nullable restore
#line 28 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue("", 864, pull, 864, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 884, "\"", 897, 1);
#nullable restore
#line 29 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue("", 892, font, 892, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 2.3rem\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
       Write(Localizer["Reminders"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
     if ((bool)ViewBag.AccessNewReminder)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1055, "\"", 1074, 2);
#nullable restore
#line 36 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue("", 1063, font, 1063, 5, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue(" ", 1068, pull, 1069, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0 2rem;transform:translateY(-10%)\">\r\n            <a class=\"btn btn-danger\" onClick=\"AddReminder(this)\" href=\"#\" style=\"padding:0.2rem\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
           Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"ace-icon glyphicon  glyphicon-plus align-top bigger-125\"></i>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div><!-- /.page-header -->\r\n\r\n\r\n<div id=\"AddReminderModal\"");
            BeginWriteAttribute("class", " class=\"", 1456, "\"", 1480, 3);
            WriteAttributeValue("", 1464, "modal", 1464, 5, true);
            WriteAttributeValue(" ", 1469, "fade", 1470, 5, true);
#nullable restore
#line 48 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue(" ", 1474, font, 1475, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 1526, "\"", 1544, 1);
#nullable restore
#line 48 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue("", 1534, direction, 1534, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeAddReminderModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""AddReminderModal-header""");
            BeginWriteAttribute("class", " class=\"", 1828, "\"", 1872, 5);
            WriteAttributeValue("", 1836, "smaller", 1836, 7, true);
            WriteAttributeValue(" ", 1843, "lighter", 1844, 8, true);
            WriteAttributeValue(" ", 1851, "blue", 1852, 5, true);
            WriteAttributeValue(" ", 1856, "no-margin", 1857, 10, true);
#nullable restore
#line 53 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue(" ", 1866, font, 1867, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </h3>
            </div>

            <div id=""AddReminderModal-body"" class=""modal-body"" style=""width:60rem"">
            </div>

            <div id=""ERROR_Data"" class=""red label-white middle hidden"" style=""height:40px;display:block"">
                <i class=""ace-icon fa fa-stop bigger-120""></i>
                ");
#nullable restore
#line 62 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
           Write(Localizer["ERROR_DataNotValid"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div id=\"ERROR_SomeThingWentWrong\" class=\"red label-white middle hidden\" style=\"height:40px;display:block\">\r\n                <i class=\"ace-icon fa fa-stop bigger-120\"></i>\r\n                ");
#nullable restore
#line 67 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
           Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n                ");
#nullable restore
#line 72 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addReminder-accept")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick = "addNewReminder()" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 77 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-addReminder-close")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick="closeAddReminderModal()" })
                .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("</div>\r\n\r\n\r\n<!-- Grid -->\r\n<div");
            BeginWriteAttribute("class", " class=\"", 3293, "\"", 3323, 3);
            WriteAttributeValue("", 3301, "row", 3301, 3, true);
            WriteAttributeValue(" ", 3304, "Grid-Content", 3305, 13, true);
#nullable restore
#line 88 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
WriteAttributeValue(" ", 3317, font, 3318, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 89 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/Reminder/dgReminderGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 91 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script>

    function AddReminder(element) {
        $(""#AddReminderModal #ERROR_Data"").addClass(""hidden"");
        $(""#AddReminderModal #Date-valid"").addClass(""hidden"");
        $(""#AddReminderModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        var link = ""/Reminder/AddAndNewModal"";
        $("".loader"").removeClass(""hidden"");

        let header = $(""#newReminderText"").text();

        $('#AddReminderModal-header').text(header);
        $('#AddReminderModal').modal('toggle');
        $('#AddReminderModal-body').load(link, function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");
        });

    }

    function EditReminder(element) {
        $(""#AddReminderModal #ERROR_Data"").addClass(""hidden"");
        $(""#AddReminderModal #Date-valid"").addClass(""hidden"");
        $(""#AddReminderModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('#AddReminderModal').modal('toggle');
        let header = $(""#editReminderText");
            WriteLiteral(@""").text();
        $('#AddReminderModal-header').text(header);
        var link = ""/Reminder/EditModal?Id="";
        var Id = $(element).attr('data-id');
        $("".loader"").removeClass(""hidden"");
        $('#AddReminderModal-body').load(link + Id + '', function () {
            $("".loader"").fadeIn(""slow"");
            $("".loader"").addClass(""hidden"");

        });

    }

    function ChangeReminderActivation(element) {


        var Id = $(element).attr('data-id');

        var link = `/Reminder/ChangeReminderActivation/${Id}`;

        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Get"",
            url: link,
            //data: data,
            success: function (response) {
                if (response !== 0) {

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                    $(""#reminderKendoGrid .k-pager-refresh"")[0].click();

                } else {
                    bootbox.alert({");
            WriteLiteral("\n                        message: \'");
#nullable restore
#line 156 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\Reminder\wpReminder.cshtml"
                             Write(Localizer["ERROR_InsertWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        className: 'bootbox-class'
                    });

                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    }


    function addNewReminder() {
        $(""#AddReminderModal #ERROR_Data"").addClass(""hidden"");
        $(""#AddReminderModal #Date-valid"").addClass(""hidden"");
        $(""#AddReminderModal #ERROR_SomeThingWentWrong"").addClass(""hidden"");

        $('.emptybox').addClass('hidden');
        var isEmmpty = true;
        $('.emptybox').each(function () {
            if ($(this).attr('data-isEssential') === 'true') {
                var empty = $(this).attr('id');
                if ($('[data-checkEmpty=""' + empty + '""]').val() === """") {
                    $(this).removeClass('hidden');
                    isEmmpty = false;
                    return;
                }
            }
        });

        if (isEmmpty === false) {
            return;
       ");
            WriteLiteral(@" }


        var link = ""/Reminder/AddOrUpdate"";

        var data = $(""#addNewReminderForm"").serialize();


        $("".loader"").removeClass(""hidden"");
        $.ajax({
            type: ""Post"",
            url: link,
            data: data,
            success: function (response) {
                if (response !== 0) {
                    if (response === ""DataNotValid"") {

                        $(""#AddReminderModal #ERROR_Data"").removeClass(""hidden"");
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    } else if (response === ""DateNotValid"") {

                        $(""#AddReminderModal #Date-valid"").removeClass(""hidden"");
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");

                    }  else {

                        $('#AddReminderModal').modal('hide');
                        $("".modal-backdrop:last"").remove();
           ");
            WriteLiteral(@"             $('#AddReminderModal-body').empty();
                        $("".loader"").fadeIn(""slow"");
                        $("".loader"").addClass(""hidden"");
                        $(""#reminderKendoGrid .k-pager-refresh"")[0].click();

                    }
                } else {

                    $(""#AddReminderModal #ERROR_SomeThingWentWrong"").removeClass(""hidden"");
                    $("".loader"").fadeIn(""slow"");
                    $("".loader"").addClass(""hidden"");
                }
            }
        });
    }

    function closeAddReminderModal() {

        $('#AddReminderModal').modal('hide');
        $('#AddReminderModal-body').empty();
        $("".modal-backdrop:last"").remove();

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
