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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Captcha
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
    
    #line 3 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Captcha/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.Captcha.CaptchaViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"field-captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 326), Tuple.Create("\"", 360)
            
            #line 7 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 334), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 334), false)
, Tuple.Create(Tuple.Create(" ", 349), Tuple.Create("form-group", 350), true)
);

WriteLiteral(">\r\n    <div>\r\n        <img");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\'", 416), Tuple.Create("\'", 469)
            
            #line 9 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 422), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 422), false)
);

WriteLiteral(" />\r\n");

            
            #line 10 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..MVC\Views\Captcha\Write.Default.cshtml"
         if (Model.EnableAudioCode)
        {

            
            #line default
            #line hidden
WriteLiteral("            <button");

WriteLiteral(" class=\"sf-Captcha-button btn btn-light ml-4\"");

WriteLiteral(" data-sf-role=\"captcha-audio-btn\"");

WriteLiteral(" type=\"button\"");

WriteAttribute("title", Tuple.Create(" title=\"", 634), Tuple.Create("\"", 679)
            
            #line 12 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                        , Tuple.Create(Tuple.Create("", 642), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaAudioTooltip")
            
            #line default
            #line hidden
, 642), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 680), Tuple.Create("\"", 730)
            
            #line 12 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                                                           , Tuple.Create(Tuple.Create("", 693), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaAudioTooltip")
            
            #line default
            #line hidden
, 693), false)
);

WriteLiteral(">\r\n                <svg");

WriteLiteral(" class=\"sf-icon-xxs\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                    <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 820), Tuple.Create("\"", 902)
, Tuple.Create(Tuple.Create("", 833), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#volume-up")
, 833), false)
);

WriteLiteral("></use>\r\n                </svg>\r\n            </button>\r\n");

WriteLiteral("            <audio");

WriteLiteral(" data-sf-role=\"captcha-audio\"");

WriteLiteral(" controls");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(" />\r\n");

            
            #line 18 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(">");

            
            #line 20 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                 Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1280), Tuple.Create("\'", 1355)
, Tuple.Create(Tuple.Create("", 1288), Tuple.Create("{\"required\":", 1288), true)
, Tuple.Create(Tuple.Create(" ", 1300), Tuple.Create("\"", 1301), true)
            
            #line 23 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1302), false)
, Tuple.Create(Tuple.Create("", 1353), Tuple.Create("\"}", 1353), true)
);

WriteLiteral(" />\r\n            <label");

WriteAttribute("for", Tuple.Create(" for=\'", 1379), Tuple.Create("\'", 1410)
            
            #line 24 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1385), false)
);

WriteLiteral(">");

            
            #line 24 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                              Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral(" </label>\r\n            <input");

WriteAttribute("id", Tuple.Create(" id=\'", 1472), Tuple.Create("\'", 1502)
            
            #line 25 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1477), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1477), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1544), Tuple.Create("\"", 1578)
            
            #line 25 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                 , Tuple.Create(Tuple.Create("", 1551), Tuple.Create<System.Object, System.Int32>(Model.CaptchaAnswerFormKey
            
            #line default
            #line hidden
, 1551), false)
);

WriteLiteral(" required=\"required\"");

WriteLiteral(" class=\"form-control input-sm\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-k\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1812), Tuple.Create("\"", 1843)
            
            #line 29 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1819), Tuple.Create<System.Object, System.Int32>(Model.CaptchaKeyFormKey
            
            #line default
            #line hidden
, 1819), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1905), Tuple.Create("\"", 1931)
            
            #line 30 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1913), Tuple.Create<System.Object, System.Int32>(Model.GenerateUrl
            
            #line default
            #line hidden
, 1913), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-iam\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1988), Tuple.Create("\'", 2033)
            
            #line 31 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1996), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaErrorMessage")
            
            #line default
            #line hidden
, 1996), false)
);

WriteLiteral(" />\r\n</div>\r\n");

            
            #line 33 "..\..MVC\Views\Captcha\Write.Default.cshtml"
 if (SystemManager.IsDesignMode)
{
    var scriptUrl = Url.WidgetContent("Mvc/Scripts/Captcha/captcha.js");
    var queryAddition = scriptUrl.Contains("?") ? "&" : "?";
    var fullScriptUrl = scriptUrl + queryAddition + string.Format("_={0}", DateTime.UtcNow.Ticks.ToString());


            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\'", 2367), Tuple.Create("\'", 2387)
            
            #line 39 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2373), Tuple.Create<System.Object, System.Int32>(fullScriptUrl
            
            #line default
            #line hidden
, 2373), false)
);

WriteLiteral("></script>\r\n");

            
            #line 40 "..\..MVC\Views\Captcha\Write.Default.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                                                    
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
