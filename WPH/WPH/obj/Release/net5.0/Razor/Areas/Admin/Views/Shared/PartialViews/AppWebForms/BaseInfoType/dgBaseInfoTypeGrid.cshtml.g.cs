#pragma checksum "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\dgBaseInfoTypeGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c88484929f76593c4e8b199cf12de60060b5bd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.BaseInfoType.Areas_Admin_Views_Shared_PartialViews_AppWebForms_BaseInfoType_dgBaseInfoTypeGrid), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/dgBaseInfoTypeGrid.cshtml")]
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
#line 1 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\dgBaseInfoTypeGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c88484929f76593c4e8b199cf12de60060b5bd2", @"/Areas/Admin/Views/Shared/PartialViews/AppWebForms/BaseInfoType/dgBaseInfoTypeGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialViews_AppWebForms_BaseInfoType_dgBaseInfoTypeGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 6 "H:\Projects\WAS\WPH\WPH\Areas\Admin\Views\Shared\PartialViews\AppWebForms\BaseInfoType\dgBaseInfoTypeGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Areas.Admin.Models.BaseInfoType.BaseInfoTypeViewModel>()
    .Name("baseInfoTypeKendoGrid")
    .Columns(columns =>
    {

        //if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        //{
        //    columns.Bound("").Title(" ").Width(30).HtmlAttributes(new { @style = "text-align:center;" })
        //    .ClientTemplate(
        //        @"<a class='tooltip-success grid-btn ' onClick='ConvertToUser(this)' data-id='#=Guid#' data-rel='tooltip' title='ConvertToUser' data-original-title='ConvertToUser'>
        //            <span class='#if(User.IsUser){#green#}else{#grey#}#'>
        //                <i class='ace-icon fa fa-user-plus bigger-120'></i>
        //            </span>
        //        </a>
        //    ");

        //    columns.Bound("").Title(" ").Width(30)
        //    .ClientTemplate(
        //        @"<a class='tooltip-error grid-btn' onClick='GridDeleteFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='Delete' data-original-title='Delete'>
        //            <span class='red'>
        //                <i class='ace-icon fa fa-trash-can bigger-120'></i>
        //            </span>
        //        </a>
        //    ");

        //    columns.Bound("").Title(" ").Width(30)
        //    .ClientTemplate(
        //        @"<a class='tooltip-success grid-btn edit' onClick='EditDoctor(this);' data-id='#=Guid#' data-rel='tooltip' title='Edit' data-original-title='Edit'>
        //            <span class='green'>
        //                <i class='ace-icon fa fa-pencil bigger-120'></i>
        //            </span>
        //        </a>
        //    ");


        //    columns.Bound(x => x.MedicalSystemCode).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["MedicalSystemCode"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
        //    columns.Bound(x => x.SpecialityName).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["DoctorSpeciality"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
        //    columns.Bound(x => x.User.PhoneNumber).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Mobile"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
        //    columns.Bound(x => x.User.Name).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title(Localizer["Name"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
        //    columns.Bound(x => x.Index).Filterable(false).Width(30).Title("").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" }).Width(30);
        //    columns.Bound(x => x.Id).Hidden();
        //    columns.Bound(x => x.Guid).Hidden();
        //    columns.Bound(x => x.User.IsUser).Hidden();

        //}
        //else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Id).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Width(30).Title("").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" }).Width(30);
            columns.Bound(x => x.Ename).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title("Ename").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Fname).Filterable(ftb => ftb.Cell(cell => cell.Operator("contains").SuggestionOperator(FilterType.Contains))).Title("Fname").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            
            columns.Bound("").Title(" ").Width(30).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                @"<a class='tooltip-success grid-btn edit' onClick='EditBaseInfoType(this)' data-id='#=Guid#' data-rel='tooltip' title='Edit' data-original-title='Edit'>
                    <span class='green'>
                        <i class='ace-icon fa fa-pencil bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound("").Title(" ").Width(30)
            .ClientTemplate(
                @"<a class='tooltip-error grid-btn' onClick='BaseInfoTypeDeleteFunction(this);' data-id='#=Guid#' data-rel='tooltip' title='Delete' data-original-title='Delete'>
                    <span class='red'>
                        <i class='ace-icon fa fa-trash-can bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound("").Title(" ").Width(30).HtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                @"<a class='tooltip-success grid-btn ' onClick='SetBaseInfoSectioType(this)' data-id='#=Guid#' data-rel='tooltip' title='SetBaseInfoSectioType' data-original-title='SetBaseInfoSectioType'>
                    <span class='purple'>
                        <i class='ace-icon fa fa-plus-circle bigger-120'></i>
                    </span>
                </a>
            ");

        }

    })

        .DataSource(dataSource => dataSource
        .Ajax()
        .ServerOperation(false)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(10)
        .Read(read => read.Action("GetAll", "BaseInfoType", new { area = "Admin" }))
        )
        .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
        .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
        .Pageable(pageable => pageable
        .Input(true)
        .Refresh(true)
        .PageSizes(true)
        .ButtonCount(5)
        .Numeric(true)) // Enable paging

        .Sortable().HtmlAttributes(new { @style = "direction: ltr;margin-top:2rem;overflow:auto" }) // Enable sorting


    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>


<script>


    $(document).ready(function () {

        $(""#baseInfoTypeKendoGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#baseInfoTypeKendoGrid"").find(""tr.k-state-selected td a.edit"").click();

        });

    })

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
