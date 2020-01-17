using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiDettLogEsiti
    {
        public decimal IdDettLogEsiti { get; set; }
        public decimal? IdDisposizione { get; set; }
        public decimal IdLogEsiti { get; set; }
        public string FlgStatoEsito { get; set; }
        public string FlgElaborataSino { get; set; }
        public string FlgOkSino { get; set; }
        public string DescErrore { get; set; }
        public string Record10 { get; set; }
        public string Record20 { get; set; }
        public string Record30 { get; set; }
        public string Record70 { get; set; }
        public DateTime? DtElaborazione { get; set; }
        public string Record40 { get; set; }
        public string Record50 { get; set; }
        public string Record16 { get; set; }
        public string Record60 { get; set; }
    }
}
