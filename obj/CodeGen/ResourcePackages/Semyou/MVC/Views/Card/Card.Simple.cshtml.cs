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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Card
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
    
    #line 2 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Card/Card.Simple.cshtml")]
    public partial class Card_Simple : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Simple()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 121), Tuple.Create("\"", 144)
            
            #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 129), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 129), false)
);

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 216), Tuple.Create("\"", 244)
            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 222), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 222), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 245), Tuple.Create("\"", 270)
            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 253), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 253), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 271), Tuple.Create("\"", 304)
            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 277), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 277), false)
);

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(">\n        </div>\n        <div");

WriteLiteral(" class=\"col-md-6 \"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"caption\"");

WriteLiteral(">\n                <h3>");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
               Write(Html.HtmlSanitize(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n                <p>");

            
            #line 11 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
              Write(Html.HtmlSanitize(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\n\n");

            
            #line 13 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
                 if (!string.IsNullOrEmpty(Model.ActionName))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 637), Tuple.Create("\"", 678)
            
            #line 15 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 644), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize(Model.ActionUrl)
            
            #line default
            #line hidden
, 644), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 15 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
                                                                                                      Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\n");

            
            #line 16 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.Simple.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n");

        }
    }
}
#pragma warning restore 1591
