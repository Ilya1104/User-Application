#pragma checksum "E:\TEST\UserApp\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779fd041e36246d6676cf8f98002fd73226ba666"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
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
#line 1 "E:\TEST\UserApp\Views\_ViewImports.cshtml"
using UserApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TEST\UserApp\Views\_ViewImports.cshtml"
using UserApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779fd041e36246d6676cf8f98002fd73226ba666", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e34c925b69d60b81f4781e86e696c35aaaca0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\TEST\UserApp\Views\Home\Contacts.cshtml"
  
    ViewData["Title"] = "Contacts page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "E:\TEST\UserApp\Views\Home\Contacts.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<style>
    .box {
        display: flex;
        flex-direction: row;
        width: 300px;
        height: 100px;
        text-align: center;
        border: 3px dotted black;
        background: gray;
    }

    .cl1, .cl2, .cl3 {
        border-radius: 50%;
        width: 80px;
        height: 80px;
        margin: auto;
    }

    .cl1 {
        background: red;
    }

    .cl2 {
        background: yellow;
    }

    .cl3 {
        background: green;
    }
</style>
<p>This page describes company and project</p>
<div class=""box"">
    <div class=""cl1""></div>
    <div class=""cl2""></div>
    <div class=""cl3""></div>
</div>
<h1>Rate from 1 to 10 this excellent horizontal traffic light :)</h1>
<div >
    Developed by <a href=""https://vk.com/id198594204"">Ilya Kuzhanov</a>; 
</div>

");
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
