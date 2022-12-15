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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.EventScheduler
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/EventScheduler/Detail.EventDetails.cshtml" +
        "")]
    public partial class Detail_EventDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_EventDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 224), Tuple.Create("\"", 247)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 232), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 232), false)
);

WriteLiteral(" ");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n    <h3");

WriteLiteral(" class=\"sf-event-title\"");

WriteLiteral(">\n        <span ");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n    </h3>\n    <span");

WriteLiteral(" class=\"sf-event-type\"");

WriteAttribute("style", Tuple.Create(" style=\"", 532), Tuple.Create("\"", 585)
, Tuple.Create(Tuple.Create("", 540), Tuple.Create("background:", 540), true)
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 551), Tuple.Create<System.Object, System.Int32>(Model.Item.EventCalendarColour()
            
            #line default
            #line hidden
, 552), false)
);

WriteLiteral("></span>\n\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.EventDates())) 
	{

            
            #line default
            #line hidden
WriteLiteral("    <p>\n        <time>");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         Write(Model.Item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time>\n    </p>\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \n");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.City) || !string.IsNullOrEmpty(Model.Item.Fields.Country))
    {
            
            #line default
            #line hidden
WriteLiteral("<address>\n\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.City) && !string.IsNullOrEmpty(Model.Item.Fields.Country))
        {
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral(" <span>,</span> ");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                   
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                              Write(Model.Item.Fields.Country);

            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                             

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        Write(string.IsNullOrEmpty(Model.Item.Fields.City) ? Model.Item.Fields.Country : Model.Item.Fields.City);

            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("             <br>\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.Street))
        {
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Street);

            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                     
        }

            
            #line default
            #line hidden
WriteLiteral("    </address>\n");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \n    <div>\n");

            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactName))
        {
            
            
            #line default
            #line hidden
            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactName);

            
            #line default
            #line hidden
            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactPhone))
        {
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactPhone);

            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                           

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 54 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 54 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactCell))
        {
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactCell);

            
            #line default
            #line hidden
            
            #line 56 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 58 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("            \n");

            
            #line 60 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 60 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactEmail))
        {

            
            #line default
            #line hidden
WriteLiteral("            <address><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1962), Tuple.Create("\"", 2009)
, Tuple.Create(Tuple.Create("", 1969), Tuple.Create("mailto:", 1969), true)
            
            #line 62 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1976), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.ContactEmail
            
            #line default
            #line hidden
, 1976), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 62 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                   Write(Model.Item.Fields.ContactEmail);

            
            #line default
            #line hidden
WriteLiteral("</a></address>\n");

            
            #line 63 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 65 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 65 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactWeb))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2174), Tuple.Create("\"", 2238)
            
            #line 67 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2181), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize((string)Model.Item.Fields.ContactWeb)
            
            #line default
            #line hidden
, 2181), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 67 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                           Write(Model.Item.Fields.ContactWeb);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 68 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n\n");

            
            #line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Location))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\n\t\t\t");

WriteLiteral("\n");

WriteLiteral("\t\t\t");

            
            #line 75 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Location);

            
            #line default
            #line hidden
WriteLiteral("\n\t\t</p>\n");

            
            #line 77 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 79 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 79 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\n");

WriteLiteral("            ");

            
            #line 82 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n");

            
            #line 84 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n    <p>\n");

WriteLiteral("        ");

            
            #line 87 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
   Write(Html.CommentsCount(string.Empty, Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n\t</p>\n    \n");

            
            #line 90 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 90 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (ViewBag.AllowCalendarExport)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\n            <span>");

            
            #line 93 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
             Write(Html.Resource("AddTo"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n            <ul>\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2851), Tuple.Create("\"", 2890)
            
            #line 95 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2858), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateOutlookUrl()
            
            #line default
            #line hidden
, 2858), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 95 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                          Write(Html.Resource("OutlookEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2984), Tuple.Create("\"", 3020)
            
            #line 96 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2991), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateICalUrl()
            
            #line default
            #line hidden
, 2991), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 96 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                       Write(Html.Resource("ICalEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3111), Tuple.Create("\"", 3149)
            
            #line 97 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3118), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateGoogleUrl()
            
            #line default
            #line hidden
, 3118), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 97 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                         Write(Html.Resource("GoogleEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n            </ul>\n        </div>\n");

            
            #line 100 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 102 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 102 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Summary))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 104 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 104 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                Write(Html.HtmlSanitize((string)Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 105 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 107 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 107 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Content))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 109 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 109 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                Write(Html.HtmlSanitize((string)Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 110 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("    ");

            
            #line 112 "..\..\ResourcePackages\Bootstrap4\MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
Write(Html.CommentsList(Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n\n</div>\n");

        }
    }
}
#pragma warning restore 1591
