using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrComposizioneCapitale
    {
        public int KeyPrComposizioneCapitale { get; set; }
        public int IdPrComposizioneCapitale { get; set; }
        public int IdPrGarTariffa { get; set; }
        public string FlgTipoComposizione { get; set; }
        public decimal? PercComposizione { get; set; }
        public int IdPrTarComposizione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
