#pragma checksum "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\DamageDiscount\dgDamageDiscountGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c131d01335bec3634fd7ab0a54d5254fd1d1c7dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.DamageDiscount.Views_Shared_PartialViews_AppWebForms_DamageDiscount_dgDamageDiscountGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/DamageDiscount/dgDamageDiscountGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.DamageDiscount
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
#line 1 "H:\Projects\WAS\WPH\Views\_ViewImports.cshtml"
using WPH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Projects\WAS\WPH\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\DamageDiscount\dgDamageDiscountGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c131d01335bec3634fd7ab0a54d5254fd1d1c7dc", @"/Views/Shared/PartialViews/AppWebForms/DamageDiscount/dgDamageDiscountGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_DamageDiscount_dgDamageDiscountGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\DamageDiscount\dgDamageDiscountGrid.cshtml"
  
    string edit_title = Localizer["EditDiscount"];
    string remove_title = Localizer["RemoveDiscount"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 13 "H:\Projects\WAS\WPH\Views\Shared\PartialViews\AppWebForms\DamageDiscount\dgDamageDiscountGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.DamageDiscount.DamageDiscountViewModel>()
    .Name("kendoDiscountGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {

            columns.Bound("").Title(" ").Width(10).HeaderHtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-error grid-btn' onClick='GridDeleteDiscountFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete' data-toggle='modal'>
                    <span class='red'>
                        <i class='ace-icon fa fa-trash-can bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound("").Title(" ").Width(10).HeaderHtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-success grid-btn edit' onClick='EditDiscount(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                    <span class='green'>
                        <i class='ace-icon fa fa-pencil bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound(x => x.Description).Filterable(false).Width(300).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.CurrencyName).Filterable(false).Title(Localizer["Currency"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Amount).Format("{0:#,#.##}").Filterable(false).Title(Localizer["Amount"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Index).Filterable(false).Width(10).Title("#").HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.Guid).Hidden();
        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(10).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Amount).Format("{0:#,#.##}").Filterable(false).Title(Localizer["Amount"]).HtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Roboto-grid" }).HeaderHtmlAttributes(new { @style = "text-align:center;", @class = "MyFont-Sarchia-grid" });
            columns.Bound(x => x.CurrencyName).Filterable(false).Title(Localizer["Currency"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Description).Filterable(false).Width(300).Title(Localizer["Description"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            columns.Bound("").Title(" ").Width(10).HeaderHtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-success grid-btn edit' onClick='EditDiscount(this)' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                    <span class='green'>
                        <i class='ace-icon fa fa-pencil bigger-120'></i>
                    </span>
                </a>
            ");

            columns.Bound("").Title(" ").Width(10).HeaderHtmlAttributes(new { @style = "text-align:center;" })
            .ClientTemplate(
                $@"<a class='tooltip-error grid-btn' onClick='GridDeleteDiscountFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete' data-toggle='modal'>
                    <span class='red'>
                        <i class='ace-icon fa fa-trash-can bigger-120'></i>
                    </span>
                    </a>
            ");

        }

    })

        .DataSource(dataSource => dataSource
        .Ajax().ServerOperation(false)
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(10)
        .Read(read => read.Action("GetAll", "DamageDiscount",new { damageId = Model }))
        )
        .Filterable(ftb => ftb.Mode(GridFilterMode.Row))
        .Selectable(selectable => selectable.Mode(GridSelectionMode.Single))
        .Pageable(pageable => pageable
        .Input(true)
        .Refresh(true)
        .PageSizes(true)
        .ButtonCount(5)
        .Numeric(true)) // Enable paging
        .Sortable().HtmlAttributes(new { @style = "direction: ltr;margin-top:2rem;font-size:1.3rem;overflow:auto" }) // Enable sorting
    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>


<script>

    $(document).ready(function () {

        $(""#kendoDiscountGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoDiscountGrid"").find(""tr.k-state-selected td a.edit"").click();

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guid> Html { get; private set; }
    }
}
#pragma warning restore 1591
