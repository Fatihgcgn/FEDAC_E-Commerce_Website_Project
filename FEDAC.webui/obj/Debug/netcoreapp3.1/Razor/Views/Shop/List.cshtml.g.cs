#pragma checksum "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db073393f3c3a4cb566a00bae02fde9ccd6376b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 2 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db073393f3c3a4cb566a00bae02fde9ccd6376b0", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943906d41ec1f95f9b4fdbb047426209b98a7536", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 16 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"co\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                             if (String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 939, "\"", 1003, 2);
            WriteAttributeValue("", 947, "page-item", 947, 9, true);
#nullable restore
#line 28 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 956, Model.PageInfo.CurrentPage==i+1?"active":"", 957, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1063, "\"", 1091, 2);
            WriteAttributeValue("", 1070, "/products?page=", 1070, 15, true);
#nullable restore
#line 29 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1085, i+1, 1085, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 30 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                                    Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 34 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1359, "\"", 1423, 2);
            WriteAttributeValue("", 1367, "page-item", 1367, 9, true);
#nullable restore
#line 37 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1376, Model.PageInfo.CurrentPage==i+1?"active":"", 1377, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1483, "\"", 1543, 4);
            WriteAttributeValue("", 1490, "/products/", 1490, 10, true);
#nullable restore
#line 38 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1500, Model.PageInfo.CurrentCategory, 1500, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1531, "?page=", 1531, 6, true);
#nullable restore
#line 38 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1537, i+1, 1537, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 39 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                                    Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 43 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\fatih\Documents\GitHub\FEDAC_E-Commerce_Website_Project\FEDAC.webui\Views\Shop\List.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""
        integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo""
        crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js""
        integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6""
        crossorigin=""anonymous""></script>
");
            }
            );
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
