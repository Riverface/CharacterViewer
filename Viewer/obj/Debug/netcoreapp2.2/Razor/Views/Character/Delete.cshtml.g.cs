#pragma checksum "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36683588989512f71666178342591e92b9496a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Delete), @"mvc.1.0.view", @"/Views/Character/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Character/Delete.cshtml", typeof(AspNetCore.Views_Character_Delete))]
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
#line 2 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\_ViewImports.cshtml"
using Viewer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36683588989512f71666178342591e92b9496a62", @"/Views/Character/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13421bfa9b10a24e4146b34a1ba70cf68570c38a", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Viewer.Models.Character>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 151, true);
            WriteLiteral("\r\n\r\n<div>\r\n  <div class=\'entryLabel\'>\r\n    <h2>Are you sure you want to delete this?</h2>\r\n  </div>\r\n  <div class=\'entry\' style=\"height: 100px;\">\r\n    ");
            EndContext();
            BeginContext(216, 47, false);
#line 13 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(263, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(266, 43, false);
#line 13 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Delete.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Delete.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(349, 46, true);
            WriteLiteral("      <input type=\"submit\" value=\"Delete\" />\r\n");
            EndContext();
#line 17 "D:\Projects\Programming\CharacterViewer\CharacterViewerFrontend.Solution\Viewer\Views\Character\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(402, 18, true);
            WriteLiteral("  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Viewer.Models.Character> Html { get; private set; }
    }
}
#pragma warning restore 1591