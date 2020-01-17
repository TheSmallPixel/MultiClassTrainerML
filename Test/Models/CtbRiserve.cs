using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbRiserve
    {
        public decimal KeyRiserva { get; set; }
        public decimal IdRiserva { get; set; }
        public decimal ImpRiserva { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgModificaRiserva { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgTipoRiserva { get; set; }
        public string FlgTipoRiserva2 { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public decimal IdSinistro { get; set; }
        public int? IdDeroga { get; set; }
        public string Note { get; set; }
        public int? IdUtenteVariazione { get; set; }
        public int? IdUtenteAutorizzatoreDer { get; set; }
        public DateTime? DtAutorizzazioneDeroga { get; set; }
        public string FlgRiservaDiDefaultSino { get; set; }
        public int? IdDanno { get; set; }
    }
}
