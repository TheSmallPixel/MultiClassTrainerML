using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaC2
    {
        public int IdAniaScaC2 { get; set; }
        public int IdAniaScaC { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string ProvinciaAccadimento { get; set; }
        public string IdentSinistroMittente { get; set; }
        public string NomeDanneggiato { get; set; }
        public string CognomeDanneggiato { get; set; }
        public string LuogoNascitaDanneggiato { get; set; }
        public DateTime? DtNascitaDanneggiato { get; set; }
        public string CodFiscaleDanneggiato { get; set; }
        public string FlgSuperaPlafondSino { get; set; }
        public decimal? ImpStimaRiserva { get; set; }
        public int? NumeroVeicCoinvolti { get; set; }
        public string FlgSenzaCoperturaSicSino { get; set; }
        public string FlgSenzaCollisioniSino { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string FlgTipoImporto { get; set; }
        public string FlgTipoPagamento { get; set; }
        public decimal? ImpRichiestoDanno { get; set; }
        public decimal? ImpDanno { get; set; }
        public decimal? ImpRisarcito { get; set; }
        public decimal? ImpRivalsa { get; set; }
        public decimal? ImpDirittiGestione { get; set; }
        public decimal? PercRespControparte { get; set; }
        public decimal? PercRespMittente { get; set; }
        public string FlgTipoVeicRichiedente { get; set; }
    }
}
