using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result = 0;
            string operation = DropDownList1.SelectedValue;

            if (double.TryParse(TextBox1.Text, out num1) && double.TryParse(TextBox2.Text, out num2))
            {
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "x":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            ResultLabel.Text = "Cannot divide by zero.";
                            return;
                        }
                        break;
                    default:
                        ResultLabel.Text = "Invalid operation.";
                        return;
                }

                ResultLabel.Text = result.ToString();
            }
            else
            {
                ResultLabel.Text = "Please enter valid numbers.";
            }
        }
    }
}
