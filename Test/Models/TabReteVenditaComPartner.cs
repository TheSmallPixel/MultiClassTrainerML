using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaComPartner
    {
        public int KeyRetevenditaComPartner { get; set; }
        public int IdRetevenditaComPartner { get; set; }
        public string FlgTipoPartnership { get; set; }
        public string FlgTipoPartner { get; set; }
        public string FlgAdesioneMandatoSino { get; set; }
        public DateTime? DtAggAdesioneMandato { get; set; }
        public DateTime? DtAperturaPartnership { get; set; }
        public DateTime? DtChiusuraPartnership { get; set; }
        public string FlgCausaleRevocaMandato { get; set; }
        public string FlgRevocaPostChiuGestSino { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
