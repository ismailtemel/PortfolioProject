#pragma checksum "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9d6f5db48722370908af3e99346fc363a986577bae25d44be784201c43cc6d57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
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
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\_ViewImports.cshtml"
using PortfolioProject.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\_ViewImports.cshtml"
using PortfolioProject.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9d6f5db48722370908af3e99346fc363a986577bae25d44be784201c43cc6d57", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bf164ab44bbf4e37cd7977c246d209c3d83397d30e1a79c799dfb5bf4ef13663", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
  
    string color = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Duyurular</h4>
      
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Tür</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if(item.Type=="Yeni Yazı")
                            {
                                color = "badge badge-danger";
                            }
                            if(item.Type=="Yeni Video")
                            {
                                color = "badge badge-warning";
                            }
                            if(item.Type=="Konferans")
                            {
                                color = "badge badge-info";
                            }
                            if(item.Type=="Workshop")
                            {
                                color = "badge badge-success";
                            }
                            if(item.Type=="Bootcamp")
                            {
                                color = "badge badge-primary";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 50 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 51 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
                                Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><label");
            BeginWriteAttribute("class", " class=\"", 2055, "\"", 2069, 1);
#nullable restore
#line 53 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2063, color, 2063, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
                                                     Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2134, "\"", 2185, 2);
            WriteAttributeValue("", 2141, "/Writer/Default/AnnouncementDetails/", 2141, 36, true);
#nullable restore
#line 54 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2177, item.ID, 2177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 56 "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n             \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
