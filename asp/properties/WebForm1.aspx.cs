using System;
using System.Web.UI;

namespace ServerControlsDemo
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListCountry.SelectedIndex = 0;
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ShowResult();
        }

        protected void RadioButtonListGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelResult.Text = $"You selected gender: {RadioButtonListGender.SelectedValue}";
        }


        protected void DropDownListCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DropDownListCountry.SelectedValue))
            {
                LabelResult.Text = $"Country selected: {DropDownListCountry.SelectedValue}";
            }
        }

        private void ShowResult()
        {
            string name = TextBoxName.Text;
            string gender = RadioButtonListGender.SelectedValue;
            string country = DropDownListCountry.SelectedValue;
     

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(country))
            {
                LabelResult.Text = "Please complete all fields.";
                return;
            }

            LabelResult.Text = $"Hello, {name}!<br />" +
                               $"Gender: {gender}<br />" +
                               $"Country: {country}<br />";
        }
    }
}
