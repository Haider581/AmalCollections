#pragma checksum "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c8d7ac20d0f776b13a7777b562d68f02fe8957c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\_ViewImports.cshtml"
using AmalCollections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\_ViewImports.cshtml"
using AmalCollections.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c8d7ac20d0f776b13a7777b562d68f02fe8957c", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b29fcb84919f455c61992dba0be8d0cab5ce915", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AmalCollections.Data.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/cart_responsive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("coupon_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("coupon_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c7811", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c8925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""cart_section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <div class=""cart_container"">

                        <!-- Cart Bar -->
                        <div class=""cart_bar"">
                            <ul class=""cart_bar_list item_list d-flex flex-row align-items-center justify-content-end"">
                                <li class=""mr-auto"">Product</li>
                                <li>Price</li>
                                <li>Quantity</li>
                                <li>Total</li>
                            </ul>
                        </div>

                        <!-- Cart Items -->
                        <div class=""cart_items"">
                            <ul class=""cart_items_list"">

");
#nullable restore
#line 31 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!-- Cart Item -->
                                    <li class=""cart_item item_list d-flex flex-lg-row flex-column align-items-lg-center align-items-start justify-content-lg-end justify-content-start"">
                                        <div class=""product d-flex flex-lg-row flex-column align-items-lg-center align-items-start justify-content-start mr-auto"">
                                            <div><div class=""product_number"">1</div></div>
                                            <div><div class=""product_image"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c12013", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1737, "~/images/products/", 1737, 18, true);
#nullable restore
#line 37 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1755, item.Product.ProductImages.FirstOrDefault().ImagePath, 1755, 54, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div></div>\r\n                                            <div class=\"product_name_container\">\r\n                                                <div class=\"product_name\"><a href=\"product.html\">");
#nullable restore
#line 39 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
                                                                                            Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></div>
                                                <div class=""product_text"">Second line for additional info</div>
                                            </div>
                                        </div>
                                        <div class=""Rate product_price product_text"">");
#nullable restore
#line 43 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
                                                                                Write(item.Product.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                        <div class=""product_quantity_container"">
                                            <div class=""product_quantity ml-lg-auto mr-lg-auto text-center"">
                                                <span class=""Qty product_text product_num"">");
#nullable restore
#line 46 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
                                                                                      Write(item.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2723, "\"", 2764, 4);
            WriteAttributeValue("", 2733, "AddToCart(", 2733, 10, true);
#nullable restore
#line 47 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2743, item.Product.Id, 2743, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2759, ",", 2759, 1, true);
            WriteAttributeValue(" ", 2760, "-1)", 2761, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"qty_sub qty_button trans_200 text-center\"><span>-</span></div>\r\n                                                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2889, "\"", 2929, 4);
            WriteAttributeValue("", 2899, "AddToCart(", 2899, 10, true);
#nullable restore
#line 48 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2909, item.Product.Id, 2909, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2925, ",", 2925, 1, true);
            WriteAttributeValue(" ", 2926, "1)", 2927, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""qty_add qty_button trans_200 text-center""><span>+</span></div>
                                            </div>
                                        </div>
                                        <div class=""totalAmount product_total product_text""></div>
                                    </li>
");
#nullable restore
#line 53 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>

                        </div>

                        <!-- Cart Buttons -->
                        <div class=""cart_buttons d-flex flex-row align-items-start justify-content-start"">
                            <div class=""cart_buttons_inner ml-sm-auto d-flex flex-row align-items-start justify-content-start flex-wrap"">
                                <div class=""button button_clear trans_200""><a href=""categories.html"">clear cart</a></div>
                                <div class=""button button_continue trans_200""><a href=""categories.html"">continue shopping</a></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row cart_extra_row"">
                <div class=""col-lg-6"">
                    <div class=""cart_extra cart_extra_1"">
                        <div class=""cart_extra_content cart_extra_coupon"">
                            <div class=""ca");
            WriteLiteral("rt_extra_title\">Coupon code</div>\r\n                            <div class=\"coupon_form_container\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c18569", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" class=\"coupon_input\" required=\"required\">\r\n                                    <button class=\"coupon_button\">apply</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""coupon_text"">Phasellus sit amet nunc eros. Sed nec congue tellus. Aenean nulla nisl, volutpat blandit lorem ut.</div>
                            <div class=""shipping"">
                                <div class=""cart_extra_title"">Shipping Method</div>
                                <ul>
                                    <li class=""shipping_option d-flex flex-row align-items-center justify-content-start"">
                                        <label class=""radio_container"">
                                            <input type=""radio"" id=""radio_1"" name=""shipping_radio"" class=""shipping_radio"">
                                            <span class=""radio_mark""></span>
                                            <span class=""radio_text"">Next day delivery</span>
                                        </label>
                                        <div class=""shipping_price ml-auto"">$4.99</div>
                    ");
            WriteLiteral(@"                </li>
                                    <li class=""shipping_option d-flex flex-row align-items-center justify-content-start"">
                                        <label class=""radio_container"">
                                            <input type=""radio"" id=""radio_2"" name=""shipping_radio"" class=""shipping_radio"">
                                            <span class=""radio_mark""></span>
                                            <span class=""radio_text"">Standard delivery</span>
                                        </label>
                                        <div class=""shipping_price ml-auto"">$1.99</div>
                                    </li>
                                    <li class=""shipping_option d-flex flex-row align-items-center justify-content-start"">
                                        <label class=""radio_container"">
                                            <input type=""radio"" id=""radio_3"" name=""shipping_radio"" class=""shipping_radio"" checked>");
            WriteLiteral(@"
                                            <span class=""radio_mark""></span>
                                            <span class=""radio_text"">Personal Pickup</span>
                                        </label>
                                        <div class=""shipping_price ml-auto"">Free</div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 cart_extra_col"">
                    <div class=""cart_extra cart_extra_2"">
                        <div class=""cart_extra_content cart_extra_total"">
                            <div class=""cart_extra_title"">Cart Total</div>
                            <ul class=""cart_extra_total_list"">
                                <li class=""d-flex flex-row align-items-center justify-content-start"">
                                    <div class=""cart_extra_total_title"">Subtota");
            WriteLiteral(@"l</div>
                                    <div class="" SubTotal cart_extra_total_value ml-auto""></div>
                                </li>
                                <li class=""d-flex flex-row align-items-center justify-content-start"">
                                    <div class=""cart_extra_total_title"">Shipping</div>
                                    <div class=""cart_extra_total_value ml-auto"">Free</div>
                                </li>
                                <li class=""d-flex flex-row align-items-center justify-content-start"">
                                    <div class=""cart_extra_total_title"">Total</div>
                                    <div class=""GrandTotal cart_extra_total_value ml-auto""></div>
                                </li>
                            </ul>
                            <div class=""checkout_button trans_200"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c24425", async() => {
                WriteLiteral("proceed to checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 138 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-center\">Your cart is empty</h3>\r\n    <div class=\"button button_continue trans_200\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c26279", async() => {
                WriteLiteral("continue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 143 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c8d7ac20d0f776b13a7777b562d68f02fe8957c27981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script>\r\n    Calc();\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AmalCollections.Data.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591