<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="webSaglikProjesi.Admin" %>

<%@ Register Src="~/ucLogin.ascx" TagPrefix="uc1" TagName="ucLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center">
        <asp:Panel ID="pnlLogin" runat="server">
            <uc1:ucLogin runat="server" ID="ucLogin" />
        </asp:Panel>
    </div>
</asp:Content>
