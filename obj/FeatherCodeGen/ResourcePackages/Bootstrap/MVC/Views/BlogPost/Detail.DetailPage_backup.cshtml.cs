#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.BlogPost
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
    
    #line 3 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/BlogPost/Detail.DetailPage_backup.cshtml")]
    public partial class Detail_DetailPage_backup : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_DetailPage_backup()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 202), Tuple.Create("\"", 225)
            
            #line 7 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
, Tuple.Create(Tuple.Create("", 210), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 210), false)
);

WriteLiteral(" ");

            
            #line 7 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <h3>\r\n        <span ");

            
            #line 9 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 9 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </h3>\r\n\r\n    <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t");

            
            #line 16 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
   Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    \r\n    <div ");

            
            #line 19 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
    Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 19 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
                                                              Write(Html.Raw(Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n    <div ");

            
            #line 21 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
    Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
                                                              Write(Html.Raw(Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    \r\n    \r\n\t\r\n");

WriteLiteral("\t");

            
            #line 25 "..\..MVC\Views\BlogPost\Detail.DetailPage_backup.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
