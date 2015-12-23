using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL.Util
{
    public class Criptografia
    {
        //Método para retornar a senha do usuário criptografada
        public static string criptografarSenha(string senha)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.UTF8.GetBytes(senha));

                byte[] hash = md5.Hash; // gerar um valor binário com a criptografia

                //transformar o conteúdo de binário para string
                string resultado = string.Empty;

                for (int i = 0; i < hash.Length; i++)
                {
                    //cada posição do vetor é um byte, então estamos transformando para string e informando que é para retornar em hexadecimal ('x')
                    resultado += hash[i].ToString("x");
                }

                return resultado;
            }
            catch
            {
                throw;
            }
        }
    }
}
