#pragma checksum "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73784f1130f7f717960b39913624e9637d1f3115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Detail), @"mvc.1.0.view", @"/Views/Products/Detail.cshtml")]
namespace AspNetCore
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
#line 1 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\_ViewImports.cshtml"
using Rybcansky_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\_ViewImports.cshtml"
using Rybcansky_Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
using Rybcansky_Shop.Controllers.ModelController.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73784f1130f7f717960b39913624e9637d1f3115", @"/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4aff890b7fea3dbeacdb638de3a041151fdbd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rybcansky_Shop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 6 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 9 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.price_Standart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.price_Standart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.price_Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.price_Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.vat_rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.vat_rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            <textarea readonly style=\"resize: none\">");
#nullable restore
#line 34 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                                               Write(this.ViewBag.Item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            Varianty\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <select>\r\n");
#nullable restore
#line 49 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                 foreach (VariantClass item in this.ViewBag.VariantQuery)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73784f1130f7f717960b39913624e9637d1f31158248", async() => {
                WriteLiteral("\r\n                          ");
#nullable restore
#line 52 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                     Write(item.color);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                         (");
#nullable restore
#line 53 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                     Write(item.price_Standart);

#line default
#line hidden
#nullable disable
                WriteLiteral(" /\r\n                          ");
#nullable restore
#line 54 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                     Write(item.price_Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral(") |\r\n                          ks: ");
#nullable restore
#line 55 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                         Write(item.stock_Number);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.stock_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.stock_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Number_Of_Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Number_Of_Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.id_Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            <p>");
#nullable restore
#line 79 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
          Write(this.ViewBag.CategoryQuery);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.id_Vendor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            <p>");
#nullable restore
#line 86 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
          Write(this.ViewBag.VendorQuery);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 91 "X:\ČTVRŤÁK\PRG\@Projekt\Rybcansky_Shop\Rybcansky_Shop\Views\Products\Detail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = this.ViewBag.Item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73784f1130f7f717960b39913624e9637d1f311513590", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rybcansky_Shop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
