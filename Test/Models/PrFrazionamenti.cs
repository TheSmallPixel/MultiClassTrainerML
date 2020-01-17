using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrFrazionamenti
    {
        public decimal KeyPrFrazionamento { get; set; }
        public decimal? IdPrFrazionamento { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string CodFraz { get; set; }
        public decimal? IdDescFrazionamento { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? PctInteressi { get; set; }
        public string FlgVitaSino { get; set; }
        public decimal? PctInteressiVita { get; set; }
        public decimal? NRate { get; set; }
        public string FlgDanniSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescFrazionamento { get; set; }
    }
}
