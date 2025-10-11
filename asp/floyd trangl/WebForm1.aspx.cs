using System;
using System.Text;

namespace floyd_trangle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(TextBox1.Text, out n) && n > 0)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        sb.Append("* ");
                    }
                    sb.Append("<br/>");
                }

                Label1.Text = sb.ToString();
            }
            else
            {
                Label1.Text = "Please enter a valid positive integer.";
            }
        }
    }
}
