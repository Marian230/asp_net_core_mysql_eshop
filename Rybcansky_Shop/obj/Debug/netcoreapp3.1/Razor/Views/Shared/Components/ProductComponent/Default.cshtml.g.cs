#pragma checksum "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a663c0187c33c34022a1f9712380d143710662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a663c0187c33c34022a1f9712380d143710662", @"/Views/Shared/Components/ProductComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4aff890b7fea3dbeacdb638de3a041151fdbd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<a class=\"product\"");
            BeginWriteAttribute("href", " href=\"", 18, "\"", 94, 1);
#nullable restore
#line 1 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
WriteAttributeValue("", 25, Url.Action("Index", "Product", new { id = this.ViewBag.Product.id }), 25, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 108, "\"", 155, 1);
#nullable restore
#line 3 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
WriteAttributeValue("", 114, "/images/" + this.ViewBag.Picture.path, 114, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n\r\n    <div class=\"product-body\">\r\n        <p>\r\n            ");
#nullable restore
#line 7 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
       Write(ViewBag.Product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <div class=\"stars\">\r\n            lmao hvezdicky\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
         if (@ViewBag.Product.price_Discount == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"price\">");
#nullable restore
#line 14 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
                        Write(ViewBag.Product.price_Standart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</p>\r\n");
#nullable restore
#line 15 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"price\">");
#nullable restore
#line 18 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
                        Write(ViewBag.Product.price_Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</p>\r\n");
            WriteLiteral("            <p class=\"prev-price\">");
#nullable restore
#line 20 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
                             Write(ViewBag.Product.price_Standart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kč</p>\r\n");
#nullable restore
#line 21 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Shared\Components\ProductComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
