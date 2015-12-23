<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Receitas.aspx.cs" Inherits="Site.Admin.Pages.Receitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    Descrição da Receita:<br /> 
    <asp:TextBox ID="txtNome" runat="server" Width="400px" required="required" />
    <br /><br />

    Data de Recebimento:<br /> 
    <asp:TextBox ID="txtData" runat="server" required="required" />
    <br /><br />

    Valor:<br /> 
    <asp:TextBox ID="txtValor" runat="server" required="required" />
    <br /><br />

    <asp:Button ID="btnReceita" runat="server" Text="Cadastrar Receita" OnClick="btnReceita_Click" />

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>
</asp:Content>
