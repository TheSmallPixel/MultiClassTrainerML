using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolAutorizzazioni
    {
        public decimal KeyPolAutorizzazione { get; set; }
        public decimal IdPolAutorizzazione { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal? PrgAppendice { get; set; }
        public string FlgStatoAutorizzazione { get; set; }
        public decimal? IdUtenteAutorizzatore { get; set; }
        public DateTime? DtEsito { get; set; }
        public string Note { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? IdRetevendita { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtInvioEmail { get; set; }
        public string NoteRichiesta { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
