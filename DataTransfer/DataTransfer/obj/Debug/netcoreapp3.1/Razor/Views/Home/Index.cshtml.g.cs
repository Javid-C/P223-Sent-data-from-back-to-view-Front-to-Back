#pragma checksum "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd0dc6670cff919273e45e65584dc6f5eaecc82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
using DataTransfer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd0dc6670cff919273e45e65584dc6f5eaecc82", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    //Layout = null;
    //List<Product> products = ViewBag.Products;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>New Nike Models</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
     foreach (Product item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("style", " style=\"", 257, "\"", 296, 2);
            WriteAttributeValue("", 265, "color:", 265, 6, true);
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
WriteAttributeValue("", 271, item.Count<=0?"red":"", 271, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", name= ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", price= ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
                                                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $,size= ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
                                                                                                      Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(",color= ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
                                                                                                                        Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(",count= ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
                                                                                                                                           Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\DataTransfer\DataTransfer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
