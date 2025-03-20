<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Five.aspx.cs" Inherits="IT_Practice.Five" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency List</title>
    <style>
        body{
            display:flex;
            justify-content:center;
            align-items:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" />
            <br />

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" runat="server" Text="Add Currency" OnClick="Button1_Click" />
            <br />

            <asp:Button ID="ButtonDelete" runat="server" Text="Delete Selected Currency" OnClick="ButtonDelete_Click" />
            <br />

            <asp:Label ID="Label1" runat="server" Text="Number of currencies: 0"></asp:Label>
        </div>
    </form>
</body>
</html>
