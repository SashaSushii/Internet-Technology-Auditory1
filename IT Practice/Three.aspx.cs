using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
	public partial class Three : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListBox3.Items.Add(new ListItem("Скопје", "0"));
                ListBox3.Items.Add(new ListItem("Стар Дојран", "120"));
                ListBox3.Items.Add(new ListItem("Гевгелија", "160"));
                ListBox3.Items.Add(new ListItem("Струмица", "150"));
            }
        }

        protected void Btn_Clicked3(object sender, EventArgs e)
        {
            ListItemCollection items = ListBox3.Items;
            string SelectedCities = "";

            foreach(ListItem item in items)
            {
                if (item.Selected)
                {
                    SelectedCities+=item.Text+" Oдалеченост: "+item.Value +"km <br />";
                }
            }
            if (!string.IsNullOrEmpty(SelectedCities))
            {
                Label3.Text = "Селектирани градови: <br />"+SelectedCities;
            }
            else
            {
                Label3.Text = "Морате да изберете барем еден град!";
            }
        }
    }
}