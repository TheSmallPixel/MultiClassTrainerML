using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinFlussiAdvancingTrade
    {
        public int IdFlussoAdvancingTrade { get; set; }
        public int IdCompagnia { get; set; }
        public int IdSinistro { get; set; }
        public DateTime DtInvio { get; set; }
        public string RecordFlusso { get; set; }
    }
}
