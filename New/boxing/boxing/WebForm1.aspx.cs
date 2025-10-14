using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace boxing
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(TextBox1.Text);
         
            Object ob = a;

         
            int b = (int)ob;
            
           
            Label1.Text = Convert.ToString(b);
        }
    }
}