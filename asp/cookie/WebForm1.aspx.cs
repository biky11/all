using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);

            try
            {
                int ans = x / y;
                HttpCookie mycok = new HttpCookie("division");
                mycok.Value = ans.ToString();
                Response.Cookies.Add(mycok);
                Response.Redirect("WebForm2.aspx");


            }
            catch (DivideByZeroException ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                Label2.Text = "I am in";
            }
        }
    }
}