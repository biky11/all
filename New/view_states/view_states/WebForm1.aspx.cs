using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view_states
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int cnt = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["count"] == null) { ViewState["count"] = 0;}
                Label1.Text=ViewState["count"].ToString();

                if (Application["countl"]==null) { Application["countl"]=0;}
                Label2.Text=Application["countl"].ToString();

                if (Session["username"]==null) { Session["username"]="user"+DateTime.Now.ToString();}
                Label3.Text=Session["username"].ToString();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cnt=Convert.ToInt32( ViewState["count"]);
            cnt++;
            ViewState["count"] = cnt;
            Label1.Text= cnt.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int ctn=Convert.ToInt32(Application["countl"]);
            ctn++;
            Application["countl"] = ctn;
            Label2.Text= Application["countl"].ToString() ;
            
                

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["username"] = "user" + DateTime.Now.ToString();
            Label3.Text = Session["username"].ToString();   
        }
    }
}