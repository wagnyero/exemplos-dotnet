using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlCommand Cmd;
        protected SqlConnection Con;
        protected SqlDataReader Dr;

        protected void openConnection()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["bd.ProjetoFinal"].ConnectionString);
            Con.Open();
        }

        protected void closeConnection()
        {
            Con.Close();
        }
    }
}
