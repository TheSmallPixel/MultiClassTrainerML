using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPercFees
    {
        public int KeyPercFees { get; set; }
        public int IdPercFees { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string FlgRamoBilancio { get; set; }
        public int PercFees { get; set; }
        public decimal? ImpMinimo { get; set; }
        public decimal? ImpMassimo { get; set; }
    }
}
