#pragma checksum "/Users/Nicolas/HolaWeb/HolaWeb.App.Frontend/Pages/Saludos/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724dcba3e3b9fc9264da42a7b3c56b3c0a74519a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HolaWeb.App.Frontend.Pages.Saludos.Pages_Saludos_Details), @"mvc.1.0.razor-page", @"/Pages/Saludos/Details.cshtml")]
namespace HolaWeb.App.Frontend.Pages.Saludos
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
#line 1 "/Users/Nicolas/HolaWeb/HolaWeb.App.Frontend/Pages/_ViewImports.cshtml"
using HolaWeb.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724dcba3e3b9fc9264da42a7b3c56b3c0a74519a", @"/Pages/Saludos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da21e6eb861da2e3f9fd1f81e5c9e01edd2af728", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Saludos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle Saludos</h1>\r\n<ul>\r\n    <li>Id: ");
#nullable restore
#line 7 "/Users/Nicolas/HolaWeb/HolaWeb.App.Frontend/Pages/Saludos/Details.cshtml"
       Write(Model.Saludo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Día: ");
#nullable restore
#line 8 "/Users/Nicolas/HolaWeb/HolaWeb.App.Frontend/Pages/Saludos/Details.cshtml"
        Write(Model.Saludo.EnEspanol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Tarde: ");
#nullable restore
#line 9 "/Users/Nicolas/HolaWeb/HolaWeb.App.Frontend/Pages/Saludos/Details.cshtml"
          Write(Model.Saludo.EnIngles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Noche: ");
#nullable restore
#line 10 "/Users/Nicolas/HolaWeb/HolaWeb.App.Frontend/Pages/Saludos/Details.cshtml"
          Write(Model.Saludo.EnItaliano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <p><a href=\"./list\">Volver a Lista</a></p>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HolaWeb.App.Frontend.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolaWeb.App.Frontend.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolaWeb.App.Frontend.Pages.DetailsModel>)PageContext?.ViewData;
        public HolaWeb.App.Frontend.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591