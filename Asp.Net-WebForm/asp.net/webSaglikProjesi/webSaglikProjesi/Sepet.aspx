<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="webSaglikProjesi.Sepet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 432px;
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var ustbaslik = this.document.getElementById("baslik");
        ustbaslik.innerText = "Sepetim";
    </script>
    <div style="text-align:center">
    <img class="auto-style1" src="images/sepetonay2.jpg" /><asp:GridView ID="gvSepet" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="154px" Width="508px" AutoGenerateColumns="False" GridLines="Horizontal" ShowFooter="True" OnRowDeleting="gvSepet_RowDeleting">
       
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="urunAd" HeaderText="Ürün Adı" />
                <asp:BoundField DataField="fiyat" HeaderText="Fiyat" >
                <HeaderStyle HorizontalAlign="Right" />
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="adet" HeaderText="Adet" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="tutar" HeaderText="Tutar" >
                <HeaderStyle HorizontalAlign="Right" />
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:CommandField DeleteText="X" ControlStyle-ForeColor="Red" ControlStyle-Font-Size="Large" ShowDeleteButton="True" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
            </Columns>
       
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
        <EmptyDataTemplate><h3>Sepetinizde Ürün Bulunmamaktadır.</h3></EmptyDataTemplate>
        
    </asp:GridView>
        <br />
        <asp:Button ID="btnBosalt" width="116px" Height="24" CssClass="bluebutton" runat="server" Text="Sepeti Boşalt" OnClick="btnBosalt_Click" />
        &nbsp;
        <asp:Button ID="btnDevam" width="116px" Height="24" CssClass="bluebutton" runat="server" Text="Alışverişe Devam" OnClick="btnDevam_Click" />
&nbsp;
        <asp:Button ID="btnSatinAl" width="116px" Height="24" CssClass="bluebutton" runat="server" Text="Satın Al" OnClick="btnSatinAl_Click" />
    </div>
</asp:Content>

