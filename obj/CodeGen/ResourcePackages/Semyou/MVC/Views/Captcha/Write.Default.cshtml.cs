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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Captcha
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
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Captcha/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.Captcha.CaptchaViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" data-sf-role=\"field-captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 322), Tuple.Create("\"", 356)
            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 330), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 330), false)
, Tuple.Create(Tuple.Create(" ", 345), Tuple.Create("form-group", 346), true)
);

WriteLiteral(">\n    <div>\n        <img");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\'", 410), Tuple.Create("\'", 463)
            
            #line 11 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 416), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 416), false)
);

WriteLiteral("/>\n    </div>\n\n    <a");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
                                        Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n\n    <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t<input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 675), Tuple.Create("\'", 750)
, Tuple.Create(Tuple.Create("", 683), Tuple.Create("{\"required\":", 683), true)
, Tuple.Create(Tuple.Create(" ", 695), Tuple.Create("\"", 696), true)
            
            #line 18 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
         , Tuple.Create(Tuple.Create("", 697), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 697), false)
, Tuple.Create(Tuple.Create("", 748), Tuple.Create("\"}", 748), true)
);

WriteLiteral(" />\n            <label");

WriteAttribute("for", Tuple.Create(" for=\'", 773), Tuple.Create("\'", 804)
            
            #line 19 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 779), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 779), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
                                              Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral(" </label>\n            <input");

WriteAttribute("id", Tuple.Create(" id=\'", 865), Tuple.Create("\'", 895)
            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 870), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 870), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteAttribute("name", Tuple.Create(" name=\"", 937), Tuple.Create("\"", 971)
            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
                  , Tuple.Create(Tuple.Create("", 944), Tuple.Create<System.Object, System.Int32>(Model.CaptchaAnswerFormKey
            
            #line default
            #line hidden
, 944), false)
);

WriteLiteral(" required=\"required\"");

WriteLiteral(" class=\"form-control input-sm\"");

WriteLiteral("/>\n            <p");

WriteLiteral(" data-sf-role=\"invalid-captcha-input\"");

WriteLiteral("  class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
           Write(Html.Resource("CaptchaErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\n        </div>\n    </div>\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-ca\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1255), Tuple.Create("\"", 1296)
            
            #line 26 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1262), Tuple.Create<System.Object, System.Int32>(Model.CaptchaCorrectAnswerFormKey
            
            #line default
            #line hidden
, 1262), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-iv\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1351), Tuple.Create("\"", 1399)
            
            #line 27 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1358), Tuple.Create<System.Object, System.Int32>(Model.CaptchaInitializationVectorFormKey
            
            #line default
            #line hidden
, 1358), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-k\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1453), Tuple.Create("\"", 1484)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1460), Tuple.Create<System.Object, System.Int32>(Model.CaptchaKeyFormKey
            
            #line default
            #line hidden
, 1460), false)
);

WriteLiteral(" />\n\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1546), Tuple.Create("\"", 1572)
            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1554), Tuple.Create<System.Object, System.Int32>(Model.GenerateUrl
            
            #line default
            #line hidden
, 1554), false)
);

WriteLiteral(" />\n</div>\n\n");

            
            #line 33 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
 if (SystemManager.IsDesignMode)
{
    var scriptUrl = Url.WidgetContent("Mvc/Scripts/Captcha/captcha.js");
    var queryAddition = scriptUrl.Contains("?") ? "&" : "?";
    var fullScriptUrl = scriptUrl + queryAddition + string.Format("_={0}", DateTime.UtcNow.Ticks.ToString());
    

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\'", 1903), Tuple.Create("\'", 1923)
            
            #line 39 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1909), Tuple.Create<System.Object, System.Int32>(fullScriptUrl
            
            #line default
            #line hidden
, 1909), false)
);

WriteLiteral("></script>\n");

            
            #line 40 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 43 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Captcha/captcha.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 43 "..\..\ResourcePackages\Semyou\MVC\Views\Captcha\Write.Default.cshtml"
                                                                                      
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
