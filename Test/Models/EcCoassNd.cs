using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EcCoassNd
    {
        public int IdEcCoassNd { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdOggetto { get; set; }
        public string FlgSelezionatoSino { get; set; }
        public string NumEc { get; set; }
        public DateTime? DtPeriodoEc { get; set; }
        public int? IdRetevendita { get; set; }
        public string FlgDefinitivoSino { get; set; }
        public int? IdCompagniaCoass { get; set; }
        public int? IdTitTipoTitolo { get; set; }
        public string NPolizza { get; set; }
        public string NSinistro { get; set; }
        public decimal? AnnoEsercizio { get; set; }
        public DateTime? DtContabMovimento { get; set; }
        public DateTime? DtRegistrazioneMovimento { get; set; }
        public decimal? PercQuotaCoass { get; set; }
        public decimal? ImpNettoNoDiritti { get; set; }
        public decimal? ImpNettoDiritti { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpImponibile { get; set; }
        public decimal? ImpCommissioni { get; set; }
        public decimal? ImpTot { get; set; }
        public decimal? PercCommissioni { get; set; }
        public decimal? PercIva { get; set; }
        public DateTime? DtPagamentoEc { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
