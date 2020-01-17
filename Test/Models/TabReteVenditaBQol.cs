using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaBQol
    {
        public decimal IdRetevenditaBQol { get; set; }
        public string CodGestione { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string Note { get; set; }
        public DateTime? DtAgg { get; set; }
        public decimal? IdUtenteAgg { get; set; }
        public DateTime? DtRichiesta { get; set; }
        public decimal? IdUtenteRichiesta { get; set; }
        public decimal? IdRetevendita { get; set; }
        public string FlgBloccoQuietanzeSino { get; set; }
    }
}
