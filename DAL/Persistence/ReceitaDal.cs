using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Entity;
using DAL.Model;
namespace DAL.Persistence
{
    public class ReceitaDal : Conexao
    {
        public void insert (Receita r)
        {
            try
            {
                openConnection();

                Cmd = new SqlCommand("INSERT INTO Receita(nome, dataRecebimento, valor, idUsuario) VALUES(@v1, @v2, @v3, @v4)", Con);
                Cmd.Parameters.AddWithValue("@v1", r.nome);
                Cmd.Parameters.AddWithValue("@v2", r.dataRecebimento);
                Cmd.Parameters.AddWithValue("@v3", r.valor);
                Cmd.Parameters.AddWithValue("@v4", r.idUsuario);

                Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        public List<HistoricoReceita> findAll(DateTime dataIni, DateTime dataFim)
        {
            try
            {
                openConnection();

                Cmd = new SqlCommand("SELECT * FROM HistoricoReceita WHERE DataRecebimento BETWEEN @v1 AND @v2", Con);
                Cmd.Parameters.AddWithValue("@v1", dataIni);
                Cmd.Parameters.AddWithValue("@v2", dataFim);

                Dr = Cmd.ExecuteReader();

                List<HistoricoReceita> lista = new List<HistoricoReceita>();

                while(Dr.Read())
                {
                    HistoricoReceita r = new HistoricoReceita();
                    r.CodigoReceita = Convert.ToInt32(Dr["CodigoReceita"]);
                    r.Descricao = Convert.ToString(Dr["Descricao"]);
                    r.DataRecebimento = Convert.ToDateTime(Dr["DataRecebimento"]);
                    r.Valor = Convert.ToDouble(Dr["Valor"]);
                    r.Usuario = Convert.ToString(Dr["Usuario"]);

                    lista.Add(r);
                }

                return lista;
            }
            catch
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
