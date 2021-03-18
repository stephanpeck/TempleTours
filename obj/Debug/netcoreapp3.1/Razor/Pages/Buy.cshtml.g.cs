#pragma checksum "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4281635e3dc3956c28b280a2e0b1342a818abb7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TempleToursProject.Pages.Pages_Buy), @"mvc.1.0.razor-page", @"/Pages/Buy.cshtml")]
namespace TempleToursProject.Pages
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
#line 2 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\_ViewImports.cshtml"
using TempleToursProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\_ViewImports.cshtml"
using TempleToursProject.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4281635e3dc3956c28b280a2e0b1342a818abb7b", @"/Pages/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf586428bb4f6d486e77ca9ad92ddef5564bb84", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
  
    ViewBag.Title = "Your Tours";
    ViewBag.SubTitle = "";
    ViewBag.Background = "/img/mountain.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<span class=\"float-right\"><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 215, "\"", 238, 1);
#nullable restore
#line 12 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
WriteAttributeValue("", 222, Model.ReturnUrl, 222, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Back to Available Tours</a></span>

<table class=""table table-hover"">

    <thead>
        <tr>
            <th scope=""col"">Book</th>
            <th scope=""col"">Quantity</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Subtotal</th>
        </tr>
    </thead>
");
            WriteLiteral("    <tbody>\n");
#nullable restore
#line 26 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td class=\"text-left\">");
#nullable restore
#line 29 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
                             Write(line.GroupInfo.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-left\">");
#nullable restore
#line 30 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
                             Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-left\">");
#nullable restore
#line 31 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
                             Write(line.GroupInfo.GroupSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
            WriteLiteral("            <td class=\"text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4281635e3dc3956c28b280a2e0b1342a818abb7b6225", async() => {
                WriteLiteral("\n                    <input type=\"hidden\" name=\"BookID\"");
                BeginWriteAttribute("value", "\n                           value=\"", 1089, "\"", 1151, 1);
#nullable restore
#line 37 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
WriteAttributeValue("", 1124, line.GroupInfo.GroupInfoId, 1124, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\n                           value=\"", 1213, "\"", 1264, 1);
#nullable restore
#line 39 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
WriteAttributeValue("", 1248, Model.ReturnUrl, 1248, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">\n                        Remove\n                    </button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n\n\n");
            WriteLiteral("        </tr>\n");
#nullable restore
#line 50 "C:\Users\steph\Source\Repos\TempleToursCombo\Pages\Buy.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\"><b>Total:</b></td>\n        </tr>\n    </tfoot>\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TempleToursProject.Pages.BuyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TempleToursProject.Pages.BuyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TempleToursProject.Pages.BuyModel>)PageContext?.ViewData;
        public TempleToursProject.Pages.BuyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
