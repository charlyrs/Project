#pragma checksum "D:\Git\Project\App\App\Views\Notifications\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2058deaa3d6954168077df3a28d033659ddac77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notifications_Index), @"mvc.1.0.view", @"/Views/Notifications/Index.cshtml")]
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
#line 1 "D:\Git\Project\App\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\Project\App\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2058deaa3d6954168077df3a28d033659ddac77", @"/Views/Notifications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Notifications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.UserViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git\Project\App\App\Views\Notifications\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style >\r\n    body{\r\n    background-color:  #C0DCEC;\r\n    color: white;\r\n    size: landscape;\r\n    \r\n   }\r\n   \r\n   text {\r\n   color: white;\r\n   }\r\n   form{\r\n   width: 400px;\r\n   }\r\n   .container{\r\n   display: flex;\r\n   \r\n   }\r\n  \r\n  \r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2058deaa3d6954168077df3a28d033659ddac773545", async() => {
                WriteLiteral("\r\n<div class=\"container\">\r\n        <img src=\"https://www.pinclipart.com/picdir/big/545-5452956_usability-clipart.png\" width=\"400\" style=\"margin-top: 20px\">\r\n\r\n    <div style=\"margin-top: 20px\">\r\n");
#nullable restore
#line 34 "D:\Git\Project\App\App\Views\Notifications\Index.cshtml"
         foreach (var n in Model.Notifications)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"card\" style=\"width: 40rem; height: 52px; margin-top: 5px\">\r\n                <div class=\"card-body\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\'", 756, "\'", 817, 1);
#nullable restore
#line 38 "D:\Git\Project\App\App\Views\Notifications\Index.cshtml"
WriteAttributeValue("", 763, Url.Action("RedirectController", new {path = n.Link}), 763, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                        <h6 style=\"color: #60bcdc \">");
#nullable restore
#line 40 "D:\Git\Project\App\App\Views\Notifications\Index.cshtml"
                                               Write(n.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    </a>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 45 "D:\Git\Project\App\App\Views\Notifications\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.ViewModels.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
