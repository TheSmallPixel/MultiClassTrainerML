using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolAttestati
    {
        public int KeyPolAttestato { get; set; }
        public int? IdPolAttestato { get; set; }
        public int? IdPolTestata { get; set; }
        public int? AaEsercizio { get; set; }
        public string FlgStatoAttestato { get; set; }
        public int? NPagatiRespPrincipale { get; set; }
        public int? NPagatiRespConcorsuale { get; set; }
        public int? NPagati { get; set; }
        public int? NRiservatiPersone { get; set; }
        public int? NRiservatiCose { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdPolizza { get; set; }
        public int? DiCuiCosePrinc { get; set; }
        public int? DiCuiPersonePrinc { get; set; }
        public int? DiCuiMistiPrinc { get; set; }
        public int? DiCuiCosePar { get; set; }
        public int? DiCuiPersonePar { get; set; }
        public int? DiCuiMistiPar { get; set; }
    }
}
