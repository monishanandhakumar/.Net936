#pragma checksum "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4b780cb4dc2ea7508b8f2569eacfdaba7f0d1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_GetFruits), @"mvc.1.0.view", @"/Views/Demo/GetFruits.cshtml")]
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
#line 1 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\_ViewImports.cshtml"
using PrjMVCCoreSecondApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\_ViewImports.cshtml"
using PrjMVCCoreSecondApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4b780cb4dc2ea7508b8f2569eacfdaba7f0d1c", @"/Views/Demo/GetFruits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c784eed0432ff2d84d152e45a1fbf03c89ba0b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_GetFruits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
  
    ViewData["Title"] = "GetFruits";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetFruits</h1>\r\n\r\n<h2>ViewData</h2>\r\n");
#nullable restore
#line 10 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
 foreach (var fru in ViewData["fruitsname"] as List<string>)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><b>");
#nullable restore
#line 12 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
      Write(fru);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n");
#nullable restore
#line 13 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n<h2>viewbag</h2>\r\n");
#nullable restore
#line 17 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
 foreach(var f in ViewBag.fruitname)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 19 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
   Write(f);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\OnlineTraining\LTI\July21\MVC\MVCDay2\PrjMVCCoreSecondApp\PrjMVCCoreSecondApp\Views\Demo\GetFruits.cshtml"
}

#line default
#line hidden
#nullable disable
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
