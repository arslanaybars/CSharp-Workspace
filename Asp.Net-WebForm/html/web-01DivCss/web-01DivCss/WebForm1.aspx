<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web_01DivCss.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Satı içi Style kullanımı (Inline)</title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 1040px; height: 750px; background-color: silver">
            Govde
            <!--Inline Style-->
            <div style="width: 1000px; height: 120px; background-color: blue; margin: 10px 20px; color: white">
                Başlık (header)
            </div>

            <div style="width: 1000px; height: 40px; background-color: green; margin: 5px 20px 5px 20px; color: white">
                Ust Menu (Header Menu)
            </div>
            <div style="width: 1040px; height: 400px; margin: 5px 20px 5px 20px">
                <div style="width: 220px; height: 400px; background-color: red; margin: 5px 20px 5px 0px; color: white; float: left">
                    Sol Menu (Left-Menu Navbar)
                </div>

                <div style="width: 500px; height: 400px; background-color: gray; margin: 5px 10px 5px 10px; color: white; float: left">
                    Content (İçerik)
                </div>

                <div style="width: 220px; height: 400px; background-color: yellow; margin: 5px 0px 5px 20px; float: left">
                    Sağ Menu (Right-Menu Navbar)
                    <div style="width: 210px; height: 120px; background-color: pink; margin: 5px">1</div>
                    <div style="width: 210px; height: 120px; background-color: pink; margin: 5px">2</div>
                    <div style="width: 210px; height: 120px; background-color: pink; margin: 5px">3</div>
                </div>
            </div>
            <div style="clear: both; width: 1000px; height: 120px; background-color: orange; margin: 20px 20px">
                Footer
            </div>

        </div>

    </form>
</body>
</html>
