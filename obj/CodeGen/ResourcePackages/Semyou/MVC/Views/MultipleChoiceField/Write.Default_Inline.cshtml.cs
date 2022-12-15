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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/MultipleChoiceField/Write.Default_Inline.csht" +
        "ml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 550), Tuple.Create("\"", 584)
            
            #line 15 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 558), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 558), false)
, Tuple.Create(Tuple.Create(" ", 573), Tuple.Create("form-group", 574), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 692), Tuple.Create("\'", 748)
, Tuple.Create(Tuple.Create("", 700), Tuple.Create("{", 700), true)
, Tuple.Create(Tuple.Create(" ", 701), Tuple.Create("\"required\":", 702), true)
, Tuple.Create(Tuple.Create(" ", 713), Tuple.Create("\"", 714), true)
            
            #line 16 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 715), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 715), false)
, Tuple.Create(Tuple.Create("", 746), Tuple.Create("\"}", 746), true)
);

WriteLiteral(" />\n        <strong>");

            
            #line 17 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
           Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\n");

            
            #line 18 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
        {

            
            #line default
            #line hidden
WriteLiteral("           <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                            Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 21 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 22 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1498), Tuple.Create("\"", 1515)
            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1505), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1505), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1516), Tuple.Create("\"", 1531)
            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1524), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1524), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                            Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 30 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                               Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" />\n");

WriteLiteral("                ");

            
            #line 31 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
           Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\n            </label>\n");

            
            #line 33 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 35 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if(Model.HasOtherChoice)
        {
           

            
            #line default
            #line hidden
WriteLiteral("            <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\n                <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1806), Tuple.Create("\"", 1823)
            
            #line 39 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1813), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1813), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral("/>\n");

WriteLiteral("                ");

            
            #line 40 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
           Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\n            </label>\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteLiteral(" />\n");

            
            #line 43 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
            
        }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n\n");

            
            #line 48 "..\..\ResourcePackages\Semyou\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/MultipleChoiceField/multiple-choice-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591