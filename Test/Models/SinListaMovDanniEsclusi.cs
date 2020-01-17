using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinListaMovDanniEsclusi
    {
        public int KeySinListaMovDanniEscl { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdPartita { get; set; }
        public int? IdDanno { get; set; }
        public string FlgTipoGestione { get; set; }
        public string FlgTipoDannoRegulation { get; set; }
        public string CodConvenzione { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public DateTime? DtPervenimento { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public string FlgTpMovimento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string ProgMovimento { get; set; }
        public string FlgStorno { get; set; }
        public string FlgCausa { get; set; }
        public decimal? ImpMovimento { get; set; }
        public string EstremiBeneficiario { get; set; }
        public string EstremiPartita { get; set; }
        public string CodCompagniaCtp { get; set; }
        public string FlgTipoSpesa { get; set; }
    }
}
