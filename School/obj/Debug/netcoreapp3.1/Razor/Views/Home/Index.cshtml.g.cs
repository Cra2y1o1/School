#pragma checksum "D:\project\School\School\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87fc4b77a4b13f16ab306dd722d999a196353b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fc4b77a4b13f16ab306dd722d999a196353b89", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\project\School\School\Views\Home\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";
    ViewBag.Title = "Средняя школа №1 г. Полоцк";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""message warning"">
    <div class=""sub-head"">
        <h3>Данное приложение помогает:</h3>
        <ul>
            <li><h3>Учителям структурировать и знать все об интересующем классе/ученике </h3></li>
            <li><h3>Родители знают отметки, а так же видят и следят за поосещаемостью детей</h3></li>
            <li><h3>Учащиеся знают все свои отметки, домашние задания и актуальное расписание</h3></li>
            <li><h3>Администрация школы и Министерство знают текущее состояние и могут реагировать оперативнее.</h3></li>
        </ul>
    </div>
</div>
<div class=""choice"">
    <a class=""log"" href=""/Account/LogIn"">Вход</a>
    <a class=""log"" href=""/Account/CreateAccount"">Регистрация</a>
</div>");
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
