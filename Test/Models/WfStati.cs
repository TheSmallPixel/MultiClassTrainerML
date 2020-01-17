using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfStati
    {
        public decimal IdStato { get; set; }
        public decimal? IdOggetto { get; set; }
        public DateTime? DtInizioStato { get; set; }
        public DateTime? DtFineStato { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdSinistro { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoStato { get; set; }
        public string FlgUltimoStatoSino { get; set; }
        public decimal? IdIspettorato { get; set; }
        public decimal? IdLiquidatore { get; set; }
        public decimal? IdFiduciario { get; set; }
    }
}
