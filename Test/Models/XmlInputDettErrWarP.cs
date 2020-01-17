using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputDettErrWarP
    {
        public decimal IdXmlInputDettErrWar { get; set; }
        public decimal IdXmlInputDett { get; set; }
        public string CodErroreWarning { get; set; }
        public string CoordinateTagErrato { get; set; }
        public string NumeroPolizza { get; set; }
        public decimal IdProdotto { get; set; }
        public decimal? IdRetevendita { get; set; }
    }
}
