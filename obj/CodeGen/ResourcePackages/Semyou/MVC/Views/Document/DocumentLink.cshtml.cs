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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Document
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Document/DocumentLink.cshtml")]
    public partial class DocumentLink : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.Document.DocumentViewModel>
    {
        public DocumentLink()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 84), Tuple.Create("\"", 107)
            
            #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 92), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 92), false)
);

WriteLiteral(">\n");

            
            #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
     if(!string.IsNullOrEmpty(Model.MediaUrl))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media\"");

WriteLiteral(">\n          <div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\n            <i");

WriteLiteral(" class=\"icon-file icon-txt icon-md\"");

WriteLiteral(">\n                <span");

WriteAttribute("class", Tuple.Create(" class=\"", 298), Tuple.Create("\"", 331)
, Tuple.Create(Tuple.Create("", 306), Tuple.Create("icon-txt-", 306), true)
            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 315), Tuple.Create<System.Object, System.Int32>(Model.Extension
            
            #line default
            #line hidden
, 315), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
                                                   Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\n            </i>\n          </div>\n          <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\n              <div>\n                <a");

WriteAttribute("class", Tuple.Create(" class=\"", 464), Tuple.Create("\"", 509)
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 472), Tuple.Create<System.Object, System.Int32>(String.Concat("sf", Model.Extension)
            
            #line default
            #line hidden
, 472), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 510), Tuple.Create("\"", 532)
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
, Tuple.Create(Tuple.Create("", 517), Tuple.Create<System.Object, System.Int32>(Model.MediaUrl
            
            #line default
            #line hidden
, 517), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
                                                                                   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</a> \n                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">(");

            
            #line 15 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
                                     Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\n              </div>\n            <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 17 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
                                Write(Model.FileSize);

            
            #line default
            #line hidden
WriteLiteral(" KB</span>\n          </div>\n        </div>\n");

            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Document\DocumentLink.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
