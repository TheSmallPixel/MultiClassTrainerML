using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolRischioImpiego
    {
        public decimal KeyPolRischioImpiego { get; set; }
        public decimal IdPolRischioImpiego { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdPolAssicurato { get; set; }
        public decimal? ImpLordoMensile { get; set; }
        public decimal? ImpTfr { get; set; }
        public decimal? IdAnagraficaMand { get; set; }
        public string FlgDelegaSino { get; set; }
        public string FlgVisitaMedicaSino { get; set; }
        public decimal? AnzianitaServizio { get; set; }
        public decimal? NumeroQuote { get; set; }
        public decimal? ImpQuota { get; set; }
        public DateTime? DtAssunzione { get; set; }
        public string FlgCoesistenza { get; set; }
        public decimal? ImpCoesistenza { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdAnagraficaDebitore { get; set; }
        public decimal? IdAnagraficaPropCredito { get; set; }
        public decimal? ImpTfrFondo { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
