#pragma checksum "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d92f795667cde7f59643ad66168fa04f1a29f8e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectView_ProjectInfo), @"mvc.1.0.view", @"/Views/ProjectView/ProjectInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92f795667cde7f59643ad66168fa04f1a29f8e2", @"/Views/ProjectView/ProjectInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectView_ProjectInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.ProjectViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml"
  
    ViewBag.Title = "Project info";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style >
    body{
    background-color:  #C0DCEC;
    color: white;
    size: landscape;
    
   }
   
   text {
   color: white;
   }
   form{
   width: 400px;
   }
   .container {
       display: flex;
       
     
       
   }
  
</style>

<div class=""container""  style=""margin-top: 50px""  >
    
    <div >
        <h1 class=""display-3"" style=""margin-bottom: 20px"">");
#nullable restore
#line 34 "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml"
                                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h3 style=\"margin-bottom: 20px\">");
#nullable restore
#line 35 "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml"
                                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\" style=\"color: #60bcdc\">Users</h5>\r\n");
#nullable restore
#line 39 "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml"
                 foreach (var user in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\" style=\"color: #60bcdc\">");
#nullable restore
#line 41 "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml"
                                                                  Write(user.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "D:\Git\Project\App\App\Views\ProjectView\ProjectInfo.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            </div>\r\n        </div>\r\n            \r\n      \r\n        \r\n    </div>\r\n");
            WriteLiteral(@"    <img style=""margin-left: 150px"" src=""https://fiai.azniirkh.ru/assets/img/why-us.png"" width=""500"">
</div>
<div>
     <button style=""background-color: #60bcdc; margin-top: 15px; width: 200px; border-radius: 12px; border-color:#C0DCEC"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">
                  Leave the project
                </button>
</div>
<div >
  <div class=""modal fade"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
      <div class=""modal-dialog modal-dialog-centered"">
          <div class=""modal-content"">
              <div class=""modal-header"" style=""background-color: #a4dfed; "">
                      <h5 class=""modal-title"" id=""staticBackdropLabel"">Leave the project</h5>
                     
                    </div>
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92f795667cde7f59643ad66168fa04f1a29f8e26685", async() => {
                WriteLiteral(@"
                  <div class=""modal-body"">
                      <h6 style=""color: black ""> Are you sure you want to leave the project? </h6>

                  </div>
                  <div class=""modal-footer"" >
                      <button style="" background-color:lightgrey ;width: 150px; border-radius: 12px; border-color: white"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                     
                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92f795667cde7f59643ad66168fa04f1a29f8e27419", async() => {
                    WriteLiteral("\r\n                          <button style=\"background-color: #60bcdc; width: 150px; border-radius: 12px; border-color:#C0DCEC\" type=\"submit\" class=\"btn btn-primary\">Leave </button>\r\n                      ");
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
                WriteLiteral("\r\n                    \r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92f795667cde7f59643ad66168fa04f1a29f8e29178", async() => {
                    WriteLiteral("\r\n                     ");
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
                WriteLiteral("\r\n  \r\n                  </div>\r\n              ");
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
            WriteLiteral("\r\n          </div>\r\n      </div>\r\n  </div>  \r\n</div>\r\n<script>\r\n$(\'#myModal\').on(\'shown.bs.modal\', function () {\r\n  $(\'#myInput\').trigger(\'focus\')\r\n})\r\n</script>");
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
