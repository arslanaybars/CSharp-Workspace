﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web_10MasterDetails.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="FilmNo" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="750px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Select" SelectText="&gt;&gt;" ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:BoundField DataField="FilmNo" HeaderText="FilmNo" InsertVisible="False" ReadOnly="True" SortExpression="FilmNo" />
                <asp:BoundField DataField="FilmAd" HeaderText="FilmAd" SortExpression="FilmAd" />
                <asp:BoundField DataField="FilmTurNo" HeaderText="FilmTurNo" SortExpression="FilmTurNo" />
                <asp:BoundField DataField="Yonetmen" HeaderText="Yonetmen" SortExpression="Yonetmen" />
                <asp:BoundField DataField="Oyuncular" HeaderText="Oyuncular" SortExpression="Oyuncular" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VideoMarketConnectionString %>" SelectCommand="SELECT [FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular] FROM [Filmler]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataKeyNames="FilmNo" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" Height="50px" OnDataBound="DetailsView1_DataBound" Width="181px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="FilmNo" HeaderText="FilmNo" InsertVisible="False" ReadOnly="True" SortExpression="FilmNo" />
                <asp:BoundField DataField="FilmAd" HeaderText="FilmAd" SortExpression="FilmAd" />
                <asp:BoundField DataField="FilmTurNo" HeaderText="FilmTurNo" SortExpression="FilmTurNo" />
                <asp:BoundField DataField="Yonetmen" HeaderText="Yonetmen" SortExpression="Yonetmen" />
                <asp:BoundField DataField="Oyuncular" HeaderText="Oyuncular" SortExpression="Oyuncular" />
                <asp:BoundField DataField="Ozet" HeaderText="Ozet" SortExpression="Ozet" />
                <asp:BoundField DataField="Miktar" HeaderText="Miktar" SortExpression="Miktar" />
                <asp:CheckBoxField DataField="Varmi" HeaderText="Varmi" SortExpression="Varmi" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:VideoMarketConnectionString %>" DeleteCommand="DELETE FROM [Filmler] WHERE [FilmNo] = @FilmNo" InsertCommand="INSERT INTO [Filmler] ([FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Miktar], [Varmi]) VALUES (@FilmAd, @FilmTurNo, @Yonetmen, @Oyuncular, @Ozet, @Miktar, @Varmi)" SelectCommand="SELECT * FROM [Filmler] WHERE ([FilmNo] = @FilmNo)" UpdateCommand="UPDATE [Filmler] SET [FilmAd] = @FilmAd, [FilmTurNo] = @FilmTurNo, [Yonetmen] = @Yonetmen, [Oyuncular] = @Oyuncular, [Ozet] = @Ozet, [Miktar] = @Miktar, [Varmi] = @Varmi WHERE [FilmNo] = @FilmNo">
            <DeleteParameters>
                <asp:Parameter Name="FilmNo" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="FilmAd" Type="String" />
                <asp:Parameter Name="FilmTurNo" Type="Int32" />
                <asp:Parameter Name="Yonetmen" Type="String" />
                <asp:Parameter Name="Oyuncular" Type="String" />
                <asp:Parameter Name="Ozet" Type="String" />
                <asp:Parameter Name="Miktar" Type="Int32" />
                <asp:Parameter Name="Varmi" Type="Boolean" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" DefaultValue="" Name="FilmNo" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="FilmAd" Type="String" />
                <asp:Parameter Name="FilmTurNo" Type="Int32" />
                <asp:Parameter Name="Yonetmen" Type="String" />
                <asp:Parameter Name="Oyuncular" Type="String" />
                <asp:Parameter Name="Ozet" Type="String" />
                <asp:Parameter Name="Miktar" Type="Int32" />
                <asp:Parameter Name="Varmi" Type="Boolean" />
                <asp:Parameter Name="FilmNo" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
