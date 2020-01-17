using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputDettErrWar
    {
        public decimal IdXmlInputDettErrWar { get; set; }
        public decimal IdXmlInputDett { get; set; }
        public string CodErroreWarning { get; set; }
        public string CoordinateTagErrato { get; set; }
        public decimal? AnnoSinistro { get; set; }
        public string NumeroSinistro { get; set; }
    }
}
