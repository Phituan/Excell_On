#pragma checksum "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f1c7b363f0a52ec86b29db0cfeda5ca5cca234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f1c7b363f0a52ec86b29db0cfeda5ca5cca234", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f1c7b363f0a52ec86b29db0cfeda5ca5cca2344771", async() => {
                BeginContext(148, 10, true);
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
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 48, false);
#line 16 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 52, false);
#line 19 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeFirtName));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 52, false);
#line 22 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeLastName));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 50, false);
#line 25 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeGender));

#line default
#line hidden
            EndContext();
            BeginContext(625, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(681, 55, false);
#line 28 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeDateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(792, 51, false);
#line 31 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeAddress));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(899, 55, false);
#line 34 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(954, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1010, 49, false);
#line 37 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1115, 50, false);
#line 40 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeAvatar));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1221, 52, false);
#line 43 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeIsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1391, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1440, 47, false);
#line 52 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1543, 51, false);
#line 55 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeFirtName));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1650, 51, false);
#line 58 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1757, 49, false);
#line 61 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeGender));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1862, 54, false);
#line 64 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeDateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1972, 50, false);
#line 67 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2078, 54, false);
#line 70 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2188, 48, false);
#line 73 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2236, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2292, 49, false);
#line 76 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeAvatar));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2397, 51, false);
#line 79 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeIsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(2448, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2503, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f1c7b363f0a52ec86b29db0cfeda5ca5cca23415306", async() => {
                BeginContext(2556, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
                                       WriteLiteral(item.EmployeeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2564, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2584, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f1c7b363f0a52ec86b29db0cfeda5ca5cca23417668", async() => {
                BeginContext(2640, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
                                          WriteLiteral(item.EmployeeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2651, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2671, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f1c7b363f0a52ec86b29db0cfeda5ca5cca23420036", async() => {
                BeginContext(2726, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
                                         WriteLiteral(item.EmployeeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2736, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Employees\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2775, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
