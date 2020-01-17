using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMalattiaLa
    {
        public int KeyMalattiaLa { get; set; }
        public int IdMalattiaLa { get; set; }
        public string CodiceLa { get; set; }
        public string DescrizioneLa { get; set; }
        public string FlgNonRimborsabileSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgObbligoFatturaSino { get; set; }
        public string FlgTestoQuietanza { get; set; }
    }
}
