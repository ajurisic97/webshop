#pragma checksum "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cbf1d24b791c75f7c1475cf11301a97f86f0b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvodi_SviProizvodi), @"mvc.1.0.view", @"/Views/Proizvodi/SviProizvodi.cshtml")]
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
#line 1 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\_ViewImports.cshtml"
using WebShopAYuri;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\_ViewImports.cshtml"
using WebShopAYuri.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cbf1d24b791c75f7c1475cf11301a97f86f0b4", @"/Views/Proizvodi/SviProizvodi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e46486a1fa01ec0f980aa70aaaf38db21c25c14", @"/Views/_ViewImports.cshtml")]
    public class Views_Proizvodi_SviProizvodi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebShopAYuri.DbModels.Proizvod>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
  
    ViewData["Title"] = "SviProizvodi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SviProizvodi</h1>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayNameFor(model => model.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayNameFor(model => model.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayNameFor(model => model.Img));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayNameFor(model => model.Kategorija));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayFor(modelItem => item.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayFor(modelItem => item.Opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayFor(modelItem => item.Img));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kategorija.Idkategorija));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Proizvodi\SviProizvodi.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    axios.get('/api/proizvodi').then(response => console.log(response.data));

    function dodajSve(data) {
        var item = document.createElement(HTMLDivElement);
        item.id = ""item"";


    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebShopAYuri.DbModels.Proizvod>> Html { get; private set; }
    }
}
#pragma warning restore 1591