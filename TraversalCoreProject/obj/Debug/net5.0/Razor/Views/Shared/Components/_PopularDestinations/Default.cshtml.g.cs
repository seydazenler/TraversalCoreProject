#pragma checksum "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b79a786dd4bd99cbafb48c00b5c99a8649cfcda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PopularDestinations_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PopularDestinations/Default.cshtml")]
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
#line 1 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b79a786dd4bd99cbafb48c00b5c99a8649cfcda", @"/Views/Shared/Components/_PopularDestinations/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad240c6781add83b5b19d87e0d171152be257c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__PopularDestinations_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Visit</h6>
            <h3 class=""hny-title"">Popular Destinations</h3>
        </div>
        <div class=""row bottom-ab-grids"">
            <!--/row-grids-->
");
#nullable restore
#line 11 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 788, "\"", 805, 1);
#nullable restore
#line 19 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
WriteAttributeValue("", 794, item.Image, 794, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 824, "\"", 830, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </div>\n                            <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\n                                <h4>");
#nullable restore
#line 22 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <p>");
#nullable restore
#line 23 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                              Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <div class=\"dst-btm\">\n                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1147, "\"", 1155, 0);
            EndWriteAttribute();
            WriteLiteral("> \'den başlayan fiyatlarla </h6>\n                                    <span>");
#nullable restore
#line 26 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </div>\n                                <p class=\"sub-para\">");
#nullable restore
#line 28 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </a>\n                </div>\n            </div>\n");
#nullable restore
#line 34 "C:\Users\Şeyda Yıldız\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
