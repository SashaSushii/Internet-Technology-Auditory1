<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="One.aspx.cs" Inherits="IT_Practice.One" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Прикажи град" OnClick="Btn_Clicked" />
            <br />
            <asp:Label ID="Label1" runat="server"  Text="Изберете град!"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
