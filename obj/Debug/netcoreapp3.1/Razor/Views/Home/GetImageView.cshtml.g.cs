#pragma checksum "C:\Users\Федоров Георгий\source\repos\net\net\Views\Home\GetImageView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f712b686fbb51ac10648de9fa5daca1f4f64dca2eda123b8c0b96cce6e9f5a6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetImageView), @"mvc.1.0.view", @"/Views/Home/GetImageView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Федоров Георгий\source\repos\net\net\Views\_ViewImports.cshtml"
using net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Федоров Георгий\source\repos\net\net\Views\_ViewImports.cshtml"
using net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f712b686fbb51ac10648de9fa5daca1f4f64dca2eda123b8c0b96cce6e9f5a6f", @"/Views/Home/GetImageView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f726c983709d4aacafef73a622402e2bdc554633f16316b2033236310e4cc95f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_GetImageView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Федоров Георгий\source\repos\net\net\Views\Home\GetImageView.cshtml"
  
    ViewData["Title"] = "Image View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 5 "C:\Users\Федоров Георгий\source\repos\net\net\Views\Home\GetImageView.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 81, "\"", 127, 1);
#nullable restore
#line 6 "C:\Users\Федоров Георгий\source\repos\net\net\Views\Home\GetImageView.cshtml"
WriteAttributeValue("", 87, Url.Action("GetImageBindMount", "Home"), 87, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Изображение из Bind Mount\"/>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 168, "\"", 211, 1);
#nullable restore
#line 7 "C:\Users\Федоров Георгий\source\repos\net\net\Views\Home\GetImageView.cshtml"
WriteAttributeValue("", 174, Url.Action("GetImageVolume", "Home"), 174, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Изображение из Volume\"/>\r\n");
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
