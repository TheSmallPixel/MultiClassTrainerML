using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPrestMedicoChirurgiche
    {
        public int KeyPrestazione { get; set; }
        public int IdPrestazione { get; set; }
        public string CodiceTabella { get; set; }
        public string FlgGruppoPrestMedChir { get; set; }
        public string FlgSottogruppoPrMedChir { get; set; }
        public string CodPrestazioneMedChir { get; set; }
        public string DescPrestazioneMedChir { get; set; }
        public int? IdGruppoIntervento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string Edizione { get; set; }
        public int? IdEdizione { get; set; }
        public string CodGruppoIntervento { get; set; }
    }
}
