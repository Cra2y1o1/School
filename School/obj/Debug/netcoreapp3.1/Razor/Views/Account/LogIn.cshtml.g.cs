#pragma checksum "C:\Users\crazy\Desktop\School\School\Views\Account\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed8832df220901dfd02a2f7f953a218c4f08c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LogIn), @"mvc.1.0.view", @"/Views/Account/LogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed8832df220901dfd02a2f7f953a218c4f08c8a", @"/Views/Account/LogIn.cshtml")]
    public class Views_Account_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\crazy\Desktop\School\School\Views\Account\LogIn.cshtml"
  
    ViewBag.Title = "Вход";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""shadow-forms"">
        <div class=""message warning"">
            <div class=""login-head"">
                <div class=""alert-close""> </div>
                <h2>Вход в аккаунт</h2>
            </div>
            <div class=""sub-head"">
                <h3>Your almost done ! One more step</h3>
                <img src=""images/bbl.png""");
            BeginWriteAttribute("alt", " alt=\"", 557, "\"", 563, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <form action =""Verify"" method=""post"">
                <input name=""username"" type=""text"" class=""text"" value=""Логин"" onfocus=""this.value = '';"" onblur=""if (this.value == '') {this.value = 'Логин';}"">
                <input name=""password"" type=""password"" value=""Пароль"" onfocus=""this.value = '';"" onblur=""if (this.value == '') {this.value = 'Пароль';}"">
                <div class=""p-container"">
                    <label class=""checkbox""><input type=""checkbox"" name=""checkbox"" checked><i></i>Remember Me</label>
                    <h6><a href=""#"">Забыли пароль?</a> </h6>
                    <div class=""clear""> </div>
                </div>
                <div class=""submit"">
                    <input type=""submit"" onclick=""myFunction()"" value=""LOG IN"">
                </div>
                <span> </span>
            </form>

        </div>
        <script>
			$(document).ready(function () {
				$('.popup-with-zoom-anim').magnificPopup({
					type: 'inline'");
            WriteLiteral(@",
					fixedContentPos: false,
					fixedBgPos: true,
					overflowY: 'auto',
					closeBtnInside: true,
					preloader: false,
					midClick: true,
					removalDelay: 300,
					mainClass: 'my-mfp-zoom-in'
				});

			});
        </script>
    </div>

    <div class=""clear""> </div>
    </div>

    </div>
    </div>
    
");
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
