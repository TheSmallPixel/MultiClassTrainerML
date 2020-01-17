using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabSpeseOutsourcing
    {
        public int IdTabSpesaOutsourcing { get; set; }
        public int IdCompagnia { get; set; }
        public int IdFiduciario { get; set; }
        public string FlgTipologiaDanno { get; set; }
        public string FlgTipoCardCompagnia { get; set; }
        public string FlgFirmaCai { get; set; }
        public string FlgRamiBilancioAmmessi { get; set; }
        public string FlgInvPermanenteSino { get; set; }
        public string FlgOltreSogliaSino { get; set; }
        public string FlgSogliaPagatoSino { get; set; }
        public string FlgSogliaRiservaSino { get; set; }
        public string FlgPerPartitaSino { get; set; }
        public string FlgAccadimentoEsteroSino { get; set; }
        public decimal ImpSpesa { get; set; }
        public decimal? ImpSogliaMax { get; set; }
        public DateTime DtStatoDal { get; set; }
        public DateTime DtStatoAl { get; set; }
        public string Descrizione { get; set; }
        public string FlgTipologiaGestioneDanno { get; set; }
        public string FlgTipoRuoloCoinvolto { get; set; }
        public string FlgVeicoloPolizzaSino { get; set; }
        public string CodRegola { get; set; }
        public string EsclusaDa { get; set; }
    }
}
