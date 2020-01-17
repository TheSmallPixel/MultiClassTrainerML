using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfVariapremi
    {
        public int KeyVariapremio { get; set; }
        public int? IdVariapremio { get; set; }
        public int? IdGaranziaassicurata { get; set; }
        public string CodVariapremio { get; set; }
        public string DescVariapremio { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
