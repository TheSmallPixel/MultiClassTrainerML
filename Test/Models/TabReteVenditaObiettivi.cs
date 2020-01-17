using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaObiettivi
    {
        public int IdObiettivo { get; set; }
        public int? IdRetevendita { get; set; }
        public decimal? AnnoIncentivazione { get; set; }
        public string FlgClusterProvvigionale { get; set; }
        public decimal? PremiNonMotor { get; set; }
        public decimal? PremiAnnui { get; set; }
        public decimal? PremiUnici { get; set; }
        public decimal? VersamentiIntegrativi { get; set; }
        public decimal? QuietanzeIncassate { get; set; }
        public string FlgStampaSino { get; set; }
        public string FlgPartecipazioneSino { get; set; }
        public string FlgAltriIstitutiSino { get; set; }
        public DateTime? DtInserimento { get; set; }
        public DateTime? DtAggiornamento { get; set; }
        public DateTime? DtCancellazione { get; set; }
        public int? IdUtenteInserimento { get; set; }
        public int? IdUtenteAggiornamento { get; set; }
        public string FlgValidoSino { get; set; }
    }
}
