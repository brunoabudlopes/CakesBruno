#pragma checksum "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e591335399b849ebc6589ffd4ef5610e918b31a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
#line 1 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\_ViewImports.cshtml"
using CakesBruno.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\_ViewImports.cshtml"
using CakesBruno.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e591335399b849ebc6589ffd4ef5610e918b31a3", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4863a5c4e1f96ad54c4b4bc40579af1e7d0513e", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("glyphicon glyphicon-remove text-danger remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cake", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Alcoholic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Non-alcoholic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 473, true);
            WriteLiteral(@"
<div class=""row checkoutForm"">
    <h2>Your shopping cart</h2>
    <h4>Here are the cakes in your shopping cart.</h4>
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Selected amount</th>
                <th>Cake</th>
                <th class=""text-right"">Price</th>
                <th class=""text-right"">Subtotal</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
             foreach (var line in Model.ShoppingCart.ShoppingCartItems)
            {

#line default
#line hidden
            BeginContext(621, 66, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(688, 11, false);
#line 21 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
                                       Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(699, 49, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
            EndContext();
            BeginContext(749, 14, false);
#line 22 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
                                     Write(line.Cake.Name);

#line default
#line hidden
            EndContext();
            BeginContext(763, 50, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
            EndContext();
            BeginContext(814, 55, false);
#line 23 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
                                      Write(line.Cake.Price.ToString("C", new CultureInfo("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(869, 76, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(947, 71, false);
#line 25 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
                    Write((line.Amount * line.Cake.Price).ToString("C", new CultureInfo("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 73, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(1092, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75e91e4382e4d07826c682acc440018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cakeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
                                                                                                                                                                             WriteLiteral(line.Cake.CakeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cakeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cakeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cakeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1256, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1301, 178, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(1480, 63, false);
#line 35 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\ShoppingCart\Index.cshtml"
               Write(Model.ShoppingCartTotal.ToString("C", new CultureInfo("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 154, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n\r\n    <div class=\"text-right\">\r\n        <div class=\"btn-group \">\r\n            ");
            EndContext();
            BeginContext(1697, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb21588617b24ac490f1eb3cbdbf1f04", async() => {
                BeginContext(1769, 9, true);
                WriteLiteral("Check out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1782, 286, true);
            WriteLiteral(@"
            <a class=""btn-group"">
                <a class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"">
                    Add more cakes<span class=""caret""></span>
                </a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li>");
            EndContext();
            BeginContext(2068, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bacf74afbaf041b981c9438c89728f18", async() => {
                BeginContext(2142, 13, true);
                WriteLiteral("Wedding Cakes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2159, 31, true);
            WriteLiteral("</li>\r\n                    <li>");
            EndContext();
            BeginContext(2190, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09fb1b3b1d954325b05f27964129880c", async() => {
                BeginContext(2268, 14, true);
                WriteLiteral("Birthday Cakes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2286, 82, true);
            WriteLiteral("</li>\r\n                </ul>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
