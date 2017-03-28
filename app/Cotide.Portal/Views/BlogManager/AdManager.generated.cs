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
    
    #line 12 "..\..\Views\BlogManager\AdManager.cshtml"
    using Cotide.Web.Controllers.BlogManager.ViewModel.Ad;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BlogManager/AdManager.cshtml")]
    public partial class AdManager : System.Web.Mvc.WebViewPage<List<AdViewModel>>
    {
        public AdManager()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Views\BlogManager\AdManager.cshtml"
  
    ViewBag.Title = "ArticleType";
    Layout = "~/Views/Shared/_BlogManagerLayout.cshtml";


            
            #line default
            #line hidden

DefineSection("Head", () => {

WriteLiteral("\r\n    ");


            
            #line 6 "..\..\Views\BlogManager\AdManager.cshtml"
Write(Html.StyleSheet("validate/pagevalidator.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 7 "..\..\Views\BlogManager\AdManager.cshtml"
Write(Html.JavaScript("validate/pagevalidator_v2.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 8 "..\..\Views\BlogManager\AdManager.cshtml"
Write(Html.StyleSheet("lib/jquery-ui-1.8.11.custom.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 9 "..\..\Views\BlogManager\AdManager.cshtml"
Write(Html.JavaScript("lib/jquery-ui.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 10 "..\..\Views\BlogManager\AdManager.cshtml"
Write(Html.JavaScript("cotide/cotide.dialog.init.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


});

WriteLiteral("\r\n");



WriteLiteral(@"      <script type=""text/javascript"">
          function DeleteAd(obj) {
              if (confirm('是否删除该广告')) {
                  location = $(obj).attr(""ref"");
              }
          }
          function UpdateAd(obj) {
              var url = $(obj).attr(""ref"");
              cotide.dialog.open(url, ""修改文章分类"", 780, 230, function () {
                  location = '");


            
            #line 23 "..\..\Views\BlogManager\AdManager.cshtml"
                         Write(Url.Action("AdManager", "BlogManager"));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n              });\r\n          } \r\n  </script> \r\n<legend>\r\n        <h4>\r\n      " +
"       广告管理</h4>\r\n    </legend>\r\n    ");


            
            #line 31 "..\..\Views\BlogManager\AdManager.cshtml"
Write(ViewData["alert"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 32 "..\..\Views\BlogManager\AdManager.cshtml"
      using (Html.BeginForm("CreateAd", "BlogManager", FormMethod.Post, new { id = "AdAdFrom", @enctype = "multipart/form-data" }))
     { 


            
            #line default
            #line hidden
WriteLiteral("        <h5>\r\n        新增广告</h5> \r\n");


            
            #line 37 "..\..\Views\BlogManager\AdManager.cshtml"
         

            
            #line default
            #line hidden
WriteLiteral("            <p>\r\n        ");


            
            #line 39 "..\..\Views\BlogManager\AdManager.cshtml"
   Write(Html.ValidationExSummary("AdAdFrom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>");



WriteLiteral("<p>\r\n          <label class=\"required\">\r\n            广告图片  (940px X 450px) ：</lab" +
"el> \r\n            <input type=\"file\" name=\"AdImg\" id=\"AdImg\" /> \r\n         </p>\r" +
"\n");



WriteLiteral("    <p>\r\n        <label class=\"required\">\r\n            广告名称 ：</label>\r\n\r\n        " +
"  ");


            
            #line 49 "..\..\Views\BlogManager\AdManager.cshtml"
     Write(Html.TextBoxEx("AdName", new
     {
         @style = "width: 500px; color: Silver;",
         @title = "广告名称",
         @maxlength = "50",
         @placeholder = "请输入广告名称(必填)"
     }, new ValidateOption()
     {
         EmptyMsg = "您还没输入广告名称",
         Description =
             "文章类别格式:1-50位字符",
         Min = 1,
         Max = 50,
         RangeMsg = "请确保文章类别在1-50位字符内"
     }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        ");


            
            #line 64 "..\..\Views\BlogManager\AdManager.cshtml"
   Write(Html.ValidationMessageEx("AdName"));

            
            #line default
            #line hidden
WriteLiteral(" \r\n    </p>\r\n");



WriteLiteral("     <p>\r\n         <label class=\"required\">\r\n            广告类型 ：</label>\r\n        " +
" ");


            
            #line 69 "..\..\Views\BlogManager\AdManager.cshtml"
    Write(Html.DropDownList("AdType", new List<SelectListItem>()
                                      {
                                          
                                          new SelectListItem()
                                              {
                                                  Selected = true,
                                                  Text = @"首页",
                                                  Value = "0"
                                              }
                                      }));

            
            #line default
            #line hidden
WriteLiteral("\r\n     </p>    \r\n");



WriteLiteral("         <p>\r\n         <label class=\"required\">\r\n            广告描述 ：</label> \r\n   " +
"             ");


            
            #line 83 "..\..\Views\BlogManager\AdManager.cshtml"
           Write(Html.TextBoxEx("AdDesc", new
           {
               @style = "width: 500px; color: Silver;",
               @title = "广告描述",
               @maxlength = "100",
               @placeholder = "请输入广告描述"
           }, new ValidateOption()
           {
               Min = 0,
               Max = 100,
               RangeMsg = "请确保广告描述在0-100位字符内",
               IsEmpty = true
           }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        ");


            
            #line 96 "..\..\Views\BlogManager\AdManager.cshtml"
   Write(Html.ValidationMessageEx("AdDesc"));

            
            #line default
            #line hidden
WriteLiteral(" \r\n         \r\n         </p>\r\n");



WriteLiteral("          <p>\r\n    \r\n      <label class=\"required\" for=\"password\">\r\n            前" +
"端显示 ：\r\n        </label>\r\n        ");


            
            #line 104 "..\..\Views\BlogManager\AdManager.cshtml"
   Write(Html.DropDownList("IsShow", new List<SelectListItem>()
                                                                                   {
                                                                                       new SelectListItem()
                                                                                           {
                                                                                               Text = @"公开",
                                                                                               Value = "true"
                                                                                           },
                                                                                       new SelectListItem()
                                                                                           {
                                                                                               Text = @"仅自己可见",
                                                                                               Value = "false"
                                                                                           }
                                                                                   }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");



WriteLiteral("             <p>\r\n    \r\n      <label class=\"required\"  >\r\n            排序 ：\r\n     " +
"   </label>\r\n    ");


            
            #line 123 "..\..\Views\BlogManager\AdManager.cshtml"
Write(Html.TextBox("Sort", "", new
{
    @style = "width: 150px; color: Silver;",
    @title = "排序",
    @placeholder = "请输入排序"
}));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");



WriteLiteral("    <p>\r\n      <button type=\"submit\" class=\"btn btn-primary\"> 保存 </button>\r\n    <" +
"/p>\r\n");


            
            #line 133 "..\..\Views\BlogManager\AdManager.cshtml"
     } 

            
            #line default
            #line hidden
WriteLiteral(@"    <h5>
        您已拥有的文章分类</h5> 
<table  class=""table  table-hover"">
                <tr class=""info"">
            <td>
                序号
            </td>
             <td>
                广告图片
            </td> 
            <td>
                广告名称
            </td> 
            <td>
                状态
            </td>
            
            <td>
                排序
            </td>
            <td>
                修改
            </td>
            <td>
                彻底删除
            </td>
        </tr>
");


            
            #line 161 "..\..\Views\BlogManager\AdManager.cshtml"
          for (int i = 0; i < Model.Count; i++)
         {

            
            #line default
            #line hidden

            
            #line 163 "..\..\Views\BlogManager\AdManager.cshtml"
WriteLiteral("             <tr ");

            
            #line default
            #line hidden
            
            #line 163 "..\..\Views\BlogManager\AdManager.cshtml"
                  if ((i % 2) == 0)
                 {

            
            #line default
            #line hidden
WriteLiteral("                     ");

WriteLiteral("class=\"\'firseTd\'\"\r\n");


            
            #line 166 "..\..\Views\BlogManager\AdManager.cshtml"
                 }
            
            #line default
            #line hidden
WriteLiteral("  >\r\n                 <td>\r\n                     ");


            
            #line 168 "..\..\Views\BlogManager\AdManager.cshtml"
                 Write(i + 1);

            
            #line default
            #line hidden
WriteLiteral("\r\n                 </td>\r\n                  <td>\r\n                     <img style" +
"=\"width: 50px;height:50px;\" src=\"");


            
            #line 171 "..\..\Views\BlogManager\AdManager.cshtml"
                                                           Write(Model[i].SmallAdImg);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n                 </td>\r\n                 <td>\r\n                     ");


            
            #line 174 "..\..\Views\BlogManager\AdManager.cshtml"
                Write(Model[i].AdName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n                 </td>\r\n                  \r\n                 <td>\r\n           " +
"          ");


            
            #line 178 "..\..\Views\BlogManager\AdManager.cshtml"
                Write(Html.ActionLink(Model[i].IsShow ? "显示" : "隐藏", "SetAdIsShow", new { @adId = Model[i].Id }));

            
            #line default
            #line hidden
WriteLiteral("  \r\n                 </td>\r\n                 \r\n            <td>\r\n                " +
"");


            
            #line 182 "..\..\Views\BlogManager\AdManager.cshtml"
           Write(Model[i].Sort);

            
            #line default
            #line hidden
WriteLiteral(" \r\n            </td>\r\n                 <td>\r\n                     <a ref=\"");


            
            #line 185 "..\..\Views\BlogManager\AdManager.cshtml"
                        Write(Url.Action("UpdateAd", "BlogManager", new { @adId = Model[i].Id }));

            
            #line default
            #line hidden
WriteLiteral("\" href=\"javascript:void(0);\"\r\n                          onclick=\"UpdateAd(this)\">" +
"修改</a>\r\n                 </td>\r\n                 <td>\r\n                     <a h" +
"ref=\'javascript:void(0);\'  ref=\"");


            
            #line 189 "..\..\Views\BlogManager\AdManager.cshtml"
                                                    Write(Url.Action("DeleteAd"));

            
            #line default
            #line hidden
WriteLiteral("?adId=");


            
            #line 189 "..\..\Views\BlogManager\AdManager.cshtml"
                                                                                 Write(Model[i].Id);

            
            #line default
            #line hidden
WriteLiteral(" \" \r\n                        onclick=\"DeleteAd(this)\">删除</a>\r\n                 </" +
"td>\r\n             </tr>\r\n");


            
            #line 193 "..\..\Views\BlogManager\AdManager.cshtml"
         }

            
            #line default
            #line hidden

            
            #line 194 "..\..\Views\BlogManager\AdManager.cshtml"
         if (Model.Count <= 0)
        {  

            
            #line default
            #line hidden
WriteLiteral("        <tr class=\"firseTd\">\r\n            <td colspan=\"7\" style=\"text-align: cent" +
"er;\">\r\n                暂无数据\r\n            </td>\r\n        </tr>\r\n");


            
            #line 201 "..\..\Views\BlogManager\AdManager.cshtml"
        } 

            
            #line default
            #line hidden
WriteLiteral("        <tfoot>\r\n            <tr>\r\n                <td colspan=\"7\">\r\n            " +
"        共有 ");


            
            #line 205 "..\..\Views\BlogManager\AdManager.cshtml"
                  Write(Model.Count);

            
            #line default
            #line hidden
WriteLiteral(" 条记录\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");


        }
    }
}
#pragma warning restore 1591