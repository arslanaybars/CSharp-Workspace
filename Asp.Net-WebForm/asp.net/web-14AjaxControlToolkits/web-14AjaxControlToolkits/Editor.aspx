<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="web_14AjaxControlToolkits.Editor" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <cc1:Editor ID="Editor1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
