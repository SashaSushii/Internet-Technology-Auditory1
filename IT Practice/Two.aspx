<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Two.aspx.cs" Inherits="IT_Practice.Two" %>

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
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Прикажи град" OnClick="Btn_Clicked2" />
            <br />
            <asp:Label ID="Label2" runat="server"  Text="Изберете град!"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>