#pragma checksum "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6805c980ed48077839331b51ac7f7ab77756507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu__UserMenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
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
#line 1 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
using GymManager.Core.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6805c980ed48077839331b51ac7f7ab77756507", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AppMenu__UserMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Web.Models.UserMenuItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
  
    var orderedChildMenuItems = Model.MenuItem.Items.OrderBy(x=> x.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
 if (Model.MenuItem.Items.Count < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 254, "\"", 425, 3);
            WriteAttributeValue("", 262, "nav-link", 262, 8, true);
#nullable restore
#line 11 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 270, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 271, 69, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 340, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "aria-current=\"page\"" : "", 341, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 11 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                           Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </li>\r\n");
#nullable restore
#line 13 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}
else
{
    string curremtElementId = "menu-" + new Random().Next();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item dropdown\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 602, "\"", 705, 3);
            WriteAttributeValue("", 610, "nav-link", 610, 8, true);
            WriteAttributeValue(" ", 618, "dropdown-toggle", 619, 16, true);
#nullable restore
#line 19 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("  ", 634, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 636, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"");
            BeginWriteAttribute("id", " id=\"", 715, "\"", 737, 1);
#nullable restore
#line 19 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 720, curremtElementId, 720, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">");
#nullable restore
#line 19 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                              Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <ul class=\"dropdown-menu\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 853, "\"", 888, 1);
#nullable restore
#line 20 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 871, curremtElementId, 871, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 21 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
            foreach(var subMenu in Model.MenuItem.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1027, 1);
#nullable restore
#line 23 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1015, subMenu.Url, 1015, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                           Write(subMenu.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 24 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </li>    \r\n");
#nullable restore
#line 28 "D:\1. PUNTO SINGULAR\Academia\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Web.Models.UserMenuItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
