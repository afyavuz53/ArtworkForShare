#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\SendDesire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398c1e75f03e6fd4b3e89c08963d54f1555dbacb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desire_SendDesire), @"mvc.1.0.view", @"/Views/Desire/SendDesire.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398c1e75f03e6fd4b3e89c08963d54f1555dbacb", @"/Views/Desire/SendDesire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_Desire_SendDesire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\SendDesire.cshtml"
  
    ViewData["Title"] = "SendDesire";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 col-md-offset-3 col-sm-12\">\r\n            <div class=\"login-content\">\r\n                <div id=\"govde\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "398c1e75f03e6fd4b3e89c08963d54f1555dbacb4639", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                        <div class=""myArtworkImg"">
                            <div class=""hex col-sm-6"">
                                <div>
                                    <div class=""hexagon hexagon2 gallery-item"">
                                        <div class=""hexagon-in1"">
                                            <div class=""hexagon-in2"" id=""aImg1""
                                                 style=""
    background-image: url(../../Content/Images/emptyTuval.jpg);
        "">
                                                <div class=""overlay"">
                                                    <div id=""myLink"">
                                                        <a id=""aImg2"" href=""../../Content/Images/emptyTuval.jpg"" data-rel=""lightbox"" class=""fa fa-expand""></a>
                                                    </div>
                                                </div>
                                            </div>
                                        </d");
                WriteLiteral("iv>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
                WriteLiteral(@"                        <div class=""templatemo_form"">
                            <label class=""myLabel"">İstek atacağınız sanatçı</label>
                            <select id=""artistNV"" class=""form-control"" disabled>
                            </select>
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">İsteğinizin görseli</label>
                            <input name=""Image"" id=""imageFile"" type=""file"" class=""form-control"" onchange=""UpdateImg()"" onclick=""ClearAlert()"">
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">Başlık</label>
                            <input id=""Title"" type=""text"" class=""form-control"" placeholder=""İsteğinizin başlığı"" onclick=""ClearAlert()"">
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">Açıklama</label>
    ");
                WriteLiteral(@"                        <input id=""Description"" type=""text"" class=""form-control"" placeholder=""Açıklama"" onclick=""ClearAlert()"">
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">Teklifiniz</label>
                            <input id=""BidPrice"" type=""number"" class=""form-control"" placeholder=""0 ₺"" onclick=""ClearAlert()"">
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">*Tam Adınız</label>
                            <input id=""Fullname"" type=""text"" class=""form-control"" placeholder=""Adınız soyadınız"" onclick=""ClearAlert()"">
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">*E-mailiniz</label>
                            <input id=""eMail"" type=""email"" class=""form-control"" placeholder=""E-Mail"" onclick=""ClearAlert()"">
                        </di");
                WriteLiteral(@"v>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">*Telefon numaranız</label>
                            <input id=""PhoneNo"" type=""text"" class=""form-control"" onclick=""ClearAlert()"">
                        </div>
                        <div class=""templatemo_form"">
                            <label class=""myLabel"">*Adresiniz</label>
                            <input id=""Adress"" type=""text"" class=""form-control"" placeholder=""Kargo için"" onclick=""ClearAlert()"">
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
            WriteLiteral(@"
                    <div class=""eBtnZemin"">
                        <div class=""eBtnBody"">
                            <button id=""btnSend"" class=""eBtn eBtnBack"" onclick=""SendDesire()"">
                                <span></span>
                                <span></span>
                                <span></span>
                                <span></span>
                                İstek Gönder
                            </button>
                        </div>
                    </div>
                </div>
                <div id=""alert"">
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            GetLightBox()\r\n            var uid =");
#nullable restore
#line 96 "C:\Users\Ahmet Yavuz\Desktop\GitHubRepository\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Desire\SendDesire.cshtml"
                Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:59959/api/user/GetName?uid="" + uid,
                success: function (name) {
                    $(""#artistNV"").append(new Option(name,uid))
                }
            })
        })


        function SendDesire() {
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
                    if ($(""#BidPrice"").val() == '') {
                        var price = 0
                    } else {
                        var price = $(""#BidPrice"").val()
                    }
                    var Input = {
                        Fullname: $(""#Fullname"").val(),
              ");
                WriteLiteral(@"          EMail: $(""#eMail"").val(),
                        Adress: $(""#Adress"").val(),
                        Phone: $(""#PhoneNo"").val(),
                        Title: $(""#Title"").val(),
                        Description: $(""#Description"").val(),
                        RequestedImgUrl: newName.imgUrl,
                        BidPrice: parseFloat(price),
                        UserID: parseInt($(""#artistNV"").val())
                    }
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:59959/api/Desire/AddDesire"",
                        data: JSON.stringify(Input),
                        contentType: ""application/json; charset=UTF-8"",
                        success: function (response) {
                            console.log(response)
                            if (response.check == true) {
                                $(""#alert"").html(""<div class='alert alert-success' role='alert'>"" + response.message + ""</div>"")");
                WriteLiteral(@"
                                $(""#govde"").hide()
                            } else {
                                $(""#alert"").html(""<div class='alert alert-danger' role='alert'>"" + response.message + ""</div>"")
                            }
                        }
                    })
                }
            })
        }

        function UpdateImg() {
            var resim = document.getElementById(""imageFile"");
            var image1 = document.getElementById(""aImg1"");
            var image2 = document.getElementById(""aImg2"");
            if (resim.files && resim.files[0]) {
                var veri = new FileReader();//veri okuma apisi başlatıyoruz.

                veri.onload = function () {//altta readAsDataURL verileri okuyoruz.O okuma tamamladığın da

                    var adres = veri.result;//veriyi al
                    //$(""#pImg"").attr(""src"", adres)
                    image1.style.backgroundImage = ""url('"" + adres + ""')"";//background
                    i");
                WriteLiteral("mage2.href = adres\r\n                }\r\n                veri.readAsDataURL(resim.files[0]);//veri okuma\r\n            }\r\n\r\n        }\r\n\r\n        function ClearAlert() {\r\n            $(\"#alert\").html(\"\")\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
