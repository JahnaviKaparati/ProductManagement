#pragma checksum "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61146c9f4ae620221d0e016023e602f03e4d3d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ShowCart), @"mvc.1.0.view", @"/Views/Cart/ShowCart.cshtml")]
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
#line 1 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
using ProductManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61146c9f4ae620221d0e016023e602f03e4d3d88", @"/Views/Cart/ShowCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c080bb828670149ae3d5dcdc557160bd745a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ShowCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-info float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width : 100px;height: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
  
    ViewData["Title"] = "ShowCart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowCart</h1>\r\n");
#nullable restore
#line 7 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron bg-white border border-light rounded m-5 p-4"">
        <div class=""container border border-secondary rounded mb-5"">
            <div class=""row bg-dark p-2"">
                <div class=""col-sm-12 my-auto"">
                    <i class='fa fa-shopping-cart text-white'></i><span class=""text-white ml-3"">Shopping Cart</span>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61146c9f4ae620221d0e016023e602f03e4d3d886146", async() => {
                WriteLiteral("Continue Shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 17 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
             if(Model.Count==0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1 style=\"color:darkred\">No Items in Cart</h1>\r\n");
#nullable restore
#line 20 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row p-3\">\r\n                    <div class=\"col-sm-auto p-0\">\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61146c9f4ae620221d0e016023e602f03e4d3d888775", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1131, "~/Images/", 1131, 9, true);
#nullable restore
#line 26 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
AddHtmlAttributeValue("", 1140, item.Product.Image, 1140, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-5\">\r\n                        <h5 style=\"color:black\">");
#nullable restore
#line 30 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
                                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p style=\"color:black\">\r\n                            ");
#nullable restore
#line 32 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
                       Write(item.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"col-sm-2 font-weight-bolder\">\r\n                        $<span class=\"itemPrice\" style=\"color:black\"> ");
#nullable restore
#line 36 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
                                                                 Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &nbsp; &#10005;  <span style=\"color:black\"> ");
#nullable restore
#line 36 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
                                                                                                                                        Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                    </div>\r\n                    <div class=\"col-sm-3 text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1865, "\"", 1909, 3);
            WriteAttributeValue("", 1872, "CartItemCount?id=", 1872, 17, true);
#nullable restore
#line 39 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
WriteAttributeValue("", 1889, item.Id, 1889, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1897, "&type=remove", 1897, 12, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\" data-ajax=\"true\" data-ajax-method=\"GET\" data-ajax-success=\"AjaxSuccess1\" data-ajax-failure=\"AjaxError1\" font-weight-bold text-white\" onclick=\"removeProduct(this)\"><i class=\"fa fa-minus\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2163, "\"", 2204, 3);
            WriteAttributeValue("", 2170, "CartItemCount?id=", 2170, 17, true);
#nullable restore
#line 40 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
WriteAttributeValue("", 2187, item.Id, 2187, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2195, "&type=add", 2195, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-info font-weight-bold text-white\" data-ajax=\"true\" data-ajax-method=\"GET\" data-ajax-success=\"AjaxSuccess\" data-ajax-failure=\"AjaxError\" onclick=\"addProduct(this)\"><i class=\"fa fa-plus\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2449, "\"", 2478, 2);
            WriteAttributeValue("", 2456, "DeleteItem?id=", 2456, 14, true);
#nullable restore
#line 41 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
WriteAttributeValue("", 2470, item.Id, 2470, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-outline-danger font-weight-bold ml-3"" data-ajax=""true"" data-ajax-method=""GET"" data-ajax-success=""AjaxSuccess1"" data-ajax-failure=""AjaxError1"" onclick=""hideBlock(this)""><i class=""fa fa-trash-o""></i></a>
                    </div>
                </div>
                <hr class=""mt-0"" />
");
#nullable restore
#line 45 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row mr-0 mt-2"">
                <div class=""col-sm float-right pr-0"">
                    <div class=""container-sm border border-info rounded p-2 pr-0"" style=""width : 60%;"">
                        <span class=""text-info"">Total (USD)</span>
                        <span class=""text-info float-right font-weight-bolder"">$<span id=""totalPrice"">0.0</span></span>
                    </div>
                </div>
            </div>
            <hr class=""m-0"" />
            <div class=""row p-2 m-0"">
");
#nullable restore
#line 56 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
                 if (Model.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm m-0\">\r\n                    <a href=\"Summary\" class=\"btn btn-success float-right\" style=\"width:12rem;\">Summary</a>\r\n                </div>\r\n");
#nullable restore
#line 61 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 65 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Identity/Account/Register\" class=\"btn btn-success\">Register</a>\r\n    <a href=\"/Identity/Account/Login\" class=\"btn btn-success\">Login</a>\r\n");
#nullable restore
#line 70 "F:\DotNetBatchJan2021\WebApps\ProductManagement\ProductManagement\Views\Cart\ShowCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>

    let arr = document.getElementsByClassName(""itemPrice"");

    var sum = 0;

    for (let i = 0; i < arr.length; i++) {
        let val = parseFloat(arr[i].innerText) * parseInt(arr[i].nextElementSibling.innerText);
        sum = sum + val;
    }
    sum = Math.round(sum * 1000) / 1000;
    document.getElementById(""totalPrice"").innerText = sum;
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
