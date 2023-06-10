#pragma checksum "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\MoneyConvert\dgMoneyConvertGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74001652fb175c897e38ac7bf42b4c99db0c9443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WPH.Pages.Shared.PartialViews.AppWebForms.MoneyConvert.Views_Shared_PartialViews_AppWebForms_MoneyConvert_dgMoneyConvertGrid), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AppWebForms/MoneyConvert/dgMoneyConvertGrid.cshtml")]
namespace WPH.Pages.Shared.PartialViews.AppWebForms.MoneyConvert
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
#line 2 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\MoneyConvert\dgMoneyConvertGrid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74001652fb175c897e38ac7bf42b4c99db0c9443", @"/Views/Shared/PartialViews/AppWebForms/MoneyConvert/dgMoneyConvertGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221a2d8e2059d2e61789d73e7efe285a53b8943", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AppWebForms_MoneyConvert_dgMoneyConvertGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\MoneyConvert\dgMoneyConvertGrid.cshtml"
  

    string edit_title = Localizer["EditMoneyConvert"];
    string remove_title = Localizer["RemoveMoneyConvert"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 14 "C:\Users\Mehran\source\repos\Clinic\WAS\WPH\WPH\Views\Shared\PartialViews\AppWebForms\MoneyConvert\dgMoneyConvertGrid.cshtml"
Write(Html.Kendo().Grid<WPH.Models.CustomDataModels.MoneyConvert.MoneyConvertViewModel>
    ()
    .Name("kendoMoneyConvertGrid")
    .Columns(columns =>
    {

        if (HttpContextAccessor.HttpContext.Session.GetString("culture") != "en")
        {
            if ((bool)ViewBag.AccessDeleteMoneyConvert)
            {
                columns.Bound("").Title(" ").Width(10).HeaderHtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
               $@"<a class='tooltip-error grid-btn' onClick='GridDeleteMoneyConvertFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete' data-toggle='modal'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }


            if ((bool)ViewBag.AccessEditMoneyConvert)
            {
                columns.Bound("").Title(" ").Width(10)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn edit' onClick='EditMoneyConvert(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");

            }

            columns.Bound(x => x.DestAmount).Title(Localizer["DestAmount"]).Format("{0:n0}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.BaseAmount).Title(Localizer["BaseAmount"]).Format("{0:n0}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.DestCurrencyName).Title(Localizer["DestCurrency"]).HtmlAttributes(new { @style = "text-align:center;font-size:1.5rem" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.BaseCurrencyName).Title(Localizer["BaseCurrency"]).HtmlAttributes(new { @style = "text-align:center;font-size:1.5rem" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Date).Title(Localizer["Date"]).Format("{0: dd/MM/yyyy}").Filterable(x => x.Cell(y => y.Template("CostDateFilterInCostGrid"))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Index).Filterable(false).Width(10).Title("#").HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Guid).Hidden();
        }
        else
        {
            columns.Bound(x => x.Guid).Hidden();
            columns.Bound(x => x.Index).Filterable(false).Title("#").Width(10).HtmlAttributes(new { @style = "text-align:center;font-size:1.5rem" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.Date).Title(Localizer["Date"]).Format("{0: dd/MM/yyyy}").Filterable(x => x.Cell(y => y.Template("CostDateFilterInCostGrid"))).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.BaseCurrencyName).Title(Localizer["BaseCurrency"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.DestCurrencyName).Title(Localizer["DestCurrency"]).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.BaseAmount).Title(Localizer["BaseAmount"]).Format("{0:n0}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });
            columns.Bound(x => x.DestAmount).Title(Localizer["DestAmount"]).Format("{0:n0}").Filterable(false).HtmlAttributes(new { @style = "text-align:center;" }).HeaderHtmlAttributes(new { @style = "text-align:center;" });

            if ((bool)ViewBag.AccessEditMoneyConvert)
            {
                columns.Bound("").Title(" ").Width(10)
                .ClientTemplate(
                   $@"<a class='tooltip-success grid-btn edit' onClick='EditMoneyConvert(this);' data-id='#=Guid#' data-rel='tooltip' title='{edit_title}' data-original-title='Edit'>
                        <span class='green'>
                            <i class='ace-icon fa fa-pencil bigger-120'></i>
                        </span>
                    </a>
                ");
            }


            if ((bool)ViewBag.AccessDeleteMoneyConvert)
            {
                columns.Bound("").Title(" ").Width(10).HeaderHtmlAttributes(new { @style = "text-align:center;" })
                .ClientTemplate(
                   $@"<a class='tooltip-error grid-btn' onClick='GridDeleteMoneyConvertFunction(this)' data-id='#=Guid#' data-rel='tooltip' title='{remove_title}' data-original-title='Delete' data-toggle='modal'>
                        <span class='red'>
                            <i class='ace-icon fa fa-trash-can bigger-120'></i>
                        </span>
                    </a>
                ");
            }

        }

    })

        .DataSource(dataSource => dataSource
        .Ajax()
        .Model(model =>
        {
            model.Id(p => p.Guid);
        })
        .PageSize(10)
        .Read(read => read.Action("GetAll", "MoneyConvert").Data("GetPeriodAndTimeForMoneyConvert"))
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

        $(""#kendoMoneyConvertGrid"").on(""dblclick"", ""tr.k-state-selected"", function (element) {

            $(""#kendoMoneyConvertGrid"").find(""tr.k-state-selected td a.edit"").click();

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
