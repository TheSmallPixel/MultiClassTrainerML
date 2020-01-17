using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MsaGaranzieRiep
    {
        public int IdMsaGaranziaRiep { get; set; }
        public DateTime? DtElaborazione { get; set; }
        public int? PrgElaborazione { get; set; }
        public string TimestampElaborazione { get; set; }
        public string FlgInviatoSino { get; set; }
    }
}
