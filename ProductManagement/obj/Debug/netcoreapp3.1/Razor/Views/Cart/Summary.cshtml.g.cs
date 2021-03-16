#pragma checksum "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352ac980551f7002bc07984ad1a667ce61b1d2e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Summary), @"mvc.1.0.view", @"/Views/Cart/Summary.cshtml")]
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
#line 1 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\_ViewImports.cshtml"
using ProductManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\_ViewImports.cshtml"
using ProductManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352ac980551f7002bc07984ad1a667ce61b1d2e7", @"/Views/Cart/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c080bb828670149ae3d5dcdc557160bd745a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductManagement.Models.ShoppingCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("justify-content-center mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
  
    ViewData["Title"] = "Summary";
    double total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Summary</h1>
<div class=""jumbotron bg-white border border-light rounded m-5 p-4"">
    <div class=""container w-75 border  border-secondary rounded mb-5"">
        <div class=""row bg-dark p-2"">

            <div class=""col-sm-12 my-auto"">
                <i class='fa fa-shopping-cart text-white'></i><span class=""text-white ml-3"">Order Summary</span>
                <a href=""/Cart/ShowCart"" class=""btn btn-sm btn-outline-info float-right"">Back to Cart</a>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352ac980551f7002bc07984ad1a667ce61b1d2e74888", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"Name\">Email</label>\r\n                <input type=\"text\" class=\"form-control \"");
                BeginWriteAttribute("value", " value=\"", 825, "\"", 852, 1);
#nullable restore
#line 20 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
WriteAttributeValue("", 833, User.Identity.Name, 833, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Name\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Phone</label>\r\n                <input type=\"text\" class=\"form-control \" ");
                WriteLiteral(" placeholder=\"Enter Phone Number\" required>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Date of Order</label>\r\n                <input type=\"text\" class=\"form-control \"");
                BeginWriteAttribute("value", " value=\"", 1275, "\"", 1296, 1);
#nullable restore
#line 28 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
WriteAttributeValue("", 1283, DateTime.Now, 1283, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
            </div>
            <div class=""form-group"">
                <label>Address</label>
                <textarea class=""form-control"" placeholder=""Enter Address"">Address</textarea>
            </div>


            <ul class=""list-group"">
                <li class=""list-group-item active text-white"">Order Summary</li>
");
#nullable restore
#line 38 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
                 foreach (var product in Model)
                {
                    total = total + product.Count * product.Product.Price;


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"list-group-item\"> ");
#nullable restore
#line 42 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
                                            Write(product.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp; &#10005; ");
#nullable restore
#line 42 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
                                                                                  Write(product.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span class=\"float-right font-weight-bold\">$");
#nullable restore
#line 42 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
                                                                                                                                              Write(  product.Count * product.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n");
#nullable restore
#line 43 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\r\n                    <span class=\"font-weight-bolder\">Grand Total : $</span><span");
                BeginWriteAttribute("class", " class=\"", 2138, "\"", 2146, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 45 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\Summary.cshtml"
                                                                                     Write(total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </li>\r\n            </ul>\r\n\r\n            <button type=\"button\" data-toggle=\"modal\" data-target=\".bd-example-modal-lg\" class=\"btn btn-info btn-block m-1 mt-4 \">Place Order</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade bd-example-modal-lg\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myLargeModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog modal-lg\"style=\"background-color:#8ccab7\">");
            WriteLiteral(@"
        <div class=""modal-content w-100"">
            <div class=""py-3 my-auto bg-light"" style=""width : 100%;"">
                <div class=""row"">
                    <div class=""col-12 col-sm-8 col-md-6 col-lg-4 mx-auto"">
                        <div id=""pay-invoice"" class=""card"">
                            <div class=""card-body"">
                                <div class=""card-title"">
                                    <h3 class=""text-center"">Pay Invoice</h3>
                                </div>
                                <hr>
");
            WriteLiteral(@"

                                <div class=""form-group"">
                                    <label for=""cc-number"" class=""control-label mb-1"">Card number</label>
                                    <input id=""cc-number"" name=""cc-number"" type=""tel"" class=""form-control cc-number identified visa"" required autocomplete=""off"">
                                    <span class=""invalid-feedback"">Enter a valid 12 to 16 digit card number</span>
                                </div>
                                <div class=""row"">
                                    <div class=""col-6"">
                                        <div class=""form-group"">
                                            <label for=""cc-exp"" class=""control-label mb-1"">Expiration</label>
                                            <input id=""cc-exp"" name=""cc-exp"" type=""tel"" class=""form-control cc-exp"" required placeholder=""MM / YY"" autocomplete=""cc-exp"">
                                            <span class=""invalid-feedback"">Enter");
            WriteLiteral(@" the expiration date</span>
                                        </div>
                                    </div>
                                    <div class=""col-6"">
                                        <label for=""x_card_code"" class=""control-label mb-1"">CVV</label>
                                        <div class=""input-group"">
                                            <input id=""x_card_code"" name=""x_card_code"" type=""tel"" class=""form-control cc-cvc"" required autocomplete=""off"">
                                            <span class=""invalid-feedback order-last"">Enter the 3-digit code on back</span>
                                            <div class=""input-group-append"">
                                                <div class=""input-group-text"">
                                                    <span class=""fa fa-question-circle fa-lg"" data-toggle=""popover"" data-container=""body"" data-html=""true"" data-title=""CVV""
                                                          data");
            WriteLiteral(@"-content=""<div class='text-center one-card'>The 3 digit code on back of the card..<div class='visa-mc-cvc-preview'></div></div>""
                                                          data-trigger=""hover""></span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label for=""x_zip"" class=""control-label mb-1"">Mob No</label>
                                    <input id=""x_zip"" name=""x_zip"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5982, "\"", 5990, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-val=""true"" data-val-required=""Please enter the ZIP/Postal code"" autocomplete=""postal-code"">
                                    <span class=""help-block"" data-valmsg-for=""x_zip"" data-valmsg-replace=""true""></span>
                                </div>
                                <div class=""form-group"">
                                    <label for=""x_promotion"" class=""control-label mb-1"">OTP</label>
                                    <input id=""x_promotion"" name=""x_prom"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 6516, "\"", 6524, 0);
            EndWriteAttribute();
            WriteLiteral(" data-val=\"true\" data-val-required=\"otp\">\r\n                                    <span class=\"help-block\" data-valmsg-for=\"x_promotion\" data-valmsg-replace=\"true\"></span>\r\n                                </div>\r\n\r\n");
            WriteLiteral(@"                                <div>
                                    <a href=""/Cart/ClearCartItems"">
                                        <div id=""payment-button"" type=""submit"" class=""btn btn-lg btn-info btn-block"">
                                            <i class=""fa fa-lock fa-lg""></i>&nbsp;
                                            <span>Pay </span>
                                        </div>
                                    </a>
                                </div>
");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "352ac980551f7002bc07984ad1a667ce61b1d2e716223", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductManagement.Models.ShoppingCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
