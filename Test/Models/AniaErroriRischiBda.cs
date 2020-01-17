using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaErroriRischiBda
    {
        public int KeyErroriRischiBda { get; set; }
        public int IdErroriRischiBda { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string FlgScarto { get; set; }
        public string FlgWarning { get; set; }
        public string Errori { get; set; }
        public int? Anno { get; set; }
        public string IdentificativoRischio { get; set; }
        public string CodTipoPolizza { get; set; }
        public DateTime? DtInizioCopertura { get; set; }
        public DateTime? DtScadenzaCopertura { get; set; }
        public string TipoVeicolo { get; set; }
        public string TipoTarga { get; set; }
        public string Targa { get; set; }
        public string CodSettore { get; set; }
        public string CodClasse { get; set; }
        public string CodUso { get; set; }
        public int? ImpMaxCose { get; set; }
        public int? ImpMaxPersone { get; set; }
        public string TipoTariffa { get; set; }
        public string CodRateazione { get; set; }
        public int? ImpFranchigia { get; set; }
        public string CodLimitazione { get; set; }
        public string CodEstensione { get; set; }
        public string SessoSoggTariffato { get; set; }
        public DateTime? DtNascitaSoggTariffato { get; set; }
        public string ProvResSoggTariffato { get; set; }
        public string CapResSoggTariffato { get; set; }
        public int? ValoreVeicolo { get; set; }
        public string CodScatolaNera { get; set; }
        public string CodTipoGuida { get; set; }
        public string CodClausolaCarrConv { get; set; }
        public string CodFurto { get; set; }
        public string CodIncendio { get; set; }
        public string CodKasko { get; set; }
    }
}
