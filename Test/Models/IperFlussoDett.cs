using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IperFlussoDett
    {
        public int KeyFlussoIperDett { get; set; }
        public int IdFlussoIperDett { get; set; }
        public int IdFlussoIper { get; set; }
        public string Targa { get; set; }
        public DateTime? DtScadPolizza { get; set; }
        public string RecordInput { get; set; }
        public string RecordOutput { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
