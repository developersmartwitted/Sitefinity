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
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/FlatTaxonomy/FlatTaxonomy.SimpleListOriginal." +
        "cshtml")]
    public partial class FlatTaxonomy_SimpleListOriginal : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public FlatTaxonomy_SimpleListOriginal()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 81), Tuple.Create("\"", 126)
            
            #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
, Tuple.Create(Tuple.Create("", 89), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 89), false)
, Tuple.Create(Tuple.Create(" ", 104), Tuple.Create("sf-Tags", 105), true)
, Tuple.Create(Tuple.Create(" ", 112), Tuple.Create("list-unstyled", 113), true)
);

WriteLiteral(">\r\n");

            
            #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
     foreach (var taxa in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 204), Tuple.Create("\"", 220)
            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
, Tuple.Create(Tuple.Create("", 211), Tuple.Create<System.Object, System.Int32>(taxa.Url
            
            #line default
            #line hidden
, 211), false)
);

WriteLiteral(">");

            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
                           Write(taxa.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
                
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
                 if (Model.ShowItemCount)
                {

            
            #line default
            #line hidden
WriteLiteral("                  ");

WriteLiteral("(");

            
            #line 11 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
                Write(taxa.Count);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 12 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </span>\r\n        </li>\r\n");

            
            #line 15 "..\..\ResourcePackages\Semyou\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleListOriginal.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591
