using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolApplicazioniEmi
    {
        public int IdPolizza { get; set; }
        public int IdPolBene { get; set; }
        public int IdTitTitolo { get; set; }
        public DateTime DtEffetto { get; set; }
        public string DtSysEvento { get; set; }
        public string FlgAnnullatoSino { get; set; }
        public int? IdUtente { get; set; }
    }
}
