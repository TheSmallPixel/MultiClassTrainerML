using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAnaValoriTipi
    {
        public decimal IdValoreTipo { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdRuoloAnagrafica { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public string NomeCampoAnagrafica { get; set; }
        public string ValoreCampoAnagrafica { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public string FlgPresenzaMultiplaSino { get; set; }
        public string FlgDisabilitatoSino { get; set; }
    }
}
