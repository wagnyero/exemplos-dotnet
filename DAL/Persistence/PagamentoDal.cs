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
    public class PagamentoDal : Conexao
    {
        public void insert(Pagamento p)
        {
            try
            {
                openConnection();
                Cmd = new SqlCommand("INSERT INTO Pagamento (nome, dataPagamento, valor, idUsuario) VALUES (@v1, @v2, @v3, @v4)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.nome);
                Cmd.Parameters.AddWithValue("@v2", p.dataPagamento);
                Cmd.Parameters.AddWithValue("@v3", p.valor);
                Cmd.Parameters.AddWithValue("@v4", p.idUsuario);

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

        public List<HistoricoPagamento> findAll(DateTime dataIni, DateTime dataFim)
        {
            try
            {
                openConnection();

                Cmd = new SqlCommand("SELECT * FROM HistoricoPagamento WHERE DataPagamento BETWEEN @v1 AND @v2", Con);
                Cmd.Parameters.AddWithValue("@v1", dataIni);
                Cmd.Parameters.AddWithValue("@v2", dataFim);

                Dr = Cmd.ExecuteReader();

                List<HistoricoPagamento> lista = new List<HistoricoPagamento>();

                while(Dr.Read())
                {
                    HistoricoPagamento p = new HistoricoPagamento();
                    p.CodigoPagamento = Convert.ToInt32(Dr["CodigoPagamento"]);
                    p.Descricao = Convert.ToString(Dr["Descricao"]);
                    p.DataPagamento = Convert.ToDateTime(Dr["DataPagamento"]);
                    p.valor = Convert.ToDouble(Dr["valor"]);
                    p.NomeUsuario = Convert.ToString(Dr["NomeUsuario"]);
                    p.Usuario = Convert.ToString(Dr["Usuario"]);

                    lista.Add(p);
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
