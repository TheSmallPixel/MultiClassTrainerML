using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGruppiVariabili
    {
        public decimal KeyPrGruppoVariabili { get; set; }
        public decimal IdPrGruppoVariabili { get; set; }
        public decimal IdDescrizioneGruppo { get; set; }
        public decimal? IdDescrizioneBottone { get; set; }
        public string FlgInPaginaSino { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string CodGruppo { get; set; }
        public string DescrizioneGruppo { get; set; }
        public string DescrizioneBottone { get; set; }
        public string FlgTipoEntitaVar { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
    }
}
