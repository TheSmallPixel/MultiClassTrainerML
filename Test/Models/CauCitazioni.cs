using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CauCitazioni
    {
        public decimal KeyCitazione { get; set; }
        public decimal IdCitazione { get; set; }
        public decimal? IdAttore { get; set; }
        public decimal? IdLegale { get; set; }
        public DateTime DtNotificaCitazione { get; set; }
        public DateTime DtRegistrazioneCitazione { get; set; }
        public DateTime? DtEsitoCitazione { get; set; }
        public string NoteCitazione { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgEsitoCitazione { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public decimal? IdIncarico { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal? Protocollo { get; set; }
        public DateTime? DtUdienza { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public string FlgTipoCuria { get; set; }
        public string DannoCoseSino { get; set; }
        public string DannoLesioniSino { get; set; }
        public string DannoVeicoloSino { get; set; }
        public decimal? ImpPetitumCose { get; set; }
        public decimal? ImpPetitumLesioni { get; set; }
        public decimal? ImpPetitumVeicolo { get; set; }
        public string FlgPetitumIndSino { get; set; }
        public string FlgStatoCitazione { get; set; }
        public int? IdAntifrodeNoSin { get; set; }
        public string FlgContenziosoRcSino { get; set; }
    }
}
