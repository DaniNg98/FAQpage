#pragma checksum "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2045e60d9f7a8b7be54438e73377c7f35caadd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2045e60d9f7a8b7be54438e73377c7f35caadd6", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0fcc4d1984afa2936125f77059d91b76c3c004", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SporsmalOgSvar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml"
  
    ViewBag.Title = "FAQ side";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"text-align:center\">\n<h1>Hva lurer du?</h1>\n</div>\n\n");
#nullable restore
#line 11 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml"
 foreach (var sporsmalOgSvar in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"accordion\">\n    <div class=\"card\">\n    <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 250, "\"", 273, 1);
#nullable restore
#line 15 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml"
WriteAttributeValue("", 255, sporsmalOgSvar.Id, 255, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center\">\n        <h5 class=\"mb-0\">\n        <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=\"#collapseTwo\" aria-expanded=\"false\" aria-controls=\"collapseTwo\">\n            \n                ");
#nullable restore
#line 19 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml"
           Write(sporsmalOgSvar.Sporsmal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n           \n        </button>\n        </h5>\n    </div>\n    <div id=\"collapseTwo\" class=\"collapse\" aria-labelledby=\"headingTwo\" data-parent=\"#accordion\">\n        <div class=\"card-body\">\n           \n                ");
#nullable restore
#line 27 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml"
           Write(sporsmalOgSvar.Svar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            \n        </div>\n    </div>\n    </div>\n</div>\n");
#nullable restore
#line 33 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/Details.cshtml"

}

#line default
#line hidden
#nullable disable
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