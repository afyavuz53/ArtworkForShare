#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ccfd216bc3b54da67932f4a15f67661b288844e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desire__FinishDesireDetail), @"mvc.1.0.view", @"/Views/Desire/_FinishDesireDetail.cshtml")]
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
#line 2 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\_ViewImports.cshtml"
using ArtworkForShare.UI.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccfd216bc3b54da67932f4a15f67661b288844e", @"/Views/Desire/_FinishDesireDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_Desire__FinishDesireDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DesireDetailVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-4\">\r\n    <h2>İstek resim</h2>\r\n    <img id=\"imgRequest\"");
            BeginWriteAttribute("href", " href=\"", 99, "\"", 149, 2);
            WriteAttributeValue("", 106, "../../Content/ClaimImages/", 106, 26, true);
#nullable restore
#line 5 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
WriteAttributeValue("", 132, Model.RequestImg, 132, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 150, "\"", 199, 2);
            WriteAttributeValue("", 156, "../../Content/ClaimImages/", 156, 26, true);
#nullable restore
#line 5 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
WriteAttributeValue("", 182, Model.RequestImg, 182, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-rel=\"lightbox\" alt=\"Eser\" style=\"max-width: 100%; height: auto;\" />\r\n</div>\r\n<div class=\"col-sm-4\" style=\"font-size:medium; text-align:left;margin-top: 5%;\">\r\n    <p id=\"title\"><label>Başlık: </label> ");
#nullable restore
#line 8 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p id=\"description\"><label>Açıklama: </label> ");
#nullable restore
#line 9 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
                                             Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p id=\"bidPrice\"><label>Teklif: </label> ");
#nullable restore
#line 10 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
                                        Write(Model.BidPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</p>    \r\n</div>\r\n<div class=\"col-sm-4\">\r\n    <h2>Çizim</h2>\r\n    <img id=\"aImg\"");
            BeginWriteAttribute("href", " href=\"", 641, "\"", 689, 2);
            WriteAttributeValue("", 648, "../../Content/ClaimImages/", 648, 26, true);
#nullable restore
#line 14 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
WriteAttributeValue("", 674, Model.MadedImg, 674, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 690, "\"", 737, 2);
            WriteAttributeValue("", 696, "../../Content/ClaimImages/", 696, 26, true);
#nullable restore
#line 14 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\_FinishDesireDetail.cshtml"
WriteAttributeValue("", 722, Model.MadedImg, 722, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-rel=\"lightbox\" alt=\"Eser\" style=\"max-width: 100%; height: auto;\" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DesireDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
