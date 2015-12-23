using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class HistoricoPagamento
    {
        public int CodigoPagamento { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPagamento { get; set; }
        public double valor { get; set; }
        public string NomeUsuario { get; set; }
        public string Usuario { get; set; }
    }
}