#pragma checksum "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fdaa8fe3f8dbfa4989db9ae7c4168c17ac00de2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Index.cshtml", typeof(AspNetCore.Views_Accounts_Index))]
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
#line 1 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\_ViewImports.cshtml"
using Viewer;

#line default
#line hidden
#line 2 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\_ViewImports.cshtml"
using Viewer.Models;

#line default
#line hidden
#line 4 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdaa8fe3f8dbfa4989db9ae7c4168c17ac00de2", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13421bfa9b10a24e4146b34a1ba70cf68570c38a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
            BeginContext(61, 170, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h2> Character & Trait Editor/Viewer</h2>\r\n</div>\r\n\r\n<div>\r\n    <div class=\'entryLabel\'>\r\n        <h2>Your Account</h2>\r\n    </div>\r\n    \r\n");
            EndContext();
#line 15 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
     if(User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(278, 69, true);
            WriteLiteral("        <div class=\'entry\' style=\"height: 100px;\">\r\n        <p>Hello ");
            EndContext();
            BeginContext(348, 18, false);
#line 18 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
            Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(366, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
         using (Html.BeginForm("LogOff", "Accounts"))
        {

#line default
#line hidden
            BeginContext(438, 76, true);
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-default\" value=\"Log Out\"/>\r\n");
            EndContext();
#line 22 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(525, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 24 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
    }
    else 
    {

#line default
#line hidden
            BeginContext(566, 67, true);
            WriteLiteral("        <div class=\'entry\' style=\"height: 100px;\">\r\n            <p>");
            EndContext();
            BeginContext(634, 39, false);
#line 28 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
          Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(673, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(695, 34, false);
#line 29 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
          Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(729, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 31 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Accounts\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(758, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
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