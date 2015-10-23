<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="web_02StateManagment.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="ddlMarkalar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMarkalar_SelectedIndexChanged" Width="193px">
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem>Samsung</asp:ListItem>
            <asp:ListItem>Nokia</asp:ListItem>
            <asp:ListItem>LG</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" Width="84px" />
    </form>
</body>
</html>
