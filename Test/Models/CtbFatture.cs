using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbFatture
    {
        public int KeyFattura { get; set; }
        public int IdFattura { get; set; }
        public int IdIndennizzo { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public decimal? ImpTotale { get; set; }
        public decimal? ImpTotaleNettoAPagare { get; set; }
        public decimal? Imponibile { get; set; }
        public decimal? Cpa { get; set; }
        public decimal? Inps { get; set; }
        public decimal? Iva { get; set; }
        public decimal? NonImponibile { get; set; }
        public decimal? RitenutaAcconto { get; set; }
        public string FlgStato { get; set; }
        public string NFattura { get; set; }
        public DateTime? DtFattura { get; set; }
        public DateTime? DtVersamento { get; set; }
        public string Note { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCalcoloautomatico { get; set; }
        public string FlgIntestatario { get; set; }
        public string FlgProformaSino { get; set; }
        public string FlgModPagamento { get; set; }
        public int? IdAnagrafica { get; set; }
    }
}
