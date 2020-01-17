using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaIbdRichieste
    {
        public int IdRichiestaIbd { get; set; }
        public DateTime DtRichiesta { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int IdCompagnia { get; set; }
        public string TargaAnia { get; set; }
        public string FlgTipoTarga { get; set; }
        public string FlgTipoRichiesta { get; set; }
        public string CodImpMand { get; set; }
        public string CodUser { get; set; }
        public string Password { get; set; }
        public string Canale { get; set; }
        public string RifRichiesta { get; set; }
        public string RifRichiedente { get; set; }
    }
}
