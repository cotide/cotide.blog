﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17626
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cotide.Portal.Views.BlogManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 5 "..\..\Views\BlogManager\UpdateLink.cshtml"
    using Cotide.Web.Controllers.BlogManager.ViewModel;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BlogManager/UpdateLink.cshtml")]
    public partial class UpdateLink : System.Web.Mvc.WebViewPage<UpdateLinkModel>
    {
        public UpdateLink()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Views\BlogManager\UpdateLink.cshtml"
  
    ViewBag.Title = "UpdateLink";
    Layout = "~/Views/Shared/_DialogLayout.cshtml";


            
            #line default
            #line hidden


WriteLiteral(@" <script type=""text/javascript"">
     function check() {
         if ($(""#LinkTxt"").val() == """") {
             alert('请输入链接文本!');
             return false;
         }
         if ($(""#LinkUrl"").val() == """") {
             alert('请输入链接地址!');
             return false;
         }
         return true;
     } 
    </script> 
<div class=""container-fluid"">
<p>
    ");


            
            #line 22 "..\..\Views\BlogManager\UpdateLink.cshtml"
Write(ViewData["alert"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n</div>\r\n<div class=\"container-fluid\">\r\n");


            
            #line 26 "..\..\Views\BlogManager\UpdateLink.cshtml"
      using (Html.BeginForm("UpdateLink", "BlogManager", FormMethod.Post, new { @Id = "login-form", @onsubmit = "return check()" }))
     {

            
            #line default
            #line hidden
WriteLiteral("           <p>\r\n            <label class=\"required\">\r\n                链接文本 ：</lab" +
"el>  \r\n                     ");


            
            #line 31 "..\..\Views\BlogManager\UpdateLink.cshtml"
                Write(Html.TextBoxFor(x=>x.LinkTxt));

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 31 "..\..\Views\BlogManager\UpdateLink.cshtml"
                                               Write(Html.HiddenFor(x=>x.Id));

            
            #line default
            #line hidden
WriteLiteral("  \r\n             </p>\r\n");



WriteLiteral("             <p>\r\n            <label class=\"required\">\r\n               \r\n        " +
"             链接地址: </label>  \r\n                     ");


            
            #line 37 "..\..\Views\BlogManager\UpdateLink.cshtml"
                Write(Html.TextBoxFor(x=>x.LinkUrl));

            
            #line default
            #line hidden
WriteLiteral("  \r\n              </p>\r\n");



WriteLiteral("         <p>\r\n             <label class=\"required\">\r\n               \r\n           " +
"          状态:  </label>   \r\n               \r\n                      ");


            
            #line 44 "..\..\Views\BlogManager\UpdateLink.cshtml"
                 Write(Html.DropDownListFor(x => x.IsShow, new List<SelectListItem>()
                                                                 {
                                                                 new SelectListItem(){ Text="显示", Value="true"},
                                                                 new SelectListItem(){ Text="隐藏",Value="false"}
                                                                 }));

            
            #line default
            #line hidden
WriteLiteral("  \r\n              </p>\r\n");



WriteLiteral("               <p>\r\n             \r\n                     <input type=\"submit\" clas" +
"s=\"btn btn-primary\"  value=\" 保存 \" />\r\n                </p>\r\n");


            
            #line 54 "..\..\Views\BlogManager\UpdateLink.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>");


        }
    }
}
#pragma warning restore 1591
