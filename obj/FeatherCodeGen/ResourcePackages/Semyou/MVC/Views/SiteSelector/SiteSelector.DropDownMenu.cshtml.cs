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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.SiteSelector
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
    
    #line 5 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SiteSelector/SiteSelector.DropDownMenu.cshtml")]
    public partial class SiteSelector_DropDownMenu : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector.SiteSelectorViewModel>
    {
        public SiteSelector_DropDownMenu()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 253), Tuple.Create("\"", 276)
            
            #line 7 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 261), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 261), false)
);

WriteLiteral(">\n\n    <h3>");

            
            #line 9 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
   Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n    <label");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 11 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                      Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</label>\n");

            
            #line 12 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
     if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<select>\n");

            
            #line 15 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<select onchange=\"document.location.href = this.value\">\n");

            
            #line 19 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 20 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
             if (!Model.IncludeCurrentSite)
            { 

            
            #line default
            #line hidden
WriteLiteral("                <option>");

            
            #line 22 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                   Write(Html.Resource("SelectSite"));

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 23 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 25 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
              
                string currentSite = string.Empty;
             
            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 29 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
             foreach (var site in Model.Sites)
            {                
                if (!Model.EachLanguageAsSeparateSite)
                {

            
            #line default
            #line hidden
WriteLiteral("                     <option");

WriteAttribute("value", Tuple.Create(" value=\"", 998), Tuple.Create("\"", 1015)
            
            #line 33 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1006), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1006), false)
);

WriteLiteral(" ");

            
            #line 33 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                           Write(site.IsCurrent ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 33 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                       Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 34 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                }
                else if (Model.SiteLanguagesDisplayMode == SiteLanguagesDisplayMode.SiteNamesAndLanguages)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1252), Tuple.Create("\"", 1269)
            
            #line 37 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1260), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1260), false)
);

WriteLiteral(" ");

            
            #line 37 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                          Write(site.IsCurrent ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 37 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                                   Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 38 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                }
                else
                {
                    if(currentSite != site.Name)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">- ");

            
            #line 43 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" -</option>\n");

            
            #line 44 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                        currentSite = site.Name;
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1644), Tuple.Create("\"", 1661)
            
            #line 46 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1652), false)
);

WriteLiteral(" ");

            
            #line 46 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                          Write(site.IsCurrent ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 46 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                      Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 47 "..\..MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\n   \n</div>");

        }
    }
}
#pragma warning restore 1591