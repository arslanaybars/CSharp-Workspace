<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="web_01DivCss.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Harici style dosyasi ile calismak (External)</title>
    <%--<link href="Style.css" rel="stylesheet" />--%>
    <style type="text/css">
        @import "Style.css";
    </style>
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
                    Content (İçerik)<br />
                    <p class="egik">Harici stylesheet dosyalarını safyalarımızda kullanabilmek için Link veya import seçeneklerini tercih edebiliriz.</p>
                    <h3>Link Seçeneği :</h3>
                    <p class="onemli">Solution explorer'dan css dosyasını sürükleyip head bölümüne bırakarak linki kolayca oluşturabiliriz.</p>
                    <h3>Import Seçeneği :</h3>
                    <p class="egik onemli">Import ifadesi derleyiciler tarafından linkten daha önce dikkate alınır ancak eski tarayıcılar tarafından yorumlanamama riski vardır.</p>
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
