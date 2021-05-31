#pragma checksum "D:\project\School\School\Views\Employer\UpdatePosition.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51cf89e1c5436ba57c2f0e9aa86c336ff650d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_UpdatePosition), @"mvc.1.0.view", @"/Views/Employer/UpdatePosition.cshtml")]
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
#line 4 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51cf89e1c5436ba57c2f0e9aa86c336ff650d5a", @"/Views/Employer/UpdatePosition.cshtml")]
    public class Views_Employer_UpdatePosition : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
  
    ViewBag.Title = "Редактирование должностей";
    Layout = "~/Views/_LayoutClient.cshtml";
    string access = "disabled";
    if(AccountController.current.level == 7)
    {
        access = "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""parents-conroll to-animate"">
    <div class=""table-element"">
        <table class=""table-element-parents"">
            <tr>
                <th>ID</th>
                <th>ФИО</th>
                <th>День рождения</th>
                <th>Номер телефона</th>
                <th>Основная должность</th>
                <th>Полная должность</th>
                <th>Уровень доступа</th>
            </tr>
");
#nullable restore
#line 26 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
             foreach (var p in EmployerController.Employers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 29 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                   Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        ");
#nullable restore
#line 31 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                   Write(p.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                               Write(p.name[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                                                if (!p.patronymic.Equals(""))
                        {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
               Write(p.patronymic[0]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                                    ;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>");
#nullable restore
#line 36 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                   Write(p.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1192, "\"", 1212, 2);
            WriteAttributeValue("", 1199, "tel:", 1199, 4, true);
#nullable restore
#line 37 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
WriteAttributeValue("", 1203, p.number, 1203, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                                           Write(p.number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                    <td>Исправлю</td>\n                    <td>");
#nullable restore
#line 39 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                   Write(p.fullPosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 40 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                   Write(p.level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 42 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>

    </div>
    <div class=""cotrollTable"">
        <div>
            <form action=""getEmployers2"" method=""post"">
                <input class=""simpleText"" name=""id"" type=""number"" min=""1"" placeholder=""id"">
                <input class=""simpleText"" name=""LastName"" type=""text"" placeholder=""Фамилия"">
                <input class=""simpleText"" name=""phone"" type=""text"" placeholder=""Номер телефона"">
                <input class=""simpleText"" name=""FullPosition"" type=""text"" placeholder=""Должность"">
                <div class=""submit"">
                    <input type=""submit"" value=""Поиск"">
                </div>
            </form>
        </div>
        <div>
            <form action=""updatePosition"" method=""post"">
                <input class=""simpleText"" name=""id"" type=""text"" placeholder=""ID Сотрудника"" required>
                <select class=""simpleComboBox"" name=""idPosition"" title=""Основная должность"" required>
");
#nullable restore
#line 63 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                     foreach (var op in EmployerController.Positions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 2439, "\"", 2453, 1);
#nullable restore
#line 65 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
WriteAttributeValue("", 2447, op.id, 2447, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                              Write(op.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>");
#nullable restore
#line 65 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\n                <input class=\"simpleText\" name=\"position\" type=\"text\" placeholder=\"Полная должность\" required>\n                <input class=\"simpleText\" name=\"level\" type=\"number\" placeholder=\"Уровень доступа (необзязательно)\" ");
#nullable restore
#line 68 "D:\project\School\School\Views\Employer\UpdatePosition.cshtml"
                                                                                                               Write(access);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n                <div class=\"submit\">\n                    <input type=\"submit\" value=\"Изменить\">\n                </div>\n            </form>\n        </div>\n    </div>\n</div>");
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
