using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistriFantasma
    {
        public int KeySinistrofantasma { get; set; }
        public int IdSinistrofantasma { get; set; }
        public int IdSinistro { get; set; }
        public DateTime? DtFantasma { get; set; }
        public string FlgRiclassificazioneSino { get; set; }
        public string FlgFranchigiaStornataSino { get; set; }
        public string FlgImportoRimborsatoSino { get; set; }
        public decimal? ImportoRimborsato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
