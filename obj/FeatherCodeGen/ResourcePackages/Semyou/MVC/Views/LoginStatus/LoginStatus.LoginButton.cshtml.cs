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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.LoginStatus
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
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginButton.cshtml")]
    public partial class LoginStatus_LoginButton : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginButton()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 9 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
  
    var SignOutUrl = string.Concat(Url.Action("SignOut"), string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 438), Tuple.Create("\"", 461)
            
            #line 13 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 446), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 446), false)
);

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"media\"");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"media-left sf-pr-xl\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"media-object\"");

WriteLiteral(">\n                <img");

WriteLiteral(" data-sf-role=\"sf-logged-in-avatar\"");

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\n            </div>\n        </div>\n        <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 789), Tuple.Create("\"", 826)
            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 796), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 796), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral("></a>\n            <p");

WriteLiteral(" data-sf-role=\"sf-logged-in-email\"");

WriteLiteral("></p>      \n            <a");

WriteLiteral(" class=\"btn btn-default\"");

WriteAttribute("href", Tuple.Create(" href=\"", 964), Tuple.Create("\"", 982)
            
            #line 23 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 971), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 971), false)
);

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                     Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n        </div>\n    </div>\n\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n\n        <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-sf-role=\"login-status-button\"");

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                                      Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1225), Tuple.Create("\"", 1267)
            
            #line 30 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1232), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 1232), false)
);

WriteLiteral(">");

            
            #line 30 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n\n    </div>\n</div>\n\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1386), Tuple.Create("\"", 1417)
            
            #line 35 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1394), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1394), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1479), Tuple.Create("\"", 1507)
            
            #line 36 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1487), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1487), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-login-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1568), Tuple.Create("\"", 1595)
            
            #line 37 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1576), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 1576), false)
);

WriteLiteral(" />\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1659), Tuple.Create("\"", 1699)
            
            #line 38 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1667), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1667), false)
);

WriteLiteral(" />\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1766), Tuple.Create("\"", 1812)
            
            #line 39 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1774), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1774), false)
);

WriteLiteral(" />\n\n");

            
            #line 41 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
