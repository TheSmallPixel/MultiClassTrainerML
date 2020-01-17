using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCanalizzazionePeriti
    {
        public int IdCanalizzazionePeriti { get; set; }
        public int? IdComune { get; set; }
        public int IdFiduciario { get; set; }
        public string FlgTipoPerizia { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public decimal? PercentualeDiCarico { get; set; }
        public string FlgTipoIncarico { get; set; }
        public int? IdRetevendita { get; set; }
    }
}
