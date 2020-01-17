using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabEsitiComunicazioni
    {
        public int IdTabEsitoComunicazione { get; set; }
        public int IdOggettoPrincipale { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoComunicazione { get; set; }
        public string FlgEsitoComunicazione { get; set; }
        public DateTime? DtComunicazione { get; set; }
        public string TimestampRichiesta { get; set; }
        public string TimestampEsito { get; set; }
        public string Dettaglio { get; set; }
        public int IdUtente { get; set; }
        public string FlgTipoOggettoPrincipale { get; set; }
    }
}
