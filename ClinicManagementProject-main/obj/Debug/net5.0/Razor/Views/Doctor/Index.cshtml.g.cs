#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50577fce89c8f4f91514890a50325dfecc25f9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50577fce89c8f4f91514890a50325dfecc25f9b8", @"/Views/Doctor/Index.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicManagementProject.Models.Doctor>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50577fce89c8f4f91514890a50325dfecc25f9b83023", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Index</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50577fce89c8f4f91514890a50325dfecc25f9b84074", async() => {
                WriteLiteral("\n    <p>\n        <a href=\"Doctor/Create\">Create New</a><br />\n        \n    </p>\n<table border=\"1\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n           \n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Specialization));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 45 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 48 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            \n            <td>\n                ");
#nullable restore
#line 52 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 58 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Specialization));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                <a asp-action=\"Edit\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1661, "\"", 1691, 1);
#nullable restore
#line 67 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1676, item.Doctor_Id, 1676, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" href=Doctor/Edit?id=");
#nullable restore
#line 67 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
                                                                                   Write(item.Doctor_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(">Edit</a> |\n\n            </td>\n        </tr>\n");
#nullable restore
#line 71 "C:\Users\ngtik\Dropbox\dotnet Work\MVCWebAPI-main\ClinicManagementProject-main\Views\Doctor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\n</table>\n<p>\n    <a href=\"Home/Index\">Back to Home</a>\n</p>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicManagementProject.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591