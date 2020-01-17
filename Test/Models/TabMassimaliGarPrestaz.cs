using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMassimaliGarPrestaz
    {
        public int IdMassimale { get; set; }
        public int? IdGaranzia { get; set; }
        public int? IdPrestazione { get; set; }
        public string FlgTipoScoperto { get; set; }
        public int? NumAventiDiritto { get; set; }
        public decimal? ImpMassimale { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? PercScoperto { get; set; }
        public string FlgMassimalePerGgSino { get; set; }
        public string FlgDateRicoveroSino { get; set; }
        public int? MaxGgPreInizioRicovero { get; set; }
        public int? MaxGgPostFineRicovero { get; set; }
        public string FlgCatAgenziaEntrate { get; set; }
        public int? IdProdottoPolIntegrativa { get; set; }
        public int? IdGaranziaPolIntegrativa { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string FlgTicketObbSino { get; set; }
        public decimal? PercScopertoConTicket { get; set; }
        public decimal? PercScopertoSenzaTicket { get; set; }
        public string FlgFascia { get; set; }
        public decimal? ImpDiaria { get; set; }
        public int? NumGgFranchigia { get; set; }
        public string CodRaggruppamento { get; set; }
    }
}
