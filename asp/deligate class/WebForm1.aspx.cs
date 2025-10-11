using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deligate_class
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myclss clc = new myclss(12,13);
            string s = Convert.ToString(clc.calc("add"));
           
            string s1 = Convert.ToString(clc.calc("sub"));
            string s2 = Convert.ToString(clc.calc("mul"));
            string s3 = Convert.ToString(clc.calc("div"));
            Response.Write(" add : "+s+" Sub : " + s1 + " mul : " + s2+ " div : "+ s3);


        }
    }

    class myclss
    {
        public float a, b;

        public myclss(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public delegate float operation();
        public float add()
        {
            return a + b;
        }
        public float sub()
        {
            return a - b;
        }
        public float mul()
        {
            return a * b;
        }

        public float div()
        {
            return a / b;
        }

        public float calc(string a)
        {
            operation op;
            if (a == "add")
            {
                op = add;
            }
            else if(a == "sub")
            {
                op = sub;
             
            }else if(a == "mul")
            {
                op = mul;
            }else if (a == "div")
            {
                op = div;
            }else
            {
                return 0;
            }
            return op();

        }
        
    }
}