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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.SubmitButton
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
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/SubmitButton/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.SubmitButton.SubmitButtonViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 289), Tuple.Create("\"", 323)
            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 297), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 297), false)
, Tuple.Create(Tuple.Create(" ", 312), Tuple.Create("form-group", 313), true)
);

WriteLiteral(">\n\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" ");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
                     Write(Html.SubmitButtonRequiredAttributes());

            
            #line default
            #line hidden
WriteLiteral(" class=\"sf-SubmitButton btn btn-primary\">");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
                                                                                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 11 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
     if (Model.AllowGoBack)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-btn-role=\"prev\"");

WriteLiteral(">");

            
            #line 13 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
                                                        Write(Html.HtmlSanitize(Model.PreviousStepText));

            
            #line default
            #line hidden
WriteLiteral(" </a>\n");

            
            #line 14 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 17 "..\..\ResourcePackages\Semyou\MVC\Views\SubmitButton\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SubmitButton/submit-button.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
