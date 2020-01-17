using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbDatiAggiuntiviPagamenti
    {
        public int KeyDatiAggiuntiviPagamenti { get; set; }
        public int IdDatiAggiuntiviPagamenti { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgCessioneCreditoSino { get; set; }
        public string FlgConcordatoSenzaRipSino { get; set; }
        public string FlgRipAntieconomicaSino { get; set; }
        public string FlgAstaRelittoSino { get; set; }
        public string FlgRicambiOriginaliSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
