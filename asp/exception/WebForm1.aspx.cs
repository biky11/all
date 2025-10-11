using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace execption
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int x;
        public class AgeValid : Exception
        {
            public AgeValid(string msg) : base(msg){}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(TextBox2.Text);
                if (x == 0 || x < 18)
                {
                    throw new AgeValid("age not valid");
                }
                else
                {
                    throw new AgeValid("age is valid");
                }

            }
            catch (AgeValid ex)
            {
                Label3.Text = ex.Message;
            }

        }
    }
}