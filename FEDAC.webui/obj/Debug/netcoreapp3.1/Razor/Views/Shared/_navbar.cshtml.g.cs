#pragma checksum "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89aa3b5ce3b600d0e6e0eaa2de028b2d8436242b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
#line 2 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\_ViewImports.cshtml"
using FEDAC.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89aa3b5ce3b600d0e6e0eaa2de028b2d8436242b", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ca0ffb318a777b43710af851ccc9354c9022a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""navbar bg-danger navbar-dark navbar-expand-sm"">
    <div class=""container"">
        <a href=""/"" class=""navbar-brand"">FEDAC</a>
        <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item"">
                <a href=""/products"" class=""nav-link"">Products</a>
            </li>
");
#nullable restore
#line 8 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/product/create"" class=""nav-link"">Cart</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/product/create"" class=""nav-link"">Orders</a>
                </li>
");
#nullable restore
#line 16 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
                //kullanıcı rolü admin değilse web sitede admini ilgilendiren sayfaları görmesini engelledik.
                if(User.IsInRole("admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                         <li class=""nav-item"">
                        <a href=""/admin/products"" class=""nav-link"">Admin Products</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/categories"" class=""nav-link"">Admin Categories</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/role/list"" class=""nav-link"">Roles</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/user/list"" class=""nav-link"">Users</a>
                        </li> 
");
#nullable restore
#line 31 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
                }  
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n        <ul class=\"navbar-nav ml-auto\">\n\n");
#nullable restore
#line 36 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\n                    <a href=\"/account/manage\" class=\"nav-link\">\n                    ");
#nullable restore
#line 40 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </li>\n                <li class=\"nav-item\">\n                    <a href=\"/account/logout\" class=\"nav-link\">Logout</a>\n                </li>\n");
#nullable restore
#line 46 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/account/login"" class=""nav-link"">Login</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/account/register"" class=""nav-link"">Register</a>
                </li>
");
#nullable restore
#line 55 "C:\Users\ceyda\Desktop\FEDAC\FEDAC.webui\Views\Shared\_navbar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </ul>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591