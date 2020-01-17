using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardContrastiDoc1f
    {
        public int IdCardContrastoDoc1f { get; set; }
        public int? IdCardContrasto1f { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdIncarico { get; set; }
        public int? IdFiduciario { get; set; }
        public string FlgAllegatoCtpSino { get; set; }
        public string FlgTipoDocCard2017 { get; set; }
        public string FlgDenunciaSino { get; set; }
        public string FlgTestimonianzaSino { get; set; }
        public string FlgVerbaleAccSino { get; set; }
        public DateTime? DtInvioAutomatico { get; set; }
        public DateTime? DtElaborazione { get; set; }
        public string FlgInviatoAniaSino { get; set; }
    }
}
