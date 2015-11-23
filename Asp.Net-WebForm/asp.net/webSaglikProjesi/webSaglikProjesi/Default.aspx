<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webSaglikProjesi.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="dlistUrunler" RepeatColumns="3" DataKeyField="urunid" runat="server" Width="507px" OnItemCommand="dlistUrunler_ItemCommand">
        <ItemTemplate>
            <div style="text-align: center">
                <asp:Label ID="lblUrunAdi" runat="server" Text='<%# Eval("urunad") %>'></asp:Label><br />
                <asp:ImageButton ID="imgResim" ImageUrl='<%# Eval("resimyolu1")  %>' Width="100px" Height="120px" AlternateText='<%# Eval("urunad") %>' runat="server" CommandName="detay" CommandArgument='<%# Eval("urunid") %>' /><br />
                <asp:Label ID="lblUrunFiyat" runat="server" Text='<%# Eval("urunfiyat", "{0:N}") %>'></asp:Label><asp:TextBox ID="txtAdet" Text="1" runat="server" Width="20px"></asp:TextBox><br />
                <asp:ImageButton ID="btnSepeteAt" ImageUrl="~/images/btnSepeteAt.png" runat="server" CommandName="sepet" />

            </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
