#pragma checksum "C:\Users\user\source\repos\MyBlog\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27fcb873cb37116ab96b3917e4d17f194f1ef79c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\user\source\repos\MyBlog\Views\_ViewImports.cshtml"
using MyBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27fcb873cb37116ab96b3917e4d17f194f1ef79c", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b889b3f4308041dc292b61010b9c4781c7386c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-10 mx-auto"">
                <ul class=""list-inline text-center"">
                    <li class=""list-inline-item"">
                        <a href=""#"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fas fa-circle fa-stack-2x""></i>
                                <i class=""fab fa-twitter fa-stack-1x fa-inverse""></i>
                            </span>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a href=""#"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fas fa-circle fa-stack-2x""></i>
                                <i class=""fab fa-facebook-f fa-stack-1x fa-inverse""></i>
                            </span>
                        </a>
                    </li>
                    <li class=""list-i");
            WriteLiteral(@"nline-item"">
                        <a href=""#"">
                            <span class=""fa-stack fa-lg"">
                                <i class=""fas fa-circle fa-stack-2x""></i>
                                <i class=""fab fa-github fa-stack-1x fa-inverse""></i>
                            </span>
                        </a>
                    </li>
                </ul>
                <p class=""copyright text-muted"">Copyright &copy; MyBlog ");
#nullable restore
#line 32 "C:\Users\user\source\repos\MyBlog\Views\Shared\Components\Footer\Default.cshtml"
                                                                   Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n");
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
