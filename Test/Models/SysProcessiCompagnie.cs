using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysProcessiCompagnie
    {
        public decimal IdProcessoCompagnia { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdProcesso { get; set; }
        public string HhmmDal { get; set; }
        public string HhmmAl { get; set; }
        public DateTime? DtUltimaElaborazione { get; set; }
        public decimal? TempoMedio { get; set; }
        public decimal? NumeroElaborazioni { get; set; }

        public virtual TabCompagnie IdCompagniaNavigation { get; set; }
        public virtual SysProcessi IdProcessoNavigation { get; set; }
    }
}
