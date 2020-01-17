using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RegTitoli
    {
        public decimal KeyRegTitolo { get; set; }
        public decimal? IdRegTitolo { get; set; }
        public decimal KeyPolEvento { get; set; }
        public decimal? IdPolizza { get; set; }
        public DateTime? DtEffetto { get; set; }
        public string FlgModProv { get; set; }
        public decimal? ImpLordo { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpProvAcquisto { get; set; }
        public decimal? ImpProvIncasso { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? CompetenzaEmesso { get; set; }
        public DateTime? DtSysEmesso { get; set; }
        public string FlgStatoRegolazione { get; set; }
        public decimal? PrgAppendice { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public int? IdPolBene { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
        public virtual PolEventi KeyPolEventoNavigation { get; set; }
    }
}
