using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AppoAnag
    {
        public decimal IdAnagrafica { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public string Nome { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }
        public string Cognome { get; set; }
        public string FlgSesso { get; set; }
        public string FlgTitoloOnorifico { get; set; }
        public DateTime? DtNascita { get; set; }
        public string ProvinciaNascita { get; set; }
        public string DescComuneNascita { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string DescComuneIndirizzo { get; set; }
        public string ProvinciaIndirizzo { get; set; }
        public string CodTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? DtRilascio { get; set; }
        public DateTime? DtScadenza { get; set; }
    }
}
