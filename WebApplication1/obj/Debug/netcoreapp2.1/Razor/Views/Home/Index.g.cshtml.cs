#pragma checksum "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401ee2fa27a1a516d7a02102426d646837e546ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401ee2fa27a1a516d7a02102426d646837e546ed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(30, 77, false);
#line 5 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Html.Label("FirstName", "First Name", new { @class = "classname", @x = "y" }));

#line default
#line hidden
            EndContext();
            BeginContext(107, 14, true);
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(122, 41, false);
#line 9 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Html.TextArea("Id", "value", 5, 10, null));

#line default
#line hidden
            EndContext();
            BeginContext(163, 16, true);
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n\r\n");
            EndContext();
#line 14 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  string name = "Ulker";

#line default
#line hidden
            BeginContext(207, 31, false);
#line 15 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Html.TextAreaFor(model => name));

#line default
#line hidden
            EndContext();
            BeginContext(238, 14, true);
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(253, 119, false);
#line 19 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Html.TextBoxFor(model=>DateTime.Now, "{0:MM-dd-yyyy}", new { maxLength=10, style="min-height:30px; border-color:red;"}));

#line default
#line hidden
            EndContext();
            BeginContext(372, 16, true);
            WriteLiteral("\r\n\r\n<hr />  \r\n\r\n");
            EndContext();
            BeginContext(389, 25, false);
#line 23 "C:\Users\bilge.adam\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Html.CheckBox("id", true));

#line default
#line hidden
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
