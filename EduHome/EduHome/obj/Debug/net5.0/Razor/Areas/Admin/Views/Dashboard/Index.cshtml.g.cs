#pragma checksum "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa16b0b2e52ddcf4c9ef73556ea1de67640ad753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa16b0b2e52ddcf4c9ef73556ea1de67640ad753", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86e3e9ec1beb64219907f791c2b57482ae1f6cd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <div id=\"chartContainer\"></div>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <div id=\"charttContainer\"></div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://www.gstatic.com/charts/loader.js""></script>
    <script>
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Status', 'Count'],
                ['Active Blogs', ");
#nullable restore
#line 22 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Dashboard\Index.cshtml"
                            Write(ViewBag.BlogsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                [\'Deactive Blogs\', ");
#nullable restore
#line 23 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Dashboard\Index.cshtml"
                              Write(ViewBag.DeactiveBlogsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]
            ]);

            var options = {
                title: 'Blogs Chart',
                is3D: true
            };

            var chart = new google.visualization.PieChart(document.getElementById('chartContainer'));
            chart.draw(data, options);
        }
    </script>

    <script>
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Status', 'Count'],
                ['Active Courses', ");
#nullable restore
#line 43 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Dashboard\Index.cshtml"
                              Write(ViewBag.CoursesCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                [\'Deactive Courses\', ");
#nullable restore
#line 44 "C:\Users\Esma\Desktop\EduHomee\EduHome\EduHome\Areas\Admin\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.DeactiveCoursesCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]
            ]);

            var options = {
                title: 'Courses Chart',
                is3D: true
            };

            var chart = new google.visualization.PieChart(document.getElementById('charttContainer'));
            chart.draw(data, options);
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
