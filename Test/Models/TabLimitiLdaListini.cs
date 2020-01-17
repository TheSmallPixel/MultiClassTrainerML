using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLimitiLdaListini
    {
        public int IdLimiteLdaListino { get; set; }
        public int? IdListino { get; set; }
        public string FlgRamoTecnico { get; set; }
        public decimal? Importo { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
    }
}
