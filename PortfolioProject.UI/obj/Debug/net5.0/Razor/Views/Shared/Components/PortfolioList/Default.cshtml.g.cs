#pragma checksum "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92c2f27643f2108502a8e74cfcc77abc64d6abbd70d3822116242ef8593ebe20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Views\_ViewImports.cshtml"
using PortfolioProject.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PortfolioProject\PortfolioProject.UI\Views\_ViewImports.cshtml"
using PortfolioProject.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"92c2f27643f2108502a8e74cfcc77abc64d6abbd70d3822116242ef8593ebe20", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bf164ab44bbf4e37cd7977c246d209c3d83397d30e1a79c799dfb5bf4ef13663", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
﻿

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Projelerim </h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>
");
#nullable restore
#line 11 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid-item\">\r\n                    <a href=\"https://dribbble.com\">\r\n                        <figure class=\"portfolio-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 631, "\"", 651, 1);
#nullable restore
#line 16 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 637, item.ImageUrl, 637, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
#nullable restore
#line 16 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                          Write(item.ImageUrl2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                            <figcaption>\r\n                                <h4 class=\"h5 mb-0\">");
#nullable restore
#line 18 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div>");
#nullable restore
#line 19 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
                                Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </figcaption>\r\n                        </figure>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 24 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\PortfolioList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
