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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Reviews
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
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Reviews/ReviewsCount.Default.cshtml")]
    public partial class ReviewsCount_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsCountViewModel>
    {
        public ReviewsCount_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" data-sf-role=\"comments-count-wrapper\"");

WriteLiteral(" data-sf-thread-key=\"");

            
            #line 8 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                          Write(Model.ThreadKey);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"sf-Review-count\"");

WriteLiteral(">\n\n    <span");

WriteLiteral(" data-sf-role=\"list-rating-wrapper\"");

WriteLiteral(" class=\"sf-Ratings\"");

WriteLiteral(">\n        <span");

WriteLiteral(" data-sf-role=\"list-rating-container\"");

WriteLiteral(" class=\"sf-Ratings-stars sf-Ratings-stars--ronly\"");

WriteLiteral("></span>\n        <span");

WriteLiteral(" class=\"text-muted sf-Ratings-average\"");

WriteLiteral(">\n            (<span");

WriteLiteral(" data-sf-role=\"list-rating-value\"");

WriteLiteral("></span>)\n        </span>\n    </span>\n     <a");

WriteLiteral(" data-sf-role=\"comments-count-anchor\"");

WriteAttribute("href", Tuple.Create(" href=\"", 680), Tuple.Create("\"", 705)
            
            #line 16 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 687), Tuple.Create<System.Object, System.Int32>(Model.NavigateUrl
            
            #line default
            #line hidden
, 687), false)
);

WriteLiteral(" class=\"sf-Ratings-count\"");

WriteLiteral(">\t\t\n          <span");

WriteLiteral(" data-sf-role=\"comments-count-anchor-text\"");

WriteLiteral("></span>\t\t\n     </a>\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"service-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 864), Tuple.Create("\"", 891)
            
            #line 19 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 872), Tuple.Create<System.Object, System.Int32>(ViewBag.ServiceUrl
            
            #line default
            #line hidden
, 872), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-count-resources\"");

WriteAttribute("value", Tuple.Create(" value=\'", 960), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 968), Tuple.Create("{\"commentsPlural\":", 968), true)
, Tuple.Create(Tuple.Create(" ", 986), Tuple.Create("\"", 987), true)
            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
             , Tuple.Create(Tuple.Create("", 988), Tuple.Create<System.Object, System.Int32>(Html.Resource("ReviewsPlural")
            
            #line default
            #line hidden
, 988), false)
, Tuple.Create(Tuple.Create("", 1019), Tuple.Create("\",", 1019), true)
, Tuple.Create(Tuple.Create(" ", 1021), Tuple.Create("\"leaveComment\":\"", 1022), true)
            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                              , Tuple.Create(Tuple.Create("", 1038), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 1038), false)
, Tuple.Create(Tuple.Create("", 1067), Tuple.Create("\",", 1067), true)
, Tuple.Create(Tuple.Create(" ", 1069), Tuple.Create("\"comment\":\"", 1070), true)
            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                         , Tuple.Create(Tuple.Create("", 1081), Tuple.Create<System.Object, System.Int32>(Html.Resource("Review")
            
            #line default
            #line hidden
, 1081), false)
, Tuple.Create(Tuple.Create("", 1105), Tuple.Create("\",", 1105), true)
, Tuple.Create(Tuple.Create(" ", 1107), Tuple.Create("\"averageRating\":\"", 1108), true)
            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1125), Tuple.Create<System.Object, System.Int32>(Html.Resource("AverageRating")
            
            #line default
            #line hidden
, 1125), false)
, Tuple.Create(Tuple.Create("", 1156), Tuple.Create("\"", 1156), true)
, Tuple.Create(Tuple.Create(" ", 1157), Tuple.Create("}", 1158), true)
);

WriteLiteral(" />\n</div>\n\n");

WriteLiteral("\n<div");

WriteLiteral(" data-sf-role=\"rating-template\"");

WriteLiteral("  style=\"display:none;\"");

WriteLiteral("><span>&#9733;</span></div>\n\n");

            
            #line 26 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 27 "..\..\ResourcePackages\Semyou\MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-count.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
