using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoProfili
    {
        public int IdProfilo { get; set; }
        public string CodProfilo { get; set; }
        public int IdDescrizione { get; set; }
        public string Note { get; set; }
        public int? IdProfiloSuperiore { get; set; }
        public string FlgTipoRuoloUtenteVis { get; set; }
        public int? IdAppartenenzaVis { get; set; }
        public string FlgTrattaDatiSensibiliSino { get; set; }
        public string Descrizione { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
        public string FlgAbilScadPolCrusSino { get; set; }
    }
}
