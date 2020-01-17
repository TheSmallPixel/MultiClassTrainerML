using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardMovimentiConsap
    {
        public int IdMovimentoConsap { get; set; }
        public int IdSinistro { get; set; }
        public string NSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public string TipoDanno { get; set; }
        public DateTime DtContabileConsap { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgParzialeTotale { get; set; }
        public string FlgCausaleMovimento { get; set; }
        public DateTime DtPagamento { get; set; }
        public DateTime? DtAbbinamentoFlusso { get; set; }
        public decimal ImportoRecuperato { get; set; }
        public int? IdFlussoCard { get; set; }
    }
}
