using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
	public partial class Four : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

        }
        protected void Button_Click1(object sender, EventArgs e)
		{
			string currencyName = TextBox1.Text.Trim();
			string currencyValue=TextBox2.Text.Trim();

			if(!string.IsNullOrEmpty(currencyName) && !string.IsNullOrEmpty(currencyValue))
			{
				decimal value;
				if(decimal.TryParse(currencyValue,out value))
				{
					ListItem listItem = new ListItem(currencyName + " ( " + value + " MKD)", value.ToString());
					RadioButtonList1.Items.Add(listItem);

					TextBox1.Text = string.Empty;
					TextBox2.Text = string.Empty;
				}
                else
                {
                    Label1.Text = "Please enter a valid number for the currency value!";
                }
            }
            else
            {
                Label1.Text = "Both fields must be filled!";
            }
        }

    }
}