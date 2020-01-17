using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IperFlussoInput
    {
        public int KeyFlussoIper { get; set; }
        public int IdFlussoIper { get; set; }
        public DateTime? DtFlusso { get; set; }
        public DateTime? DtRisposta { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
