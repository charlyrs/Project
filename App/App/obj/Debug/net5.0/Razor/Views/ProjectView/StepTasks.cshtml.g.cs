#pragma checksum "D:\Git\Project\App\App\Views\ProjectView\StepTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8624b5cf9d28e05e9389c7cb17a156f12a4cb61a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectView_StepTasks), @"mvc.1.0.view", @"/Views/ProjectView/StepTasks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8624b5cf9d28e05e9389c7cb17a156f12a4cb61a", @"/Views/ProjectView/StepTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectView_StepTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.RMStepViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git\Project\App\App\Views\ProjectView\StepTasks.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style >
  body{
  background-color: #60bcdc;
  
  color: white;
  }
  text {
  color: white;
  }
  .container {
         display: flex;
        
         
     }
     nav{
     height: 45px;
     }
  
  
</style>
<h1 class=""display-4"">");
#nullable restore
#line 27 "D:\Git\Project\App\App\Views\ProjectView\StepTasks.cshtml"
                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"container\" >\r\n    <div class=\"mycontainer\" style=\"margin-top: 20px;\">\r\n        \r\n        <div class=\"container\">\r\n");
#nullable restore
#line 32 "D:\Git\Project\App\App\Views\ProjectView\StepTasks.cshtml"
             foreach (var task in Model.Tasks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\"width: 12rem; margin-left: 15px\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\" style=\"color: #60bcdc\">");
#nullable restore
#line 36 "D:\Git\Project\App\App\Views\ProjectView\StepTasks.cshtml"
                                                                 Write(task.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\Git\Project\App\App\Views\ProjectView\StepTasks.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.ViewModels.RMStepViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
