using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UC
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string wclmsg
        {
            set
            {
                Label1.Text = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
    }
}