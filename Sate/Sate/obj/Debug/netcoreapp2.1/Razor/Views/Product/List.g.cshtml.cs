#pragma checksum "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba7101d71e28bc7828249a020ecbecdbd18af6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\Users\elizi\Desktop\Sate\Sate\Views\_ViewImports.cshtml"
using Sate.ViewModel;

#line default
#line hidden
#line 2 "C:\Users\elizi\Desktop\Sate\Sate\Views\_ViewImports.cshtml"
using Sate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba7101d71e28bc7828249a020ecbecdbd18af6a", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7abd15870fa3b4009c7b0f3d31624ced1f67051", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 65, true);
            WriteLiteral("\r\n<h2 align=\"center\">Все изделия</h2>\r\n<div class=\"col-lg-4\">\r\n\r\n");
            EndContext();
#line 5 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
      
        foreach (var product in Model.allP)
        {

#line default
#line hidden
            BeginContext(127, 348, true);
            WriteLiteral(@"<div class=""child"">

                <div class=""card-deck mb-3 text-center"" display=""inline"">

                    <div class=""card mb-4 shadow-sm"">
                        <div class=""card-header"">
                            <h4 class=""my-0 font-weight-normal""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">");
            EndContext();
            BeginContext(476, 12, false);
#line 13 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
                                                                                                                                         Write(product.name);

#line default
#line hidden
            EndContext();
            BeginContext(488, 159, true);
            WriteLiteral("</font></font></h4>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            <img width=\"100\" height=\"111\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 647, "\"", 665, 1);
#line 16 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
WriteAttributeValue("", 653, product.img, 653, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 666, "\"", 685, 1);
#line 16 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
WriteAttributeValue("", 672, product.name, 672, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 44, true);
            WriteLiteral(" />\r\n\r\n                            <p>Шифр: ");
            EndContext();
            BeginContext(731, 14, false);
#line 18 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
                                Write(product.cipher);

#line default
#line hidden
            EndContext();
            BeginContext(745, 48, true);
            WriteLiteral("</p>\r\n                            <p>Количество:");
            EndContext();
            BeginContext(794, 16, false);
#line 19 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
                                     Write(product.quantity);

#line default
#line hidden
            EndContext();
            BeginContext(810, 67, true);
            WriteLiteral(" </p>\r\n                        </div>\r\n\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 877, "\"", 896, 1);
#line 22 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
WriteAttributeValue("", 884, product.url, 884, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 273, true);
            WriteLiteral(@" type=""button"" class=""btn btn-lg btn-block btn-outline-primary""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Еще варианты</font></font></a>
                       

                    </div>
                </div>
            </div>
");
            EndContext();
#line 28 "C:\Users\elizi\Desktop\Sate\Sate\Views\Product\List.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1188, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591