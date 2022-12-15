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
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n<input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" class=\"search-field\"");

WriteLiteral("   name=\"s\"");

WriteAttribute("title", Tuple.Create(" title=\"", 352), Tuple.Create("\"", 389)
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 360), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 360), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 390), Tuple.Create("\"", 425)
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
                         , Tuple.Create(Tuple.Create("", 404), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 404), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 426), Tuple.Create("\"", 457)
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 431), Tuple.Create<System.Object, System.Int32>(Html.Raw(searchTextBoxId)
            
            #line default
            #line hidden
, 431), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 458), Tuple.Create("\"", 496)
            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                       , Tuple.Create(Tuple.Create("", 466), Tuple.Create<System.Object, System.Int32>(Html.Raw(ViewBag.SearchQuery)
            
            #line default
            #line hidden
, 466), false)
);

WriteLiteral(" />\r\n\r\n                                ");

WriteLiteral("\r\n                            \r\n\r\n\r\n\r\n<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"search-submit\"");

WriteAttribute("id", Tuple.Create(" id=\"", 681), Tuple.Create("\"", 711)
            
            #line 21 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 686), Tuple.Create<System.Object, System.Int32>(Html.Raw(searchButtonId)
            
            #line default
            #line hidden
, 686), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                      Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 801), Tuple.Create("\"", 836)
            
            #line 23 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 809), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.ResultsUrl)
            
            #line default
            #line hidden
, 809), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 892), Tuple.Create("\"", 931)
            
            #line 24 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 900), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.IndexCatalogue)
            
            #line default
            #line hidden
, 900), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 982), Tuple.Create("\"", 1027)
            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 990), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.WordsMode.ToString())
            
            #line default
            #line hidden
, 990), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1087), Tuple.Create("\'", 1161)
            
            #line 26 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1095), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? Html.Raw("true") : Html.Raw("false")
            
            #line default
            #line hidden
, 1095), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1222), Tuple.Create("\"", 1266)
            
            #line 27 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1230), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MinSuggestionLength)
            
            #line default
            #line hidden
, 1230), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1324), Tuple.Create("\"", 1365)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1332), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.SuggestionFields)
            
            #line default
            #line hidden
, 1332), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1415), Tuple.Create("\"", 1448)
            
            #line 29 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1423), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Language)
            
            #line default
            #line hidden
, 1423), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1506), Tuple.Create("\"", 1547)
            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1514), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.SuggestionsRoute)
            
            #line default
            #line hidden
, 1514), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1604), Tuple.Create("\'", 1647)
            
            #line 31 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1612), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 1612), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1703), Tuple.Create("\'", 1745)
            
            #line 32 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1711), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 1711), false)
);

WriteLiteral(" />\r\n\r\n\r\n");

WriteLiteral("\r\n\r\n");

            
            #line 37 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 38 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 40 "..\..\ResourcePackages\Semyou\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
