<%@ Control Language="C#" EnableViewState="true" %>
<h1>
    <asp:Literal runat="server" ID="ltrlPageTitle"></asp:Literal></h1>

<script runat="server">
    private string text = string.Empty;
    private bool showParentTitle = false;

    public string Text
    {
        get {return text;}
        set { text = value; }
    }

    public bool ShowParentTitle
    {
        get { return showParentTitle; }
        set { showParentTitle = value; }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Page.Items["IsInIndexMode"] == null)
        {
            try
            {
                var node = Telerik.Sitefinity.Web.SiteMapBase.GetCurrentProvider().CurrentNode;
                if (string.IsNullOrEmpty(text) && node != null)
                {
                    if (!showParentTitle)
                    {
                        ltrlPageTitle.Text = node.Title;
                    }
                    else if (node.ParentNode != null)
                    {
                        ltrlPageTitle.Text = node.ParentNode.Title;    
                    }
                    return;
                }
                
                ltrlPageTitle.Text = Text;
            }
            catch (Exception ex)
            {
                
            }
        }
    }
</script>
