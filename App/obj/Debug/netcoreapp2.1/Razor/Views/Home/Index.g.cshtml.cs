#pragma checksum "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de009cdaf5b7104e3608091078cada81036995f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 2 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\_ViewImports.cshtml"
using Interface;

#line default
#line hidden
#line 2 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\_ViewImports.cshtml"
using Interface.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de009cdaf5b7104e3608091078cada81036995f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b368d7fdfc315a624d4870e1dafedef0dfd8281", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Personagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 82, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2\">\r\n");
            EndContext();
#line 9 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
             foreach (var item in Model.Where(p => p.Time == 1))
            {

#line default
#line hidden
            BeginContext(220, 62, true);
            WriteLiteral("                <div class=\"column\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 282, "\"", 300, 1);
#line 12 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
WriteAttributeValue("", 288, item.Imagem, 288, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(301, 45, true);
            WriteLiteral(" height=\"80\" width=\"70\" data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 346, "\"", 364, 1);
#line 12 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
WriteAttributeValue("", 354, item.Nome, 354, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 29, true);
            WriteLiteral(" />\r\n                </div>\r\n");
            EndContext();
#line 14 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(409, 98, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-sm-8\">\r\n\r\n        </div>\r\n        <div class=\"col-sm-2\">\r\n");
            EndContext();
#line 20 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
             foreach (var item in Model.Where(p => p.Time == 2))
            {

#line default
#line hidden
            BeginContext(588, 62, true);
            WriteLiteral("                <div class=\"column\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 650, "\"", 668, 1);
#line 23 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
WriteAttributeValue("", 656, item.Imagem, 656, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(669, 46, true);
            WriteLiteral(" height=\"80\" width=\"70\"  data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 715, "\"", 733, 1);
#line 23 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
WriteAttributeValue("", 723, item.Nome, 723, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(734, 29, true);
            WriteLiteral(" />\r\n                </div>\r\n");
            EndContext();
#line 25 "C:\Users\Nelson Saraiva\source\repos\Marvel API\App\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(778, 142, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n$(document).ready(function(){\r\n  $(\'[data-toggle=\"tooltip\"]\').tooltip();\r\n});\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Personagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
