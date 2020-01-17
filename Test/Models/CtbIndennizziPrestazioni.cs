using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbIndennizziPrestazioni
    {
        public int KeyIndennizzoprestazione { get; set; }
        public int IdIndennizzoprestazione { get; set; }
        public int? IdIndennizzo { get; set; }
        public int IdGaranziacolpita { get; set; }
        public int IdPrestazione { get; set; }
        public int IdSottoprestazione { get; set; }
        public decimal? Importo { get; set; }
        public int IdValuta { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdQuietanza { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public int? IdDanno { get; set; }
    }
}
