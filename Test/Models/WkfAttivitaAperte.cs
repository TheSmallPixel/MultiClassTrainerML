using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WkfAttivitaAperte
    {
        public int IdAttivita { get; set; }
        public DateTime? DtInizioAttivita { get; set; }
        public DateTime? DtFineAttivita { get; set; }
        public int? IdOggetto { get; set; }
        public int? IdSinistro { get; set; }
        public int? KeyPolEvento { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoAttivita { get; set; }
        public string FlgTipoOggetto { get; set; }
        public DateTime? DtEffettoAttivita { get; set; }
        public int? IdUtenteTrattazione { get; set; }
        public int? IdGruppoTrattazione { get; set; }
        public string FlgStatoAttivita { get; set; }
        public DateTime? DtScadenza { get; set; }
        public DateTime? DtInserimento { get; set; }
        public string Note { get; set; }
        public int? IdAttivitaOrigine { get; set; }
    }
}
