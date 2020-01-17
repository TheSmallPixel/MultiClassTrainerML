using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AntifrodeNoSinistro
    {
        public int KeyAntifrodeNoSin { get; set; }
        public int IdAntifrodeNoSin { get; set; }
        public DateTime? DtEvento { get; set; }
        public string Targa { get; set; }
        public string NPolizza { get; set; }
        public int? IdSinistro { get; set; }
        public string NSinistro { get; set; }
        public string FlgEntePrimaSegnalazione { get; set; }
        public int? IdCslRadicamento { get; set; }
        public DateTime? DtPrimaSegnalazione { get; set; }
        public string FlgTriage { get; set; }
        public string FlgSinistroFantasmaSino { get; set; }
        public string FlgSinistroSerialeSino { get; set; }
        public string SinistroSerialeNote { get; set; }
        public string NoteInvestigazioni { get; set; }
        public DateTime? DtInvestigazione { get; set; }
        public decimal? ImpInvestigazioni { get; set; }
        public string FlgParteOffesa { get; set; }
        public string FlgParteCivile { get; set; }
        public int? NumeroParti { get; set; }
        public int IdCompagnia { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string TipoEsito { get; set; }
        public string AnnoEsito { get; set; }
    }
}
