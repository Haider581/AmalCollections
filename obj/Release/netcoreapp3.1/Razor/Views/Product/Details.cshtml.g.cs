#pragma checksum "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8a931685ddd6dbcbb2aab71554016ca1ec9106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\_ViewImports.cshtml"
using AmalCollections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\_ViewImports.cshtml"
using AmalCollections.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8a931685ddd6dbcbb2aab71554016ca1ec9106", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b29fcb84919f455c61992dba0be8d0cab5ce915", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AmalCollections.Data.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mainImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("thumbImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Product Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    .borderblack {
        border: 3px solid black;
    }

    .mainImg {
        height: 500px;
        max-width: 100%;
    }

    .thumbCont {
        padding: 10px;
    }

    .thumbImg {
        height: 150px;
        max-width: 100%;
    }
    .btn-black{
        width: 100%;
    }
    .description {
        color: black !important;
    }
    ");
            WriteLiteral(@"@media (max-width: 767px) {
        .thumbCont {
            padding: 0px;
            margin-top: 5px;
        }
        .btn-black {
            margin-top: 5px;
        }
    }
</style>
<br />
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-7"">
            <div class=""row"">
                <div class=""col-md-8"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc8a931685ddd6dbcbb2aab71554016ca1ec91064910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 880, "~/images/products/", 880, 18, true);
#nullable restore
#line 47 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 898, Model.ProductImages.FirstOrDefault().ImagePath, 898, 47, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 51 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
                         foreach (var item in Model.ProductImages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 col-sm-4 col-md-12\">\r\n                                <div class=\"thumbCont\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc8a931685ddd6dbcbb2aab71554016ca1ec91067101", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1337, "~/images/products/", 1337, 18, true);
#nullable restore
#line 55 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1355, item.ImagePath, 1355, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 58 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-5 description\">\r\n            <h2>");
#nullable restore
#line 64 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h4>Rs. ");
#nullable restore
#line 65 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
               Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <p><b>Quantity</b></p>
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""quantity buttons_added"">
                        <input type=""button"" value=""-"" class=""minus""><input readonly type=""number"" step=""1"" min=""1""");
            BeginWriteAttribute("max", " max=\"", 1968, "\"", 1974, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"quantity\" value=\"1\" title=\"Qty\" class=\"input-text qty text\" size=\"4\"");
            BeginWriteAttribute("pattern", " pattern=\"", 2050, "\"", 2060, 0);
            EndWriteAttribute();
            BeginWriteAttribute("inputmode", " inputmode=\"", 2061, "\"", 2073, 0);
            EndWriteAttribute();
            WriteLiteral(@"><input type=""button"" value=""+"" class=""plus"">
                    </div>
                </div>
                <div class=""col-md-9"">
                    <button id=""btnAdd"" class=""btn btn-black"">Add to Cart</button>
                </div>
            </div>
            <br />
            <h3>
                <b>Description</b>
            </h3>
            <p>
                ");
#nullable restore
#line 82 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('document').ready(function () {
            //Zoom
            $(function () {
                $('.mainImg').okzoom({
                    width: 200,
                    height: 200
                });
            });

            //click
            $('.minus').click(function () {
                var qty = parseInt($('.qty').val());
                if (qty > 1) {
                    qty = qty - 1;
                }
                $('.qty').val(qty);
            })
            $('.plus').click(function () {
                var qty = parseInt($('.qty').val());
                qty = qty + 1;
                $('.qty').val(qty);
            })
            $('.thumbImg').on('click', function () {
                var newAtr = $(this).attr('src');
                $('.mainImg').attr('src', newAtr);
                $('.thumbImg').each(function () {
                    $(this).removeClass('borderblack');
                });
                $(this).addClass('borderb");
                WriteLiteral("lack\');\r\n            })\r\n            $(\'#btnAdd\').click(function () {\r\n                var productId = ");
#nullable restore
#line 121 "D:\Projects\Web\Haider Bhai\AmalCollections\AmalCollections\Views\Product\Details.cshtml"
                           Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                var qty = parseInt($('.qty').val());
                $.when(AddToCart(productId, qty)).done(function () {
                    $.confirm({
                        title: 'Question',
                        content: 'Item added to cart',
                        theme: 'supervan',
                        buttons: {
                            ""Continue Shopping"": function () {
                                window.location.href = '/Product/Index/7?catId=1&sortId=7';
                            },
                            ""Checkout"": function () {
                                window.location.href = '/Cart/CartDetail';
                            }
                        }
                    })
                })
            })
        })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AmalCollections.Data.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
