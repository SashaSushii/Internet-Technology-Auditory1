<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Six.aspx.cs" Inherits="IT_Practice.Six" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Conversion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Currency selection (RadioButtonList) -->
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
            </asp:RadioButtonList>
            <br />

            <!-- TextBox to enter the amount to be converted -->
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            
            <!-- TextBox to enter currency name and value -->
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />

            <!-- Button to add new currency -->
            <asp:Button ID="Button1" runat="server" Text="Add Currency" OnClick="Button1_Click" />
            <br />

            <!-- Button to delete selected currency -->
            <asp:Button ID="ButtonDelete" runat="server" Text="Delete Selected Currency" OnClick="ButtonDelete_Click" />
            <br />

            <!-- Label to display number of currencies -->
            <asp:Label ID="Label1" runat="server" Text="Number of currencies: 0"></asp:Label>
            <br />

            <!-- Label to show the result of the currency conversion -->
            <asp:Label ID="LabelConversionResult" runat="server" Text="Converted amount will be displayed here."></asp:Label>
        </div>
    </form>
</body>
</html>