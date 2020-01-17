using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbForfaitContabile
    {
        public int KeyForfaitContabile { get; set; }
        public int IdForfaitContabile { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdRecupero { get; set; }
        public decimal? Importo { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgTipoConvenzioneAnia { get; set; }
        public string FlgStatoContabile { get; set; }
        public string FlgTipoContoForfait { get; set; }
        public string FlgCausalePagamentoAnia { get; set; }
        public int? IdForfaitContabileAtteso { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
