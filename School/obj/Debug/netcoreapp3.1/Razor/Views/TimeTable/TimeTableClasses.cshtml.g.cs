#pragma checksum "D:\project\School\School\Views\TimeTable\TimeTableClasses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fdd351e565e4e56db769edca058c75dafddda91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeTable_TimeTableClasses), @"mvc.1.0.view", @"/Views/TimeTable/TimeTableClasses.cshtml")]
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
#line 4 "D:\project\School\School\Views\TimeTable\TimeTableClasses.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdd351e565e4e56db769edca058c75dafddda91", @"/Views/TimeTable/TimeTableClasses.cshtml")]
    public class Views_TimeTable_TimeTableClasses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\project\School\School\Views\TimeTable\TimeTableClasses.cshtml"
  
    ViewBag.Title = "Расписание";
    Layout = "~/Views/_LayoutClient.cshtml";
    int number = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""width: 20%;"">
    <form action=""getFindedChild"" method=""post"">
        <input class=""simpleText"" name=""ClassName"" type=""text"" placeholder=""Класс"">
        <div class=""submit"">
            <input type=""submit"" value=""Поиск"">
        </div>
    </form>
</div>
<div class=""parents-conroll to-animate"">
    <div class=""table-element"">
        <table class=""table-element-parents"">
            <tr>
                <th>№ урока</th>
                <th>Понедельник</th>
                <th>Вторник</th>
                <th>Среда</th>
                <th>Четверг</th>
                <th>Пятница</th>
                <th>Суббота</th>
            </tr>

");
#nullable restore
#line 31 "D:\project\School\School\Views\TimeTable\TimeTableClasses.cshtml"
             foreach (var p in TimeTableController.choosedClass)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 34 "D:\project\School\School\Views\TimeTable\TimeTableClasses.cshtml"
                   Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\project\School\School\Views\TimeTable\TimeTableClasses.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
