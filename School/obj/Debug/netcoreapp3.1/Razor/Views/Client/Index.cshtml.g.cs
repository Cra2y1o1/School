#pragma checksum "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c85691163ec5fed961ef668d493c2a2fd7f3846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
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
#line 4 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
using School.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c85691163ec5fed961ef668d493c2a2fd7f3846", @"/Views/Client/Index.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
  
    ViewBag.Title = "Добро пожаловать!";
    Layout = "~/Views/_LayoutClient.cshtml";
    Person current = AccountController.current;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p class=\"text-index-p\">Добро пожаловать <b>");
#nullable restore
#line 12 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
                                       Write(current.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
                                                         Write(current.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
                                                                       Write(current.patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n<p class=\"text-index-p\">Вы ");
#nullable restore
#line 13 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
                            if (current.position.Equals("Сотрудник"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>");
#nullable restore
#line 15 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
  Write(current.fullPosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n");
#nullable restore
#line 16 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("       <b>");
#nullable restore
#line 19 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
     Write(current.position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n");
#nullable restore
#line 20 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\n<p class=\"text-index-p\">Ваш уровень доступа <b>");
#nullable restore
#line 22 "C:\Users\crazy\Desktop\diplom\School\School\Views\Client\Index.cshtml"
                                          Write(current.level);

#line default
#line hidden
#nullable disable
            WriteLiteral(" из 7</b></p>\n<p class=\"text-index-p\">Выберайте пункты меню для работы с web-приложением</p>");
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
