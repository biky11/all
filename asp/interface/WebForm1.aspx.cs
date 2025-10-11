using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaces
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ara clc = new ara();
            string a = Convert.ToString(clc.cirl(4));
            string b = Convert.ToString(clc.tri(5));

            Response.Write(" circle area : " + a + " \n tringle area " + b);

        }
    }

    public interface area
    { 
       double cirl(double a);
       double tri(double a);


    }
    public class ara : area
    {
        public double cirl(double a)
        {

            return (a * a) * 2 * 3.14;
        }

        public double tri(double a) {
            return a * a;
            
        }
    }
}