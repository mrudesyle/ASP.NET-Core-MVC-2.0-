#pragma checksum "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34360e6e7cbc17602f84e9cd75ac994473dd543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34360e6e7cbc17602f84e9cd75ac994473dd543", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(53, 101, true);
            WriteLiteral("\r\n<section class=\"jumbotron text-center\">\r\n\t<div class=\"container\">\r\n\t\t<h1 class=\"jumbotron-heading\">");
            EndContext();
            BeginContext(155, 11, false);
#line 8 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(166, 14, true);
            WriteLiteral("</h1>\r\n\t\t<h5>$");
            EndContext();
            BeginContext(181, 11, false);
#line 9 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
        Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(192, 102, true);
            WriteLiteral("</h5>\r\n\t</div>\r\n</section>\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-lg-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(294, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61184bc35bd743a39294a87d6bec4d47", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 304, "~/Images/", 304, 9, true);
#line 15 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 313, Model.image, 313, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 350, Model.Title, 350, 12, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 362, "image", 363, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(372, 44, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"col-lg-8\">\r\n\t\t\t<p>");
            EndContext();
            BeginContext(417, 17, false);
#line 18 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(434, 42, true);
            WriteLiteral("</p>\r\n\t\t\t<a class=\"btn btn-lg btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 476, "\"", 504, 2);
            WriteAttributeValue("", 483, "/home/order/", 483, 12, true);
#line 19 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\Details.cshtml"
WriteAttributeValue("", 495, Model.Id, 495, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(505, 41, true);
            WriteLiteral(">Buy</a>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
