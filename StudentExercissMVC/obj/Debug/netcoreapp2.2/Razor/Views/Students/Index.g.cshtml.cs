#pragma checksum "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa7683c33ccb98c37166024ee19a7cd428b895b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 1 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\_ViewImports.cshtml"
using StudentExercissMVC;

#line default
#line hidden
#line 2 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\_ViewImports.cshtml"
using StudentExercissMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa7683c33ccb98c37166024ee19a7cd428b895b", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db16ce138dd697d55cb0b8271764146243752f51", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentExercissMVC.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faa7683c33ccb98c37166024ee19a7cd428b895b3885", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 38, false);
#line 16 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 44, false);
#line 19 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 45, false);
#line 22 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(496, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(552, 44, false);
#line 25 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(596, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(652, 47, false);
#line 28 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(699, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(817, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(866, 37, false);
#line 37 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(903, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(959, 43, false);
#line 40 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1058, 44, false);
#line 43 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1158, 43, false);
#line 46 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1257, 46, false);
#line 49 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1359, 52, false);
#line 52 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1432, 58, false);
#line 53 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1511, 55, false);
#line 54 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\tonyr\31backend\StudentExercissMVC\StudentExercissMVC\Views\Students\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1605, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentExercissMVC.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
