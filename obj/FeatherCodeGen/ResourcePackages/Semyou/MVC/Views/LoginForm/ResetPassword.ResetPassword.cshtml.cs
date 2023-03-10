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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.LoginForm
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
    
    #line 4 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginForm/ResetPassword.ResetPassword.cshtml")]
    public partial class ResetPassword_ResetPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ResetPasswordViewModel>
    {
        public ResetPassword_ResetPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 175), Tuple.Create("\"", 198)
            
            #line 6 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 183), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 183), false)
);

WriteLiteral(">\n    \n    <h3>");

            
            #line 8 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
   Write(Html.Resource("ResetPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 10 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
     if (Model.ResetComplete)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 12 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Html.Resource("ResetPasswordSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 360), Tuple.Create("\"", 386)
            
            #line 13 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 367), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 367), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                         Write(Html.Resource("ResetPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 14 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }
    else if (Model.RequiresQuestionAndAnswer && string.IsNullOrEmpty(Model.ResetPasswordQuestion))
    {
        
            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
   Write(Html.Resource("CannotResetPasswordError"));

            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                  
    }
    else
    {        

            
            #line default
            #line hidden
WriteLiteral("        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 663), Tuple.Create("\"", 715)
            
            #line 21 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 672), Tuple.Create<System.Object, System.Int32>(Url.Action("ResetPassword", "LoginForm")
            
            #line default
            #line hidden
, 672), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(">\n");

            
            #line 22 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
             if (!string.IsNullOrEmpty(Model.Error))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 25 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
               Write(Model.Error);

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 27 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("    \n");

WriteLiteral("            ");

            
            #line 29 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Html.HiddenFor(u => u.SecurityToken));

            
            #line default
            #line hidden
WriteLiteral("\n    \n");

            
            #line 31 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
             if (Model.RequiresQuestionAndAnswer)
            {
            

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>");

            
            #line 35 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                      Write(Model.ResetPasswordQuestion);

            
            #line default
            #line hidden
WriteLiteral("</label>\n");

WriteLiteral("                    ");

            
            #line 36 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
               Write(Html.TextBoxFor(u => u.ResetPasswordAnswer, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 38 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        \n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>");

            
            #line 41 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                  Write(Html.Resource("ResetPasswordNewPassword"));

            
            #line default
            #line hidden
WriteLiteral("</label>\n");

WriteLiteral("                ");

            
            #line 42 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.PasswordFor(u => u.NewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n            </div>\n\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>");

            
            #line 47 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                  Write(Html.Resource("ResetPasswordRepeatNewPassword"));

            
            #line default
            #line hidden
WriteLiteral("</label>\n");

WriteLiteral("                 ");

            
            #line 48 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            Write(Html.PasswordFor(u => u.RepeatNewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n    \n            <button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 51 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                     Write(Html.Resource("ResetPasswordSaveButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n        \n        </form>\n");

            
            #line 54 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n");

        }
    }
}
#pragma warning restore 1591
