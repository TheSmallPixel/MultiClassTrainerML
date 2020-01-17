using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPrestazioni
    {
        public int IdPrestAssicurata { get; set; }
        public int IdBene { get; set; }
        public int IdGaranziaassicurata { get; set; }
        public int IdPrestazione { get; set; }
        public decimal? ImpMassimale { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? PercScoperto { get; set; }
        public string FlgTipoMassimalizzazione { get; set; }
        public int? IdPrestAssicurataPadre { get; set; }
        public decimal? ImpMassimaleNucleo { get; set; }
        public decimal? ImpFranchigiaNucleo { get; set; }
        public decimal? PercScopertoNucleo { get; set; }
    }
}
