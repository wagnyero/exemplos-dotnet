using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class HistoricoReceita
    {
        public int CodigoReceita { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRecebimento { get; set; }
        public double Valor { get; set; }
        public string Usuario { get; set; }
    }
}
