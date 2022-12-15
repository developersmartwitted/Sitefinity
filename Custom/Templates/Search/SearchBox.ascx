<%@ Control Language="C#" %>


<%@ Register TagPrefix="sitefinity" Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register TagPrefix="ajaxToolkit" Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" %>

<asp:Button ID="searchButton" runat="server"  OnClientClick="return false;" CssClass="searchbtnblog" />  <asp:TextBox ID="searchTextBox" runat="server" CssClass="txtboxSearch" />

<ajaxToolkit:TextBoxWatermarkExtender ID="TBWE2" runat="server"
    TargetControlID="searchTextBox"
    WatermarkText="search"
    WatermarkCssClass="watermarked" />
