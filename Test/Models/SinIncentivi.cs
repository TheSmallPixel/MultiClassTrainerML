using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinIncentivi
    {
        public int IdIncentivo { get; set; }
        public int? IdSinistro { get; set; }
        public int IdFasciaIncentivo { get; set; }
        public DateTime? DtPeriodoRiferimento { get; set; }
        public DateTime DtInserimento { get; set; }
        public int IdRetevendita { get; set; }
        public DateTime? DtSegnalazioneDatoAnomalo { get; set; }
        public int? IdUtenteSegnalazione { get; set; }
        public decimal? Importo { get; set; }
        public DateTime? DtScarico { get; set; }
    }
}
