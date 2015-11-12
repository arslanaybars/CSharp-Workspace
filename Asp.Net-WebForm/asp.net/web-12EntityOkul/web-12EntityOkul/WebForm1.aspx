<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web_12EntityOkul.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="ddlSiniflar" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlSiniflar_SelectedIndexChanged" Width="201px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvOgrenciler" runat="server" CellPadding="4" DataKeyNames="ID" ForeColor="#333333" GridLines="None" Width="516px" OnSelectedIndexChanged="gvOgrenciler_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField SelectText="Sec" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <asp:LinkButton ID="lbEkle" runat="server" OnClick="lbEkle_Click">Yeni Öğrenci Ekle</asp:LinkButton>
            <br />
            <br />
            <asp:Label ID="lblOgrenciNo" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="false">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Adi"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Soyadi"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Telefon"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Adres"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAdres" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="TC Kimlik No"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtTCKNo" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Taksit Sayisi"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtTSayisi" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Taksit Tutarı"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtTTutari" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="80px" OnClick="btnKaydet_Click" ></asp:Button></td>
                        <td>
                            <asp:Button ID="btnDegistir" runat="server" Text="Degistir" Width="80px" OnClick="btnDegistir_Click"></asp:Button>
                            &nbsp;
                            <asp:Button ID="btnSil" runat="server" Text="Sil" Width="80px" OnClick="btnSil_Click"></asp:Button></td>
                    </tr>
                </table>
            </asp:Panel>

        </div>
    </form>
</body>
</html>
