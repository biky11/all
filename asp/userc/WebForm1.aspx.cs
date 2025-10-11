using System;

namespace userc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "1234")
            {
                GreetingControl1.GreetingText = "Welcome, " + txtName.Text + "!";
            }
            else
            {
                GreetingControl1.GreetingText = "Access Denied: Incorrect Password.";
            }
        }
    }
}
