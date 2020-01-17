using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinReiezione
    {
        public int KeyReiezione { get; set; }
        public int IdReiezione { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdDanno { get; set; }
        public string FlgTipoDanno { get; set; }
        public DateTime? DtReiezione { get; set; }
        public DateTime? DtScadenza { get; set; }
        public string FlgTipoReiezione { get; set; }
        public string FlgStatoReiezione { get; set; }
        public string FlgCausaleChiusReiezione { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdUtenteCreazione { get; set; }
        public int? IdUtenteChiusura { get; set; }
        public string FlgMotivoReiezione { get; set; }
        public string Note { get; set; }
    }
}
