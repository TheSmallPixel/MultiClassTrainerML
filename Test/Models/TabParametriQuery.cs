using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabParametriQuery
    {
        public int IdTabParametriQuery { get; set; }
        public int IdTabQuery { get; set; }
        public int? PrgParametro { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public string ValoreDefault { get; set; }
    }
}
