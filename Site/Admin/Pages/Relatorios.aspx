<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Relatorios.aspx.cs" Inherits="Site.Admin.Pages.Relatorios" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <h3>Gerar relatórios de Pagamentos / Recebimentos</h3>
    <br />

    <h4>Informe o período desejado:</h4>
    <br />
    
    De: <asp:TextBox ID="txtData" runat="server" required="required" />
    Até: <asp:TextBox ID="txtDataFim" runat="server" required="required" />
    <br /><br />
    Tipo de relatório: <asp:DropDownList ID="ddTipo" runat="server">
                            <asp:ListItem Enabled="true" Text="Pagamentos" Value="Pagamento" Selected="True" />
                            <asp:ListItem Enabled="true" Text="Recebimentos" Value="Recebimento" />
                       </asp:DropDownList>
    <br /><br />

    <asp:Button ID="btnRelatorio" runat="server" Text="Gerar Relatório" OnClick="btnRelatorio_Click" />

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>


<br />
<br />
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<rsweb:ReportViewer ID="ReportViewer" runat="server" Width="700px" Height="600px" SizeToReportContent="true">
</rsweb:ReportViewer>


</asp:Content>
