#pragma checksum "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a008181592a955001e13b92ac220c453a2b32d82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_SearchByGender), @"mvc.1.0.view", @"/Views/Employees/SearchByGender.cshtml")]
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
#line 1 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\_ViewImports.cshtml"
using V2_Ems_MVC_RepoPattern_InMemory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\_ViewImports.cshtml"
using V2_Ems_MVC_RepoPattern_InMemory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a008181592a955001e13b92ac220c453a2b32d82", @"/Views/Employees/SearchByGender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd5992f74b44466055197d144a73f77d5931a31", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_SearchByGender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<V2_Ems_MVC_RepoPattern_InMemory.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchByGender", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
  
    ViewData["Title"] = "SearchByGender";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search Employees By Gender</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a008181592a955001e13b92ac220c453a2b32d824484", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\"\r\n            <label class=\"control-label\"></label>\r\n");
#nullable restore
#line 12 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
             foreach (var gender in Html.GetEnumSelectList<Gender>())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"radio\" name=\"gender\"");
                BeginWriteAttribute("value", " value=\"", 426, "\"", 447, 1);
#nullable restore
#line 14 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
WriteAttributeValue("", 434, gender.Value, 434, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/> ");
#nullable restore
#line 14 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                                                                              Write(gender.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                                                                                               
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input class=\"btn btn-primary\" type=\"submit\" name=\"btnSearch\" value=\"Search\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 20 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
 if (@ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>");
#nullable restore
#line 22 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 23 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
 if (Model != null && Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a008181592a955001e13b92ac220c453a2b32d828577", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
               Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateOfJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 84 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 93 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 96 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 97 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 98 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 101 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 104 "C:\Users\Hp\source\repos\EMS.NetCore\V2_Ems_MVC_RepoPattern_InMemory\Views\Employees\SearchByGender.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<V2_Ems_MVC_RepoPattern_InMemory.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
