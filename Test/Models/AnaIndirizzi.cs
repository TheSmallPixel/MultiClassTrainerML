using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaIndirizzi
    {
        public decimal KeyIndirizzo { get; set; }
        public decimal IdIndirizzo { get; set; }
        public decimal? IdComune { get; set; }
        public decimal? IdProvincia { get; set; }
        public decimal? IdNazione { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Localita { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoIndirizzo { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Presso { get; set; }
        public string FlgPrincipaleSino { get; set; }
        public string FlgPrefToponomastico { get; set; }
        public string Toponimo { get; set; }
        public string Civico { get; set; }
        public decimal? Latitudine { get; set; }
        public decimal? Longitudine { get; set; }
    }
}
