<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BirthdayCardWebApp._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Создајте роденденска честитка</h3>
    
    <!-- Background Color -->
    <label>Изберете боја за позадина:</label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Width="74px">
        <asp:ListItem Value="White">Бела</asp:ListItem>
        <asp:ListItem Value="LightBlue">Светло сина</asp:ListItem>
        <asp:ListItem Value="LightGreen">Светло зелена</asp:ListItem>
    </asp:DropDownList>
    <br /><br />

    <!-- Font Selection -->
    <label>Изберете фонт:</label>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem Value="Arial">Arial</asp:ListItem>
        <asp:ListItem Value="Times New Roman">Times New Roman</asp:ListItem>
        <asp:ListItem Value="Verdana">Verdana</asp:ListItem>
    </asp:DropDownList>
    <br /><br />

    <!-- Font Color -->
    <label>Изберете боја на фонтот:</label>
    <br />
    <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem Value="Black">Црна</asp:ListItem>
        <asp:ListItem Value="Red">Црвена</asp:ListItem>
        <asp:ListItem Value="Blue">Сина</asp:ListItem>
    </asp:DropDownList>
    <br /><br />

    <!-- Font Size -->
    <label>Внесете големина на фонтот:</label>
    <br />
    <asp:TextBox ID="TextBoxFontSize" runat="server"></asp:TextBox>
    <br /><br />

    <!-- Border Type -->
    <label>Тип на рамка:</label>
    <br />
    <asp:DropDownList ID="DropDownListBorder" runat="server">
        <asp:ListItem Value="None">Нема рамка</asp:ListItem>
        <asp:ListItem Value="Solid">Цврста</asp:ListItem>
        <asp:ListItem Value="Dashed">Даширана</asp:ListItem>
        <asp:ListItem Value="Dotted">Точкаста</asp:ListItem>
    </asp:DropDownList>
    <br /><br />

    <!-- Image Upload -->
    <label>Додадете слика:</label>
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br /><br />

    <!-- Text Content -->
    <label>Внесете ја содржината на честитката:</label>
    <br />
    <asp:TextBox ID="TextBoxContent" runat="server" TextMode="MultiLine" Rows="4" Columns="50"></asp:TextBox>
    <br /><br />

    <!-- Create Button -->
    <asp:Button ID="Button1" runat="server" Text="Креирај" OnClick="Button1_Click" />
    
    <!-- Display the card preview -->
    <br /><br />
    <div id="CardPreview" runat="server" style="border: 2px solid; padding: 20px; margin-top: 20px;">
        <h4>Преглед на Честитката:</h4>
        <div id="CardContent" runat="server"></div>
    </div>
</asp:Content>