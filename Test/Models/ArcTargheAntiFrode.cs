using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcTargheAntiFrode
    {
        public int KeyTargaAntiFrode { get; set; }
        public int IdTargaAntiFrode { get; set; }
        public int IdCompagnia { get; set; }
        public string FlgTipoTarga { get; set; }
        public string Targa { get; set; }
        public string Telaio { get; set; }
        public string Note { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtScadenza { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
