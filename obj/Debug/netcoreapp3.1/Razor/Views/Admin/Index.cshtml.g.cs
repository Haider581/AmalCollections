#pragma checksum "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f51371ab3a8aa57620d385e994b85d007c809c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f51371ab3a8aa57620d385e994b85d007c809c", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b29fcb84919f455c61992dba0be8d0cab5ce915", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AmalCollections.Data.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Orders</h1>\r\n<br />\r\n\r\n<table id=\"myTable\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DocId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Qty\r\n            </th>\r\n            <th>Amount</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DocId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
                Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "D:\Projects\Web\Haider Bhai\AmalCollections 14-10-2020\AmalCollections\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AmalCollections.Data.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
