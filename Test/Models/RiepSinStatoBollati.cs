using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RiepSinStatoBollati
    {
        public decimal IdStatoBollato { get; set; }
        public decimal MeseBollato { get; set; }
        public decimal AnnoBollato { get; set; }
        public string FlgTipoBollato { get; set; }
        public string FlgStatoBollato { get; set; }
        public string Note { get; set; }
        public DateTime DtStampaRistampaBollato { get; set; }
        public decimal IdCompagnia { get; set; }
        public DateTime DtBollatoCompleta { get; set; }
    }
}
