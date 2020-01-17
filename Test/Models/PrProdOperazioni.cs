using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrProdOperazioni
    {
        public decimal KeyPrProdOperazione { get; set; }
        public decimal IdPrProdOperazione { get; set; }
        public decimal IdPrProdotto { get; set; }
        public decimal IdTabParametriOperazione { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgCanaleEmissione { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? NGgEmisPostergata { get; set; }
        public int? NGgEmisAntergata { get; set; }
        public string FlgAutorizzazioneSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public string FlgTemplateFeu { get; set; }
    }
}
