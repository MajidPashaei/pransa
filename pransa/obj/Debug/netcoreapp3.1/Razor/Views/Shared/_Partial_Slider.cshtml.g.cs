#pragma checksum "f:\Projects\pransa\pransa\Views\Shared\_Partial_Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e961b85d2ac6a90e7ceb794483bd00f079dede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Partial_Slider), @"mvc.1.0.view", @"/Views/Shared/_Partial_Slider.cshtml")]
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
#line 2 "f:\Projects\pransa\pransa\Views\_ViewImports.cshtml"
using pransa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "f:\Projects\pransa\pransa\Views\_ViewImports.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e961b85d2ac6a90e7ceb794483bd00f079dede", @"/Views/Shared/_Partial_Slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c698fb2a9f4f82b5ab509b2dee02280d8504a1bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Partial_Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("       <section id=\"main-slider\" class=\"main-slider carousel slide carousel-fade card hidden-sm\"\r\n                            data-ride=\"carousel\">\r\n");
            WriteLiteral("                            <div class=\"carousel-inner\">\r\n\r\n                 \r\n");
#nullable restore
#line 16 "f:\Projects\pransa\pransa\Views\Shared\_Partial_Slider.cshtml"
                           if ( ViewBag.qslider != null)
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "f:\Projects\pransa\pransa\Views\Shared\_Partial_Slider.cshtml"
                         foreach (var item in ViewBag.qslider)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"carousel-item active\">\r\n                                    <a class=\"main-slider-slide\" href=\"#\"");
            BeginWriteAttribute("style", "\r\n                                        style=\"", 1266, "\"", 1371, 4);
            WriteAttributeValue("", 1315, "background-image:", 1315, 17, true);
            WriteAttributeValue(" ", 1332, "url(../fileupload/", 1333, 19, true);
#nullable restore
#line 22 "f:\Projects\pransa\pransa\Views\Shared\_Partial_Slider.cshtml"
WriteAttributeValue("", 1351, item.ImageMainSlid, 1351, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1370, ")", 1370, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 25 "f:\Projects\pransa\pransa\Views\Shared\_Partial_Slider.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "f:\Projects\pransa\pransa\Views\Shared\_Partial_Slider.cshtml"
                         
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
         
                            <a class=""carousel-control-prev"" href=""#main-slider"" role=""button"" data-slide=""prev"">
                                <i class=""mdi mdi-chevron-right""></i>
                            </a>
                            <a class=""carousel-control-next"" href=""#main-slider"" data-slide=""next"">
                                <i class=""mdi mdi-chevron-left""></i>
                            </a>
                    
                            
                        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
