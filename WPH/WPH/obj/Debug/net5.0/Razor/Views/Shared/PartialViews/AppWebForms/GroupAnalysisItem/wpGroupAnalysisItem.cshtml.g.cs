#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f947e896f2da3bf4ba87aecfc5422ddc333d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.GroupAnalysisItem.Views_Shared_PartialViews_AppWebForms_GroupAnalysisItem_wpGroupAnalysisItem), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/GroupAnalysisItem/wpGroupAnalysisItem.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.GroupAnalysisItem
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f947e896f2da3bf4ba87aecfc5422ddc333d7d", @"/Views/Shared/PartialViews/AppWebForms/GroupAnalysisItem/wpGroupAnalysisItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_GroupAnalysisItem_wpGroupAnalysisItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
  
    string dir = "";
    if (HttpContextAccessor.HttpContext.Session.GetString("culture") == "en")
    {
        dir = " ";
    }
    else
    {
        dir = " direction:rtl; ";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input class=\"hidden\" type=\"text\" id=\"groupanalysisid\" data-Value=\"");
#nullable restore
#line 20 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                              Write(ViewBag.GroupAnalysisFirstId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<div class=\"space-10\"></div>\r\n<div class=\"row Grid-Content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\" style=\"margin-top: 2px;\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <span>");
#nullable restore
#line 27 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                     Write(Localizer["Analysis"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                Write(Html.Kendo().DropDownList()
                    .Name("analysis")
                    .DataTextField("Name")
                    .DataValueField("Guid")
                    .Events(e =>
                    {
                        e.Select("onSelectAnalysisForGroupAnalysisPage");
                    })
                    .DataSource(source =>
                      {
                          source.Read(read =>
                          {
                              read.Action("GetAllAnalysesWithoutInGroupAnalysis", "Analysis").Data("GetGroupAnalysisIdInGroupAnalysisItemPage");
                          })
                          .ServerFiltering(false);
                      })
                  .HtmlAttributes(new { style = "width: 100%;font-size:1.5rem" })
                    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-md-2"" style=""padding:0px"">
                    <a id=""add-Analysis"" class=""k-primary pull-right"" style=""display: inline-block;"" href=""#"">
                        <i class=""fa fa-angle-double-left"" style=""font-size: 20px;padding: 0px 15px;""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""col-md-10"">
            ");
#nullable restore
#line 59 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
       Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/GroupAnalysisItem/dgGroupAnalysis_AnalysisGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""row"" style=""margin-top:5px"">
        <div class=""col-md-11 col-sm-11"">
        </div>
        <div class=""col-md-1 col-sm-1"">
            <a id=""DeleteAllAnalysis"" class=""btn btn-xs btn-danger pull-right"" style=""display: inline-block;"" href=""#"">
                ");
#nullable restore
#line 67 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
           Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                Write(Localizer["All"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </a>
        </div>
    </div>
</div>

<div class=""row Grid-Content"">
    <div class=""row"" style=""margin-left: 0px;margin-right: 0px;"">
        <div class=""col-md-2"" style=""margin-top: 2px;"">

            <div class=""row"" style=""margin-top:3px"">
                <div class=""col-md-12"">
                    <span>");
#nullable restore
#line 79 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                     Write(Localizer["AnalysisItems"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 86 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/PartialViews/AppWebForms/GroupAnalysisItem/dgGroupAnalysisItemGrid.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""row"" style=""margin-top:5px;margin-left: 0px;margin-right: 0px"">
                <div class=""col-md-11 col-sm-11"">
                </div>
                <div class=""col-md-1 col-sm-1"">
                    <a id=""DeleteAll"" class=""btn btn-xs btn-danger pull-right"" style=""display: inline-block;"" href=""#"">
                        ");
#nullable restore
#line 93 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                   Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 93 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                        Write(Localizer["All"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input class=\"hidden\" type=\"text\" id=\"analysisid\" data-Value=\"");
#nullable restore
#line 101 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                         Write(ViewBag.AnalysisFirstItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<input class=\"hidden\" type=\"text\" id=\"analysisidForAnalysisItem\" data-Value=\"");
#nullable restore
#line 102 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                                        Write(ViewBag.AnalysisFirstItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n<input class=\"hidden\" type=\"text\" id=\"analysisitemid\" data-Value=\"\" />\r\n\r\n<div id=\"GroupAnalysisModal\" class=\"modal fade\" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 4111, "\"", 4123, 1);
#nullable restore
#line 105 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
WriteAttributeValue("", 4119, dir, 4119, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeGroupAnalysisModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""GroupAnalysisModal-header"" class=""smaller lighter blue no-margin"">");
#nullable restore
#line 110 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                                                     Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n\r\n            <div id=\"GroupAnalysisModal-body\" class=\"modal-body\">\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 118 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-GroupAnalysisModal-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick = "groupAnalysisClick()" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 122 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-GroupAnalysisModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick= "closeGroupAnalysisModal()" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"GroupAnalysisItemModal\" class=\"modal fade\" tabindex=\"-1\"");
            BeginWriteAttribute("style", " style=\"", 5402, "\"", 5414, 1);
#nullable restore
#line 131 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
WriteAttributeValue("", 5410, dir, 5410, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" onclick=""closeGroupAnalysisItemModal()"" aria-hidden=""true"">&times;</button>
                <h3 id=""GroupAnalysisItemModal-header"" class=""smaller lighter blue no-margin"">");
#nullable restore
#line 136 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                                                         Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n\r\n            <div id=\"GroupAnalysisItemModal-body\" class=\"modal-body\" style=\"width:70rem\">\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 144 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-newGroupAnalysisItem-accept")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right", onclick= "analysisItemClick()" })
                    .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 148 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-GroupAnalysisItemModal-close")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", onclick="closeGroupAnalysisItemModal()" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"GroupAnalysisItem-modal-delete\" class=\"modal fade bd-example-modal-lg\" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 6793, "\"", 6805, 1);
#nullable restore
#line 158 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
WriteAttributeValue("", 6801, dir, 6801, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3 class='smaller'><i class='ace-icon fa fa-exclamation-triangle red'></i>");
#nullable restore
#line 163 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                                                      Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>

            <div id=""delete-modal-body"" class=""modal-body"">
                <div class=""label label-warning label-white middle"" style=""font-size:1.5rem;height:40px;"">
                    <i class=""ace-icon fa fa-exclamation-triangle bigger-120""></i>
                    ");
#nullable restore
#line 169 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
               Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div id=""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"" class=""label label-danger label-white middle hidden"" style=""font-size:small;height:40px;"">
                    <i class=""ace-icon fa fa-stop bigger-120""></i>
                    ");
#nullable restore
#line 173 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div id=""ERROR_SomeThingWentWrong"" class=""label label-danger label-white middle hidden"" style=""font-size:small;height:40px;"">
                    <i class=""ace-icon fa fa-stop bigger-120""></i>
                    ");
#nullable restore
#line 177 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 182 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 184 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-delete-accept-GroupAnalysisItem")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 188 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-close-modal-update")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", @data_dismiss = "modal" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div>\r\n\r\n<div id=\"GroupAnalysis_Analysis-modal-delete\" class=\"modal fade bd-example-modal-lg\" data-backdrop=\"static\" data-keyboard=\"false\"");
            BeginWriteAttribute("style", " style=\"", 9112, "\"", 9124, 1);
#nullable restore
#line 198 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
WriteAttributeValue("", 9120, dir, 9120, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""widget-header"" style=""padding:1rem"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h3 class='smaller'><i class='ace-icon fa fa-exclamation-triangle red'></i>");
#nullable restore
#line 203 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
                                                                                      Write(Localizer["DeleteRecordHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>

            <div id=""delete-modal-body"" class=""modal-body"">
                <div class=""label label-warning label-white middle"" style=""font-size:1.5rem;height:40px;"">
                    <i class=""ace-icon fa fa-exclamation-triangle bigger-120""></i>
                    ");
#nullable restore
#line 209 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
               Write(Localizer["DeleteRecordBody"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div id=""ERROR_ThisRecordHasDependencyOnItInAnotherEntity"" class=""label label-danger label-white middle hidden"" style=""font-size:small;height:40px;"">
                    <i class=""ace-icon fa fa-stop bigger-120""></i>
                    ");
#nullable restore
#line 213 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
               Write(Localizer["ERROR_ThisRecordHasDependencyOnItInAnotherEntity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div id=""ERROR_SomeThingWentWrong"" class=""label label-danger label-white middle hidden"" style=""font-size:small;height:40px;"">
                    <i class=""ace-icon fa fa-stop bigger-120""></i>
                    ");
#nullable restore
#line 217 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
               Write(Localizer["ERROR_SomeThingWentWrong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 222 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 224 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                .Name("btn-delete-accept-GroupAnalysis_Analysis")
                .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "k-primary pull-right" })
                .Content(Localizer["Ok"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 228 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
            Write(Html.Kendo().Button()
                    .Name("btn-close-modal-update")
                    .HtmlAttributes(new { style = "font-size:15px;height:35px;margin:2px;", type = "button", @class = "pull-right", @data_dismiss = "modal" })
                    .Content(Localizer["Exit"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div>\r\n\r\n");
#nullable restore
#line 238 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_GridAndModalLinks.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 239 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\GroupAnalysisItem\wpGroupAnalysisItem.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/PartialViews/InterfacePartials/_Modal.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
