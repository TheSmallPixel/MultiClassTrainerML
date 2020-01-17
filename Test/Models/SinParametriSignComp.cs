using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinParametriSignComp
    {
        public int KeySinParametroSignComp { get; set; }
        public int IdSinParametroSignComp { get; set; }
        public int IdSinistro { get; set; }
        public int IdOggetto { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgIndiceSignificativita { get; set; }
        public int? ValoreIndiceSignificativita { get; set; }
        public string IdentificativoVeicolo { get; set; }
        public string IdentificativoPersona { get; set; }
        public string IdentificativoPolizza { get; set; }
        public DateTime? DtPrimaElaborazione { get; set; }
        public DateTime? DtUltimaVariazione { get; set; }
    }
}
