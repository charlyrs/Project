#pragma checksum "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a98ad046b5297f6e70a6bcbddf02417bf62444a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectView_Index), @"mvc.1.0.view", @"/Views/ProjectView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a98ad046b5297f6e70a6bcbddf02417bf62444a0", @"/Views/ProjectView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.ProjectViewModel>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
  
    ViewBag.Title = "Projects";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style >
  body{
  background-color: #60bcdc ;
  color: white;
  
  }
  text {
  color: white;
  }
  .container {
         display: flex;
         justify-content: center;
     }
     nav{
          height: 45px;
          }
     
  
  
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a98ad046b5297f6e70a6bcbddf02417bf62444a03523", async() => {
                WriteLiteral("\r\n<div class=\"container\" style=\"margin-top: 10px\">\r\n\r\n\r\n");
#nullable restore
#line 34 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
     foreach (var column in Model.Columns)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card\" style=\"width: 300px; border-radius: 12px; margin-left: 10px; \">\r\n            <div class=\"card-body\">\r\n\r\n                <h5 class=\"card-title\" style=\"color: #60bcdc;\">");
#nullable restore
#line 39 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                                                          Write(column.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 40 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                 if (Model.BossRole)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                     using (Html.BeginForm("Index", "AddTask", new {columnId = column.Id}, FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""form-group"" style=""margin-top: 10px; "">

                            <input style=""border-radius: 12px;  height: 35px"" type=""text"" name=""title"" class=""form-control"" placeholder=""Add task"">

                        </div>
");
#nullable restore
#line 49 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                 foreach (var task in column.Tasks)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\'", 1316, "\'", 1378, 1);
#nullable restore
#line 54 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 1323, Url.Action("Index","TaskView", new {taskId = task.Id}), 1323, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\r\n                       \r\n                        <h5 style=\"color: #60bcdc\">");
#nullable restore
#line 56 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                                              Write(task.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    </a>\r\n");
#nullable restore
#line 58 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 64 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n</div>\r\n<a");
                BeginWriteAttribute("href", " href=\'", 1607, "\'", 1640, 1);
#nullable restore
#line 67 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 1614, Url.Action("ProjectInfo"), 1614, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <button style=\"background-color: #a4dfed; margin-top: 20px; margin-left: 50px; width: 200px; border-color: #a4dfed; border-radius: 12px \" type=\"submit\" class=\"btn btn-primary\">Project Info</button>\r\n</a>\r\n<a");
                BeginWriteAttribute("href", " href=\'", 1855, "\'", 1884, 1);
#nullable restore
#line 70 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 1862, Url.Action("RoadMap"), 1862, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <button style=\"background-color: #a4dfed; margin-top: 20px; margin-left: 50px; width: 200px; border-color: #a4dfed; border-radius: 12px \" type=\"submit\" class=\"btn btn-primary\">RoadMap</button>\r\n</a>\r\n<a");
                BeginWriteAttribute("href", " href=\'", 2094, "\'", 2131, 1);
#nullable restore
#line 73 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 2101, Url.Action("ProjectSettings"), 2101, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <button style=\"background-color: #a4dfed; margin-top: 20px; margin-left: 50px; width: 200px; border-color: #a4dfed; border-radius: 12px \" type=\"submit\" class=\"btn btn-primary\">Settings</button>\r\n</a>\r\n<a");
                BeginWriteAttribute("href", " href=\'", 2342, "\'", 2381, 1);
#nullable restore
#line 76 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 2349, Url.Action("SearchTasksByTags"), 2349, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <button style=\"background-color: #a4dfed; margin-top: 20px; margin-left: 50px; width: 200px; border-color: #a4dfed; border-radius: 12px \" type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.ViewModels.ProjectViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
