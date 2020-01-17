using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfContrattiEmessi12Sez
    {
        public decimal IdContrattoEmesso { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? AnnoCompetenza { get; set; }
        public decimal? MeseCompetenza { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? KeyTitolo { get; set; }
        public decimal? KeyEvento { get; set; }
        public string FlgTipoEvento { get; set; }
        public DateTime? DtRegistrazioneEmesso { get; set; }
        public DateTime? DtRegistrazioneAnnullo { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtPervenimentoProposta { get; set; }
        public string NProposta { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public string CodfiscPiva { get; set; }
        public string FlgPeriodicitaPagamenti { get; set; }
        public string CodFrazionamento { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public DateTime? DtAnnullamentoPolizza { get; set; }
        public decimal? AnniDurataContratto { get; set; }
        public string FlgTipoOperazionePtf { get; set; }
        public string FlgOperazAnnullataSino { get; set; }
        public string FlgIfrs4Sino { get; set; }
        public string FlgFormaPensioneSino { get; set; }
        public string FlgTipoDelega { get; set; }
        public decimal? PercQuota { get; set; }
        public decimal? ProgressivoOrdine { get; set; }
        public string FlgQuietanzaPagataSino { get; set; }
        public string MatricolaRui { get; set; }
        public string FlgRamoBilancioPolizza { get; set; }
        public decimal? ProgressivoBene { get; set; }
        public string TargaTelaio { get; set; }
        public string CodTariffa { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? ImpNettoAnnuoFirma { get; set; }
        public decimal? ImpNettoAnnuoRateSucc { get; set; }
        public decimal? ImpNettoTitolo { get; set; }
        public string CodRamo { get; set; }
        public string CodProdotto { get; set; }
        public decimal? NumeroSezioneContratto { get; set; }
        public string CodTipoTitolo { get; set; }
        public decimal? ContaInteri { get; set; }
        public decimal? ContaQuota { get; set; }
        public DateTime? DtEffettoEvento { get; set; }
        public string CognomeRagioneSocialeAss { get; set; }
        public string CodfiscPivaAss { get; set; }
        public string DtSysEvento { get; set; }
        public int? AnnoCompetenzaEmesso { get; set; }
        public int? MeseCompetenzaEmesso { get; set; }
    }
}
