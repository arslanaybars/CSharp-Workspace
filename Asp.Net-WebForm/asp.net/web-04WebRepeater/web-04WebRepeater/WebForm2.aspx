<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="web_04WebRepeater.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="govde">
            Govde
            <!--Inline Style-->
            <div id="baslik">
                Başlık (header)
            </div>

            <div id="ustmenu">
                Ust Menu (Header Menu)
            </div>
            <div id="menu">
                <div id="solmenu">
                    Sol Menu (Left-Menu Navbar)
                </div>

                <div id="icerik">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <h2>Kategoriler</h2>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div>
                                <%#Eval("KategoriAd") %>
                            </div>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <div style="background-color: silver;">
                                <%#Eval("KategoriAd") %>
                            </div>
                        </AlternatingItemTemplate>
                        <SeparatorTemplate>
                            <hr />
                        </SeparatorTemplate>
                    </asp:Repeater>
                </div>

                <div id="sagmenu">
                    Sağ Menu (Right-Menu Navbar)
                    <div class="sagmenuTab">1</div>
                    <div class="sagmenuTab">2</div>
                    <div class="sagmenuTab">3</div>
                </div>
            </div>
            <div id="footer">
                Footer
            </div>
        </div>
    </form>
</body>
</html>
