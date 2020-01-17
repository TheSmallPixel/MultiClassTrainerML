using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IperFlussoErr
    {
        public int KeyFlussoIperErr { get; set; }
        public int IdFlussoIperErr { get; set; }
        public int IdFlussoIperDett { get; set; }
        public string CodErr { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
