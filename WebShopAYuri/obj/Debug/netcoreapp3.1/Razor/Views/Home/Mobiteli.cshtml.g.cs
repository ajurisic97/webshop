#pragma checksum "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb6f22fa5ebf9d634a2911a31165053b0faea96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mobiteli), @"mvc.1.0.view", @"/Views/Home/Mobiteli.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cb6f22fa5ebf9d634a2911a31165053b0faea96", @"/Views/Home/Mobiteli.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e46486a1fa01ec0f980aa70aaaf38db21c25c14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mobiteli : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebShopAYuri.DbModels.Proizvod>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
  
    ViewData["Title"] = "Naslovnica";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Carousel -->
<link href=""https://fonts.googleapis.com/css?family=Muli:300,400,700,900"" rel=""stylesheet"" />
<link rel=""stylesheet"" href=""fonts/icomoon/style.css"">
<link rel=""stylesheet"" href=""css/style.css"">
<style>

    .btn {
        padding: 14px 20px;
        border-radius: 0;
    }

        .btn.btn-white {
            background: #fff;
            color: #000;
        }

    .col-md-8 {
        margin-bottom: 50px;
    }

    .intro-section {
        height: 515px;
    }

    h1, .h1 {
        margin-top: 150px;
        color: white;
        font-size: 60px;
        font-weight: 700;
        font-family: ""Muli"", -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
    }

    h3, .h3 {
        font-size: 14px;
    }
</style>

<!-- Wrapper for slides -->
<div class=""site-section"">
    <div class=""intro-section"" style=""background-image: url('https:/");
            WriteLiteral(@"/cdn.vox-cdn.com/thumbor/XAg2tROQEtnBxN5gwpbZejt1s_U=/0x0:2040x1360/1200x800/filters:focal(857x517:1183x843)/cdn.vox-cdn.com/uploads/chorus_image/image/61520649/jbareham_180424_2499_0007.0.jpg'); "">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-md-7 mx-auto text-center"" data-aos=""fade-up"">
                    <h1>Mobiteli</h1>
                </div>
            </div>
        </div>
    
    </div>
        <div class=""container"">
            <div class=""row mb-4"">
                <div class=""col-md-7 mb-5 text-center mx-auto"">
                    <span class=""caption""></span>
                    <h2 class=""text-black""></h2>
                </div>
            </div>
            <div class=""row auctions-entry"">
");
#nullable restore
#line 68 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-6 col-md-4 col-lg-3"">
                        <div class=""item"">
                            <div>
                                <a href=""item-single.html""><img src=""https://www.hgshop.hr/articleImages/80786-878.jpg?preset=product"" alt=""Image"" class=""img-fluid""></a>
                            </div>
                            <div class=""p-4"">
");
            WriteLiteral("                                <h3><a");
            BeginWriteAttribute("href", " href=\"", 2668, "\"", 2737, 2);
            WriteAttributeValue("", 2675, "proizvod/dohvati/", 2675, 17, true);
#nullable restore
#line 77 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
WriteAttributeValue("", 2692, Html.DisplayFor(modelItem=> item.Idproizvod), 2692, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
                                                                                                        Write(Html.DisplayFor(modelItem => item.Marka));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 77 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
                                                                                                                                                    Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <div class=\"d-flex mb-2\">\r\n                                    <span>Cijena:</span>\r\n                                    <span class=\"ml-auto\">");
#nullable restore
#line 80 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral(" kn</span>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 87 "C:\Users\4nd3lo\Desktop\PMA Projekti\AndeloProjekt-27082020\AndeloProjekt-27082020\AndeloProjekt-23082020\WebShopAYuri\Views\Home\Mobiteli.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
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
