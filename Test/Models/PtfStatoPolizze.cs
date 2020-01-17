using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfStatoPolizze
    {
        public decimal IdStatoPolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal AnnoCompetenza { get; set; }
        public decimal MeseCompetenza { get; set; }
        public decimal KeyPolEvento { get; set; }
        public decimal IdPolizza { get; set; }
        public string FlgStatoContratto { get; set; }
        public DateTime? DataCompetenza { get; set; }
        public string FlgAnnSostSino { get; set; }
    }
}
