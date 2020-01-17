using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRegoleVendibilitaGar
    {
        public decimal KeyPrRegolaVendibilitaGar { get; set; }
        public decimal? IdPrRegolaVendibilitaGar { get; set; }
        public decimal? IdPrGaranziaA { get; set; }
        public string FlgIncludeEsclude { get; set; }
        public decimal? IdPrGaranziaB { get; set; }
        public decimal? PrgOr { get; set; }
        public string FlgDerogabileSino { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public int? IdPrPacchettoA { get; set; }
        public int? IdPrPacchettoB { get; set; }
        public decimal? CodDeroga { get; set; }
    }
}
