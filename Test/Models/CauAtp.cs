using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CauAtp
    {
        public int KeyAtp { get; set; }
        public int IdAtp { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int Protocollo { get; set; }
        public DateTime DtRegistrazione { get; set; }
        public string FlgTipoDannoAtp { get; set; }
        public string FlgMotivoAtp { get; set; }
        public int? IdFiduciarioAccertamento { get; set; }
        public DateTime DtAccertamento { get; set; }
        public string NoteAccertamento { get; set; }
        public DateTime? DtEsito { get; set; }
        public string FlgTipologiaEsitoAtp { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdLegaleIncaricato { get; set; }
        public DateTime? DtNotifica { get; set; }
        public string FlgStatoAtp { get; set; }
    }
}
