#pragma checksum "D:\project\School\School\Views\Client\Parents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "995c2f2d8814aa2ca2684ad3179f2f687e7e2374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Parents), @"mvc.1.0.view", @"/Views/Client/Parents.cshtml")]
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
#line 4 "D:\project\School\School\Views\Client\Parents.cshtml"
using School.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project\School\School\Views\Client\Parents.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995c2f2d8814aa2ca2684ad3179f2f687e7e2374", @"/Views/Client/Parents.cshtml")]
    public class Views_Client_Parents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\project\School\School\Views\Client\Parents.cshtml"
  
    ViewBag.Title = "Родители";
    Layout = "~/Views/_LayoutClient.cshtml";
    WorkWithDB workWithDB = new WorkWithDB();
    List<Person> Parents = ClientController.FindedParents;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""parents-conroll to-animate"">
    <div class=""table-element"">
        <table class=""table-element-parents"">
            <tr>
                <th>Фамилия</th>
                <th>Имя</th>
                <th>Отчество</th>
                <th>Пол</th>
                <th>День рождения</th>
                <th>Номер телефона</th>
                <th>E-mail</th>
                <th>ID ребенка</th>
                <th>ФИО ребенка</th>
                <th>Класс</th>
            </tr>
");
#nullable restore
#line 28 "D:\project\School\School\Views\Client\Parents.cshtml"
             foreach (var p in Parents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1135, "\"", 1155, 2);
            WriteAttributeValue("", 1142, "tel:", 1142, 4, true);
#nullable restore
#line 36 "D:\project\School\School\Views\Client\Parents.cshtml"
WriteAttributeValue("", 1146, p.number, 1146, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\project\School\School\Views\Client\Parents.cshtml"
                                   Write(p.number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1217, 2);
            WriteAttributeValue("", 1202, "mailto:", 1202, 7, true);
#nullable restore
#line 37 "D:\project\School\School\Views\Client\Parents.cshtml"
WriteAttributeValue("", 1209, p.email, 1209, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "D:\project\School\School\Views\Client\Parents.cshtml"
                                     Write(p.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 38 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.child.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.child.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "D:\project\School\School\Views\Client\Parents.cshtml"
                             Write(p.child.name[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "D:\project\School\School\Views\Client\Parents.cshtml"
                                                    if (!p.child.patronymic.Equals(""))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.child.patronymic[0]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\project\School\School\Views\Client\Parents.cshtml"
                                      
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "D:\project\School\School\Views\Client\Parents.cshtml"
           Write(p.child.ScClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\project\School\School\Views\Client\Parents.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>
    </div>
    <div class=""cotrollTable"">
        <form action=""getFindedParent"">
            <input class=""simpleText"" name=""LastName"" type=""text"" placeholder=""Фамилия"">
            <input class=""simpleText"" name=""FirstName"" type=""text"" placeholder=""Имя"">
            <input class=""simpleText"" name=""Patronymic"" type=""text"" placeholder=""Отчество"">
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
