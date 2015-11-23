<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="webSaglikProjesi.ucLogin" %>
<link href="style.css" rel="stylesheet" />
<div>
    <table>
        <tr>
            <td colspan="2" style="text-align: center;">
                    <h2>Admin Girişi</h2>
                    <%--<asp:Label ID="Label3" runat="server" Text="Admin Girişi" ForeColor="White"></asp:Label>--%>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" Text="Admin"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Kullanıcı Adı Boş Geçilmez." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Şifre Boş Geçilemez." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Button ID="btnLogin" runat="server" Text="Login" Height="24px" Width="100px" CssClass="bluebutton" OnClick="btnLogin_Click" />
            </td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblMesaj" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
    </table>
</div>
