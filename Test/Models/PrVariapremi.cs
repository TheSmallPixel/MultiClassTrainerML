using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrVariapremi
    {
        public decimal KeyPrVariapremio { get; set; }
        public decimal? IdPrVariapremio { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodVariapremio { get; set; }
        public decimal? IdDescVariapremio { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public string ValoreParametri { get; set; }
        public decimal? ImpVariazione { get; set; }
        public decimal? CoefVariazione { get; set; }
        public decimal? PuntiVariazione { get; set; }
        public string FlgModificabileSino { get; set; }
        public string FlgTipoValore { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescVariapremio { get; set; }
        public decimal? PerVariazione { get; set; }
    }
}
