#pragma checksum "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e36c026339ddd65d36b83b4595448c214570f172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mark_show), @"mvc.1.0.view", @"/Views/Mark/show.cshtml")]
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
#line 4 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e36c026339ddd65d36b83b4595448c214570f172", @"/Views/Mark/show.cshtml")]
    public class Views_Mark_show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
  
    ViewBag.Title = "Успеваемость";
    Layout = "~/Views/_LayoutClient.cshtml";
    string Enable = "";
    string StudierValue = "";
    bool user = false;
    string sel = "selected";
    if (AccountController.current.level < 3) {
        Enable = "disabled";
        StudierValue = AccountController.current.level == 2 ? AccountController.current.child.lastName : AccountController.current.lastName;
        user = true;
    }



#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""parents-conroll to-animate"">
    <div class=""table-element"">
        <h1 class=""center-b24""><i class=""center-b24""></i></h1>
        <table class=""table-element-parents"">
            <tr>
                <th>Код оценки</th>
                <th>Класс</th>
                <th>Учащийся</th>
                <th>Предмет</th>
                <th>Оценка</th>
                <th>Дата оценки</th>
                <th>Преподаватель</th>
            </tr>
");
#nullable restore
#line 34 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
             foreach (var p in MarkController.marks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 37 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 38 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.ScClass.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 39 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.Studier.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                               Write(p.Studier.name[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 40 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.scObj.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 41 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 42 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.dateTime.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 43 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
           Write(p.Teacher.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                               Write(p.Teacher.name[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n        </tr>\n");
#nullable restore
#line 46 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n    <div class=\"cotrollTable\">\n        <form action=\"show\" method=\"post\">\n            <select class=\"simpleComboBox\" name=\"idClass\" title=\"Класс\" ");
#nullable restore
#line 51 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                                                   Write(Enable);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n                <option value=\"%\">Все</option>\n");
#nullable restore
#line 53 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                 foreach (var c in HomeController.classes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <option");
            BeginWriteAttribute("value", " value=\"", 1773, "\"", 1791, 1);
#nullable restore
#line 55 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
WriteAttributeValue("", 1781, c.idClass, 1781, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                if (user && AccountController.current.child.ScClass.Equals(c.Name)) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                                                                                 Write(sel);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                                                                                           ; }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n        ");
#nullable restore
#line 56 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
   Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </option>            ");
#nullable restore
#line 57 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\n            <select class=\"simpleComboBox\" name=\"idScObj\" title=\"Предмет\">\n                <option value=\"%\">Все</option>\n");
#nullable restore
#line 61 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                 foreach (var c in HomeController.scObjs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <option");
            BeginWriteAttribute("value", " value=\"", 2148, "\"", 2161, 1);
#nullable restore
#line 63 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
WriteAttributeValue("", 2156, c.id, 2156, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                     Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>");
#nullable restore
#line 63 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\n            <input class=\"simpleText\" name=\"dateMark\" type=\"date\" title=\"Дата оценки\">\n            <input class=\"simpleText\" name=\"Studier\" type=\"text\" placeholder=\"Фамилия учащегося\"");
            BeginWriteAttribute("value", " value=\"", 2386, "\"", 2407, 1);
#nullable restore
#line 66 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
WriteAttributeValue("", 2394, StudierValue, 2394, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                                                                                                  Write(Enable);

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
            <input class=""simpleText"" name=""Teacher"" type=""text"" placeholder=""Фамилия учителя"">
            <div class=""submit"">
                <input type=""submit"" value=""Поиск"">
            </div>
        </form>
        <div style=""display: flex; font-size: 14px;"">
            <a class=""a-to-button"" href=""#popup1"">Выставить оценку</a>
            <a class=""a-to-button"" href=""/"">Запрос на изменение оценки</a>
        </div>
    </div>
</div>

<div id=""popup1"" class=""overlay"">
    <div class=""popup"">
        <a class=""close"" href=""#"">&times;</a>
        <div class=""content"">
            <form action=""addmark"" method=""post"">
                <input class=""simpleText"" name=""idStudier"" type=""text"" placeholder=""ID ученика"">
                <select class=""simpleComboBox"" name=""idScObj"" title=""Предмет"">
");
#nullable restore
#line 86 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                     foreach (var c in HomeController.scObjs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 3331, "\"", 3344, 1);
#nullable restore
#line 88 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
WriteAttributeValue("", 3339, c.id, 3339, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                             Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>");
#nullable restore
#line 88 "C:\Users\crazy\Desktop\diplom\School\School\Views\Mark\show.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
                <input class=""simpleText"" name=""mark"" type=""number"" min=""0"" max=""10"" placeholder=""Оценка"">
                <input class=""simpleText"" name=""dateMark"" type=""date"" title=""Дата оценки"">
                <div class=""submit"">
                    <input type=""submit"" value=""Подтвердить"">
                </div>
            </form>
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
