using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabStatiOperazioni
    {
        public int IdStatoOperazione { get; set; }
        public int IdTipoOggetto { get; set; }
        public string Descrizione { get; set; }
        public string FlgAttivaSino { get; set; }
        public string FlgObbligatorietaNote { get; set; }
        public int? IdFunzione { get; set; }
        public string Url { get; set; }
    }
}
