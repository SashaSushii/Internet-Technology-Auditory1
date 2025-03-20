using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BirthdayCardWebApp
{
    public partial class _Default : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get values from user input
            string backgroundColor = DropDownList1.SelectedValue;
            string fontFamily = DropDownList2.SelectedValue;
            string fontColor = DropDownList3.SelectedValue;
            string fontSize = TextBoxFontSize.Text;
            string borderType = DropDownListBorder.SelectedValue;
            string content = TextBoxContent.Text;
            string imageUrl = "";

            // If user uploaded an image, get the image URL (you can add functionality to save the image)
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath("~/Images/") + fileName);
                imageUrl = "~/Images/" + fileName;
            }

            // Apply the user's selections to the card preview
            CardPreview.Attributes["style"] = $"background-color: {backgroundColor}; border: 2px {borderType}; padding: 20px;";

            // Add the image if provided
            if (!string.IsNullOrEmpty(imageUrl))
            {
                CardContent.InnerHtml = $"<img src='{imageUrl}' alt='Card Image' style='max-width: 100%; height: auto;'/><br /><br />";
            }

            // Add the content with applied styles
            CardContent.InnerHtml += $"<div style='font-family: {fontFamily}; font-size: {fontSize}px; color: {fontColor};'>{content}</div>";
        }
    }
}
