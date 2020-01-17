using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiDisposizioni
    {
        public decimal IdDisposizione { get; set; }
        public string RifOggetto { get; set; }
        public string FlgTipoOggDisp { get; set; }
        public string CodRiferimento { get; set; }
        public string FlgStatoDisp { get; set; }
        public string Note { get; set; }
        public DateTime DtStato { get; set; }
        public string Errore { get; set; }
        public decimal? IdDistinta { get; set; }
        public decimal? IdIspettorato { get; set; }
        public decimal? Importo { get; set; }
        public string FlgAnnullataSino { get; set; }
        public string FlgPresaVisioneSino { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdContocorrenteBenef { get; set; }
        public DateTime? DtPagamento { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoCodRiferimento { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public DateTime? DtEmessoBanca { get; set; }
        public DateTime? DtPagamentoBanca { get; set; }
        public DateTime? DtStornoBanca { get; set; }
        public int? IdValuta { get; set; }
        public string CodRamoProdotto { get; set; }

        public virtual CbiDistinte IdDistintaNavigation { get; set; }
    }
}
