using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interf
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            area at = new area();
            float a=at.cil(12);
            Response.Write(Convert.ToString(a));

        }

        public interface ara
        {
            float cil(float x);
            float tri(float x);
        };

        public class area : ara
        {
            public float cil(float x) { return 2 * x; }
            public float tri(float x) { return x * x * x; }
        }

    }
}