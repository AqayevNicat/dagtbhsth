#pragma checksum "C:\Users\nijatma\Desktop\P224_ASP_06-04-2022_FileUpload_FileExtention_SweetAllert\Pustok\Pustok\Areas\Manage\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540a9915a5f539dbe1bf992d9fefd61e212f44da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Product/Index.cshtml")]
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
#line 2 "C:\Users\nijatma\Desktop\P224_ASP_06-04-2022_FileUpload_FileExtention_SweetAllert\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nijatma\Desktop\P224_ASP_06-04-2022_FileUpload_FileExtention_SweetAllert\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nijatma\Desktop\P224_ASP_06-04-2022_FileUpload_FileExtention_SweetAllert\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nijatma\Desktop\P224_ASP_06-04-2022_FileUpload_FileExtention_SweetAllert\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540a9915a5f539dbe1bf992d9fefd61e212f44da", @"/Areas/Manage/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c51811d3ad1288e8ebb226db6ea5ae46cb2e4207", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-10\">\r\n        <h1>Product Table</h1>\r\n    </div>\r\n    <div class=\"col-lg-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540a9915a5f539dbe1bf992d9fefd61e212f44da4614", async() => {
                WriteLiteral("Create Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th >#</th>
                    <th >Title</th>
                    <th >Price</th>
                    <th >Discount Price</th>
                    <th>Settings</th>
                </tr>
            </thead>
            <tbody id=""ProductTable"">
                ");
#nullable restore
#line 24 "C:\Users\nijatma\Desktop\P224_ASP_06-04-2022_FileUpload_FileExtention_SweetAllert\Pustok\Pustok\Areas\Manage\Views\Product\Index.cshtml"
           Write(await Html.PartialAsync("_ProductTablePartial",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591