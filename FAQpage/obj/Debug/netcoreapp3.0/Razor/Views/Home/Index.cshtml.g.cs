#pragma checksum "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bff1dc0e1512a808bc01397724861543d7554888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "/Users/daninani/Projects/FAQpage/FAQpage/Views/_ViewImports.cshtml"
using FAQpage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daninani/Projects/FAQpage/FAQpage/Views/_ViewImports.cshtml"
using FAQpage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff1dc0e1512a808bc01397724861543d7554888", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0fcc4d1984afa2936125f77059d91b76c3c004", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SporsmalOgSvar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml"
  
    ViewBag.Title = "FAQ side";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table>\n    <tread>\n        <tr>\n            <th>ID</th>\n            <th>Spørsmål</th>\n            <th>Svar</th>\n        </tr>\n    </tread>\n    <tbody>\n");
#nullable restore
#line 16 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml"
         foreach (var sporsmalOgSvar in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 19 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml"
               Write(sporsmalOgSvar.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml"
               Write(sporsmalOgSvar.Sporsmal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml"
               Write(sporsmalOgSvar.Svar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 23 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <sricpt src=\"/js/site.js\"></sricpt>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SporsmalOgSvar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
