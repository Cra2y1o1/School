#pragma checksum "D:\project\School\School\Views\Employer\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9052f7fe37fb350a25dab765e143eade80347765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_Show), @"mvc.1.0.view", @"/Views/Employer/Show.cshtml")]
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
#line 4 "D:\project\School\School\Views\Employer\Show.cshtml"
using School.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project\School\School\Views\Employer\Show.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9052f7fe37fb350a25dab765e143eade80347765", @"/Views/Employer/Show.cshtml")]
    public class Views_Employer_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\project\School\School\Views\Employer\Show.cshtml"
  
    ViewBag.Title = "Сотрудники";
    Layout = "~/Views/_LayoutClient.cshtml";
    Person I = AccountController.current;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""parents-conroll to-animate"">
    <div class=""table-element"">
        <table class=""table-element-parents"">
            <tr>
                <th>ID</th>
                <th>Фамилия</th>
                <th>Имя</th>
                <th>Отчество</th>
                <th>День рождения</th>
                <th>Номер телефона</th>
                <th>E-mail</th>
                <th>Должность</th>
            </tr>
");
#nullable restore
#line 25 "D:\project\School\School\Views\Employer\Show.cshtml"
             foreach (var p in EmployerController.Employers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "D:\project\School\School\Views\Employer\Show.cshtml"
                   Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\project\School\School\Views\Employer\Show.cshtml"
                   Write(p.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\project\School\School\Views\Employer\Show.cshtml"
                   Write(p.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\project\School\School\Views\Employer\Show.cshtml"
                   Write(p.patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\project\School\School\Views\Employer\Show.cshtml"
                   Write(p.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1076, "\"", 1096, 2);
            WriteAttributeValue("", 1083, "tel:", 1083, 4, true);
#nullable restore
#line 33 "D:\project\School\School\Views\Employer\Show.cshtml"
WriteAttributeValue("", 1087, p.number, 1087, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "D:\project\School\School\Views\Employer\Show.cshtml"
                                           Write(p.number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1144, "\"", 1166, 2);
            WriteAttributeValue("", 1151, "mailto:", 1151, 7, true);
#nullable restore
#line 34 "D:\project\School\School\Views\Employer\Show.cshtml"
WriteAttributeValue("", 1158, p.email, 1158, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\project\School\School\Views\Employer\Show.cshtml"
                                             Write(p.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 35 "D:\project\School\School\Views\Employer\Show.cshtml"
                   Write(p.fullPosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\project\School\School\Views\Employer\Show.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>
    </div>
    <div class=""cotrollTable"">
        <form action=""getEmployers"" method=""post"">
            <input class=""simpleText"" name=""LastName"" type=""text"" placeholder=""Фамилия"">
            <input class=""simpleText"" name=""FirstName"" type=""text"" placeholder=""Имя"">
            <input class=""simpleText"" name=""Patronymic"" type=""text"" placeholder=""Отчество"">
            <input class=""simpleText"" name=""phone"" type=""text"" placeholder=""Номер телефона"">
            <input class=""simpleText"" name=""FullPosition"" type=""text"" placeholder=""Должность"">
            <div class=""submit"">
                <input type=""submit"" value=""Поиск"">
            </div>
        </form>

    </div>
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
