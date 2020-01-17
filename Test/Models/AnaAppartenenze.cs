using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaAppartenenze
    {
        public decimal IdAnaAppartenenza { get; set; }
        public decimal? IdAppartenenza { get; set; }
        public string FlgTipoRuoloUtente { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string FlgAbilitaModificaSino { get; set; }
    }
}
