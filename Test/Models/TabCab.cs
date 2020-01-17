using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCab
    {
        public decimal IdCab { get; set; }
        public string CodCab { get; set; }
        public decimal IdAbi { get; set; }
        public string Denominazione { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string Indirizzo { get; set; }
        public string Comune { get; set; }
        public string Cap { get; set; }
        public string Provincia { get; set; }
        public decimal? IdCorporatebanking { get; set; }

        public virtual TabAbi IdAbiNavigation { get; set; }
    }
}
