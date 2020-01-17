using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfScadenzeAlert
    {
        public int IdScadenzaAlert { get; set; }
        public int? IdCompagnia { get; set; }
        public string FlgTipoAttivitaOrigine { get; set; }
        public int GiorniAlert { get; set; }
        public string FlgLivelloAlert { get; set; }
        public string CodOperazione { get; set; }
    }
}
