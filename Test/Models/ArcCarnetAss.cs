using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcCarnetAss
    {
        public int IdCarnetAss { get; set; }
        public int IdCompagnia { get; set; }
        public string FlgTipoCarnet { get; set; }
        public DateTime DtCaricoIsp { get; set; }
        public DateTime? DtAssLiqFid { get; set; }
        public int IdContocorrente { get; set; }
        public int IdIspettorato { get; set; }
        public int? IdLiquidatore { get; set; }
        public int? IdFiduciario { get; set; }
        public string FlgTaglioAss { get; set; }
    }
}
