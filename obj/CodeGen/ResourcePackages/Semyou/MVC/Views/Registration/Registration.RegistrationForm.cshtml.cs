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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Registration
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
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Registration/Registration.RegistrationForm.cs" +
        "html")]
    public partial class Registration_RegistrationForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration.RegistrationViewModel>
    {
        public Registration_RegistrationForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 12 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
  
    var isTwoCols = (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0) ? "col-md-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 663), Tuple.Create("\"", 699)
            
            #line 18 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 671), false)
, Tuple.Create(Tuple.Create(" ", 686), Tuple.Create("row", 687), true)
, Tuple.Create(Tuple.Create(" ", 690), Tuple.Create("sf-m-xxs", 691), true)
);

WriteLiteral(">\n");

            
            #line 19 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 19 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
     if ((Request.QueryString["ShowActivationMsg"] == "true") ||
	 (ViewBag.ShowActivationMsg is bool && ViewBag.ShowActivationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>\n");

WriteLiteral("            ");

            
            #line 23 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.Resource("VisitYourEmail"));

            
            #line default
            #line hidden
WriteLiteral("\n        </h3>\n");

            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 26 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
      Write(string.Format(Html.Resource("ActivationLinkHasBeenSent"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"sendAgainLink\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                     Write(Html.Resource("SendAgain"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" data-sf-role=\"confirmationResendInfo\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(string.Format(Html.Resource("ActivationLinkHasBeenSentAgain"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("\n            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"sendAgainLink\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 31 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                         Write(Html.Resource("SendAgain"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n        </div>\n");

            
            #line 33 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-resend-confirmation-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1505), Tuple.Create("\"", 1579)
            
            #line 34 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       , Tuple.Create(Tuple.Create("", 1513), Tuple.Create<System.Object, System.Int32>(Url.Action("ResendConfirmationEmail", new { email = Model.Email})
            
            #line default
            #line hidden
, 1513), false)
);

WriteLiteral(" />\n");

            
            #line 35 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    }
    else if ((Request.QueryString["ShowSuccessfulRegistrationMsg"] == "true") ||
             (ViewBag.ShowSuccessfulRegistrationMsg is bool && ViewBag.ShowSuccessfulRegistrationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 39 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

WriteLiteral("        <p>");

            
            #line 40 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
      Write(Html.Resource("DefaultSuccessfulRegistrationMessage"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 41 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"

    }
    else
    {
        using (Html.BeginFormSitefinity(true))
        {
          
            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
     Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                       ;

            
            #line default
            #line hidden
WriteLiteral("          <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2028), Tuple.Create("\"", 2046)
            
            #line 48 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 2036), Tuple.Create<System.Object, System.Int32>(isTwoCols
            
            #line default
            #line hidden
, 2036), false)
);

WriteLiteral(">\n               <h3");

WriteLiteral(" class=\"sf-mb-xl\"");

WriteLiteral(">");

            
            #line 49 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                               Write(Html.Resource("Registration"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 50 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                if (!string.IsNullOrEmpty(ViewBag.Error))
               {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 53 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 55 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               }

            
            #line default
            #line hidden
WriteLiteral("                \n");

WriteLiteral("\t\t\t   ");

            
            #line 57 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          Write(Html.HiddenFor(m => m.RequiresQuestionAndAnswer));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\n               <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 61 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("FirstName"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 64 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.TextBox("Profile[FirstName]", null, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n                </div>\n            \n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 70 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("LastName"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 73 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.TextBox("Profile[LastName]", null, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n                </div>\n            \n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("Email"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 82 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", type = "email" }));

            
            #line default
            #line hidden
WriteLiteral("\n                          \n");

            
            #line 84 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 84 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Html.ValidationMessageFor(m => m.Email) != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 87 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                Write(Html.ValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </div>\n");

            
            #line 89 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    } 

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n       \n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 95 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("Password"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 98 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 100 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 100 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Html.ValidationMessageFor(m => m.Password) != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("> ");

            
            #line 103 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                 Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </div>\n");

            
            #line 105 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    } 

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n            \n               <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 111 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("ReTypePassword"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 114 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.PasswordFor(m => m.ReTypePassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                            \n");

            
            #line 116 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 116 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Html.ValidationMessageFor(m => m.ReTypePassword) != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 119 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                Write(Html.ValidationMessageFor(m => m.ReTypePassword));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </div>\n");

            
            #line 121 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    } 

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n    \t\t\t\n");

            
            #line 125 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    			
            
            #line default
            #line hidden
            
            #line 125 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 if (Model.RequiresQuestionAndAnswer)
                {
    				

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n    \t\t\t\t\t<label>\n");

WriteLiteral("    \t\t\t\t\t\t");

            
            #line 130 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                       Write(Html.Resource("Question"));

            
            #line default
            #line hidden
WriteLiteral("\n    \t\t\t\t\t</label>\n\n");

WriteLiteral("    \t\t\t\t\t");

            
            #line 133 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.TextBoxFor(m => m.Question, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 135 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					
            
            #line default
            #line hidden
            
            #line 135 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                         if (Html.ValidationMessageFor(m => m.Question) != null)
    					{

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n    \t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("> ");

            
            #line 138 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                     Write(Html.ValidationMessageFor(m => m.Question));

            
            #line default
            #line hidden
WriteLiteral("</span>\n    \t\t\t\t\t\t</div>\n");

            
            #line 140 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					} 

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t</div>\n");

            
            #line 142 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    				

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n    \t\t\t\t\t<label>\n");

WriteLiteral("    \t\t\t\t\t\t");

            
            #line 145 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                       Write(Html.Resource("Answer"));

            
            #line default
            #line hidden
WriteLiteral("\n    \t\t\t\t\t</label>\n\n");

WriteLiteral("    \t\t\t\t\t");

            
            #line 148 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.TextBoxFor(m => m.Answer, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 150 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					
            
            #line default
            #line hidden
            
            #line 150 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                         if (Html.ValidationMessageFor(m => m.Answer) != null)
    					{

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n    \t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("> ");

            
            #line 153 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                     Write(Html.ValidationMessageFor(m => m.Answer));

            
            #line default
            #line hidden
WriteLiteral("</span>\n    \t\t\t\t\t\t</div>\n");

            
            #line 155 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					}

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t</div>\n");

            
            #line 157 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 160 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 160 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode )
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 162 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                             Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 163 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 166 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                             Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 167 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n                <div");

WriteLiteral(" class=\"sf-mt-l\"");

WriteLiteral(">\n                    <div>Already registered?</div>\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6222), Tuple.Create("\"", 6248)
            
            #line 171 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 6229), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 6229), false)
);

WriteLiteral(">");

            
            #line 171 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                             Write(Html.Resource("BackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n                </div>\n            </div>\n");

            
            #line 174 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
			
			if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">    \n                <h3");

WriteLiteral(" class=\"sf-mb-xl\"");

WriteLiteral(">");

            
            #line 178 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                Write(Html.Resource("ConnectWith"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 180 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 180 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 foreach (var provider in Model.ExternalProviders)
                {
                    var classToBeAdd = "btn btn-default btn-lg btn-block " + @provider.Value;                 
                    
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"sf-mb-xs\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 184 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 186 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n");

            
            #line 188 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 192 "..\..\ResourcePackages\Semyou\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Registration/registration-form.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
