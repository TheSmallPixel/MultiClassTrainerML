using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDocumentazioniAmmesse
    {
        public int IdDocumentazioneAmmessa { get; set; }
        public string FlgTipoDocumentazione { get; set; }
        public int? IdTransizioneStatoCard { get; set; }
        public string CodiceRaggruppamento { get; set; }
    }
}
