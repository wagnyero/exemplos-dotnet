<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h3>Preencha os dados abaixo:</h3>

        <form id="form" runat="server">
            Nome: <br />
            <asp:TextBox ID="txtNome" runat="server" Width="250px" required="required" />
            <br /><br />

            Email: <br />
            <asp:TextBox ID="txtEmail" runat="server" Width="200px" type="email" required="required" />
            <br /><br />

            Usuário: <br />
            <asp:TextBox ID="txtLogin" runat="server" Width="150px" required="required" pattern="^[a-z0-9\s]{6,25}$" />
            <br /><br />

            Senha: <br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" Width="150px" required="required" pattern="^[A-Za-z0-9\s]{6,20}$" />
            <br /><br />

            Confirme sua Senha: <br />
            <asp:TextBox ID="txtSenha2" runat="server" TextMode="Password" Width="150px" required="required" pattern="^[A-Za-z0-9\s]{6,20}$" />
            <br /><br />

            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Usuário" OnClick="btnCadastro_Click" />

            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>
        </form>
    </div> <!-- fechando a div do conteúdo -->
</asp:Content>
