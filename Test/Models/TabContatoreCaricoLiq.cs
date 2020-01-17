using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabContatoreCaricoLiq
    {
        public int IdContatoreCaricoLiq { get; set; }
        public int IdCanalizzazioneLiq { get; set; }
        public int? IdIspettorato { get; set; }
        public int IdLiquidatore { get; set; }
        public int? Numero { get; set; }
    }
}
