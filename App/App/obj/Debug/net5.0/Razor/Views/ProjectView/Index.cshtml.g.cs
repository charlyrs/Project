#pragma checksum "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33ea9f6e8496fd5557f8c3315e6139c909ee7ef4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ea9f6e8496fd5557f8c3315e6139c909ee7ef4", @"/Views/ProjectView/Index.cshtml")]
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
            WriteLiteral("\r\n<style >\r\n  body{\r\n  background-color: #60bcdc ;\r\n  color: white;\r\n  \r\n  }\r\n  text {\r\n  color: white;\r\n  }\r\n  .container {\r\n         display: flex;\r\n         justify-content: center;\r\n     }\r\n     \r\n  \r\n  \r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ea9f6e8496fd5557f8c3315e6139c909ee7ef43511", async() => {
                WriteLiteral("\r\n<div class=\"container\" style=\"margin-top: 10px\">\r\n\r\n\r\n");
#nullable restore
#line 31 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
     foreach (var column in Model.Columns)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card\" style=\"width: 300px; border-radius: 12px; margin-left: 10px; \">\r\n            <div class=\"card-body\">\r\n\r\n                <h5 class=\"card-title\" style=\"color: #60bcdc;\">");
#nullable restore
#line 36 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                                                          Write(column.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 37 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                 using (Html.BeginForm("Index", "AddTask", new {columnId = column.Id}, FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\" style=\"margin-top: 10px; \">\r\n\r\n                        <input style=\"border-radius: 12px;  height: 35px\" type=\"text\" name=\"title\" class=\"form-control\" placeholder=\"Add task\" >\r\n\r\n                    </div>\r\n");
#nullable restore
#line 44 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                 foreach (var task in column.Tasks)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\'", 1168, "\'", 1230, 1);
#nullable restore
#line 48 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 1175, Url.Action("Index","TaskView", new {taskId = task.Id}), 1175, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\r\n                       \r\n                        <h5 style=\"color: #60bcdc\">");
#nullable restore
#line 50 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                                              Write(task.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    </a>\r\n");
#nullable restore
#line 52 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n</div>\r\n<a");
                BeginWriteAttribute("href", " href=\'", 1459, "\'", 1492, 1);
#nullable restore
#line 61 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
WriteAttributeValue("", 1466, Url.Action("ProjectInfo"), 1466, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
    <button style=""background-color: #a4dfed; margin-top: 20px; margin-left: 50px; width: 200px; border-color: #a4dfed; border-radius: 12px "" type=""submit"" class=""btn btn-primary"">Project Info</button>
</a>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color: #a4dfed; "">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Add project</h5>
                   
            </div>
");
#nullable restore
#line 71 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
             using (Html.BeginForm("Add", "ProjectsList", FormMethod.Post))
            {


               

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""modal-body"">


                        

                    </div>
                    <div class=""modal-footer"">
                        <button style="" background-color:lightgrey ;width: 150px; border-radius: 12px; border-color: white"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        

                            <button style=""background-color: #60bcdc; width: 150px; border-radius: 12px; border-color:#C0DCEC"" type=""submit"" class=""btn btn-primary"" >Add </button>
                       
                    </div>
");
#nullable restore
#line 89 "D:\Git\Project\App\App\Views\ProjectView\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
            WriteLiteral("\r\n<script>\r\n$(\'#myModal\').on(\'shown.bs.modal\', function () {\r\n  $(\'#myInput\').trigger(\'focus\')\r\n})\r\n</script>");
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
