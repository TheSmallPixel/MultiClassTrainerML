using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EstSinistri
    {
        public decimal IdEstrazione { get; set; }
        public DateTime? DtEstrazione { get; set; }
        public string CodTipoEstrazione { get; set; }
        public DateTime? DtEstrazioneDal { get; set; }
        public DateTime? DtEstrazioneAl { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodStatoScarico { get; set; }
        public int? NumSinInviati { get; set; }
        public int? NumSinDefinitiInviati { get; set; }
        public int? NumSinErrati { get; set; }
        public int? NumSinDefinitiErrati { get; set; }
        public DateTime? DtRitornoErrori { get; set; }
        public int? IdCompagnia { get; set; }
        public string TimestampEstrazione { get; set; }
        public DateTime? DtElaborazioneIvass { get; set; }
    }
}
