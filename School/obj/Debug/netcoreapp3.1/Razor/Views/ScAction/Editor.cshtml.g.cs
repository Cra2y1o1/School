#pragma checksum "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2661ce272127abcf0368366c2796bcb9acae38ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScAction_Editor), @"mvc.1.0.view", @"/Views/ScAction/Editor.cshtml")]
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
#line 1 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2661ce272127abcf0368366c2796bcb9acae38ab", @"/Views/ScAction/Editor.cshtml")]
    public class Views_ScAction_Editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
  
    ViewBag.Title = "Редактор мероприятий";
    Layout = "~/Views/_LayoutClient.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""parents-conroll to-animate"">
    <div class=""table-element"">
        <h1 class=""center-b24"">Мероприятия</h1>
        <table class=""to-table"">
            <tr>
                <th rowspan=""2"">Код мероприятия</th>
                <th rowspan=""2"">Мероприятие</th>
                <th rowspan=""2"">Место</th>
                <th rowspan=""2"">Дата</th>
                <th rowspan=""2"">Время</th>
                <th rowspan=""2"">Продолжительность</th>
                <th colspan=""4"">Участник</th>
            </tr>
            <tr>
                <th>ФИО</th>
                <th>Дата рождения</th>
                <th>Статус</th>
                <th>Роль</th>
            </tr>

");
#nullable restore
#line 37 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
             foreach (var a in ScActionController.actions)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr ");
#nullable restore
#line 40 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
       Write(Style(a.id));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n            <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1130, "\"", 1156, 1);
#nullable restore
#line 41 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
WriteAttributeValue("", 1140, a.persons.Count, 1140, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                      Write(a.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1184, "\"", 1210, 1);
#nullable restore
#line 42 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
WriteAttributeValue("", 1194, a.persons.Count, 1194, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                      Write(a.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1240, "\"", 1266, 1);
#nullable restore
#line 43 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
WriteAttributeValue("", 1250, a.persons.Count, 1250, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                      Write(a.place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1297, "\"", 1323, 1);
#nullable restore
#line 44 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
WriteAttributeValue("", 1307, a.persons.Count, 1307, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                      Write(a.dateTime.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1380, "\"", 1406, 1);
#nullable restore
#line 45 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
WriteAttributeValue("", 1390, a.persons.Count, 1390, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                      Write(a.dateTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1458, "\"", 1484, 1);
#nullable restore
#line 46 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
WriteAttributeValue("", 1468, a.persons.Count, 1468, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                      Write(a.length.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 47 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
           Write(a.persons[0].lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                  Write(a.persons[0].name[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 47 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                                         Write(a.persons[0].patronymic[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\n            <td>");
#nullable restore
#line 48 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
           Write(a.persons[0].birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 49 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
           Write(a.persons[0].position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 50 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
           Write(a.persons[0].roleForAction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 52 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                 foreach (var p in a.persons)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                     if (p.id.Equals(a.persons[0].id)) continue;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr ");
#nullable restore
#line 55 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                   Write(Style(a.id));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n                        <td>");
#nullable restore
#line 56 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                       Write(p.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                   Write(p.name[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 56 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                                               Write(p.patronymic[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\n                        <td>");
#nullable restore
#line 57 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                       Write(p.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 58 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                       Write(p.position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 59 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                       Write(p.roleForAction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 61 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
                 



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </table>\n    </div>\n    <div class=\"cotrollTable\">\n        <form action=\"ChangeActions\" method=\"post\">\n            <h3>");
#nullable restore
#line 71 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
           Write(ViewBag.ExMes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <input class=""simpleText"" id=""id"" name=""id"" type=""text"" placeholder=""id мероприятия (для изменения)"" onkeyup=""myFunction()"">
            <input class=""simpleText"" name=""ActionName"" type=""text"" placeholder=""Название"" required>
            <input class=""simpleDate"" name=""ActionDate"" type=""date"" placeholder=""Дата"" required><label class=""under-input""> - Дата мероприятия</label><br />
            <input class=""simpleText"" name=""ActionTime"" type=""text"" pattern=""([01]?[0-9]|2[0-3]):[0-5]{1,1}[0-9]{1,1}"" placeholder=""Время"" required>
            <input class=""simpleText"" name=""ActionLen"" type=""text"" pattern=""([01]?[0-9]|2[0-3]):[0-5]{1,1}[0-9]{1,1}"" placeholder=""Продолжительность"" required>
            <input class=""simpleText"" name=""ActionPlace"" type=""text"" placeholder=""Место"" required>

            <div class=""submit"">
                <input name=""submit"" id=""submit"" type=""submit"" value=""Добавить мепроприятие"">
            </div>
            <script>
                function myFunction() {
       ");
            WriteLiteral(@"             var x = document.getElementById(""submit"");
                    if (document.getElementById(""id"").value.length != 0) {
                        x.value = ""Изменить мероприятие"";
                    } else {
                        x.value = ""Добавить мероприятие"";
                    }
                }
            </script>
        </form>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\crazy\Desktop\diplom\School\School\Views\ScAction\Editor.cshtml"
            
    public string Style(int id)
    {
        string style = "style=background-color:#adadad;";
        if (id % 2 == 0)
        {
            style = "";
        }
        return style;
    }

#line default
#line hidden
#nullable disable
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
