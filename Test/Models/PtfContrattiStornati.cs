using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfContrattiStornati
    {
        public decimal IdRegistroStornati { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? AnnoRegistro { get; set; }
        public decimal? MeseRegistro { get; set; }
        public decimal? KeyPolEvento { get; set; }
        public decimal? IdPolizza { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtRegistrazioneStorno { get; set; }
        public DateTime? DtEffettoStorno { get; set; }
        public DateTime? CompetenzaEmesso { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public string CodStorno { get; set; }
        public string FlgTipoBene { get; set; }
        public decimal? ProgressivoBene { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public string CodfiscPiva { get; set; }
        public string TipoCoass { get; set; }
        public decimal? PercQuota { get; set; }
        public string RamoBilancioPolizza { get; set; }
        public string RamoBilancio { get; set; }
        public decimal? ImportoFirma { get; set; }
        public decimal? ImportoOperazione { get; set; }
        public string FlgOperazioneAnnullataSino { get; set; }
        public DateTime? DtRegStornoOperazione { get; set; }
        public decimal? ContaInteri { get; set; }
        public decimal? ContaQuota { get; set; }
    }
}
