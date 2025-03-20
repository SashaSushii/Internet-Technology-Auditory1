using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
	public partial class One : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				ListBox1.Items.Add("Скопје");
                ListBox1.Items.Add("Стар Дојран");
                ListBox1.Items.Add("Гевгелија");
                ListBox1.Items.Add("Струмица");

            }
        }

		protected void Btn_Clicked(object sender, EventArgs e)
		{
			string SelectedItem = ListBox1.SelectedItem.Text;
			if(!string.IsNullOrEmpty(SelectedItem))
			{
				Label1.Text = "Го избравте градот: " + SelectedItem;
			}
		}
	}
}