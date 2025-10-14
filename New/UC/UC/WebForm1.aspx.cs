using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string un= TextBox1.Text.Trim();

            if (!string.IsNullOrEmpty(un))
            {
                Welcome1.wclmsg = un;
                Welcome1.Visible = true;
            }
        }
    }
}