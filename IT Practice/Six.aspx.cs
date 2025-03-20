using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
    public partial class Six : System.Web.UI.Page
    {
        private Dictionary<string, decimal> currencyRates = new Dictionary<string, decimal>
        {
            { "USD", 50 },   // 1 USD = 50 MKD
            { "EUR", 60 },   // 1 EUR = 60 MKD
            { "GBP", 70 },   // 1 GBP = 70 MKD
            { "AUD", 40 }    // 1 AUD = 40 MKD
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Add currencies to RadioButtonList dynamically on page load
            if (!IsPostBack)
            {
                foreach (var currency in currencyRates)
                {
                    RadioButtonList1.Items.Add(new ListItem(currency.Key, currency.Key));
                }
            }

            // Update item count every time the page is loaded or refreshed
            UpdateItemCount();
        }

        // Add currency when button is clicked
        protected void Button1_Click(object sender, EventArgs e)
        {
            string currencyName = TextBox2.Text.Trim();
            string currencyValue = TextBox1.Text.Trim();

            if (!string.IsNullOrEmpty(currencyName) && !string.IsNullOrEmpty(currencyValue))
            {
                decimal variable;
                if (decimal.TryParse(currencyValue, out variable))
                {
                    // Add the new currency to the RadioButtonList
                    ListItem newItem = new ListItem(currencyName + " (" + variable + " MKD)", currencyName);
                    RadioButtonList1.Items.Add(newItem);

                    // Clear the TextBoxes after adding the item
                    TextBox2.Text = string.Empty;
                    TextBox1.Text = string.Empty;

                    // Update item count
                    UpdateItemCount();
                }
                else
                {
                    Label1.Text = "Please enter a valid value for the currency!";
                }
            }
            else
            {
                Label1.Text = "Please enter both currency name and value!";
            }
        }

        // Delete selected currency when button is clicked
        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex != -1)
            {
                // Remove the selected item from the list
                RadioButtonList1.Items.Remove(RadioButtonList1.SelectedItem);

                // Update item count
                UpdateItemCount();
            }
            else
            {
                Label1.Text = "Please select a currency to delete!";
            }
        }

        // Update the item count label to reflect the number of currencies
        public void UpdateItemCount()
        {
            Label1.Text = "Number of currencies: " + RadioButtonList1.Items.Count;
        }

        // Event handler to perform currency conversion when currency selection changes
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected currency's value (the currency code, like USD, EUR)
            string selectedCurrency = RadioButtonList1.SelectedValue;

            // Check if the selected currency exists in the dictionary
            if (currencyRates.ContainsKey(selectedCurrency))
            {
                decimal rate = currencyRates[selectedCurrency];

                // Get the amount to convert from TextBox1 (the input amount)
                decimal amountToConvert;
                if (decimal.TryParse(TextBox1.Text.Trim(), out amountToConvert))
                {
                    decimal convertedAmount = amountToConvert * rate;
                    LabelConversionResult.Text = $"Converted amount: {convertedAmount} MKD";
                }
                else
                {
                    LabelConversionResult.Text = "Please enter a valid amount to convert!";
                }
            }
            else
            {
                LabelConversionResult.Text = "Invalid currency selected.";
            }
        }
    }
}