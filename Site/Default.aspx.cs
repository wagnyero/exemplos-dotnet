using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entity;
using DAL.Persistence;
using DAL.Util;
using System.Web.Security;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["usuario"] != null)
                {
                    Response.Redirect("/Admin/Default.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text;
                string senha = Criptografia.criptografarSenha(txtSenha.Text);

                UsuarioDal uDal = new UsuarioDal();
                Usuario u = uDal.validarUsuarioAtivo(login, senha);

                if(u != null)
                {
                    FormsAuthentication.SetAuthCookie(u.login, false);
                    Session.Add("usuario", u);
                    
                    Response.Redirect("/Admin/Default.aspx");
                }
                else
                {
                    lblMensagem.Text = "Acesso negado. Tente novamente!";
                }
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}