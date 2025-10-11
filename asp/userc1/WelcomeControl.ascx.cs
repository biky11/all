using System;
using System.Web.UI;

namespace userc1
{
    public partial class WelcomeControl : UserControl
    {
        public string WelcomeMessage
        {
            set { LabelWelcome.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
