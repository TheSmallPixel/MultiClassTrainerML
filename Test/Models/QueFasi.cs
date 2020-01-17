using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QueFasi
    {
        public int KeyFase { get; set; }
        public int IdFase { get; set; }
        public int IdQuerela { get; set; }
        public DateTime DtInizioFase { get; set; }
        public DateTime DtFineFase { get; set; }
        public string FlgFaseQuerela { get; set; }
        public DateTime DtStatoFaseQuerela { get; set; }
        public string FlgStatoFaseQuerela { get; set; }
        public decimal ImpRisarcimento { get; set; }
        public decimal ImpSpeseProcessuali { get; set; }
        public string FlgRimborsoSpeseLegaliSino { get; set; }
        public string Note { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
