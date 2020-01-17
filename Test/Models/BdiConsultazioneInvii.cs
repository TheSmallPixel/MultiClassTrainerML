using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiConsultazioneInvii
    {
        public int KeyConsultazioneinvio { get; set; }
        public int IdConsultazioneinvio { get; set; }
        public DateTime? DtInvio { get; set; }
        public DateTime? DtRisposta { get; set; }
        public DateTime? DtErrore { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
