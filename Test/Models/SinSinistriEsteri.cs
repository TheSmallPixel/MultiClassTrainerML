using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistriEsteri
    {
        public int KeySinistroestero { get; set; }
        public int IdSinistroestero { get; set; }
        public int? IdCompagniaMand { get; set; }
        public string NumRiferimentoUci { get; set; }
        public string NumSinistroMandante { get; set; }
        public string NoteSinistro { get; set; }
        public string FlgRisultanteDa { get; set; }
        public string NoteRisultanteDa { get; set; }
        public string FlgCopertura { get; set; }
        public DateTime? DtRichiestaMandante { get; set; }
        public DateTime? DtRispostaMandante { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtSollecito { get; set; }
        public DateTime? DtRicRichiestaUci { get; set; }
    }
}
