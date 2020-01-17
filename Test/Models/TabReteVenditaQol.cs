using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaQol
    {
        public decimal IdRetevenditaQol { get; set; }
        public string CodGestione { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string FlgAdesioneQolSino { get; set; }
        public string FlgTipoStampa { get; set; }
        public string NrBollettinoCcp { get; set; }
        public string DescCcp { get; set; }
        public string FlgOrdinamentoQol { get; set; }
        public DateTime? DtAgg { get; set; }
        public decimal? IdUtenteAgg { get; set; }
        public DateTime? DtRichiesta { get; set; }
        public decimal? IdUtenteRichiesta { get; set; }
        public decimal? IdRetevendita { get; set; }
        public string FlgTipoStampaAvvisi { get; set; }
        public string FlgStampaAvvisiSino { get; set; }
    }
}
