using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPromotersVf
    {
        public decimal KeyPromoterVf { get; set; }
        public decimal IdPromoterVf { get; set; }
        public string CodPromoterVf { get; set; }
        public decimal IdAreaCommerciale { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal IdIndirizzo { get; set; }
        public DateTime DtPromoterVfDal { get; set; }
        public string NumTelefono1 { get; set; }
        public string NumTelefono2 { get; set; }
        public string NumTelefono3 { get; set; }
        public string NumSelezioneDiretta { get; set; }
        public string NumFax { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
