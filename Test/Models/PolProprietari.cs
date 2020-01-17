using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolProprietari
    {
        public decimal KeyPolProprietario { get; set; }
        public decimal? IdPolProprietario { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string FlgPredefinitoSino { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
