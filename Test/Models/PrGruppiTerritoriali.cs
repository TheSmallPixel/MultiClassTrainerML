using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGruppiTerritoriali
    {
        public decimal KeyPrGruppoTerritoriale { get; set; }
        public decimal IdPrGruppoTerritoriale { get; set; }
        public string CodGruppo { get; set; }
        public decimal? IdDescGruppo { get; set; }
        public decimal? ImpGruppo { get; set; }
        public decimal? CoefGruppo { get; set; }
        public decimal? PuntiGruppo { get; set; }
        public decimal IdUtente { get; set; }
        public decimal IdPrGarTariffa { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public string FlgAmmessoSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescGruppo { get; set; }
        public string FlgTargaSpecSino { get; set; }
    }
}
