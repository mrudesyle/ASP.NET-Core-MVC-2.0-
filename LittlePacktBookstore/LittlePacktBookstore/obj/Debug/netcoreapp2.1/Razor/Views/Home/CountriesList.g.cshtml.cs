#pragma checksum "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33ca5b2da3c7e99a70ebbc3549ce28c8c55ea60e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CountriesList), @"mvc.1.0.view", @"/Views/Home/CountriesList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CountriesList.cshtml", typeof(AspNetCore.Views_Home_CountriesList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ca5b2da3c7e99a70ebbc3549ce28c8c55ea60e", @"/Views/Home/CountriesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CountriesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LittlePacktBookstore.Models.Country>>
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
  
    ViewData["Title"] = "CountriesList";

#line default
#line hidden
            BeginContext(108, 34, true);
            WriteLiteral("\r\n<h2>OrdersList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172904b5857849cf8c02a3ff994ee231", async() => {
                BeginContext(165, 10, true);
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
            BeginContext(179, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(272, 38, false);
#line 16 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(310, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(366, 40, false);
#line 19 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(406, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(541, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(602, 37, false);
#line 29 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(639, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(707, 39, false);
#line 32 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(746, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(814, 65, false);
#line 35 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(879, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(904, 71, false);
#line 36 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(975, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1000, 69, false);
#line 37 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\CountriesList.cshtml"
        }

#line default
#line hidden
            BeginContext(1124, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LittlePacktBookstore.Models.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
