#pragma checksum "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074964c37262df7b1ae9f2a2954a98f196fe692f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Szukaj), @"mvc.1.0.view", @"/Views/Filmy/Szukaj.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"074964c37262df7b1ae9f2a2954a98f196fe692f", @"/Views/Filmy/Szukaj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f895119732e295865809f5e97ea642b6807dabe", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmy_Szukaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WypozyczalniaFilmowa.Models.Film>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nSzukana fraza to: ");
#nullable restore
#line 3 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml"
             Write(ViewBag.Fraza);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Tytuł</th>\r\n            <th>Reżyser</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml"
         foreach (var film in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml"
               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 17 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml"
               Write(film.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 397, "\"", 461, 1);
#nullable restore
#line 19 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml"
WriteAttributeValue("", 404, Url.Action("Szczegoly","Filmy", new {idFilmu = film.Id}), 404, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Szczegóły</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\109\Source\Repos\WypozyczalniaFilmow4\WypozyczalniaFilmowa\Views\Filmy\Szukaj.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WypozyczalniaFilmowa.Models.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
