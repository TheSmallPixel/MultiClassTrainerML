using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSicRichieste
    {
        public int IdRichiestasic { get; set; }
        public DateTime? DtRichiesta { get; set; }
        public string CodCompDebitrice { get; set; }
        public int? IdSinistro { get; set; }
        public string RecordInvioRichiestaSic { get; set; }
        public string TargaAniaDebitrice { get; set; }
        public int? IdRispostasic { get; set; }
        public int? IdRiferimentoInvio { get; set; }
    }
}
