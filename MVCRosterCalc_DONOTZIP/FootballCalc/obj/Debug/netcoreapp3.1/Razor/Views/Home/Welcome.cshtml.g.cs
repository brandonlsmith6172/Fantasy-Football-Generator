#pragma checksum "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c9c006597568abcafb2eab72aa0d37aff9dd43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
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
#line 1 "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\_ViewImports.cshtml"
using FootballCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\_ViewImports.cshtml"
using FootballCalc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c9c006597568abcafb2eab72aa0d37aff9dd43", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b73f51c3fb1c61d4df5584ef97b0f7c8b0c38ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 8 "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\chjay\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Welcome.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
