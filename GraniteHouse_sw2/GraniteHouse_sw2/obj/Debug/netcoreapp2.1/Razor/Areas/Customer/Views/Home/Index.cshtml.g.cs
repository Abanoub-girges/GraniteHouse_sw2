#pragma checksum "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c0b32b1456ddf9a5d88c1e54a1d5464f3123ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Index))]
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
#line 1 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\_ViewImports.cshtml"
using GraniteHouse_sw2;

#line default
#line hidden
#line 2 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\_ViewImports.cshtml"
using GraniteHouse_sw2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c0b32b1456ddf9a5d88c1e54a1d5464f3123ca3", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62b9f31bdeda4b94be41c4066eb24f43483aeb6", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GraniteHouse_sw2.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 38, true);
            WriteLiteral("\r\n<br /> <br />\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 6 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {


#line default
#line hidden
            BeginContext(133, 242, true);
            WriteLiteral("        <div class=\"col-4\" >\r\n            <div class=\"card mb-4\">\r\n                <div class=\"card-header\">\r\n                    <h4 class=\"my-0 font-weight-normal\" >\r\n                        <label style=\"font-size:23px; color:steelblue;\"> ");
            EndContext();
            BeginContext(376, 12, false);
#line 13 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml"
                                                                    Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(388, 128, true);
            WriteLiteral("</label>\r\n\r\n                    </h4>\r\n\r\n                </div>\r\n                <img class=\"card-img-top\" style=\"height:100% ;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 516, "\"", 536, 1);
#line 18 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 522, product.Image, 522, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(537, 294, true);
            WriteLiteral(@" alt=""Card Image"" />
                  
                <div class=""card-body"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <label style=""font-size:20px; color:#a51313""><b>$");
            EndContext();
            BeginContext(832, 13, false);
#line 23 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml"
                                                                        Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(845, 78, true);
            WriteLiteral("</b>/sq.ft</label>\r\n\r\n                        </div>\r\n                        ");
            EndContext();
            BeginContext(923, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe31c3a1e46243d29698f45b22794a13", async() => {
                BeginContext(1049, 13, true);
                WriteLiteral("View Details ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                            WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1066, 96, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
            EndContext();
#line 34 "C:\Users\Maria Majid\Desktop\Abanoub-github\GraniteHouse_sw2\GraniteHouse_sw2\GraniteHouse_sw2\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1169, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GraniteHouse_sw2.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
