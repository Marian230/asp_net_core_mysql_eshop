#pragma checksum "C:\Users\ps4ma\Desktop\asp_net_core_mysql_eshop\Rybcansky_Shop\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421446cf07924939853d099e8d30520584642b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421446cf07924939853d099e8d30520584642b4f", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4aff890b7fea3dbeacdb638de3a041151fdbd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private global::AspNetCore.Views_Contact_Index.__Generated__OverlayComponentViewComponentTagHelper __OverlayComponentViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:overlay-component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421446cf07924939853d099e8d30520584642b4f4013", async() => {
            }
            );
            __OverlayComponentViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Contact_Index.__Generated__OverlayComponentViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OverlayComponentViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Contact");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __OverlayComponentViewComponentTagHelper.name = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __OverlayComponentViewComponentTagHelper.name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"content-wrap\">\r\n    <div class=\"contact-grid\">\r\n        <div class=\"contact-form\">\r\n            <h1>Tell Us Your Message</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421446cf07924939853d099e8d30520584642b4f5569", async() => {
                WriteLiteral(@"
                <label for=""name"">Your Name</label>
                <input type=""text"" id=""name"" placeholder=""Full Name"" autocomplete=""off""/>

                <label for=""email"">Your Email</label>
                <input type=""text"" id=""email"" placeholder=""Email Address"" autocomplete=""off""/>

                <label for=""subject"">Subject</label>
                <input type=""text"" id=""subject"" placeholder=""Subject"" autocomplete=""off""/>

                <label for=""message"">Your Message</label>
                <textarea id=""message"" placeholder=""Message""></textarea>

                <input type=""submit"" value=""Send Message"" />
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div>
            <div class=""contact-info"">
                <h2>Contact Us</h2>
                <p>
                    Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum.
                    Mirum est notare quam littera gothica, quam nunc putamus parum claram anteposuerit
                    litterarum formas human. qui sequitur mutationem consuetudium lectorum. Mirum est notare quam
                </p>
                <div class=""contact-bar"">
                    <img src=""/images/contact/contact-address.svg"" alt=""Contact-address-picture"" />
                    <h3>Address</h3>
                    <p><address>123 Main Street, Anytown, CA 12345 – USA</address></p>
                    <hr />
                </div>
                <div class=""contact-bar"">
                    <img src=""/images/contact/contact-phone.svg"" alt=""Contact-phone-picture"" />
                    <h3>Phone</h3>
                    <p>Mobile: <a href=""tel:08");
            WriteLiteral(@"123456789"">(08) 123 456 789</a></p>
                    <p>Hotline: <a href=""tel:1009678456"">1009 678 456</a></p>
                    <hr />
                </div>
                <div class=""contact-bar"">
                    <img src=""/images/contact/contact-email.svg"" alt=""Contact-email-picture"" />
                    <h3>Email</h3>
                    <p><a href=""mailto:yourmail@domain.com"">yourmail@domain.com</a></p>
                    <p><a href=""mailto:mail@yourmail.com"">mail@yourmail.com</a></p>
                    <hr />
                </div>
            </div>
        </div>

    </div>
</div>");
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:overlay-component")]
        public class __Generated__OverlayComponentViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__OverlayComponentViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String name { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("OverlayComponent", new { name });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
