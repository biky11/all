using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calen
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.Date.Month==10 && e.Day.Date.Day == 17)
            {
                Label divali = new Label();
                divali.Text = "<br> divali";
                e.Cell.Controls.Add(divali);
                e.Cell.BackColor=System.Drawing.Color.AntiqueWhite;
            }
        }
        

    }
}