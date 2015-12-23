<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Pagamentos.aspx.cs" Inherits="Site.Admin.Pages.Pagamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    Descrição do Pagamento:<br /> 
    <asp:TextBox ID="txtNome" runat="server" Width="400px" required="required" />
    <br /><br />

    Data de Pagamento:<br /> 
    <asp:TextBox ID="txtData" runat="server" required="required" />
    <br /><br />

    Valor:<br /> 
    <asp:TextBox ID="txtValor" runat="server" required="required" />
    <br /><br />

    <asp:Button ID="btnPagamento" runat="server" Text="Cadastrar Pagamento" OnClick="btnPagamento_Click" />

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>
</asp:Content>
