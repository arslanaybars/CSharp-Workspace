<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="akordiyon.aspx.cs" Inherits="web_14AjaxControlToolkits.akordiyon" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .accordion {
            width: 300px;
        }

        .accBaslik {
            border: 1px solid black;
            color: white;
            background-color: black;
            cursor: pointer;
            font-family: Verdana;
            font-size: 12px;
            padding: 5px;
        }

        .accSecili {
            border: 1px solid black;
            color: white;
            background-color: black;
            cursor: pointer;
            font-family: Verdana;
            font-size: 12px;
            padding: 5px;
        }

        .accIcerik {
            border: 1px dashed black;
            background-color: silver;
            cursor: pointer;
            font-family: Verdana;
            font-size: 12px;
            padding-top: 10px;
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
            <asp:Accordion ID="Accordion1" runat="server" CssClass="accordion" ContentCssClass="accIcerik" HeaderCssClass="accBaslik" HeaderSelectedCssClass="accSecili">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane1" runat="server">
                        <Header>ASP.Net Ajax hangi nesneleri kullanır</Header>
                        <Content>
                            Javascript, xml dışında html/xhtml, css, DOM, XMLHttpRequest nesnelerini kullanır.
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane2" runat="server">
                        <Header>XMLHttpRequest ne amaçla kullanılır</Header>
                        <Content>
                            Normal web sayfasının işleyişini arkaplanda client side olarak takip eder. Asenkron olarak sayfanın istenilen bölümünün güncellenmesini (postback) sağlar.
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane3" runat="server">
                        <Header>Asp.Net Ajax nasıl bir postback işlemi gerçekleşir</Header>
                        <Content>
                            Update panel içinde bulunan bölüm partial page postback işlemine maruz kalır.
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane4" runat="server">
                        <Header>Toolkit Script Manager ne amaçla kullanılır</Header>
                        <Content>
                            Ajax Control Toolkit araçlarını kullanmak için öncelikle sayfaya script manager yerine toolkitScriptManager atılmalıdır.
                        </Content>
                    </asp:AccordionPane>

                </Panes>
            </asp:Accordion>
        </div>
    </form>
</body>
</html>
