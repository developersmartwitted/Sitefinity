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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.SearchBox
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
    
    #line 5 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchBox/SearchBoxSEMYOU.cshtml")]
    public partial class SearchBoxSEMYOU : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBoxSEMYOU()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();

            
            #line default
            #line hidden
WriteLiteral("\r\n<form");

WriteLiteral(" id=\"frmSemYOUSearch\"");

WriteLiteral(" method=\"get\"");

WriteAttribute("action", Tuple.Create(" action=\"", 333), Tuple.Create("\"", 369)
            
            #line 11 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 342), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.ResultsUrl)
            
            #line default
            #line hidden
, 342), false)
);

WriteLiteral(">\r\n    <span");

WriteLiteral(" class=\"sy-search\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" name=\"searchQuery\"");

WriteLiteral(" placeholder=\"Wie k??nnen wir Ihnen helfen?\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n        <input");

WriteLiteral(" id=\"btnsearch\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"\"");

WriteLiteral("  />\r\n    </span>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 619), Tuple.Create("\"", 654)
            
            #line 17 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 627), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.ResultsUrl)
            
            #line default
            #line hidden
, 627), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 706), Tuple.Create("\"", 745)
            
            #line 18 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 714), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.IndexCatalogue)
            
            #line default
            #line hidden
, 714), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 792), Tuple.Create("\"", 837)
            
            #line 19 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 800), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.WordsMode.ToString())
            
            #line default
            #line hidden
, 800), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 901), Tuple.Create("\'", 975)
            
            #line 20 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 909), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? Html.Raw("true") : Html.Raw("false")
            
            #line default
            #line hidden
, 909), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1040), Tuple.Create("\"", 1084)
            
            #line 21 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 1048), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MinSuggestionLength)
            
            #line default
            #line hidden
, 1048), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1146), Tuple.Create("\"", 1187)
            
            #line 22 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.SuggestionFields)
            
            #line default
            #line hidden
, 1154), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1241), Tuple.Create("\"", 1274)
            
            #line 23 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 1249), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Language)
            
            #line default
            #line hidden
, 1249), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1336), Tuple.Create("\"", 1377)
            
            #line 24 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.SuggestionsRoute)
            
            #line default
            #line hidden
, 1344), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1438), Tuple.Create("\'", 1481)
            
            #line 25 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 1446), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 1446), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1541), Tuple.Create("\'", 1583)
            
            #line 26 "..\..MVC\Views\SearchBox\SearchBoxSEMYOU.cshtml"
, Tuple.Create(Tuple.Create("", 1549), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 1549), false)
);

WriteLiteral(" />\r\n</form>\r\n\r\n \r\n\r\n");

WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
