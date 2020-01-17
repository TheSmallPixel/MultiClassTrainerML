using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCanalizzazioneLiq
    {
        public int IdCanalizzazioneLiq { get; set; }
        public int? IdIspettorato { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public int? IdRetevendita { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string FlgTipoSinistroCanaliz { get; set; }
        public int? IdLiquidatore { get; set; }
        public decimal? PercentualeDiCarico { get; set; }
        public int? IdProvincia { get; set; }
        public string CodGruppoFormula { get; set; }
    }
}
