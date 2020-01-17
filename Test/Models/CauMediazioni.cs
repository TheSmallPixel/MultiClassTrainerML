using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CauMediazioni
    {
        public int KeyMediazione { get; set; }
        public int IdMediazione { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTipoMediazione { get; set; }
        public int? Protocollo { get; set; }
        public DateTime? DtNotifica { get; set; }
        public DateTime? DtRichiesta { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public DateTime? DtMediazione { get; set; }
        public DateTime? DtScadenza { get; set; }
        public int? IdIndirizzo { get; set; }
        public int? IdOrganismoMediazione { get; set; }
        public int? IdUtenteMediatore { get; set; }
        public int? IdFiduciarioMediatore { get; set; }
        public decimal? ValoreCose { get; set; }
        public decimal? ValoreLesioni { get; set; }
        public decimal? ValoreVeicolo { get; set; }
        public string FlgStatoMediazione { get; set; }
        public DateTime? DtIncontro { get; set; }
        public int? IdIncarico { get; set; }
        public decimal? CostoPratica { get; set; }
        public DateTime? DtEsito { get; set; }
        public string FlgEsitoMediazione { get; set; }
        public string Note { get; set; }
        public int? IdValuta { get; set; }
        public string FlgAnnullataSino { get; set; }
    }
}
