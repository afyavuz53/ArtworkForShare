#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1dca607bc57331a9a1dc5e76a0b27f5a1db8c5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Update), @"mvc.1.0.view", @"/Views/User/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1dca607bc57331a9a1dc5e76a0b27f5a1db8c5d", @"/Views/User/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 col-md-offset-3 col-sm-12\">\r\n            <div class=\"login-content\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1dca607bc57331a9a1dc5e76a0b27f5a1db8c5d5160", async() => {
                WriteLiteral(@"
                    <div>
                        <div class=""myProfileImg"">
                            <div class=""myHexagon myHexagonteam gallery-item"">
                                <div class=""myHexagon-in1"">
                                    <div class=""myHexagon-in2"">
                                        <img class=""myImpHexa"" id=""pImg""");
                BeginWriteAttribute("src", " src=\"", 643, "\"", 691, 2);
                WriteAttributeValue("", 649, "../../Content/Images/", 649, 21, true);
#nullable restore
#line 16 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
WriteAttributeValue("", 670, Model.ProfilResmiUrl, 670, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""Profil Resmi"" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">Profil Resminiz(Tavsiye edilen boyut 200x230)</label>
                        <input name=""ProfilResmi"" id=""ProfilImg"" type=""file"" class=""form-control"" onchange=""UpdateImg()"">
                    </div>
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">*Adınız</label>
                        <input name=""FirstName"" type=""text"" class=""form-control"" placeholder=""*Adınız""");
                BeginWriteAttribute("value", " value=\"", 1417, "\"", 1441, 1);
#nullable restore
#line 28 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
WriteAttributeValue("", 1425, Model.FirstName, 1425, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"templatemo_form\">\r\n                        <label class=\"myLabel\">*Soyadınız</label>\r\n                        <input name=\"LastName\" type=\"text\" class=\"form-control\" placeholder=\"*Soyadınız\"");
                BeginWriteAttribute("value", " value=\"", 1695, "\"", 1718, 1);
#nullable restore
#line 32 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
WriteAttributeValue("", 1703, Model.LastName, 1703, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>                    
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">Telefon Numaranız</label>
                        <input name=""Phone"" type=""text"" class=""form-control"" placeholder=""Telefon Numaranız""");
                BeginWriteAttribute("value", " value=\"", 2003, "\"", 2023, 1);
#nullable restore
#line 36 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
WriteAttributeValue("", 2011, Model.Phone, 2011, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""eBtnZemin"">
                        <div class=""eBtnBody"">
                            <button type=""submit"" class=""eBtn eBtnBack"">
                                <span></span>
                                <span></span>
                                <span></span>
                                <span></span>
                                Güncelle
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div>\r\n");
#nullable restore
#line 51 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                     if (ViewContext.ViewBag.Message != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                       Write(ViewContext.ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 56 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container"" style=""margin-top:5%"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3 col-sm-12"">
            <div class=""login-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1dca607bc57331a9a1dc5e76a0b27f5a1db8c5d12005", async() => {
                WriteLiteral(@"
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">Eski Şifreniz</label>
                        <input name=""OldPassword"" type=""password"" class=""form-control"">
                    </div>
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">Yeni Şifreniz</label>
                        <input name=""NewPassword"" type=""password"" class=""form-control"">
                    </div>
                    <div class=""eBtnZemin"">
                        <div class=""eBtnBody"">
                            <button type=""submit"" class=""eBtn eBtnBack"">
                                <span></span>
                                <span></span>
                                <span></span>
                                <span></span>
                                Şifreyi Değiştir
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                     if (ViewContext.TempData["Check"] != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                         if (ViewContext.TempData["Check"].ToString() == "success")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-success\" role=\"alert\">\r\n                                ");
#nullable restore
#line 95 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                           Write(ViewContext.TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 97 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                         if (ViewContext.TempData["Message"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\">\r\n                                ");
#nullable restore
#line 104 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                           Write(ViewContext.TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 106 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\Update.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function UpdateImg() {
            var resim = document.getElementById(""ProfilImg"");
            var image = document.getElementById(""pImg"");
            if (resim.files && resim.files[0]) {
                var veri = new FileReader();//veri okuma apisi başlatıyoruz.

                veri.onload = function () {//altta readAsDataURL verileri okuyoruz.O okuma tamamladığın da

                    var adres = veri.result;//veriyi al
                    //$(""#pImg"").attr(""src"", adres)
                    image.src = adres
                }
                veri.readAsDataURL(resim.files[0]);//veri okuma
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
