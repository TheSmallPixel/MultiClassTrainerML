using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaPrivacy
    {
        public decimal KeyDatiprivacy { get; set; }
        public decimal? IdDatiprivacy { get; set; }
        public string FlgConsensoDati { get; set; }
        public string FlgConsensoDatiSensibili { get; set; }
        public string FlgConsensoFiniCommerciali { get; set; }
        public DateTime? DtConsenso { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgConsensoFirmaGrafoSino { get; set; }
        public string FlgRevocaFirmaGrafoSino { get; set; }
    }
}
