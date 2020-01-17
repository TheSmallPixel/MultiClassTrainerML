using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLimitePagamenti
    {
        public int IdLimitePagamento { get; set; }
        public int IdCompagniaLimPag { get; set; }
        public int? IdUtenteLimPag { get; set; }
        public decimal ImpSoglia { get; set; }
        public int IdRamo { get; set; }
        public int? IdProdotto { get; set; }
        public int IdUtente { get; set; }
        public string EmailNotifica { get; set; }
        public string FlgAmmettePagamentoSino { get; set; }
    }
}
