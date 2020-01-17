using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinMalattiaTrattamenti
    {
        public int KeyMalattiatrattamento { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public DateTime? DtInizioTrattamento { get; set; }
        public DateTime? DtFineTrattamento { get; set; }
        public string FlgTipoTrattamento { get; set; }
        public string FlgTipoEvento { get; set; }
        public int? IdOspedale { get; set; }
        public string Note { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgStatoTrattamento { get; set; }
        public int? IdIndennizzo { get; set; }
        public int? IdQuietanza { get; set; }
        public int? IdAnagrafica { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgStrutturaPrivataSino { get; set; }
        public DateTime? DtStato { get; set; }
        public int? IdNazione { get; set; }
        public string FlgOspedaleEsteroSino { get; set; }
        public string FlgTicketSino { get; set; }
    }
}
