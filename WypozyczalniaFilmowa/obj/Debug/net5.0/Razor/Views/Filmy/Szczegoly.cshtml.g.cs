#pragma checksum "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca7b6a03acff450f2f1a46287b76ea6ecef124f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Szczegoly), @"mvc.1.0.view", @"/Views/Filmy/Szczegoly.cshtml")]
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
#line 1 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\_ViewImports.cshtml"
using WypozyczalniaFilmowa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\_ViewImports.cshtml"
using WypozyczalniaFilmowa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7b6a03acff450f2f1a46287b76ea6ecef124f", @"/Views/Filmy/Szczegoly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f895119732e295865809f5e97ea642b6807dabe", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmy_Szczegoly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aca7b6a03acff450f2f1a46287b76ea6ecef124f4182", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 69, "\"", 155, 4);
            WriteAttributeValue("", 79, "window.location.href", 79, 20, true);
            WriteAttributeValue(" ", 99, "=\'", 100, 3, true);
#nullable restore
#line 3 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
WriteAttributeValue("", 102, Url.Action("EdytujFilm","Filmy", new {id=Model.Id}), 102, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 154, "\'", 154, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edytuj</button>\r\n<table>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 7 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
       Write(Model.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <ul>\r\n                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aca7b6a03acff450f2f1a46287b76ea6ecef124f6338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 332, "~/plakaty/", 332, 10, true);
#nullable restore
#line 12 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
AddHtmlAttributeValue("", 342, Model.Plakat, 342, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 15 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
               Write(Model.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 18 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
               Write(Model.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 21 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
               Write(Model.DataDodania);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 24 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szczegoly.cshtml"
               Write(Model.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
