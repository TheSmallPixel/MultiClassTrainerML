using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolContratto
    {
        public decimal KeyPolContratto { get; set; }
        public decimal? IdPolContratto { get; set; }
        public decimal IdPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public DateTime? DtEffettoRata { get; set; }
        public DateTime? DtScadenzaRata { get; set; }
        public decimal IdAgenzia { get; set; }
        public decimal? IdProduttore { get; set; }
        public string FlgDurata { get; set; }
        public string FlgTacRinnovoSino { get; set; }
        public decimal IdFrazionamento { get; set; }
        public decimal? MmDurataProroga { get; set; }
        public string FlgTipoCoass { get; set; }
        public string FlgModProv { get; set; }
        public string FlgEsentasseSino { get; set; }
        public string FlgTipoIndiciz { get; set; }
        public DateTime? DtIndicizzazione { get; set; }
        public decimal? IdSostituente { get; set; }
        public string FlgRegPremioSino { get; set; }
        public DateTime? DtProssimaRegolazione { get; set; }
        public decimal? MesiRegolazione { get; set; }
        public DateTime? DtAppendice { get; set; }
        public decimal? PrgAppendice { get; set; }
        public decimal? IdConvenzione { get; set; }
        public string NDocumento { get; set; }
        public decimal PctAccessori { get; set; }
        public decimal ImpNetto { get; set; }
        public decimal ImpTasse { get; set; }
        public decimal ImpLordo { get; set; }
        public decimal IdValuta { get; set; }
        public decimal? ImpScontiAumento { get; set; }
        public string FlgMezzoIncassoPolizza { get; set; }
        public decimal? IdPagatore { get; set; }
        public decimal? IdContocorrente { get; set; }
        public decimal? IdCartacredito { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public decimal? ImpAccessoriFissi { get; set; }
        public string FlgContrattoCedutoSino { get; set; }
        public DateTime? DtScaMoraAttuale { get; set; }
        public DateTime? DtScaMoraFutura { get; set; }
        public int? NumLimiteInclusioni { get; set; }
        public int? PrgLimiteInclusioni { get; set; }
        public int? IdPlafond { get; set; }
        public DateTime? DtInizioAnnualita { get; set; }
        public DateTime? DtFineAnnualita { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
