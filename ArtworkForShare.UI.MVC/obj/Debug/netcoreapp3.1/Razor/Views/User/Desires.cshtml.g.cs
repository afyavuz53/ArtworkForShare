#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Desires.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a01621c93137d25e7bd11ed3b8a67960525995e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Desires), @"mvc.1.0.view", @"/Views/User/Desires.cshtml")]
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
#line 2 "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\_ViewImports.cshtml"
using ArtworkForShare.UI.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a01621c93137d25e7bd11ed3b8a67960525995e6", @"/Views/User/Desires.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Desires : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Desires.cshtml"
  
    ViewData["Title"] = "Desires";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
            <table class=""table table-responsive myTable"" >
                <thead>
                    <tr>
                        <th>Örnek Görsel</th>
                        <th>Başlık</th>
                        <th>Teklif</th>
                        <th>Durum</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id=""tableDesire"">
                    <!-- İstekler -->
                </tbody>
            </table>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n                $.ajax({\r\n                type: \"GET\",\r\n                    url: \"http://localhost:59959/api/desire/GetDesireForUser?id=\"+");
#nullable restore
#line 32 "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Desires.cshtml"
                                                                             Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
                    success: function (input) {
                    $.ajax({
                        type: ""POST"",                        
                        url: ""../../desire/LoadDesireTable"",
                        data: JSON.stringify(input),
                        contentType: ""application/json; charset=utf-8"",
                        success: function (response) {
                            $(""#tableDesire"").append(response)
                            GetLightBox()
                        }
                    })
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
