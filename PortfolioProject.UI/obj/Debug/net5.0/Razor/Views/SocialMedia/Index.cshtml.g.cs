#pragma checksum "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c14523018d60dbf56ebcf40eb4246e25b57694e6f9a58210e6d4187ea795d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_Index), @"mvc.1.0.view", @"/Views/SocialMedia/Index.cshtml")]
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
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c14523018d60dbf56ebcf40eb4246e25b57694e6f9a58210e6d4187ea795d14", @"/Views/SocialMedia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bf164ab44bbf4e37cd7977c246d209c3d83397d30e1a79c799dfb5bf4ef13663", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SocialMedia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title""> Deneyimler</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 23 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 27 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
                               Write(item.SocialMediaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1046, 2);
            WriteAttributeValue("", 996, "/SocialMedia/DeleteSocialMedia/", 996, 31, true);
#nullable restore
#line 29 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 1027, item.SocialMediaID, 1027, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1131, "\"", 1188, 2);
            WriteAttributeValue("", 1138, "/SocialMedia/UpdateSocialMedia/", 1138, 31, true);
#nullable restore
#line 30 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 1169, item.SocialMediaID, 1169, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 34 "D:\PortfolioProject\PortfolioProject.UI\Views\SocialMedia\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <a href=\"/SocialMedia/AddSocialMedia/\" class=\"btn btn-outline-info\">Yeni Sosyal Medya Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591