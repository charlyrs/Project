#pragma checksum "D:\Git\Project\App\App\Views\Registration\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7071e0713c2821c6d29aff203eeb0dcc27ad5aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_LogIn), @"mvc.1.0.view", @"/Views/Registration/LogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7071e0713c2821c6d29aff203eeb0dcc27ad5aa3", @"/Views/Registration/LogIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "D:\Git\Project\App\App\Views\Registration\LogIn.cshtml"
  
    ViewBag.Title = "Log in";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
body{
    background-color:  #C0DCEC;
    color: white;
    size: landscape;
    
   }
   .btn {
             position: relative;
             overflow: hidden;
             z-index: 1;
             padding: 10px 40px;
             margin: 0 20px;
             font-family: 'Montserrat Alternates', sans-serif;
             font-weight: 600;
             line-height: 30px;
             color: white;
             font-size: 15px;
             text-transform: uppercase;
             background: #60bcdc ;
             border-width: 0;
             box-shadow: 5px 5px 0 #145DA0;
             outline: none;
             cursor: pointer;
             transition: 1.5s;
          }
          .btn:before, .btn:after {
             content: """";
             position: absolute;
             height: 200px;
             left: -50%;
             margin-top: -100px;
             top: 50%;
             width: 200px;
             border-radius: 50%;
             opacity: 0.3;
        ");
            WriteLiteral(@"     z-index: -1;
             transform: scale(0);
          }
          .btn:before {
             background: #a4dfed;
             transition: .8s ease-out;
          }
          .btn:after {
             transition: .4s ease-in .3s;
          }
          .btn:hover {
             color: #145DA0;
          }
          .btn:hover:before, .btn:hover:after {
             opacity: 1;
             transform: scale(4);
          }
   
   text {
   color: white;
   }
   form{
   width: 400px;
   }
   .container {
       display: flex;
       align-items: center;
       justify-content: center;
     
       
   }
   nav{
        height: 45px;
        }
   </style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7071e0713c2821c6d29aff203eeb0dcc27ad5aa35568", async() => {
                WriteLiteral("\r\n<h1 class=\"display-3\" style=\"color: white;\">Log in</h1>\r\n<div");
                BeginWriteAttribute("class", " class=\"", 1878, "\"", 1886, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-top: 50px\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7071e0713c2821c6d29aff203eeb0dcc27ad5aa36083", async() => {
                    WriteLiteral(@"
        <div class=""form-group"">
            <input style=""border-radius: 12px"" type=""text"" name=""username"" class=""form-control"" id=""exampleInputName1"" placeholder=""Username"">
        </div>
        <div class=""form-group"">

            <input style=""border-radius: 12px"" type=""password"" name=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
        </div>

        <button  type=""submit"" class=""btn"">Submit</button>
    ");
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
                WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
