#pragma checksum "D:\Git\Project\App\App\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abe40ecc47900b68ebea5359dcd686dc7451059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abe40ecc47900b68ebea5359dcd686dc7451059", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b0c841f4decbe6e1d65767bfd58a56af80c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.UserViewModel>
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
#line 3 "D:\Git\Project\App\App\Views\Account\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body{\r\n    background-color: #60bcdc;\r\n    }\r\n    .container{\r\n    align-content: center;\r\n    }\r\n    nav{\r\n         height: 45px;\r\n         }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3abe40ecc47900b68ebea5359dcd686dc74510593407", async() => {
                WriteLiteral(@"
 <div >
        
     <div class=""container"" style=""width: 300px; margin-top: 20px; align-items: center"">
         <h1 style=""margin-bottom: 20px; color: white"">Account info</h1>
         <div class=""form-group"">

             <input style=""border-radius: 12px; "" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 566, "\"", 595, 1);
#nullable restore
#line 25 "D:\Git\Project\App\App\Views\Account\Index.cshtml"
WriteAttributeValue("", 580, Model.Nickname, 580, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n         </div>\r\n\r\n         <div class=\"form-group\">\r\n             <input style=\"border-radius: 12px; \" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 732, "\"", 758, 1);
#nullable restore
#line 29 "D:\Git\Project\App\App\Views\Account\Index.cshtml"
WriteAttributeValue("", 746, Model.Email, 746, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n         </div>\r\n         \r\n             <a");
                BeginWriteAttribute("href", " href=\'", 814, "\'", 848, 1);
#nullable restore
#line 32 "D:\Git\Project\App\App\Views\Account\Index.cshtml"
WriteAttributeValue("", 821, Url.Action("EditUserData"), 821, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                 <button style=\"background-color: #C0DCEC; width: 250px; border-color: darkturquoise; border-radius: 12px \" type=\"submit\" class=\"btn btn-primary\">Edit</button>\r\n             </a>\r\n         \r\n        \r\n         <a");
                BeginWriteAttribute("href", " href=\'", 1080, "\'", 1114, 1);
#nullable restore
#line 37 "D:\Git\Project\App\App\Views\Account\Index.cshtml"
WriteAttributeValue("", 1087, Url.Action("EditPassword"), 1087, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n             <h6 style=\"color: white; margin-top: 20px; \">Change password</h6>\r\n         </a>\r\n         <a");
                BeginWriteAttribute("href", " href=\'", 1224, "\'", 1252, 1);
#nullable restore
#line 40 "D:\Git\Project\App\App\Views\Account\Index.cshtml"
WriteAttributeValue("", 1231, Url.Action("LogOut"), 1231, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                          <button style=\"background-color: #C0DCEC; width: 250px; border-color: darkturquoise; border-radius: 12px \" type=\"submit\" class=\"btn btn-primary\">Log out</button>\r\n                      </a>\r\n        \r\n     </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
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
