#pragma checksum "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b591c39a40c47aed7f4485d381bfe017b323a9f5"
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
#line 1 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b591c39a40c47aed7f4485d381bfe017b323a9f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1ccbf9b2bfce1c50cd44fe67072b93e861078c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12\" style=\"margin-top:100px;\">\n    <div class=\"col-4\" style=\"float:left;\">\n        <div style=\"height:30px; margin-bottom:10px;\"><h4>");
#nullable restore
#line 7 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                                                     Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\n        <img");
            BeginWriteAttribute("src", " src=", 236, "", 249, 1);
#nullable restore
#line 8 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
WriteAttributeValue("", 241, p.Image, 241, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\" width=\"300\" style=\"margin-bottom:20px;\" />\n        <br />\n        <b>Description:</b>\n        <div style=\"width:300px;height:50px; overflow:auto\">");
#nullable restore
#line 11 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                                                       Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div style=\"height:100px\">\n            <span style=\"width:300px;\"><b>Ingredient:</b>");
#nullable restore
#line 13 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                                                    Write(p.Recipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <br />\n            <span><b>Price:</b>");
#nullable restore
#line 15 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                          Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <br />\n            <span><b>Category:</b>");
#nullable restore
#line 17 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                             Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n        <button class=\"btn btn-info\" style=\"margin-bottom:50px;\">Add Bill</button>\n    </div>\n</div>\n");
#nullable restore
#line 22 "D:\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
