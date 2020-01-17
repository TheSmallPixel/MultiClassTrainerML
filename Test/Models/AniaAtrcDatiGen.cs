using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrcDatiGen
    {
        public int KeyAniaAtrcDatiGen { get; set; }
        public int IdAniaAtrcDatiGen { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtInvio { get; set; }
        public string CodImpresaMittente { get; set; }
        public string TipoRecord { get; set; }
        public string CodImpresa { get; set; }
        public string FormatoIdentVeicolo { get; set; }
        public string IdentVeicolo { get; set; }
        public string TipoVeicolo { get; set; }
        public DateTime? DtScadenzaContratto { get; set; }
        public string IdentFiscaleContr { get; set; }
        public string TipoMovimento { get; set; }
        public string CausaleMovimento { get; set; }
        public string IdentFiscaleAvDiritto { get; set; }
        public string CodiceLegge { get; set; }
        public string NPolizza { get; set; }
        public string FormaTariffaria { get; set; }
        public int? NFranNonCorrisposte { get; set; }
        public decimal? ImpFranNonCorrisposte { get; set; }
        public string ClasseProvenienza { get; set; }
        public string ClasseAssegnazione { get; set; }
        public string ClasseProvenienzaCu { get; set; }
        public string ClasseAssegnazioneCu { get; set; }
        public string CampoLiberoImpresa { get; set; }
        public string CognomeRagSocContr { get; set; }
        public string NomeContraente { get; set; }
        public string CognomeRagSocAvDiritto { get; set; }
        public string NomeAvDiritto { get; set; }
        public string TipoAvDiritto { get; set; }
        public string NaturaAvDiritto { get; set; }
        public string FlgPolizzaGratuita { get; set; }
        public string FlgControlloMovimenti { get; set; }
        public string StringaAnomalie { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public string FlgDaReinviareSino { get; set; }
        public string CodiceIur { get; set; }
        public string TipoPolizza { get; set; }
    }
}
