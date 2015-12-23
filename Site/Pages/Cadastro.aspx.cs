using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entity;
using DAL.Persistence;
using DAL.Util;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtSenha2.Text))
            {
                try
                {
                    UsuarioDal uDal = new UsuarioDal();

                    if (uDal.validarUsuario(txtLogin.Text) )
                    {
                        lblMensagem.Text = "O usuário informado encontra-se em uso. Favor, utilize outro.";
                    }
                    else
                    {
                        Usuario u = new Usuario();

                        u.nome = txtNome.Text;
                        u.login = txtLogin.Text;
                        u.senha = Criptografia.criptografarSenha(txtSenha.Text);
                        u.email = txtEmail.Text;
                        u.ativo = "S";

                        uDal.insert(u);
                        lblMensagem.Text = "Usuário " + u.login + " cadastrado com sucesso.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
            else
            {
                lblMensagem.Text = "As senhas informadas não estão corretas";
            }
        }
    }
}