using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoDisposizioni
    {
        public int IdDisposizione { get; set; }
        public string RifOggetto { get; set; }
        public string FlgTipoOggDisp { get; set; }
        public string CodRiferimento { get; set; }
        public string FlgStatoDisp { get; set; }
        public string Note { get; set; }
        public DateTime DtStato { get; set; }
        public string Errore { get; set; }
        public int? IdDistinta { get; set; }
        public int? IdIspettorato { get; set; }
        public decimal? Importo { get; set; }
        public string FlgAnnullataSino { get; set; }
        public string FlgPresaVisioneSino { get; set; }
        public int? IdIndirizzo { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdContocorrenteBenef { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string FlgTipoCodRiferimento { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public DateTime? DtEmessoBanca { get; set; }
        public DateTime? DtPagamentoBanca { get; set; }
        public DateTime? DtStornoBanca { get; set; }
        public int? IdValuta { get; set; }
        public string CodRamoProdotto { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
    }
}
