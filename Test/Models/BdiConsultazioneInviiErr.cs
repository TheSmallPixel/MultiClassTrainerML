using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiConsultazioneInviiErr
    {
        public int KeyConsultazioneinvioErr { get; set; }
        public int IdConsultazioneinvioErr { get; set; }
        public int IdConsultazioneinvio { get; set; }
        public int IdSinistro { get; set; }
        public string CodSinistroInviato { get; set; }
        public int? ProgressivoRecord { get; set; }
        public string ChiaveTipoRek { get; set; }
        public string CodErrore { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
