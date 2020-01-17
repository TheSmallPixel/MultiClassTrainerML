using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BpScartiEurop
    {
        public int IdBpScartoEurop { get; set; }
        public int? IdBpFlusso { get; set; }
        public int? IdBpFlussoDett { get; set; }
        public string FlgStato { get; set; }
        public string TestataInviata { get; set; }
        public string RecordInviato { get; set; }
        public string Codice { get; set; }
        public string DescrizioneErrore { get; set; }
    }
}
