using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardMovimentiTecnici
    {
        public int IdMovimentoTecnico { get; set; }
        public int IdSinistro { get; set; }
        public string NSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public string TipoRecupero { get; set; }
        public DateTime DtPagamento { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public int IdRecupero { get; set; }
        public decimal ImportoRecupero { get; set; }
    }
}
