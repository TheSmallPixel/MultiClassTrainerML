using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiBollato
    {
        public int IdTabTipiBollato { get; set; }
        public string DocumentoDaArchiviare { get; set; }
        public string Etichetta { get; set; }
        public string CodModello { get; set; }
        public string MetodoCreazioneDataset { get; set; }
        public string CodBollato { get; set; }
        public string TipoBollato { get; set; }
        public string TipoArea { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
    }
}
