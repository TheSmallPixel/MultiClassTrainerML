using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDatiAggDocumentale
    {
        public int KeyDatiAggDocumentale { get; set; }
        public int IdDatiAggDocumentale { get; set; }
        public int? IdAllegato { get; set; }
        public string FlgUfficio { get; set; }
        public int? IdUtente { get; set; }
        public string FlgStatoDocumento { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public DateTime? DataTimbro { get; set; }
        public int? IdIspettorato { get; set; }
        public int? IdUtenteDestinatario { get; set; }
        public int? IdLiquidatore { get; set; }
        public int? NumeroFirme { get; set; }
        public string Note { get; set; }
        public string NumeroSinistro { get; set; }
        public string FlgMacrotipologia { get; set; }
        public string FlgMicrotipologia { get; set; }
        public DateTime? DataCambioStato { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public string TipoOrigine { get; set; }
        public string RilascioDocumentoSino { get; set; }
        public string OriginaleSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string RecordInviato { get; set; }
    }
}
