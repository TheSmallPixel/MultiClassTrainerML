using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RispostaSicSinistri
    {
        public int IdSinistroSic { get; set; }
        public int? IdRispostaSic { get; set; }
        public string DenuncianteControparte { get; set; }
        public int? CodiceCompagnia { get; set; }
        public int? CodiceUfficio { get; set; }
        public string TipoVeicolo { get; set; }
        public string NumeroSinistro { get; set; }
        public string TipoTargaControparte { get; set; }
        public string TargaControparte { get; set; }
        public string TipoVeicoloControparte { get; set; }
        public DateTime? DataSinistro { get; set; }
        public string TipoResponsabilita { get; set; }
        public int? CodiceCompagniaDebitrice { get; set; }
        public int? CodiceImpresaControparte { get; set; }
        public int? CodiceUfficioControparte { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string FlgMandatarioDebitore { get; set; }
    }
}
