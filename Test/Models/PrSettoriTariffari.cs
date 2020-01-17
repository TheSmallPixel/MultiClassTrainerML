using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrSettoriTariffari
    {
        public decimal KeyPrSettoreTariffario { get; set; }
        public decimal? IdPrSettoreTariffario { get; set; }
        public decimal? IdPrParametro { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public decimal? IdPrValParametro { get; set; }
        public decimal? IdPrVariapremio { get; set; }
        public decimal? IdPrSessoEta { get; set; }
        public decimal? IdPrPunteggio { get; set; }
        public decimal? IdSettore { get; set; }
        public decimal? IdClasse { get; set; }
        public decimal? IdUso { get; set; }
        public decimal? DaTecnico { get; set; }
        public decimal? ATecnico { get; set; }
        public string FlgFormaTariffaria { get; set; }
        public decimal? ImpPremioBase { get; set; }
        public decimal? PuntiBase { get; set; }
        public string FlgAmmessoSino { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? IdFormula { get; set; }
        public decimal? IdPrParametroClasseMerito { get; set; }
        public decimal? IdPrEvoluzioneBm { get; set; }
        public decimal? CoefTecnico { get; set; }
        public decimal? IdPrGruppoTerritoriale { get; set; }
        public decimal? IdPrClasseGruppoTer { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual TabClasse IdClasseNavigation { get; set; }
        public virtual TabSettore IdSettoreNavigation { get; set; }
        public virtual TabUso IdUsoNavigation { get; set; }
    }
}
