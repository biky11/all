using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tree
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadtree();

        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            
        }

        public void loadtree()
        {
            TreeNode root = new TreeNode("Countries", "Countries");
            TreeNode india = new TreeNode("India", "India");

            india.ChildNodes.Add(new TreeNode("mh", "mh"));

            root.ChildNodes.Add(india);
            TreeView1.Nodes.Add(root);
            TreeView1.ExpandAll();
        }
    }
}