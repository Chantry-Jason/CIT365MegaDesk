#pragma checksum "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf5c53a1dcc3cc8b30721ec745422992a8001e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDesk.Pages.Quotes.Pages_Quotes_Delete), @"mvc.1.0.razor-page", @"/Pages/Quotes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Quotes/Delete.cshtml", typeof(MegaDesk.Pages.Quotes.Pages_Quotes_Delete), @"{id:int?}")]
namespace MegaDesk.Pages.Quotes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\_ViewImports.cshtml"
using MegaDesk;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf5c53a1dcc3cc8b30721ec745422992a8001e8", @"/Pages/Quotes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460365d825535bcbd8bf03b94cf81c137a23c898", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Quotes_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(105, 226, true);
            WriteLiteral("<article class=\"quoteTable\">\r\n    <h2>Delete</h2>\r\n\r\n    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>Quote</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(332, 46, false);
#line 16 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.name));

#line default
#line hidden
            EndContext();
            BeginContext(378, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(434, 42, false);
#line 19 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.name));

#line default
#line hidden
            EndContext();
            BeginContext(476, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(532, 47, false);
#line 22 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.width));

#line default
#line hidden
            EndContext();
            BeginContext(579, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(635, 43, false);
#line 25 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.width));

#line default
#line hidden
            EndContext();
            BeginContext(678, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(734, 47, false);
#line 28 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.depth));

#line default
#line hidden
            EndContext();
            BeginContext(781, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(837, 43, false);
#line 31 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.depth));

#line default
#line hidden
            EndContext();
            BeginContext(880, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(936, 52, false);
#line 34 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.numDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(988, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1044, 48, false);
#line 37 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.numDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1148, 47, false);
#line 40 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.price));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1251, 43, false);
#line 43 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.price));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1350, 52, false);
#line 46 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.surfaceMat));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1458, 48, false);
#line 49 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.surfaceMat));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1562, 49, false);
#line 52 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.rushOrd));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1667, 45, false);
#line 55 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.rushOrd));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1768, 51, false);
#line 58 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1875, 47, false);
#line 61 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Quote.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1922, 46, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            EndContext();
            BeginContext(1968, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17a92f1cbf004fbdbca869e9f9ef5f2e", async() => {
                BeginContext(1988, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2002, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65b930413bb04e98a49450639c8ec103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\jchantry\source\repos\CIT365MegaDesk\CIT365MegaDesk\RazorPagesMovie\Pages\Quotes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Quote.ID);

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
                BeginContext(2044, 92, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
                EndContext();
                BeginContext(2136, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12bfc5a2a1524c578e93ffa025fc5cbe", async() => {
                    BeginContext(2158, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2174, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2191, 24, true);
            WriteLiteral("\r\n    </div>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDesk.Pages.Quotes.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk.Pages.Quotes.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk.Pages.Quotes.DeleteModel>)PageContext?.ViewData;
        public MegaDesk.Pages.Quotes.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
