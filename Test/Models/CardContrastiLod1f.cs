using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardContrastiLod1f
    {
        public int IdCardContrastoLod1f { get; set; }
        public int? IdCardContrasto1f { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdFunzioneSinistro { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgStatoFinale { get; set; }
        public string FlgDefinitiPerScadenzaSino { get; set; }
        public string FlgRuoloRichiestaCompagnia { get; set; }
        public DateTime? DtInizioLodo { get; set; }
        public DateTime? DtFineLodo { get; set; }
        public DateTime? DtElaborazione { get; set; }
    }
}
