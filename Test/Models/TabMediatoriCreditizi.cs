using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMediatoriCreditizi
    {
        public decimal IdMediatorecreditizio { get; set; }
        public string NumeroIscrizione { get; set; }
        public DateTime DtIscrizione { get; set; }
        public DateTime? DtSospensione { get; set; }
        public DateTime? DtCessazione { get; set; }
        public decimal IdAnagrafica { get; set; }
    }
}
