using System;
using System.Web.UI.WebControls;

namespace TreeDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTree();
            }
        }

        private void LoadTree()
        {
            // Root node
            TreeNode root = new TreeNode("Countries", "Countries");

            // India Node
            TreeNode india = new TreeNode("India", "India");
            india.ChildNodes.Add(new TreeNode("Maharashtra", "Maharashtra"));
            india.ChildNodes.Add(new TreeNode("Gujarat", "Gujarat"));

            // USA Node
            TreeNode usa = new TreeNode("USA", "USA");
            usa.ChildNodes.Add(new TreeNode("California", "California"));
            usa.ChildNodes.Add(new TreeNode("Texas", "Texas"));

            // Add countries to root
            root.ChildNodes.Add(india);
            root.ChildNodes.Add(usa);

            // Add root to TreeView
            TreeView1.Nodes.Add(root);

            // Expand all
            TreeView1.ExpandAll();
        }

       
    }
}
