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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Navigation
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
    
    #line 3 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.SemYou.cshtml")]
    public partial class NavigationView_SemYou : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 20 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 21 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n\r\n");


#line 24 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
        

#line default
#line hidden

#line 24 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
         if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 656), Tuple.Create("\"", 672)

#line 26 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
, Tuple.Create(Tuple.Create("", 663), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 663), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"menu-arrow\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 26 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                     WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"megamenu clearfix halfmenu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"container-fluid\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"row\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n");


#line 31 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                        

#line default
#line hidden

#line 31 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                         if (node.IsCurrentlyOpened)
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                           <div");

WriteLiteralTo(__razor_helper_writer, " class=\"col-lg-4 col-md-12\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"wstliststy02 clearfix\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 35 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                

#line default
#line hidden

#line 35 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                 foreach (var childNode in node.ChildNodes)
                                {
                                    

#line default
#line hidden

#line 37 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
      WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 37 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                                                        
                                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            </ul>\r\n                            </div>\r\n");


#line 41 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                            }
                            else
                            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"col-lg-4 col-md-12\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"wstliststy02 clearfix\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 46 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                

#line default
#line hidden

#line 46 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                 foreach (var childNode in node.ChildNodes)
                                {
                                    

#line default
#line hidden

#line 48 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
      WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 48 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                                                        
                                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            </ul>\r\n                              </div>\r\n");


#line 52 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                        </div>\r\n                </div>\r\n            </div>\r\n");


#line 57 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"


        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2029), Tuple.Create("\"", 2045)

#line 62 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
, Tuple.Create(Tuple.Create("", 2036), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 2036), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2046), Tuple.Create("\"", 2071)

#line 62 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
, Tuple.Create(Tuple.Create("", 2055), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 2055), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 62 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                            WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 63 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"

        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </li>\r\n");


#line 67 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"


#line default
#line hidden
});

#line 67 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
}
#line default
#line hidden

#line 72 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 73 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
 
    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 76 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 76 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 80 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("items-expanded"));


#line default
#line hidden

#line 80 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                   ;
    }


#line default
#line hidden
});

#line 82 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
}
#line default
#line hidden

        public NavigationView_SemYou()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 268), Tuple.Create("\"", 291)
            
            #line 9 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
, Tuple.Create(Tuple.Create("", 276), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 276), false)
);

WriteLiteral(">\r\n  \r\n    <ul");

WriteLiteral(" class=\"mobile-sub wsmenu-list\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
         foreach (var node in Model.Nodes)
        {
        
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
   Write(RenderSubLevelsRecursive(node));

            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\Navigation\NavigationView.SemYou.cshtml"
                                       ;
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591