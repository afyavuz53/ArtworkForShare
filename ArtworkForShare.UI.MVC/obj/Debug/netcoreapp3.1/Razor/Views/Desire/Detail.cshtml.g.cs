#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3913735980b961a89f8004996dced96d91a4296a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desire_Detail), @"mvc.1.0.view", @"/Views/Desire/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3913735980b961a89f8004996dced96d91a4296a", @"/Views/Desire/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_Desire_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "desires", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"col-lg-offset-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3913735980b961a89f8004996dced96d91a4296a3867", async() => {
                WriteLiteral("İstekler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(">Detay</p>\r\n<div class=\"container\">\r\n    <div class=\"row login-content \" id=\"desireDetail\">\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            var id=");
#nullable restore
#line 15 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\Detail.cshtml"
              Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
             $.ajax({
                 type: ""GET"",
                 url: ""http://localhost:59959/api/desire/GetDetailById?id=""+id,
                 success: function (result) {
                     $.ajax({
                         type: ""POST"",
                         url: ""../GetDesireDetail"",
                         data: JSON.stringify(result),
                         contentType: ""application/json; charset=utf-8"",
                         success: function (response) {
                             $(""#desireDetail"").html(response)
                         }
                     })
                 }
             })
            GetLightBox()
        })

        function UpdateImg() {
            var resim = document.getElementById(""imageFile"");
            var image = document.getElementById(""aImg"");

            if (resim.files && resim.files[0]) {
                var veri = new FileReader();//veri okuma apisi başlatıyoruz.

                veri.onload = function () {//altt");
                WriteLiteral(@"a readAsDataURL verileri okuyoruz.O okuma tamamladığın da

                    var adres = veri.result;//veriyi al
                    //$(""#pImg"").attr(""src"", adres)
                    image.href = adres;//background
                    image.src=adres

                }
                veri.readAsDataURL(resim.files[0]);//veri okuma
            }

        }

        function ClearAlert() {
            $(""#alert"").html("""")
        }

        function BtnAccept() {
            var id=");
#nullable restore
#line 59 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\Detail.cshtml"
              Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            var formData = new FormData();
            formData.append('file', $('#imageFile')[0].files[0])
            $.ajax({
                type: 'POST',
                url: '../AddImage',
                data: formData,
                dataType: ""json"",
                processData: false,
                contentType: false,
                success: function (newName) {
                    //newName.imgUrl
                    $.ajax({
                        type: ""GET"",
                        url: ""http://localhost:59959/api/Desire/UpdateDesire?name="" + newName.imgUrl+""&dId=""+id,
                        success: function (response) {
                            if (response.check == true) {
                                $(""#alert"").html(""<div class='alert alert-success' role='alert'>"" + response.message + ""</div>"")
                                location.reload();
                            } else {
                                $(""#alert"").html(""<div class='alert alert-dan");
                WriteLiteral(@"ger' role='alert'>"" + response.message + ""</div>"")
                            }
                        }
                    })
                }
            })
        }

        function BtnCancel() {
            var check = confirm(""Emin misiniz?"")
            if (check) {
                var id=");
#nullable restore
#line 90 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\Detail.cshtml"
                  Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                $.ajax({
                    type: ""GET"",
                    url: ""http://localhost:59959/api/Desire/RefuseDesire?dId=""+id,
                    success: function () {
                        location.reload();
                    }
                })
            }
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
