<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Three.aspx.cs" Inherits="IT_Practice.Three" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Destinations</title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        #form1 {
            text-align: center;
        }

        #Label3 {
            font-weight: bold;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox3" runat="server" SelectionMode="Multiple" style="width: 250px; height: 100px;">
            </asp:ListBox>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Прикажи градови" OnClick="Btn_Clicked3" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Изберете град!"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
