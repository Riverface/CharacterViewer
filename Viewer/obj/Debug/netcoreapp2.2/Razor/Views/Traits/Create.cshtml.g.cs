#pragma checksum "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8ee8cdf877c2d0185a4d6dfdffc24e697bc225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Traits_Create), @"mvc.1.0.view", @"/Views/Traits/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Traits/Create.cshtml", typeof(AspNetCore.Views_Traits_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8ee8cdf877c2d0185a4d6dfdffc24e697bc225", @"/Views/Traits/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13421bfa9b10a24e4146b34a1ba70cf68570c38a", @"/Views/_ViewImports.cshtml")]
    public class Views_Traits_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Viewer.Models.Trait>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 104, true);
            WriteLiteral("\r\n<div>\r\n\r\n  <div class=\'entryLabel\'>\r\n    <h4>Add a new Trait</h4>\r\n  </div>\r\n  <div class=\'entry\'>\r\n\r\n");
            EndContext();
#line 14 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml"
     using (Html.BeginForm())
    {
      

#line default
#line hidden
            BeginContext(209, 34, false);
#line 16 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml"
 Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(252, 65, false);
#line 17 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml"
 Write(Html.TextBoxFor(model => model.Name, new{@required = "required"}));

#line default
#line hidden
            EndContext();
            BeginContext(319, 52, true);
            WriteLiteral("      <input type=\"submit\" value=\"Add new Trait\"/>\r\n");
            EndContext();
#line 19 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml"
    }

#line default
#line hidden
            BeginContext(378, 21, true);
            WriteLiteral("  </div>\r\n</div>\r\n<p>");
            EndContext();
            BeginContext(400, 43, false);
#line 22 "D:\Projects\Programming\CharacterViewer\Viewer.solution\viewer\Views\Traits\Create.cshtml"
Write(Html.ActionLink("Show all Traits", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(443, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Viewer.Models.Trait> Html { get; private set; }
    }
}
#pragma warning restore 1591
