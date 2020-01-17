using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinCinquineCard
    {
        public decimal KeyCinquinaCard { get; set; }
        public decimal IdCinquinaCard { get; set; }
        public decimal IdSinistro { get; set; }
        public string CodiceCompPolizza { get; set; }
        public string TargaPolizza { get; set; }
        public string TargaAniaPolizza { get; set; }
        public string CodiceCompCtp { get; set; }
        public string TargaCtp { get; set; }
        public string TargaAniaCtp { get; set; }
        public DateTime DtAccadimento { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
