<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TabPanel.aspx.cs" Inherits="web_14AjaxControlToolkits.TabPanel" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
            <asp:TabContainer ID="TabContainer1" runat="server" Width="500px" ActiveTabIndex="1">
                <asp:TabPanel runat="server" ID="TabPanel1" HeaderText="Ürün İsimleri">
                    <ContentTemplate>
                        İstediğiniz ürünü anasayfadan veya detay sayfasından seçip sepete atabilirsiniz.
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Sepet İşlemleri">
                    <ContentTemplate>
                        Sepetinizdeki ürünleri inceleleyip istedğinizi silebilir. Alışverişe devam edebilir veya satın alma aşamasına geçebilirsiniz.
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </div>
    </form>
</body>
</html>
