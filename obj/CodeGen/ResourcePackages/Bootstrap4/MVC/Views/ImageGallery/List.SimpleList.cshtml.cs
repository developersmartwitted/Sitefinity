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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.ImageGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/ImageGallery/List.SimpleList.cshtml")]
    public partial class List_SimpleList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_SimpleList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 308), Tuple.Create("\"", 345)
, Tuple.Create(Tuple.Create("", 316), Tuple.Create("list-unstyled", 316), true)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create(" ", 329), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 330), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 346), Tuple.Create("\"", 389)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 359), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 359), false)
);

WriteLiteral(">\n\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
     foreach (var item in Model.Items)
    {
        var thumbnailViewModel = (ThumbnailViewModel)item;

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"d-inline-block\"");

WriteLiteral(">\r\n            <figure");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 556), Tuple.Create("\"", 663)
            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 569), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(item.Fields.Description) ? item.Fields.Title : item.Fields.Description
            
            #line default
            #line hidden
, 569), false)
);

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 687), Tuple.Create("\"", 727)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 693), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 693), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 728), Tuple.Create("\'", 826)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 734), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 734), false)
);

WriteLiteral("\r\n                     ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                     ");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n            </figure>\r\n        </li>\r\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\n\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.SimpleList.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591