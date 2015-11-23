<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="webSaglikProjesi.UyeKayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var ustbaslik = this.document.getElementById("baslik");
        ustbaslik.innerText = "Yeni Üye Kayıt";
    </script>
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align: center">
                <h3>
                    <asp:Label ID="lblMesaj" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label></h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Kulanıcı Adı ( E-mail ) :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Sifre :"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvSifre" runat="server" ControlToValidate="txtSifre" ErrorMessage="Şifre Boş Geçilemez." ForeColor="Red">*</asp:RequiredFieldValidator>
                
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Sifre Tekrar :"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtSifreTekrar" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvSifreTekrar" runat="server" ControlToValidate="txtSifreTekrar" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvSifreTekrar" runat="server" ControlToCompare="txtSifre" ControlToValidate="txtSifreTekrar" ErrorMessage="Şifreler Aynı Olmalıdır" ForeColor="Red">*</asp:CompareValidator>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Üye Adı :"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtAdi" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAdi" runat="server" ControlToValidate="txtAdi" ErrorMessage="İsim boş geçilemez." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Uye Soyadı :"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtSoyadi" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvSoyadi" runat="server" ControlToValidate="txtSoyadi" ErrorMessage="Soyadı boş geçilemez." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="TC Kimlik No :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTCKNo" runat="server" Width="300px" MaxLength="11" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfcTCKNo" runat="server" ControlToValidate="txtTCKNo" ErrorMessage="TC Kimlik numarası boş geçilemez." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Teslim Adresi :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" Width="300px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="İlçe :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtIlce" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="İl :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtIl" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Telefon :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align: center">
                <asp:CheckBox ID="cbxOkudum" runat="server" Text="Gizlilik Sözleşmesini Okudum." />
            </td>
            </tr>


        <tr>
            <td>&nbsp;</td>
            <td style="text-align: center">
                <asp:Button ID="btnKayit" Width="150px" Height="24" CssClass="bluebutton" runat="server" Text="Kayıt Ol" OnClick="btnKayit_Click" />
            </td>
        </tr>


        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>


        <tr>
            <td>&nbsp;</td>
            <td><asp:TextBox ID="TextBox1" runat="server" Width="300px" TextMode="MultiLine" Height="83px">Girmiş olduğunuz kişisel bilgileriniz. Üçüncü şahıs veya kurumlarla kesinlikle paylaşılmayacaktır. Her türlü özel bilgi ve ödeme işlemleriniz 128 bit SSL güvenlik sertifikalarıyla şifrelenmektedir.</asp:TextBox></td>
        </tr>

    </table>
</asp:Content>
