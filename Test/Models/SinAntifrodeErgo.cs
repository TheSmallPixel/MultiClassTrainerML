using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinAntifrodeErgo
    {
        public int KeyAntifrodeErgo { get; set; }
        public int IdAntifrodeErgo { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgEntePrimaSegnalazione { get; set; }
        public int? IdCslRadicamento { get; set; }
        public DateTime? DtPrimaSegnalazione { get; set; }
        public int? IdProvResidenzaProprietario { get; set; }
        public int? IdRegResidenzaProprietario { get; set; }
        public string FlgAreaTerritoriale { get; set; }
        public int? IdReteVendita { get; set; }
        public int? AnnoRegistrazione { get; set; }
        public string NSinistro { get; set; }
        public string FlgMotoCiclomotoriSino { get; set; }
        public string FlgCardPrimaSpecifica { get; set; }
        public string FlgCardSecondaSpecifica { get; set; }
        public string FlgNoSinistroSino { get; set; }
        public DateTime? DtEvento { get; set; }
        public string Targa { get; set; }
        public string NPolizza { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTriage { get; set; }
        public string FlgSinistroFantasmaSino { get; set; }
        public string FlgSinistroSerialeSino { get; set; }
        public string SinistroSerialeNote { get; set; }
        public decimal? ImpIndennizziTrasferimento { get; set; }
        public decimal? ImpRiservaTrasferimento { get; set; }
        public decimal? ImpAfm { get; set; }
        public decimal? ImpCostiUlteriori { get; set; }
        public string NoteInvestigazioni { get; set; }
        public DateTime? DtInvestigazione { get; set; }
        public decimal? ImpInvestigazioni { get; set; }
        public int? IdFiduciarioCivilista { get; set; }
        public decimal? ImpCostoCivilista { get; set; }
        public int? IdFiduciarioPenale { get; set; }
        public decimal? ImpCostoPenalista { get; set; }
        public DateTime? DtIncaricoDenunciaQuerela { get; set; }
        public string FlgParteOffesa { get; set; }
        public string FlgParteCivile { get; set; }
        public int? NumeroParti { get; set; }
        public int? FlgEsitoArchiviazione { get; set; }
        public int? FlgEsitoAssoluzione { get; set; }
        public int? FlgEsitoCondanna { get; set; }
        public int? FlgEsitoAltro { get; set; }
        public string NoteEsitoAltro { get; set; }
        public decimal? ImpDifferenzialeRiserve { get; set; }
        public int IdCompagnia { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
