#pragma checksum "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86f91ef2a0998b35a066ae444fe29dd498afb6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86f91ef2a0998b35a066ae444fe29dd498afb6d", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7335b01999e594613dc7a9e8537178e45df8cec7", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"border d-block w-75 mx-auto\" style=\"height:50px\">\r\n            <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\r\n");
#nullable restore
#line 8 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.Coupon.Count(); i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n");
#nullable restore
#line 13 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                              
                                var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                                var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 751, "\"", 764, 1);
#nullable restore
#line 18 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 757, imgsrc, 757, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" />\r\n                        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\r\n");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                              
                                var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                                var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1248, "\"", 1261, 1);
#nullable restore
#line 29 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1254, imgsrc, 1254, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" />\r\n                        </div>\r\n");
#nullable restore
#line 31 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br /><br />

          <div class=""backgroundWhite container"">

              <ul id=""menu-filters"" class=""menu-filter-list list-inline text-center"">
                  <li class=""filter active btn btn-secondary ml-1 mr-1"" data-filter="".menu-restaurant"">Show All</li>

");
#nullable restore
#line 45 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                   foreach (var item in Model.Category)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <li class=\"filter ml-1 mr-1\" ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 47 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                                       Write(item.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 47 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 48 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </ul>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
               foreach (var category in Model.Category)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"row\" id=\"menu-wrapper\" style=\"box-shadow: 1px 2px 25px 1px #DCDCDC\">\r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d86f91ef2a0998b35a066ae444fe29dd498afb6d9138", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u => u.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                  <br />\r\n");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\ExperienceIT\ASP.NET CORE Udemy\Spice\Areas\Customer\Views\Home\Index.cshtml"
                  
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>

<script>
    var posts = $('.post');

    (function ($) {
        $(""#menu-filters li"").click(function () {
            $(""#menu-filters li"").removeClass('active btn btn-secondary');
            $(this).addClass('active btn btn-secondary');

            var selectedFilter = $(this).data(""filter"");

            $("".menu-restaurant"").fadeOut();

            setTimeout(function () {
                $(selectedFilter).slideDown();
            }, 300);
        });
    })(jQuery);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
