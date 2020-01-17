using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaInterrogazioniSita
    {
        public int IdInterrogazioneSita { get; set; }
        public DateTime? DataInterrogazione { get; set; }
        public string EsitoSita { get; set; }
        public string RecordRicevutoParte1 { get; set; }
        public string RecordRicevutoParte2 { get; set; }
        public int? IdVeicolo { get; set; }
        public string CoperturaSitaSino { get; set; }
    }
}
