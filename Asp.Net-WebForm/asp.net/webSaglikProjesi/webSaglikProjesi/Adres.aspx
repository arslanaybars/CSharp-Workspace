<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Adres.aspx.cs" Inherits="webSaglikProjesi.Adres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            text-align: left;
        }

        .auto-style2 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var ustbaslik = this.document.getElementById("baslik");
        ustbaslik.innerText = "Adres Onayı";
    </script>
    <div style="text-align: center">
        <img src="images/adresonay2.jpg" />

        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Sitemizden alışveriş yapabilmeniz için öncelikle üye olmanız gerekmetedir. Eğer üye değilseniz "></asp:Label><a href="UyeKayit.aspx">yeni üye kaydı için tıklayınız.</a>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Kulanıcı Adı ( E-mail ) :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Sifre :"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSifre" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnGiris" Width="150px" Height="24" CssClass="bluebutton" runat="server" Text="Giriş" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMesaj" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        <asp:Panel ID="pnlAdres" runat="server" Visible="false">

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Teslim Adresi :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdres" runat="server" Width="150px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="İlçe :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIlce" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="İl :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIl" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Telefon :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelefon" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAdresOnay" Width="150px" Height="24" CssClass="bluebutton" runat="server" Text="Adres Onay" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>
