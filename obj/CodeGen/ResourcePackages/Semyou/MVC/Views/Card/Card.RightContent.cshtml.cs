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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Card/Card.RightContent.cshtml")]
    public partial class Card_RightContent : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_RightContent()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 77), Tuple.Create("\"", 100)
            
            #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
, Tuple.Create(Tuple.Create("", 85), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 85), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"w1040\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"sy-ft-div\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 178), Tuple.Create("\"", 206)
            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
, Tuple.Create(Tuple.Create("", 184), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 184), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 207), Tuple.Create("\"", 232)
            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
, Tuple.Create(Tuple.Create("", 215), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 215), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 233), Tuple.Create("\"", 266)
            
            #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"sy-st-div\"");

WriteLiteral(">\r\n            <h2>\r\n");

WriteLiteral("                ");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
           Write(Html.Raw(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h2>\r\n            <p>");

            
            #line 12 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
          Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n");

            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
             if (!string.IsNullOrEmpty(Model.ActionName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 541), Tuple.Create("\"", 564)
            
            #line 16 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
, Tuple.Create(Tuple.Create("", 548), Tuple.Create<System.Object, System.Int32>(Model.ActionUrl
            
            #line default
            #line hidden
, 548), false)
);

WriteLiteral(">");

            
            #line 16 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
                                      Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 17 "..\..\ResourcePackages\Semyou\MVC\Views\Card\Card.RightContent.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n   \r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
