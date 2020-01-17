using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiGruppo
    {
        public decimal IdUtenteGruppo { get; set; }
        public string CodGruppo { get; set; }
        public string FlgAreaGruppo { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public decimal? IdUtenteGruppoSup { get; set; }
        public decimal? IdFormula { get; set; }
        public int? LivelloVisibilitaDocumenti { get; set; }
        public int? CodDerogaGruppo { get; set; }
        public string FlgEscludiDerogheSino { get; set; }
        public int? LivelloAutorizzazione { get; set; }
    }
}
