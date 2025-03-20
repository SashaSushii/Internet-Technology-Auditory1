using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
	public partial class Two : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				ListBox2.Items.Add(new ListItem("Скопје", "0"));
				ListBox2.Items.Add(new ListItem("Стар Дојран", "120"));
				ListBox2.Items.Add(new ListItem("Гевгелија", "160"));
				ListBox2.Items.Add(new ListItem("Струмица", "150"));
			}
		}

		protected void Btn_Clicked2(object sender, EventArgs e)
		{
			if (ListBox2.SelectedItem!=null) {
				string selectedCity = ListBox2.SelectedItem.Text;
				string selectedValue = ListBox2.SelectedItem.Value;

				Label2.Text = "Градот што го избравте: " + selectedCity + " одалеченост од Скопје: " + selectedValue + "km";
			}
			else
			{
				Label2.Text= "Морате да изберете град!";
            }
			
		}
	}
}