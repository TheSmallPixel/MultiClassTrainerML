using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MsaEstrazioneNoteDiario
    {
        public int IdMsaEstrazioneNotaDiario { get; set; }
        public int IdCompagnia { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int IdNotaDiario { get; set; }
        public DateTime? DtCreazione { get; set; }
        public string Nota { get; set; }
        public string Utente { get; set; }
        public DateTime DtElaborazione { get; set; }
        public string DtScadenza { get; set; }
        public int PrgElaborazioneGiorno { get; set; }
    }
}
