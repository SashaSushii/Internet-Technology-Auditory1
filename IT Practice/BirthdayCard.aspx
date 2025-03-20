<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BirthdayCard.aspx.cs" Inherits="IT_Practice.BirthdayCard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Birthday Card</title>
    <style>
        .card-container {
            width: 400px;
            height: 300px;
            padding: 20px;
            position: relative;
            border: 2px solid black;
            display: none;
        }
        .card-text {
            text-align: center;
            padding: 20px;
            font-size: 16px;
            font-family: Arial;
        }
        .card-image {
            width: 100%;
            height: 100%;
            object-fit: cover;
            opacity: 0.3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Create Your Birthday Greeting Card</h2>
            <div>
                <label for="txtMessage">Enter Message:</label>
                <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="4" Columns="40"></asp:TextBox>
            </div>
            <br />

            <label for="ddlFont">Font:</label>
            <asp:DropDownList ID="ddlFont" runat="server">
            </asp:DropDownList>
            <br />

            <label for="txtFontSize">Font Size:</label>
            <asp:TextBox ID="txtFontSize" runat="server" Text="16"></asp:TextBox>
            <br />

            <label for="txtFontColor">Font Color:</label>
            <asp:TextBox ID="txtFontColor" runat="server" Text="#000000"></asp:TextBox>
            <br />

            <label for="txtBackgroundColor">Background Color:</label>
            <asp:TextBox ID="txtBackgroundColor" runat="server" Text="#ffffff"></asp:TextBox>
            <br />

            <label for="ddlBorderStyle">Border Style:</label>
            <asp:DropDownList ID="ddlBorderStyle" runat="server">
            </asp:DropDownList>
            <br />

            <label for="fileUpload">Upload Image:</label>
            <asp:FileUpload ID="fileUpload" runat="server" />
            <br />

            <asp:Button ID="btnGenerate" runat="server" Text="Generate Card" OnClick="btnGenerate_Click" />
        </div>

        <div id="pnlCard" runat="server" class="card-container">
            <asp:Label ID="lblMessage" runat="server" CssClass="card-text"></asp:Label>
            <asp:Image ID="imgCard" runat="server" CssClass="card-image" Visible="false" />
        </div>
    </form>
</body>
</html>