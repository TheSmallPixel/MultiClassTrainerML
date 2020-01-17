using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolVariabili
    {
        public decimal KeyPolVariabile { get; set; }
        public decimal? IdPolVariabile { get; set; }
        public string FlgTipoEntitaVar { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? IdElencoValore { get; set; }
        public string ValoreStringa { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public DateTime? ValoreData { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
