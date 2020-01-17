using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabComuniIstat
    {
        public string CodRegione { get; set; }
        public string CodUnitaTerr { get; set; }
        public string CodProvStorico { get; set; }
        public string ProgrComune { get; set; }
        public string CodComuneAlfanum { get; set; }
        public string DescItaNoita { get; set; }
        public string DescIta { get; set; }
        public string DescAltro { get; set; }
        public int? CodRipartizione { get; set; }
        public string DescRipartizione { get; set; }
        public string DescRegione { get; set; }
        public string DescProvincia { get; set; }
        public int? FlgCapoluogo01 { get; set; }
        public string SiglaProv { get; set; }
        public int? CodComuneNumerico { get; set; }
        public int? CodComuneNumerico110 { get; set; }
        public int? CodComuneNumerico107 { get; set; }
        public int? CodComuneNumerico103 { get; set; }
        public string CodCatastale { get; set; }
        public double? NrAbitanti { get; set; }
        public string Nuts1 { get; set; }
        public string Nuts2 { get; set; }
        public string Nuts3 { get; set; }
    }
}
