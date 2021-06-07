#pragma checksum "D:\project\School\School\Views\_LayoutClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9307b6a31e7da36f5158c2b1969ca34d7a5877e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__LayoutClient), @"mvc.1.0.view", @"/Views/_LayoutClient.cshtml")]
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
#line 1 "D:\project\School\School\Views\_LayoutClient.cshtml"
using School.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\School\School\Views\_LayoutClient.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9307b6a31e7da36f5158c2b1969ca34d7a5877e3", @"/Views/_LayoutClient.cshtml")]
    public class Views__LayoutClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/popuo-box.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/style_menu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\project\School\School\Views\_LayoutClient.cshtml"
   
    Person I = AccountController.current;
    string avaPath = "/images/avatar.png";
    if (AccountController.current != null)
    {
        if (!AccountController.current.avatar.Equals(""))
        {
            avaPath = AccountController.current.avatar;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9307b6a31e7da36f5158c2b1969ca34d7a5877e35348", async() => {
                WriteLiteral("\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>");
#nullable restore
#line 19 "D:\project\School\School\Views\_LayoutClient.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9307b6a31e7da36f5158c2b1969ca34d7a5877e35968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9307b6a31e7da36f5158c2b1969ca34d7a5877e37231", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9307b6a31e7da36f5158c2b1969ca34d7a5877e38494", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9307b6a31e7da36f5158c2b1969ca34d7a5877e310372", async() => {
                WriteLiteral(@"
    <div class=""login-head"">
        <h2>ГУО ""Средняя школа №1 г. Полоцка""</h2>
    </div>  
    <div class=""main-menu"">
            <div class=""menu"">
                <ul class=""menu__list"">
                    <li>
                        <p class=""menu__link"">Родители</p>
                        <ul class=""sub-menu__list"">
                            <li>
                                <a href=""/Client/Parents"" class=""sub-menu__link"">Просмотр </a>
                            </li>
");
#nullable restore
#line 38 "D:\project\School\School\Views\_LayoutClient.cshtml"
                             if (I.level > 5)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                    <a href=\"/Client/ParentsConnections\" class=\"sub-menu__link\">Установка связей</a>\n                </li>");
#nullable restore
#line 42 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1569, "\"", 1576, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Учащиеся</a>\n                        <ul class=\"sub-menu__list\">\n                            <li>\n                                <a href=\"/Students/students\" class=\"sub-menu__link\">Просмотр</a>\n                            </li>\n");
#nullable restore
#line 51 "D:\project\School\School\Views\_LayoutClient.cshtml"
                             if (AccountController.current.level > 5)
                            {



#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                    <a href=\"/Students/SetClass\" class=\"sub-menu__link\">Установка класса</a>\n                </li>");
#nullable restore
#line 57 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2172, "\"", 2179, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Сотрудники</a>\n                        <ul class=\"sub-menu__list\">\n                            <li>\n                                <a href=\"/Employer/Show\" class=\"sub-menu__link\">Просмотр</a>\n                            </li>\n");
#nullable restore
#line 66 "D:\project\School\School\Views\_LayoutClient.cshtml"
                             if (AccountController.current.level >= 6)
                            {



#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                    <a href=\"/Employer/UpdatePosition\" class=\"sub-menu__link\">Редактирование должности</a>\n                </li>");
#nullable restore
#line 72 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2788, "\"", 2795, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Успеваемость</a>\n                        <ul class=\"sub-menu__list\">\n                            <li>\n                                <a href=\"/Mark/show\" class=\"sub-menu__link\">Просмотр</a>\n                            </li>\n");
#nullable restore
#line 81 "D:\project\School\School\Views\_LayoutClient.cshtml"
                             if (AccountController.current.level == 7)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                    <a href=\"/Mark/Editor\" class=\"sub-menu__link\">Редактировать</a>\n                </li>");
#nullable restore
#line 85 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3377, "\"", 3384, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""menu__link"">Расписание</a>
                        <ul class=""sub-menu__list"">
                            <li>
                                <a href=""/TimeTable/TimeTableClasses"" class=""sub-menu__link"">Просмотр</a>
                            </li>
");
#nullable restore
#line 94 "D:\project\School\School\Views\_LayoutClient.cshtml"
                             if (AccountController.current.level > 6)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                    <a href=\"/TimeTable/SetUpTimeTable\" class=\"sub-menu__link\">Редактировать</a>\n                </li>");
#nullable restore
#line 98 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </li>\n");
#nullable restore
#line 101 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     if (AccountController.current.level > 5)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\n                            <p class=\"menu__link\">Мероприятия</p>\n                            <ul class=\"sub-menu__list\">\n                                <li>\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4252, "\"", 4259, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Просмотр</a>\n                                </li>\n                                <li>\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4410, "\"", 4417, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Редактировать</a>\n                                </li>\n                                <li>\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4573, "\"", 4580, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Удалить</a>\n                                </li>\n                            </ul>\n                        </li>\n");
#nullable restore
#line 117 "D:\project\School\School\Views\_LayoutClient.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     if (AccountController.current.level == 7)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <li>
                    <p class=""menu__link"">Управление БД</p>
                    <ul class=""sub-menu__list"">
                        <li>
                            <a href=""/Account/delete"" class=""sub-menu__link"">Удаление аккаунта</a>
                        </li>
                        <li>
                            <a");
                BeginWriteAttribute("href", " href=\"", 5172, "\"", 5179, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Редактор аккаунтов</a>\n                        </li>\n                        <li>\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5316, "\"", 5323, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Таблицы</a>\n                        </li>\n                    </ul>\n                </li>");
#nullable restore
#line 133 "D:\project\School\School\Views\_LayoutClient.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </ul>
            </div>
            <div class=""AccountSet"">
                <ul class=""menu__list"">
                    <li>

                        <!--<a href="""" class=""menu__link"">-->
                        <div class=""list-login menu__link"">
                            <div style=""margin-right: 25px;"">
                                <img class=""ava""");
                BeginWriteAttribute("src", " src=\"", 5816, "\"", 5830, 1);
#nullable restore
#line 144 "D:\project\School\School\Views\_LayoutClient.cshtml"
WriteAttributeValue("", 5822, avaPath, 5822, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"64\" width=\"64\" />\n                            </div>\n                            <div>");
#nullable restore
#line 146 "D:\project\School\School\Views\_LayoutClient.cshtml"
                            Write(I.lastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 146 "D:\project\School\School\Views\_LayoutClient.cshtml"
                                        Write(I.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                        </div>
                        <!--</a>-->

                        <ul class=""sub-menu__list"">
                            <li>
                                <a href=""/Client/myAccount"" class=""sub-menu__link"">Управление аккаунтом</a>
                            </li>
                            <li>
                                <a href=""/Account/LogOut"" class=""sub-menu__link"">Выход</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    <div class=""render-body"">
        ");
#nullable restore
#line 163 "D:\project\School\School\Views\_LayoutClient.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div class=\"footer\">\n        <p>Copyright &copy; 2021  Все права защищены | <a href=\"/Client/Index\">Главная</a> | Сообщение разработчику <a href=\"mailto:dbschool.krigin.psu@gmail.com\">dbschool.krigin.psu@gmail.com</a></p>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
