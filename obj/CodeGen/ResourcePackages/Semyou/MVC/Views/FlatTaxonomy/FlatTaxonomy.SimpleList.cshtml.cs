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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.FlatTaxonomy
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/FlatTaxonomy/FlatTaxonomy.SimpleList.cshtml")]
    public partial class FlatTaxonomy_SimpleList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public FlatTaxonomy_SimpleList()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 81), Tuple.Create("\"", 160)
            
            #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 89), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 89), false)
, Tuple.Create(Tuple.Create(" ", 104), Tuple.Create("sf-Tags", 105), true)
, Tuple.Create(Tuple.Create(" ", 112), Tuple.Create("list-unstyled", 113), true)
, Tuple.Create(Tuple.Create(" ", 126), Tuple.Create("term-filters", 127), true)
, Tuple.Create(Tuple.Create(" ", 139), Tuple.Create("term-filters-product", 140), true)
);

WriteLiteral(">\r\n");

            
            #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
     foreach (var taxa in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 238), Tuple.Create("\"", 254)
            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 245), Tuple.Create<System.Object, System.Int32>(taxa.Url
            
            #line default
            #line hidden
, 245), false)
);

WriteLiteral(" class=\"termfilter-semyou\"");

WriteLiteral(">");

            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
                                                     Write(taxa.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n          \r\n        </li>\r\n");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591
