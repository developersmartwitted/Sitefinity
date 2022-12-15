<%--<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TagCloud.ascx.cs" Inherits="SitefinityWebApp.UserControlls.TagCloud" %>
--%>
<%@ Control Language="C#" %>
<asp:Label ID="titleLabel" runat="server"></asp:Label>
<h3>
    <asp:Literal ID="controlTitle" runat="server"></asp:Literal>
</h3>
<p>
    <asp:Literal ID="lblDisplayAs" runat="server" Text="DisplayAs"></asp:Literal> :
    <asp:LinkButton ID="displayCloudLink" runat="server" Text="Cloud"></asp:LinkButton> |
    <asp:LinkButton ID="displayListLink" runat="server" Text="List"></asp:LinkButton>
</p>
 
<asp:Repeater ID="repeater_cloud" runat="server">
    <HeaderTemplate><ul class="tagCloud"></HeaderTemplate>
    <ItemTemplate>
        <li><asp:HyperLink ID="tagLink" runat="server" CssClass="tagCloudItem"></asp:HyperLink></li>
    </ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>
</asp:Repeater>
 
<asp:Repeater ID="tagsRepeaterList" runat="server">
    <HeaderTemplate><ul></HeaderTemplate>
    <ItemTemplate>
        <li>
            <asp:HyperLink ID="tagLink" runat="server"></asp:HyperLink>
            (<asp:Label ID="taggedContentCount" runat="server"></asp:Label>)
        </li>
    </ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>
</asp:Repeater>
