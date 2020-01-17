using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcParametriStampaErrori
    {
        public int IdParametroStampaErrore { get; set; }
        public int? IdParametroStampa { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtErrore { get; set; }
    }
}
