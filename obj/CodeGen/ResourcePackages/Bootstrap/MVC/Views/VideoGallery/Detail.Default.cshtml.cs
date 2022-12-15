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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.VideoGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/VideoGallery/Detail.Default.cshtml")]
    public partial class Detail_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery.VideoDetailsViewModel>
    {
        public Detail_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 213), Tuple.Create("\"", 236)
            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 221), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 221), false)
);

WriteLiteral(" ");

            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n    <h2>\n        <span ");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n    </h2>\n\n    <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n\n    <div ");

            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
    Write(Html.InlineEditingFieldAttributes("Description", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                  Write(Html.HtmlSanitize((string)Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n    <video");

WriteAttribute("src", Tuple.Create(" src=\"", 828), Tuple.Create("\"", 859)
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 834), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 834), false)
);

WriteLiteral(" controls=\"controls\"");

WriteAttribute("width", Tuple.Create(" width=\"", 880), Tuple.Create("\"", 900)
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 888), Tuple.Create<System.Object, System.Int32>(Model.Width
            
            #line default
            #line hidden
, 888), false)
);

WriteAttribute("height", Tuple.Create(" height=\"", 901), Tuple.Create("\"", 923)
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
             , Tuple.Create(Tuple.Create("", 910), Tuple.Create<System.Object, System.Int32>(Model.Height
            
            #line default
            #line hidden
, 910), false)
);

WriteLiteral("></video>\n\n");

            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"m-bottom-lg text-center\"");

WriteLiteral(">\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
              
                var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
                var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
            
            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.PreviousItem != null) 
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"pull-left\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1369), Tuple.Create("\"", 1518)
            
            #line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1376), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 1376), false)
);

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
               Write(Html.Resource("PreviousVideo"));

            
            #line default
            #line hidden
WriteLiteral("\n                </a>\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.PreviousItem != null || Model.NextItem != null)
            {
                
            
            #line default
            #line hidden
            
            #line 39 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
           Write(Html.HtmlSanitize((string)string.Format(Html.Resource("IndexOfTotal"), ViewBag.ItemIndex, Model.TotalItemsCount)));

            
            #line default
            #line hidden
            
            #line 39 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                                  ;
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 42 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.NextItem != null) 
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"pull-right\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1934), Tuple.Create("\"", 2075)
            
            #line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1941), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 1941), false)
);

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
               Write(Html.Resource("NextVideo"));

            
            #line default
            #line hidden
WriteLiteral("\n                </a>\n");

            
            #line 47 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n");

            
            #line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"

        
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
   Write(Html.ActionLink(Html.Resource("BackToAllVideos"), "Index"));

            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                   
    }

            
            #line default
            #line hidden
WriteLiteral("    \n");

            
            #line 53 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 53 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\Detail.Default.cshtml"
              
       
    
            
            #line default
            #line hidden
WriteLiteral("\n</div>");

        }
    }
}
#pragma warning restore 1591
