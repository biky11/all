using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_con
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label3.Text = RadioButtonList1.SelectedValue.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RadioButtonList1.SelectedValue.ToString()))
            {
                Label2.Text = RadioButtonList1.SelectedValue.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showr();
        }

        public void showr()
        {
            string name=TextBox1.Text;
            string gen=RadioButtonList1.SelectedValue.ToString();
            String cont=DropDownList1.SelectedValue.ToString() ;

            Label1.Text = $"hello,{name}<br>" +
                $"gender, {gen} <br>"+$"country,{cont}";
            ;
        
        
        
        }
    }
}