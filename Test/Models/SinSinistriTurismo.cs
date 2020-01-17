using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistriTurismo
    {
        public int KeySinistroturismo { get; set; }
        public int IdSinistroturismo { get; set; }
        public int IdSinistro { get; set; }
        public string FlgMotAnnullamento { get; set; }
        public DateTime? DtPrenotViaggio { get; set; }
        public DateTime? DtInizioViaggio { get; set; }
        public DateTime? DtRientroViaggio { get; set; }
        public string NoteMotAnnullamento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
