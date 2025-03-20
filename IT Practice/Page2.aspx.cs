using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
	public partial class Page2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public void btnPrevious_Click(object sender, EventArgs e)
		{
			Response.Redirect("Page1.aspx");
		}

		public void btnNext_Click( object sender, EventArgs e)
		{
			Response.Redirect("Page3.aspx");
		}
		
    }
}