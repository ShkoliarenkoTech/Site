#pragma checksum "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83992281a412a39df30f4dfc836cdbbfa2134515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bakery_ViewResult), @"mvc.1.0.view", @"/Views/Bakery/ViewResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bakery/ViewResult.cshtml", typeof(AspNetCore.Views_Bakery_ViewResult))]
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
#line 1 "D:\GitHub\Projects\Site\Site\Site\Views\_ViewImports.cshtml"
using Site.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83992281a412a39df30f4dfc836cdbbfa2134515", @"/Views/Bakery/ViewResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811f1a2ac6095d556332e7bff6ab43642d452983", @"/Views/_ViewImports.cshtml")]
    public class Views_Bakery_ViewResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<h1>All bakery products</h1>\r\n<h3>");
            EndContext();
            BeginContext(35, 20, false);
#line 2 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
Write(Model.BakeryCategory);

#line default
#line hidden
            EndContext();
            BeginContext(55, 35, true);
            WriteLiteral("</h3>\r\n<div class=\" mt-5 mb-2\">\r\n\r\n");
            EndContext();
#line 5 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
      


        foreach (var bakery in Model.AllBakery)
        {


#line default
#line hidden
            BeginContext(164, 16, true);
            WriteLiteral("            <h2>");
            EndContext();
            BeginContext(181, 11, false);
#line 11 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
           Write(bakery.Name);

#line default
#line hidden
            EndContext();
            BeginContext(192, 6, true);
            WriteLiteral("</h2> ");
            EndContext();
#line 11 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
                                  //Product name:

#line default
#line hidden
            BeginContext(215, 81, true);
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <p><img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 296, "\"", 315, 1);
#line 13 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
WriteAttributeValue("", 302, bakery.Image, 302, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 65, true);
            WriteLiteral(" alt=\"Image\" width=\"500\" height=\"500\" /></p>\r\n                <p>");
            EndContext();
            BeginContext(382, 22, false);
#line 14 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
              Write(bakery.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(404, 34, true);
            WriteLiteral("</p>\r\n                <p><b>Price:");
            EndContext();
            BeginContext(439, 26, false);
#line 15 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"
                       Write(bakery.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(465, 101, true);
            WriteLiteral("</b></p>\r\n                <p><a class =\" btn btn-warning\" href=\"#\">More</a></p>\r\n            </div>\r\n");
            EndContext();
#line 18 "D:\GitHub\Projects\Site\Site\Site\Views\Bakery\ViewResult.cshtml"

        }

    

#line default
#line hidden
            BeginContext(588, 14, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
