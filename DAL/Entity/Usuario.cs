using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string ativo { get; set; }

        public List<Pagamento> Pagamentos { get; set; }
        public List<Receita> Receitas { get; set; }
    }
}
