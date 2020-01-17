using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaConticorrenti
    {
        public decimal KeyContocorrente { get; set; }
        public decimal IdContocorrente { get; set; }
        public decimal IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public decimal? IdNazione { get; set; }
        public decimal? CinIban { get; set; }
        public string Cin { get; set; }
        public decimal? IdAbi { get; set; }
        public decimal? IdCab { get; set; }
        public string NConto { get; set; }
        public string FlgTipologiaConto { get; set; }
        public string Intestazione { get; set; }
        public string FlgPrincipaleSino { get; set; }
        public decimal? IdFidejussione { get; set; }
        public string FlgQuietanzamentoSino { get; set; }
        public string Note { get; set; }
        public DateTime? DtApertura { get; set; }
        public DateTime? DtChiusura { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgNoIbanSino { get; set; }
        public string Iban { get; set; }
    }
}
