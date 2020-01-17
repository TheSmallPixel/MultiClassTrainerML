using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrdEsitiTardivi
    {
        public int KeyAniaAtrdEsitiTardivi { get; set; }
        public int IdAniaAtrdEsitiTardivi { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string FlgControlloMovimenti { get; set; }
        public string IdentSinistroAnia { get; set; }
        public string TimestampRicezioneAnia { get; set; }
        public DateTime? DtReteAnia { get; set; }
        public int? IdAniaAtrdInvioTardivi { get; set; }
        public string CodErrore { get; set; }
        public string DescrizioneErrore { get; set; }
    }
}
