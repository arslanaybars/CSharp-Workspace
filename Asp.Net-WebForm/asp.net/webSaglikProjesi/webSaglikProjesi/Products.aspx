<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="webSaglikProjesi.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dlstUrunler" RepeatColumns="3" DataKeyField="urunid" runat="server" Width="510px" OnItemCommand="dlstUrunler_ItemCommand">
        <ItemTemplate>
            <div style="text-align: center">
                <asp:Label ID="lblUrunAdi" runat="server" Text='<% #Eval("urunad")%>'></asp:Label>
                <br />
                <asp:ImageButton ID="imgResim" ImageUrl='<%# Eval("resimyolu1") %>' Width="100px" Height="120px" AlternateText='<% #Eval("urunad")%>' CommandArgument='<% #Eval("urunid")%>' runat="server" CommandName="detay" />
                <br />
                <asp:Label ID="lblUrunFiyat" runat="server" Text='<% #Eval("urunfiyat")%>'></asp:Label>
                <asp:TextBox ID="txtAdet" Text="1" runat="server" Width="20px"></asp:TextBox>
                <br />
                <asp:ImageButton ID="btnSepeteAt" ImageUrl='~/images/btnSepeteAt.png' runat="server" CommandName="sepet" />

            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
