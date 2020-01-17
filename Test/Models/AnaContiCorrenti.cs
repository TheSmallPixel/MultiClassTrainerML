using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaContiCorrenti
    {
        public decimal KeyContocorrente { get; set; }
        public decimal IdContocorrente { get; set; }
        public string NConto { get; set; }
        public decimal? IdNazione { get; set; }
        public decimal? IdAbi { get; set; }
        public decimal? IdCab { get; set; }
        public decimal? IdUtente { get; set; }
        public string Cin { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? CinIban { get; set; }
        public string Iban { get; set; }
        public string CodSia { get; set; }
        public string FlgAbilitazioneCc { get; set; }
        public int? IdBic { get; set; }
        public string Intestatario { get; set; }
        public string Note { get; set; }
        public string CodCuc { get; set; }
        public int? IdAnaCommissioniCc { get; set; }
        public string CodCid { get; set; }
    }
}
