using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaDannoVal
    {
        public int KeyEntitaschedadannoval { get; set; }
        public int IdEntitaschedadannoval { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public decimal? PuntiInvalidita { get; set; }
        public decimal? ImpDannoPermanente { get; set; }
        public decimal? PctPersonalizzazionePerm { get; set; }
        public decimal? ImpPersonalizzazionePerm { get; set; }
        public decimal? PctPersonalizzazioneTemp { get; set; }
        public decimal? ImpPersonalizzazioneTemp { get; set; }
        public decimal? ImpSpeseMediche { get; set; }
        public decimal? ImpDanniCose { get; set; }
        public decimal? ImpRivalse { get; set; }
        public decimal? ImpOnorari { get; set; }
        public decimal? ImpAltriOneri { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
