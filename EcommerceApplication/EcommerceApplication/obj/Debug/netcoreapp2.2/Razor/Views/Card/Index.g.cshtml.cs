#pragma checksum "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccbfaab9e071ec8cb78d5949c775adacda9bb7ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Card/Index.cshtml", typeof(AspNetCore.Views_Card_Index))]
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
#line 1 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\_ViewImports.cshtml"
using EcommerceApplication;

#line default
#line hidden
#line 2 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\_ViewImports.cshtml"
using EcommerceApplication.Models;

#line default
#line hidden
#line 3 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\_ViewImports.cshtml"
using EcommerceApplication.ViewModels.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccbfaab9e071ec8cb78d5949c775adacda9bb7ed", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a56b7ce0eb595a624325b423c3f819480b2b808", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceApplication.ViewModels.Card.CardIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Error", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
  
    ViewData["Title"] = "Carrito";
    Layout = "_FrontendLayout";

#line default
#line hidden
            BeginContext(133, 246, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n        <!-- /.row -->\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9 col-lg-9 col-sm-7\">\r\n                <div class=\"panel panel-info\">\r\n                    <div class=\"panel-heading\"> Tu carrito: ");
            EndContext();
            BeginContext(380, 44, false);
#line 12 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                                       Write(Model.CardProductVMList.Sum(p => p.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(424, 747, true);
            WriteLiteral(@" </div>
                    <div class=""panel-wrapper collapse in"" aria-expanded=""true"">
                        <div class=""panel-body"">
                            <div class=""table-responsive"">
                                <table class=""table product-overview"">
                                    <thead>
                                        <tr>
                                            <th>Nombre</th>
                                            <th>Precio</th>
                                            <th>Cantidad</th>
                                            <th>Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 26 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                         foreach (var cartitem in Model.CardProductVMList)
                                        {

#line default
#line hidden
            BeginContext(1306, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(1401, 20, false);
#line 29 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                           Write(cartitem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 57, true);
            WriteLiteral("</td>\r\n                                            <td>$ ");
            EndContext();
            BeginContext(1479, 14, false);
#line 30 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                             Write(cartitem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1549, 17, false);
#line 31 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                           Write(cartitem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1566, 57, true);
            WriteLiteral("</td>\r\n                                            <td>$ ");
            EndContext();
            BeginContext(1624, 21, false);
#line 32 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                             Write(cartitem.ProductTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1742, 509, true);
            WriteLiteral(@"
                                    </tbody>

                                </table>
                                <hr>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3 col-lg-3 col-sm-5"">
                <div class=""white-box"">
                    <h3 class=""box-title"">Lo que llevas:</h3>
                    <hr> <small>Precio total:</small>
                    <h2>$ ");
            EndContext();
            BeginContext(2252, 20, false);
#line 49 "C:\Users\Erick\source\repos\Web\EcommerceApplication\EcommerceApplication\Views\Card\Index.cshtml"
                     Write(Model.CardTotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2272, 86, true);
            WriteLiteral("</h2>\r\n\r\n                    <hr>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2358, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccbfaab9e071ec8cb78d5949c775adacda9bb7ed9698", async() => {
                BeginContext(2405, 127, true);
                WriteLiteral("\r\n                            <button class=\"btn btn-default btn-block \">Continuar comprando</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2539, 81, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2620, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccbfaab9e071ec8cb78d5949c775adacda9bb7ed11766", async() => {
                BeginContext(2645, 179, true);
                WriteLiteral("\r\n                            <p>Aún no es válida esta opción:</p>\r\n                            <button class=\"btn btn-success btn-block \">Pagar</button>\r\n                        ");
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
            BeginContext(2831, 104, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommerceApplication.ViewModels.Card.CardIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
