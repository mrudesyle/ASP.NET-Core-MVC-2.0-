#pragma checksum "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab700722a44ee51a06fa9ea78a5ccc2c41a63ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Carousel), @"mvc.1.0.view", @"/Views/Home/_Carousel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_Carousel.cshtml", typeof(AspNetCore.Views_Home__Carousel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab700722a44ee51a06fa9ea78a5ccc2c41a63ec", @"/Views/Home/_Carousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d92cb761646fb4d9f41c0d674984d9b6dc823bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Carousel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
  
	int count = 0;

#line default
#line hidden
            BeginContext(56, 336, true);
            WriteLiteral(@"<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
	<ol class=""carousel-indicators"">
		<li data-target=""#myCarousel"" data-slide-to=""0"" class=""""></li>
		<li data-target=""#myCarousel"" data-slide-to=""1"" class=""active""></li>
		<li data-target=""#myCarousel"" data-slide-to=""2""></li>
	</ol>
	<div class=""carousel-inner"">
");
            EndContext();
#line 13 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
         foreach (var item in Model)
		{



#line default
#line hidden
            BeginContext(433, 7, true);
            WriteLiteral("\t\t\t<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 440, "\"", 491, 2);
            WriteAttributeValue("", 448, "carousel-item", 448, 13, true);
#line 17 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
WriteAttributeValue(" ", 461, count == 0 ? "active" : "", 462, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(492, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 18 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
                 switch (count++)
				{
					case 0:

#line default
#line hidden
            BeginContext(539, 140, true);
            WriteLiteral("\t\t\t\t\t\t<img class=\"first-slide\" src=\"data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==\" alt=\"First slide\">\r\n");
            EndContext();
#line 22 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
						break;
					case 1:

#line default
#line hidden
            BeginContext(707, 142, true);
            WriteLiteral("\t\t\t\t\t\t<img class=\"second-slide\" src=\"data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==\" alt=\"Second slide\">\r\n");
            EndContext();
#line 25 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
						break;
					case 2:

#line default
#line hidden
            BeginContext(877, 140, true);
            WriteLiteral("\t\t\t\t\t\t<img class=\"third-slide\" src=\"data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==\" alt=\"Third slide\">\r\n");
            EndContext();
#line 28 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
						break;
				}

#line default
#line hidden
            BeginContext(1038, 115, true);
            WriteLiteral("\t\t\t\t<div class=\"container\">\r\n\t\t\t\t\t<div class=\"row\" style=\"padding-top:25px\">\r\n\t\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1153, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0437c7df81da4c61a4a673c4a92a57f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1163, "~/Images/", 1163, 9, true);
#line 33 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
AddHtmlAttributeValue("", 1172, item.ImageURL, 1172, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1229, 107, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-8\">\r\n\t\t\t\t\t\t\t<div class=\"carousel-caption text-left\">\r\n\t\t\t\t\t\t\t\t<h1>");
            EndContext();
            BeginContext(1337, 10, false);
#line 37 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 19, true);
            WriteLiteral(".</h1>\r\n\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(1367, 16, false);
#line 38 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1383, 54, true);
            WriteLiteral(" ...</p>\r\n\t\t\t\t\t\t\t\t<p><a class=\"btn btn-lg btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1437, "\"", 1466, 2);
            WriteAttributeValue("", 1444, "/home/details/", 1444, 14, true);
#line 39 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
WriteAttributeValue("", 1458, item.Id, 1458, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1467, 99, true);
            WriteLiteral(" role=\"button\">Read More</a></p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
            EndContext();
#line 45 "E:\OneDrive\React Apps\Packt Publishing\ASP.net core mvc\Section 1\01. Start\LittlePacktBookstore\LittlePacktBookstore\Views\Home\_Carousel.cshtml"
		}

#line default
#line hidden
            BeginContext(1571, 431, true);
            WriteLiteral(@"	</div>
	<a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
		<span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
		<span class=""sr-only"">Previous</span>
	</a>
	<a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
		<span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
		<span class=""sr-only"">Next</span>
	</a>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Carousel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
