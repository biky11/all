using System;

namespace ValidationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LabelResult.Text = "Registration successful!";
            }
            else
            {
                LabelResult.Text = string.Empty;
            }
        }
    }
}
