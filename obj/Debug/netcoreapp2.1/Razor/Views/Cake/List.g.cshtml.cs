#pragma checksum "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6571ae392b3828410129ec58e1dc933e1d97d0a1"
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
#line 2 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\_ViewImports.cshtml"
using CakesBruno.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6571ae392b3828410129ec58e1dc933e1d97d0a1", @"/Views/Cake/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4863a5c4e1f96ad54c4b4bc40579af1e7d0513e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cake_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(5, 21, false);
#line 1 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(26, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 3 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
            BeginContext(70, 37, true);
            WriteLiteral("        <span>No items found</span>\r\n");
            EndContext();
#line 7 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
    }
    else
    {
        foreach (Cake cake in Model.Cakes)
        {
            

#line default
#line hidden
            BeginContext(199, 34, false);
#line 12 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
       Write(Html.Partial("CakesSummary", cake));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Bruno Lopes\source\repos\CakesBruno\CakesBruno\Views\Cake\List.cshtml"
                                               
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
