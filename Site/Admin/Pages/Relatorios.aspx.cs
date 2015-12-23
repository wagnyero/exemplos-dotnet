using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entity;
using DAL.Persistence;
using Microsoft.Reporting.WebForms;

namespace Site.Admin.Pages
{
    public partial class Relatorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataIni = Convert.ToDateTime(txtData.Text);
                DateTime dataFim = Convert.ToDateTime(txtDataFim.Text);
                
                if (ddTipo.SelectedValue.Equals("Pagamento"))
                {
                    PagamentoDal pDal = new PagamentoDal();

                    ReportViewer.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("/Admin/Reports/RelPagamentos.rdlc");
                    ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelPagamentos", pDal.findAll(dataIni, dataFim)));
                }
                else if(ddTipo.SelectedValue.Equals("Recebimento"))
                {
                    ReceitaDal rDal = new ReceitaDal();

                    ReportViewer.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("/Admin/Reports/RelReceita.rdlc");
                    ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelReceita", rDal.findAll(dataIni, dataFim)));
                }

                ReportViewer.DataBind();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}