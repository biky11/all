using System;
using System.Text;

namespace fibona
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
                int a = 0, b = 1;

                sb.Append("Fibonacci Series: ");

                for (int i = 1; i <= n; i++)
                {
                    sb.Append(a + " ");
                    int temp = a + b;
                    a = b;
                    b = temp;
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
