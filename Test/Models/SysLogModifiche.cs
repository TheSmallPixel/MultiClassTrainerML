using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysLogModifiche
    {
        public DateTime? DtModifica { get; set; }
        public string Tabella { get; set; }
        public string Chiave { get; set; }
        public decimal? IdUtente { get; set; }
        public string ValoreOld { get; set; }
        public string ValoreNew { get; set; }
        public string Campo { get; set; }
    }
}
