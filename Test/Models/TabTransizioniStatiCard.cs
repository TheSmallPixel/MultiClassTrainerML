using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTransizioniStatiCard
    {
        public int IdTransizioneStatoCard { get; set; }
        public int IdTransizioneStato { get; set; }
        public string FlgDocumentazAmmessa { get; set; }
        public string FlgRuoloCard { get; set; }
        public string FlgRuoloCard2 { get; set; }
    }
}
