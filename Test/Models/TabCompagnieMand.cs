using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCompagnieMand
    {
        public int IdCompagniaMand { get; set; }
        public string CodCompagniaMand { get; set; }
        public int? IdAnagraficaComp { get; set; }
        public int? IdAnagraficaRef { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string CodCompagniaUci { get; set; }
    }
}
