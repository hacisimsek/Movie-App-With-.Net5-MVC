#pragma checksum "C:\Users\hacisimsek\Desktop\dotnet\Views\Shared\_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e4e41da001a4133ce898c4ff528ba076b167bef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
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
#line 1 "C:\Users\hacisimsek\Desktop\dotnet\Views\_ViewImports.cshtml"
using dotnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hacisimsek\Desktop\dotnet\Views\_ViewImports.cshtml"
using dotnet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4e41da001a4133ce898c4ff528ba076b167bef", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a109575271c2d8e2f37e0ea938cc447c8cd1d0c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"list-group\">\r\n\r\n");
#nullable restore
#line 6 "C:\Users\hacisimsek\Desktop\dotnet\Views\Shared\_menu.cshtml"
     foreach (var category in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action active\"> \r\n       ");
#nullable restore
#line 8 "C:\Users\hacisimsek\Desktop\dotnet\Views\Shared\_menu.cshtml"
  Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </a>\r\n");
#nullable restore
#line 10 "C:\Users\hacisimsek\Desktop\dotnet\Views\Shared\_menu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
