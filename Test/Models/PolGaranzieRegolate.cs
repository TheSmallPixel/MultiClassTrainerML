using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolGaranzieRegolate
    {
        public decimal KeyPolGaranziaRegolata { get; set; }
        public decimal IdPolGaranziaRegolata { get; set; }
        public decimal? IdPolRegPremio { get; set; }
        public decimal DatoConsuntivo { get; set; }
        public string Note { get; set; }
        public decimal IdPolGaranzia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolGaranzie IdPolGaranziaNavigation { get; set; }
        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
