#pragma checksum "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e43de65ad3c0d619e113d3f5f65234ef6139f0d"
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
#line 1 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
using School.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
using School.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e43de65ad3c0d619e113d3f5f65234ef6139f0d", @"/Views/_LayoutClient.cshtml")]
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
#line 3 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
   
    Person I = AccountController.current;
    string avaPath = "/images/avatar.png";
    if (!AccountController.current.avatar.Equals(""))
    {
        avaPath = AccountController.current.avatar;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e43de65ad3c0d619e113d3f5f65234ef6139f0d5368", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 17 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e43de65ad3c0d619e113d3f5f65234ef6139f0d6017", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e43de65ad3c0d619e113d3f5f65234ef6139f0d7282", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e43de65ad3c0d619e113d3f5f65234ef6139f0d8547", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e43de65ad3c0d619e113d3f5f65234ef6139f0d10429", async() => {
                WriteLiteral("\r\n    <div class=\"login-head\">\r\n        <h2>ГУО \"Средняя школа №1 г. Полоцка\"</h2>\r\n    </div>  \r\n    <div class=\"main-menu\">\r\n            <div class=\"menu\">\r\n                <ul class=\"menu__list\">\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 954, "\"", 961, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Родители</a>\r\n                        <ul class=\"sub-menu__list\">\r\n                            <li>\r\n                                <a href=\"/Client/Parents\" class=\"sub-menu__link\">Просмотр </a>\r\n                            </li>\r\n");
#nullable restore
#line 36 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
                             if (I.level > 5)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <a href=\"/Client/ParentsConnections\" class=\"sub-menu__link\">Установка связей</a>\r\n                                    </li>\r\n");
#nullable restore
#line 41 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
                                } 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1649, "\"", 1656, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Учащиеся</a>\r\n                        <ul class=\"sub-menu__list\">\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1812, "\"", 1819, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1967, "\"", 1974, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2164, "\"", 2171, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Сотрудники</a>\r\n                        <ul class=\"sub-menu__list\">\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2329, "\"", 2336, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2484, "\"", 2491, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2681, "\"", 2688, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Успеваемость</a>\r\n                        <ul class=\"sub-menu__list\">\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2848, "\"", 2855, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3003, "\"", 3010, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3200, "\"", 3207, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"menu__link\">Расписание</a>\r\n                        <ul class=\"sub-menu__list\">\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3365, "\"", 3372, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sub-menu__link\">Второй уровень</a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3520, "\"", 3527, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sub-menu__link"">Второй уровень</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""AccountSet"">
                <ul class=""menu__list"">
                    <li>

                        <!--<a href="""" class=""menu__link"">-->
                        <div class=""list-login menu__link"">
                            <div>
                                <img class=""ava""");
                BeginWriteAttribute("src", " src=\"", 4022, "\"", 4036, 1);
#nullable restore
#line 97 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
WriteAttributeValue("", 4028, avaPath, 4028, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"64\" width=\"64\" />\r\n                            </div>\r\n                            <div>");
#nullable restore
#line 99 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
                            Write(I.lastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 99 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
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
#line 116 "C:\Users\crazy\Desktop\diplom\School\School\Views\_LayoutClient.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <div class=""footer"">
        <p>Copyright &copy; 2021  Все права защищены | <a href=""/Client/Index"">Главная</a> | Сообщение разработчику <a href=""mailto:dbschool.krigin.psu@gmail.com"">dbschool.krigin.psu@gmail.com</a></p>
    </div>

");
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
            WriteLiteral("\r\n</html>\r\n");
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
