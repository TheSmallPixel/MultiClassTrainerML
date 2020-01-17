using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinMalattiaFatture
    {
        public int KeyMalattiafattura { get; set; }
        public int IdMalattiafattura { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public string NumeroFattura { get; set; }
        public DateTime? DtFattura { get; set; }
        public int? IdAnagrafica { get; set; }
        public string FlgTipoPrestMalattia { get; set; }
        public int? IdValuta { get; set; }
        public decimal? ImpCambio { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgFittiziaSino { get; set; }
        public string FlgFatturaSenzaDatiSino { get; set; }
        public DateTime? DtInvioAnagrafeTributaria { get; set; }
        public string FlgRichiediBersaniSino { get; set; }
        public string FlgTipoDocPratica { get; set; }
        public decimal? ImpBollo { get; set; }
        public string FlgIntestatario { get; set; }
        public string FlgProformaSino { get; set; }
        public string FlgModPagamento { get; set; }
        public string FlgEsteraSino { get; set; }
    }
}
