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

namespace Cotide.Portal.Views.Blog
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/_ArticleTag.cshtml")]
    public partial class ArticleTag : System.Web.Mvc.WebViewPage<IList<Cotide.Web.Controllers.Blog.ViewModel.IndexArticleTagViewModel>>
    {
        public ArticleTag()
        {
        }
        public override void Execute()
        {

WriteLiteral("<legend>  <lable>  标签</lable> </legend>\r\n");


            
            #line 3 "..\..\Views\Blog\_ArticleTag.cshtml"
 if (Model != null && Model.Count > 0)
   {    
    

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"row-fluid\">\r\n <p>\r\n");


            
            #line 8 "..\..\Views\Blog\_ArticleTag.cshtml"
      foreach (var item in Model)   {
            
            #line default
            #line hidden
WriteLiteral("  <a href=\"");


            
            #line 8 "..\..\Views\Blog\_ArticleTag.cshtml"
                                           Write(Url.Action("Tag", "Blog", new {@id = item.Id}));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"");


            
            #line 8 "..\..\Views\Blog\_ArticleTag.cshtml"
                                                                                                   Write(item.TagName);

            
            #line default
            #line hidden
WriteLiteral("\"  style=\"font-size: ");


            
            #line 8 "..\..\Views\Blog\_ArticleTag.cshtml"
                                                                                                                                     Write(Html.Raw(item.Random+"pt"));

            
            #line default
            #line hidden
WriteLiteral(" ;\">  ");


            
            #line 8 "..\..\Views\Blog\_ArticleTag.cshtml"
                                                                                                                                                                      Write(item.TagName);

            
            #line default
            #line hidden
WriteLiteral(" </a>  ");


            
            #line 8 "..\..\Views\Blog\_ArticleTag.cshtml"
                                                                                                                                                                                               }  

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n    </div>\r\n");


            
            #line 11 "..\..\Views\Blog\_ArticleTag.cshtml"
  }
   else
   { 

            
            #line default
            #line hidden
WriteLiteral("<p style=\"text-align: center;\">\r\n    暂无标签\r\n</p>\r\n");


            
            #line 17 "..\..\Views\Blog\_ArticleTag.cshtml"
  }
            
            #line default
            #line hidden
WriteLiteral(" ");


        }
    }
}
#pragma warning restore 1591