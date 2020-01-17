using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabSottoprestazioni
    {
        public int KeySottoprestazione { get; set; }
        public int? IdSottoprestazione { get; set; }
        public int? IdPrestazione { get; set; }
        public string CodSottoprestazione { get; set; }
        public string FlgTipoSottoprestazione { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTipologiaDanno { get; set; }
        public string FlgSelezionabileSino { get; set; }
        public string FlgCollegamentoSchedaDanno { get; set; }
        public string FlgImportoNegativoSino { get; set; }
    }
}
