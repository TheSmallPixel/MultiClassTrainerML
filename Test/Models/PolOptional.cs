using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolOptional
    {
        public decimal KeyPolOptional { get; set; }
        public decimal? IdPolOptional { get; set; }
        public decimal? IdPolVeicolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public string FlgTipoOptional { get; set; }
        public string Descrizione { get; set; }
        public decimal? ImpOptional { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string CodqrtInfocar { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
