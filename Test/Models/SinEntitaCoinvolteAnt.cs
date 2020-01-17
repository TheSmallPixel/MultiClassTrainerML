using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaCoinvolteAnt
    {
        public int KeyEntitacoinvoltaAnt { get; set; }
        public int IdEntitacoinvoltaAnt { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public decimal? ImpLiquidazioneAlMeglio { get; set; }
        public decimal? ImpRichiestaRisarcitoria { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
