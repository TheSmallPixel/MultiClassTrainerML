using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfOperazioni
    {
        public decimal IdOperazione { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string CodOperazione { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public string Parametri { get; set; }
        public string Modulo { get; set; }
    }
}
