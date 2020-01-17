using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BpFlussi
    {
        public int IdBpFlusso { get; set; }
        public int IdCompagnia { get; set; }
        public int ProgrFlusso { get; set; }
        public string NomeFlusso { get; set; }
        public string FlgEnteErogatore { get; set; }
        public string DtEstrazioneDal { get; set; }
        public string DtEstrazioneAl { get; set; }
        public int IdUtenteCreazione { get; set; }
        public DateTime DtCreazione { get; set; }
        public int? IdUtenteInvio { get; set; }
        public DateTime? DtInvio { get; set; }
        public string FlgStatoFlusso { get; set; }
    }
}
