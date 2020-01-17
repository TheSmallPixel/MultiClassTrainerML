using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCoordinatoreReteDedicata
    {
        public int KeyCoordinatoreretededicata { get; set; }
        public int IdCoordinatoreretededicata { get; set; }
        public int IdDipartimento { get; set; }
        public int IdAnagrafica { get; set; }
        public int? IdIndirizzo { get; set; }
        public DateTime DtCoordinatoreDal { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
