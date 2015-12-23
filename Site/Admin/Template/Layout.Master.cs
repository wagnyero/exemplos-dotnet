using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using DAL.Entity;

namespace Site.Admin.Template
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Usuario u = Session["usuario"] as Usuario;
                lblNome.Text = u.nome.ToString();
            } 
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Remove("usuario");
            Session.Abandon();

            Response.Redirect("/Default.aspx");
        }
    }
}