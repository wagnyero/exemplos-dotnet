﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Pagamento
    {
        public int idPagamento { get; set; }
        public string nome { get; set; }
        public DateTime dataPagamento { get; set; }
        public double valor { get; set; }
        public int idUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
