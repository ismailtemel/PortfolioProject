#pragma checksum "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f85f061b46bfd022aa66c748754a5aea8c01b17d995e4290064af33e162c4345"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f85f061b46bfd022aa66c748754a5aea8c01b17d995e4290064af33e162c4345", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bf164ab44bbf4e37cd7977c246d209c3d83397d30e1a79c799dfb5bf4ef13663", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                   #
                                </th>
                                <th> Proje Adı </th>
                                <th> URL </th>
                                <th> Fiyat </th>
                                <th> Tamamlanma Oranı </th>
                                <th> Durum </th>                             
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 24 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 27 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1204, "\"", 1224, 1);
#nullable restore
#line 30 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1210, item.ImageUrl, 1210, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 32 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    \r\n                                    <td> ");
#nullable restore
#line 34 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> %");
#nullable restore
#line 35 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 36 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>\r\n                                        <div class=\"badge badge-outline-success\"><a");
            BeginWriteAttribute("href", " href=\"", 1664, "\"", 1713, 2);
            WriteAttributeValue("", 1671, "/Portfolio/EditPortfolio/", 1671, 25, true);
#nullable restore
#line 38 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1696, item.PortfolioID, 1696, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detayları Gör</a></div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 41 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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