using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolBeneficiari
    {
        public decimal KeyPolBeneficiario { get; set; }
        public decimal? IdPolBeneficiario { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgTipoBeneficiario { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTipoAnagBenPtf { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
