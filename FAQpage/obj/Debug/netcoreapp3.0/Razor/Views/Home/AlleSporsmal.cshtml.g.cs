#pragma checksum "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d24f026f98ddaf9ecd876a9df2b0ef347789296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AlleSporsmal), @"mvc.1.0.view", @"/Views/Home/AlleSporsmal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d24f026f98ddaf9ecd876a9df2b0ef347789296", @"/Views/Home/AlleSporsmal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0fcc4d1984afa2936125f77059d91b76c3c004", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AlleSporsmal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SporsmalOgSvar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LagSporsmal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
  
    ViewBag.Title = "Spørsmål og svar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div style=""text-align:center; margin-bottom:50px; margin-top:50px"">
    <h1>Spørsmål Og Svar</h1>
</div>

<div style=""text-align:center; margin-bottom:50px; margin-top:20px"">
<h5>Velkommen til Finnreise's FAQ side. Her finner du spørsmål og svar relatert til vår nettside.</h5>
<h5>Dersom du ikke finner ditt spørsmål kan du sende inn et spørsmål til oss.</h5>
</div>

<div>
    <h3>Alle spørsmål</h3>
</div>

");
#nullable restore
#line 22 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
 foreach (var sporsmalOgSvar in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"accordion\">\n    <div class=\"card\">\n    <div class=\"card-header\" id=\"headingTwo\">\n        <h5 class=\"mb-0\">\n        <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=\"#h");
#nullable restore
#line 28 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
                                                                                 Write(sporsmalOgSvar.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 839, "\"", 876, 2);
            WriteAttributeValue("", 855, "h", 855, 1, true);
#nullable restore
#line 28 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
WriteAttributeValue("", 856, sporsmalOgSvar.Id, 856, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordion\">\n            ");
#nullable restore
#line 29 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
       Write(sporsmalOgSvar.Sporsmal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </button>\n        </h5>\n    </div>\n    <div");
            BeginWriteAttribute("id", " id=\"", 992, "\"", 1018, 2);
            WriteAttributeValue("", 997, "h", 997, 1, true);
#nullable restore
#line 33 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
WriteAttributeValue("", 998, sporsmalOgSvar.Id, 998, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingTwo\">\n        <div class=\"card-body\">\n            ");
#nullable restore
#line 35 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
       Write(sporsmalOgSvar.Svar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div style=""float:right"">
                <button type=""button"" class=""btn btn-sm btn-success""><i class=""fa fa-thumbs-up"" ng-click=""incrementLikes(technology)""></i></button>
                0
                <button type=""button"" class=""btn btn-sm btn-danger""><i class=""fa fa-thumbs-down"" ng-click=""incrementDislikes(technology)""></i></button>
                0
            </div>
        </div>
    </div>
    </div>
</div>
");
#nullable restore
#line 46 "/Users/daninani/Projects/FAQpage/FAQpage/Views/Home/AlleSporsmal.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""text-align:center; margin-top:120px; margin-left:20%; margin-right:20%"">
<h5>Fant du ikke spørsmålet ditt? Send inn ditt spørsmål til oss så svarer på ditt spørsmål så fort som mulig.</h5>
</div>

<div style=""text-align:center; margin-bottom:120px"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d24f026f98ddaf9ecd876a9df2b0ef3477892968033", async() => {
                WriteLiteral("Send inn et spørsmål her");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <sricpt src=\"/js/site.js\"></sricpt>\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISporsmalOgSvarRepository _sporsmalOgSvarRepository { get; private set; }
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
