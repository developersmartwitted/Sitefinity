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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/BlogPost/Detail.DetailPage.cshtml")]
    public partial class Detail_DetailPage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_DetailPage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 204), Tuple.Create("\"", 227)
            
            #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 212), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 212), false)
);

WriteLiteral(" ");

            
            #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    \r\n    <div");

WriteLiteral(" class=\"post-template-default single single-post postid-227688 single-format-stan" +
"dard desktop group-blog news\"");

WriteLiteral(">\r\n\r\n         <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"site-content\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" id=\"primary\"");

WriteLiteral(" class=\"content-area\"");

WriteLiteral(">\r\n                <main");

WriteLiteral(" id=\"main\"");

WriteLiteral(" class=\"site-main\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n\r\n                    <article");

WriteLiteral(" id=\"post-227688\"");

WriteLiteral(" class=\"post type-post\"");

WriteLiteral(">\r\n\r\n                       <div");

WriteLiteral(" class=\"modal-overlay\"");

WriteLiteral(">\r\n\r\n                       </div>\r\n                        <header");

WriteLiteral(" class=\"entry-header\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"entry-featured-category-wrap\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"entry-featured-category-box featured-category-box-office-365\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" class=\"back-link\"");

WriteLiteral(">\r\n                                        Back\r\n                                " +
"    </a>\r\n\r\n                                </div>\r\n                            " +
"</div>\r\n\r\n                            <h1");

WriteLiteral(" class=\"entry-title\"");

WriteLiteral(">\r\n                                <span ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                 Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                                                                          Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                ");

WriteLiteral("\r\n                            </h1>\r\n\r\n                            <div");

WriteLiteral(" class=\"entry-meta\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"when-who\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"byline\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        ");

WriteLiteral("\r\n                                        <span");

WriteLiteral(" class=\"author vcard\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" class=\"url fn n\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                                                ");

            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                           Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                ");

WriteLiteral("\r\n                                            </a>\r\n                             " +
"           </span>\r\n                                    </span>,\r\n\r\n            " +
"                        <span");

WriteLiteral(" class=\"posted-on\"");

WriteLiteral(">\r\n                                        on\r\n\r\n                                " +
"        <time");

WriteLiteral(" class=\"entry-date published\"");

WriteLiteral(" >\r\n                                            ");

WriteLiteral("\r\n");

WriteLiteral("                                            ");

            
            #line 56 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                       Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </time>\r\n\r\n                            " +
"            <time");

WriteLiteral(" class=\"updated\"");

WriteLiteral(">\r\n                                            ");

WriteLiteral("\r\n                                        </time>\r\n\r\n                            " +
"        </span>\r\n\r\n                                </div>\r\n                     " +
"           <span");

WriteLiteral(" class=\"comments-sep v-sep\"");

WriteLiteral(">|</span>\r\n                                <a");

WriteLiteral(" class=\"num-comments\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                                    ");

WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 69 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                               Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    Comments\r\n                                <" +
"/a>\r\n                                <span");

WriteLiteral(" class=\"v-sep\"");

WriteLiteral(">|</span>\r\n\r\n                                <span");

WriteLiteral(" class=\"addthis_toolbox\"");

WriteLiteral(" addthis:url=\"#\"");

WriteLiteral(" addthis:title=\"\"");

WriteLiteral(" addthis:description=\"\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"addthis_counter\"");

WriteLiteral(" style=\"display: inline-block;\"");

WriteLiteral(">\r\n                                        ");

WriteLiteral("\r\n                                    </span>\r\n                                  " +
"  <div");

WriteLiteral(" class=\"atclear\"");

WriteLiteral(">\r\n\r\n                                    </div>\r\n\r\n                              " +
"  </span>\r\n                            </div><!-- .entry-meta -->\r\n             " +
"           </header><!-- .entry-header -->\r\n\r\n\r\n\r\n                        <div");

WriteLiteral(" class=\"entry-content\"");

WriteLiteral(">\r\n\r\n                            ");

WriteLiteral("\r\n\r\n                            <div ");

            
            #line 92 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                            Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 92 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
                                                                                      Write(Html.Raw(Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n\r\n                            <p>\r\n\r\n                                ");

WriteLiteral("\r\n                            </p>\r\n                        </div><!-- .entry-con" +
"tent -->\r\n\r\n\r\n                        ");

WriteLiteral("  \r\n                    <!-- .entry-meta -->\r\n\r\n                        ");

WriteLiteral("\r\n\r\n                    </article><!-- #post-## -->\r\n                </main><!-- " +
"#main -->\r\n            </div><!-- #primary -->\r\n        </div>\r\n\r\n    </div>\r\n\r\n" +
"\r\n\r\n");

WriteLiteral("    ");

            
            #line 133 "..\..\ResourcePackages\Bootstrap\MVC\Views\BlogPost\Detail.DetailPage.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591