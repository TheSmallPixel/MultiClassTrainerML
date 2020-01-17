using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitTitoli
    {
        public decimal KeyTitTitolo { get; set; }
        public decimal? IdTitTitolo { get; set; }
        public decimal KeyPolEvento { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdAgenzia { get; set; }
        public decimal IdTitTipoTitolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public string NPolizza { get; set; }
        public string NProposta { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtCopertura { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string FlgStatoTitolo { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public string FlgModProv { get; set; }
        public decimal? ImpLordo { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpProvAcquisto { get; set; }
        public decimal? ImpProvIncasso { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? CompetenzaEmesso { get; set; }
        public DateTime? DtSysEmesso { get; set; }
        public string FlgCondizioneTitolo { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public DateTime? DtProdotto { get; set; }
        public string NRifEsterno { get; set; }
        public decimal? ImpLordo100 { get; set; }
        public string ProvCalcoloTasseRca { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }
        public int? IdPnaFranchigiaAgg { get; set; }
        public int? PrgAppendice { get; set; }
        public DateTime? DtComunicazioneCop { get; set; }
        public int? IdTitRateDati { get; set; }
        public DateTime? DtStato { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public string FlgSistemaProvenienza { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
        public virtual TitTipoTitolo IdTitTipoTitoloNavigation { get; set; }
        public virtual PolEventi KeyPolEventoNavigation { get; set; }
    }
}
