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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.UnsubscribeForm
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
    
    #line 3 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/UnsubscribeForm/UnsubscribeFormByLink.UnsubscribeMessage.cshtml")]
    public partial class UnsubscribeFormByLink_UnsubscribeMessage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.UnsubscribeForm.UnsubscribeFormViewModel>
    {
        public UnsubscribeFormByLink_UnsubscribeMessage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 156), Tuple.Create("\"", 179)
            
            #line 5 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
, Tuple.Create(Tuple.Create("", 164), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 164), false)
);

WriteLiteral(">\n");

            
            #line 6 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
     if (ViewBag.IsSubscribe == false)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 8 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
       Write(Html.Resource("UnsubscribeSuccessful"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 9 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <pre>");

            
            #line 10 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByLink.UnsubscribeMessage.cshtml"
    Write(Html.HtmlSanitize(Model.Message));

            
            #line default
            #line hidden
WriteLiteral("</pre>\n</div>");

        }
    }
}
#pragma warning restore 1591
