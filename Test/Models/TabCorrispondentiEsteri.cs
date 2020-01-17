using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCorrispondentiEsteri
    {
        public int IdCorrispondenteestero { get; set; }
        public string CodCorrispondenteEstero { get; set; }
        public int IdAnagraficaCorrEstero { get; set; }
        public DateTime DtInizioRapporto { get; set; }
        public DateTime DtFineRapporto { get; set; }
    }
}
