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
    public partial class Receitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReceita_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario dadosUsuario = Session["usuario"] as Usuario;

                Receita r = new Receita();
                r.nome = txtNome.Text;
                r.dataRecebimento = Convert.ToDateTime(txtData.Text);
                r.valor = Convert.ToDouble(txtValor.Text);
                r.idUsuario = dadosUsuario.idUsuario;

                ReceitaDal rDal = new ReceitaDal();
                rDal.insert(r);

                lblMensagem.Text = "Receita gravado com sucesso.";
                txtNome.Text = string.Empty;
                txtValor.Text = string.Empty;
                txtData.Text = string.Empty;
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}