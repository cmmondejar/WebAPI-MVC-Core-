#pragma checksum "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a236b214c880e741807573ab090c8d40e3ee8079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1), @"mvc.1.0.view", @"/Views/Home/Index1.cshtml")]
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
#line 1 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\_ViewImports.cshtml"
using WebAPPMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\_ViewImports.cshtml"
using WebAPPMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a236b214c880e741807573ab090c8d40e3ee8079", @"/Views/Home/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4244dbff3ed10557d2d4d4ab4123663599ace146", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAPPMVC.Models.EmployeeDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.DisplayFor(modelItem => item.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 56 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 62 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
  
    TempData["contain"] = "staff";
    if (TempData["msg"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            alert(\'");
#nullable restore
#line 67 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
              Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n        </script>\r\n");
#nullable restore
#line 69 "E:\BACKUP GOAL SETTING\WebAPICORE\WebAPPMVC\Views\Home\Index1.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAPPMVC.Models.EmployeeDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
