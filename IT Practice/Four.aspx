<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Four.aspx.cs" Inherits="IT_Practice.Four" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
                        <br />
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Currency Name"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Currency Value in MKD"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Currency" OnClick="Button_Click1" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Selected Currency:"></asp:Label>
        </div>
    </form>
</body>
</html>
