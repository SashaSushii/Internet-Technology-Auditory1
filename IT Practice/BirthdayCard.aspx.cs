using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Practice
{
	public partial class BirthdayCard : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Ensure items are added only once
            {
                // Add items to the Font dropdown
                ddlFont.Items.Add(new ListItem("Arial", "Arial"));
                ddlFont.Items.Add(new ListItem("Times New Roman", "Times New Roman"));
                ddlFont.Items.Add(new ListItem("Verdana", "Verdana"));

                // Add items to the Border Style dropdown
                ddlBorderStyle.Items.Add(new ListItem("None", "none"));
                ddlBorderStyle.Items.Add(new ListItem("Solid", "solid"));
                ddlBorderStyle.Items.Add(new ListItem("Dotted", "dotted"));
                ddlBorderStyle.Items.Add(new ListItem("Dashed", "dashed"));
            }
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            // Set the message text
            lblMessage.Text = txtMessage.Text;

            // Set the font family
            lblMessage.Style["font-family"] = ddlFont.SelectedValue;

            // Set the font size
            lblMessage.Style["font-size"] = txtFontSize.Text + "px";

            // Set the font color
            lblMessage.Style["color"] = txtFontColor.Text;

            // Set the background color
            pnlCard.Style["background-color"] = txtBackgroundColor.Text;

            // Set the border style
            pnlCard.Style["border"] = "2px " + ddlBorderStyle.SelectedValue + " black";

            // Handle image upload (optional)
            if (fileUpload.HasFile)
            {
                // Get file name and save the uploaded image
                string fileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                string filePath = "~/Images/" + fileName;
                fileUpload.SaveAs(Server.MapPath(filePath));

                // Set image URL
                imgCard.ImageUrl = filePath;
                imgCard.Visible = true;
            }
            else
            {
                imgCard.Visible = false; // Hide the image if no file is uploaded
            }

            // Show the generated card
            pnlCard.Visible = true;
        }
    }
}