#pragma checksum "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf4b96c8b423850ab4b24e62866d538b85ceb66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Delete), @"mvc.1.0.view", @"/Views/Employees/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Delete.cshtml", typeof(AspNetCore.Views_Employees_Delete))]
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
#line 1 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf4b96c8b423850ab4b24e62866d538b85ceb66", @"/Views/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(84, 178, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(263, 48, false);
#line 15 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(311, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(375, 44, false);
#line 18 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(419, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(482, 52, false);
#line 21 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeFirtName));

#line default
#line hidden
            EndContext();
            BeginContext(534, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(598, 48, false);
#line 24 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeFirtName));

#line default
#line hidden
            EndContext();
            BeginContext(646, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(709, 52, false);
#line 27 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeLastName));

#line default
#line hidden
            EndContext();
            BeginContext(761, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(825, 48, false);
#line 30 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeLastName));

#line default
#line hidden
            EndContext();
            BeginContext(873, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(936, 50, false);
#line 33 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeGender));

#line default
#line hidden
            EndContext();
            BeginContext(986, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1050, 46, false);
#line 36 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeGender));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1159, 55, false);
#line 39 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeDateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1278, 51, false);
#line 42 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeDateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1392, 51, false);
#line 45 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1507, 47, false);
#line 48 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1617, 55, false);
#line 51 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1736, 51, false);
#line 54 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1850, 49, false);
#line 57 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1963, 45, false);
#line 60 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2071, 50, false);
#line 63 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeAvatar));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2185, 46, false);
#line 66 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeAvatar));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2294, 52, false);
#line 69 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeIsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(2346, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2410, 48, false);
#line 72 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeIsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2496, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf4b96c8b423850ab4b24e62866d538b85ceb6613818", async() => {
                BeginContext(2522, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2532, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edf4b96c8b423850ab4b24e62866d538b85ceb6614211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2576, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2659, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf4b96c8b423850ab4b24e62866d538b85ceb6616134", async() => {
                    BeginContext(2681, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2697, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2710, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591