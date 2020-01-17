using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRelazioniFlussi
    {
        public int IdArcRelazioniFlussi { get; set; }
        public string FlgTipoFlusso { get; set; }
        public string IdentificativoEsterno { get; set; }
        public int IdOggettoWise { get; set; }
        public int IdCompagnia { get; set; }
    }
}
