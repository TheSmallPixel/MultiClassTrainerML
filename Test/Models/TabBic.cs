using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabBic
    {
        public int IdBic { get; set; }
        public int IdAbi { get; set; }
        public int IdCab { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string CodBicSwift { get; set; }
    }
}
