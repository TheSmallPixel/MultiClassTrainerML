using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EstSinistriDett
    {
        public decimal IdEstrazioneDett { get; set; }
        public string CodTipoEntita { get; set; }
        public decimal? IdEntita { get; set; }
        public string ChiaveInviata { get; set; }
        public decimal? IdEstrazione { get; set; }
        public string RecordEstratto { get; set; }
        public int? PrgRecordInviato { get; set; }
        public decimal? IdEntitaCoinvolta { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdOggetto { get; set; }
        public string NominativoRif { get; set; }
        public string CodFiscaleRif { get; set; }
        public string PartitaIvaRif { get; set; }
        public string TargaRif { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
