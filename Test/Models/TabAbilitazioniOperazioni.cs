using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAbilitazioniOperazioni
    {
        public int IdAbilitazioneOperazione { get; set; }
        public int IdStatoOperazione { get; set; }
        public int? IdProdotto { get; set; }
        public string FlgRamoBilancio { get; set; }
    }
}
