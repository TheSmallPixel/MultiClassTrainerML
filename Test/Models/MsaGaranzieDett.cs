using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MsaGaranzieDett
    {
        public int IdMsaGaranziaDett { get; set; }
        public int? IdMsaGaranziaRiep { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string CodGaranzia { get; set; }
        public string DescGaranzia { get; set; }
        public string CodPrestazione { get; set; }
        public string DescPrestazione { get; set; }
        public string CodSottoprestazione { get; set; }
        public string DescSottoprestazione { get; set; }
        public string FlgColpitaSino { get; set; }
        public decimal? ImpRiserva { get; set; }
        public string FlgTipoMovimento { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
