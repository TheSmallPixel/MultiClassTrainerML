using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RuoliReteCarrieraProp
    {
        public int IdRuoloReteCarrieraProp { get; set; }
        public DateTime? DtLivello { get; set; }
        public string CodiceFiscaleDp2 { get; set; }
        public DateTime? DtInizioPiano { get; set; }
        public string FlgStatoPropostaMovCar { get; set; }
        public int? IdRuoloReteRif { get; set; }
        public int? IdCarrieraRif { get; set; }
        public int? IdCausale { get; set; }
        public int? IdRuoloReteFlussiCarrProp { get; set; }
        public string CodLivello { get; set; }
        public DateTime? DtStampaLettera { get; set; }
    }
}
