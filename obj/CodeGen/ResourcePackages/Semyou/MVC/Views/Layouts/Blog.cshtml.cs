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
    
    #line 1 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Semyou/MVC/Views/Layouts/Blog.cshtml")]
    public partial class Blog : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Blog()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html ");

            
            #line 8 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
 Write(Html.RenderLangAttribute());

            
            #line default
            #line hidden
WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge,chrome=1,IE=10\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" href=\"/ResourcePackages/Bootstrap/assets/dist/images/favicon-1.ico\"");

WriteLiteral(" type=\"image/icon\"");

WriteLiteral(">\r\n    <title>Semyou Blog</title>\r\n\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.Section("head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.StyleSheet(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/css/StyleSheet.css"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 19 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.StyleSheet(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/css/font-awesome.css"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.StyleSheet(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/css/font-awesome.min.css"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 21 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.StyleSheet(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/css/style.min.css"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    \r\n");

WriteLiteral("    ");

            
            #line 24 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/js/jquery.js"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 25 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/js/jquery-migrate.min.js"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 26 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.Script(Url.Content("https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    window.history.replaceState && window.location.hash === \'#_=_\' && window.h" +
"istory.replaceState( \'\',\'\', window.location.href.substr( 0, window.location.href" +
".indexOf( \'#\' ) ) );\r\n    </script>\r\n</head>\r\n\r\n<body");

WriteLiteral(" class=\"home blog desktop group-blog\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.Section("top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" id=\"page\"");

WriteLiteral(" class=\"hfeed site \"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"site-header-wrap\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
       Write(Html.SfPlaceHolder("cphCookie"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <header");

WriteLiteral(" id=\"masthead\"");

WriteLiteral(" class=\"site-header\"");

WriteLiteral(">\r\n\r\n\r\n                <div");

WriteLiteral(" class=\"header-top-menu\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"site-logo\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"/blog\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2149), Tuple.Create("\"", 2224)
, Tuple.Create(Tuple.Create("", 2155), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap/assets/dist/images/footer_title_icon.png")
, 2155), false)
);

WriteLiteral(">\r\n                            <span>\r\n                                <h4>SEMYOU" +
" Blogs</h4>\r\n                            </span>\r\n                        </a>\r\n" +
"                    </div>\r\n\r\n\r\n\r\n\r\n                    <nav");

WriteLiteral(" id=\"site-utility-navigation\"");

WriteLiteral(" class=\"utility-navigation\"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n                        <div>\r\n\r\n");

WriteLiteral("                            ");

            
            #line 59 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                       Write(Html.SfPlaceHolder("cph_lang_button"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"menu-top-nav-container\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                            ");

            
            #line 65 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                       Write(Html.SfPlaceHolder("cph_utility_navigation"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                    </nav>\r\n\r\n           " +
"     </div>\r\n\r\n                <div");

WriteLiteral(" class=\"mobile-search-icon-wrap\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"header-mobile-dropdown-toggle\"");

WriteLiteral(">search</a>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"header-mobile-dropdown\"");

WriteLiteral(">\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"header-dropdown\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"search-container\"");

WriteLiteral(">\r\n\r\n                        <div");

WriteLiteral(" class=\"header-search\"");

WriteLiteral(" id=\"header-search\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"search-form\"");

WriteLiteral(">\r\n                                <span>Search</span>\r\n");

WriteLiteral("                                ");

            
            #line 87 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                           Write(Html.SfPlaceHolder("cph_header_search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n         " +
"           </div>\r\n\r\n                    <nav");

WriteLiteral(" id=\"site-navigation\"");

WriteLiteral(" class=\"main-navigation\"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"skip-link screen-reader-text\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Skip to content</a>\r\n                        <ul");

WriteLiteral(" class=\"main-navigation-top-level\"");

WriteLiteral(">\r\n\r\n                            <li");

WriteLiteral(" class=\"filter-parent\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                                    <!--<span class=\"ms-icon icon-circle\"></sp" +
"an>-->\r\n");

WriteLiteral("                                    ");

            
            #line 100 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                               Write(Html.SfPlaceHolder("cph_nav_menu1"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                  \r\n                                </a>\r\n");

WriteLiteral("                                ");

            
            #line 103 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                           Write(Html.SfPlaceHolder("cph_navigation"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n\r\n\r\n         " +
"           </nav>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </header>\r\n      " +
"  </div>\r\n    </div>\r\n\r\n\r\n\r\n    \r\n\r\n\r\n");

WriteLiteral("    ");

            
            #line 123 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
Write(Html.SfPlaceHolder("cph_home_featured_row_post"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"site-content\"");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"content-area\"");

WriteLiteral(" id=\"primary\"");

WriteLiteral(">\r\n            <main");

WriteLiteral(" class=\"site-main masonry-container\"");

WriteLiteral(" id=\"main\"");

WriteLiteral("  >\r\n");

WriteLiteral("                ");

            
            #line 127 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.SfPlaceHolder("CphMain"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </main>\r\n         </div>\r\n");

WriteLiteral("        ");

            
            #line 130 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
   Write(Html.SfPlaceHolder("CphBlogDetail"));

            
            #line default
            #line hidden
WriteLiteral("\r\n      </div>\r\n\r\n\r\n                <footer");

WriteLiteral(" id=\"colophon\"");

WriteLiteral(" class=\"site-footer\"");

WriteLiteral(" role=\"contentinfo\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"footer-widgets\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"footer-widget-col\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                            <aside");

WriteLiteral(" id=\"nav_menu-2\"");

WriteLiteral(" class=\"widget widget_nav_menu footer-left-sidebar\"");

WriteLiteral(">\r\n                                <h4");

WriteLiteral(" class=\"widget-title footer-mobile-dropdown-toggle\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">other  blogs</a>\r\n                                </h4>\r\n                       " +
"         <div");

WriteLiteral(" class=\"menu-other-microsoft-blogs-container\"");

WriteLiteral(">\r\n                                    <ul");

WriteLiteral(" id=\"menu-other-microsoft-blogs\"");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" id=\"menu-item-18\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-18\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">BlogSemyou  Blog</a>\r\n                                        </li>\r\n\r\n         " +
"                               <li");

WriteLiteral(" id=\"menu-item-19\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-19\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                                                BlogSemyou On The Issues\r\n    " +
"                                        </a>\r\n                                  " +
"      </li>\r\n                                        <li");

WriteLiteral(" id=\"menu-item-20\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-20\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(@">The BlogSemyou Blog</a>
                                        </li>
                                    </ul>
                                </div>
                            </aside>
                        </div>

                        <div");

WriteLiteral(" class=\"footer-widget-col\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                            <aside");

WriteLiteral(" id=\"nav_menu-3\"");

WriteLiteral(" class=\"widget widget_nav_menu footer-middle-sidebar\"");

WriteLiteral(">\r\n                                <h4");

WriteLiteral(" class=\"widget-title footer-mobile-dropdown-toggle\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">other  blogs</a>\r\n                                </h4>\r\n                       " +
"         <div");

WriteLiteral(" class=\"menu-other-product-blogs-container\"");

WriteLiteral(">\r\n                                    <ul");

WriteLiteral(" id=\"menu-other-product-blogs\"");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" id=\"menu-item-3751\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-3751\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Exchange Blog</a>\r\n                                        </li>\r\n              " +
"                      </ul>\r\n                                </div>\r\n           " +
"                 </aside>\r\n                        </div>\r\n\r\n\r\n                 " +
"       <div");

WriteLiteral(" class=\"footer-widget-col\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                            <aside");

WriteLiteral(" id=\"nav_menu-4\"");

WriteLiteral(" class=\"widget widget_nav_menu footer-right-sidebar\"");

WriteLiteral(">\r\n                                <h4");

WriteLiteral(" class=\"widget-title footer-mobile-dropdown-toggle\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">other  blogs</a>\r\n                                </h4>\r\n                       " +
"         <div");

WriteLiteral(" class=\"menu-other-office-blogs-container\"");

WriteLiteral(">\r\n                                    <ul");

WriteLiteral(" id=\"menu-other-office-blogs\"");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" id=\"menu-item-24\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-24\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(@">Office Updates</a>
                                        </li>
                                    </ul>
                                </div>
                            </aside>
                        </div>
                    </div>

                    <div");

WriteLiteral(" class=\"footer-logo\"");

WriteLiteral(">\r\n\r\n                        <div");

WriteLiteral(" class=\"copyright-logo\"");

WriteLiteral(" role=\"img\"");

WriteLiteral(" aria-label=\"BlogSemyou logo\"");

WriteLiteral(">\r\n\r\n                        </div>\r\n                        <p>?? 2017 </p>\r\n\r\n  " +
"                  </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"menu-footer-menu-container\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" id=\"menu-footer-menu\"");

WriteLiteral(" class=\"footer-menu\"");

WriteLiteral(">\r\n\r\n                            <li");

WriteLiteral(" id=\"menu-item-30\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-30\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"/about/terms-of-service\"");

WriteLiteral(">Legal</a>\r\n                            </li>\r\n                            <li");

WriteLiteral(" id=\"menu-item-31\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-31\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"/about/masthead\"");

WriteLiteral(">Trademarks</a>\r\n                            </li>\r\n                            <" +
"li");

WriteLiteral(" id=\"menu-item-32\"");

WriteLiteral(" class=\"menu-item menu-item-type-custom menu-item-object-custom menu-item-32\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"/about/terms-of-service\"");

WriteLiteral(">Privacy Statement</a>\r\n                            </li>\r\n                      " +
"  </ul>\r\n                    </div>\r\n\r\n                </footer>\r\n\r\n\r\n          " +
"      <div");

WriteLiteral(" class=\"sfPublicWrapper\"");

WriteLiteral(" id=\"PublicWrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 221 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
               Write(Html.SfPlaceHolder("Contentplaceholder1"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n                ");

WriteLiteral("\r\n");

            
            #line 229 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                
            
            #line default
            #line hidden
            
            #line 229 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                 if (Html.ShouldRenderInlineEditing())
                {
                
            
            #line default
            #line hidden
            
            #line 231 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(ScriptRef.MicrosoftAjax, "top"));

            
            #line default
            #line hidden
            
            #line 231 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                            
                
            
            #line default
            #line hidden
            
            #line 232 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(ScriptRef.MicrosoftAjaxCore, "top"));

            
            #line default
            #line hidden
            
            #line 232 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                                
                
            
            #line default
            #line hidden
            
            #line 233 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
            
            #line 233 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                     

                
            
            #line default
            #line hidden
            
            #line 235 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.jquery.ba-outside-events.min.js"), "top"));

            
            #line default
            #line hidden
            
            #line 235 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                                                                                                                                           
                
            
            #line default
            #line hidden
            
            #line 236 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(ScriptRef.KendoAll, "top"));

            
            #line default
            #line hidden
            
            #line 236 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                       
                
            
            #line default
            #line hidden
            
            #line 237 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.RequireJS.require.min.js"), "top"));

            
            #line default
            #line hidden
            
            #line 237 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                                                                                                                                    
                
            
            #line default
            #line hidden
            
            #line 238 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.InlineEditingManager(false));

            
            #line default
            #line hidden
            
            #line 238 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
                                                 
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                    jQuery(document).ready(function ($) {\r\n                   " +
"     var openModal = function (standard) {\r\n                            tb_show(" +
"\'\', \'#TB_inline?width=900&amp;inlineId=login-modal\', \'\');\r\n\r\n                   " +
"         if (true === standard) {\r\n                                $(\'#TB_window" +
"\').addClass(\'standard-login login-popup\');\r\n                                $(\'." +
"office-login-errors\').addClass(\'visually-hidden\');\r\n                            " +
"    $(\'.office-login-welcome\').removeClass(\'visually-hidden\');\r\n                " +
"            } else {\r\n                                $(\'#TB_window\').addClass(\'" +
"login-popup-has-errors login-popup\');\r\n                                $(\'.offic" +
"e-login-errors\').removeClass(\'visually-hidden\');\r\n                              " +
"  $(\'.office-login-welcome\').addClass(\'visually-hidden\');\r\n                     " +
"           $(\'.login-popup\').height($(\'#wp-social-login-connect-options\').height" +
"());\r\n                            }\r\n\r\n                            $(\'.login-pop" +
"up\').css({\r\n                                \'width\': \'100%\',\r\n                  " +
"              \'left\': 0,\r\n                                \'margin-left\': 0\r\n    " +
"                        }).css(\'margin-top\', \'\');\r\n                            $" +
"(\'#TB_ajaxContent\').css({\r\n                                \'margin\': \'0 auto\',\r\n" +
"                                \'max-width\': \'100%\'\r\n                           " +
" });\r\n                        };\r\n\r\n                        $(\'body\').on(\'click\'" +
", \'[href=\"\"], [href=\"\"]\',\r\n                            function (evt) {\r\n       " +
"                         evt.preventDefault();\r\n                                " +
"openModal(true);\r\n                            });\r\n                    });\r\n\r\n  " +
"                  $(\".filter-parent\").click(function (e) {\r\n                    " +
"    var a = $(\".filter-parent >a >div >div > span\");\r\n                        if" +
" (a.hasClass(\"fa fa-plus\")) {\r\n                            a.removeClass(\"fa fa-" +
"plus\");\r\n                            a.addClass(\"fa fa-minus\");\r\n               " +
"         }\r\n                        else {\r\n                            a.remove" +
"Class(\"fa fa-minus\");\r\n                            a.addClass(\"fa fa-plus\");\r\n  " +
"                      }\r\n\r\n                    });\r\n\r\n                </script>\r" +
"\n\r\n\r\n                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

                    $('#nav').on('click', '#nav > li > a', function (event) {
                        event.stopPropagation();
                        event.preventDefault();
                        var openMenu = $('#nav .active').next('ul');
                        if (event.handled !== true) {
                            openMenu.velocity(""slideUp"", 200, function () { });
                            if ($(this).hasClass('active')) {
                                $(this).removeClass('active');
                            } else {
                                $(this).next('ul').velocity(""slideDown"", 500, function () { });
                                $('#nav li a').removeClass('active');
                                $(this).addClass('active');
                            }
                            event.handled = true;
                        } else {
                            return false;
                        }
                    });
                </script>


");

WriteLiteral("                ");

            
            #line 314 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/js/project.min.js"), "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 315 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap/assets/dist/js/masonry.min.js"), "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

WriteLiteral("                ");

            
            #line 318 "..\..\ResourcePackages\Semyou\MVC\Views\Layouts\Blog.cshtml"
           Write(Html.Section("bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
