#pragma checksum "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b48998ef504bc32db947d7fb3359e3b859eeee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cake_List), @"mvc.1.0.view", @"/Views/Cake/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cake/List.cshtml", typeof(AspNetCore.Views_Cake_List))]
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
#line 1 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b48998ef504bc32db947d7fb3359e3b859eeee", @"/Views/Cake/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ed7f0143cd9087aa03f8267b41c0bd113c8b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Cake_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 62, true);
            WriteLiteral("\r\n<div>\r\n    <h2>All cakes are shown here</h2>\r\n</div>\r\n\r\n<h2>");
            EndContext();
            BeginContext(93, 21, false);
#line 7 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(114, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
            BeginContext(158, 37, true);
            WriteLiteral("        <span>No items found</span>\r\n");
            EndContext();
#line 13 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
    }
    else
    {
        foreach (var cake in Model.Cakes)
        {

#line default
#line hidden
            BeginContext(273, 50, true);
            WriteLiteral("            <div>\r\n                <h4>Cake Name: ");
            EndContext();
            BeginContext(324, 9, false);
#line 19 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
                          Write(cake.Name);

#line default
#line hidden
            EndContext();
            BeginContext(333, 38, true);
            WriteLiteral("</h4>\r\n                <p>Cake price: ");
            EndContext();
            BeginContext(372, 50, false);
#line 20 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
                          Write(cake.Price.ToString("C", new CultureInfo("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(422, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 22 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
        }
    }

#line default
#line hidden
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
