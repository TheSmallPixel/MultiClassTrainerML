using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabClassificazioniStatiCard
    {
        public int IdClassificazioneStatoCard { get; set; }
        public int IdStatoCard { get; set; }
        public string FlgClassificazione { get; set; }
        public string Descrizione { get; set; }
    }
}
