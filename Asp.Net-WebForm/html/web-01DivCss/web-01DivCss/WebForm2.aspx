<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="web_01DivCss.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stlyle Elementiyle CSS kullanımı</title>
    <style type="text/css">
        #govde {
            width: 1040px;
            height: 750px;
            background-color: silver;
        }

        #baslik {
            width: 1000px;
            height: 120px;
            background-color: blue;
            margin: 10px 20px;
            color: white;
        }

        #ustmenu {
            width: 1000px;
            height: 40px;
            background-color: green;
            margin: 5px 20px 5px 20px;
            color: white;
        }

        #menu {
            width: 1040px;
            height: 400px;
            margin: 5px 20px 5px 20px;
        }

        #solmenu {
            width: 220px;
            height: 400px;
            background-color: red;
            margin: 5px 20px 5px 0px;
            color: white;
            float: left;
        }

        #icerik {
            width: 500px;
            height: 400px;
            background-color: gray;
            margin: 5px 10px 5px 10px;
            color: white;
            float: left;
        }

        #sagmenu {
            width: 220px;
            height: 400px;
            background-color: yellow;
            margin: 5px 0px 5px 20px;
            float: left;
        }

        .sagmenuTab {
            width: 210px;
            height: 120px;
            background-color: pink;
            margin: 5px;
        }

        #footer {
            clear: both;
            width: 1000px;
            height: 120px;
            background-color: orange;
            margin: 20px 20px;
        }
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
                    Content (İçerik)
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
