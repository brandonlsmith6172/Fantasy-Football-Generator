#pragma checksum "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fb439b150a78a1a748c68bf80e2a40ad83ef5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\_ViewImports.cshtml"
using FootballCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\_ViewImports.cshtml"
using FootballCalc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7fb439b150a78a1a748c68bf80e2a40ad83ef5b", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b73f51c3fb1c61d4df5584ef97b0f7c8b0c38ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FootballCalc.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
  
    ViewBag.Title = "Registration";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Registration</h2>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>User</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 40 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 41 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
Write(Html.HiddenFor(model => model.Userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"form-group\">\r\n    \r\n    ");
#nullable restore
#line 45 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
Write(Html.LabelFor(model => model.First_Name, @htmlAttributes:new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-md-10\">\r\n        ");
#nullable restore
#line 47 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.EditorFor(model => model.First_Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.ValidationMessageFor(model => model.First_Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 53 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.LabelFor(model => model.Last_Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.EditorFor(model => model.Last_Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 56 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Last_Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 61 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.LabelFor(model => model.Date_Of_Birth, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 63 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.EditorFor(model => model.Date_Of_Birth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 64 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Date_Of_Birth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 68 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.LabelFor(model => model.Username, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 70 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.EditorFor(model => model.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 71 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 75 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 78 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\" name=\"Email Address\">\r\n        ");
#nullable restore
#line 82 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
   Write(Html.LabelFor(model => model.Email_Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.EditorFor(model => model.Email_Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 85 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email_Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 95 "C:\Users\deyas\Documents\GitHub\Fantasy-Football-Generator\MVCRosterCalc_DONOTZIP\FootballCalc\Views\Home\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FootballCalc.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
