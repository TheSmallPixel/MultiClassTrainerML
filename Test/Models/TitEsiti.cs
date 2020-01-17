using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitEsiti
    {
        public decimal KeyTitEsito { get; set; }
        public decimal? IdTitEsito { get; set; }
        public decimal? IdTitTitolo { get; set; }
        public string FlgTipoEsito { get; set; }
        public DateTime? DtEsito { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public decimal? IdAgenziaEsito { get; set; }
        public decimal? ImpIncassato { get; set; }
        public DateTime? CompetenzaEsito { get; set; }
        public decimal? IdCntFogliocassa { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtSysEsito { get; set; }
        public decimal? IdTitPagatore { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdAgenziaEmesso { get; set; }
        public string NRifEsterno { get; set; }
        public string FlgEsitoContabileSino { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string HhmmEsito { get; set; }
        public DateTime? DtComunicazioneCop { get; set; }
        public string CausaleRiconciliazione { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public string CausaleRiconciliazioneProv { get; set; }
        public string FlgSistemaProvenienza { get; set; }
    }
}
