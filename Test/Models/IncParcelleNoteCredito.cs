using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncParcelleNoteCredito
    {
        public int KeyParcellaNotaCredito { get; set; }
        public int IdParcellaNotaCredito { get; set; }
        public int IdSpesa { get; set; }
        public int? IdSpesaStorno { get; set; }
        public int? IdSpesaRiemessa { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdIncarico { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdParcella { get; set; }
        public string FlgMotivoStorno { get; set; }
        public string FlgRiemettiSpesaSino { get; set; }
        public DateTime DtStorno { get; set; }
    }
}
