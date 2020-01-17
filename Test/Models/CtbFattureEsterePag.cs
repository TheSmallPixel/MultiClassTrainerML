using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbFattureEsterePag
    {
        public int KeyFatturaEsteraPag { get; set; }
        public int IdFatturaEsteraPag { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int IdFatturaEstera { get; set; }
        public DateTime? DataPagamento { get; set; }
        public DateTime? DtScaricoContabilita { get; set; }
        public decimal? ImpPagamento { get; set; }
    }
}
