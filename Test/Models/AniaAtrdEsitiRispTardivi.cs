using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrdEsitiRispTardivi
    {
        public int KeyAniaAtrdEsitirispTard { get; set; }
        public int IdAniaAtrdEsitirispTard { get; set; }
        public int? IdAniaAtrdRispTardivi { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string FlgControlloMovimenti { get; set; }
        public string IdentSinistroAnia { get; set; }
        public string TimestampRicezioneAnia { get; set; }
        public DateTime? DtReteAnia { get; set; }
        public string CodErrore { get; set; }
        public string DescrizioneErrore { get; set; }
    }
}
