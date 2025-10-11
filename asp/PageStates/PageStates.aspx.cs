using System;
using System.Web;

namespace aspstates
{
    public partial class PageStates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["count"] == null)
                ViewState["count"] = 0;

            lblViewState.Text = "ViewState Count: " + ViewState["count"].ToString();

            if (Session["username"] != null)
                lblSession.Text = "Session Value: " + Session["username"].ToString();
            else
                lblSession.Text = "Session Value: [not set]";

            if (Application["appCounter"] != null)
                lblAppState.Text = "Application Value: " + Application["appCounter"].ToString();
            else
                lblAppState.Text = "Application Value: [not set]";
        }

        protected void btnViewState_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(ViewState["count"]);
            count++;
            ViewState["count"] = count;
        }

        protected void btnSession_Click(object sender, EventArgs e)
        {
            Session["username"] = "User_" + DateTime.Now.Ticks.ToString().Substring(10);
        }

        protected void btnApp_Click(object sender, EventArgs e)
        {
            Application.Lock();
            if (Application["appCounter"] == null)
                Application["appCounter"] = 1;
            else
                Application["appCounter"] = (int)Application["appCounter"] + 1;
            Application.UnLock();
        }
    }
}
