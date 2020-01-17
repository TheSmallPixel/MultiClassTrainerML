using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabScadenzeStatiOggetto
    {
        public int IdScadenzaStatoOggetto { get; set; }
        public int IdStatoOggetto { get; set; }
        public int NGiorniInizioScadenza { get; set; }
        public int NGiorniFineScadenza { get; set; }
        public string FlgLivelloScadenza { get; set; }
        public string FlgSpuntaManualeSino { get; set; }
        public string FlgRitrosoSino { get; set; }
        public string FlgTipologiaCruscotto { get; set; }
        public string FlgForzaScadenzaSino { get; set; }
    }
}
