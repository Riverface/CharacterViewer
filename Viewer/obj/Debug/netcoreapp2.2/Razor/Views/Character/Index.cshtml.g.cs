#pragma checksum "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8141e38ad8acd7c38cb1917c7e0c172c0e0150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Index), @"mvc.1.0.view", @"/Views/Character/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Character/Index.cshtml", typeof(AspNetCore.Views_Character_Index))]
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
#line 1 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\_ViewImports.cshtml"
using Viewer;

#line default
#line hidden
#line 5 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
using Viewer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8141e38ad8acd7c38cb1917c7e0c172c0e0150", @"/Views/Character/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13421bfa9b10a24e4146b34a1ba70cf68570c38a", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Viewer.Models.Character>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 107, true);
            WriteLiteral("\r\n  <div>\r\n    <div class=\'entryLabel\'>\r\n      <h1>Characters</h1>\r\n    </div>\r\n    <div class=\'entry\'>\r\n\r\n");
            EndContext();
#line 14 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
            BeginContext(239, 16, true);
            WriteLiteral("          <ul>\r\n");
            EndContext();
#line 17 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
             foreach (Character Character in Model)
            {

#line default
#line hidden
            BeginContext(323, 18, true);
            WriteLiteral("              <li>");
            EndContext();
            BeginContext(342, 90, false);
#line 19 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
             Write(Html.ActionLink($"{Character.Description}", "Details", new { id = Character.CharacterId }));

#line default
#line hidden
            EndContext();
            BeginContext(432, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(454, 17, true);
            WriteLiteral("          </ul>\r\n");
            EndContext();
#line 22 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(507, 55, true);
            WriteLiteral("          <h3>No Characters have been added yet!</h3>\r\n");
            EndContext();
#line 26 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(573, 33, true);
            WriteLiteral("    </div>\r\n  </div>\r\n\r\n  <div>\r\n");
            EndContext();
#line 31 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
       if(User.Identity.IsAuthenticated)
      {

#line default
#line hidden
            BeginContext(657, 136, true);
            WriteLiteral("        <div class=\'entryLabel propertyLabel\'>\r\n          Characters menu\r\n        </div>\r\n        <div class=\'property\'>\r\n          <p>");
            EndContext();
            BeginContext(794, 46, false);
#line 37 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
        Write(Html.ActionLink("Add new Character", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(840, 19, true);
            WriteLiteral("</p>\r\n          <p>");
            EndContext();
            BeginContext(860, 40, false);
#line 38 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
        Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(900, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 40 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(931, 8, true);
            WriteLiteral("  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Viewer.Models.Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
