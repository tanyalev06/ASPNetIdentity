#pragma checksum "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a103017ff2bf43bad41461c9ed2368e25188dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
#line 1 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\_ViewImports.cshtml"
using TestIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\_ViewImports.cshtml"
using TestIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a103017ff2bf43bad41461c9ed2368e25188dac", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ba01b2255d50c3847cb0d3c57bedef2aff6ea4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\t\t<meta charset=\"utf-8\" />\r\n\t\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 3 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
         if(ViewBag.Title != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<title>Tittle = ");
#nullable restore
#line 4 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 5 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
		}
		else{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<title>Наш сайт</title>\r\n");
#nullable restore
#line 8 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
         if(ViewBag.Description != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 305, "\"", 335, 1);
#nullable restore
#line 10 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 315, ViewBag.Description, 315, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> ");
#nullable restore
#line 10 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
                                                                       //мета для описания страницы
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
         if(ViewBag.Keywords != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 433, "\"", 460, 1);
#nullable restore
#line 13 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 443, ViewBag.Keywords, 443, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />  ");
#nullable restore
#line 13 "D:\Тестовые задания\Минское городское агентство обслуживания населения\ASPNetIdentity\TestIdentity\Views\Shared\MetatagsPartial.cshtml"
                                                                  //мета для ключевых слов
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
