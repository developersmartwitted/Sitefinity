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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.TextField
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
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/TextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField.TextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n<!-- InputCssClass class variable -->\n\n");

            
            #line 12 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
   var inputCssClass = "";
   HashSet<TextType> availableOptions = new HashSet<TextType>() { TextType.Text, TextType.Password, TextType.Date, TextType.DateTimeLocal, TextType.Month, TextType.Time,
   TextType.Week, TextType.Number, TextType.Email,TextType.Url, TextType.Tel, TextType.Color };

   if (availableOptions.Contains(Model.InputType))
   {
       inputCssClass = "form-control";
   }

            
            #line default
            #line hidden
WriteLiteral("\n\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 823), Tuple.Create("\"", 857)
            
            #line 23 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 831), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 831), false)
, Tuple.Create(Tuple.Create(" ", 846), Tuple.Create("form-group", 847), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 958), Tuple.Create("\'", 1071)
, Tuple.Create(Tuple.Create("", 966), Tuple.Create("{\"maxLength\":\"", 966), true)
            
            #line 24 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
     , Tuple.Create(Tuple.Create("", 980), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 980), false)
, Tuple.Create(Tuple.Create("", 1016), Tuple.Create("\",", 1016), true)
, Tuple.Create(Tuple.Create(" ", 1018), Tuple.Create("\"minLength\":", 1019), true)
, Tuple.Create(Tuple.Create(" ", 1031), Tuple.Create("\"", 1032), true)
            
            #line 24 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1033), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 1033), false)
, Tuple.Create(Tuple.Create("", 1069), Tuple.Create("\"}", 1069), true)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1134), Tuple.Create("\'", 1414)
, Tuple.Create(Tuple.Create("", 1142), Tuple.Create("{\"maxLength\":\"", 1142), true)
            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1156), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1156), false)
, Tuple.Create(Tuple.Create("", 1208), Tuple.Create("\",", 1208), true)
, Tuple.Create(Tuple.Create(" ", 1210), Tuple.Create("\"required\":", 1211), true)
, Tuple.Create(Tuple.Create(" ", 1222), Tuple.Create("\"", 1223), true)
            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                    , Tuple.Create(Tuple.Create("", 1224), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1224), false)
, Tuple.Create(Tuple.Create("", 1275), Tuple.Create("\",", 1275), true)
, Tuple.Create(Tuple.Create(" ", 1277), Tuple.Create("\"invalid\":", 1278), true)
, Tuple.Create(Tuple.Create(" ", 1288), Tuple.Create("\"", 1289), true)
            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                      , Tuple.Create(Tuple.Create("", 1290), Tuple.Create<System.Object, System.Int32>(Html.Resource("InvalidEntryMessage")
            
            #line default
            #line hidden
, 1290), false)
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create("\",", 1327), true)
, Tuple.Create(Tuple.Create(" ", 1329), Tuple.Create("\"regularExpression\":", 1330), true)
, Tuple.Create(Tuple.Create(" ", 1350), Tuple.Create("\"", 1351), true)
            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1352), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1352), false)
, Tuple.Create(Tuple.Create("", 1412), Tuple.Create("\"}", 1412), true)
);

WriteLiteral(" />\n\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 1430), Tuple.Create("\'", 1461)
            
            #line 27 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1436), false)
);

WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                      Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\n    <input");

WriteAttribute("id", Tuple.Create(" id=\'", 1504), Tuple.Create("\'", 1534)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1509), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1509), false)
);

WriteLiteral(" data-sf-role=\"text-field-input\"");

WriteAttribute("type", Tuple.Create(" type=\"", 1567), Tuple.Create("\"", 1608)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1574), Tuple.Create<System.Object, System.Int32>(Model.InputType.ToHtmlInputType()
            
            #line default
            #line hidden
, 1574), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1609), Tuple.Create("\"", 1642)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                          , Tuple.Create(Tuple.Create("", 1616), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1616), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1643), Tuple.Create("\"", 1679)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                                   , Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 1657), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1680), Tuple.Create("\"", 1700)
            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                  , Tuple.Create(Tuple.Create("", 1688), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 1688), false)
);

WriteLiteral(" ");

            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                           Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral(" class=\"");

            
            #line 28 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                                                                        Write(inputCssClass);

            
            #line default
            #line hidden
WriteLiteral("\" />\n");

            
            #line 29 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
      if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 31 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
                          Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 32 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 35 "..\..\ResourcePackages\Semyou\MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/TextField/text-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
