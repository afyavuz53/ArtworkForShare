#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\AddArtwork.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63984beeccb5161a7bab9a670a893c9d4042786c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AddArtwork), @"mvc.1.0.view", @"/Views/User/AddArtwork.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63984beeccb5161a7bab9a670a893c9d4042786c", @"/Views/User/AddArtwork.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AddArtwork : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\User\AddArtwork.cshtml"
  
    ViewData["Title"] = "AddArtwork";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 col-md-offset-3 col-sm-12\">\r\n            <div class=\"login-content\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63984beeccb5161a7bab9a670a893c9d4042786c4567", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                    <div class=""myArtworkImg"">
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
                                    </div>
                                </div>
           ");
                WriteLiteral("                 </div>\r\n                        </div>\r\n                    </div>\r\n");
                WriteLiteral(@"                    <div class=""templatemo_form"">
                        <label class=""myLabel"">*Eseriniz</label>
                        <input name=""Image"" id=""imageFile"" type=""file"" class=""form-control"" onchange=""UpdateImg()"" onclick=""ClearAlert()"">
                    </div>
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">*Eserin Adı</label>
                        <input id=""Name"" type=""text"" class=""form-control"" placeholder=""*Eserin Adı"" onclick=""ClearAlert()"">
                    </div>
                    <div class=""templatemo_form"">
                        <label class=""myLabel"">Açıklama</label>
                        <input id=""Description"" type=""text"" class=""form-control"" placeholder=""Açıklama"" onclick=""ClearAlert()"">
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
                        <button id=""btnAdd"" class=""eBtn eBtnBack"">
                            <span></span>
                            <span></span>
                            <span></span>
                            <span></span>
                            Ekle
                        </button>
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
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            GetLightBox()
        })
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
                    image2.href = adres
                }
                veri.readAsDataURL(resim.files[0]);//veri okuma
            }
        }
        $(""#btnAdd"").click(function () {
            var formData = new FormData();            
            formData.appen");
                WriteLiteral(@"d('file', $('#imageFile')[0].files[0])
            $.ajax({
                type: ""POST"",
                url: ""AddImage"",
                data: formData,
                dataType: ""json"",
                processData: false,
                contentType: false,
                success: function (response) {
                    var veri = {
                        Name: $(""#Name"").val(),
                        Description: $(""#Description"").val(),
                        Url: response.veriUrl,
                        UserId: response.userId
                    }                    
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:59959/api/Artwork/AddArtwork"",
                        data: JSON.stringify(veri),
                        contentType: ""application/json; charset=UTF-8"",
                        success: function (result) {
                            if (result.check == true) {
                                $(""#");
                WriteLiteral(@"alert"").html(""<div class='alert alert-success' role='alert'>"" + result.message + ""</div>"")
                            } else {
                                $(""#alert"").html(""<div class='alert alert-danger' role='alert'>"" + result.message + ""</div>"")
                            }
                            $(""#imageFile"").val("""")
                            $(""#Name"").val("""")
                            $(""#Description"").val("""")
                            var image1 = document.getElementById(""aImg1"");
                            var image2 = document.getElementById(""aImg2"");
                            image1.style.backgroundImage = ""url('../../Content/images/emptyTuval.jpg')"";//background
                            image2.href = ""../../Content/images/emptyTuval.jpg""
                        }
                    })
                }
            })            

        })
        function ClearAlert() {
            $(""#alert"").html("""")
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
