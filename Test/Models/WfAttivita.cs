using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfAttivita
    {
        public decimal IdAttivita { get; set; }
        public DateTime? DtInizioAttivita { get; set; }
        public DateTime? DtFineAttivita { get; set; }
        public decimal? IdOggetto { get; set; }
        public decimal? IdSinistro { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoAttivita { get; set; }
        public string FlgTipoOggetto { get; set; }
        public DateTime? DtEffettoAttivita { get; set; }
        public decimal? IdUtenteTrattazione { get; set; }
        public decimal? IdGruppoTrattazione { get; set; }
        public string FlgStatoAttivita { get; set; }
        public DateTime? DtScadenza { get; set; }
        public DateTime? DtInserimento { get; set; }
        public string Note { get; set; }
        public decimal? IdAttivitaOrigine { get; set; }
    }
}
