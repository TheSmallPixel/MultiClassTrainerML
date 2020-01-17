using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiConsultazioneInviiRisp
    {
        public int KeyConsultazioneinvioRisp { get; set; }
        public int IdConsultazioneinvioRisp { get; set; }
        public int IdConsultazioneinvio { get; set; }
        public int IdSinistro { get; set; }
        public string CodSinistroInviato { get; set; }
        public string FlgTipoRek { get; set; }
        public string ChiaveTipoRek { get; set; }
        public int? NumSinistri { get; set; }
        public int? CodiceProvvedimento1 { get; set; }
        public int? CodiceProvvedimento2 { get; set; }
        public int? CodiceProvvedimento3 { get; set; }
        public int? CodiceProvvedimento4 { get; set; }
        public int? CodiceProvvedimento5 { get; set; }
        public int? CodiceProvvedimento6 { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
