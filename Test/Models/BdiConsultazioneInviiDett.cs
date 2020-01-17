using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiConsultazioneInviiDett
    {
        public int KeyConsultazioneinvioDett { get; set; }
        public int IdConsultazioneinvioDett { get; set; }
        public int IdConsultazioneinvio { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? ProgressivoRecord { get; set; }
        public string CodSinistroInviato { get; set; }
        public string Targa { get; set; }
        public string CodiceFiscalePartitaIva { get; set; }
        public string TipoRicerca { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
