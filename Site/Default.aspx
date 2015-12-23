<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h3>Bem vindo</h3>

        <p>
            Aqui você encontra as melhores dicas de estética. <br />
            Para acessar o sistema Financeiro, efetue o login ao lado.
        </p>
    </div> <!-- fechando a div do conteúdo -->

    <div id="coluna">
        <h4>Entrar no sistema</h4>
        
        <form id="form" runat="server">
            Usuário:<br/>
            <asp:TextBox ID="txtLogin" runat="server" required="required" /><br />
            
            Senha:<br/>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" required="required" /><br/>
            
            <asp:Button ID="btnLogin" runat="server" Text="Acessar" OnClick="btnLogin_Click" />

            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>
        </form>
    </div>

</asp:Content>
