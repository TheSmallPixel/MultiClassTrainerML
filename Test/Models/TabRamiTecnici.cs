using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRamiTecnici
    {
        public int IdRamoTecnico { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string DescrizioneRamo { get; set; }
        public int? DurataMassimaRiservaCose { get; set; }
        public string FlgProntaLiquidazioneSino { get; set; }
        public int? DurataMassimaRiservaPers { get; set; }
        public string BloccoAllegatiAgenzia { get; set; }
        public int? DurataMaxRisCoseDefault { get; set; }
        public int? DurataMaxRisPersDefault { get; set; }
        public string FlgPortaleDefault { get; set; }
        public string FlgMalattiaSino { get; set; }
    }
}
