<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web_0WebGridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvMusteriler" runat="server" CellPadding="4" DataKeyNames="MusteriNo" ForeColor="#333333" GridLines="None" Width="1000px" AutoGenerateColumns="False" OnRowEditing="gvMusteriler_RowEditing" OnRowCancelingEdit="gvMusteriler_RowCancelingEdit" OnRowUpdating="gvMusteriler_RowUpdating" OnRowCommand="gvMusteriler_RowCommand" OnRowDeleting="gvMusteriler_RowDeleting">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="&gt;&gt;" ShowSelectButton="True" />
                    <asp:TemplateField HeaderText="Musteri No">
                        <EditItemTemplate>
                            <asp:Label ID="lblMusteriNo" runat="server" Text='<%# Bind("MusteriNo") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("MusteriNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Adi">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAdi" runat="server" Text='<%# Bind("MusteriAd") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtYeniAd" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("MusteriAd") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Soyadi">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSoyadi" runat="server" Text='<%# Bind("MusteriSoyad") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtYeniSoyad" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("MusteriSoyad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Telefon">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelefon" runat="server" Text='<%# Bind("Telefon") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtYeniTelefon" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Telefon") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Adres">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAdres" runat="server" Text='<%# Bind("Adres") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtYeniAdres" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Adres") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Güncelle"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Vazgec"></asp:LinkButton>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="lbKaydet" runat="server" CausesValidation="True" CommandName="Save" ForeColor="White" Text="Kaydet"></asp:LinkButton>
                            &nbsp;&nbsp;
                            <asp:LinkButton ID="lbVazgec" runat="server" CausesValidation="True" CommandName="Vazgec" ForeColor="White" Text="Vazgec"></asp:LinkButton>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbGuncelle" runat="server" CausesValidation="False" CommandName="Edit" Text="Degistir"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbSil" runat="server" CausesValidation="False" CommandName="Delete" Text="Sil"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
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
        </div>
        <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Müşteri Ekle" />
    </form>
</body>
</html>
