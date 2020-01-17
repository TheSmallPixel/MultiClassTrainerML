using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolRca
    {
        public decimal KeyPolRca { get; set; }
        public decimal? IdPolRca { get; set; }
        public decimal? IdPolizza { get; set; }
        public string FlgMotivoAssicurazione { get; set; }
        public string FlgFormaTariffaria { get; set; }
        public string FlgClasseCompagnia { get; set; }
        public string FlgPejus { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgCartaVerdeSino { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string NumeroPolizzaProv { get; set; }
        public DateTime? DtScadenzaPolPrec { get; set; }
        public string CodFisPropLegge40 { get; set; }
        public string ClasseCuPropLegge40 { get; set; }
        public string FlgTipoVeicoloLegge40 { get; set; }
        public string FlgTipoTargaLegge40 { get; set; }
        public string TargaLegge40 { get; set; }
        public string TargaAtr { get; set; }
        public int? IdNazioneImmLegge40 { get; set; }
        public int? IdNazioneImmAtr { get; set; }
        public string ClasseCuLegge40Ibdv { get; set; }
        public string FlgTipoTargaAtr { get; set; }
        public string FlgTipoVeicoloAtr { get; set; }
        public string CodiceIur { get; set; }
        public string CfPivaAtrDivVeic { get; set; }
        public string CodIurAtrDivVeic { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
