#pragma checksum "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5493d33124e984ea026004db472ca25daf733bdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pictures_Detail), @"mvc.1.0.view", @"/Views/Pictures/Detail.cshtml")]
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
#nullable restore
#line 6 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5493d33124e984ea026004db472ca25daf733bdc", @"/Views/Pictures/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4aff890b7fea3dbeacdb638de3a041151fdbd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Pictures_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rybcansky_Shop.Models.Picture>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
  
    Layout = "Administration_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<!--<div>\r\n    <h4>Picture</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(Html.DisplayFor(model => model.order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.path));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(Html.DisplayFor(model => model.path));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 33 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>-->\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Název</th>\r\n        <th>path</th>\r\n        <th>Obrázek</th>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 46 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(this.ViewBag.Item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 47 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
       Write(this.ViewBag.Item.path);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1190, "\"", 1250, 1);
#nullable restore
#line 49 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
WriteAttributeValue("", 1196, Convert.ToString("/images/" + this.ViewBag.Item.path), 1196, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1251, "\"", 1275, 1);
#nullable restore
#line 49 "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Pictures\Detail.cshtml"
WriteAttributeValue("", 1257, this.ViewBag.name, 1257, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rybcansky_Shop.Models.Picture> Html { get; private set; }
    }
}
#pragma warning restore 1591
