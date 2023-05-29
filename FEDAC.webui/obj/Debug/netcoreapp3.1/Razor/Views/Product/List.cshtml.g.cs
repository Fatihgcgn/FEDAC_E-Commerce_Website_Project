#pragma checksum "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94e79bafb8fc9bca836967db590848e02cd39cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 2 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94e79bafb8fc9bca836967db590848e02cd39cc", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ca0ffb318a777b43710af851ccc9354c9022a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
  
    //popular class etiketini eğer 2den fazla ürün(product) varsa kullansın diğer türlü kullanmasın.
    var popularClass = Model.Products.Count>2?"popular":"";
    var products=Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 11 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
#nullable restore
#line 14 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
 if (products.Count == 0) //ürün yoksa
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
                                                                     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">                     \n");
#nullable restore
#line 21 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\n                ");
#nullable restore
#line 24 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 26 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 28 "C:\Users\fatih\Desktop\FEDAC\FEDAC.webui\Views\Product\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
