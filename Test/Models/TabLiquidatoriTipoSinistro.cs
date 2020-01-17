using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLiquidatoriTipoSinistro
    {
        public int IdLiquidatoreTipoSinistro { get; set; }
        public int IdLiquidatore { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string FlgTipoCard { get; set; }
        public string FlgFirmaCai { get; set; }
    }
}
