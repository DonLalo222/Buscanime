#pragma checksum "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ecd56bb4e4fc3b20da7f54b6da780ab3c1e4251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animes_Characters), @"mvc.1.0.view", @"/Views/Animes/Characters.cshtml")]
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
#line 1 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/_ViewImports.cshtml"
using Buscanime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
using Buscanime.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ecd56bb4e4fc3b20da7f54b6da780ab3c1e4251", @"/Views/Animes/Characters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34375bbe85a0d8ecdb90f70c7ffad2a5c0e68ace", @"/Views/_ViewImports.cshtml")]
    public class Views_Animes_Characters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QueryCharacterStaff>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
  
    var id = ViewBag.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<ul class=\"nav nav-tabs\">\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 173, "\"", 199, 2);
            WriteAttributeValue("", 180, "/animes/details/", 180, 16, true);
#nullable restore
#line 13 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
WriteAttributeValue("", 196, id, 196, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Details</a>\r\n  </li>\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 272, "\"", 304, 3);
            WriteAttributeValue("", 279, "/animes/details/", 279, 16, true);
#nullable restore
#line 16 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
WriteAttributeValue("", 295, id, 295, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 298, "/promo", 298, 6, true);
            EndWriteAttribute();
            WriteLiteral(">Video Promo</a>\r\n  </li>\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 387, "\"", 424, 3);
            WriteAttributeValue("", 394, "/animes/details/", 394, 16, true);
#nullable restore
#line 19 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
WriteAttributeValue("", 410, id, 410, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 413, "/characters", 413, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Characters</a>\r\n  </li>\r\n</ul>\r\n<hr>\r\n<!-- -->\r\n<h2 class=\"font-weight-light\">\r\n    Characters\r\n</h2>\r\n<hr>\r\n<!-- -->\r\n\r\n<div class=\"row\">\r\n\r\n\r\n");
#nullable restore
#line 33 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
   foreach (Character character in @Model.characters)
  {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-3 text-center\">\r\n      <img");
            BeginWriteAttribute("src", " src=\"", 683, "\"", 709, 1);
#nullable restore
#line 37 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
WriteAttributeValue("", 689, character.image_url, 689, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail img-fluid\" alt=\"image character\" style=\"width: 200px; height: 300px; object-fit: contain;\">\r\n      <p>");
#nullable restore
#line 38 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
    Write(Html.ActionLink(@character.name, "details", "characters", new {id = @character.mal_id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 40 "/media/eduardo/uso variado/24_07_2020/Proyectos Portafolio/NetCore_Buscanime/Buscanime/Views/Animes/Characters.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n\r\n  <!-- https://api.jikan.moe/v3/person/289/pictures -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QueryCharacterStaff> Html { get; private set; }
    }
}
#pragma warning restore 1591
