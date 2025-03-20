using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
    public partial class Five : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Update the item count when the page is loaded
            if (!IsPostBack)
            {
                UpdateItemCount();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string currencyName = TextBox1.Text.Trim();
            string currencyValue = TextBox2.Text.Trim();

            if (!string.IsNullOrEmpty(currencyName) && !string.IsNullOrEmpty(currencyValue))
            {
                decimal variable;
                if (decimal.TryParse(currencyValue, out variable))
                {
                    // Create a new ListItem with the currency name and value
                    ListItem item = new ListItem(currencyName + " ( " + variable + " MKD )", variable.ToString());
                    RadioButtonList1.Items.Add(item);

                    // Clear the TextBoxes after adding the item
                    TextBox1.Text = string.Empty;
                    TextBox2.Text = string.Empty;

                    // Update the item count
                    UpdateItemCount();
                }
                else
                {
                    Label1.Text = "Please enter a valid number for the currency value!";
                }
            }
            else
            {
                Label1.Text = "Please enter both currency name and value!";
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex != -1)
            {
                // Remove the selected item from the RadioButtonList
                RadioButtonList1.Items.Remove(RadioButtonList1.SelectedItem);

                // Update the item count after deletion
                UpdateItemCount();
            }
            else
            {
                Label1.Text = "Please select a currency to delete!";
            }
        }

        public void UpdateItemCount()
        {
            // Display the number of items in the RadioButtonList
            Label1.Text = "Number of currencies: " + RadioButtonList1.Items.Count;
        }
    }
}
