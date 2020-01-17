using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinArbitratiCard
    {
        public decimal IdArbitratoCard { get; set; }
        public decimal IdSinistro { get; set; }
        public string FlgTipoComunicazioniArb { get; set; }
        public DateTime? DtCreazione { get; set; }
        public DateTime? DtComunicazione { get; set; }
        public DateTime? DtChiusura { get; set; }
        public string FlgStatoArb { get; set; }
        public string CodAniaImpMit { get; set; }
        public string FlgTipoEsitoArb { get; set; }
        public string FlgTipoEsitoDettArb { get; set; }
        public string RadiceSic { get; set; }
        public string RigaCsvRespOnLineAnia { get; set; }
    }
}
