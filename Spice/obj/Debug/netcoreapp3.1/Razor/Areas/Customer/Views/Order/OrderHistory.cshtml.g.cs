#pragma checksum "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e582a3f59a3d1f10a4dfaa56425a2ee25749a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
using Spice.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e582a3f59a3d1f10a4dfaa56425a2ee25749a1", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7335b01999e594613dc7a9e8537178e45df8cec7", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Spice.TagHelpers.PageLinkTagHelper __Spice_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
  
    ViewData["Title"] = "Order History";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<div class=""border backgroundWhite"">
    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info""> Order List</h2>
        </div>
        <div class=""col-4"">

        </div>
        <div class=""col-2 text-right"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e582a3f59a3d1f10a4dfaa56425a2ee25749a16442", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if (Model.Orders.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border\" style=\"box-shadow: 1px 2px 25px 1px #DCDCDC\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 42 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Total Items\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n\r\n");
#nullable restore
#line 50 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                 foreach (var item in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <button type=\"submit\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 72 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                           Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                <i class=\"fas fa-info-circle\"></i> Details\r\n                            </button>\r\n\r\n");
#nullable restore
#line 76 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                             if (item.OrderHeader.Status == SD.StatusSubmitted || item.OrderHeader.Status == SD.StatusInProcess || item.OrderHeader.Status == SD.StatusCompleted || item.OrderHeader.Status == SD.StatusReady)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-info btnOrderStatus\" data-id=\"");
#nullable restore
#line 78 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                              Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                    <i class=\"fas fa-clock\"></i> Status\r\n                                </button>\r\n");
#nullable restore
#line 81 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 84 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e582a3f59a3d1f10a4dfaa56425a2ee25749a115528", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __Spice_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Spice.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Spice_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 86 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Spice_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 86 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Spice_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Spice_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Spice_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n");
#nullable restore
#line 89 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No category exists...</p>\r\n");
#nullable restore
#line 93 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-centered modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class=""modal-title"">Order Details</h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myModalContent"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""myOrderStatus"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-info text-light justify-content-center"">
                <h5 class=""modal-title"">Order");
            WriteLiteral(@" Status </h5>
            </div>
            <div class=""modal-body justify-content-center"" id='myOrderStatusContent'>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var PostBackURL = '/Customer/Order/GetOrderDetails';
        var OrderStatusURL = '/Customer/Order/GetOrderStatus';

        $(function () {
            $("".anchorDetail"").click(function () {
                var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');
                $.ajax({
                    type: ""GET"",
                    url: PostBackURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    datatyype: ""json"",
                    success: function (data) {
                        $('#myModalContent').html(data);
                        $('#myModal').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed"");
                    }
                });
            });

            $("".btnOrderStatus"").click(function () {
        ");
                WriteLiteral(@"        var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');
                $.ajax({
                    type: ""GET"",
                    url: OrderStatusURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    datatype: ""json"",
                    success: function (data) {
                        $('#myOrderStatusContent').html(data);
                        $('#myOrderStatus').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed."");
                    }
                });
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
