using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDatiVeicoli
    {
        public decimal KeyPrDatiVeicolo { get; set; }
        public decimal? IdPrDatiVeicolo { get; set; }
        public decimal? IdPrBene { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgSettoreSino { get; set; }
        public string FlgClasseSino { get; set; }
        public string FlgUsoSino { get; set; }
        public string FlgDataImmSino { get; set; }
        public string FlgFormaTarSino { get; set; }
        public string FlgMotivoAssicSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgCoperturaRcaSino { get; set; }
        public string FlgCoperturaArdSino { get; set; }
        public string FlgCoperturaRcaArdSino { get; set; }
        public int? NumAnniAssicurati { get; set; }
        public int? NumSinAmmessi { get; set; }
        public string FlgDerogaNumSinSino { get; set; }
        public decimal? CodDerogaNumSin { get; set; }
        public string FlgDisabCtrlIbdvSino { get; set; }
    }
}
