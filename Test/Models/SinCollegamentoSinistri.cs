using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinCollegamentoSinistri
    {
        public int KeyCollegamentoSinistri { get; set; }
        public int IdCollegamentoSinistri { get; set; }
        public int IdSinistro { get; set; }
        public int IdSinistroCollegato { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Note { get; set; }
        public int IdUtente { get; set; }
    }
}
