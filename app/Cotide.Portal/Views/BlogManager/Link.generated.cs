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
    
    #line 12 "..\..\Views\BlogManager\Link.cshtml"
    using Cotide.Web.Controllers.BlogManager.ViewModel;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BlogManager/Link.cshtml")]
    public partial class Link : System.Web.Mvc.WebViewPage<Cotide.Framework.Collections.PagedList<LinkModel> >
    {
        public Link()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Views\BlogManager\Link.cshtml"
  
    ViewBag.Title = "Link";
    Layout = "~/Views/Shared/_BlogManagerLayout.cshtml";


            
            #line default
            #line hidden

DefineSection("Head", () => {

WriteLiteral("\r\n    ");


            
            #line 6 "..\..\Views\BlogManager\Link.cshtml"
Write(Html.StyleSheet("validate/pagevalidator.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 7 "..\..\Views\BlogManager\Link.cshtml"
Write(Html.JavaScript("validate/pagevalidator_v2.js"));

            
            #line default
            #line hidden
WriteLiteral("   \r\n    ");


            
            #line 8 "..\..\Views\BlogManager\Link.cshtml"
Write(Html.StyleSheet("lib/jquery-ui-1.8.11.custom.css"));

            
            #line default
            #line hidden
WriteLiteral("    \r\n    ");


            
            #line 9 "..\..\Views\BlogManager\Link.cshtml"
Write(Html.JavaScript("lib/jquery-ui.min.js"));

            
            #line default
            #line hidden
WriteLiteral("    \r\n    ");


            
            #line 10 "..\..\Views\BlogManager\Link.cshtml"
Write(Html.JavaScript("cotide/cotide.dialog.init.js"));

            
            #line default
            #line hidden
WriteLiteral("   \r\n");


});

WriteLiteral("\r\n ");


WriteLiteral("  ");


WriteLiteral(@"   <script type=""text/javascript"">
       function DeleteLink(obj) {
           if (confirm('是否删除该收藏链接')) {
               location = $(obj).attr(""ref"");
           }
       }
       function UpdateLink(obj) {
           var url = $(obj).attr(""ref"");
           cotide.dialog.open(url, ""修改收藏链接"", 480, 230, function () {
               location = '");


            
            #line 23 "..\..\Views\BlogManager\Link.cshtml"
                      Write(Url.Action("Link", "BlogManager"));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n           });\r\n       } \r\n  </script> \r\n   <legend>\r\n        <h4>\r\n         " +
"   网站链接管理</h4>\r\n    </legend>\r\n    <h4>\r\n        新增链接</h4>\r\n");


            
            #line 33 "..\..\Views\BlogManager\Link.cshtml"
      using (Html.BeginForm("AddLink", "BlogManager", FormMethod.Post, new { id = "AddLinkFrom" }))
       { 

            
            #line default
            #line hidden
WriteLiteral("     <p>\r\n        <label class=\"required\">\r\n            链接名称 ：</label>\r\n        <" +
"input id=\"linkTxt\" name=\"linkTxt\" style=\"width: 300px;\" class=\"half\" type=\"text\"" +
" />\r\n    </p>\r\n");



WriteLiteral(@"    <p>
        <label class=""required"">
            链接地址 ：</label>
        <input id=""Text1"" name=""linkHref"" style=""width: 500px;"" class=""half"" type=""text"" />
        <button type=""submit"" class=""btn btn-primary"">
            保存
        </button>
    </p>
");


            
            #line 48 "..\..\Views\BlogManager\Link.cshtml"
    } 

            
            #line default
            #line hidden
WriteLiteral(@"    <!-- 内容/Start -->
    <h4>
        您收藏的链接</h4>
<table  class=""table  table-hover"">
                <tr class=""info"">
            <td>
                序号
            </td>
            <td>
                链接名称
            </td>
            <td>
                状态
            </td>
            <td>
                变更时间
            </td>
            <td>
                修改
            </td>
            <td>
                彻底删除
            </td>
        </tr>
");


            
            #line 73 "..\..\Views\BlogManager\Link.cshtml"
          for (int i = 0; i < Model.Count; i++)
            { 

            
            #line default
            #line hidden

            
            #line 75 "..\..\Views\BlogManager\Link.cshtml"
WriteLiteral("       <tr ");

            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\BlogManager\Link.cshtml"
            if ((i % 2) == 0)
                 {

            
            #line default
            #line hidden
WriteLiteral("                     ");

WriteLiteral("class=\"\'firseTd\'\"\r\n");


            
            #line 78 "..\..\Views\BlogManager\Link.cshtml"
                 }
            
            #line default
            #line hidden
WriteLiteral("  >\r\n            <td>\r\n                ");


            
            #line 80 "..\..\Views\BlogManager\Link.cshtml"
            Write(i + 1);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");


            
            #line 83 "..\..\Views\BlogManager\Link.cshtml"
          Write(Model[i].LinkTxt);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                 ");


            
            #line 86 "..\..\Views\BlogManager\Link.cshtml"
            Write(Html.ActionLink(Model[i].IsShow ? "显示" : "隐藏", "SetLinkIsShow", new { @linkId = Model[i].Id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 89 "..\..\Views\BlogManager\Link.cshtml"
           Write(Model[i].LastUpdate);

            
            #line default
            #line hidden
WriteLiteral(" \r\n            </td>\r\n            <td>\r\n                <a  ref=\"");


            
            #line 92 "..\..\Views\BlogManager\Link.cshtml"
                    Write(Url.Action("UpdateLink", "BlogManager", new { @linkId = Model[i].Id }));

            
            #line default
            #line hidden
WriteLiteral("\" href=\"javascript:void(0);\"\r\n                          onclick=\"UpdateLink(this)" +
"\"    >修改 </a>\r\n            </td>\r\n            <td>\r\n                <a href=\'jav" +
"ascript:void(0);\' ref=\"");


            
            #line 96 "..\..\Views\BlogManager\Link.cshtml"
                                              Write(Url.Action("DeleteLink"));

            
            #line default
            #line hidden
WriteLiteral("?linkId=");


            
            #line 96 "..\..\Views\BlogManager\Link.cshtml"
                                                                               Write(Model[i].Id);

            
            #line default
            #line hidden
WriteLiteral(" \"\r\n                    onclick=\"DeleteLink(this)\">删除</a>\r\n            </td>\r\n   " +
"     </tr>\r\n");


            
            #line 100 "..\..\Views\BlogManager\Link.cshtml"
        } 

            
            #line default
            #line hidden

            
            #line 101 "..\..\Views\BlogManager\Link.cshtml"
         if (Model.Count <= 0)
           {  

            
            #line default
            #line hidden
WriteLiteral("        <tr class=\"firseTd\">\r\n            <td colspan=\"9\" style=\"text-align: cent" +
"er;\">\r\n                暂无数据\r\n            </td>\r\n        </tr>\r\n");


            
            #line 108 "..\..\Views\BlogManager\Link.cshtml"
        } 

            
            #line default
            #line hidden
WriteLiteral("        <tfoot>\r\n            <tr>\r\n                <td colspan=\"8\">\r\n            " +
"        共有 ");


            
            #line 112 "..\..\Views\BlogManager\Link.cshtml"
                  Write(Model.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" 条记录\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n " +
"   <!-- 分页/开始 -->\r\n    <div id=\"pageNav\" class=\"blueFoot\">\r\n        ");


            
            #line 119 "..\..\Views\BlogManager\Link.cshtml"
   Write(Html.Pager("pageIndex", Model.PageSize, Model.TotalCount));

            
            #line default
            #line hidden
WriteLiteral(" \r\n    </div>\r\n    <!-- 分页/结束 -->");


        }
    }
}
#pragma warning restore 1591
