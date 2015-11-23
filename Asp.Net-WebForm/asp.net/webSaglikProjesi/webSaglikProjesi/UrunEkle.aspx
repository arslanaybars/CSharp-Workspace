<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="webSaglikProjesi.UrunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="float: left">
        <asp:DropDownList ID="ddlKategoriler" runat="server" Height="20px" Width="150px" OnSelectedIndexChanged="ddlKategoriler_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
    </div>

    <div>
        <asp:DropDownList ID="ddlAltKategoriler" runat="server" Height="20px" Width="150px" OnSelectedIndexChanged="ddlAltKategoriler_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
    </div>

    <div style="text-align: center">
        <asp:GridView ID="gvUrunler" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="400px" AutoGenerateColumns="False" DataKeyNames="urunid">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Seç" SelectText="&gt;&gt;" ShowSelectButton="True">
                    <ItemStyle HorizontalAlign="Right" />
                </asp:CommandField>
                <asp:BoundField DataField="urunkodu" HeaderText="Urun Kodu" />
                <asp:BoundField DataField="urunad" HeaderText="Urun Adı" />
                <asp:BoundField DataField="miktar" HeaderText="Miktar">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="urunfiyat" HeaderText="Fiyat">
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
    </div>

    <div>
        <asp:LinkButton ID="btnYeni" runat="server" OnClick="btnYeni_Click">Yeni Ürün Ekle</asp:LinkButton>
        <br />
        <br />
        <asp:Panel ID="pnlGiris" runat="server" Visible="false">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Ürün Kodu : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUrunKodu" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Ürün Adı : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUrunAdi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Ürün Bilgisi : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUrunBilgisi" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Miktar : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMiktar" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Fiyat : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFiyat" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Küçük Resim : "></asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload ID="fuResim1" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Büyük Resim : "></asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload ID="fuResim2" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Height="24px" Width="70px" CssClass="bluebutton" OnClick="btnKaydet_Click" />
                        <asp:Button ID="btnDegistir" runat="server" Text="Değştir" Height="24px" Width="70px" CssClass="bluebutton" OnClick="btnDegistir_Click" />
                        <asp:Button ID="btnSil" runat="server" Text="Sil" Height="24px" Width="70px" CssClass="bluebutton" OnClick="btnSil_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>
