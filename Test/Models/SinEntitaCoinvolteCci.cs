using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaCoinvolteCci
    {
        public decimal KeyEntitacoinvoltacci { get; set; }
        public decimal IdEntitacoinvoltacci { get; set; }
        public DateTime? DtAccertamentiPostumi { get; set; }
        public DateTime? DtDecesso { get; set; }
        public string FlgNaturaLesione1 { get; set; }
        public string FlgSedeLesione1 { get; set; }
        public string FlgNaturaLesione2 { get; set; }
        public string FlgSedeLesione2 { get; set; }
        public string FlgNaturaLesione3 { get; set; }
        public string FlgSedeLesione3 { get; set; }
        public string FlgUlterioriLesioniSino { get; set; }
        public string FlgDannoBiologicoSino { get; set; }
        public string FlgTipoGestione { get; set; }
        public string FlgProfessione { get; set; }
        public string FlgCausaInfortunio { get; set; }
        public string FlgGruppoAgenteMateriale { get; set; }
        public string FlgCategoriaAgenteMateriale { get; set; }
        public string FlgAzioneCci { get; set; }
        public string FlgMotivoAnnullamento { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string IdentificativoSinistroMigr { get; set; }
        public string IdentificativoPartDannoMigr { get; set; }
    }
}
