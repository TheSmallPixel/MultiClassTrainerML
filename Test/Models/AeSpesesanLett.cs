using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AeSpesesanLett
    {
        public int IdAeSpesesanLett { get; set; }
        public string CodiceFiscaleIscritto { get; set; }
        public int AnnoCompetenza { get; set; }
        public DateTime DtElaborazione { get; set; }
        public string LettCodiceFiscaleSoggetto { get; set; }
        public string LettNominativoSoggetto { get; set; }
        public string LettNumeroPratica { get; set; }
        public string LettNumeroFattura { get; set; }
        public DateTime? LettDtFattura { get; set; }
        public decimal? LettImpRichiesto { get; set; }
        public decimal? LettImpLiquidato { get; set; }
        public string CodModelloStampa { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Comune { get; set; }
        public string CodProvincia { get; set; }
        public string Presso { get; set; }
        public string FlgPraticaIntegrativaSino { get; set; }
    }
}
