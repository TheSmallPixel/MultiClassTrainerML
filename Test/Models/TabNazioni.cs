using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabNazioni
    {
        public decimal IdNazione { get; set; }
        public string CodNazioneIso { get; set; }
        public decimal IdDescrizioneNazione { get; set; }
        public string CodNazioneUic { get; set; }
        public decimal? IdDescrizioneNazionalita { get; set; }
        public string DescrizioneNazione { get; set; }
        public string DescrizioneNazionalita { get; set; }
        public string SiglaAutomobilistica { get; set; }
    }
}
