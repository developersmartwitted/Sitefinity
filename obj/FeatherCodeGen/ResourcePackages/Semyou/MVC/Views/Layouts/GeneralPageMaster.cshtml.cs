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

namespace SitefinityWebApp.ResourcePackages.Semyou.MVC.Views.Layouts
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 1 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Layouts/GeneralPageMaster.cshtml")]
    public partial class GeneralPageMaster : System.Web.Mvc.WebViewPage<dynamic>
    {
        public GeneralPageMaster()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html ");

            
            #line 8 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
 Write(Html.RenderLangAttribute());

            
            #line default
            #line hidden
WriteLiteral(" >\r\n\r\n<head>\r\n\r\n      <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n      <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\"");

WriteLiteral(">\r\n      <title>SEMYOU | We\'ll take you safely into the cloud with SEMYOU Service" +
"s</title>\r\n      <!-- Google font -->\r\n      <link");

WriteLiteral(" href=\"https://fonts.googleapis.com/css?family=Lato:100,100i,300,300i,400,400i,70" +
"0,700i,900,900i\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n\r\n    <script async");

WriteLiteral(" src=\"https://www.googletagmanager.com/gtag/js?id=UA-16798457-5\"");

WriteLiteral("></script>\r\n    <script>\r\n    window.dataLayer = window.dataLayer || [];\r\n    fun" +
"ction gtag(){dataLayer.push(arguments);}\r\n    gtag(\'js\', new Date());\r\n\r\n    gta" +
"g(\'config\', \'UA-16798457-5\');\r\n    </script>\r\n\r\n");

WriteLiteral("    ");

            
            #line 27 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
Write(Html.Section("head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n   \r\n    ");

WriteLiteral("\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/bootstrap.min.css\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/font-awesome.min.css\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/jqvmap.min.css\"");

WriteLiteral(" media=\"screen\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/owl.carousel.min.css\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/owl.theme.default.min.css\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" media=\"all\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/mega-menu.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/style.css\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/responsive.css\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/ResourcePackages/Semyou/assets/dist/css/color.css\"");

WriteLiteral(">\r\n   \r\n\r\n   \r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2746), Tuple.Create("\"", 2809)
, Tuple.Create(Tuple.Create("", 2753), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Semyou/assets/dist/images/favicon.ico")
, 2753), false)
);

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n\r\n");

WriteLiteral("    ");

            
            #line 53 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
Write(Html.Script(Url.Content("https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");

WriteLiteral("\r\n\r\n\r\n</head>\r\n\r\n<body>\r\n");

WriteLiteral("    ");

            
            #line 61 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
Write(Html.Section("top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n   \r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 66 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
       Write(Html.SfPlaceHolder("cphCookie"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" id=\"app\"");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n                <!-- Top Nav -->\r\n                <nav");

WriteLiteral(" class=\"navbar navbar-expand-lg navbar-light top-menu p-0\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 70 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
               Write(Html.SfPlaceHolder("cphLogo"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                \r\n                    <button");

WriteLiteral(" class=\"navbar-toggler\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#navbarNavDropdown\"");

WriteLiteral(" aria-controls=\"navbarNavDropdown\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" aria-label=\"Toggle navigation\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"navbar-toggler-icon\"");

WriteLiteral("></span>\r\n                    </button>\r\n");

WriteLiteral("                    ");

            
            #line 75 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
               Write(Html.SfPlaceHolder("cphnavbarNavDropdown"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                   \r\n                </nav>\r\n                <!-- /Top Nav -->\r" +
"\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"wsmenucontainer clearfix\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"wsmobileheader clearfix\"");

WriteLiteral(">\r\n         <a");

WriteLiteral(" id=\"wsnavtoggle\"");

WriteLiteral(" class=\"animated-arrow\"");

WriteLiteral("><span></span></a>\r\n");

WriteLiteral("        ");

            
            #line 86 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.SfPlaceHolder("cphsmallogo"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"headerfull\"");

WriteLiteral(">\r\n            <!--Main Menu HTML Code-->\r\n            <div");

WriteLiteral(" class=\"wsmain wsmain2\"");

WriteLiteral(">\r\n                <nav");

WriteLiteral(" class=\"wsmenu clearfix\"");

WriteLiteral(">\r\n                    <!-- <div class=\"smllogo\"><a href=\"#\"><img src=\"images/log" +
"o.png\" alt=\"\"/></a></div> -->\r\n\r\n");

WriteLiteral("                    ");

            
            #line 94 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
               Write(Html.SfPlaceHolder("cphmobilesubwsmenulist"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"my-2 my-lg-0 pull-right mr-m-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 96 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                   Write(Html.SfPlaceHolder("cphbuttonSYApps"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                       \r\n                    </div>\r\n               </nav>\r\n\r\n " +
"          </div>\r\n            <!--Menu HTML Code-->\r\n        </div>\r\n    </div>\r" +
"\n\r\n");

WriteLiteral("    ");

            
            #line 106 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
Write(Html.SfPlaceHolder("cphContent"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <section");

WriteLiteral(" class=\"pt-5 pb-5 cus_wrap1\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 111 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
               Write(Html.SfPlaceHolder("cphleft"));

            
            #line default
            #line hidden
WriteLiteral("   </div>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                    ");

            
            #line 114 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
               Write(Html.SfPlaceHolder("cphRight"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n        </div" +
">\r\n    </section>\r\n    <footer");

WriteLiteral(" class=\"footer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n          \r\n");

WriteLiteral("                ");

            
            #line 123 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
           Write(Html.SfPlaceHolder("cphfootermenu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n           \r\n           \r\n            <div");

WriteLiteral(" class=\"row mt-5\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12 copyright text-sm-center text-md-right\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 128 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
               Write(Html.SfPlaceHolder("cphcopyright"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                   \r\n                </div>\r\n            </div>\r\n        </div>" +
"\r\n    </footer>\r\n\r\n \r\n\r\n    <!--  JavaScript -->\r\n\r\n    ");

WriteLiteral("\r\n\r\n\r\n   \r\n    <script");

WriteLiteral(" src=\"https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/bootstrap.min.js\"");

WriteLiteral("></script>\r\n   \r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/jquery.vmap.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/jquery.vmap.world.js\"");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral("></script>\r\n   <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/jquery.vmap.sampledata.js\"");

WriteLiteral("></script>\r\n   <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/mega-menu.js\"");

WriteLiteral("></script>\r\n   <script");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/owl.carousel.min.js\"");

WriteLiteral("></script>\r\n   <script");

WriteLiteral(" src=\"/ResourcePackages/Semyou/assets/dist/js/custom.js\"");

WriteLiteral("></script>\r\n\r\n   \r\n     ");

WriteLiteral("\r\n");

            
            #line 170 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
    
            
            #line default
            #line hidden
            
            #line 170 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
     if (Html.ShouldRenderInlineEditing())
    {
        
            
            #line default
            #line hidden
            
            #line 172 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.Script(ScriptRef.MicrosoftAjax, "top"));

            
            #line default
            #line hidden
            
            #line 172 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                                    
        
            
            #line default
            #line hidden
            
            #line 173 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.Script(ScriptRef.MicrosoftAjaxCore, "top"));

            
            #line default
            #line hidden
            
            #line 173 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                                        
        
            
            #line default
            #line hidden
            
            #line 174 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
            
            #line 174 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                             

        
            
            #line default
            #line hidden
            
            #line 176 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.Script(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.jquery.ba-outside-events.min.js"), "top"));

            
            #line default
            #line hidden
            
            #line 176 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                                                                                                                                                   
        
            
            #line default
            #line hidden
            
            #line 177 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.Script(ScriptRef.KendoAll, "top"));

            
            #line default
            #line hidden
            
            #line 177 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                               
        
            
            #line default
            #line hidden
            
            #line 178 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.Script(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.RequireJS.require.min.js"), "top"));

            
            #line default
            #line hidden
            
            #line 178 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                                                                                                                                            
        
            
            #line default
            #line hidden
            
            #line 179 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
   Write(Html.InlineEditingManager(false));

            
            #line default
            #line hidden
            
            #line 179 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
                                         
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("   ");

            
            #line 182 "..\..MVC\Views\Layouts\GeneralPageMaster.cshtml"
Write(Html.Section("bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
