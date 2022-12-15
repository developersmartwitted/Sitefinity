<%@ Control Language="C#" %>


<%@ Register TagPrefix="sitefinity" Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register TagPrefix="ajaxToolkit" Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" %>

<div class="search">
<asp:Button ID="searchButton" runat="server"  OnClientClick="return false;" CssClass="searchbtnblog" /> 
 <asp:TextBox ID="searchTextBox" runat="server" CssClass="txtboxSearch" />
</div>
