using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPolizzeAltriDati
    {
        public decimal KeyPolizzaAltriDati { get; set; }
        public decimal IdPolizzaAltriDati { get; set; }
        public decimal NumeroRate { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string CodConvenzione { get; set; }
        public string DescConvenzione { get; set; }
        public DateTime? DtIniConvenzione { get; set; }
        public DateTime? DtFinConvenzione { get; set; }
        public string FlgAppendiciDerogaSino { get; set; }
        public string Note { get; set; }
        public string CodRiassicurazione1 { get; set; }
        public decimal? PercRiassicurazione1 { get; set; }
        public string CodRiassicurazione2 { get; set; }
        public decimal? PercRiassicurazione2 { get; set; }
        public string FlgDelegaRisImpSino { get; set; }
        public string TestoLiberoPolizza { get; set; }
        public string FlgAppendiciRegolazioneSino { get; set; }
        public decimal? FranchigiaFrontale { get; set; }
        public decimal? Mesi1Esigib { get; set; }
        public decimal? Mesi2Esigib { get; set; }
        public decimal? Mesi3Esigib { get; set; }
        public decimal? Mesi4Esigib { get; set; }
        public decimal? ImpTfr { get; set; }
        public decimal? ImpTfrFondo { get; set; }
        public string FlgApplicazioniSino { get; set; }
    }
}
