#pragma checksum "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2643cdaabeeac700a35ea9da05ede8e759c988c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2643cdaabeeac700a35ea9da05ede8e759c988c9", @"/Views/Product/Index.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrnekUygulama.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <ul>\r\n");
#nullable restore
#line 4 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
       foreach (var product in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <li>");
#nullable restore
#line 6 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
        Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 7 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n    <br />\r\n\r\n     <ul>\r\n");
#nullable restore
#line 13 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
       foreach (var product in ViewBag.Product as List<OrnekUygulama.Models.Product>)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <li>");
#nullable restore
#line 15 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
        Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n     <br />\r\n\r\n     <ul>\r\n");
#nullable restore
#line 22 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
       foreach (var product in ViewData["products"] as List<OrnekUygulama.Models.Product>)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <li>");
#nullable restore
#line 24 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
        Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 25 "D:\Kurslar\ASP.NET_MVC_CORE\DotNetCore5Lessons\OrnekUygulama\OrnekUygulama\Views\Product\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrnekUygulama.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591