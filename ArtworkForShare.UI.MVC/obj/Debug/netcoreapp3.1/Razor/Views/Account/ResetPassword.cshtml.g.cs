#pragma checksum "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Account\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb69b04e483a0738d1fb96d2cb28572ed8df3bc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPassword), @"mvc.1.0.view", @"/Views/Account/ResetPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb69b04e483a0738d1fb96d2cb28572ed8df3bc7", @"/Views/Account/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33b8e572470ad8acf3f640bbe966b609813fc65", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Account\ResetPassword.cshtml"
  
    ViewData["Title"] = "ResetPassword";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""atomMain"" id=""yukleniyor"">
        <div class=""atomBody"">
            <main class=""loadingMain"">
                <div class=""atom"">
                    <div class=""electron""></div>
                    <div class=""electron-alpha""></div>
                    <div class=""electron-omega""></div>
                </div>
            </main>
        </div>
    </div>
    <div class=""row"" id=""site"">
        <div class=""col-md-6 col-md-offset-3 col-sm-12"">
            <div class=""login-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb69b04e483a0738d1fb96d2cb28572ed8df3bc74352", async() => {
                WriteLiteral("\r\n                    <div class=\"templatemo_form\">\r\n                        <label class=\"myLabel\">Yeni Şifreniz</label>\r\n                        <input id=\"Password\" type=\"password\" class=\"form-control\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                        <button type=""submit"" class=""eBtn eBtnBack"" onclick=""ChangePassword()"">
                            <span></span>
                            <span></span>
                            <span></span>
                            <span></span>
                            Şifreyi Değiştir
                        </button>
                    </div>
                </div>
                <div id=""alert""></div>
                <div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#yukleniyor\').hide()\r\n        })\r\n\r\n        function ChangePassword() {\r\n            var uid =");
#nullable restore
#line 53 "C:\Users\Ahmet Yavuz\Desktop\ProjeOdevi\ArtworkForShare\ArtworkForShare.UI.MVC\Views\Account\ResetPassword.cshtml"
                Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            var pwd = $(""#Password"").val()
            $('#site').hide()
            $('#yukleniyor').show()
            $.ajax({
                url: ""http://localhost:59959/api/User/ChangePassword?id="" + uid + ""&pwd="" + pwd,
                type: ""GET"",
                success: function (response) {
                    if (response.check == true) {
                        $(""#alert"").html(""<div class='alert alert-success' role='alert'>"" + response.message + ""</div>"")
                        alert(""Şifre değiştirildi."")
                        window.location = ""http://localhost:51680/Account/login""
                    } else {
                        $(""#alert"").html(""<div class='alert alert-danger' role='alert'>"" + response.message + ""</div>"")
                        $('#site').show()
                        $('#yukleniyor').hide()
                    }
                }
            })
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