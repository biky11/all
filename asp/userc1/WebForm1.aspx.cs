using System;

namespace userc1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text.Trim();
            string password = TextBoxPassword.Text.Trim();

            if (!string.IsNullOrEmpty(username) && password == "1234")
            {
                Welcome1.WelcomeMessage = "Welcome, " + username + "!";
                Welcome1.Visible = true;
                LabelMessage.Text = "";
            }
            else
            {
                LabelMessage.Text = "Invalid username or password!";
                Welcome1.Visible = false;
            }
        }
    }
}
