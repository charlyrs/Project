#pragma checksum "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ceb33c4ba3b2c4ae9b8c608ed24567f4119d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectsList_Index), @"mvc.1.0.view", @"/Views/ProjectsList/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ceb33c4ba3b2c4ae9b8c608ed24567f4119d48", @"/Views/ProjectsList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectsList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
  
    ViewBag.Title = "Projects";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style >
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

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ceb33c4ba3b2c4ae9b8c608ed24567f4119d484098", async() => {
                WriteLiteral("\r\n\r\n<div class=\"container\" >\r\n    <div class=\"mycontainer\" style=\"margin-top: 20px;\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ceb33c4ba3b2c4ae9b8c608ed24567f4119d484461", async() => {
                    WriteLiteral("\r\n            <div class=\"container\">\r\n");
#nullable restore
#line 40 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
                 foreach (var project in Model.Projects)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"card\" style=\"width: 12rem; margin-left: 15px\">\r\n                        <div class=\"card-body\">\r\n                            <a");
                    BeginWriteAttribute("href", " href=\'", 770, "\'", 842, 1);
#nullable restore
#line 44 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
WriteAttributeValue("", 777, Url.Action("Index", "ProjectView", new {projectId = project.Id}), 777, 65, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <h5 class=\"card-title\" style=\"color: #60bcdc\">");
#nullable restore
#line 45 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
                                                                         Write(project.Title);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h5>\r\n                            </a>\r\n                            <p class=\"card-text\" style=\"color: #60bcdc \">");
#nullable restore
#line 47 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
                                                                    Write(project.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 51 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        
    </div>
    <button style=""background-color: #60bcdc; margin-top: 15px; width: 200px; border-radius: 12px; border-color:#C0DCEC"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">
              + Add Project
            </button>
</div>



");
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
            WriteLiteral(@"



<!-- Modal -->
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color: #a4dfed; "">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Add project</h5>
                   
            </div>
");
#nullable restore
#line 76 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
             using (Html.BeginForm("Add", "ProjectsList", FormMethod.Post))
            {


               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""modal-body"">


                        <div class=""form-group"">

                            <input style=""border-radius: 12px; "" type=""text"" name=""title"" class=""form-control"" placeholder=""Title"">
                        </div>
                        <div class=""form-group"">

                            <textarea style=""border-radius: 12px"" type=""text"" name=""description"" class=""form-control"" placeholder=""Description""></textarea>
                        </div>

                    </div>
                    <div class=""modal-footer"">
                        <button style="" background-color:lightgrey ;width: 150px; border-radius: 12px; border-color: white"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        

                            <button style=""background-color: #60bcdc; width: 150px; border-radius: 12px; border-color:#C0DCEC"" type=""submit"" class=""btn btn-primary"" >Add </button>
                       
   ");
            WriteLiteral("                 </div>\r\n");
#nullable restore
#line 101 "D:\Git\Project\App\App\Views\ProjectsList\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n$(\'#myModal\').on(\'shown.bs.modal\', function () {\r\n  $(\'#myInput\').trigger(\'focus\')\r\n})\r\n</script>");
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
