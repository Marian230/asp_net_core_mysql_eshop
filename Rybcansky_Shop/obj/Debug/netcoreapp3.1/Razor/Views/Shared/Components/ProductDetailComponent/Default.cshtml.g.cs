#pragma checksum "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62e633ea0e915dec4505a1ff7b11c0d2339824b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductDetailComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductDetailComponent/Default.cshtml")]
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
#line 1 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\_ViewImports.cshtml"
using Rybcansky_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\_ViewImports.cshtml"
using Rybcansky_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e633ea0e915dec4505a1ff7b11c0d2339824b3", @"/Views/Shared/Components/ProductDetailComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4aff890b7fea3dbeacdb638de3a041151fdbd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductDetailComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rybcansky_Shop.Models.Order_Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"card col-8\" style=\"width: 1000px\">\r\n        <div class=\"mx-3 my-3\">\r\n            <h1>");
#nullable restore
#line 6 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
           Write(this.ViewBag.Product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
             if (@ViewBag.Product.price_Discount == null)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 293, "\"", 301, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"card-text text-danger\">");
#nullable restore
#line 11 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                                                 Write(ViewBag.Product.price_Standart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</h2>\r\n                    <p></p>\r\n                </div>\r\n");
#nullable restore
#line 14 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
             }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 522, "\"", 530, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"card-text text-danger\">");
#nullable restore
#line 18 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                                                 Write(ViewBag.Product.price_Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</h2>\r\n                    <p class=\"card-text\"><s>");
#nullable restore
#line 19 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                                       Write(ViewBag.Product.price_Standart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</s></p>\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p>Prodejce: ");
#nullable restore
#line 23 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                    Write(this.ViewBag.Vendor[0].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Dostupnost: 5 ks</p>\r\n            <hr />\r\n\r\n            <p>");
#nullable restore
#line 27 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
          Write(this.ViewBag.Product.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <hr />\r\n\r\n            <div class=\"row footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e633ea0e915dec4505a1ff7b11c0d2339824b39748", async() => {
                WriteLiteral("\r\n                    <div class=\"col\">\r\n                        <label>Počet:</label>\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62e633ea0e915dec4505a1ff7b11c0d2339824b310195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 37 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.quantity);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ks\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62e633ea0e915dec4505a1ff7b11c0d2339824b312353", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id_Order);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                                             WriteLiteral(this.ViewBag.Cart.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e633ea0e915dec4505a1ff7b11c0d2339824b314979", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                             foreach (Variant item in this.ViewBag.Variants)
                             {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e633ea0e915dec4505a1ff7b11c0d2339824b315635", async() => {
#nullable restore
#line 43 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                                                    Write(item.color);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                                   WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
                             }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 40 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id_Product);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <button class=\"btn btn-danger\" type=\"submit\">Přidat do košíku</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card col-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 2060, "\"", 2126, 1);
#nullable restore
#line 56 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductDetailComponent\Default.cshtml"
WriteAttributeValue("", 2066, Convert.ToString("/images/" + this.ViewBag.Picture[0].path), 2066, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" style=\"width: 100%; height: 555px;  object-fit: scale-down;\" class=\"m-0\" />\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rybcansky_Shop.Models.Order_Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
