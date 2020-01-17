using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrZoneTerritoriali
    {
        public decimal KeyPrZonaTerritoriale { get; set; }
        public decimal? IdPrZonaTerritoriale { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdNazione { get; set; }
        public decimal? IdProvincia { get; set; }
        public decimal? IdComune { get; set; }
        public string Cap { get; set; }
        public decimal? IdPrGruppoTerritoriale { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgSiglaTargaSpec { get; set; }
    }
}
