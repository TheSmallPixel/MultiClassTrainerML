using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RuoliReteAgePag
    {
        public int IdRuoloReteAgePag { get; set; }
        public int IdRuoloRete { get; set; }
        public int IdRetevendita { get; set; }
        public DateTime DtDal { get; set; }
        public DateTime DtAl { get; set; }
        public string Note { get; set; }
    }
}
