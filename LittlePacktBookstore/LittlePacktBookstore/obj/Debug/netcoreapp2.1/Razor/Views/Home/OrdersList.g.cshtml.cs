#pragma checksum "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0ab630e820ba94c57361a2be34367398f3ec5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrdersList), @"mvc.1.0.view", @"/Views/Home/OrdersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OrdersList.cshtml", typeof(AspNetCore.Views_Home_OrdersList))]
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
#line 1 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.ViewModels;

#line default
#line hidden
#line 2 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\_ViewImports.cshtml"
using LittlePacktBookstore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0ab630e820ba94c57361a2be34367398f3ec5a", @"/Views/Home/OrdersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrdersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LittlePacktBookstore.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
  
    ViewData["Title"] = "OrdersList";

#line default
#line hidden
            BeginContext(103, 34, true);
            WriteLiteral("\r\n<h2>OrdersList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(137, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a04bc5113c2c45d7889a6769f4441cca", async() => {
                BeginContext(160, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 100, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(275, 38, false);
#line 16 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(313, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(381, 42, false);
#line 19 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
            EndContext();
            BeginContext(423, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(491, 46, false);
#line 22 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(537, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(605, 42, false);
#line 25 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(647, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(715, 40, false);
#line 28 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(755, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(823, 41, false);
#line 31 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(864, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(932, 43, false);
#line 34 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(975, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1043, 39, false);
#line 37 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1150, 41, false);
#line 40 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1259, 41, false);
#line 43 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 90, true);
            WriteLiteral("\r\n                </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1422, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1471, 37, false);
#line 52 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1564, 41, false);
#line 55 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.BookId));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1661, 45, false);
#line 58 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1762, 41, false);
#line 61 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1859, 39, false);
#line 64 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1954, 40, false);
#line 67 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2050, 42, false);
#line 70 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2092, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2148, 38, false);
#line 73 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2242, 40, false);
#line 76 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2338, 40, false);
#line 79 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2434, 65, false);
#line 82 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2499, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2520, 71, false);
#line 83 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2591, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2612, 69, false);
#line 84 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2681, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\OrdersList.cshtml"
}

#line default
#line hidden
            BeginContext(2720, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LittlePacktBookstore.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
