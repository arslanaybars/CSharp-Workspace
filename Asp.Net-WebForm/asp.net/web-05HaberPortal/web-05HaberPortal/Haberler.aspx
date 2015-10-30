<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Haberler.aspx.cs" Inherits="web_05HaberPortal.Haberler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <h2>Haberler</h2>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="govde">
                        <div class="baslik">
                            <%#Eval("HaberBaslik") %>
                        </div>
                        <div class="resim">
                            <img src='<%#Eval("HaberResim") %>' width="200px" height="200px" />
                        </div>
                        <div class="haber">
                            <%#Eval("HaberOzet") %>
                        </div>
                        <div class="devam">
                            <a href="HaberDetay.aspx?id=<%#Eval("id") %>">Haberin Devamı..</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
