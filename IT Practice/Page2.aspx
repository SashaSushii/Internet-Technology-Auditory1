<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="IT_Practice.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Page 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Page 2</h1>
            <h1>This is content for Page 2</h1>
      
                <asp:Button ID="Button1" runat="server" Text="Previous" OnClick="btnPrevious_Click" />
            
            
                <asp:Button ID="Button2" runat="server" Text="Next" OnClick="btnNext_Click" />
            

        </div>
    </form>
</body>
</html>
