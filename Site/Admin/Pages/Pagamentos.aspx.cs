using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entity;
using DAL.Persistence;

namespace Site.Admin.Pages
{
    public partial class Pagamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario dadosUsuario = Session["usuario"] as Usuario;

                Pagamento p = new Pagamento();
                p.nome = txtNome.Text;
                p.dataPagamento = Convert.ToDateTime(txtData.Text);
                p.valor = Convert.ToDouble(txtValor.Text);
                p.idUsuario = dadosUsuario.idUsuario;

                PagamentoDal pDal = new PagamentoDal();
                pDal.insert(p);

                lblMensagem.Text = "Pagamento cadastrado com sucesso.";
                txtNome.Text = string.Empty;
                txtData.Text = string.Empty;
                txtValor.Text = string.Empty;
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}