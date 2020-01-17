using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RuoliReteCarriera
    {
        public int IdRuoloReteCarriera { get; set; }
        public int IdRuoloRete { get; set; }
        public int IdLivelloCarriera { get; set; }
        public int IdCausale { get; set; }
        public DateTime? DtInizioPiano { get; set; }
        public DateTime DtDal { get; set; }
        public DateTime DtAl { get; set; }
        public string Note { get; set; }

        public virtual TabLivelliCarriera IdLivelloCarrieraNavigation { get; set; }
    }
}
