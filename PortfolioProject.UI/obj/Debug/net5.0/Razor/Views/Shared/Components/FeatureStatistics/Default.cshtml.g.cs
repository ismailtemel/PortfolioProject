#pragma checksum "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\FeatureStatistics\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b836c2253e00b6d9768b7f5569c6dcf3a9d402c110fee9ecf769d88c792b88d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureStatistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureStatistics/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b836c2253e00b6d9768b7f5569c6dcf3a9d402c110fee9ecf769d88c792b88d2", @"/Views/Shared/Components/FeatureStatistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bf164ab44bbf4e37cd7977c246d209c3d83397d30e1a79c799dfb5bf4ef13663", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeatureStatistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""mb-0"">");
#nullable restore
#line 9 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                        Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""icon icon-box-success "">
                            <span class=""mdi mdi-arrow-top-right icon-item""></span>
                        </div>
                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Yetenek Sayısı</h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""mb-0"">$");
#nullable restore
#line 29 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                         Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""icon icon-box-success"">
                            <span class=""mdi mdi-arrow-top-right icon-item""></span>
                        </div>
                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Okunmamış Mesaj Sayısı</h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""mb-0"">");
#nullable restore
#line 49 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""icon icon-box-danger"">
                            <span class=""mdi mdi-arrow-bottom-left icon-item""></span>
                        </div>
                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Okunmuş Mesaj Sayısı</h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""mb-0"">");
#nullable restore
#line 69 "D:\PortfolioProject\PortfolioProject.UI\Views\Shared\Components\FeatureStatistics\Default.cshtml"
                                        Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""icon icon-box-success "">
                            <span class=""mdi mdi-arrow-top-right icon-item""></span>
                        </div>
                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Çalışılan Firma Sayısı</h6>
            </div>
        </div>
    </div>
</div>");
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
