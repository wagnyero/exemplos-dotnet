using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Entity;

namespace DAL.Persistence
{
    public class UsuarioDal : Conexao
    {
        public void insert(Usuario u)
        {
            try
            {
                openConnection();
                Cmd = new SqlCommand("INSERT INTO Usuario (nome, login, senha, email, ativo) VALUES (@v1, @v2, @v3, @v4, @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", u.nome);
                Cmd.Parameters.AddWithValue("@v2", u.login);
                Cmd.Parameters.AddWithValue("@v3", u.senha);
                Cmd.Parameters.AddWithValue("@v4", u.email);
                Cmd.Parameters.AddWithValue("@v5", u.ativo);

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

        //Verifica se o usuário está incluído no banco e se está ativo
        public Usuario validarUsuarioAtivo(string login, string senha)
        {
            try
            {
                openConnection();

                Cmd = new SqlCommand("SELECT * FROM Usuario WHERE login = @v1 AND senha = @v2", Con);
                Cmd.Parameters.AddWithValue("@v1", login);
                Cmd.Parameters.AddWithValue("@v2", senha);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read() && Convert.ToString(Dr["ativo"]).Equals("S"))
                {
                    Usuario u = new Usuario();
                    u.idUsuario = Convert.ToInt32(Dr["idUsuario"]);
                    u.nome = Convert.ToString(Dr["nome"]);
                    u.login = Convert.ToString(Dr["login"]);
                    u.senha = Convert.ToString(Dr["senha"]);
                    u.email = Convert.ToString(Dr["email"]);
                    u.ativo = Convert.ToString(Dr["ativo"]);

                    return u;
                }

                return null;
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

        //Verifica se o usuário está incluído no banco
        public bool validarUsuario(string login)
        {
            try
            {
                openConnection();

                Cmd = new SqlCommand("SELECT idUsuario FROM Usuario WHERE login = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", login);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
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