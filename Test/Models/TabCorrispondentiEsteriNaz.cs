using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCorrispondentiEsteriNaz
    {
        public int IdCorrispondenteesteronazione { get; set; }
        public int IdCorrispondenteestero { get; set; }
        public int IdNazione { get; set; }
        public DateTime DtInizioRapporto { get; set; }
        public DateTime DtFineRapporto { get; set; }
    }
}
