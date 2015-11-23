<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="webSaglikProjesi.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dlistUrunler" DataKeyField="urunid" runat="server" Width="507px" OnItemCommand="dlistUrunler_ItemCommand">
        <ItemTemplate>
            <div style="text-align: center">
                <asp:Label ID="lblUrunAdi" runat="server" Text='<%# Eval("urunad") %>'></asp:Label><br />
                <asp:ImageButton ID="imgResim" ImageUrl='<%# Eval("resimyolu2")  %>' Width="220px" Height="240px" AlternateText='<%# Eval("urunad") %>' runat="server" /><br />
                <asp:Label ID="lblUrunFiyat" runat="server" Text='<%# Eval("urunfiyat", "{0:N}") %>'></asp:Label><asp:TextBox ID="txtAdet" Text="1" runat="server" Width="20px"></asp:TextBox><br />
                <asp:ImageButton ID="btnSepeteAt" ImageUrl="~/images/btnSepeteAt.png" runat="server" CommandName="sepet" /><br /><br />

                  <asp:Label ID="lblUrunBilgisi" runat="server" Text='<%# Eval("urunbilgisi") %>'></asp:Label>
                <br />

            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
