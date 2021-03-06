#pragma checksum "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe86de983af629a683c0b5bf88677c54784851cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
#line 1 "D:\Senior Project\BartenderApp\Views\_ViewImports.cshtml"
using BartenderApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Senior Project\BartenderApp\Views\_ViewImports.cshtml"
using BartenderApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe86de983af629a683c0b5bf88677c54784851cd", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8a9299c52128077241df8014c4e820aa2ac15c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BartenderApp.Models.Drink>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Menu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe86de983af629a683c0b5bf88677c54784851cd3433", async() => {
                WriteLiteral("\r\n    <title>Drink Menu</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe86de983af629a683c0b5bf88677c54784851cd4432", async() => {
                WriteLiteral("\r\n    <h1>Drink Menu</h1>\r\n    <p class=\"text-danger\">");
#nullable restore
#line 14 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
                      Write(TempData["error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
               Write(Html.DisplayNameFor(model => model.drinkName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
               Write(Html.DisplayNameFor(model => model.drinkDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
               Write(Html.DisplayNameFor(model => model.drinkPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
                   Write(Html.DisplayFor(modelItem => item.drinkName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
                   Write(Html.DisplayFor(modelItem => item.drinkDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $");
#nullable restore
#line 41 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
                    Write(Html.DisplayFor(modelItem => item.drinkPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
                   Write(Html.ActionLink("Add to Order", "addToOrder", new { id = item.id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "D:\Senior Project\BartenderApp\Views\Home\Menu.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BartenderApp.Models.Drink>> Html { get; private set; }
    }
}
#pragma warning restore 1591
