<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web_06DataList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .id {
            width: 100px;
            float: left;
        }

        .item {
            width: 200px;
            float: left;
        }

        .detay {
            width: 200px;
            float: left;
        }

        .btn {
            width: 70px;
            float: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="dlstKategoriler" runat="server" CellPadding="4" ForeColor="#333333" Width="650px" OnItemCommand="dlstKategoriler_ItemCommand">
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <HeaderTemplate>
                    <div class="id">
                        KategoriNo
                    </div>
                    <div class="item">
                        KategoriAd
                    </div>
                    <div class="detay">
                        Aciklama
                    </div>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="id">
                        <%#Eval("KategoriNo") %>
                    </div>
                    <div class="item">
                        <%#Eval("KategoriAd") %>
                    </div>
                    <div class="detay">
                        <%#Eval("Aciklama") %>
                    </div>
                    <div class="btn">
                        <asp:LinkButton ID="lbDegistir" runat="server" CommandName="edit">Degistir</asp:LinkButton>
                    </div>
                    <div class="btn">
                        <asp:LinkButton ID="lbil" runat="server" CommandName="delete" CommandArgument='<%#Eval("KategoriNo") %>'>Sil</asp:LinkButton>
                    </div>
                </ItemTemplate>
                <EditItemTemplate>
                    <div class="id">
                        <asp:Label ID="lblKategoriNo" runat="server" Text='<%#Eval("KategoriNo") %>'></asp:Label>
                    </div>
                    <div class="item">
                        <asp:TextBox ID="txtKategoriAdi" runat="server" Text='<%#Eval("KategoriAd") %>'></asp:TextBox>
                    </div>
                    <div class="detay">
                        <asp:TextBox ID="txtAciklama" runat="server" Text='<%#Eval("Aciklama") %>'></asp:TextBox>
                    </div>
                    <div class="btn">
                        <asp:LinkButton ID="lbGuncelle" runat="server" CommandName="update" CommandArgument='<%#Eval("KategoriNo") %>'>Güncelle</asp:LinkButton>
                    </div>
                    <div class="btn">
                        <asp:LinkButton ID="lbVazdec" runat="server" CommandName="cancel">Vazgeç</asp:LinkButton>
                    </div>
                </EditItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
