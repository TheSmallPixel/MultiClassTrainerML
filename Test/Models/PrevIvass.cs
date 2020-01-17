using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrevIvass
    {
        public int IdPrevIvass { get; set; }
        public int? IdPolizza { get; set; }
        public DateTime? DtSysRichiesta { get; set; }
        public string XmlRichiesta { get; set; }
        public string Errori { get; set; }
    }
}
