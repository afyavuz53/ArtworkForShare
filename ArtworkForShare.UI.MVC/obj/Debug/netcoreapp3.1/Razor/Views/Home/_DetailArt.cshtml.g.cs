#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeff3b12ffac994b5e1eb5b53d693d632af98847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__DetailArt), @"mvc.1.0.view", @"/Views/Home/_DetailArt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeff3b12ffac994b5e1eb5b53d693d632af98847", @"/Views/Home/_DetailArt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__DetailArt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtworkDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArtistArtworks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row login-content \">\r\n        <div class=\"col-sm-6\">\r\n            <img");
            BeginWriteAttribute("href", " href=\"", 137, "\"", 175, 2);
            WriteAttributeValue("", 144, "../../Content/Images/", 144, 21, true);
#nullable restore
#line 6 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
WriteAttributeValue("", 165, Model.Url, 165, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 176, "\"", 213, 2);
            WriteAttributeValue("", 182, "../../Content/Images/", 182, 21, true);
#nullable restore
#line 6 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
WriteAttributeValue("", 203, Model.Url, 203, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-rel=\"lightbox\" alt=\"Eser\" style=\"max-width: 100%; height: auto;\" />\r\n        </div>\r\n        <div class=\"col-sm-6\" style=\"font-size:medium\">\r\n            <p><b>Eser Adı:</b> ");
#nullable restore
#line 9 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><b>Sanatçı:</b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff3b12ffac994b5e1eb5b53d693d632af988475143", async() => {
                WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
                                                                                                            Write(Model.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
                                                                                     WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
             if (string.IsNullOrWhiteSpace(Model.Description))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><b>Açıklama yok</b></p>\r\n");
#nullable restore
#line 14 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><b>Açıklama: ");
#nullable restore
#line 17 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n");
#nullable restore
#line 18 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Home\_DetailArt.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtworkDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
