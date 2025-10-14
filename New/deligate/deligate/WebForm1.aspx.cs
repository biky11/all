using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deligate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dele cls = new dele(12,13);
            string s = Convert.ToString(cls.calc("sub"));
            Response.Write(s);

        }

        class dele
        {
            float a, b;
            public dele(float a, float b)
            {
                this.a = a;
                this.b = b;
            }
            public delegate float opera();

            public float add()
            {
                return a + b;
            }

            public float sub()
            {
                return a - b;
            }

            public float calc(string s)
            {
                opera op;
                if (s == "add")
                {
                    op = add;
                }else if (s == "sub")
               
                {
                    op = sub;
                }
                else
                {
                    return 0;
                }
                    return op();
            }
        }
    }
}