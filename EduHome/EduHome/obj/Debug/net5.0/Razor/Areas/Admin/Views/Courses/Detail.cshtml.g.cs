#pragma checksum "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e59f4ef72720f5d5974646efe0543b93c703b52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Courses_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Courses/Detail.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e59f4ef72720f5d5974646efe0543b93c703b52", @"/Areas/Admin/Views/Courses/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a0c480aceae0c1fc0430846b3b8389540ac9ad", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Courses_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:350px;width:350px;object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e59f4ef72720f5d5974646efe0543b93c703b524391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 27, "~/img/course/", 27, 13, true);
#nullable restore
#line 3 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
AddHtmlAttributeValue("", 40, Model.Image, 40, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 4 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
#nullable restore
#line 5 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>About Course<br />");
#nullable restore
#line 6 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
                Write(Model.CourseDetail.AboutCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Apply Course<br />");
#nullable restore
#line 7 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
                Write(Model.CourseDetail.Apply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Certification<br />");
#nullable restore
#line 8 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
                 Write(Model.CourseDetail.Certification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Course Start<br />");
#nullable restore
#line 9 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
                Write(Model.CourseDetail.Starts.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Duration<br />");
#nullable restore
#line 10 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
            Write(Model.CourseDetail.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Class Duration<br />");
#nullable restore
#line 11 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
                  Write(Model.CourseDetail.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Skill Level<br />");
#nullable restore
#line 12 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
               Write(Model.CourseDetail.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Language<br />");
#nullable restore
#line 13 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
            Write(Model.CourseDetail.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Student<br />");
#nullable restore
#line 14 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
           Write(Model.CourseDetail.Student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Course Fee<br />");
#nullable restore
#line 15 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Courses\Detail.cshtml"
              Write(Model.CourseDetail.CourseFee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e59f4ef72720f5d5974646efe0543b93c703b529260", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral("\r\n\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
