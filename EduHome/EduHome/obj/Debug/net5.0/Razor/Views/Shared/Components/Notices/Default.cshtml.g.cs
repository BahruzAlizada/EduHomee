#pragma checksum "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\Shared\Components\Notices\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a663b2a2151029adf258f1b4389543890b0023d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notices_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notices/Default.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models.HomeVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a663b2a2151029adf258f1b4389543890b0023d5", @"/Views/Shared/Components/Notices/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12595893c504d51562e64b077b5eee4604670a3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Notices_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notice>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\Shared\Components\Notices\Default.cshtml"
 foreach(Notice notice in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"single-notice-left mb-23 pb-20\">\r\n        <h4>");
#nullable restore
#line 6 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\Shared\Components\Notices\Default.cshtml"
       Write(notice.CreatedTime.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 7 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\Shared\Components\Notices\Default.cshtml"
      Write(notice.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Views\Shared\Components\Notices\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notice>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591