using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolContraenti
    {
        public decimal KeyPolContraente { get; set; }
        public decimal? IdPolContraente { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string FlgPredefinitoSino { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgMezzoSpedizionePolizza { get; set; }
        public int? IdRecapito { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
