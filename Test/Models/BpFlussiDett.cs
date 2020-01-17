using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BpFlussiDett
    {
        public int IdBpFlussoDett { get; set; }
        public int IdBpFlusso { get; set; }
        public int IdCompagnia { get; set; }
        public decimal KeyPolEvento { get; set; }
        public decimal IdPolizza { get; set; }
        public string NPolizza { get; set; }
        public string FlgTipoOperazione { get; set; }
        public string BpRecord { get; set; }
        public int IdUtente { get; set; }
    }
}
