#pragma checksum "D:\PortfolioProject\PortfolioProject.UI\Areas\Writer\Views\Default\_SidebarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7a23cc1e38da2ec7ba84b2954c6f2abbada23eb8ad3918f8bba5cc4868fceda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default__SidebarPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7a23cc1e38da2ec7ba84b2954c6f2abbada23eb8ad3918f8bba5cc4868fceda2", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bf164ab44bbf4e37cd7977c246d209c3d83397d30e1a79c799dfb5bf4ef13663", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/ReceiverMessage/"">
                <i class=""ti-notepad menu-icon""></i>
                <span class=""menu-title"">Gelen Mesajlar</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/SenderMessage/"">
                <i class=""ti-agenda menu-icon""></i>
                <span class=""menu-title"">Giden Mesajlar</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/SendMessage/"">
                <i class=""ti-cloud menu-icon""></i>
                <span class=""menu-title"">Yen");
            WriteLiteral(@"i Mesaj</span>
            </a>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Default/Index/"">
                <i class=""ti-announcement menu-icon""></i>
                <span class=""menu-title"">Duyurular</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""ti-microphone menu-icon""></i>
                <span class=""menu-title"">Profil</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""ti-settings menu-icon""></i>
                <span class=""menu-title"">Ayarlar</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Login/LogOut/"">
                <i class=""ti-power-off menu-icon""></i>
                <span class=""menu-title"">Çıkış Yap</span>
            </a>
        </li>
    ");
            WriteLiteral("</ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591