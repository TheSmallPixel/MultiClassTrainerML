using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardContrastiInc1f
    {
        public int IdCardContrastoInc1f { get; set; }
        public int? IdCardContrasto1f { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdIncarico { get; set; }
        public int? IdFiduciario { get; set; }
        public DateTime? DtEsitoIncarico { get; set; }
        public string FlgAnnullatoSino { get; set; }
        public string FlgEsitoIncaricoCard2017 { get; set; }
        public DateTime? DtElaborazione { get; set; }
    }
}
