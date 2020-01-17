using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSaldiConvenzioni
    {
        public int KeyAniaSaldoConvenzione { get; set; }
        public int IdAniaSaldoConvenzione { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public decimal? ImportoPagato { get; set; }
        public decimal? ImportoRecuperatoWise { get; set; }
        public decimal? ImportoRecuperatoAnia { get; set; }
        public DateTime? DtUltimoPagamento { get; set; }
        public DateTime? DtUltimoInvio { get; set; }
        public string FlgStatoWise { get; set; }
        public string FlgStatoAnia { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
