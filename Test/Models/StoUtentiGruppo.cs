using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoUtentiGruppo
    {
        public int IdUtenteGruppo { get; set; }
        public string CodGruppo { get; set; }
        public string FlgAreaGruppo { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public int? IdUtenteGruppoSup { get; set; }
        public int? IdFormula { get; set; }
        public int? LivelloVisibilitaDocumenti { get; set; }
        public string FlgEscludiDerogheSino { get; set; }
        public int? CodDerogaGruppo { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
        public int? LivelloAutorizzazione { get; set; }
    }
}
